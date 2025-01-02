namespace Faker.NET.Tests.Locales
{
    [TestFixture(FakerLocale.English)]
    [TestFixture(FakerLocale.German)]
    [TestFixture(FakerLocale.Russian)]
    public class LoremTests
    {
        public LoremTests(FakerLocale locale)
        {
            Faker.SetLocale(locale);
        }

        [TestCase(5)]
        [TestCase(50)]
        [TestCase(500)]
        public void Lorem(int count)
        {
            Assert.That(Faker.Lorem.Words(count), Is.Not.Null);
        }
    }
}