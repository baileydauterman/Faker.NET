using System.Net;

namespace Faker.NET.Tests.EN
{
    public class Computers
    {
        [SetUp]
        public void Setup()
        {
            Faker.SetLocale(FakerLocale.English);
        }

        [Test]
        public void IPv4()
        {
            Assert.That(IPAddress.Parse(Faker.Internet.IPv4()), Is.InstanceOf<IPAddress>());
        }

        [Test]
        public void IPv6()
        {
            Assert.That(IPAddress.Parse(Faker.Internet.IPv6()), Is.InstanceOf<IPAddress>());
        }
    }
}
