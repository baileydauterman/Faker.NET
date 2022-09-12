using Faker.NET.Common;

namespace Faker.NET.Locales.EN.Date
{
    public static class Date
    {
        public static string Day
        {
            get => day.Get();
        }

        public static string DayAbbreviated => day.Get(true);

        public static string DateNum => Randomizer.Next(1,31).ToString();

        public static string Month => month.Get();

        public static string MonthAbbreviated => month.Get(true);

        public static string Year => Randomizer.Next(1995, 2025).ToString();

        public static string NowFormatted(string format)
        {
            return DateTime.Now.ToString(format);
        }

        private static Month month = new();
        private static Day day = new();
    }
}
