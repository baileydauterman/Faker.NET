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
    }
}
