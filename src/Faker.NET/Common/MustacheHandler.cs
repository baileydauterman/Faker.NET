using System.Text;
using System.Text.RegularExpressions;

namespace Faker.NET.Common
{
    public class MustacheHandler
    {
        public string Replace(string template) => Replace(template, _commonReplacements);

        public string Replace(string template, Dictionary<string, Func<string>> replacements)
        {
            // var value = FindAll(template, "{{").ToArray();
            var indexStarts = Task.Run(() => FindAll(template, "{{").ToArray());
            var indexEnds = Task.Run(() => FindAll(template, "}}").ToArray());

            var builder = new StringBuilder();
            Task.WaitAll(indexStarts, indexEnds);

            int previousEnd = 0;

            foreach (var (start, end) in indexStarts.Result.Zip(indexEnds.Result))
            {
                if (previousEnd < start)
                {
                    builder.Append(template.AsSpan(previousEnd, start - previousEnd));
                }

                var startToEnd = start + 2;
                var word = template.Substring(startToEnd, end - startToEnd);
                builder.Append(GetWordReplacement(word, replacements));

                previousEnd = end + 2;
            }

            return builder.ToString();
        }

        private string GetWordReplacement(string word, Dictionary<string, Func<string>> replacement)
        {
            var match = _index.Match(word);
            var index = -1;
            if (match.Success)
            {
                word = word.Substring(0, word.IndexOf('['));
                index = int.Parse(match.Groups["idx"].Value);
            }

            var output = replacement[word].Invoke();
            return index > -1 ? output.Substring(index, 1) : output;
        }

        private IEnumerable<int> FindAll(string template, string characters)
        {
            int index = template.IndexOf(characters);
            int charsLen = characters.Length;
            while (index != -1)
            {
                yield return index;
                index = template.IndexOf(characters, index + charsLen);
            }

            yield break;
        }

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

            { "location.buildingNumber", () => Faker.Location.BuildingNumber() },
            { "location.state", () => Faker.Location.State() },
            { "location.streetSuffix", () => Faker.Location.StreetSuffix() },
            { "location.street", () => Faker.Location.Street() },

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
