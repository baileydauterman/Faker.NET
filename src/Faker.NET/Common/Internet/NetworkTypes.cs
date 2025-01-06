namespace Faker.NET.Common.Internet;

[Flags]
public enum NetworkTypes
{
    Loopback = 0,
    PrivateA = 1,
    PrivateB = 2,
    PrivateC = 4,
    TestNet1 = 8,
    TestNet2 = 16,
    TestNet3 = 32,
    LinkLocal = 64,
    Multicast = 128,
    Any = Loopback | PrivateA | PrivateB | PrivateC | TestNet1 | TestNet2 | TestNet3 | LinkLocal | Multicast,
}
