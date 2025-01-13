using System.Globalization;
using Faker.NET.Implementations;
using Faker.NET.Implementations.Modules;
using Faker.NET.Locales.DE.Data;

namespace Faker.NET.Locales.DE
{
    internal class DELocale : FakerLocaleInstance
    {
        public DELocale()
        {
            Person = new FakerPerson<DeFakerPersonData>();
            PhoneNumber = new FakerPhone<DePhoneNumberData>();
            Lorem = new FakerLorem<DeLoremData>();
            Location = new FakerLocation<DeLocationData>();
            Culture = CultureInfo.GetCultureInfo("de");
        }
    }
}

