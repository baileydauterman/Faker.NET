using System;

namespace Faker.NET.Extensions;

public static class StringExtensions
{
    public static string ToSlug(this string value)
    {
        var split = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return split.ToSlug();
    }

    public static string ToSlug(this string[] value)
    {
        return string.Join("-", value);
    }
}
