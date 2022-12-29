using Faker.NET.EN.Date;
using System.Globalization;

namespace Faker.NET.Tests.Locales.EN
{
    internal static class Dates
    {
        [Test]
        public static void Days()
        {
            Assert.That((DayOfWeek)Enum.Parse(typeof(DayOfWeek), Date.Day), Is.InstanceOf<DayOfWeek>());
            var dayIndex = Array.IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.AbbreviatedDayNames, Date.DayAbbreviated);

            Assert.That((DayOfWeek)dayIndex, Is.InstanceOf<DayOfWeek>());
            Assert.That(int.Parse(Date.DateNum), Is.InstanceOf<int>());
        }
        [Test]
        public static void Months()
        {
            Assert.That(Date.Month, Is.InstanceOf<string>());
            Assert.That(Date.MonthAbbreviated, Is.InstanceOf<string>()); 
            Assert.That(int.Parse(Date.MonthNum), Is.InstanceOf<int>());
        }

        [Test]
        public static void Years()
        {
            Assert.That(DateTime.ParseExact(Date.Year, "yyyy", null), Is.InstanceOf<DateTime>());
        }

        [Test]
        public static void Formats()
        {
            Assert.That(DateTime.Parse(Date.NowFormatted("MM/dd/yyyy")), Is.InstanceOf<DateTime>());
            Assert.That(DateTime.Parse(Date.NowFormatted("dddd, dd MMMM yyyy")), Is.InstanceOf<DateTime>());
            Assert.That(DateTime.Parse(Date.NowFormatted("dddd, dd MMMM yyyy HH:mm:ss")), Is.InstanceOf<DateTime>());
            Assert.That(DateTime.Parse(Date.NowFormatted("HH:mm")), Is.InstanceOf<DateTime>());
            Assert.That(DateTime.Parse(Date.NowFormatted("hh:mm tt")), Is.InstanceOf<DateTime>());
            Assert.That(DateTime.Parse(Date.NowFormatted("H:mm")), Is.InstanceOf<DateTime>());
            Assert.That(DateTime.Parse(Date.NowFormatted("h:mm tt")), Is.InstanceOf<DateTime>());
            Assert.That(DateTime.Parse(Date.NowFormatted("HH:mm:ss")), Is.InstanceOf<DateTime>());
            Assert.That(DateTime.Parse(Date.NowFormatted("yyyy MMMM")), Is.InstanceOf<DateTime>());

            Assert.That(DateTime.Parse(Date.FullDateTime), Is.InstanceOf<DateTime>());
        }
    }
}
