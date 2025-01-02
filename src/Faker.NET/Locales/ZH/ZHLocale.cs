using Faker.NET.Common.Exceptions;
using Faker.NET.Extensions;
using Faker.NET.Implementations;
using Faker.NET.Interfaces;
using Faker.NET.Locales.ZH.Data;
using System.Globalization;

namespace Faker.NET.Locales.ZH
{
    internal class ZHLocale : FakerLocaleInstance
    {
        public ZHLocale()
        {
            Name = new Name();
        }
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
