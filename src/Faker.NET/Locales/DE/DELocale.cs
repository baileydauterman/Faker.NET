using Faker.NET.Implementations.Modules;
using Faker.NET.Locales.DE.Data;

namespace Faker.NET.Locales.DE
{
    internal class DELocale : FakerLocaleInstance
    {
        public DELocale() : base("de")
        {
            PhoneNumber = new FakerPhone<DePhoneNumberData>();
            Location = new FakerLocation<DeLocationData>();
        }
    }
}

