using Faker.NET.Common;
using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Common
{
    internal class MustacheHandlerTests : DeterministicTestClass
    {
        [TestCase("{{first}}.{{last}}", "johan.mueller")]
        [TestCase("{{first}}.{{middle}}.{{last}}", "johan.harper.mueller")]
        [TestCase("{{first}}.{{middle[0]}}.{{last}}", "johan.h.mueller")]
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

        [TestCase("{{first}}.{{last}}", "johan.mueller")]
        [TestCase("{{first}}.{{middle}}.{{last}}", "johan.bowie.jacobson")]
        [TestCase("{{first}}.{{middle[0]}}.{{last}}", "johan.b.jacobson")]
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
