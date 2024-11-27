using System;
using System.Linq.Expressions;

namespace Faker.NET.Attributes;

public class LoremWordsAttribute : FakerAttribute
{
    public int WordCount = 0;

    public int MinWords = 0;

    public int MaxWords = 0;

    public override object GetPropertyValue()
    {
        if (WordCount == 0 && MinWords == 0 && MaxWords == 0)
        {
            return string.Empty;
        }

        if (WordCount != 0 && MinWords != 0 && MaxWords != 0)
        {
            throw new ArgumentException("WordCount should be used by itself, or use MinWords and MaxWords together");
        }

        if (WordCount > 0)
        {
            return Faker.Lorem.GetWords(WordCount);
        }

        if (MinWords >= 0 && MaxWords > 0)
        {
            return Faker.Lorem.GetWords(MinWords, MaxWords);
        }

        return string.Empty;
    }
}

public class LoremSentencesAttribute : FakerAttribute
{
    public int SentenceCount = 0;

    public int MinSentences = 0;

    public int MaxSentences = 0;

    public override object GetPropertyValue()
    {
        if (SentenceCount == 0 && MinSentences == 0 && MaxSentences == 0)
        {
            return string.Empty;
        }

        if (SentenceCount != 0 && MinSentences != 0 && MaxSentences != 0)
        {
            throw new ArgumentException("WordCount should be used by itself, or use MinWords and MaxWords together");
        }

        if (SentenceCount > 0)
        {
            return Faker.Lorem.GetSentences(SentenceCount);
        }

        if (MinSentences >= 0 && MaxSentences > 0)
        {
            return Faker.Lorem.GetSentences(MinSentences, MaxSentences);
        }

        return string.Empty;
    }
}

public class LoremParagraphAttribute : FakerAttribute
{
    public int ParagraphCount = 0;

    public int MinParagraphs = 0;

    public int MaxParagraphss = 0;

    public override object GetPropertyValue()
    {
        if (ParagraphCount == 0 && MinParagraphs == 0 && MaxParagraphss == 0)
        {
            return string.Empty;
        }

        if (ParagraphCount != 0 && MinParagraphs != 0 && MaxParagraphss != 0)
        {
            throw new ArgumentException("WordCount should be used by itself, or use MinWords and MaxWords together");
        }

        if (ParagraphCount > 0)
        {
            return Faker.Lorem.GetParagraphs(ParagraphCount);
        }

        if (MinParagraphs >= 0 && MaxParagraphss > 0)
        {
            return Faker.Lorem.GetParagraphs(MinParagraphs, MaxParagraphss);
        }

        return string.Empty;
    }
}
