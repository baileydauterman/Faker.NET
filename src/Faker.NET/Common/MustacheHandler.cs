using System.Text;
using System.Text.RegularExpressions;

namespace Faker.NET.Common
{
    public class MustacheHandler
    {
        public MustacheHandler()
        {
        }

        public string Replace(string template) => Replace(template, _commonReplacements);

        public string Replace(string template, Dictionary<string, Func<string>> replacements)
        {
            _builder = new StringBuilder();
            var index = MoveToNextStartIndex(ref template);

            while (index > -1)
            {
                var endIndex = template.IndexOf("}}");
                var word = template.Substring(index + 2, endIndex - index - 2);
                HandleReplacement(word, replacements);
                template = template.Substring(endIndex + 2);
                index = MoveToNextStartIndex(ref template);
            }

            return _builder.ToString();
        }

        private int MoveToNextStartIndex(ref string template)
        {
            var index = template.IndexOf("{{");

            if (index != 0 && index != -1)
            {
                _builder.Append(template.Substring(0, index));
                template = template.Substring(index);
                index = 0;
            }

            return index;
        }

        private void HandleReplacement(string word, Dictionary<string, Func<string>> replacement)
        {
            var match = _index.Match(word);
            var index = -1;
            if (match.Success)
            {
                word = word.Substring(0, word.IndexOf('['));
                index = int.Parse(match.Groups["idx"].Value);
            }

            var output = replacement[word].Invoke();
            output = index > -1 ? output.Substring(index, 1) : output;
            _builder.Append(output);
        }

        private StringBuilder _builder;

        // private readonly Regex _mustaches = new Regex("^{{(?<word>[\\w\\.]+)(?:\\[(?<index>\\d+)\\])?");
        private readonly Regex _index = new Regex("\\[(?<idx>\\d+)\\]");
        private readonly Dictionary<string, Func<string>> _commonReplacements = new Dictionary<string, Func<string>>
        {
            { "airline.aircraftType", () => Faker.Airline.AircraftType().ToString() },
            { "airline.airline", () => Faker.Airline.Airline().ToString() },
            { "airline.airplane", () => Faker.Airline.Airplane().ToString() },
            { "airline.airport", () => Faker.Airline.Airport().ToString() },
            { "airline.flightNumber", () => Faker.Airline.FlightNumber() },
            { "airline.recordLocator", () => Faker.Airline.RecordLocator() },
            { "airline.seat", () => Faker.Airline.Seat() },

            { "person.bio", () => Faker.Person.Bio() },
            { "person.bioPart", () => Faker.Person.BioPart() },
            { "person.bioSupporter", () => Faker.Person.BioSupporter() },
            { "person.firstName", () => Faker.Person.FirstName() },
            { "person.fullName", () => Faker.Person.FullName() },
            { "person.gender", () => Faker.Person.Gender() },
            { "person.jobArea", () => Faker.Person.JobArea() },
            { "person.jobDescriptor", () => Faker.Person.JobDescriptor() },
            { "person.jobTitle", () => Faker.Person.JobTitle() },
            { "person.jobType", () => Faker.Person.JobType() },
            { "person.lastName", () => Faker.Person.LastName() },
            { "person.middleName", () => Faker.Person.MiddleName() },
            { "person.prefix", () => Faker.Person.Prefix() },
            { "person.sex", () => Faker.Person.Sex().ToString() },
            { "person.Suffix", () => Faker.Person.Suffix() },
            { "person.zodiacSign", () => Faker.Person.ZodiacSign() },

            { "word.adverb", () => Faker.Word.Adverb() },
            { "word.conjunction", () => Faker.Word.Conjunction() },
            { "word.interjection", () => Faker.Word.Interjection() },
            { "word.noun", () => Faker.Word.Noun() },
            { "word.preposition", () => Faker.Word.Preposition() },
            { "word.sample", () => Faker.Word.Sample() },
            { "word.verb", () => Faker.Word.Verb() },
            { "word.words", () => Faker.Word.Words() },

            { "internet.emoji", () => Faker.Internet.Emoji() }
        };
    }
}
