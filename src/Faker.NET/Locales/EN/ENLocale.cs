using Faker.NET.API;
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
            Lorem = new Lorem();
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
