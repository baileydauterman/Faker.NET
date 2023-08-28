using Faker.NET.API;

namespace Faker.NET.Locales
{
    public interface IFakerLocale
    {
        IFakerName Name { get; }
    }
}
