using Faker.NET.Common;
using Faker.NET.Interfaces;
using Faker.NET.Locales.EN;
using System.Globalization;

namespace Faker.NET.Locales.AR
{
    internal class ARLocale : IFakerInstance
    {
        public ARLocale()
        {
            Computer = new Computer();
            Name = new Names.Name();
        }
        public IFakerComputer Computer { get; }

        public IFakerName Name { get; }

        public IFakerLocation Location => throw new FakerInstanceNotImplementedException(nameof(Location));

        public IFakerLorem Lorem => throw new FakerInstanceNotImplementedException(nameof(Lorem));

        public IFakerUser User => throw new FakerInstanceNotImplementedException(nameof(User));

        public IFakerPhoneNumber PhoneNumber => throw new FakerInstanceNotImplementedException(nameof(PhoneNumber));

        public CultureInfo Culture => CultureInfo.GetCultureInfo("ar");
    }
}
