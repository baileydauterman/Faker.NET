using Faker.NET.Extensions;
using Faker.NET.Interfaces;

namespace Faker.NET.Common
{
    internal class Lorem : IFakerLorem
    {
        public Lorem(string[] words)
        {
            _words = words;
        }

        public string GetText(int words) => _words.CreateRandomString(words);

        public string GetText(int min, int max) => _words.CreateRandomLengthString(min, max);

        private readonly string[] _words;
    }
}
