using Faker.NET.API;
using Faker.NET.Common;
using Faker.NET.Locales.DE.Names;

namespace Faker.NET.DE.Names
{
    public class Name : IFakerName
    {
        public string First => NameData.FirstName.GetRandom();

        public string Last => NameData.LastName.GetRandom();

        public string Prefix => NameData.Prefix.GetRandom();

        public string Full => $"{First} {Last}";

        public string Suffix => throw new NotImplementedException();

        public string Job => throw new NotImplementedException();

        public string Email => throw new NotImplementedException();
    }
}
