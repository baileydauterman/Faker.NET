using System.Text.RegularExpressions;

namespace Faker.NET.Common
{
    public class MustacheHandler
    {
        public string Replace(string template)
        {
            return Replace(template, _commonReplacements);
        }

        public string Replace(string template, Dictionary<string, string> parameters)
        {
            var matches = _mustaches.Matches(template);
            foreach (Match match in matches)
            {
                var word = match.Groups["word"].Value;
                var value = parameters[word];
                if (match.Groups["index"].Captures.Count > 0)
                {
                    var index = int.Parse(match.Groups["index"].Value);
                    var replaceValue = $"{word}[{index}]";
                    value = $"{value[index]}";
                    template = template.Replace($"{{{{{replaceValue}}}}}", value);
                }
                else
                {
                    template = template.Replace($"{{{{{word}}}}}", value);
                }
            }

            return template;
        }

        public string Replace(string template, Dictionary<string, Func<string>> parameters)
        {
            var matches = _mustaches.Matches(template);
            foreach (Match match in matches)
            {
                var word = match.Groups["word"].Value;
                var value = parameters[word].Invoke();
                if (match.Groups["index"].Captures.Count > 0)
                {
                    var index = int.Parse(match.Groups["index"].Value);
                    var replaceValue = $"{word}[{index}]";
                    value = $"{value[index]}";
                    template = template.Replace($"{{{{{replaceValue}}}}}", value);
                }
                else
                {
                    template = template.Replace($"{{{{{word}}}}}", value);
                }
            }

            return template;
        }

        private readonly Regex _mustaches = new Regex("{{(?<word>\\w+)(?:\\[(?<index>\\d+)\\])?}}");

        private readonly Dictionary<string, Func<string>> _commonReplacements = new Dictionary<string, Func<string>>
        {
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
        };
    }
}
