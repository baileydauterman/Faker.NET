using System.Globalization;

namespace Faker.NET.Interfaces
{
    /// <summary>
    /// Instance that contains all faker instances related to an <see cref="FakerLocale"/>
    /// </summary>
    public interface IFakerLocaleInstance
    {
        IFakerName Name { get; }

        IFakerCommerce Commerce { get; }

        IFakerLocation Location { get; }

        IFakerLorem Lorem { get; }

        IFakerUser User { get; }

        IFakerPhoneNumber PhoneNumber { get; }

        CultureInfo Culture { get; }
    }
}
