using Faker.NET.Common;

namespace Faker.NET.Locales.EN.Date
{
    internal class Month : IFakerText
    {
        public Month() : base()
        {
            Data = new()
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December",
            };

            AlternateData = new()
            {
                "Jan",
                "Feb",
                "Mar",
                "Apr",
                "May",
                "Jun",
                "Jul",
                "Aug",
                "Sep",
                "Oct",
                "Nov",
                "Dec",
            };
        }
    }
}
