using System.Globalization;

namespace Faker.NET.Tests.EN
{
    internal class Dates
    {
        [SetUp]
        public void Setup()
        {
            Faker.SetLocale("en");
        }

        [Test]
        public void Days()
        {
            Assert.That((DayOfWeek)Enum.Parse(typeof(DayOfWeek), Faker.Date.Day), Is.InstanceOf<DayOfWeek>());
            var dayIndex = Array.IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.AbbreviatedDayNames, Faker.Date.DayAbbreviated);

            Assert.That((DayOfWeek)dayIndex, Is.InstanceOf<DayOfWeek>());
            Assert.That(int.Parse(Faker.Date.DateNum), Is.InstanceOf<int>());
        }
        [Test]
        public void Months()
        {
            Assert.That(Faker.Date.Month, Is.InstanceOf<string>());
            Assert.That(Faker.Date.MonthAbbreviated, Is.InstanceOf<string>());
            Assert.That(int.Parse(Faker.Date.MonthNum), Is.InstanceOf<int>());
        }

        [Test]
        public void Years()
        {
            Assert.That(DateTime.ParseExact(Faker.Date.Year, "yyyy", null), Is.InstanceOf<DateTime>());
        }

        [Test]
        public void Formats()
        {
            Assert.That(DateTime.Parse(Faker.Date.NowFormatted("MM/dd/yyyy")), Is.InstanceOf<DateTime>());
            Assert.That(DateTime.Parse(Faker.Date.NowFormatted("dddd, dd MMMM yyyy")), Is.InstanceOf<DateTime>());
            Assert.That(DateTime.Parse(Faker.Date.NowFormatted("dddd, dd MMMM yyyy HH:mm:ss")), Is.InstanceOf<DateTime>());
            Assert.That(DateTime.Parse(Faker.Date.NowFormatted("HH:mm")), Is.InstanceOf<DateTime>());
            Assert.That(DateTime.Parse(Faker.Date.NowFormatted("hh:mm tt")), Is.InstanceOf<DateTime>());
            Assert.That(DateTime.Parse(Faker.Date.NowFormatted("H:mm")), Is.InstanceOf<DateTime>());
            Assert.That(DateTime.Parse(Faker.Date.NowFormatted("h:mm tt")), Is.InstanceOf<DateTime>());
            Assert.That(DateTime.Parse(Faker.Date.NowFormatted("HH:mm:ss")), Is.InstanceOf<DateTime>());
            Assert.That(DateTime.Parse(Faker.Date.NowFormatted("yyyy MMMM")), Is.InstanceOf<DateTime>());

            Assert.That(DateTime.Parse(Faker.Date.FullDateTime), Is.InstanceOf<DateTime>());
        }
    }
}
