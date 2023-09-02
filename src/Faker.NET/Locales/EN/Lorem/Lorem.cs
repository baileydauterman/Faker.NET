using Faker.NET.API;
using Faker.NET.Common;

namespace Faker.NET.EN
{
    public class Lorem : IFakerLorem
    {
        public string GetText(int words) => LoremIpsum.Words.CreateRandomString(words);

        public string GetText(int min, int max) => LoremIpsum.Words.CreateRandomLengthString(min, max);
    }
}
