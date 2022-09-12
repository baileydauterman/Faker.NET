using Faker.NET.Common;

namespace Faker.NET.EN.Names
{
    internal class Prefix : FakerText
    {
        public Prefix() : base()
        {
            Data = new()
            {
                "Mr.",
                "Mrs.",
                "Ms.",
                "Miss",
                "Dr."
            };
        }
    }
}
