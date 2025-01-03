using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Locales.EN.Data;

internal class EnFakerPhoneData : IFakerPhoneDefinition
{
    public string[] Human { get; } = {
        "!##-!##-####",
        "(!##) !##-####",
        "1-!##-!##-####",
        "!##.!##.####",
        "!##-!##-#### x###",
        "(!##) !##-#### x###",
        "1-!##-!##-#### x###",
        "!##.!##.#### x###",
        "!##-!##-#### x####",
        "(!##) !##-#### x####",
        "1-!##-!##-#### x####",
        "!##.!##.#### x####",
        "!##-!##-#### x#####",
        "(!##) !##-#### x#####",
        "1-!##-!##-#### x#####",
        "!##.!##.#### x#####",
    };

    public string[] National { get; } = {
        "(!##) !##-####",
    };

    public string[] International { get; } = {
        "+1!##!######",
    };
}
