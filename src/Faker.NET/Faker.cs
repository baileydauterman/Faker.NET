using System.Globalization;
using Faker.NET.Common;
using Faker.NET.Interfaces;
using Faker.NET.Interfaces.Modules;
using Faker.NET.Modules.Interfaces;

namespace Faker.NET
{
    /// <summary>
    /// Static entry point into creating fake data. Can be changed with any SetLocale method
    /// </summary>
    public class Faker
    {
        internal static MustacheHandler Mustache { get; } = new MustacheHandler();

        public static void SetLocale(FakerLocale locale)
        {
            FakerInstance = FakerLocaleFactory.Create(locale);
        }

        public static void Set(IFakerLocaleInstance faker)
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

        public static IFakerAirline Airline => FakerInstance.Airline;

        public static IFakerColor Color => FakerInstance.Color;

        public static IFakerDate Date => FakerInstance.Date;

        public static IFakerInternet Internet => FakerInstance.Internet;

        public static IFakerLorem Lorem => FakerInstance.Lorem;

        public static IFakerLocation Location => FakerInstance.Location;

        public static IFakerPerson Person => FakerInstance.Person;

        public static IFakerPhone Phone => FakerInstance.PhoneNumber;

        public static IFakerWord Word => FakerInstance.Word;

        public static FakerRandomizer Randomizer { get; private set; } = new FakerRandomizer();

        public static IFakerLocaleInstance FakerInstance { get; private set; } = FakerLocaleFactory.Create(FakerLocale.English);
    }
}
