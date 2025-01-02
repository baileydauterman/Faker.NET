using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Locales.RU.Data;

internal class RuPhoneNumberData : IFakerPhoneDefinition
{
    public string[] Human { get; } = {
        "(9##)###-##-##",
    };

    public string[] National { get; } = {
        "8 (9##) ###-##-##"
    };

    public string[] International { get; } = {
        "+79#########"
    };
}
