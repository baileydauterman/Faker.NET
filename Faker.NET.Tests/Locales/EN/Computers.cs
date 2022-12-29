using Faker.NET.EN.Computer;
using System.Net;

namespace Faker.NET.Tests.Locales.EN
{
    public static class Computers
    {
        [Test]
        public static void IPv4()
        {
            Assert.That(IPAddress.Parse(Computer.IPv4Address), Is.InstanceOf<IPAddress>());
        }

        [Test]
        public static void IPv6()
        {
            Assert.That(IPAddress.Parse(Computer.IPv6Address), Is.InstanceOf<IPAddress>());
        }
    }
}
