using Faker.NET.Common;

namespace Faker.NET.Locales.EN.Date
{
    public static class Date
    {
        public static string Day
        {
            get => day.Get();
        }

        public static string DayAbbreviated
        {
            get => day.Get(true);
        }

        public static string DateNum
        {
            get => Randomizer.Next(1,31).ToString();
        }

        public static string Month
        {
            get => month.Get();
        }

        public static string MonthAbbreviated
        {
            get => month.Get(true);
        }

        public static string Year
        {
            get => Randomizer.Next(1995, 2025).ToString();
        }

        private static Month month = new();
        private static Day day = new();
    }
}
