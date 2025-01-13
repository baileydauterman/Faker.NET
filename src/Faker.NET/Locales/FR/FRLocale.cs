using System.Globalization;
using Faker.NET.Implementations;
using Faker.NET.Implementations.Modules;
using Faker.NET.Locales.FR.Data;

namespace Faker.NET.Locales.FR
{
    internal class FRLocale : FakerLocaleInstance
    {
        public FRLocale()
        {
            Person = new FakerPerson<FrFakerPersonData>();
            Culture = CultureInfo.GetCultureInfo("fr");
        }
    }
}
