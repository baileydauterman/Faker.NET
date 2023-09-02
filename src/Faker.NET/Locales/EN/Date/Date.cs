namespace Faker.NET.EN.Date
{
    public static class Date
    {
        /// <summary>
        /// Returns full name of Day (e.g. Monday, Tuesday, etc.)
        /// </summary>
        public static string Day => Faker.Culture.DateTimeFormat.DayNames[Faker.Randomizer.Next(7)];

        /// <summary>
        /// Returns abbreviated name of Day (e.g. Mon, Tue, etc.)
        /// </summary>
        public static string DayAbbreviated => Faker.Culture.DateTimeFormat.AbbreviatedDayNames[Faker.Randomizer.Next(7)];

        /// <summary>
        /// Returns random day between 1 and 31
        /// </summary>
        public static string DateNum => Faker.Randomizer.Next(1, 31).ToString();

        /// <summary>
        /// Returns full name of month (e.g. January, February, etc.)
        /// </summary>
        public static string Month => Faker.Culture.DateTimeFormat.MonthNames[Faker.Randomizer.Next(12)];

        /// <summary>
        /// Returns abbreviated name of month (e.g. Jan, Feb, etc.)
        /// </summary>
        public static string MonthAbbreviated => Faker.Culture.DateTimeFormat.AbbreviatedMonthNames[Faker.Randomizer.Next(12)];

        /// <summary>
        /// Returns month number (e.g. 1, 2, 3, etc.)
        /// </summary>
        public static string MonthNum => Faker.Randomizer.Next(1, 12).ToString();

        /// <summary>
        /// Returns year between 1941 and 2022
        /// </summary>
        public static string Year => Faker.Randomizer.Next(YearMin, YearMax).ToString();

        public static string Hour => Faker.Randomizer.Next(1, 12).ToString();

        public static string Hour24 => Faker.Randomizer.Next(1, 24).ToString();

        public static string Minute => Faker.Randomizer.Next(0, 60).ToString();

        public static string Second => Faker.Randomizer.Next(0, 60).ToString();

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

        public static int YearMin { get; set; } = 1941;
        public static int YearMax { get; set; } = DateTime.Now.Year;
    }
}
