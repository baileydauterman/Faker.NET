using Faker.NET.Common;
using Faker.NET.Interfaces;
using Faker.NET.Locales.RU.Data;

namespace Faker.NET.Locales.RU
{
    internal class Name : IFakerName
    {
        public string First => NameData.FirstNames.GetRandom();

        public string Last => NameData.LastNames.GetRandom();

        public string Full => $"{First} {Last}";

        public string Suffix => throw new NotImplementedException();

        public string Prefix => throw new NotImplementedException();

        public string Job => $"{NameData.TitleLevel.GetRandom()} {NameData.TitleDescriptor.GetRandom()} {NameData.TitleJob.GetRandom()}";

        public string Email => EmailHelper.Generate(First, Last);
    }
}
