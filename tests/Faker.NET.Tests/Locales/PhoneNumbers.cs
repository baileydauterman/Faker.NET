namespace Faker.NET.Tests.Locales
{
    [TestFixture(FakerLocale.English)]
    [TestFixture(FakerLocale.German)]
    [TestFixture(FakerLocale.Russian)]
    internal class PhoneNumbers
    {
        public PhoneNumbers(FakerLocale locale)
        {
            Faker.SetInstance(locale);
        }

        [Test]
        public void GeneratePhoneNumber()
        {
            Assert.IsNotNull(Faker.Phone.Number);
            Assert.IsNotNull(Faker.Phone.NumberWithCountryCode);
        }
    }
}
