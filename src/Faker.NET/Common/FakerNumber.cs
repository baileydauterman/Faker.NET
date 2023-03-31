using System.Text;

namespace Faker.NET.Common
{
    public class FakerNumber
    {
        public string Get()
        {
            return ConvertFormatToNumbers(Format);
        }

        public string Get(bool useAlternate)
        {
            return ConvertFormatToNumbers(AltFormat);
        }

        public string Get(string customFormat)
        {
            return ConvertFormatToNumbers(customFormat);
        }

        private string ConvertFormatToNumbers(string format)
        {
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
