using System.Globalization;

namespace Faker.NET.Common
{
    public class FakerText
    {
        public FakerText(string? culture = null)
        {
                _culture = string.IsNullOrEmpty(culture)
                    ? CultureInfo.CurrentCulture
                    : CultureInfo.GetCultureInfo(culture);
        }

        public virtual string Get(bool useAlternate = false)
        {
            return useAlternate ? 
                Data.ElementAt(Randomizer.Next(Data.Count)) :
                AlternateData.ElementAt(Randomizer.Next(AlternateData.Count));
        }

        public CultureInfo _culture { get; set; }

        public HashSet<string> Data { get; set; }
        public HashSet<string> AlternateData { get; set; }
    }
}
