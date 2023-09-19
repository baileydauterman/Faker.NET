using Faker.NET.API;
using System.Globalization;

namespace Faker.NET.Locales.EN
{
    internal class ENLocale : IFakerLocale
    {
        public ENLocale()
        {
            Computer = new NET.EN.Computer.Computer();
            Name = new NET.EN.Names.Name();
            User = new NET.EN.Account.User();
            Lorem = new NET.EN.Lorem();
            Location = new NET.EN.Location.Location();
            PhoneNumber = new NET.EN.PhoneNumber.PhoneNumber();
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
