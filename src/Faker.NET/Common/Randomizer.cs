namespace Faker.NET.Common
{
    public class Randomizer
    {
        public Coin FlipCoin()
        {
            return Next(1, 10) > 5 ? Coin.Heads : Coin.Tails;
        }

        /// <summary>
        /// Get random next value
        /// </summary>
        /// <param name="max">Max of value returned</param>
        /// <returns>Random int</returns>
        public int Next(int max)
        {
            return _random.Next(max);
        }

        /// <summary>
        /// Get random next value
        /// </summary>
        /// <param name="min">Min of value returned</param>
        /// <param name="max">Max of value returned</param>
        /// <returns>Random int</returns>
        public int Next(int min, int max)
        {
            return _random.Next(min, max);
        }

        /// <summary>
        /// Creates a random byte array of given length
        /// </summary>
        /// <param name="length">Length of return value</param>
        /// <returns>Random byte array</returns>
        public byte[] NextBytes(int length)
        {
            var bytes = new byte[length];
            _random.NextBytes(bytes);
            return bytes;
        }

        /// <summary>
        /// Fills the given byte array with random values
        /// </summary>
        /// <param name="buffer">Given byte array</param>
        /// <returns>Filled byte array</returns>
        public byte[] NextBytes(byte[] buffer)
        {
            _random.NextBytes(buffer);
            return buffer;
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

        public static string GetRandom(this IList<string> array)
        {
            return array[Faker.Randomizer.Next(array.Count)];
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

    public enum Coin
    {
        Heads,
        Tails,
    }
}
