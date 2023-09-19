using Faker.NET.API;
using System.Globalization;

namespace Faker.NET.Locales
{
    public interface IFakerLocale
    {
        IFakerComputer Computer { get; }

        IFakerName Name { get; }

        IFakerLocation Location { get; }

        IFakerLorem Lorem { get; }

        IFakerUser User { get; }

        IFakerPhoneNumber PhoneNumber { get; }

        CultureInfo Culture { get; }
    }
}
