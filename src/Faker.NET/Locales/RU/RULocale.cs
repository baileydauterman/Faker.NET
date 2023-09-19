using Faker.NET.API;
using Faker.NET.Common;
using Faker.NET.EN.Computer;
using Faker.NET.RU.Lorem;
using System.Globalization;

namespace Faker.NET.Locales.RU
{
    public class RULocale : IFakerLocale
    {
        public RULocale()
        {
            Computer = new Computer();
            Name = new Names.Name();
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
