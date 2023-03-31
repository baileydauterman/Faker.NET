using Faker.NET.Common;

namespace Faker.NET.EN.PhoneNumber
{
    internal class PhoneNumber : FakerNumber
    {
        public PhoneNumber() : base()
        {
            Format = "###-###-####";
            AltFormat = "(###)-###-####";
        }
    }
}
