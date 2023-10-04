using Faker.NET.API;
using Faker.NET.Common;
using Faker.NET.Locales.EN;
using System.Globalization;

namespace Faker.NET.Locales.RU
{
    public class RULocale : IFakerInstance
    {
        public RULocale()
        {
            Computer = new Computer();
            Name = new Name();
            Lorem = new Lorem();
            PhoneNumber = new PhoneNumber();
        }

        public IFakerComputer Computer { get; }

        public IFakerName Name { get; }

        public IFakerLocation Location => throw new FakerMemberNotImplementedException(SupportedFakerLocales.Russian, nameof(Location));

        public IFakerLorem Lorem { get; }

        public IFakerUser User => throw new FakerMemberNotImplementedException(SupportedFakerLocales.Russian, nameof(User));

        public IFakerPhoneNumber PhoneNumber { get; }

        public CultureInfo Culture { get; } = CultureInfo.GetCultureInfo("ru");
    }
}
