using Faker.NET.Common;

namespace Faker.NET.EN.Date
{
    public static class Date
    {
        public static string Day => day.Get();

        public static string DayAbbreviated => day.Get(true);

        public static string DateNum => Randomizer.Next(1, 31).ToString();

        public static string Month => month.Get();

        public static string MonthAbbreviated => month.Get(true);

        public static string MonthNum => Randomizer.Next(1, 12).ToString();

        public static string Year => Randomizer.Next(YearMin, YearMax).ToString();

        public static string Hour => Randomizer.Next(1, 12).ToString();

        public static string Hour24 => Randomizer.Next(1, 24).ToString();

        public static string Minute => Randomizer.Next(0, 60).ToString();

        public static string Second => Randomizer.Next(0, 60).ToString();

        public static string FullDateTime => NowFormatted("dddd, MMMM dd, yyyy h:mm:ss tt");

        public static string Formatted(string format)
        {
            var dt = new DateTime(int.Parse(Year), int.Parse(MonthNum), int.Parse(DateNum), int.Parse(Hour), int.Parse(Minute), int.Parse(Second));
            return dt.ToString(format);
        }

        public static string NowFormatted(string format)
        {
            return DateTime.Now.ToString(format);
        }

        private static Month month = new();
        private static Day day = new();


        public static int YearMin { get; set; } = 1941;
        public static int YearMax { get; set; } = 2022;
    }
}
