using Faker.NET.Implementations.Modules;
using Faker.NET.Locales.RU.Data;

namespace Faker.NET.Locales.RU
{
    internal class RULocale : FakerLocaleInstance
    {
        public RULocale() : base("ru")
        {
            Person = new FakerPerson();
            Lorem = new FakerLorem();
            PhoneNumber = new FakerPhone<RuPhoneNumberData>();
        }
    }
}
