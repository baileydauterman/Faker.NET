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
                Assert.That(Faker.Person.LastName(), Is.EqualTo("Mueller"));
                Assert.That(Faker.Person.FullName(), Is.EqualTo("Theodore Mason Block"));
                Assert.That(Faker.Person.JobTitle(), Is.EqualTo("Chief Infrastructure Producer"));
            });
        }
    }
}
