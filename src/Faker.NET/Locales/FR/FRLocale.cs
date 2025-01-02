using Faker.NET.Extensions;
using Faker.NET.Implementations;
using Faker.NET.Interfaces;
using Faker.NET.Locales.FR.Data;
using System.Globalization;

namespace Faker.NET.Locales.FR
{
    internal class FRLocale : FakerLocaleInstance
    {
        public FRLocale()
        {
            Name = new Name();
            Culture = CultureInfo.GetCultureInfo("fr");
        }
    }

    internal class Name : IFakerName
    {
        public string First => NameData.FirstNames.GetRandom();

        public string Last => NameData.LastNames.GetRandom();

        public string Full => $"{First} {Last}";

        public string Suffix => throw new NotImplementedException();

        public string Prefix => throw new NotImplementedException();

        public string Job => throw new NotImplementedException();

        public string Email => throw new NotImplementedException();
    }
}
