using Faker.NET.API;
using Faker.NET.Common;
using Faker.NET.Locales.EN.Names;

namespace Faker.NET.EN.Names
{
    public class Name : IFakerName
    {
        public string First => NameData.FirstNames.GetRandom();

        public string Last => NameData.LastNames.GetRandom();

        public string Full => $"{First} {Last}";

        public string Suffix => NameData.Suffix.GetRandom();

        public string Prefix => NameData.Prefix.GetRandom();

        public string Job => $"{NameData.TitleLevel.GetRandom()} {NameData.TitleDescriptor.GetRandom()} {NameData.TitleJob.GetRandom()}";

        public string Email => EmailHelper.Generate(First, Last);
    }
}
