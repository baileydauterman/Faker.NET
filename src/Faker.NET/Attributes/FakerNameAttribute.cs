using Faker.NET.Common.Exceptions;

namespace Faker.NET.Attributes;

public enum FakerNameAttributes
{
    First,
    Last,
    Full,
    Suffix,
    Prefix,
    Job,
    Email
}

public class FakerNameAttribute : Attribute
{
    public FakerNameAttributes Field { get; set; } = FakerNameAttributes.Full;

    public object GetPropertyValue()
    {
        string value = Field switch {
            FakerNameAttributes.First => Faker.Name.First,
            FakerNameAttributes.Last => Faker.Name.Last,
            FakerNameAttributes.Full => Faker.Name.Full,
            FakerNameAttributes.Suffix => Faker.Name.Suffix,
            FakerNameAttributes.Prefix => Faker.Name.Prefix,
            FakerNameAttributes.Job => Faker.Name.Job,
            FakerNameAttributes.Email => Faker.Name.Email,
            _ => string.Empty
        };

        if (string.IsNullOrEmpty(value))
        {
            ThrowHelper.FakerAttributeNotImplementedException(Field.ToString(), nameof(FakerNameAttribute));
        }

        return value;
    }
}
