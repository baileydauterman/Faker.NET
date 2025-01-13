using Faker.NET.Extensions;
using Faker.NET.Interfaces.Definitions;
using Faker.NET.Interfaces.Modules;

namespace Faker.NET.Implementations.Modules;

internal class FakerCommerce<T> : FakerDefinitionHandler<T>, IFakerCommerce where T : IFakerCommerceDefinition
{
    public string Department()
    {
        return Data.Department.GetRandom();
    }

    public string Isbn()
    {
        int[] digits = new int[12];

        // Start with the "978" or "979" prefix
        digits[0] = 9;
        digits[1] = 7;
        digits[2] = Faker.Randomizer.Next(8, 10);

        for (int i = 3; i < 12; i++)
        {
            digits[i] = Faker.Randomizer.Next(0, 10);
        }

        var sum = 0;

        for (int i = 0; i < digits.Length; i++)
        {
            var multiple = i % 2 == 0 ? 1 : 3;
            sum += digits[i] * multiple;
        }

        // Check digit when added to isbn makes it divisble by 10
        int remainder = sum % 10;
        int checkDigit = sum % 10 == 0 ? 0 : 10 - remainder;

        string isbn = string.Join("", digits) + checkDigit;
        return isbn;
    }

    public string Price(int decimalPlaces = 2, int min = 1, int max = 1000, string symbol = "")
    {
        var price = Faker.Randomizer.NextDouble(min, max).ToString($"F{decimalPlaces}");
        return $"{symbol}{price}";
    }

    public string Product()
    {
        return Data.ProductName.Material.GetRandom();
    }

    public string ProductAdjective()
    {
        return Data.ProductName.Adjective.GetRandom();
    }

    public string ProductDescription()
    {
        return Data.ProductDescription.GetRandom();
    }

    public string ProductMaterial()
    {
        return Data.ProductName.Material.GetRandom();
    }

    public string ProductName()
    {
        return $"{ProductAdjective()} {ProductMaterial()} {Product()}";
    }
}
