using Faker.NET.Attributes;
using Faker.NET.Files.Csv;
using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Files
{
    public class Csv : FileBasedTestClass
    {
        [Test]
        [TestCase(100_000)]
        [TestCase(200_000)]
        [TestCase(500_000)]
        [TestCase(1_000_000)]
        public void GenerateMassiveRows(int rowCount)
        {
            // more of a proof of concept rather than testing because Generate() returns an IEnumerable
            // at time of writing will generate 3,000,000 values in about 2.5 seconds
            var path = IO.GetRandomTempFilePath();
            var faker = CsvFaker.ToFile(path)
                            .AddTestColumns()
                            .WithRowCount((uint)rowCount);
            faker.Write();
        }

        [Test]
        public void GenerateFileFromPath()
        {
            var tempPath = IO.GetRandomTempFilePath();
            var faker = CsvFaker.ToFile(tempPath).AddTestColumns();
            faker.Write();
            CheckFile(tempPath, 501);
        }

        [Test]
        public void GenerateFileFromStreamReadError()
        {
            var tempPath = IO.GetRandomTempFilePath();

            using var stream = File.Open(tempPath, FileMode.OpenOrCreate, FileAccess.Read);
            Assert.Throws<Exception>(() => CsvFaker.ToStream(stream));
        }

        [Test]
        public void GenerateFileFromStream()
        {
            var tempPath = IO.GetRandomTempFilePath();
            using var writeStream = File.OpenWrite(tempPath);
            var faker = CsvFaker.ToStream(writeStream).AddTestColumns();
            faker.Write();
            CheckFile(tempPath, 501);
        }

        [Test]
        public void GenerateTypeCsv()
        {
            var path = IO.GetRandomTempFilePath();
            CsvFaker.ToFile(path)
                .WithRowCount(100)
                .FromClass<FakeClass>()
                .Write();

            CheckFile(path, 101);
        }

        private static void CheckFile(string path, uint expectedRows)
        {
            var actualLines = 0;
            using (var file = File.OpenRead(path))
            using (var reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    if (reader.ReadLine() is not null)
                    {
                        actualLines += 1;
                    }
                }
            }

            Assert.That(expectedRows, Is.EqualTo(actualLines));
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
