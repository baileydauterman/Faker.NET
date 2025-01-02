namespace Faker.NET.Modules.Interfaces;

/// <summary>
/// Interface to display text from a given language.
/// </summary>
public interface IFakerLorem
{
    string Word();

    string Words(int min = 1, int max = 3);

    string Paragraph();

    string Paragraphs(int min = 1, int max = 3);

    string Sentences();

    string Sentences(int min, int max);

    string Slug(int min = 1, int max = 3);

    string Text();
}
