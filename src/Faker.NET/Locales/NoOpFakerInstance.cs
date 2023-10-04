using Faker.NET.API;
using System.Globalization;

namespace Faker.NET.Locales
{
    public class NoOpFakerInstance : IFakerInstance
    {
        public IFakerComputer Computer => throw new NotImplementedException();

        public IFakerName Name => throw new NotImplementedException();

        public IFakerLocation Location => throw new NotImplementedException();

        public IFakerLorem Lorem => throw new NotImplementedException();

        public IFakerUser User => throw new NotImplementedException();

        public IFakerPhoneNumber PhoneNumber => throw new NotImplementedException();

        public CultureInfo Culture => throw new NotImplementedException();
    }
}
