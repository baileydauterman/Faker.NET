using Faker.NET.Common;
using System.Net;

namespace Faker.NET.EN.Computer
{
    internal class IPv6Address : FakerNumber
    {
        public string Get()
        {
            var bytes = new byte[16];
            new Random().NextBytes(bytes);
            IPAddress ipv6Address = new IPAddress(bytes);
            return ipv6Address.ToString();
        }
    }
}
