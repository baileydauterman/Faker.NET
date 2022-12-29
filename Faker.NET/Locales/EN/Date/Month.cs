using Faker.NET.Common;

namespace Faker.NET.EN.Date
{
    internal class Month : FakerText
    {
        public Month(string? culture = null) 
            : base()
        {
        }

        public override string Get(bool useAlternate = false)
        {
            return useAlternate ?
                _culture.DateTimeFormat.AbbreviatedMonthNames[Randomizer.Next(12)] :
                _culture.DateTimeFormat.MonthNames[Randomizer.Next(12)];
        }
    }
}
