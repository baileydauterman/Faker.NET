using Faker.NET.Interfaces;
using System.Globalization;

namespace Faker.NET.Locales
{
    /// <summary>
    /// Instance that contains all faker instances related to an <see cref="SupportedFakerLocales"/>
    /// </summary>
    public interface IFakerInstance
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
