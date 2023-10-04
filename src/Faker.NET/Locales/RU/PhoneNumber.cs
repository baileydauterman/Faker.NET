using Faker.NET.API;
using Faker.NET.Common;

namespace Faker.NET.Locales.RU
{
    internal class PhoneNumber : IFakerPhoneNumber
    {
        public string Number => NumberHelper.GetFromFormat("8 (939) ###-##-##");

        public string AlternateNumberFormat => NumberHelper.GetFromFormat("8 (958) ###-##-##");
    }
}
