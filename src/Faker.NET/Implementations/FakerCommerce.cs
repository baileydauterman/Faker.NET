using Faker.NET.Extensions;
using Faker.NET.Interfaces.Definitions;
using Faker.NET.Modules.Interfaces;

namespace Faker.NET.Implementations;

internal class FakerCommerce<T> : FakerDefinitionHandler<T>, IFakerCommerce where T : IFakerCommerceDefinition
{
    public string Department()
    {
        return Data.Department.GetRandom();
    }

    public string Isbn()
    {
        throw new NotImplementedException();
    }

    public string Price(int decimalPlaces = 2, int min = 1, int max = 1000, string symbol = "")
    {
        return Faker.Randomizer.NextDouble(min, max).ToString($"F{decimalPlaces}");
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
