using System.Text.Json;
using Faker.NET.Files.Json;

namespace Faker.NET.Tests.Files
{
	public class Json
	{
		[Test]
		public void SingleObject()
		{
			Faker.Randomizer.SetSeed(1000);
			var fakedData = JsonFaker.FromObject(SomeValue.SetTestValues).Trim();
			Assert.That(fakedData, Is.EqualTo(_singleFaked));

			Faker.Randomizer.Reset();
		}

		[Test]
		public void SingleNestedObject()
		{
			Faker.Randomizer.SetSeed(1000);
			var fakedData = JsonFaker.FromObject(AnotherValue.AsValue, jsonSerializerOptions);
			Assert.That(fakedData, Is.EqualTo(_singleNestedFaked));
            Faker.Randomizer.Reset();
        }

		[Test]
		public void MultipleNodes()
		{
			var faker = new JsonFaker()
				.AddField<KeyValuePair<string, object>>(() => CreateNameNode("name", Faker.Name.First))
				.AddField<SomeValue>(SomeValue.SetTestValues)
				.AddField<AnotherValue>(AnotherValue.SetTestValues)
				.AddField<DoubleNested>(DoubleNested.SetTestValues);

			var output = faker.Generate();
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
			public string AValue { get; set; }
			public string BValue { get; set; }
			public string CValue { get; set; }
			public SomeValue nested { get; set; }

			public static object SetTestValues()
			{
				return new AnotherValue
				{
					AValue = Faker.Computer.IPv4Address,
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
		private const string _singleNestedFaked = "{\"AValue\":\"39.61.193.1\",\"BValue\":\"Mathias Koch\",\"CValue\":\"\",\"nested\":{\"firstValue\":\"Vincent Cassin\",\"secondvalue\":\"International Solutions Supervisor\"}}";
		private readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
		{
			WriteIndented = false
		};
    }
}

