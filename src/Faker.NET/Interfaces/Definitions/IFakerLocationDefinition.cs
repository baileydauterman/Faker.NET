using Faker.NET.Common.Location;
using Faker.NET.Location;

namespace Faker.NET.Interfaces.Definitions;

public interface IFakerLocationDefinition
{
    public string[] BuildingNumber { get; }
    public string[] CityName { get; }
    public string[] CityPattern { get; }
    public string[] CityPrefix { get; }
    public string[] CitySuffix { get; }
    public string[] Continent { get; }
    public string[] Country { get; }
    public string[] County { get; }
    public Direction Direction { get; }
    public Language[] Language { get; }
    public string[] Postcode { get; }
    public string[] SecondaryAddress { get; }
    public LocationState[] State { get; }
    public StreetAddress StreetAddress { get; }
    public string[] StreetName { get; }
    public string[] StreetPattern { get; }
    public string[] StreetSuffix { get; }
}
