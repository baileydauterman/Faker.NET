using Faker.NET.Common;

namespace Faker.NET.EN.Names
{
    internal class Suffix : FakerText
    {
        public Suffix() : base()
        {
            Data = new()
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
}
