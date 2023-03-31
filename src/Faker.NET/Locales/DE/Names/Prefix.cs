using Faker.NET.Common;

namespace Faker.NET.DE.Names
{
    internal class Prefix : FakerText
    {
        public Prefix() : base()
        {
            Native = new()
            {
                "Hr.",
                "Fr.",
                "Dr.",
                "Prof. Dr."
            };
        }
    }
}
