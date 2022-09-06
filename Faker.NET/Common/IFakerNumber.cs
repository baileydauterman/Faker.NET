using System.Text;

namespace Faker.NET.Common
{
    public class IFakerNumber
    {
        public IFakerNumber()
        {
        }

        public string Get()
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

        public string Get(bool useAlternate)
        {
            var sb = new StringBuilder();
            foreach (char c in AltFormat)
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
