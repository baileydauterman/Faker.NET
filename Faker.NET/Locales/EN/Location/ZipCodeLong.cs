using Faker.NET.Common;

namespace Faker.NET.Locales.EN.Location
{
    internal class ZipCodeLong : IFakerNumber
    {
        public ZipCodeLong() : base()
        {
            Format = "#####-####";
        }
    }
}
