using System.Text;
using Faker.NET.Extensions;
using Faker.NET.Interfaces;

namespace Faker.NET.Common
{
    internal class FakerLorem : IFakerLorem
    {
        public FakerLorem(string[] words)
        {
            _words = words;
        }

        public string GetWords(int words) => _words.CreateRandomString(words);

        public string GetWords(int min, int max) => _words.CreateRandomLengthString(min, max);

        public string GetParagraphs(int count)
        {
            var builder = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                var paragraph = GetSentences(4, 12);
                builder.Append(paragraph);
            }

            return builder.ToString().Trim();
        }

        public string GetParagrphs(int min, int max)
        {
            var exact = Faker.Randomizer.Next(min, max);
            return GetParagraphs(exact);
        }

        public string GetSentences(int count)
        {
            var builder = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                var sentence = GetWords(4, 18);
                builder.Append($"{sentence}. ");
            }

            return builder.ToString().Trim();
        }

        public string GetSentences(int min, int max)
        {
            var exact = Faker.Randomizer.Next(min, max);
            return GetSentences(exact);
        }

        private readonly string[] _words;
    }
}
