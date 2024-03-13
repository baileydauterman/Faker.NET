using Faker.NET.Common;
using System.Data;
using System.Text;

namespace Faker.NET.Files.Sql
{
    public class SqlFaker
    {
        public SqlFaker(string outputFilePath)
        {
            BaseStream = File.Open(outputFilePath, new FileStreamOptions
            {
                Mode = FileMode.OpenOrCreate,
                Access = FileAccess.ReadWrite,
            });
        }

        public SqlFaker(Stream stream)
        {
            if (!stream.CanWrite)
            {
                throw new Exception("Unable to write to input stream");
            }

            BaseStream = stream;
        }

        public SqlFaker SetTable(string table)
        {
            Table = table;
            return this;
        }

        public SqlFaker AddTableColumn(string columnName, SqlDbType type, Func<string> dataGenerator)
        {
            if (!_tableRowGenerators.ContainsKey(columnName))
            {
                _tableRowGenerators.Add(columnName, (dataGenerator, type));
            }

            return this;
        }

        public SqlFaker AddTableColumn(string columnName, string value, SqlDbType type)
        {
            if (!_tableRowGenerators.ContainsKey(columnName))
            {
                _tableRowGenerators.Add(columnName, (() => value, type));
            }

            return this;
        }

        /// <summary>
        /// Allows the user to specify a set collection of data to randomly select from
        /// </summary>
        /// <param name="columnName">Column name that the column generator belongs to</param>
        /// <param name="dataValues">Values to randomly choose from</param>
        /// <returns>The instance of the SqlFaker</returns>
        public SqlFaker AddTableColumn(string columnName, IList<string> dataValues, SqlDbType type)
        {
            if (!_tableRowGenerators.ContainsKey(columnName))
            {
                _tableRowGenerators.Add(columnName, (() => dataValues.GetRandom(), type));
            }

            return this;
        }

        public SqlFaker Iterations(uint count)
        {
            _generateCount = count;
            return this;
        }

        public void Write()
        {
            if (string.IsNullOrWhiteSpace(DbName))
            {
                throw new ArgumentNullException(nameof(DbName));
            }

            if (string.IsNullOrWhiteSpace(Table))
            {
                throw new ArgumentNullException(nameof(Table));
            }

            if (BaseStream is null || !BaseStream.CanWrite)
            {
                throw new Exception("BaseStream is null or unable to be written to");
            }

            using (var streamWriter = new StreamWriter(BaseStream))
            {
                streamWriter.Write($"INSERT INTO {DbName} ");
                streamWriter.WriteLine($"({string.Join(", ", _tableRowGenerators.Keys)})");
                streamWriter.WriteLine($"VALUES");

                for (var i = 0; i < _generateCount; i++)
                {
                    var fakedData = new string[_tableRowGenerators.Keys.Count];
                    var index = 0;
                    var stringBuilder = new StringBuilder();

                    foreach ((var generator, var type) in _tableRowGenerators.Values)
                    {
                        var generatedValue = generator.Invoke();
                        fakedData[index++] = ShouldWrapInQuotes(type) ? $"'{generatedValue}'" : $"{generatedValue}";
                    }

                    var suffix = i == _generateCount - 1 ? ");" : "),";
                    streamWriter.WriteLine($"({string.Join(", ", fakedData)}{suffix}");
                }
            }
        }

        private bool ShouldWrapInQuotes(SqlDbType type)
        {
            return type == SqlDbType.Text || type == SqlDbType.Char ||
                   type == SqlDbType.VarChar || type == SqlDbType.NVarChar;
        }

        public string DbName { get; set; }

        public string Table { get; set; }

        public Stream BaseStream { get; }

        private Dictionary<string, (Func<string> Generator, SqlDbType Type)> _tableRowGenerators = new Dictionary<string, (Func<string> Generator, SqlDbType Type)>();

        private uint _generateCount = 50;
    }
}
