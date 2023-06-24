namespace Faker.NET.Files.Csv
{
	public class CsvFaker
	{
		public CsvFaker()
		{
		}

		public CsvFaker(string outputFile)
		{
			BaseStream = File.Open(outputFile, new FileStreamOptions
			{
				Mode = FileMode.OpenOrCreate,
				Access = FileAccess.ReadWrite,
			});
		}

		public CsvFaker(Stream stream)
		{
			if (!stream.CanWrite)
			{
				throw new Exception("Unable to write to stream");
			}

			BaseStream = stream;
		}

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

		public CsvFaker AddColumn(string columnName, string value)
		{
			_headers.Add(columnName, () => value);
			return this;
		}

		public uint GetRowCount()
		{
			return _rowsCountToGenerate;
		}

		/// <summary>
		/// Defaults to 10 can update to any uint value
		/// </summary>
		/// <param name="count"></param>
		/// <returns></returns>
		public CsvFaker UpdateRowCount(uint count)
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

		public IEnumerable<string> GenerateRows(uint rowCount = 10)
		{
			if (rowCount != 10)
			{
				UpdateRowCount(rowCount);
			}

			yield return JoinColumns(_headers.Keys);

			var count = 0;

			while (count++ < _rowsCountToGenerate)
			{
				yield return GenerateRow();
			}
		}

		public void WriteRows(uint rowCount = 10)
		{
			if (rowCount != 10)
			{
				UpdateRowCount(rowCount);
			}

			using (var streamWriter = new StreamWriter(BaseStream))
			{
				foreach (var line in GenerateRows(rowCount))
				{
					streamWriter.WriteLine(line);
				}
			}
		}

		/// <summary>
		/// TODO: Create a way to get properties from an object and take a
		/// delegate to create a csv from a type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public IEnumerable<string> Generate<T>()
		{
			return Enumerable.Empty<string>();
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

		public Stream BaseStream { get; private set; }
	}
}

