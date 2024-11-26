using Faker.NET.Common;
using Faker.NET.Common.Exceptions;
using Faker.NET.Interfaces;
using Faker.NET.Locales.AR.Data;
using System.Globalization;

namespace Faker.NET.Locales.AR
{
    internal class ARLocale : IFakerLocaleInstance
    {
        public ARLocale()
        {
            Name = new Name();
        }

        public IFakerName Name { get; }

        public IFakerLocation Location => ThrowHelper.FakerInstanceNotImplementedException(Location, nameof(Location));

        public IFakerLorem Lorem => throw new FakerInstanceNotImplementedException(nameof(Lorem));

        public IFakerUser User => throw new FakerInstanceNotImplementedException(nameof(User));

        public IFakerPhoneNumber PhoneNumber => throw new FakerInstanceNotImplementedException(nameof(PhoneNumber));

        public CultureInfo Culture => CultureInfo.GetCultureInfo("ar");
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
