using System;
using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Dates;

public class DateTests : DeterministicTestClass
{
    [Test]
    public void TestDate()
    {
        Assert.Multiple(() =>
        {
            var date = Faker.Date.Anytime();
            Assert.That(date, Is.InstanceOf<DateTime>());
            Assert.That(date, Is.GreaterThan(DateTime.MinValue));
            Assert.That(date, Is.LessThan(DateTime.MaxValue));
        });
    }
}
