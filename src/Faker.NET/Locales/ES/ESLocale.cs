using Faker.NET.Common;
using Faker.NET.Implementations;
using Faker.NET.Interfaces;
using Faker.NET.Locales.ES.Data;
using System.Globalization;

namespace Faker.NET.Locales.ES
{
    internal class ESLocale : FakerLocaleInstance
    {
        public ESLocale()
        {
            Lorem = new FakerLorem(LoremIpsum.Words);
            Culture = CultureInfo.GetCultureInfo("es");
        }
    }
}
