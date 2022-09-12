using Faker.NET.Common;

namespace Faker.NET.EN.Date
{
    internal class Day : FakerText
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
