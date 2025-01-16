using System.Globalization;
using Faker.NET.Implementations.Definitions;
using Faker.NET.Implementations.Modules;

namespace Faker.NET.Locales.ES
{
    internal class ESLocale : FakerLocaleInstance
    {
        public ESLocale()
        {
            Lorem = new FakerLorem<BaseFakerLoremDefinition>();
            Culture = CultureInfo.GetCultureInfo("es");
        }
    }
}
