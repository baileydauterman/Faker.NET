using System.Globalization;
using Faker.NET.API;

namespace Faker.NET.Common
{
    public class FakerText : IFaker
    {
        public FakerText()
        {
            Culture = CultureInfo.CurrentCulture;
        }

        public FakerText(string culture)
        {
            Culture = CultureInfo.GetCultureInfo(culture);
        }

        public virtual string Get(bool useAlternate = false)
        {
            return useAlternate ?
                Native[Faker.Randomizer.Next(Native.Count)] :
                Translated[Faker.Randomizer.Next(Translated.Count)];
        }

        public CultureInfo Culture { get; }

        public List<string> Native { get; set; }

        public List<string> Translated { get; set; }
    }
}
