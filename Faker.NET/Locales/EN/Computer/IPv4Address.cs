using Faker.NET.Common;

namespace Faker.NET.EN.Computer
{
    public class IPv4Address : FakerNumber
    {
        public new string Get()
        {
            return $"{Randomizer.Next(1,256)}.{Randomizer.Next(1, 256)}.{Randomizer.Next(1, 256)}.{Randomizer.Next(1, 256)}";
        }
    }
}
