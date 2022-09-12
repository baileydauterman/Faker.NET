using Faker.NET.Common;

namespace Faker.NET.Locales.EN.Computers
{
    public class IPv4Address : FakerNumber
    {
        public new string Get()
        {
            return $"{Randomizer.Next(1,256)}.{Randomizer.Next(1, 256)}.{Randomizer.Next(1, 256)}.{Randomizer.Next(1, 256)}";
        }
    }
}
