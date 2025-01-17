using Faker.NET.Implementations.Modules;

namespace Faker.NET.Locales.ES
{
    internal class ESLocale : FakerLocaleInstance
    {
        public ESLocale() : base("es")
        {
            Lorem = new FakerLorem();
        }
    }
}
