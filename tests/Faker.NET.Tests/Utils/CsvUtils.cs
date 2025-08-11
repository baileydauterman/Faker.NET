using Faker.NET.Files.Csv;

namespace Faker.NET.Tests.Utils;

public static class CsvUtils
{
    public static IEnumerable<string> ToCsvRows<T>()
    {
        using var memStream = new MemoryStream();
        var faker = CsvFaker.ToStream(memStream)
            .WithRowCount(5)
            .FromClass<T>();
        faker.Write(keepStreamOpen: true);

        memStream.Position = 0;
        using var streamReader = new StreamReader(memStream);
        while (!streamReader.EndOfStream)
        {
            var line = streamReader.ReadLine();
            if (line is not null)
            {
                yield return line;
            }
        }
    }

    public static CsvFaker AddTestColumns(this CsvFaker faker)
    {
        return faker.WithColumns(new()
        {
            { "name", () => Faker.Person.FirstName() },
            { "date", () => Faker.Date.Anytime().ToString() },
            { "update_date", () => DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") },
            { "text", () => Faker.Lorem.Words(35, 35) },
            { "ip", () => Faker.Internet.IPv4() },
            { "small_variable_message", () => Faker.Lorem.Words(5, 10) }
        });
    }
}
