namespace Faker.NET.Common;

[Flags]
public enum StringCharacterTypes
{
    None = 0,
    UpperCase = 1,
    LowerCase = 2,
    Special = 4,
    Numbers = 8,
    All = UpperCase | LowerCase | Numbers | Special
}
