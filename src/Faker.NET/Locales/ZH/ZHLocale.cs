using Faker.NET.Common.Exceptions;
using Faker.NET.Extensions;
using Faker.NET.Interfaces;
using Faker.NET.Locales.ZH.Data;
using System.Globalization;

namespace Faker.NET.Locales.ZH
{
    internal class ZHLocale : IFakerLocaleInstance
    {
        public ZHLocale()
        {
            Name = new Name();
        }

        public IFakerName Name { get; }

        public IFakerLocation Location => ThrowHelper.FakerMemberNotImplementedException(Location, FakerLocale.Mandarin, nameof(Location));

        public IFakerLorem Lorem => ThrowHelper.FakerMemberNotImplementedException(Lorem, FakerLocale.Mandarin, nameof(Lorem));

        public IFakerUser User => ThrowHelper.FakerMemberNotImplementedException(User, FakerLocale.Mandarin, nameof(User));

        public IFakerPhoneNumber PhoneNumber => ThrowHelper.FakerMemberNotImplementedException(PhoneNumber, FakerLocale.Mandarin, nameof(PhoneNumber));

        public CultureInfo Culture { get; } = CultureInfo.GetCultureInfo("zh");
    }

    internal class Name : IFakerName
    {
        public string First => NameData.FirstNames.GetRandom();

        public string Last => NameData.LastNames.GetRandom();

        public string Full => $"{Last} {First}";

        public string Suffix => ThrowHelper.NotImplementedException(Suffix);

        public string Prefix => ThrowHelper.NotImplementedException(Prefix);

        public string Job => ThrowHelper.NotImplementedException(Job);

        public string Email => ThrowHelper.NotImplementedException(Email);
    }
}
