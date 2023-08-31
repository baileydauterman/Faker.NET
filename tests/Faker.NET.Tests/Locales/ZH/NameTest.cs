namespace Faker.NET.Tests.ZH
{
    internal class NameTest
    {
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
        public void StressFirstName()
        {
            var i = 0;

            while (i < 10_000)
            {
                _ = Faker.Name.First;

                i++;
            }
        }

        [Test]
        public void StressLastName()
        {
            var i = 0;

            while (i < 10_000)
            {
                _ = Faker.Name.Last;

                i++;
            }
        }
    }
}
