using Faker.NET.Implementations.Modules;

namespace Faker.NET.Locales.FR
{
    internal class FRLocale : FakerLocaleInstance
    {
        public FRLocale() : base("fr")
        {
            Person = new FakerPerson();
        }
    }
}
