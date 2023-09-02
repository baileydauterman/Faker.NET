using Faker.NET.API;
using Faker.NET.Common;
using Faker.NET.Locales;
using Faker.NET.Locales.AR;
using Faker.NET.Locales.EN;
using Faker.NET.Locales.FR;
using Faker.NET.Locales.RU;
using Faker.NET.Locales.ZH;
using System.Globalization;

namespace Faker.NET
{
    /// <summary>
    /// Decorator to handle Locales and calls to base classes
    /// </summary>
    public class Faker
    {
        public static void SetLocale(string locale)
        {
            Culture = CultureInfo.GetCultureInfo(locale);
            SetFakerInstance();
        }

        public static void SetLocale(CultureInfo cultureInfo)
        {
            Culture = cultureInfo;
            FakerInstance = SetFakerInstance();
        }

        private static IFakerLocale SetFakerInstance()
        {
            return Culture.TwoLetterISOLanguageName switch
            {
                "ar" => new ARLocale(),
                "en" => new ENLocale(),
                "fr" => new FRLocale(),
                "ru" => new RULocale(),
                "zh" => new ZHLocale(),
                _ => throw new NotSupportedException($"{Culture.TwoLetterISOLanguageName} is not yet supported by Faker.NET. Feel free to contribute at:\n\t" +
                                        $"https://github.com/baileydauterman/Faker.NET"),
            };
        }

        public static CultureInfo Culture { get; private set; } = CultureInfo.GetCultureInfo("en");

        public static IFakerComputer Computer => FakerInstance.Computer;

        public static IFakerName Name => FakerInstance.Name;

        public static IFakerUser User => FakerInstance.User;

        public static IFakerLorem Lorem => FakerInstance.Lorem;

        public static IFakerLocation Location => FakerInstance.Location;

        public static IFakerPhoneNumber Phone => FakerInstance.PhoneNumber;

        public static IFakerCustom Custom { get; set; }

        public static Randomizer Randomizer = new Randomizer();

        private static IFakerLocale FakerInstance { get; set; } = SetFakerInstance();
    }
}
