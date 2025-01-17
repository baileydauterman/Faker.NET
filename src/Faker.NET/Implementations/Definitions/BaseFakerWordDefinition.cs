using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Implementations.Definitions
{
    internal class BaseFakerWordDefinition : IFakerWordDefinition
    {
        public IReadOnlyCollection<string> Adjective => lazyAdjective.Value;

        public IReadOnlyCollection<string> Adverb => lazyAdverb.Value;

        public IReadOnlyCollection<string> Conjunction => lazyConjunction.Value;

        public IReadOnlyCollection<string> Interjection => lazyInterjection.Value;

        public IReadOnlyCollection<string> Noun => lazyNoun.Value;

        public IReadOnlyCollection<string> Preposition => lazyPreposition.Value;

        public IReadOnlyCollection<string> Verb => lazyVerb.Value;

        internal Lazy<IReadOnlyCollection<string>> lazyAdjective = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Word", "adjective"));
        internal Lazy<IReadOnlyCollection<string>> lazyAdverb = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Word", "adverb"));
        internal Lazy<IReadOnlyCollection<string>> lazyConjunction = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Word", "conjunction"));
        internal Lazy<IReadOnlyCollection<string>> lazyInterjection = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Word", "interjection"));
        internal Lazy<IReadOnlyCollection<string>> lazyNoun = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Word", "adjective"));
        internal Lazy<IReadOnlyCollection<string>> lazyPreposition = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Word", "preposition"));
        internal Lazy<IReadOnlyCollection<string>> lazyVerb = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Word", "verb"));
    }
}
