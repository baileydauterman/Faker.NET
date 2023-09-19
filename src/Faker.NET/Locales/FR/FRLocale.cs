using Faker.NET.API;
using Faker.NET.EN.Computer;
using System.Globalization;

namespace Faker.NET.Locales.FR
{
    internal class FRLocale : IFakerLocale
    {
        public FRLocale()
        {
            Computer = new Computer();
            Name = new Names.Name();
        }

        public IFakerComputer Computer { get; }

        public IFakerName Name { get; }

        public IFakerLocation Location => throw new NotImplementedException();

        public IFakerLorem Lorem => throw new NotImplementedException();

        public IFakerUser User => throw new NotImplementedException();

        public IFakerPhoneNumber PhoneNumber => throw new NotImplementedException();

        public CultureInfo Culture { get; } = CultureInfo.GetCultureInfo("fr");
    }
}
