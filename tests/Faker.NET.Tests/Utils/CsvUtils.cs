using Faker.NET.Files.Csv;

namespace Faker.NET.Tests.Utils;

public static class CsvUtils
{
    public static List<string> ToCsvRows<T>()
    {
        return new CsvFaker()
            .Iterations(5)
            .Generate<T>()
            .ToList();
    }
}
