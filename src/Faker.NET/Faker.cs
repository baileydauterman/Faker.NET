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
        public static IFakerInstance GetInstance(string locale)
        {
            var fakerLocale = GetLocale(locale);
            return FakerLocaleFactory.Create(fakerLocale);
        }

        public static void SetLocale(CultureInfo cultureInfo)
            => UpdateCultureAndFakerInstance(cultureInfo);

        public static void SetLocale(string locale)
            => UpdateCultureAndFakerInstance(CultureInfo.GetCultureInfo(locale));

        public static void SetLocale(SupportedFakerLocales locale)
            => UpdateCultureAndFakerInstance(CultureInfo.GetCultureInfo(locale.ToString()));

        public static void SetInstance(SupportedFakerLocales locale)
        {
            FakerInstance = FakerLocaleFactory.Create(locale);
        }

        public static void SetInstance(IFakerInstance faker)
        {
            FakerInstance = faker;
        }

        public static CultureInfo Culture => FakerInstance.Culture;

        public static IFakerComputer Computer => FakerInstance.Computer;

        public static IFakerName Name => FakerInstance.Name;

        public static IFakerUser User => FakerInstance.User;

        public static IFakerLorem Lorem => FakerInstance.Lorem;

        public static IFakerLocation Location => FakerInstance.Location;

        public static IFakerPhoneNumber Phone => FakerInstance.PhoneNumber;

        public static Date Date { get; } = new Date();

        public static IFakerCustom Custom { get; set; }

        public static Randomizer Randomizer { get; private set; } = new Randomizer();

        public static IFakerInstance FakerInstance { get; private set; } = new ENLocale();

        private static SupportedFakerLocales GetLocale(string locale)
        {
            var cultureInfo = CultureInfo.GetCultureInfo(locale);
            return FakerLocaleFactory.GetLocale(cultureInfo);
        }

        private static void UpdateCultureAndFakerInstance(CultureInfo culture)
        {
            var locale = FakerLocaleFactory.GetLocale(culture);
            FakerInstance = FakerLocaleFactory.Create(locale);
        }
    }

    public enum SupportedFakerLocales
    {
        English,
        Arabic,
        French,
        Russian,
        Mandarin,
        German,
    }
}
