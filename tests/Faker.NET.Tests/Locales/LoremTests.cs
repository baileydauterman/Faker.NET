namespace Faker.NET.Tests.Locales
{
    [TestFixture(FakerLocale.English)]
    [TestFixture(FakerLocale.German)]
    [TestFixture(FakerLocale.Russian)]
    public class LoremTests
    {
        public LoremTests(FakerLocale locale)
        {
            Faker.SetInstance(locale);
        }

        [TestCase(5)]
        [TestCase(50)]
        [TestCase(500)]
        public void Lorem(int count)
        {
            Assert.That(Faker.Lorem.GetText(count), Is.Not.Null);
        }
    }
}