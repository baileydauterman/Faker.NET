namespace Faker.NET.Attributes;

/// <summary>
/// Attribute class to use the public facing <see cref="Faker"/> class to generate fake data off of class attributes
/// </summary>
public abstract class FakerAttribute : Attribute
{
    /// <summary>
    /// Method to get a value based off of an attribute
    /// </summary>
    /// <returns>The object created by <see cref="Faker"/></returns>
    public abstract object GetPropertyValue();
}
