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
                Culture.DateTimeFormat.AbbreviatedMonthNames[Faker.Randomizer.Next(12)] :
                Culture.DateTimeFormat.MonthNames[Faker.Randomizer.Next(12)];
        }
    }
}
