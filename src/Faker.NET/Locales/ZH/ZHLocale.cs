using Faker.NET.API;
using Faker.NET.EN.Computer;

namespace Faker.NET.Locales.ZH
{
    internal class ZHLocale : IFakerLocale
    {
        public IFakerComputer Computer => new Computer();

        public IFakerName Name => new Names.Name();

        public IFakerLocation Location => throw new NotImplementedException();

        public IFakerLorem Lorem => throw new NotImplementedException();

        public IFakerUser User => throw new NotImplementedException();

        public IFakerPhoneNumber PhoneNumber => throw new NotImplementedException();
    }
}
