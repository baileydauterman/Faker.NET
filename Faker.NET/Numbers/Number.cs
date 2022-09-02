using Faker.NET.Common;
using System.Text;

namespace Faker.NET.Numbers
{
    public static class Number
    {
        public static string NumberString
        {
            get
            {
                var sb = new StringBuilder();
                foreach (char c in Format)
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
        }

        public static string Format
        {
            get => _format;

            set
            {
                _format = value;
            }
        }

        public static string _format = "###-###-####";
    }
}
