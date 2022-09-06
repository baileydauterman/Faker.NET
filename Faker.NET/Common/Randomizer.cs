namespace Faker.NET.Common
{
    public static class Randomizer
    {
        public static int Next(int max)
        {
            return random.Next(max);
        }

        public static int Next(int min, int max)
        {
            return random.Next(min, max);
        }

        private static Random random = new Random();
    }
}
