using System;

namespace Faker.NET.Extensions;

public static class RandomizerExtensions
{
    public static T GetRandom<T>(this T[] array)
    {
        return array[Faker.Randomizer.Next(array.Length)];
    }

    public static T GetRandom<T>(this IList<T> array)
    {
        return array[Faker.Randomizer.Next(array.Count)];
    }

    public static string CreateRandomString(this string[] array, int numberOfWords)
    {
        var wordArray = new string[numberOfWords];

        while (numberOfWords-- > 0)
        {
            wordArray[numberOfWords] = array.GetRandom();
        }

        return string.Join(" ", wordArray);
    }

    public static string CreateRandomLengthString(this string[] array, int min, int max)
    {
        var value = Faker.Randomizer.Next(min, max);
        return array.CreateRandomString(value);
    }
}
