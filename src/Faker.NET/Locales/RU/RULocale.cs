using System.Globalization;
using Faker.NET.Implementations;
using Faker.NET.Implementations.Modules;
using Faker.NET.Locales.RU.Data;

namespace Faker.NET.Locales.RU
{
    internal class RULocale : FakerLocaleInstance
    {
        public RULocale()
        {
            Person = new FakerPerson<RuFakerPersonData>();
            Lorem = new FakerLorem<RuLoremData>();
            PhoneNumber = new FakerPhone<RuPhoneNumberData>();
            Culture = CultureInfo.GetCultureInfo("ru");
        }
    }
}
