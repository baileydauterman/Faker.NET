namespace Faker.NET.Interfaces.Definitions;

public interface IFakerWordDefinition
{
    public IReadOnlyCollection<string> Adjective { get; }
    public IReadOnlyCollection<string> Adverb { get; }
    public IReadOnlyCollection<string> Conjunction { get; }
    public IReadOnlyCollection<string> Interjection { get; }
    public IReadOnlyCollection<string> Noun { get; }
    public IReadOnlyCollection<string> Preposition { get; }
    public IReadOnlyCollection<string> Verb { get; }
}
