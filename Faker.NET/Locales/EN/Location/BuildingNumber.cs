using Faker.NET.Common;

namespace Faker.NET.Locales.EN.Location
{
    internal class BuildingNumber : IFakerNumber
    {
        public BuildingNumber() : base()
        {
            Format = formats[Randomizer.Next(formats.Count)];
        }

        private List<string> formats = new()
        {
            "####",
            "###",
            "##"
        };
    }
}
