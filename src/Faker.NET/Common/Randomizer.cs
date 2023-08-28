namespace Faker.NET.Common
{
    public static class Randomizer
    {
        public static string GetRandom(this string[] array)
        {
            return array[random.Next(array.Length)];
        }

        public static int Next(int max)
        {
            return random.Next(max);
        }

        public static int Next(int min, int max)
        {
            return random.Next(min, max);
        }

        public static void SetSeed(int seed)
        {
            Seed = seed;
            random = new Random(Seed.Value);
        }

        public static void Reset()
        {
            random = new Random();
        }

        private static Random random = new Random();

        public static int? Seed { get; private set; } = null;
    }
}
