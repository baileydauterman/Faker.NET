﻿using System.Text.Json;
using Faker.NET.Files.Json;
using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Files
{
    public class Json : DeterministicTestClass
    {
        [Test]
        public void SingleObject()
        {
            var fakedData = JsonFaker.FromObject(SomeValue.SetTestValues, jsonSerializerOptions).Trim();
            Asserts.IsEqual(fakedData, _singleFaked);
        }

        [Test]
        public void SingleNestedObject()
        {
            var fakedData = JsonFaker.FromObject(AnotherValue.AsValue, jsonSerializerOptions);
            Asserts.IsEqual(fakedData, _singleNestedFaked);
        }

        [Test]
        public void MultipleNodes()
        {
            var faker = new JsonFaker()
                .AddField<KeyValuePair<string, object>>(() => CreateNameNode("name", Faker.Person.FirstName()))
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
                    firstValue = Faker.Person.FullName(),
                    secondvalue = Faker.Person.JobTitle(),
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
                    BValue = Faker.Person.FullName(),
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

        private const string _singleFaked = "{\"firstValue\":\"Clinton Liam Jacobson\",\"secondvalue\":\"Chief Quality Executive\"}";
        private const string _singleNestedFaked = "{\"AValue\":\"130.45.158.102\",\"BValue\":\"Melanie Arya Ullrich\",\"CValue\":\"\",\"nested\":{\"firstValue\":\"Orville Lincoln Ziemann\",\"secondvalue\":\"Principal Applications Agent\"}}";
        private readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
        {
            WriteIndented = false
        };
    }
}

