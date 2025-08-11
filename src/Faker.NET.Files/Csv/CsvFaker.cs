using System;
using Faker.NET.Attributes;
using Faker.NET.Common.Exceptions;

namespace Faker.NET.Files.Csv;

public class CsvFaker : IDisposable
{
    public static CsvFaker ToFile(string path)
    {
        ThrowHelper.IfNullOrEmpty(path, $"{nameof(CsvFaker)} file path cannot be null or empty.");

        return new CsvFaker(System.IO.File.Open(path, new FileStreamOptions
        {
            Mode = FileMode.OpenOrCreate,
            Access = FileAccess.ReadWrite,
        }));
    }

    public static CsvFaker ToStream(Stream stream)
    {
        return new CsvFaker(stream);
    }

    private CsvFaker(Stream stream)
    {
        ThrowHelper.IfNotWritable(stream);
        _stream = new StreamWriter(stream);
    }

    /// <summary>
    /// Change the delimiter to whatever best suits your uses
    /// </summary>
    /// <param name="delimiter"></param>
    /// <returns></returns>
    public CsvFaker WithDelimiter(char delimiter)
    {
        _delimiter = delimiter;
        return this;
    }

    /// <summary>
    /// Generate a csv based on a type. Properties to have data generated must use an attribute that extends <see cref="FakerAttribute"/>
    /// </summary>
    /// <typeparam name="T">Type to generate csv from</typeparam>
    /// <returns></returns>
    public CsvFaker FromClass<T>()
    {
        var type = typeof(T);

        foreach (var prop in type.GetProperties())
        {
            var attrs = prop.GetCustomAttributes(typeof(FakerAttribute), true) as FakerAttribute[] ??
                        throw new Exception();

            foreach (var attr in attrs)
            {
                _columnMetadata.Add(prop.Name, () => attr.GetPropertyValue().ToString() ?? string.Empty);
            }
        }

        return this;
    }

    public CsvFaker WithColumns(Dictionary<string, Func<string>> columns)
    {
        foreach (var key in columns.Keys)
        {
            _columnMetadata[key] = columns[key];
        }
        return this;
    }

    public CsvFaker WithRowCount(uint rowCount)
    {
        _rowCount = rowCount;
        return this;
    }

    public void Write(bool keepStreamOpen = false)
    {
        var headers = _columnMetadata.Keys.ToArray();
        var headerCount = headers.Length - 1;
        var row = new string[headerCount];
        WriteRow(headers);

        for (var i = 0; i < _rowCount; i++)
        {
            for (var j = 0; j < headerCount; j++)
            {
                row[j] = _columnMetadata[headers[j]]();
            }

            WriteRow(row);
        }

        if (keepStreamOpen)
        {
            _stream.Flush();
        }
        else
        {
            _stream.Close();
        }
    }

    public void Dispose()
    {
        try
        {
            _stream.Dispose();
        }
        finally
        {
            GC.SuppressFinalize(this);
        }
    }

    ~CsvFaker()
    {
        _stream.Dispose();
    }

    private void WriteRow(string[] values)
    {
        _stream.WriteLine(string.Join(_delimiter, values));
    }

    private char _delimiter = ',';
    private uint _rowCount = 500;
    private readonly StreamWriter _stream;
    private readonly Dictionary<string, Func<string>> _columnMetadata = new Dictionary<string, Func<string>>();
}
