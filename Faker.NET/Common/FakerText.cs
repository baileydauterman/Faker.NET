namespace Faker.NET.Common
{
    public class FakerText
    {
        public string Get()
        {
            return Data[Randomizer.Next(Data.Count)];
        }

        public string Get(bool useAlternate)
        {
            return AlternateData[Randomizer.Next(AlternateData.Count)];
        }

        public List<string> Data { get; set; }
        public List<string> AlternateData { get; set; }
    }
}
