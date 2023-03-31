using Faker.NET.EN.Names;

namespace Faker.NET.Tests.EN
{
    internal static class Names
    {
        [Test]
        public static void TestNames()
        {
            Assert.That(Name.FirstName, Is.Not.Null);
            Assert.That(Name.LastName, Is.Not.Null);
            Assert.That(Name.FullName, Is.Not.Null);
            Assert.That(Name.JobTitle, Is.Not.Null);
            Assert.That(Name.Suffix, Is.Not.Null);
            Assert.That(Name.Prefix, Is.Not.Null);
            Assert.That(Name.Email, Is.Not.Null);
        }
    }
}
