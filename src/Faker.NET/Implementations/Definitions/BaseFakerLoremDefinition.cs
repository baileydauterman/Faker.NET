using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Implementations.Definitions
{
    internal class BaseFakerLoremDefinition : IFakerLoremDefinition
    {
        public IReadOnlyCollection<string> Words => lazyWords.Value;

        internal Lazy<IReadOnlyCollection<string>> lazyWords = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Lorem", "words"));
    }
}
