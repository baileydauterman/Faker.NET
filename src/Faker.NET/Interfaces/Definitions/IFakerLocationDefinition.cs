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

public class Direction
{
    public Direction(string[] cardinal, string[] cardinalAbbr, string[] ordinal, string[] ordinalAbbr)
    {
        Cardinal = cardinal;
        CardinalAbbr = cardinalAbbr;
        Ordinal = ordinal;
        OrdinalAbbr = ordinalAbbr;
    }

    public string[] Cardinal { get; }
    public string[] CardinalAbbr { get; }
    public string[] Ordinal { get; }
    public string[] OrdinalAbbr { get; }
}

public class Language
{
    public string Name { get; set; }
    public string Alpha2 { get; set; }
    public string Alpha3 { get; set; }
}

public class StreetAddress
{
    public string Normal { get; set; }
    public string Full { get; set; }
}
