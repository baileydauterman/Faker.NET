﻿using Faker.NET.Common;
using Faker.NET.Interfaces;
using Faker.NET.Locales.DE.Data;
using System.Globalization;

namespace Faker.NET.Locales.DE
{
    internal class DELocale : IFakerInstance
    {
        public DELocale()
        {
            Computer = new Computer();
            Name = new Name();
            PhoneNumber = new PhoneNumber();
            Location = new Location();
            Lorem = new Common.Lorem(Data.Lorem.Words);
        }

        public IFakerComputer Computer { get; }

        public IFakerName Name { get; }

        public IFakerLocation Location { get; }

        public IFakerLorem Lorem { get; }

        public IFakerUser User => throw new FakerInstanceNotImplementedException(nameof(User));

        public IFakerPhoneNumber PhoneNumber { get; }

        public CultureInfo Culture { get; } = CultureInfo.GetCultureInfo("de");
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

    internal class Location : IFakerLocation
    {
        public string City => Locations.Cities.GetRandom();

        public string State => Locations.States.GetRandom();

        public string StateAbbreviation => Locations.StatesAbbreviated.GetRandom();

        public string BuildingNumber => Locations.BuildingNumberFormat.ToRandomFormat();

        public string Address => $"{Street} {BuildingNumber}, {PostalCode} {City}";

        public string PostalCode => _postalCodeFormat.ToRandomString();

        public string PostalCodeAlternate => _postalCodeFormat.ToRandomString();

        public string Street => Locations.StreetNames.GetRandom();

        private static readonly string _postalCodeFormat = "#####";
    }

    internal class PhoneNumber : IFakerPhoneNumber
    {
        public string Number => $"1{PhoneNumbers.Formats.ToRandomFormat()}";

        public string NumberWithCountryCode => $"+{CountryCode}-1{Number}";

        public int CountryCode { get; } = 49;
    }
}

