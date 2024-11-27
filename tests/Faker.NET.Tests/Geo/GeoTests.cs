using System;
using Faker.NET.Geo;
using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Geo;

public class GeoTests : DeterministicTestClass
{
    [Test]
    public void TestGeo()
    {
        Assert.That(Faker.Location.Longitude, Is.EqualTo("0.822186937"));
        Assert.That(Faker.Location.Latitude, Is.EqualTo("42.597009837"));
    }
}
