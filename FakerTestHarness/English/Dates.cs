using Faker.NET.EN.Date;

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

            Console.WriteLine(Date.NowFormatted("MM/dd/yyyy"));
            Console.WriteLine(Date.NowFormatted("dddd, dd MMMM yyyy"));
            Console.WriteLine(Date.NowFormatted("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(Date.NowFormatted("HH:mm"));
            Console.WriteLine(Date.NowFormatted("hh:mm tt"));
            Console.WriteLine(Date.NowFormatted("H:mm"));
            Console.WriteLine(Date.NowFormatted("h:mm tt"));
            Console.WriteLine(Date.NowFormatted("HH:mm:ss"));
            Console.WriteLine(Date.NowFormatted("yyyy MMMM"));

            Console.WriteLine(Date.Formatted("MM/dd/yyyy"));
            Console.WriteLine(Date.Formatted("dddd, dd MMMM yyyy"));
            Console.WriteLine(Date.Formatted("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(Date.Formatted("HH:mm"));
            Console.WriteLine(Date.Formatted("hh:mm tt"));
            Console.WriteLine(Date.Formatted("H:mm"));
            Console.WriteLine(Date.Formatted("h:mm tt"));
            Console.WriteLine(Date.Formatted("HH:mm:ss"));
            Console.WriteLine(Date.Formatted("yyyy MMMM"));
        }
    }
}
