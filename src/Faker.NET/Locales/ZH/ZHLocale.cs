using Faker.NET.Implementations;
using Faker.NET.Implementations.Modules;
using Faker.NET.Locales.ZH.Data;

namespace Faker.NET.Locales.ZH
{
    internal class ZHLocale : FakerLocaleInstance
    {
        public ZHLocale()
        {
            Person = new FakerPerson<ZhFakerPersonData>();
        }
    }
}
