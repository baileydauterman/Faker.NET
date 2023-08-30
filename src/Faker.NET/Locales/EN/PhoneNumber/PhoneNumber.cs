using Faker.NET.API;
using Faker.NET.Common;

namespace Faker.NET.EN.PhoneNumber
{
    internal class PhoneNumber : IFakerPhoneNumber
    {
        public string AlternateNumberFormat => NumberHelper.GetFromFormat("###-###-####");

        public string Number => NumberHelper.GetFromFormat("(###)-###-####");
    }
}
