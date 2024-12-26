using System.Net;
using Faker.NET.Attributes;
using Faker.NET.Files.Csv;
using Faker.NET.Interfaces;

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

        [Test]
        public void GenerateTypeByInstanceCsv()
        {
            var classInstance = new NoAttrInteropClass();
            var csvFaker = new CsvFaker()
                .Iterations(100)
                .Generate(classInstance);

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
            return new CsvFaker()
                .AddColumn("name", () => Faker.Name.First)
                .AddColumn("date", () => Faker.Date.Anytime().ToString())
                .AddColumn("update_date", () => DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"))
                .AddColumn("text", () => Faker.Lorem.GetWords(35))
                .AddColumn("ip", () => Faker.Internet.IPv4())
                .AddColumn("small_variable_message", () => Faker.Lorem.GetWords(5, 10));
        }

        private CsvFaker CreateCsvFaker(string tempPath)
        {
            return new CsvFaker(tempPath)
                .AddColumn("name", () => Faker.Name.First)
                .AddColumn("date", () => Faker.Date.Anytime().ToString())
                .AddColumn("update_date", () => DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"))
                .AddColumn("text", () => Faker.Lorem.GetWords(35))
                .AddColumn("ip", () => Faker.Internet.IPv4())
                .AddColumn("small_variable_message", () => Faker.Lorem.GetWords(5, 10));
        }

        private CsvFaker CreateCsvFaker(Stream stream)
        {
            return new CsvFaker(stream)
                .AddColumn("name", () => Faker.Name.First)
                .AddColumn("date", () => Faker.Date.Anytime().ToString())
                .AddColumn("update_date", () => DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"))
                .AddColumn("text", () => Faker.Lorem.GetWords(35))
                .AddColumn("ip", () => Faker.Internet.IPv4())
                .AddColumn("small_variable_message", () => Faker.Lorem.GetWords(5, 10));
        }

        public class FakeClass : IMyClass
        {
            [FakerNameFirst]
            public string Name { get; set; } = string.Empty;

            [FakerNameLast]
            public string Last { get; set; } = string.Empty;

            [FakerComputerIPv4Address]
            public string IPAddress { get; set; } = string.Empty;
        }

        public class NoAttrInteropClass : IMyClass
        {
            public string Name { get => Faker.Name.First; set => throw new NotImplementedException(); }
            public string Last { get => Faker.Name.Last; set => throw new NotImplementedException(); }
            public string IPAddress { get => Faker.Internet.IPv4(); set => throw new NotImplementedException(); }
        }

        public interface IMyClass
        {
            string Name { get; set; }

            string Last { get; set; }

            string IPAddress { get; set; }
        }
    }
}

