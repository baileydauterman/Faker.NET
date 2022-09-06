using Faker.NET.Common;

namespace Faker.NET.Locales.EN.Date
{
    internal class Day : IFakerText
    {
        public Day() : base()
        {
            Data = new()
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
            };

            AlternateData = new()
            {
                "Sun",
                "Mon",
                "Tue",
                "Wed",
                "Thu",
                "Fri",
                "Sat"
            };
        }
    }
}
