using Faker.NET.Extensions;
using Faker.NET.Interfaces;
using Faker.NET.Locales.EN.Data;

namespace Faker.NET.Locales.EN;

internal class Commerce : IFakerCommerce
{
    public string Department => CommerceData.Department.GetRandom();

    public string Product => BuildProduct();

    private string BuildProduct()
    {
        var adjective = CommerceData.Adjective.GetRandom();
        var material = CommerceData.Material.GetRandom();
        var product = CommerceData.Product.GetRandom();

        return $"{adjective} {material} {product}";
    }
}
