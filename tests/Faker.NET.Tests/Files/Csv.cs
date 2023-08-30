using Faker.NET.Files.Csv;
using Faker.NET.EN;
using Faker.NET.EN.Computer;
using Faker.NET.EN.Date;
using Faker.NET.EN.Names;

namespace Faker.NET.Tests.Files
{
	public class Csv
	{
		[Test]
		public void GenerateCsv()
		{
			// using the static first name here will generate the same same for every row
			// use () => Name.FirstName to turn this into a func.
			var faker = CreateFaker();

			// Generate a single row
			var value = faker.GenerateRow();

			// default 10 rows
			var values = faker.Generate();

			// 10 rows and 1 header row
			Assert.That(values.Count(), Is.EqualTo(11));

			values = faker.Iterations(25).Generate();

			// 25 rows and 1 header row
			Assert.That(values.Count(), Is.EqualTo(26));
		}

		[Test]
		[TestCase(100_000)]
		[TestCase(200_000)]
		[TestCase(1_000_000)]
		public void GenerateMassiveRows(int rowCount)
		{
			var faker = CreateFaker().Iterations((uint)rowCount);

			faker.Generate();
		}

		[Test]
		public void GenerateFileFromPath()
		{
			var tempPath = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());

			var faker = CreateFaker(tempPath);
			faker.WriteRows();

			ICollection<string> lines = new List<string>();

			using (var file = File.OpenRead(tempPath))
			using (var reader = new StreamReader(file))
			{
				while (!reader.EndOfStream)
				{
					lines.Add(reader.ReadLine());
				}
			}

			Assert.That(lines.Count, Is.EqualTo(11));

			File.Delete(tempPath);
		}

		[Test]
		public void GenerateFileFromStreamReadError()
		{
			var tempPath = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());

			using (var stream = File.OpenRead(tempPath))
			{
				Assert.Throws<Exception>(() => CreateFaker(stream));
			}

			if (File.Exists(tempPath))
			{
				File.Delete(tempPath);
			}
		}

		[Test]
		public void GenerateFileFromStream() {
			var tempPath = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
			using var writeStream = File.OpenWrite(tempPath);

			var faker = CreateFaker(writeStream);

			faker.WriteRows();

			ICollection<string> lines = new List<string>();

			using (var file = File.OpenRead(tempPath))
			using (var reader = new StreamReader(file))
			{
				while (!reader.EndOfStream)
				{
					lines.Add(reader.ReadLine() ?? string.Empty);
				}
			}

			Assert.That(lines.Count, Is.EqualTo(11));

			File.Delete(tempPath);
		}

		[Test]
		[TestCase(100_000)]
		[TestCase(1_000_000)]
		public void GenerateFile(int rowCount)
		{
			var tempPath = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
			var lines = CreateFileGetLines(tempPath, (uint)rowCount);

			Assert.That(lines?.Count, Is.EqualTo(rowCount + 1));
		}

		[Test]
		public void GenerateTypeCsv()
		{
			var csvFaker = new CsvFaker()
				.Iterations(100)
				.Generate<FakeClass>();

			Assert.That(csvFaker.Count(), Is.EqualTo(101));
		}

		private ICollection<string> CreateFileGetLines(string tempPath, uint rowCount = 10)
		{
			using var stream = File.OpenWrite(tempPath);

			var faker = CreateFaker(stream).Iterations(rowCount);
			faker.WriteRows();

			ICollection<string> lines = new List<string>();

			using (var file = File.OpenRead(tempPath))
			using (var reader = new StreamReader(file))
			{
				while (!reader.EndOfStream)
				{
					lines.Add(reader.ReadLine() ?? string.Empty);
				}
			}

			File.Delete(tempPath);

			return lines;
		}

		private CsvFaker CreateFaker()
		{
			return new CsvFaker()
				.AddColumn("name", () => Faker.Name.First)
				.AddColumn("date", () => Date.FullDateTime)
				.AddColumn("update_date", () => Date.NowFormatted("dddd, dd MMMM yyyy HH:mm:ss"))
				.AddColumn("text", () => Faker.Lorem.GetText(35))
				.AddColumn("ip", () => Computer.IPv4Address)
				.AddColumn("small_variable_message", () => Faker.Lorem.GetText(5, 10));
		}

		private CsvFaker CreateFaker(string tempPath)
		{
			return new CsvFaker(tempPath)
				.AddColumn("name", () => Faker.Name.First)
				.AddColumn("date", () => Date.FullDateTime)
				.AddColumn("update_date", () => Date.NowFormatted("dddd, dd MMMM yyyy HH:mm:ss"))
				.AddColumn("text", () => Faker.Lorem.GetText(35))
				.AddColumn("ip", () => Computer.IPv4Address)
				.AddColumn("small_variable_message", () => Faker.Lorem.GetText(5, 10));
		}

		private CsvFaker CreateFaker(Stream stream)
		{
			return new CsvFaker(stream)
				.AddColumn("name", () => Faker.Name.First)
				.AddColumn("date", () => Date.FullDateTime)
				.AddColumn("update_date", () => Date.NowFormatted("dddd, dd MMMM yyyy HH:mm:ss"))
				.AddColumn("text", () => Faker.Lorem.GetText(35))
				.AddColumn("ip", () => Computer.IPv4Address)
				.AddColumn("small_variable_message", () => Faker.Lorem.GetText(5, 10));
		}

		public class FakeClass
		{
			// [CsvMap(DisplayName = "name", ClassType = typeof(Faker), ClassProperty = "FirstName")]
			public string Name { get; set; }

			// [CsvMap(DisplayName = "date", ClassType = typeof(Faker.NET.EN.Date.Date), ClassProperty = "FullDateTime")]
			public string Date { get; set; }

			// [CsvMap(DisplayName = "ip_address", ClassType = typeof(Faker.NET.EN.Computer.Computer), ClassProperty = "IPv4Address")]
			public string IPAddress { get; set; }
		}
	}
}

