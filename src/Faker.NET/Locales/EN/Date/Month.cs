using Faker.NET.Common;

namespace Faker.NET.EN.Date
{
    internal class Month : FakerText
    {
        public Month(string culture = null) 
            : base()
        {
        }

        public override string Get(bool useAlternate = false)
        {
            return useAlternate ?
                Culture.DateTimeFormat.AbbreviatedMonthNames[Randomizer.Next(12)] :
                Culture.DateTimeFormat.MonthNames[Randomizer.Next(12)];
        }
    }
}
