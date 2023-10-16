namespace Faker.NET.Common
{
    internal class NumberHelper
    {
        public static int Get(int max = 1000) => Faker.Randomizer.Next(max);

        public static int Get(int min, int max) => Faker.Randomizer.Next(min, max);

        public static string GetFromFormat(string format, char delim = '#')
        {
            var charArray = new char[format.Length];
            var i = 0;

            foreach (var ch in format)
            {
                charArray[i] = ch == delim ? $"{Faker.Randomizer.Next(0, 9)}"[0] : ch;
            }

            return new string(charArray);
        }

        public static string GetFromRandomFormat(string[] formats, char delim = '#')
        {
            var format = formats.GetRandom();
            return GetFromFormat(format, delim);
        }
    }
}
