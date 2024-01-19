using Faker.NET.Interfaces;
using Faker.NET.Locales.EN;
using System.Globalization;

namespace Faker.NET.Locales.FR
{
    internal class FRLocale : IFakerInstance
    {
        public FRLocale()
        {
            Computer = new Computer();
            Name = new Name();
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
