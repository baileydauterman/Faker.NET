using Faker.NET.Common;
using System.Net;

namespace Faker.NET.Locales.EN.Computers
{
    internal class IPv6Address : FakerNumber
    {
        public new string Get()
        {
            byte[] bytes = new byte[16];
            new Random().NextBytes(bytes);
            IPAddress ipv6Address = new IPAddress(bytes);
            return ipv6Address.ToString();
        }
    }
}
