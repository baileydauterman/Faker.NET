﻿using System.Text;
using Faker.NET.Interfaces.Modules;

namespace Faker.NET.Implementations.Modules
{
    internal class FakerNumber : IFakerNumber
    {
        public long BigInt(long min = long.MinValue, long max = long.MaxValue)
        {
            throw new NotImplementedException();
        }

        public string Binary(int min = int.MinValue, int max = int.MaxValue)
        {
            throw new NotImplementedException();
        }

        public float Float(float min = float.MinValue, float max = float.MaxValue)
        {
            throw new NotImplementedException();
        }

        public string Hex(int min = 0, int max = 15)
        {
            throw new NotImplementedException();
        }

        public string Int(int min = int.MinValue, int max = int.MaxValue)
        {
            throw new NotImplementedException();
        }

        public string Octal(int min = 0, int max = 7)
        {
            throw new NotImplementedException();
        }

        public string RomanNumeral(int min = 0, int max = 3999)
        {
            if (min <= 0 || max > 3999)
            {
                throw new ArgumentOutOfRangeException($"Input must be between 1 and 3999.\nmin: {min}\nmax: {max}");
            }

            var num = Faker.Randomizer.Next(min, max);
            StringBuilder roman = new StringBuilder();

            (int value, string numeral)[] map = new (int, string)[]
            {
                (1000, "M"),
                (900, "CM"),
                (500, "D"),
                (400, "CD"),
                (100, "C"),
                (90, "XC"),
                (50, "L"),
                (40, "XL"),
                (10, "X"),
                (9, "IX"),
                (5, "V"),
                (4, "IV"),
                (1, "I")
            };

            foreach (var (value, numeral) in map)
            {
                while (num >= value)
                {
                    roman.Append(numeral);
                    num -= value;
                }
            }

            return roman.ToString();
        }
    }
}
