using Faker.NET.Common;
using Faker.NET.Interfaces;
using Faker.NET.Locales.EN.Data;
using System.Globalization;

namespace Faker.NET.Locales.EN;

internal class ENLocale : IFakerLocaleInstance
{
    public ENLocale()
    {
        Name = new EnFakerName();
        User = new EnFakerUser();
        Lorem = new FakerLorem(LoremIpsum.Words);
        Location = new EnFakerLocation();
        PhoneNumber = new EnFakerPhoneNumber();
    }

    public IFakerName Name { get; }

    public IFakerUser User { get; }

    public IFakerLorem Lorem { get; }

    public IFakerLocation Location { get; }

    public IFakerPhoneNumber PhoneNumber { get; }

    public CultureInfo Culture { get; } = CultureInfo.GetCultureInfo("en");
}
