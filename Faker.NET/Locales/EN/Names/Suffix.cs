using Faker.NET.Common;

namespace Faker.NET.EN.Names
{
    internal class Suffix : FakerText
    {
        public Suffix() : base()
        {
            Native = new()
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

            Translated = Native;
        }
    }
}
