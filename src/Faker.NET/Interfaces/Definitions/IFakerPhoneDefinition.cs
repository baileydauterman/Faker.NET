namespace Faker.NET.Interfaces.Definitions;

public interface IFakerPhoneDefinition
{
    public IReadOnlyCollection<string> Human { get; }

    public IReadOnlyCollection<string> National { get; }

    public IReadOnlyCollection<string> International { get; }
}
