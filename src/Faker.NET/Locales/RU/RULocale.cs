using Faker.NET.Implementations.Modules;
using Faker.NET.Locales.RU.Data;

namespace Faker.NET.Locales.RU
{
    internal class RULocale : FakerLocaleInstance
    {
        public RULocale() : base("ru")
        {
            PhoneNumber = new FakerPhone<RuPhoneNumberData>();
        }
    }
}
