using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Implementations.Definitions
{
    internal class BaseFakerInternetDefinition : IFakerInternetDefinition
    {
        public IReadOnlyCollection<string> TopLevelDomains => lazyTLDs.Value;

        public IReadOnlyCollection<string> UsernamePatterns => lazyUsernamePatterns.Value;

        internal Lazy<IReadOnlyCollection<string>> lazyTLDs = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Internet", "top_level_domains"));
        internal Lazy<IReadOnlyCollection<string>> lazyUsernamePatterns = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Internet", "username_patterns"));
    }
}
