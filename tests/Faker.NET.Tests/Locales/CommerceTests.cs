using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Locales
{
    [TestFixture(FakerLocale.English)]
    internal class CommerceTests : DeterministicLocaleTestClass
    {
        public CommerceTests(FakerLocale locale) : base(locale)
        {
        }

        [Test]
        public void Isbn()
        {
            Assert.That(Faker.Commerce.Isbn(), Is.EqualTo("9791649609570"));
        }

        [Test]
        public void Department()
        {
            Assert.That(Faker.Commerce.Department(), Is.EqualTo("Home"));
        }

        [Test]
        public void Price()
        {
            Assert.That(Faker.Commerce.Price(), Is.EqualTo("507.82"));
            Assert.That(Faker.Commerce.Price(symbol: "$"), Is.EqualTo("$621.60"));
        }

        [Test]
        public void ProductAdjective()
        {
            Assert.That(Faker.Commerce.ProductAdjective(), Is.EqualTo("Licensed"));
        }

        [Test]
        public void ProductDescription()
        {
            Assert.That(Faker.Commerce.ProductDescription(), Is.EqualTo("Our {{food.adjective}}-inspired {{commerce.product}} brings a taste of luxury to your {{word.adjective}} lifestyle"));
        }

        [Test]
        public void ProductMaterial()
        {
            Assert.That(Faker.Commerce.ProductMaterial(), Is.EqualTo("Metal"));
        }

        [Test]
        public void ProductName()
        {
            Assert.That(Faker.Commerce.ProductName(), Is.EqualTo("Licensed Cotton Plastic"));
        }

        [Test]
        public void Product()
        {
            Assert.That(Faker.Commerce.Product(), Is.EqualTo("Metal"));
        }
    }
}
