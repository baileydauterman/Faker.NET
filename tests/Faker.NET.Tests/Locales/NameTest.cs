namespace Faker.NET.Tests.Locales
{
    [TestFixture(FakerLocale.Arabic)]
    [TestFixture(FakerLocale.English)]
    [TestFixture(FakerLocale.French)]
    [TestFixture(FakerLocale.German)]
    [TestFixture(FakerLocale.Russian)]
    [TestFixture(FakerLocale.Mandarin)]
    internal class NameTest
    {
        public NameTest(FakerLocale locale)
        {
            Faker.SetInstance(locale);
        }

        [Test]
        public void FirstName()
        {
            Assert.That(Faker.Name.First, Is.Not.Null);
        }

        [Test]
        public void LastName()
        {
            Assert.That(Faker.Name.Last, Is.Not.Null);
        }

        [Test]
        public void FullName()
        {
            Assert.That(Faker.Name.Full, Is.Not.Null);
        }

        [Test]
        [TestCase(10_000)]
        public void StressFirstName(int count)
        {
            var i = 0;

            while (i++ < count)
            {
                _ = Faker.Name.First;
            }
        }

        [Test]
        [TestCase(10_000)]
        public void StressLastName(int count)
        {
            var i = 0;

            while (i++ < count)
            {
                _ = Faker.Name.Last;
            }
        }

        [Test]
        [TestCase(10_000)]
        public void StressFull(int count)
        {
            var i = 0;

            while (i++ < count)
            {
                _ = Faker.Name.Full;
            }
        }
    }
}
