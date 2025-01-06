using Faker.NET.Common.Phone;

namespace Faker.NET.Interfaces.Modules;

public interface IFakerPhone
{
    public string IMEI();

    public string Number(PhoneNumberType type = PhoneNumberType.Human);
}
