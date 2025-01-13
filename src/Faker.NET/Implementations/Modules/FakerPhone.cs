using Faker.NET.Common;
using Faker.NET.Common.Phone;
using Faker.NET.Extensions;
using Faker.NET.Interfaces.Definitions;
using Faker.NET.Interfaces.Modules;

namespace Faker.NET.Implementations.Modules;

internal class FakerPhone<T> : FakerDefinitionHandler<T>, IFakerPhone where T : IFakerPhoneDefinition
{
    public string IMEI()
    {
        var format = "##-######-######-L";
        return format.ToRandomString();
    }

    public string Number(PhoneNumberType type = PhoneNumberType.Human)
    {
        var format = type switch
        {
            PhoneNumberType.Human => Data.Human.GetRandom(),
            PhoneNumberType.National => Data.Human.GetRandom(),
            PhoneNumberType.International => Data.Human.GetRandom(),
            _ => throw new Exception($"Unhandled phone number type: {type}")
        };

        return format.ToRandomString();
    }
}
