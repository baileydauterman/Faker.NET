using Faker.NET.API;
using Faker.NET.Common;
using Faker.NET.Locales.EN.Data;

namespace Faker.NET.Locales.EN
{
    public class Lorem : IFakerLorem
    {
        public string GetText(int words) => LoremIpsum.Words.CreateRandomString(words);

        public string GetText(int min, int max) => LoremIpsum.Words.CreateRandomLengthString(min, max);
    }
}
