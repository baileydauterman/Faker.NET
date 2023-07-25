using Faker.NET.Files.Json;
using Faker.NET.EN.Computer;
using Faker.NET.EN.Names;
using Faker.NET.Common;
using System.Text.Json;

namespace Faker.NET.Tests.Files
{
	public class Json
	{
		[Test]
		public void SingleObject()
		{
			Randomizer.SetSeed(1000);
			var fakedData = JsonFaker.FromObject(SomeValue.SetTestValues).Trim();
			Assert.That(fakedData, Is.EqualTo(_singleFaked));

			Randomizer.Reset();
		}

		[Test]
		public void SingleNestedObject()
		{
			Randomizer.SetSeed(1000);
			var fakedData = JsonFaker.FromObject(AnotherValue.AsValue, jsonSerializerOptions);
			Assert.That(fakedData, Is.EqualTo(_singleNestedFaked));
			Randomizer.Reset();
		}

		[Test]
		public void MultipleNodes()
		{
			var faker = new JsonFaker()
				.AddField<KeyValuePair<string, object>>(() => CreateNameNode("name", Name.FirstName))
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
			public string firstValue { get; set; }

			public string secondvalue { get; set; }

            public static object SetTestValues()
			{
				return new SomeValue
				{
					firstValue = Name.FullName,
					secondvalue = Name.JobTitle,
				};
			}

			public static SomeValue AsValue()
			{
				return (SomeValue)SetTestValues();
			}
		}

		public class AnotherValue
		{
			public string AValue { get; set; }
			public string BValue { get; set; }
			public string CValue { get; set; }
			public SomeValue nested { get; set; }

			public static object SetTestValues()
			{
				return new AnotherValue
				{
					AValue = Computer.IPv4Address,
					BValue = Name.Email,
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
			public SomeValue someValue { get; set; }
			public AnotherValue anotherValue { get; set; }

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
		private const string _singleNestedFaked = "{\"AValue\":\"39.61.193.1\",\"BValue\":\"mathias.koch2@outlook.com\",\"CValue\":\"\",\"nested\":{\"firstValue\":\"Maud Bailey\",\"secondvalue\":\"Lead Directives Executive\"}}";
		private readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
		{
			WriteIndented = false
		};
    }
}

