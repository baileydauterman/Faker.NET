namespace Faker.NET.Interfaces.Definitions;

public interface IFakerCommerceDefinition
{
    public string[] Department { get; }

    public IFakerCommerceProductNameDefinition ProductName { get; }

    public string[] ProductDescription { get; }
}
