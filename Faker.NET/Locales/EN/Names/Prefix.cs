using Faker.NET.Common;

namespace Faker.NET.Locales.EN.Names
{
    internal class Prefix : IFakerText
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
