using Faker.NET.Common;
using Faker.NET.Common.Exceptions;
using Faker.NET.Interfaces;
using Faker.NET.Locales.RU.Data;
using System.Globalization;

namespace Faker.NET.Locales.RU
{
    internal class RULocale : IFakerLocaleInstance
    {
        public RULocale()
        {
            Name = new Name();
            Lorem = new Lorem(LoremIpsum.Words);
            PhoneNumber = new PhoneNumber();
            Location = new Location();
        }

        public IFakerName Name { get; }

        public IFakerLocation Location { get; }

        public IFakerLorem Lorem { get; }

        public IFakerUser User => ThrowHelper.FakerMemberNotImplementedException(User, FakerLocale.Russian, nameof(User));

        public IFakerPhoneNumber PhoneNumber { get; }

        public CultureInfo Culture { get; } = CultureInfo.GetCultureInfo("ru");
    }

    internal class Location : IFakerLocation
    {
        public string Street => $"{Locations.StreetSuffix.GetRandom()} {Locations.Streets.GetRandom()}";

        public string City => Locations.Cities.GetRandom();

        public string State => Locations.States.GetRandom();

        public string StateAbbreviation => Locations.StatesAbbreviated.GetRandom();

        public string BuildingNumber => Locations.BuildingNumberFormats.ToRandomFormat();

        public string Address => $"{Street} {BuildingNumber}, {City}, {State}";

        public string PostalCode => Faker.Randomizer.Next(100000, 162817).ToString();

        public string PostalCodeAlternate => PostalCode;
    }

    internal class PhoneNumber : IFakerPhoneNumber
    {
        public string Number => $"{PhoneNumbers.AreaCodes.GetRandom()} {PhoneNumbers.Formats.ToRandomFormat()}";

        public string NumberWithCountryCode => $"+{CountryCode} {Number}";

        public int CountryCode => 8;
    }

    internal class Name : IFakerName
    {
        public string First => NameData.FirstNames.GetRandom();

        public string Last => NameData.LastNames.GetRandom();

        public string Full => $"{First} {Last}";

        public string Suffix => throw new NotImplementedException();

        public string Prefix => throw new NotImplementedException();

        public string Job => $"{NameData.TitleLevel.GetRandom()} {NameData.TitleDescriptor.GetRandom()} {NameData.TitleJob.GetRandom()}";

        public string Email => InternetHelper.GenerateEmail(First, Last);
    }
}
