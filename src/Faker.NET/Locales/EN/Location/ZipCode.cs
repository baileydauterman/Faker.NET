using Faker.NET.Common;

namespace Faker.NET.EN.Location
{
    internal class ZipCode : FakerNumber
    {
        public ZipCode() : base()
        {
            Format = "#####";
            AltFormat = "#####-####";
        }
    }
}
