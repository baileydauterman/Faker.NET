using Faker.NET.API;
using Faker.NET.Common;
using Faker.NET.Locales.EN.Data;
using System.Globalization;

namespace Faker.NET.Locales.EN
{
    internal class ENLocale : IFakerInstance
    {
        public ENLocale()
        {
            Computer = new Computer();
            Name = new Name();
            User = new User();
            Lorem = new Lorem(LoremIpsum.Words);
            Location = new Location();
            PhoneNumber = new PhoneNumber();
        }

        public IFakerName Name { get; }

        public IFakerUser User { get; }

        public IFakerLorem Lorem { get; }

        public IFakerLocation Location { get; }

        public IFakerPhoneNumber PhoneNumber { get; }

        public IFakerComputer Computer { get; }

        public CultureInfo Culture { get; } = CultureInfo.GetCultureInfo("en");
    }

    internal class Name : IFakerName
    {
        public string First => Names.First.GetRandom();

        public string Last => Names.Last.GetRandom();

        public string Full => $"{First} {Last}";

        public string Suffix => Names.Suffix.GetRandom();

        public string Prefix => Names.Prefix.GetRandom();

        public string Job => $"{Names.TitleLevel.GetRandom()} {Names.TitleDescriptor.GetRandom()} {Names.TitleJob.GetRandom()}";

        public string Email => EmailHelper.Generate(First, Last);
    }

    internal class PhoneNumber : IFakerPhoneNumber
    {
        public string Number => NumberHelper.GetFromRandomFormat(PhoneNumbers.Formats);
    }

    internal class Commerce : IFakerCommerce
    {
        public string Department => CommerceData.Department.GetRandom();

        public string Product => $"{_adjective} {_material} {_product}";

        private string _adjective => CommerceData.Adjective.GetRandom();

        private string _material => CommerceData.Material.GetRandom();

        private string _product => CommerceData.Product.GetRandom();
    }

    internal class Location : IFakerLocation
    {
        public string City => LocationData.Cities.GetRandom();

        public string State => LocationData.States.GetRandom();

        public string StateAbbreviation => LocationData.StatesAbbreviation.GetRandom();

        public string BuildingNumber => NumberHelper.Get(1, 1000).ToString();

        public string Address => $"{BuildingNumber} {Street} {City}, {StateAbbreviation} {PostalCode}";

        public string PostalCode => NumberHelper.GetFromFormat("#####");

        public string PostalCodeAlternate => NumberHelper.GetFromFormat("#####-####");

        public string Street => LocationData.StreetNames.GetRandom();
    }

    public class User : IFakerUser
    {
        public Common.Objects.User New => GetUser();

        public Common.Objects.User GetUser()
        {
            var user = new Common.Objects.User()
            {
                FirstName = Faker.Name.First,
                LastName = Faker.Name.Last,
                JobTitle = Faker.Name.Job,
                Prefix = Faker.Name.Prefix,
            };

            user.Email = EmailHelper.Generate(user.FirstName, user.LastName);

            return user;
        }
    }
}
