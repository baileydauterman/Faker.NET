using Faker.NET.Common;
using Faker.NET.Interfaces;
using System.Net;

namespace Faker.NET.Technology
{
    public class Computer : IFakerComputer
    {
        public Computer(string[] domains) 
        {
            _domains = domains;
        }

        public string IPv4Address => $"{Ipv4Octet}.{Ipv4Octet}.{Ipv4Octet}.{Ipv4Octet}";

        public string IPv6Address => new IPAddress(Faker.Randomizer.NextBytes(16)).ToString();

        public string Domain => _domains.GetRandom();

        public string UserAgent => Data.UserAgents.Get();

        private static int Ipv4Octet => Faker.Randomizer.Next(1, 256);

        private string[] _domains;
    }
}
