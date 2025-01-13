namespace Faker.NET.Interfaces.Definitions;

public interface IFakerInternetDefinition
{
    public IReadOnlyCollection<string> TopLevelDomains { get; }

    public IReadOnlyCollection<string> UsernamePatterns { get; }
}
