using Faker.NET.Common.Phone;

namespace Faker.NET.Attributes;

public class FakerPhoneNumberAttribute : FakerAttribute
{
    public PhoneNumberType Type { get; set; }
    public override object GetPropertyValue() => Faker.Phone.Number(Type);
}