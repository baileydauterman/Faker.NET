namespace Faker.NET.Common
{
    public class IFakerText
    {
        public IFakerText()
        {
        }

        public string Get()
        {
            return Data[Randomizer.Next(Data.Count)];
        }

        public List<string> Data { get; set; }
    }
}
