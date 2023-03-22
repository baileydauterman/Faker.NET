using Faker.NET.RU.Names;

namespace Faker.NET.Tests.RU
{
    internal class Names
    {
        [Test]
        public void FirstName()
        {
            Assert.That(Name.Translated.FirstName, Is.Not.Null);
            Assert.That(Name.Native.FirstName, Is.Not.Null);
        }

        [Test]
        public void MiddleName()
        {
            Assert.That(Name.Translated.MiddleName, Is.Not.Null);
            Assert.That(Name.Native.MiddleName, Is.Not.Null);
        }

        [Test]
        public void LastName()
        {
            Assert.That(Name.Translated.LastName, Is.Not.Null);
            Assert.That(Name.Native.LastName, Is.Not.Null);
        }

        [Test]
        public void Jobs()
        {
            Assert.That(Name.Native.JobTitle, Is.Not.Null);
            Assert.That(Name.Translated.JobTitle, Is.Not.Null);
        }

        [Test]
        public void StressFirstName()
        {
            var i = 0;

            while (i < 10_000)
            {
                _ = Name.Native.FirstName;
                _ = Name.Translated.FirstName;

                i++;
            }
        }

        [Test]
        public void StressMiddleName()
        {
            var i = 0;

            while (i < 10_000)
            {
                _ = Name.Native.MiddleName;
                _ = Name.Translated.MiddleName;

                i++;
            }
        }

        [Test]
        public void StressLastName()
        {
            var i = 0;

            while (i < 10_000)
            {
                _ = Name.Native.LastName;
                _ = Name.Translated.LastName;

                i++;
            }
        }
    }
}
