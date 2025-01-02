using Faker.NET.Common;
using Faker.NET.Extensions;
using Faker.NET.Locales.EN.Data;
using Faker.NET.Modules.Interfaces;

namespace Faker.NET.Locales.EN;

internal class EnFakerPhoneNumber : IFakerPhoneNumber
{
    public string Number => $"{PhoneNumbers.AreaCodes.GetRandom()}{PhoneNumbers.Formats.ToRandomFormat()}";

    public string NumberWithCountryCode => $"+{CountryCode} {Number}";

    public int CountryCode { get; } = 1;
}
