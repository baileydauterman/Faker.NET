using Faker.NET.Extensions;

namespace Faker.NET.Internet.Generators;

public class HexGenerator
{
    public string Generate(int length = 2)
    {
        var arrValues = new string[length];

        for (int i = 0; i < length; i++)
        {
            arrValues[i] = Values.GetRandom();
        }

        return string.Join(string.Empty, arrValues);
    }

    private static readonly string[] Values = {
        "0", "1","2","3","4","5","6","7","8","9",
        "A", "B", "C", "D", "E", "F"
    };
}
