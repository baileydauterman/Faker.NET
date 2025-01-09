using Faker.NET.Common;
using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Common
{
    internal class MustacheHandlerTests : DeterministicTestClass
    {
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

        [TestCase("{{person.firstName}}.{{person.lastName}}", "johan.mueller")]
        [TestCase("{{person.firstName}}.{{person.middleName}}.{{person.lastName}}", "johan.bowie.jacobson")]
        [TestCase("{{person.firstName}}.{{person.middleName[0]}}.{{person.lastName}}", "johan.b.jacobson")]
        public void DefaultValues(string template, string expectedOutput)
        {
            var handler = new MustacheHandler();
            var handled = handler.Replace(template);

            Assert.That(handled.ToLower(), Is.EqualTo(expectedOutput));
        }

        [TestCase("{{person.firstName}}.{{person.firstName}}", "Johan.Chase")]
        [TestCase("Hello, my name is {{person.firstName}}.{{person.firstName}}", "Hello, my name is Johan.Chase")]
        public void UniqueReplace(string template, string expectedOutput)
        {
            var handler = new MustacheHandler();
            var handled = handler.Replace(template);
            Assert.That(handled, Is.EqualTo(expectedOutput));
        }
    }
}
