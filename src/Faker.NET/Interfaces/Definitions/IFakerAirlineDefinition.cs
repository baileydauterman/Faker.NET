using Faker.NET.Airline;

namespace Faker.NET.Interfaces.Definitions;

public interface IFakerAirlineDefinition
{
    public Airline.Airline[] Airlines { get; }

    public Airport[] Airports { get; }

    public Airplane[] Airplanes { get; }
}
