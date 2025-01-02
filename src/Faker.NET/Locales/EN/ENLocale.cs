using Faker.NET.Common;
using Faker.NET.Implementations;
using Faker.NET.Locales.EN.Data;

namespace Faker.NET.Locales.EN;

internal class ENLocale : FakerLocaleInstance
{
    public ENLocale()
    {
        Commerce = new FakerCommerce<Data.EnCommerce>();
        Location = new FakerLocation<EnLocationData>();

        Name = new EnFakerName();
        User = new EnFakerUser();
        Lorem = new FakerLorem(LoremIpsum.Words);
        PhoneNumber = new EnFakerPhoneNumber();
    }
}
