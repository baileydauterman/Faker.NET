using Faker.NET.Common;

namespace Faker.NET.Locales.EN.Location
{
    internal class BuildingNumber : IFakerNumber
    {
        public new int Get()
        {
            return Randomizer.Next(1, 8000);
        }
    }
}
