using Faker.NET.API;

namespace Faker.NET.Locales
{
    public interface IFakerLocale
    {
        IFakerName Name { get; }

        IFakerLocation Location { get; }

        IFakerLorem Lorem { get; }

        IFakerUser User { get; }

        IFakerPhoneNumber PhoneNumber { get; }
    }
}
