using Faker.NET.Implementations;
using Faker.NET.Locales.ES.Data;
using System.Globalization;

namespace Faker.NET.Locales.ES
{
    internal class ESLocale : FakerLocaleInstance
    {
        public ESLocale()
        {
            Lorem = new FakerLorem<EsLoremData>();
            Culture = CultureInfo.GetCultureInfo("es");
        }
    }
}
