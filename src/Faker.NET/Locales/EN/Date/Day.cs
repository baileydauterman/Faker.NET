using Faker.NET.Common;

namespace Faker.NET.EN.Date
{
    internal class Day : FakerText
    {
        /// <summary>
        /// Initializes the days based off of the culture provided.
        /// If none is provided it will use the current culture of the machine.
        /// </summary>
        /// <param name="culture"></param>
        public Day(string culture) : base()
        {
        }

        /// <summary>
        /// Returns a day of the week based on current culture
        /// </summary>
        /// <param name="useAlternate"></param>
        /// <returns></returns>
        public override string Get(bool useAlternate = false)
        {
            return useAlternate ?
                _culture.DateTimeFormat.AbbreviatedDayNames[Randomizer.Next(7)] :
                _culture.DateTimeFormat.DayNames[Randomizer.Next(7)];
        }
    }
}
