using System.Data.SQLite;

namespace Faker.NET.Files.Database
{
	public class DatabaseFaker
	{
		public int Count { get; private set; } = 100;

		public DatabaseFaker(string dbName, string outputPath)
		{
			SQLiteConnection.CreateFile(dbName);
			_dbConnection = new SQLiteConnection($"Data Source={dbName}");
			_dbConnection.Open();

			_outputPath = outputPath;
		}

		/// <summary>
		/// Add a table and it's corresponding fields
		/// </summary>
		/// <param name="tableName">Name of the table to be created</param>
		/// <param name="tableParams">Key is the name of the field and the value is the type of the field</param>
		/// <returns>the current instance of <see cref="DatabaseFaker"/></returns>
		public DatabaseFaker AddTable(string tableName, params KeyValuePair<string, string>[] tableParams)
		{
			var paramsList = tableParams.Select(x => $"{x.Key} {x.Value}");
			var createTableCommand = _dbConnection.CreateCommand();
			createTableCommand.CommandText = $"CREATE TABLE {tableName} ({string.Join(',', paramsList)})";
			createTableCommand.ExecuteNonQuery();

			_tableTracker.Add(new DatabaseTableTracker
			{
				TableName = tableName,
				TableFields = tableParams.ToDictionary(x => x.Key, y => y.Value)
			});

			return this;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="tableName"></param>
		/// <param name="fieldGenerators"></param>
		/// <returns></returns>
		/// <exception cref="Exception"></exception>
		public DatabaseFaker AddFieldFun(string tableName, params KeyValuePair<string, Func<object>>[] fieldGenerators)
		{
			var table = _tableTracker.FirstOrDefault(x => x.TableName.Equals(tableName));

			if (table is null)
			{
				throw new Exception($"Table has not been created yet: {tableName}");
			}

			foreach (var generator in fieldGenerators)
			{
				if (table.TableFields.ContainsKey(generator.Key))
				{
					table.TableFieldFaker.Add(generator.Key, generator.Value);
				}
				else
				{
					throw new InvalidDataException($"Unable to add func for {generator.Key} because the table does not contain that value");
				}
			}

			return this;
		}

		public DatabaseFaker RowCount(int value)
		{
			Count = value;
			return this;
		}

		public bool Generate()
		{
			var count = Count;

			foreach (var table in _tableTracker)
			{
				GenerateTable(table, count);
			}

			return true;
		}

		private void GenerateTable(DatabaseTableTracker table, int count)
		{
			while (count-- > 0)
			{

			}
		}

		private List<DatabaseTableTracker> _tableTracker = new List<DatabaseTableTracker>();
		private SQLiteConnection _dbConnection;
		private string _outputPath;
	}

	internal class DatabaseTableTracker
	{
		public string TableName { get; set; }

		public Dictionary<string, string> TableFields { get; set; }

		public Dictionary<string, Func<object>> TableFieldFaker { get; set; }
	}
}

