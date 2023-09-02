using Faker.NET.API;
using Faker.NET.Common;
using Faker.NET.Locales.EN.Location;

namespace Faker.NET.EN.Location
{
    public class Location : IFakerLocation
    {
        public string City => LocationData.Cities.GetRandom();

        public string State => LocationData.States.GetRandom();

        public string StateAbbreviation => LocationData.StatesAbbreviation.GetRandom();

        public string BuildingNumber => NumberHelper.Get(1, 1000).ToString();

        public string Address => $"{BuildingNumber} {City}, {StateAbbreviation} {ZipCode}";

        public string ZipCode => NumberHelper.GetFromFormat("#####");

        public string LongZipCode => NumberHelper.GetFromFormat("#####-####");
    }
}
