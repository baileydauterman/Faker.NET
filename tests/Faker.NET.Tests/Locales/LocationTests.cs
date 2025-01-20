using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Locales;

[TestFixture(FakerLocale.English)]
[TestFixture(FakerLocale.German)]
[TestFixture(FakerLocale.Russian)]
internal class LocationTests : DeterministicLocaleTestClass
{
    public LocationTests(FakerLocale locale) : base(locale)
    {
    }

    [Test]
    public void All()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Faker.Location.City(), Is.Not.Null);
            Assert.That(Faker.Location.State(), Is.Not.Null);
            Assert.That(Faker.Location.State(true), Is.Not.Null);
            Assert.That(Faker.Location.BuildingNumber, Is.Not.Null);
            Assert.That(Faker.Location.ZipCode(), Is.Not.Null);
            Assert.That(Faker.Location.Street, Is.Not.Null);
            Assert.That(Faker.Location.StreetAddress(), Is.Not.Null);
        });
    }
}
