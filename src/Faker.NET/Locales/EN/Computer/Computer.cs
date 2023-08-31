using Faker.NET.API;
using System.Net;

namespace Faker.NET.EN.Computer
{
    public class Computer : IFakerComputer
    {
        public string IPv4Address => $"{ipv4Octet}.{ipv4Octet}.{ipv4Octet}.{ipv4Octet}";

        public string IPv6Address => new IPAddress(Faker.Randomizer.NextBytes(16)).ToString();

        private int ipv4Octet => Faker.Randomizer.Next(1, 256);
    }
}
