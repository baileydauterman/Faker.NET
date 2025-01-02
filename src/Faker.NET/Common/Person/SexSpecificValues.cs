using Faker.NET.Extensions;

namespace Faker.NET.Common.Person;

public class SexSpecificValues<T>
{
    public T[] Unisex { get; set; } = Array.Empty<T>();

    public T[] Female { get; set; } = Array.Empty<T>();

    public T[] Male { get; set; } = Array.Empty<T>();

    public T Get(Sex? sex)
    {
        if (sex is null || Female.Length == 0 && Male.Length == 0)
        {
            return Unisex.GetRandom();
        }

        return sex switch
        {
            Sex.Male => Male.GetRandom(),
            _ => Female.GetRandom(),
        };
    }
}
