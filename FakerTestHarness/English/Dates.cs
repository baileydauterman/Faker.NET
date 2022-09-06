using Faker.NET.Locales.EN.Date;

namespace FakerTestHarness.English
{
    internal static class Dates
    {

        public static void Test()
        {
            Console.WriteLine(Date.Month);
            Console.WriteLine(Date.Year);
            Console.WriteLine(Date.Day);
            Console.WriteLine(Date.DateNum);
            Console.WriteLine(Date.MonthAbbreviated);
            Console.WriteLine(Date.DayAbbreviated);

            Console.WriteLine($"{Date.Day} {Date.Month} {Date.DateNum}, {Date.Year}");
        }
    }
}
