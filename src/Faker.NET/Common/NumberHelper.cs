using System.Text;

namespace Faker.NET.Common
{
    internal static class NumberHelper
    {
        public static string ToRandomString(this string format, char delim = '#')
        {
            var charArray = Encoding.UTF8.GetChars(Encoding.UTF8.GetBytes(format));
            var i = 0;

            foreach (var ch in format)
            {
                // take the first value of the string to put into the charArray
                var num = $"{Faker.Randomizer.Next(0, 9)}"[0];
                charArray[i++] = ch == delim ? num : ch;
            }

            return new string(charArray);
        }

        /// <summary>
        /// Takes an array of formats and returns a random number based on the format
        /// </summary>
        /// <param name="formats">The array of formats</param>
        /// <param name="replacementChar">The character to replace in the formats</param>
        /// <returns>Randomly formatted string</returns>
        public static string ToRandomFormat(this string[] formats, char replacementChar = '#')
        {
            var format = formats.GetRandom();
            return format.ToRandomString(replacementChar);
        }
    }
}
