using Faker.NET.Common;

namespace Faker.NET.Names
{
    internal class Suffix : IFakerText
    {
        public string Get()
        {
            return Data[Randomizer.Next(Data.Count)];
        }

        public List<string> Data { get; } = new()
        {
            "Jr.",
            "Sr.",
            "I",
            "II",
            "III",
            "IV",
            "V",
            "MD",
            "DDS",
            "PhD",
            "DVM",
        };
    }
}
