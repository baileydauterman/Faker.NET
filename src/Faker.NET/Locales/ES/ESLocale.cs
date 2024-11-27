using Faker.NET.Common;
using Faker.NET.Interfaces;
using Faker.NET.Locales.ES.Data;
using System.Globalization;

namespace Faker.NET.Locales.ES
{
    internal class ESLocale : IFakerLocaleInstance
    {
        public ESLocale()
        {
            Lorem = new FakerLorem(LoremIpsum.Words);
        }

        public IFakerName Name => throw new NotImplementedException();

        public IFakerLocation Location => throw new NotImplementedException();

        public IFakerLorem Lorem { get; }

        public IFakerUser User => throw new NotImplementedException();

        public IFakerPhoneNumber PhoneNumber => throw new NotImplementedException();

        public CultureInfo Culture => throw new NotImplementedException();
    }
}
