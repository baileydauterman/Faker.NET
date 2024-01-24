using Faker.NET.Common;
using Faker.NET.Interfaces;
using Faker.NET.Locales.ZH.Data;

namespace Faker.NET.Locales.ZH
{
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
