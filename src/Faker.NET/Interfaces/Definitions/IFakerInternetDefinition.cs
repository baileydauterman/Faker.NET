namespace Faker.NET.Interfaces.Definitions;

public interface IFakerInternetDefinition
{
    public string[] TopLevelDomains { get; }

    public string[] UsernamePatterns { get; }
}
