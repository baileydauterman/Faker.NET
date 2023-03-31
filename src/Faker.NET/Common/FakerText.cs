using System.Globalization;

namespace Faker.NET.Common
{
    public class FakerText
    {
        /// <summary>
        /// Used for date times
        /// </summary>
        /// <param name="culture"></param>
        public FakerText(string culture = null)
        {
            _culture = string.IsNullOrEmpty(culture)
                ? CultureInfo.CurrentCulture
                : CultureInfo.GetCultureInfo(culture);
        }

        public virtual string Get(bool useAlternate = false)
        {
            return useAlternate ?
                Native[Randomizer.Next(Native.Count)] :
                Translated[Randomizer.Next(Translated.Count)];
        }

        public CultureInfo _culture { get; set; }

        public List<string> Native { get; set; }

        public List<string> Translated { get; set; }
    }
}
