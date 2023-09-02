namespace Faker.NET.Common
{
    public class Randomizer
    {
        public int Next(int max)
        {
            return _random.Next(max);
        }

        public int Next(int min, int max)
        {
            return _random.Next(min, max);
        }

        public byte[] NextBytes(int count)
        {
            var bytes = new byte[count];
            _random.NextBytes(bytes);
            return bytes;
        }

        public byte[] NextBytes(byte[] bytes)
        {
            _random.NextBytes(bytes);
            return bytes;
        }

        public void SetSeed(int seed)
        {
            _random = new Random(seed);
        }

        public void Reset()
        {
            _random = new Random();
        }

        private Random _random = new Random();
    }

    public static class RandomizerExtensions
    {
        public static string GetRandom(this string[] array)
        {
            return array[Faker.Randomizer.Next(array.Length)];
        }

        public static string CreateRandomString(this string[] array, int words)
        {
            var wordArray = new string[words];

            while (words-- > 0)
            {
                wordArray[words] = array.GetRandom();
            }

            return string.Join(" ", wordArray);
        }

        public static string CreateRandomLengthString(this string[] array, int min, int max)
        {
            var value = Faker.Randomizer.Next(min, max);
            return array.CreateRandomString(value);
        }
    }
}
