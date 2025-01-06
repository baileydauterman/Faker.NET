using Faker.NET.Common.Internet.Data;

namespace Faker.NET.Interfaces.Definitions;

public interface IFakerInternetDefinition
{
    public string[] TopLevelDomains { get; }

    public Emojis Emojis { get; }
}
