using System.Runtime.CompilerServices;
using Faker.NET.Attributes;
using Faker.NET.Files.Csv;

namespace Faker.NET.Tests.Files
{
    public class Csv
    {
        [Test]
        public void GenerateCsv()
        {
            // using the static first name here will generate the same same for every row
            // use () => Name.FirstName to turn this into a func.
            var faker = CreateCsvFaker();

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
        [TestCase(500_000)]
        public void GenerateMassiveRows(int rowCount)
        {
            var faker = CreateCsvFaker().Iterations((uint)rowCount);

            faker.Generate();
        }

        [Test]
        public void GenerateFileFromPath()
        {
            var tempPath = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());

            var faker = CreateCsvFaker(tempPath);
            faker.WriteRows();

            ICollection<string> lines = new List<string>();

            using (var file = File.OpenRead(tempPath))
            using (var reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line is not null)
                    {
                        lines.Add(line);
                    }
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
                Assert.Throws<Exception>(() => CreateCsvFaker(stream));
            }

            if (File.Exists(tempPath))
            {
                File.Delete(tempPath);
            }
        }

        [Test]
        public void GenerateFileFromStream()
        {
            var tempPath = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
            using var writeStream = File.OpenWrite(tempPath);

            var faker = CreateCsvFaker(writeStream);

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
        public void GenerateFile(int rowCount)
        {
            var tempPath = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
            var lines = CreateFileGetLineCount(tempPath, (uint)rowCount);

            // amount of lines plus the header
            Assert.That(lines, Is.EqualTo(rowCount + 1));
        }

        [Test]
        public void GenerateTypeCsv()
        {
            var csvFaker = new CsvFaker()
                .Iterations(100)
                .Generate<FakeClass>();

            foreach (var line in csvFaker)
            {
                // make sure there is actually data there
                var lines = line.Split(',', StringSplitOptions.RemoveEmptyEntries);
                Assert.That(lines.Length, Is.GreaterThanOrEqualTo(3));
            }

            Assert.That(csvFaker.Count(), Is.EqualTo(101));
        }

        private int CreateFileGetLineCount(string tempPath, uint rowCount = 10)
        {
            using var stream = File.OpenWrite(tempPath);

            var faker = CreateCsvFaker(stream).Iterations(rowCount);
            faker.WriteRows();

            var lines = 0;

            using (var file = File.OpenRead(tempPath))
            using (var reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    reader.ReadLine();
                    lines++;
                }
            }

            File.Delete(tempPath);

            return lines;
        }

        private CsvFaker CreateCsvFaker()
        {
            return new CsvFaker().AddTestColumns();
        }

        private CsvFaker CreateCsvFaker(string tempPath)
        {
            return new CsvFaker(tempPath).AddTestColumns();
        }

        private CsvFaker CreateCsvFaker(Stream stream)
        {
            return new CsvFaker(stream).AddTestColumns();
        }

        public class FakeClass
        {
            [FakerPersonFirstName]
            public string Name { get; set; } = string.Empty;

            [FakerPersonLastName]
            public string Last { get; set; } = string.Empty;

            [FakerInternetIPv4]
            public string IPAddress { get; set; } = string.Empty;

            [FakerInternetPassword(Length = 25, Memorable = false, Prefix = "12345")]
            public string Password { get; set; } = string.Empty;
        }
    }
}

internal static class CsvFakerExtensions
{
    public static CsvFaker AddTestColumns(this CsvFaker faker)
    {
        return faker
                .AddColumn("name", () => Faker.NET.Faker.Name.First)
                .AddColumn("date", () => Faker.NET.Faker.Date.Anytime().ToString())
                .AddColumn("update_date", () => DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"))
                .AddColumn("text", () => Faker.NET.Faker.Lorem.Words(35, 35))
                .AddColumn("ip", () => Faker.NET.Faker.Internet.IPv4())
                .AddColumn("small_variable_message", () => Faker.NET.Faker.Lorem.Words(5, 10));
    }
}
