using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Locales
{
    [TestFixture(FakerLocale.English)]
    [TestFixture(FakerLocale.German)]
    internal class AirlineTests : DeterministicLocaleTestClass
    {
        public AirlineTests(FakerLocale locale) : base(locale)
        {
        }

        [Test]
        public void Airline()
        {
            NET.Common.Airline.Airline? airline = null;
            switch (Faker.GetLocale())
            {
                case FakerLocale.English:
                    airline = Faker.Airline.Airline();
                    Assert.That(airline, Is.Not.Null);
                    Assert.That(airline.Name, Is.EqualTo("Frontier Airlines"));
                    break;

                case FakerLocale.German:
                    airline = Faker.Airline.Airline();
                    Assert.That(airline, Is.Not.Null);
                    Assert.That(airline.Name, Is.EqualTo("Lufthansa CityLine"));
                    break;
            }
        }

        [Test]
        public void Airport()
        {
            NET.Common.Airline.Airport? airport = null;
            switch (Faker.GetLocale())
            {
                case FakerLocale.English:
                    airport = Faker.Airline.Airport();
                    Assert.That(airport, Is.Not.Null);
                    Assert.That(airport.Name, Is.EqualTo("St. Louis Lambert International Airport"));
                    break;

                case FakerLocale.German:
                    airport = Faker.Airline.Airport();
                    Assert.That(airport, Is.Not.Null);
                    Assert.That(airport.Name, Is.EqualTo("Neubrandenburg Airport"));
                    break;
            }
        }

        [Test]
        public void Airplane()
        {
            NET.Common.Airline.Airplane? airplane = null;
            switch (Faker.GetLocale())
            {
                case FakerLocale.English:
                    airplane = Faker.Airline.Airplane();
                    Assert.That(airplane, Is.Not.Null);
                    Assert.That(airplane.Name, Is.EqualTo("Cessna Citation I"));
                    break;

                case FakerLocale.German:
                    airplane = Faker.Airline.Airplane();
                    Assert.That(airplane, Is.Not.Null);
                    Assert.That(airplane.Name, Is.EqualTo("Airbus A321"));
                    break;
            }
        }
    }
}
