using Faker.NET.Common.Airline;
using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Implementations.Definitions
{
    internal class BaseFakerAirlineDefinition : IFakerAirlineDefinition
    {
        public IReadOnlyCollection<Airline> Airlines => lazyAirlines.Value;

        public IReadOnlyCollection<Airport> Airports => lazyAirports.Value;

        public IReadOnlyCollection<Airplane> Airplanes => lazyAirplanes.Value;

        internal Lazy<IReadOnlyCollection<Airline>> lazyAirlines = new(() => Faker.ResourceRetriever.GetAsArray<Airline>(Faker.Culture.TwoLetterISOLanguageName, "Airline", "airlines"));
        internal Lazy<IReadOnlyCollection<Airport>> lazyAirports = new(() => Faker.ResourceRetriever.GetAsArray<Airport>(Faker.Culture.TwoLetterISOLanguageName, "Airline", "airports"));
        internal Lazy<IReadOnlyCollection<Airplane>> lazyAirplanes = new(() => Faker.ResourceRetriever.GetAsArray<Airplane>(Faker.Culture.TwoLetterISOLanguageName, "Airline", "airplanes"));
    }
}
