namespace Faker.NET.Tests.Common
{
    internal class Randomizer
    {
        [Test]
        public void SeedSetter()
        {
            Faker.SetRandomizerSeed(192876453);

            Assert.Multiple(() =>
            {
                Assert.That(Faker.Name.First, Is.EqualTo("Edd"));
                Assert.That(Faker.Name.Last, Is.EqualTo("Bahringer"));
                Assert.That(Faker.Name.Full, Is.EqualTo("Angelina Walter"));
                Assert.That(Faker.Name.Job, Is.EqualTo("Future Data Architect"));
            });
        }
    }
}
