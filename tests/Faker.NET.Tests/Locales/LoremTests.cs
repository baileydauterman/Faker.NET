using System;
namespace Faker.NET.Tests.Locales
{
	[TestFixture("en")]
	[TestFixture("ru")]
	public class LoremTests
	{
		public LoremTests(string locale)
		{
			Faker.SetLocale(locale);
		}

		[TestCase(5)]
		[TestCase(50)]
		[TestCase(500)]
		public void Lorem(int count)
		{
			Assert.That(Faker.Lorem.GetText(count), Is.Not.Null);
		}
	}
}