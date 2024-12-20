﻿using Faker.NET.Attributes;

namespace Faker.NET.Files.Csv
{
    public class CsvFaker
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CsvFaker()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="outputFile">Opens stream to write to</param>
        public CsvFaker(string outputFile)
        {
            BaseStream = File.Open(outputFile, new FileStreamOptions
            {
                Mode = FileMode.OpenOrCreate,
                Access = FileAccess.ReadWrite,
            });
        }

        /// <summary>
        /// Stream that can be written to for output
        /// </summary>
        /// <param name="stream">The stream (must have write permissions)</param>
        /// <exception cref="Exception"></exception>
        public CsvFaker(Stream stream)
        {
            if (!stream.CanWrite)
            {
                throw new Exception("Unable to write to stream");
            }

            BaseStream = stream;
        }

        public Stream BaseStream { get; private set; }

        /// <summary>
        /// Change the delimiter to whatever best suits your uses
        /// </summary>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public CsvFaker UpdateDelimiter(char delimiter)
        {
            _delimiter = delimiter;
            return this;
        }

        /// <summary>
        /// Builder way to add columns and functions to perform based on headers
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public CsvFaker AddColumn(string columnName, Func<string> func)
        {

            _headers.Add(columnName, func);
            return this;
        }

        /// <summary>
        /// Adds a column header and the static value that will be put in the rows
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public CsvFaker AddColumn(string columnName, string value)
        {
            _headers.Add(columnName, () => value);
            return this;
        }

        /// <summary>
        /// Amount of rows to be generated when <see cref="Generate"/> or <see cref="Generate{T}"/> are called
        /// </summary>
        /// <returns></returns>
        public uint GetRowCount()
        {
            return _rowsCountToGenerate;
        }

        /// <summary>
        /// Generate a csv based on a type. Requires use of <see cref="CsvMapAttribute"/>
        /// </summary>
        /// <typeparam name="T">Type to generate csv from</typeparam>
        /// <returns></returns>
        public IEnumerable<string> Generate<T>()
        {
            var type = typeof(T);

            foreach (var prop in type.GetProperties())
            {
                var attrs = prop.GetCustomAttributes(typeof(FakerAttribute), true) as FakerAttribute[];

                foreach (var attr in attrs)
                {
                    _headers.Add(prop.Name, () => attr.GetPropertyValue().ToString());
                }
            }

            return Generate();
        }

        public IEnumerable<string> Generate<T>(T classInstance)
        {
            var type = classInstance.GetType();

            foreach (var prop in type.GetProperties())
            {
                _headers.Add(prop.Name, () => (string)prop.GetValue(classInstance));
            }

            return Generate();
        }

        /// <summary>
        /// Defaults to 10 can update to any uint value
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public CsvFaker Iterations(uint count)
        {
            _rowsCountToGenerate = count;
            return this;
        }

        /// <summary>
        /// Generate a single row with no headers
        /// </summary>
        /// <returns></returns>
        public string GenerateRow()
        {
            var output = new List<string>();

            foreach ((var header, var func) in _headers)
            {
                var val = func();
                if (val.IndexOf(',') != -1)
                {
                    output.Add($"\"{val}\"");
                }
                else
                {
                    output.Add(val);
                }
            }

            return JoinColumns(output);
        }

        /// <summary>
        /// Generates the entire csv (headers and rows).
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Generate()
        {
            yield return JoinColumns(_headers.Keys);

            var count = 0;

            while (count++ < _rowsCountToGenerate)
            {
                yield return GenerateRow();
            }
        }

        /// <summary>
        /// Outputs the data to the <see cref="BaseStream"/>
        /// </summary>
        public void WriteRows()
        {
            using (var streamWriter = new StreamWriter(BaseStream))
            {
                foreach (var line in Generate())
                {
                    streamWriter.WriteLine(line);
                }
            }
        }

        /// <summary>
        /// Clears the headers and value creating funcs. Allows to start fresh.
        /// </summary>
        /// <returns></returns>
        public bool Clear()
        {
            _headers = new();

            return _headers.Count == 0;
        }

        private string JoinColumns(IEnumerable<string> input)
        {
            return string.Join(_delimiter, input);
        }

        ~CsvFaker()
        {
            BaseStream?.Dispose();
        }

        private Dictionary<string, Func<string>> _headers = new();
        private uint _rowsCountToGenerate = 10;
        private char _delimiter = ',';
    }
}

