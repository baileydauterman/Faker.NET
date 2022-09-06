using Faker.NET.Common;

namespace Faker.NET.Locales.EN.PhoneNumber
{
    internal class PhoneNumber : IFakerNumber
    {
        public PhoneNumber() : base()
        {
            Format = "###-###-####";
        }
    }
}
