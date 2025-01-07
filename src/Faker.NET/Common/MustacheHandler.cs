using System.Text.RegularExpressions;

namespace Faker.NET.Common
{
    public class MustacheHandler
    {
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

        private readonly Regex _mustaches = new Regex("{{(?<word>\\w+)(?:\\[(?<index>\\d+)\\])?}}");
    }
}
