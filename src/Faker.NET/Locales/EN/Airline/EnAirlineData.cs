using Faker.NET.Common.Airline;
using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Locales.EN.Airline;

internal class EnAirlineData : IFakerAirlineDefinition
{
    public EnAirlineData()
    {
        Airlines = Faker.ResourceRetriever.Get<Common.Airline.Airline>("EN.Airline.en_airlines.json");
        Airports = Faker.ResourceRetriever.Get<Airport>("EN.Airline.en_airports.json");
        Airplanes = Faker.ResourceRetriever.Get<Airplane>("EN.Airline.en_airplanes.json");
    }

    public IReadOnlyCollection<Common.Airline.Airline> Airlines { get; }

    public IReadOnlyCollection<Airport> Airports { get; }

    public IReadOnlyCollection<Airplane> Airplanes { get; }
}
