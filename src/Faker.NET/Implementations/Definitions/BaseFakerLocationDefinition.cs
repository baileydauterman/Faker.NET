using Faker.NET.Common.Location;
using Faker.NET.Interfaces.Definitions;
using Faker.NET.Location;

namespace Faker.NET.Implementations.Definitions
{
    internal class BaseFakerLocationDefinition : IFakerLocationDefinition
    {
        public IReadOnlyCollection<string> BuildingNumber => lazyBuildingNumberPatterns.Value;

        public IReadOnlyCollection<string> CityName => lazyCityName.Value;

        public IReadOnlyCollection<string> CityPrefix => lazyCityPrefix.Value;

        public IReadOnlyCollection<string> CitySuffix => lazyCitySuffix.Value;

        public IReadOnlyCollection<string> Continent => lazyContinent.Value;

        public IReadOnlyCollection<string> Country => lazyCountry.Value;

        public IReadOnlyCollection<string> County => lazyCounty.Value;

        public Direction Direction => lazyDirection.Value;

        public IReadOnlyCollection<Language> Language => lazyLanguage.Value;

        public IReadOnlyCollection<string> Postcode => lazyPostCode.Value;

        public IReadOnlyCollection<string> SecondaryAddress => lazySecondaryAddressPatterns.Value;

        public IReadOnlyCollection<LocationState> State => lazyLocationState.Value;

        public StreetAddress StreetAddress => lazyStreetAddress.Value;

        public IReadOnlyCollection<string> StreetName => lazyStreetName.Value;

        public IReadOnlyCollection<string> StreetPattern => lazyStreetPattern.Value;

        public IReadOnlyCollection<string> StreetSuffix => lazyStreetSuffix.Value;

        internal Lazy<IReadOnlyCollection<string>> lazyBuildingNumberPatterns = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Location", "building_number_formats"));
        internal Lazy<IReadOnlyCollection<string>> lazyCityName = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Location", "city_names"));
        internal Lazy<IReadOnlyCollection<string>> lazyCityPrefix = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Location", "city_prefixes"));
        internal Lazy<IReadOnlyCollection<string>> lazyCitySuffix = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Location", "city_suffixes"));
        internal Lazy<IReadOnlyCollection<string>> lazyContinent = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Location", "continents"));
        internal Lazy<IReadOnlyCollection<string>> lazyCountry = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Location", "countries"));
        internal Lazy<IReadOnlyCollection<string>> lazyCounty = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Location", "counties"));
        internal Lazy<Direction> lazyDirection = new(() => Faker.ResourceRetriever.Get<Direction>(Faker.Culture.TwoLetterISOLanguageName, "Location", "directions"));
        internal Lazy<IReadOnlyCollection<Language>> lazyLanguage = new(() => Faker.ResourceRetriever.GetAsArray<Language>(Faker.Culture.TwoLetterISOLanguageName, "Location", "languages"));
        internal Lazy<IReadOnlyCollection<string>> lazyPostCode = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Location", "postcode_formats"));
        internal Lazy<IReadOnlyCollection<string>> lazySecondaryAddressPatterns = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Location", "secondary_address_formats"));
        internal Lazy<IReadOnlyCollection<LocationState>> lazyLocationState = new(() => Faker.ResourceRetriever.GetAsArray<LocationState>(Faker.Culture.TwoLetterISOLanguageName, "Location", "states"));
        internal Lazy<StreetAddress> lazyStreetAddress = new(() => Faker.ResourceRetriever.Get<StreetAddress>(Faker.Culture.TwoLetterISOLanguageName, "Location", "street_address_formats"));
        internal Lazy<IReadOnlyCollection<string>> lazyStreetName = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Location", "street_names"));
        internal Lazy<IReadOnlyCollection<string>> lazyStreetPattern = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Location", "street_patterns"));
        internal Lazy<IReadOnlyCollection<string>> lazyStreetSuffix = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Location", "street_suffixes"));
    }
}
