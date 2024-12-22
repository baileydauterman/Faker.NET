namespace Faker.NET.Tests.EN
{
    internal class Names
    {
        [Test]
        public void TestNames()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Faker.Name.First, Is.Not.Null);
                Assert.That(Faker.Name.Last, Is.Not.Null);
                Assert.That(Faker.Name.Full, Is.Not.Null);
                Assert.That(Faker.Name.Job, Is.Not.Null);
                Assert.That(Faker.Name.Suffix, Is.Not.Null);
                Assert.That(Faker.Name.Prefix, Is.Not.Null);
                Assert.That(Faker.Internet.Email(), Is.Not.Null);
            });
        }
    }
}
