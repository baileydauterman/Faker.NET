namespace Faker.NET.Interfaces
{
    /// <summary>
    /// Interface to display text from a given language.
    /// </summary>
    public interface IFakerLorem
    {
        string GetWords(int count);
        
        string GetWords(int min, int max);

        string GetParagraphs(int count);

        string GetParagraphs(int min, int max);

        string GetSentences(int count);

        string GetSentences(int min, int max);
    }
}
