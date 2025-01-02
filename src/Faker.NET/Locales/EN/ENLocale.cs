using Faker.NET.Common;
using Faker.NET.Implementations;
using Faker.NET.Locales.EN.Data;

namespace Faker.NET.Locales.EN;

internal class ENLocale : FakerLocaleInstance
{
    public ENLocale()
    {
        Commerce = new FakerCommerce<EnCommerce>();
        Location = new FakerLocation<EnLocationData>();
        Word = new FakerWord<EnWordData>();

        Name = new EnFakerName();
        User = new EnFakerUser();
        Lorem = new FakerLorem(LoremIpsum.Words);
        PhoneNumber = new EnFakerPhoneNumber();
    }
}
