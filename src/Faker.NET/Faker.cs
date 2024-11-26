using Faker.NET.Common;
using Faker.NET.Interfaces;
using Faker.NET.Locales.EN;
using System.Globalization;

namespace Faker.NET
{
    /// <summary>
    /// Static entry point into creating fake data. Can be changed with any SetLocale method
    /// </summary>
    public class Faker
    {
        public static void SetInstance(FakerLocale locale)
        {
            FakerInstance = FakerLocaleFactory.Create(locale);
        }

        public static void SetInstance(IFakerLocaleInstance faker)
        {
            FakerInstance = faker;
        }

        public static CultureInfo Culture => FakerInstance.Culture;

        public static IFakerComputer Computer => Technology.TechnologyFakerFactory.GetComputerFaker(Culture);

        public static IFakerName Name => FakerInstance.Name;

        public static IFakerUser User => FakerInstance.User;

        public static IFakerLorem Lorem => FakerInstance.Lorem;

        public static IFakerLocation Location => FakerInstance.Location;

        public static IFakerPhoneNumber Phone => FakerInstance.PhoneNumber;

        public static Date Date { get; } = new Date();

        public static IFakerCustom Custom { get; set; }

        public static Randomizer Randomizer { get; private set; } = new Randomizer();

        public static IFakerLocaleInstance FakerInstance { get; private set; } = new ENLocale();
    }
}
