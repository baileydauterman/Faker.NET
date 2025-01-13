namespace Faker.NET.Interfaces.Definitions;

public interface IFakerCommerceDefinition
{
    public IReadOnlyCollection<string> Department { get; }

    public IFakerCommerceProductNameDefinition ProductName { get; }

    public IReadOnlyCollection<string> ProductDescription { get; }
}
