using Faker.NET.Files.Json;
using System.Text.Json;

namespace Faker.NET.Tests.Files
{
    public class Json
    {
        [Test]
        public void SingleObject()
        {
            Faker.SetRandomizerSeed(1000);
            var fakedData = JsonFaker.FromObject(SomeValue.SetTestValues, jsonSerializerOptions).Trim();
            Assert.That(fakedData, Is.EqualTo(_singleFaked));

            Faker.ResetRandomizer();
        }

        [Test]
        public void SingleNestedObject()
        {
            Faker.SetRandomizerSeed(1000);
            var fakedData = JsonFaker.FromObject(AnotherValue.AsValue, jsonSerializerOptions);
            Assert.That(fakedData, Is.EqualTo(_singleNestedFaked));
            Faker.ResetRandomizer();
        }

        [Test]
        public void MultipleNodes()
        {
            var faker = new JsonFaker()
                .AddField<KeyValuePair<string, object>>(() => CreateNameNode("name", Faker.Name.First))
                .AddField<SomeValue>(SomeValue.SetTestValues)
                .AddField<AnotherValue>(AnotherValue.SetTestValues)
                .AddField<DoubleNested>(DoubleNested.SetTestValues);

            var output = faker.CreateJsonString();
        }

        public KeyValuePair<string, object> CreateNameNode(string nodeName, object value)
        {
            return new KeyValuePair<string, object>(nodeName, value);
        }

        public class SomeValue
        {
            public string firstValue { get; set; } = string.Empty;

            public string secondvalue { get; set; } = string.Empty;

            public static object SetTestValues()
            {
                return new SomeValue
                {
                    firstValue = Faker.Name.Full,
                    secondvalue = Faker.Name.Job,
                };
            }

            public static SomeValue AsValue()
            {
                return (SomeValue)SetTestValues();
            }
        }

        public class AnotherValue
        {
            public string AValue { get; set; } = string.Empty;
            public string BValue { get; set; } = string.Empty;
            public string CValue { get; set; } = string.Empty;
            public SomeValue nested { get; set; } = new SomeValue();

            public static object SetTestValues()
            {
                return new AnotherValue
                {
                    AValue = Faker.Internet.IPv4(),
                    BValue = Faker.Name.Full,
                    CValue = string.Empty,
                    nested = SomeValue.AsValue()
                };
            }

            public static AnotherValue AsValue()
            {
                return (AnotherValue)SetTestValues();
            }
        }

        public class DoubleNested
        {
            public SomeValue someValue { get; set; } = new SomeValue();
            public AnotherValue anotherValue { get; set; } = new AnotherValue();

            public static object SetTestValues()
            {
                return new DoubleNested
                {
                    someValue = SomeValue.AsValue(),
                    anotherValue = AnotherValue.AsValue(),
                };
            }
        }

        private const string _singleFaked = "{\"firstValue\":\"Camryn Feil\",\"secondvalue\":\"Legacy Solutions Developer\"}";
        private const string _singleNestedFaked = "{\"AValue\":\"39.60.192.0\",\"BValue\":\"Mathias Koch\",\"CValue\":\"\",\"nested\":{\"firstValue\":\"Vincent Cassin\",\"secondvalue\":\"International Solutions Supervisor\"}}";
        private readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
        {
            WriteIndented = false
        };
    }
}

