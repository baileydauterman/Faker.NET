namespace Faker.NET.Modules.Interfaces;

public interface IFakerPhoneNumber
{
    public string Number { get; }

    public string NumberWithCountryCode { get; }

    public int CountryCode { get; }
}
