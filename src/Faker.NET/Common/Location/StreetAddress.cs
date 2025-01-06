using System;
using Faker.NET.Interfaces.Modules;

namespace Faker.NET.Common.Location;

public class StreetAddress
{
    public Func<IFakerLocation, string> Normal { get; set; } = e => string.Empty;

    public Func<IFakerLocation, string> Full { get; set; } = e => string.Empty;
}
