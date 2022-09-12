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

            Console.WriteLine(Date.NowFormatted("MM/dd/yyyy"));
            Console.WriteLine(Date.NowFormatted("dddd, dd MMMM yyyy"));
            Console.WriteLine(Date.NowFormatted("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(Date.NowFormatted("MM/dd/yyyy HH:mm"));
            Console.WriteLine(Date.NowFormatted("MM/dd/yyyy hh:mm tt"));
            Console.WriteLine(Date.NowFormatted("MM/dd/yyyy H:mm"));
            Console.WriteLine(Date.NowFormatted("MM/dd/yyyy h:mm tt"));
            Console.WriteLine(Date.NowFormatted("MM/dd/yyyy HH:mm:ss"));
            Console.WriteLine(Date.NowFormatted("MMMM dd"));
            Console.WriteLine(Date.NowFormatted("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK"));
            Console.WriteLine(Date.NowFormatted("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"));
            Console.WriteLine(Date.NowFormatted("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss"));
            Console.WriteLine(Date.NowFormatted("HH:mm"));
            Console.WriteLine(Date.NowFormatted("hh:mm tt"));
            Console.WriteLine(Date.NowFormatted("H:mm"));
            Console.WriteLine(Date.NowFormatted("h:mm tt"));
            Console.WriteLine(Date.NowFormatted("HH:mm:ss"));
            Console.WriteLine(Date.NowFormatted("yyyy MMMM"));
        }
    }
}
