using System.Globalization;

namespace Faker.NET.Interfaces
{
    /// <summary>
    /// Instance that contains all faker instances related to an <see cref="FakerLocale"/>
    /// </summary>
    public interface IFakerLocaleInstance
    {
        IFakerCommerce Commerce { get; }

        IFakerDate Date { get; }

        IFakerInternet Internet { get; }

        IFakerName Name { get; }

        IFakerLocation Location { get; }

        IFakerLorem Lorem { get; }

        IFakerUser User { get; }

        IFakerPhoneNumber PhoneNumber { get; }

        IFakerWord Word { get; }

        CultureInfo Culture { get; }
    }
}
