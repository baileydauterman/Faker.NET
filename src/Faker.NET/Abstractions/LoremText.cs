using System;
using Faker.NET.API;
using Faker.NET.Common;

namespace Faker.NET.Abstractions
{
    public class LoremText : IFaker
    {
        public LoremText(List<string> words)
        {
            Words = words;
        }

        public LoremText(params string[] words)
        {
            Words = words.ToList();
        }

        public string Get(bool useAlternate = false)
        {
            return Words[Randomizer.Next(Words.Count)];
        }

        public virtual string GetText(int words)
        {
            return string.Join(' ', GetWords(words));
        }

        public virtual string GetText(int minWords, int maxWords)
        {
            var words = Randomizer.Next(minWords, maxWords);
            return string.Join(' ', GetWords(words));
        }

        private IEnumerable<string> GetWords(int words)
        {
            while (words-- != 0)
            {
                yield return Get();
            }
        }

        public List<string> Words { get; }
    }
}

