namespace Faker.NET.Tests.Locales
{
    [TestFixture("en")]
    [TestFixture("de")]
    internal class PhoneNumbers
    {
        public PhoneNumbers(string locale)
        {
            Faker.SetLocale(locale);
        }

        [Test]
        public void GeneratePhoneNUmber()
        {
            Assert.IsNotNull(Faker.Phone.Number);
        }
    }
}
