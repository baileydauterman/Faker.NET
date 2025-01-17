using Faker.NET.Implementations.Definitions;
using Faker.NET.Implementations.Modules;
using Faker.NET.Locales.EN.Data;

namespace Faker.NET.Locales.EN;

internal class ENLocale : FakerLocaleInstance
{
    public ENLocale() : base("en")
    {
        Airline = new FakerAirline<BaseFakerAirlineDefinition>();
        Commerce = new FakerCommerce<BaseFakerCommerceDefinition>();
        Location = new FakerLocation<EnLocationData>();
    }
}
