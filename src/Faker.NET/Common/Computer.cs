using Faker.NET.Interfaces;
using System.Net;

namespace Faker.NET.Common
{
    internal class Computer : IFakerComputer
    {
        public string IPv4Address => $"{ipv4Octet}.{ipv4Octet}.{ipv4Octet}.{ipv4Octet}";

        public string IPv6Address => new IPAddress(Faker.Randomizer.NextBytes(16)).ToString();

        public string Domain => _domains.GetRandom();

        private int ipv4Octet => Faker.Randomizer.Next(1, 256);

        private string[] _domains =
        {
            ".com",
            ".org",
            ".net",
            ".edu",
        };
    }
}
