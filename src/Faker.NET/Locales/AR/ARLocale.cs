using Faker.NET.Extensions;
using Faker.NET.Common.Exceptions;
using Faker.NET.Interfaces;
using Faker.NET.Locales.AR.Data;
using System.Globalization;
using Faker.NET.Implementations;

namespace Faker.NET.Locales.AR
{
    internal class ARLocale : FakerLocaleInstance
    {
        public ARLocale()
        {
            Name = new Name();
            Culture = CultureInfo.GetCultureInfo("ar");
        }
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
