using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Locales
{
    [TestFixture(FakerLocale.English)]
    internal class AirlineTests : DeterministicLocaleTestClass
    {
        public AirlineTests(FakerLocale locale) : base(locale)
        {
        }

        [Test]
        public void Airline()
        {
            var airline = Faker.Airline.Airline();
            Assert.That(airline, Is.Not.Null);
            Assert.That(airline.Name, Is.EqualTo("Frontier Airlines"));
        }

        [Test]
        public void Airport()
        {
            var airport = Faker.Airline.Airport();
            Assert.That(airport, Is.Not.Null);
            Assert.That(airport.Name, Is.EqualTo("St. Louis Lambert International Airport"));
        }

        [Test]
        public void Airplane()
        {
            var airplane = Faker.Airline.Airplane();
            Assert.That(airplane, Is.Not.Null);
            Assert.That(airplane.Name, Is.EqualTo("Cessna Citation I"));
        }
    }
}
