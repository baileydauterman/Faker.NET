using Faker.NET.Common.Phone;

namespace Faker.NET.Modules.Interfaces;

public interface IFakerPhone
{
    public string IMEI();

    public string Number(PhoneNumberType type = PhoneNumberType.Human);
}
