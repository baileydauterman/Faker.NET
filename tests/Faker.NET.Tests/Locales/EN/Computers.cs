using System.Net;

namespace Faker.NET.Tests.EN
{
    public class Computers
    {
        [SetUp]
        public void Setup()
        {
            Faker.SetInstance(SupportedFakerLocales.English);
        }

        [Test]
        public void IPv4()
        {
            Assert.That(IPAddress.Parse(Faker.Computer.IPv4Address), Is.InstanceOf<IPAddress>());
        }

        [Test]
        public void IPv6()
        {
            Assert.That(IPAddress.Parse(Faker.Computer.IPv6Address), Is.InstanceOf<IPAddress>());
        }
    }
}
