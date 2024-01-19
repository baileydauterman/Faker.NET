using Faker.NET.Common;
using Faker.NET.Interfaces;
using Faker.NET.Locales.DE.Data;
using Faker.NET.Locales.EN;
using System.Globalization;

namespace Faker.NET.Locales.DE
{
    public class DELocale : IFakerInstance
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

    public class Name : IFakerName
    {
        public string First => Data.Names.FirstName.GetRandom();

        public string Last => Data.Names.LastName.GetRandom();

        public string Prefix => Data.Names.Prefix.GetRandom();

        public string Full => $"{First} {Last}";

        public string Suffix => throw new NotImplementedException();

        public string Job => throw new NotImplementedException();

        public string Email => throw new NotImplementedException();
    }

    public class Location : IFakerLocation
    {
        public string City => Locations.Cities.GetRandom();

        public string State => Locations.States.GetRandom();

        public string StateAbbreviation => Locations.StatesAbbreviated.GetRandom();

        public string BuildingNumber => NumberHelper.GetFromRandomFormat(Locations.BuildingNumberFormat);

        public string Address => $"{Street} {BuildingNumber}, {PostalCode} {City}";

        public string PostalCode => NumberHelper.GetFromFormat("#####");

        public string PostalCodeAlternate => NumberHelper.GetFromFormat("#####");

        public string Street => Locations.StreetNames.GetRandom();
    }

    internal class PhoneNumber : IFakerPhoneNumber
    {
        public string Number => NumberHelper.GetFromFormat("+49-1##-#######");

        public string AlternateNumberFormat => NumberHelper.GetFromFormat("+49-1###-########");
    }
}

