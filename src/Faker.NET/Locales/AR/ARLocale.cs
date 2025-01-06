using System.Globalization;
using Faker.NET.Implementations;
using Faker.NET.Locales.AR.Data;

namespace Faker.NET.Locales.AR
{
    internal class ARLocale : FakerLocaleInstance
    {
        public ARLocale()
        {
            Person = new FakerPerson<ArPersonData>();
            Culture = CultureInfo.GetCultureInfo("ar");
        }
    }
}
