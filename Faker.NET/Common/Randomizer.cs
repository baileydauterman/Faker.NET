namespace Faker.NET.Common
{
    public static class Randomizer
    {
        public static int Next(int max)
        {
            return random.Next(max);
        }

        private static Random random = new Random();
        private static int Temp = 0;
    }
}
