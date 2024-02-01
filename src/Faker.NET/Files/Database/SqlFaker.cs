using System.Text.RegularExpressions;

namespace Faker.NET.Files.Sql
{
    public class SqlFaker
    {
        public Stream BaseStream { get; private set; }

        public SqlFaker(Stream stream)
        {
            if (!stream.CanWrite)
            {
                throw new Exception("Unable to write to stream");
            }

            BaseStream = stream;
        }

        public SqlFaker AddTable(string tableName, SqlTableFaker fields)
        {
            if (_tables.ContainsKey(tableName))
            {
                throw new Exception($"Table already exists in cache: {tableName}");
            }

            _tables.Add(tableName, fields);
            return this;
        }

        public SqlFaker CreateInsert(string tableName, int iterations = 500)
        {
            if (!_tables.ContainsKey(tableName))
            {
                throw new Exception($"Table not in cache: {tableName}");
            }

            return this;
        }

        private readonly Dictionary<string, SqlTableFaker> _tables = new Dictionary<string, SqlTableFaker>();
    }

    public class SqlTableFaker
    {
        /// <summary>
        /// Create a field generator for a field of the given type name. Using the same name multiple times will overwrite the current value.
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="dataGenerator"></param>
        public bool TryAddField(string fieldName, string fieldType, Func<string> dataGenerator, bool isPrimaryKey = false)
        {
            if (!IsValidFieldType(fieldType))
            {
                return false;
            }

            if (isPrimaryKey && !string.IsNullOrWhiteSpace(fieldName))
            {
                throw new Exception("Primary key has already been defined for this table");
            }

            _dataGenerators[fieldName] = (fieldType, dataGenerator);
            return true;
        }

        private static bool IsValidFieldType(string type)
        {
            return IsValidNumericType(type) || IsValidStringType(type) || IsValidDateTimeType(type) || IsValidOtherType(type);
        }

        private static bool IsValidStringType(string type)
        {
            return _variableLengthStringTypes.IsMatch(type) || _maxLengthStringTypes.IsMatch(type) || _otherStringTypes.IsMatch(type);
        }

        private static bool IsValidNumericType(string type)
        {
            return _fixedNumericTypes.IsMatch(type) || _precisionNumericTypes.IsMatch(type) || _variableNumericTypes.IsMatch(type);
        }

        private static bool IsValidDateTimeType(string type)
        {
            return _dateTimeTypes.IsMatch(type);
        }

        private static bool IsValidOtherType(string type)
        {
            return _otherDataTypes.IsMatch(type);
        }

        private static readonly Regex _variableLengthStringTypes = new Regex(@"^(?:char|varchar|binary)\(\d+\)$");
        private static readonly Regex _maxLengthStringTypes = new Regex(@"^(?:varchar|nvarchar|varbinary)\(max\)$");
        private static readonly Regex _otherStringTypes = new Regex(@"^text|nchar|nvarchar|ntext|varbinary|image$");

        private static readonly Regex _fixedNumericTypes = new Regex(@"^bit|tinyint|smallint|int|bigint|money|real$");
        private static readonly Regex _precisionNumericTypes = new Regex(@"^(?:decimal|numeric)\(\d+,\d+\)");
        private static readonly Regex _variableNumericTypes = new Regex(@"^float\(\d+\)");

        private static readonly Regex _dateTimeTypes = new Regex(@"^datetime|datetime2|smalldatetime|date|time|datetimeoffset|timestamp$");

        private static readonly Regex _otherDataTypes = new Regex(@"^sql_variant|uniqueidentifier|xml|cursor|table$");

        private readonly Dictionary<string, (string Type, Func<string> Generator)> _dataGenerators = new Dictionary<string, (string Type, Func<string> Generator)>();
        private string _primaryKey = null;
    }
}
