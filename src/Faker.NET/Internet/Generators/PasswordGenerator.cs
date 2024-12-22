using System.Text;
using Faker.NET.Extensions;

namespace Faker.NET.Internet.Generators;

internal class PasswordGenerator
{
    public string Generate(int length, PasswordGeneratorFlags settings = PasswordGeneratorFlags.All)
    {
        if (settings == PasswordGeneratorFlags.None)
        {
            return "";
        }

        if (length > 48)
        {
            length = 48;
        }

        var builder = new StringBuilder(length);
        AddGenerators(settings);

        while (length > 0)
        {
            length--;
            var random = _randomGetter.GetRandom();
            var randChar = _characterGenerators[random].Invoke();
            builder.Append(randChar);
        }

        return builder.ToString();
    }

    private void AddGenerators(PasswordGeneratorFlags settings)
    {
        _characterGenerators.Clear();
        _randomGetter.Clear();

        if ((settings & PasswordGeneratorFlags.LowerCase) == PasswordGeneratorFlags.LowerCase)
        {
            _characterGenerators.Add(PasswordGeneratorFlags.LowerCase, () => GetRandomCharacter(97, 122));
            _randomGetter.Add(PasswordGeneratorFlags.LowerCase);
        }

        if ((settings & PasswordGeneratorFlags.UpperCase) == PasswordGeneratorFlags.UpperCase)
        {
            _characterGenerators.Add(PasswordGeneratorFlags.UpperCase, () => GetRandomCharacter(65, 90));
            _randomGetter.Add(PasswordGeneratorFlags.UpperCase);
        }

        if ((settings & PasswordGeneratorFlags.Special) == PasswordGeneratorFlags.Special)
        {
            _characterGenerators.Add(PasswordGeneratorFlags.Special, () => GetRandomCharacter(33, 64));
            _randomGetter.Add(PasswordGeneratorFlags.Special);
        }

        if ((settings & PasswordGeneratorFlags.Numbers) == PasswordGeneratorFlags.Numbers)
        {
            _characterGenerators.Add(PasswordGeneratorFlags.Numbers, () => GetRandomCharacter(48, 57));
            _randomGetter.Add(PasswordGeneratorFlags.Numbers);
        }
    }

    private char GetRandomCharacter(int low, int high)
    {
        return (char)Faker.Randomizer.Next(low, high);
    }

    private readonly Dictionary<PasswordGeneratorFlags, Func<char>> _characterGenerators = new Dictionary<PasswordGeneratorFlags, Func<char>>();

    private readonly List<PasswordGeneratorFlags> _randomGetter = new List<PasswordGeneratorFlags>();
}
