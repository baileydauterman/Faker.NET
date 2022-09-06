using Faker.NET.Common;

namespace Faker.NET.Locales.EN.Location
{
    internal class ZipCode : IFakerNumber
    {
        public ZipCode() : base()
        {
            Format = "#####";
        }
    }
}
