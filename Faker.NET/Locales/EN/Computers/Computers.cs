namespace Faker.NET.EN.Computers
{
    public static class Computers
    {
        public static string IPv4Address => ip.Get();
        public static string IPv6Address => ipv6.Get();

        private static IPv4Address ip = new();
        private static IPv6Address ipv6 = new();
    }
}
