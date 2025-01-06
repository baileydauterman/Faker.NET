using System.Text;
using Faker.NET.Extensions;

namespace Faker.NET.Common
{
    internal static class NumberHelper
    {
        public static NumericRange<int> AsRange(this (int Min, int Max) range)
        {
            return new NumericRange<int>(range.Min, range.Max);
        }

        public static int ToPercentage(this double value)
        {
            return (int)(value * 100);
        }

        public static string ToRandomString(this string format)
        {
            var charArray = Encoding.UTF8.GetChars(Encoding.UTF8.GetBytes(format));

            for (int i = 0; i < charArray.Length; i++)
            {
                var ch = charArray[i];
                var v = ch switch
                {
                    '#' => Faker.Randomizer.NextCharacter('1', '9'),
                    '!' => Faker.Randomizer.NextCharacter('1', '9'),
                    _ => ch
                };

                charArray[i] = v;
            }

            return new string(charArray);
        }

        /// <summary>
        /// Takes an array of formats and returns a random number based on the format
        /// </summary>
        /// <param name="formats">The array of formats</param>
        /// <param name="replacementChar">The character to replace in the formats</param>
        /// <returns>Randomly formatted string</returns>
        public static string ToRandomFormat(this string[] formats)
        {
            var format = formats.GetRandom();
            return format.ToRandomString();
        }
    }
}
