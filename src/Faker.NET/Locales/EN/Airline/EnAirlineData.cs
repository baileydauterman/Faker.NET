using Faker.NET.Common.Airline;
using Faker.NET.Implementations.Definitions;

namespace Faker.NET.Locales.EN.Airline;

internal class EnAirlineData : BaseFakerAirlineDefinition
{
    public EnAirlineData()
    {
        lazyAirlines = new(() => Faker.ResourceRetriever.Get<Common.Airline.Airline>("EN.Airline.en_airlines.json"));
        lazyAirports = new(() => Faker.ResourceRetriever.Get<Airport>("EN.Airline.en_airports.json"));
        lazyAirplanes = new(() => Faker.ResourceRetriever.Get<Airplane>("EN.Airline.en_airplanes.json"));
    }
}
