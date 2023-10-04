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
        }

        public IFakerComputer Computer { get; }

        public IFakerName Name { get; }

        public IFakerLocation Location => throw new FakerInstanceNotImplementedException(nameof(Location));

        public IFakerLorem Lorem { get; }

        public IFakerUser User => throw new NotImplementedException(nameof(User));

        public IFakerPhoneNumber PhoneNumber => throw new NotImplementedException(nameof(PhoneNumber));

        public CultureInfo Culture { get; } = CultureInfo.GetCultureInfo("ru");
    }
}
