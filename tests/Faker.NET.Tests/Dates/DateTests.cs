using System;
using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Dates;

public class DateTests : DeterministicTestClass
{
    [Test]
    public void Anytime()
    {
        var date = Faker.Date.Anytime();
        Assert.That(date, Is.InstanceOf<DateTime>());
        Assert.That(date, Is.GreaterThan(DateTime.MinValue));
        Assert.That(date, Is.LessThan(DateTime.MaxValue));
        Assert.That(date, Is.EqualTo(new DateTime(5083, 3, 19, 9, 55, 41, 80)));
    }

    [Test]
    public void Between()
    {
        var start = new DateTime(2020, 1, 1);
        var end = new DateTime(2024, 12, 31);
        var date = Faker.Date.Between(start, end);
        Assert.That(date, Is.InstanceOf<DateTime>());
        Assert.That(date, Is.GreaterThan(start));
        Assert.That(date, Is.LessThan(end));
        Assert.That(date, Is.EqualTo(new DateTime(2022, 3, 19, 9, 55, 41, 80)));
    }

    [Test]
    public void Future()
    {
        var farthestDate = new DateTime(2048, 12, 31);
        var curDate = DateTime.Now;
        var date = Faker.Date.Future(farthestDate);

        Assert.That(date, Is.InstanceOf<DateTime>());
        Assert.That(date, Is.GreaterThan(curDate));
        Assert.That(date, Is.LessThan(farthestDate));
        Assert.That(date, Is.EqualTo(new DateTime(2036, 3, 19, 9, 55, 41, 80)));
    }

    [Test]
    public void Past()
    {
        var farthestDate = new DateTime(2012, 12, 31);
        var curDate = DateTime.Now;
        var date = Faker.Date.Past(farthestDate);

        Assert.That(date, Is.InstanceOf<DateTime>());
        Assert.That(date, Is.GreaterThan(farthestDate));
        Assert.That(date, Is.LessThan(curDate));
        Assert.That(date, Is.EqualTo(new DateTime(2018, 3, 19, 9, 55, 41, 80)));
    }

    [Test]
    public void Recent()
    {
        var recDate = DateTime.Now.AddDays(-5);
        var curDate = DateTime.Now;
        var date = Faker.Date.Recent(5);

        Assert.That(date, Is.InstanceOf<DateTime>());
        Assert.That(date, Is.GreaterThan(recDate));
        Assert.That(date, Is.LessThan(curDate));
    }

    [Test]
    public void Soon()
    {
        var soonDate = DateTime.Now.AddDays(5);
        var curDate = DateTime.Now;
        var date = Faker.Date.Soon(5);

        Assert.That(date, Is.InstanceOf<DateTime>());
        Assert.That(date, Is.GreaterThan(curDate));
        Assert.That(date, Is.LessThan(soonDate));
    }
}
