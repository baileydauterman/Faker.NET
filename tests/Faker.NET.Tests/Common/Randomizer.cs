using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Common
{
    internal class Randomizer : DeterministicTestClass
    {
        [Test]
        public void SeedSetter()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Faker.Person.FirstName(), Is.EqualTo("Johan"));
                Assert.That(Faker.Person.LastName(), Is.EqualTo("Jacobson"));
                Assert.That(Faker.Person.FullName(), Is.EqualTo("Melanie Arya Lynch"));
                Assert.That(Faker.Person.JobTitle(), Is.EqualTo("Legacy Web Strategist"));
            });
        }
    }
}
