using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Locales
{
    [TestFixture(FakerLocale.English)]
    [TestFixture(FakerLocale.German)]
    [TestFixture(FakerLocale.Russian)]
    [TestFixture(FakerLocale.Spanish)]
    public class LoremTests : DeterministicLocaleTestClass
    {
        public LoremTests(FakerLocale locale) : base(locale)
        {
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