using Faker.NET.EN.Names;

namespace Faker.NET.Tests.Common
{
    internal class Randomizer
    {
        [Test]
        public void TestSeedSetter()
        {
            Faker.NET.Common.Randomizer.SetSeed(192876453);

            Assert.Multiple(() =>
            {
                Assert.That(Name.FirstName, Is.EqualTo("Edd"));
                Assert.That(Name.LastName, Is.EqualTo("Bahringer"));
                Assert.That(Name.FullName, Is.EqualTo("Angelina Walter"));
                Assert.That(Name.JobTitle, Is.EqualTo("Future Data Architect"));
                Assert.That(Name.Email, Is.EqualTo("kristoffer.harris5@gmail.com"));
            });
        }
    }
}
