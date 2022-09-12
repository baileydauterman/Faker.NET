using Faker.NET.Common;

namespace Faker.NET.EN.Location
{
    internal class BuildingNumber : FakerNumber
    {
        public new int Get()
        {
            return Randomizer.Next(1, 8000);
        }
    }
}
