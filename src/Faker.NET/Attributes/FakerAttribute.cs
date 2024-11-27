namespace Faker.NET.Attributes;

public abstract class FakerAttribute : Attribute
{
    public abstract object GetPropertyValue();
}
