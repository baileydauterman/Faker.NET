using Faker.NET.Implementations.Modules;
using Faker.NET.Locales.DE.Data;

namespace Faker.NET.Locales.DE
{
    internal class DELocale : FakerLocaleInstance
    {
        public DELocale() : base("de")
        {
            Location = new FakerLocation<DeLocationData>();
        }
    }
}

