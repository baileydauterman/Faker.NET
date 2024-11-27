namespace Faker.NET.Attributes;

public class FakerLoremWordsAttribute : FakerAttribute
{
    public int Count = 0;

    public int Min = 0;

    public int Max = 0;

    public override object GetPropertyValue()
    {
        if (Count == 0 && Min == 0 && Max == 0)
        {
            return string.Empty;
        }

        if (Count != 0 && Min != 0 && Max != 0)
        {
            throw new ArgumentException($"{nameof(Count)} should be used by itself, or use {nameof(Min)} and {nameof(Max)} together");
        }

        if (Count > 0)
        {
            return Faker.Lorem.GetWords(Count);
        }

        if (Min >= 0 && Max > 0)
        {
            return Faker.Lorem.GetWords(Min, Max);
        }

        return string.Empty;
    }
}

public class FakerLoremSentencesAttribute : FakerAttribute
{
    public int Count = 0;

    public int Min = 0;

    public int Max = 0;

    public override object GetPropertyValue()
    {
        if (Count == 0 && Min == 0 && Max == 0)
        {
            return string.Empty;
        }

        if (Count != 0 && Min != 0 && Max != 0)
        {
            throw new ArgumentException($"{nameof(Count)} should be used by itself, or use {nameof(Min)} and {nameof(Max)} together");
        }

        if (Count > 0)
        {
            return Faker.Lorem.GetSentences(Count);
        }

        if (Min >= 0 && Max > 0)
        {
            return Faker.Lorem.GetSentences(Min, Max);
        }

        return string.Empty;
    }
}

public class FakerLoremParagraphAttribute : FakerAttribute
{
    public int Count = 0;

    public int Min = 0;

    public int Max = 0;

    public override object GetPropertyValue()
    {
        if (Count == 0 && Min == 0 && Max == 0)
        {
            return string.Empty;
        }

        if (Count != 0 && Min != 0 && Max != 0)
        {
            throw new ArgumentException($"{nameof(Count)} should be used by itself, or use {nameof(Min)} and {nameof(Max)} together");
        }

        if (Count > 0)
        {
            return Faker.Lorem.GetParagraphs(Count);
        }

        if (Min >= 0 && Max > 0)
        {
            return Faker.Lorem.GetParagraphs(Min, Max);
        }

        return string.Empty;
    }
}
