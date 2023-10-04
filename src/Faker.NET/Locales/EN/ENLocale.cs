using Faker.NET.API;
using Faker.NET.Common;
using Faker.NET.Locales.EN.Data;
using System.Globalization;

namespace Faker.NET.Locales.EN
{
    internal class ENLocale : IFakerInstance
    {
        public ENLocale()
        {
            Computer = new Computer();
            Name = new Name();
            User = new User();
            Lorem = new Lorem(LoremIpsum.Words);
            Location = new Location();
            PhoneNumber = new PhoneNumber();
        }

        public IFakerName Name { get; }

        public IFakerUser User { get; }

        public IFakerLorem Lorem { get; }

        public IFakerLocation Location { get; }

        public IFakerPhoneNumber PhoneNumber { get; }

        public IFakerComputer Computer { get; }

        public CultureInfo Culture { get; } = CultureInfo.GetCultureInfo("en");
    }
}
