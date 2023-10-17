using Faker.NET.API;
using Faker.NET.Common;
using Faker.NET.Locales.EN;
using Faker.NET.Locales.RU.Data;
using System.Globalization;

namespace Faker.NET.Locales.RU
{
    public class RULocale : IFakerInstance
    {
        public RULocale()
        {
            Computer = new Computer();
            Name = new Name();
            Lorem = new Lorem(LoremIpsum.Words);
            PhoneNumber = new PhoneNumber();
            Location = new Location();
        }

        public IFakerComputer Computer { get; }

        public IFakerName Name { get; }

        public IFakerLocation Location { get; }

        public IFakerLorem Lorem { get; }

        public IFakerUser User => throw new FakerMemberNotImplementedException(SupportedFakerLocales.Russian, nameof(User));

        public IFakerPhoneNumber PhoneNumber { get; }

        public CultureInfo Culture { get; } = CultureInfo.GetCultureInfo("ru");
    }

    internal class Location : IFakerLocation
    {
        public string Street => $"{Locations.StreetSuffix.GetRandom()} {Locations.Streets.GetRandom()}";

        public string City => Locations.Cities.GetRandom();

        public string State => Locations.States.GetRandom();

        public string StateAbbreviation => Locations.StatesAbbreviated.GetRandom();

        public string BuildingNumber => NumberHelper.GetFromRandomFormat(Locations.BuildingNumberFormats);

        public string Address => $"{Street} {BuildingNumber}, {City}, {State}";

        public string PostalCode => NumberHelper.Get(100000, 162817).ToString();

        public string PostalCodeAlternate => PostalCode;
    }
}
