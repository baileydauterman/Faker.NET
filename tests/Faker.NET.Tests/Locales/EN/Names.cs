using Faker.NET.API;
using Faker.NET.EN.Names;
// using Faker = Faker.NET.Faker;

namespace Faker.NET.Tests.EN
{
    internal static class Names
    {
        [Test]
        public static void TestNames()
        {
            IFakerName names = new Name();

            Assert.Multiple(() =>
            {
                Assert.That(Faker.Name.First, Is.Not.Null);
                Assert.That(Faker.Name.Last, Is.Not.Null);
                Assert.That(Faker.Name.Full, Is.Not.Null);
                Assert.That(Faker.Name.Job, Is.Not.Null);
                Assert.That(Faker.Name.Suffix, Is.Not.Null);
                Assert.That(Faker.Name.Prefix, Is.Not.Null);
                Assert.That(Faker.Name.Email, Is.Not.Null);
            });
        }
    }
}
