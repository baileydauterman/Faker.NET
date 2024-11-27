namespace Faker.NET.Tests.Locales
{
    [TestFixture(FakerLocale.English)]
    [TestFixture(FakerLocale.German)]
    [TestFixture(FakerLocale.Russian)]
    internal class PhoneNumbers
    {
        public PhoneNumbers(FakerLocale locale)
        {
            Faker.SetLocale(locale);
        }

        [Test]
        public void GeneratePhoneNumber()
        {
            Assert.That(Faker.Phone.Number, Is.Not.Null);
            Assert.That(Faker.Phone.NumberWithCountryCode, Is.Not.Null);
        }
    }
}
