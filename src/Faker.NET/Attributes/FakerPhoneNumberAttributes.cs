namespace Faker.NET.Attributes;

public class FakerPhoneNumberAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Phone.Number;
}

public class FakerPhoneNumberWithAreaCodeAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Phone.NumberWithCountryCode;
}

public class FakerPhoneNumberCountryCodeAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Phone.CountryCode;
}
