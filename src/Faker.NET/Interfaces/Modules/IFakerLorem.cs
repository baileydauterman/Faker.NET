namespace Faker.NET.Modules.Interfaces;

/// <summary>
/// Interface to display text from a given language.
/// </summary>
public interface IFakerLorem
{
    string Lines(int min = 1, int max = 3);

    string Paragraph();

    string Paragraphs(int min = 1, int max = 3);

    string Sentence();

    string Sentences(int min = 1, int max = 2);

    string Slug(int min = 1, int max = 3);

    string Text();

    string Word();

    string Words(int min = 1, int max = 3);
}
