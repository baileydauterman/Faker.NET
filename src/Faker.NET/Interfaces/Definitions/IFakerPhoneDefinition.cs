using System;

namespace Faker.NET.Interfaces.Definitions;

public interface IFakerPhoneDefinition
{
    public string[] Human { get; }

    public string[] National { get; }

    public string[] International { get; }
}
