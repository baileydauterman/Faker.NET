using Faker.NET.Common;
using Faker.NET.Interfaces;
using Faker.NET.Locales.ZH.Data;
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

        public IFakerLocation Location => throw new FakerMemberNotImplementedException(FakerLocale.Mandarin, nameof(Location));

        public IFakerLorem Lorem => throw new FakerMemberNotImplementedException(FakerLocale.Mandarin, nameof(Lorem));

        public IFakerUser User => throw new FakerMemberNotImplementedException(FakerLocale.Mandarin, nameof(User));

        public IFakerPhoneNumber PhoneNumber => throw new FakerMemberNotImplementedException(FakerLocale.Mandarin, nameof(PhoneNumber));

        public CultureInfo Culture { get; } = CultureInfo.GetCultureInfo("zh");
    }

    internal class Name : IFakerName
    {
        public string First => NameData.FirstNames.GetRandom();

        public string Last => NameData.LastNames.GetRandom();

        public string Full => $"{Last} {First}";

        public string Suffix => throw new NotImplementedException();

        public string Prefix => throw new NotImplementedException();

        public string Job => throw new NotImplementedException();

        public string Email => throw new NotImplementedException();
    }
}
