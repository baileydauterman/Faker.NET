using Faker.NET.Common;

namespace Faker.NET.Names
{
    internal class Prefix : IFakerText
    {
        public string Get()
        {
            return Data[Randomizer.Next(Data.Count)];
        }
        public List<string> Data { get; } = new()
        {
            "Mr.", 
            "Mrs.", 
            "Ms.", 
            "Miss", 
            "Dr."
        };

    }
}
