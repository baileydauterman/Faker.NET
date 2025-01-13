using Faker.NET.Common.Airline;

namespace Faker.NET.Interfaces.Definitions;

public interface IFakerAirlineDefinition
{
    public IReadOnlyCollection<Airline> Airlines { get; }

    public IReadOnlyCollection<Airport> Airports { get; }

    public IReadOnlyCollection<Airplane> Airplanes { get; }
}
