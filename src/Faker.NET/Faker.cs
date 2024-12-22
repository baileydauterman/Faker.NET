using Faker.NET.Common;
using Faker.NET.Interfaces;
using Faker.NET.Internet;
using System.Globalization;

namespace Faker.NET
{
    /// <summary>
    /// Static entry point into creating fake data. Can be changed with any SetLocale method
    /// </summary>
    public class Faker
    {
        public static void SetLocale(FakerLocale locale)
        {
            FakerInstance = FakerLocaleFactory.Create(locale);
        }

        public static void SetLocale(IFakerLocaleInstance faker)
        {
            FakerInstance = faker;
        }

        public static void SetRandomizerSeed(int seed)
        {
            Randomizer = new FakerRandomizer(seed);
        }

        public static void ResetRandomizer()
        {
            Randomizer = new FakerRandomizer();
        }

        /// <summary>
        /// <see cref="Culture"/> can be used internally to display things like DateTimes and other
        /// things that might be dependent on the given culture.
        /// </summary>
        public static CultureInfo Culture => FakerInstance.Culture;

        public static IFakerInternet Internet => new FakerInternet();

        public static IFakerName Name => FakerInstance.Name;

        public static IFakerUser User => FakerInstance.User;

        public static IFakerLorem Lorem => FakerInstance.Lorem;

        public static IFakerLocation Location => FakerInstance.Location;

        public static IFakerPhoneNumber Phone => FakerInstance.PhoneNumber;

        public static Date Date { get; } = new Date();

        public static IFakerCustom Custom { get; set; }

        public static FakerRandomizer Randomizer { get; private set; } = new FakerRandomizer();

        public static IFakerLocaleInstance FakerInstance { get; private set; } = FakerLocaleFactory.Create(FakerLocale.English);
    }
}
