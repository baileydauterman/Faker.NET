using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Implementations.Definitions;

internal class BaseFakerPhoneDefinition : IFakerPhoneDefinition
{
    public IReadOnlyCollection<string> Human => lazyHuman.Value;

    public IReadOnlyCollection<string> National => lazyNational.Value;

    public IReadOnlyCollection<string> International => lazyInternational.Value;

    internal Lazy<IReadOnlyCollection<string>> lazyHuman = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Phone", "human"));
    internal Lazy<IReadOnlyCollection<string>> lazyNational = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Phone", "national"));
    internal Lazy<IReadOnlyCollection<string>> lazyInternational = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Phone", "international"));
}
