using Faker.NET.Implementations.Modules;
using Faker.NET.Locales.DE.Data;

namespace Faker.NET.Locales.DE
{
    internal class DELocale : FakerLocaleInstance
    {
        public DELocale() : base("de")
        {
            Person = new FakerPerson();
            PhoneNumber = new FakerPhone<DePhoneNumberData>();
            Lorem = new FakerLorem();
            Location = new FakerLocation<DeLocationData>();
        }
    }
}

