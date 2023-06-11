using Faker.NET.Common;

namespace Faker.NET.EN.Location
{
    internal class BuildingNumber : FakerNumber
    {
        public int Get() => System.Convert.ToInt16(base.Get(1, 1000));
    }
}
