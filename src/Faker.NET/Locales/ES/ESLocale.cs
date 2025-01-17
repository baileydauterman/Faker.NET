using System.Globalization;
using Faker.NET.Implementations.Modules;

namespace Faker.NET.Locales.ES
{
    internal class ESLocale : FakerLocaleInstance
    {
        public ESLocale()
        {
            Culture = CultureInfo.GetCultureInfo("es");
            Lorem = new FakerLorem();
        }
    }
}
