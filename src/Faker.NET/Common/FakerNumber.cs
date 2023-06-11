﻿using System.Text;
using Faker.NET.API;

namespace Faker.NET.Common
{
    public class FakerNumber : IFaker
    {
        public string Get(string format)
        {
            return Convert(format);
        }

        public string Get(bool useAlternate = false)
        {
            return useAlternate ? Convert(Format) : Convert(AltFormat);
        }

        public string Get(int startRange, int endRange)
        {
            return Randomizer.Next(startRange, endRange).ToString();
        }

        internal string Convert(string format)
        {
            if (string.IsNullOrWhiteSpace(format))
            {
                return string.Empty;
            }

            var sb = new StringBuilder();
            foreach (char c in format)
            {
                if (c == '#')
                {
                    sb.Append(Randomizer.Next(9));
                    continue;
                }

                sb.Append(c);
            }

            return sb.ToString();
        }

        public string Format { get; set; }
        public string AltFormat { get; set; }
    }
}
