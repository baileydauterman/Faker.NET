using Faker.NET.Common.Airline;
using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Implementations.Definitions
{
    internal class BaseFakerAirlineDefinition : IFakerAirlineDefinition
    {
        public IReadOnlyCollection<Airline> Airlines => lazyAirlines.Value;

        public IReadOnlyCollection<Airport> Airports => lazyAirports.Value;

        public IReadOnlyCollection<Airplane> Airplanes => lazyAirplanes.Value;

        internal Lazy<IReadOnlyCollection<Airline>> lazyAirlines { get; set; }
        internal Lazy<IReadOnlyCollection<Airport>> lazyAirports { get; set; }
        internal Lazy<IReadOnlyCollection<Airplane>> lazyAirplanes { get; set; }
    }
}
