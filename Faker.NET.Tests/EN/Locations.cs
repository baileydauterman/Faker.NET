using Faker.NET.EN.Location;

namespace Faker.NET.Tests.EN
{
    internal static class Locations
    {
        [Test]
        public static void GeneratingDataTest()
        {
            Assert.That(Location.City, Is.Not.Null);
            Assert.That(Location.State, Is.Not.Null);
            Assert.That(Location.StateAbbreviation, Is.Not.Null);
            Assert.That(Location.Address, Is.Not.Null);
            Assert.That(Location.BuildingNumber, Is.Not.Null);
            Assert.That(Location.ZipCode, Is.Not.Null);
            Assert.That(Location.ZipCodeLongFormat, Is.Not.Null);
        }
    }
}
