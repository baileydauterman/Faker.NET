namespace Faker.NET.Extensions;

public static class CollectionExtensions
{
    public static int[] ToRangeArray(this int start, int end, params int[] otherNumbers)
    {
        if (start > end)
        {
            throw new ArgumentException($"Start ({start}) cannot be larger than ending number ({end})");
        }
        var retVal = new int[end - start + otherNumbers.Length + 1];

        var i = 0;
        for (; i + start <= end; i++)
        {
            retVal[i] = start + i;
        }

        foreach (var otherValue in otherNumbers)
        {
            retVal[i++] = otherValue;
        }

        return retVal;
    }
}
