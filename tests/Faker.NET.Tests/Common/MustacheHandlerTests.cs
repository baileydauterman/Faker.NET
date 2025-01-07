using Faker.NET.Common;
using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Common
{
    internal class MustacheHandlerTests : DeterministicTestClass
    {
        [TestCase("{{first}}.{{last}}", "johan.jacobson")]
        [TestCase("{{first}}.{{middle}}.{{last}}", "johan.sasha.jacobson")]
        [TestCase("{{first}}.{{middle[0]}}.{{last}}", "johan.s.jacobson")]
        public void HardcodedValues(string template, string expectedOutput)
        {
            var handler = new MustacheHandler();
            var handled = handler.Replace(template, new Dictionary<string, string>
            {
                { "first", Faker.Person.FirstName() },
                { "last", Faker.Person.LastName() },
                { "middle", Faker.Person.MiddleName() },
            });

            Assert.That(handled.ToLower(), Is.EqualTo(expectedOutput));
        }

        [TestCase("{{first}}.{{last}}", "johan.jacobson")]
        [TestCase("{{first}}.{{middle}}.{{last}}", "johan.bowie.von")]
        [TestCase("{{first}}.{{middle[0]}}.{{last}}", "johan.b.von")]
        public void Lambdas(string template, string expectedOutput)
        {
            var handler = new MustacheHandler();
            var handled = handler.Replace(template, new Dictionary<string, Func<string>>
            {
                { "first", () => Faker.Person.FirstName() },
                { "last", () => Faker.Person.LastName() },
                { "middle", () => Faker.Person.MiddleName() },
            });

            Assert.That(handled.ToLower(), Is.EqualTo(expectedOutput));
        }
    }
}
