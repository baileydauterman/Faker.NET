using Faker.NET.EN.Location;

namespace Faker.NET.Tests.EN
{
    internal static class Locations
    {
        [Test]
        public static void GeneratingDataTest()
        {
            Assert.That(Faker.Location.City, Is.Not.Null);
            Assert.That(Faker.Location.State, Is.Not.Null);
            Assert.That(Faker.Location.StateAbbreviation, Is.Not.Null);
            Assert.That(Faker.Location.Address, Is.Not.Null);
            Assert.That(Faker.Location.BuildingNumber, Is.Not.Null);
            Assert.That(Faker.Location.ZipCode, Is.Not.Null);
            Assert.That(Faker.Location.LongZipCode, Is.Not.Null);
        }
    }
}
