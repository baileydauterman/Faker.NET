using Faker.NET.Common;

namespace Faker.NET.Locales.DE.Names
{
    internal class Prefix : IFakerText
    {
        public Prefix() : base()
        {
            Data = new()
            {
                "Hr.",
                "Fr.",
                "Dr.",
                "Prof. Dr."
            };
        }
    }
}
