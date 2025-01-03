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

        [TestCase(0, 5)]
        [TestCase(0, 50)]
        [TestCase(0, 500)]
        public void Lorem(int min, int max)
        {
            Assert.That(Faker.Lorem.Words(min, max), Is.Not.Null);
        }
    }
}