using Faker.NET.Common;
using Faker.NET.Common.Phone;
using Faker.NET.Extensions;
using Faker.NET.Implementations;
using Faker.NET.Interfaces;
using Faker.NET.Locales.RU.Data;
using System.Globalization;

namespace Faker.NET.Locales.RU
{
    internal class RULocale : FakerLocaleInstance
    {
        public RULocale()
        {
            Name = new Name();
            Lorem = new FakerLorem<RuLoremData>();
            PhoneNumber = new FakerPhone<RuPhoneNumberData>();
            // Location = new Location();
            Culture = CultureInfo.GetCultureInfo("ru");
        }
    }

    internal class Name : IFakerName
    {
        public string First => NameData.FirstNames.GetRandom();

        public string Last => NameData.LastNames.GetRandom();

        public string Full => $"{First} {Last}";

        public string Suffix => throw new NotImplementedException();

        public string Prefix => throw new NotImplementedException();

        public string Job => $"{NameData.TitleLevel.GetRandom()} {NameData.TitleDescriptor.GetRandom()} {NameData.TitleJob.GetRandom()}";
    }
}
