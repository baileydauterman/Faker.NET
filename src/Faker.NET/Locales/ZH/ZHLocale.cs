using Faker.NET.Interfaces;
using Faker.NET.Common;
using Faker.NET.Locales.EN;
using System.Globalization;

namespace Faker.NET.Locales.ZH
{
    internal class ZHLocale : IFakerInstance
    {
        public ZHLocale()
        {
            Computer = new Computer();
            Name = new Name();
        }

        public IFakerComputer Computer { get; }

        public IFakerName Name { get; }

        public IFakerLocation Location => throw new FakerMemberNotImplementedException(SupportedFakerLocales.Mandarin, nameof(Location));

        public IFakerLorem Lorem => throw new FakerMemberNotImplementedException(SupportedFakerLocales.Mandarin, nameof(Lorem));

        public IFakerUser User => throw new FakerMemberNotImplementedException(SupportedFakerLocales.Mandarin, nameof(User));

        public IFakerPhoneNumber PhoneNumber => throw new FakerMemberNotImplementedException(SupportedFakerLocales.Mandarin, nameof(PhoneNumber));

        public CultureInfo Culture { get; } = CultureInfo.GetCultureInfo("zh");
    }
}
