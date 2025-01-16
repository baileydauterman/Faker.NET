using Faker.NET.Implementations.Definitions;
using Faker.NET.Implementations.Modules;
using Faker.NET.Locales.EN.Data;

namespace Faker.NET.Locales.EN;

internal class ENLocale : FakerLocaleInstance
{
    public ENLocale()
    {
        Culture = System.Globalization.CultureInfo.GetCultureInfo("en");

        Person = new FakerPerson<BaseFakerPersonDefinition>();
        Airline = new FakerAirline<BaseFakerAirlineDefinition>();
        Commerce = new FakerCommerce<BaseFakerCommerceDefinition>();
        Location = new FakerLocation<EnLocationData>();
        Word = new FakerWord<EnWordData>();
        Date = new FakerDate();
        Internet = new FakerInternet<BaseFakerInternetDefinition>();
        PhoneNumber = new FakerPhone<EnFakerPhoneData>();
        Lorem = new FakerLorem<BaseFakerLoremDefinition>();
    }
}
