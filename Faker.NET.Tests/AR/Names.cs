using Faker.NET.AR.Names;

namespace Faker.NET.Tests.AR
{
    internal class NameTest
    {
        [Test]
        public void FirstName()
        {
            Assert.That(Name.Translated.FirstName, Is.Not.Null);
            Assert.That(Name.Native.FirstName, Is.Not.Null);
        }

        [Test]
        public void LastName()
        {
            Assert.That(Name.Translated.LastName, Is.Not.Null);
            Assert.That(Name.Native.LastName, Is.Not.Null);
        }

        [Test]
        [TestCase(10_000)]
        [TestCase(100_000)]
        [TestCase(1_000_000)]
        public void StressFirstName(int count)
        {
            var i = 0;

            while (i < count)
            {
                _ = Name.Native.FirstName;
                _ = Name.Translated.FirstName;

                i++;
            }
        }

        [Test]
        [TestCase(10_000)]
        [TestCase(100_000)]
        [TestCase(1_000_000)]
        public void StressLastName(int count)
        {
            var i = 0;

            while (i < count)
            {
                _ = Name.Native.LastName;
                _ = Name.Translated.LastName;

                i++;
            }
        }
    }
}
