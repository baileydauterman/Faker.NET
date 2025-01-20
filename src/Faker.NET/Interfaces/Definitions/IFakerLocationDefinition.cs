using Faker.NET.Common.Location;
using Faker.NET.Location;

namespace Faker.NET.Interfaces.Definitions;

public interface IFakerLocationDefinition
{
    public IReadOnlyCollection<string> BuildingNumber { get; }
    public IReadOnlyCollection<string> CityName { get; }
    public IReadOnlyCollection<string> CityPrefix { get; }
    public IReadOnlyCollection<string> CitySuffix { get; }
    public IReadOnlyCollection<string> Continent { get; }
    public IReadOnlyCollection<string> Country { get; }
    public IReadOnlyCollection<string> County { get; }
    public Direction Direction { get; }
    public IReadOnlyCollection<Language> Language { get; }
    public IReadOnlyCollection<string> Postcode { get; }
    public IReadOnlyCollection<string> SecondaryAddress { get; }
    public IReadOnlyCollection<LocationState> State { get; }
    public StreetAddress StreetAddress { get; }
    public IReadOnlyCollection<string> StreetName { get; }
    public IReadOnlyCollection<string> StreetPattern { get; }
    public IReadOnlyCollection<string> StreetSuffix { get; }
}
