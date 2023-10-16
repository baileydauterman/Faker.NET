namespace Faker.NET.Tests.Locales
{
    [TestFixture("en")]
    [TestFixture("de")]
    internal class Locations
    {
        public Locations(string locale)
        {
            Faker.SetLocale(locale);
        }

        [Test]
        public void All()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Faker.Location.City, Is.Not.Null);
                Assert.That(Faker.Location.State, Is.Not.Null);
                Assert.That(Faker.Location.StateAbbreviation, Is.Not.Null);
                Assert.That(Faker.Location.BuildingNumber, Is.Not.Null);
                Assert.That(Faker.Location.PostalCode, Is.Not.Null);
                Assert.That(Faker.Location.PostalCodeAlternate, Is.Not.Null);
                Assert.That(Faker.Location.Street, Is.Not.Null);
                Assert.That(Faker.Location.Address, Is.Not.Null);
            });
        }
    }
}
