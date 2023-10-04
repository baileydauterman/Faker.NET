using Faker.NET.API;
using Faker.NET.Common;
using Faker.NET.Locales.FR.Data;

namespace Faker.NET.Locales.FR
{
    public class Name : IFakerName
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

