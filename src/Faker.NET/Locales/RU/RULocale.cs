using System.Globalization;
using Faker.NET.Implementations.Modules;
using Faker.NET.Locales.RU.Data;

namespace Faker.NET.Locales.RU
{
    internal class RULocale : FakerLocaleInstance
    {
        public RULocale()
        {
            Culture = CultureInfo.GetCultureInfo("ru");

            Person = new FakerPerson<RuFakerPersonData>();
            Lorem = new FakerLorem();
            PhoneNumber = new FakerPhone<RuPhoneNumberData>();
        }
    }
}
