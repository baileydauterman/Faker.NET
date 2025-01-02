using Faker.NET.Common;
using Faker.NET.Extensions;
using Faker.NET.Interfaces;
using Faker.NET.Locales.DE.Data;
using System.Globalization;
using Faker.NET.Implementations;

namespace Faker.NET.Locales.DE
{
    internal class DELocale : FakerLocaleInstance
    {
        public DELocale()
        {
            Name = new Name();
            PhoneNumber = new PhoneNumber();
            Lorem = new Common.FakerLorem(Data.Lorem.Words);
            Culture = CultureInfo.GetCultureInfo("de");
        }
    }

    internal class Name : IFakerName
    {
        public string First => Names.FirstName.GetRandom();

        public string Last => Names.LastName.GetRandom();

        public string Prefix => Names.Prefix.GetRandom();

        public string Full => $"{First} {Last}";

        public string Suffix => throw new NotImplementedException();

        public string Job => throw new NotImplementedException();

        public string Email => throw new NotImplementedException();
    }

    internal class PhoneNumber : IFakerPhoneNumber
    {
        public string Number => $"1{PhoneNumbers.Formats.ToRandomFormat()}";

        public string NumberWithCountryCode => $"+{CountryCode}-1{Number}";

        public int CountryCode { get; } = 49;
    }
}

