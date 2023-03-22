using System.Globalization;

namespace Faker.NET.Common
{
    public class FakerText
    {
        /// <summary>
        /// Used for date times
        /// </summary>
        /// <param name="culture"></param>
        public FakerText(string? culture = null)
        {
                _culture = string.IsNullOrEmpty(culture)
                    ? CultureInfo.CurrentCulture
                    : CultureInfo.GetCultureInfo(culture);
        }

        public virtual string Get(bool useAlternate = false)
        {
            return useAlternate ? 
                Native.ElementAt(Randomizer.Next(Native.Count)) :
                Translated.ElementAt(Randomizer.Next(Translated.Count));
        }

        public CultureInfo _culture { get; set; }

        public HashSet<string> Native { get; set; }

        public HashSet<string> Translated { get; set; }
    }
}
