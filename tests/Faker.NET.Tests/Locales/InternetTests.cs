using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Locales
{
    internal class InternetTests : DeterministicTestClass
    {
        [Test]
        public void IPv4()
        {
            var address = Faker.Internet.IPv4("192.168.1.0/31");
            Assert.That(address, Is.EqualTo("192.168.1.1"));

            address = Faker.Internet.IPv4("192.168.1.0/24");
            Assert.That(address, Is.EqualTo("192.168.1.46"));

            address = Faker.Internet.IPv4("192.168.1.0/16");
            Assert.That(address, Is.EqualTo("192.168.160.55"));
        }

        [Test]
        public void DomainName()
        {
            Assert.That(Faker.Internet.DomainName(), Is.EqualTo("medium-concentration.monster"));
        }

        [Test]
        public void Username()
        {
            Assert.That(Faker.Internet.Username(), Is.EqualTo("johanj"));
        }
    }
}
