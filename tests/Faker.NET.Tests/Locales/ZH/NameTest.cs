using Faker.NET.ZH.Names;

namespace Faker.NET.Tests.ZH
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
