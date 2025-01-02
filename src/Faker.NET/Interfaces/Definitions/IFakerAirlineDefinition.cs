using Faker.NET.Common.Airline;

namespace Faker.NET.Interfaces.Definitions;

public interface IFakerAirlineDefinition
{
    public Airline[] Airlines { get; }

    public Airport[] Airports { get; }

    public Airplane[] Airplanes { get; }
}
