using Faker.NET.Common;

namespace Faker.NET.EN.Computer
{
    public class IPv4Address : FakerNumber
    {
        public string Get()
        {
            return $"{octet}.{octet}.{octet}.{octet}";
        }

        private int octet => Randomizer.Next(1, 256);
    }
}
