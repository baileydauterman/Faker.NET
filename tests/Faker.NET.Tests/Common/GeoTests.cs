using Faker.NET.Common.Location;
using Faker.NET.Extensions;
using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Common
{
    internal class GeoTests : DeterministicTestClass
    {
        [Test]
        public void GeoCoordinates()
        {
            var kilometers = Distance.Kilometers(15);
            var coordinates = new Coordinate
            {
                Latitude = 32,
                Longitude = -120
            };

            var randCoords = Faker.Location.NearbyCoordinate(coordinates, kilometers);
            Assert.Multiple(() =>
            {
                Assert.That(randCoords.Latitude, Is.EqualTo(32.030027117537976));
                Assert.That(randCoords.Longitude, Is.EqualTo(-119.92728937534456));
            });

            randCoords = Faker.Location.NearbyCoordinate(coordinates, kilometers.ToMeters());

            Assert.Multiple(() =>
            {
                Assert.That(randCoords.Latitude, Is.EqualTo(31.93119672227219));
                Assert.That(randCoords.Longitude, Is.EqualTo(-119.94340520264679));
            });
        }

    }
}
