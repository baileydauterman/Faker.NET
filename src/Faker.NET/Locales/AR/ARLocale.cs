using Faker.NET.API;
using Faker.NET.Common;
using Faker.NET.EN.Computer;

namespace Faker.NET.Locales.AR
{
    internal class ARLocale : IFakerLocale
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
    }
}
