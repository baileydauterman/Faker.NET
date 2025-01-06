using Faker.NET.Common.Phone;

namespace Faker.NET.Tests.Locales
{
    [TestFixture(FakerLocale.English)]
    [TestFixture(FakerLocale.German)]
    [TestFixture(FakerLocale.Russian)]
    internal class PhoneNumberTests
    {
        public PhoneNumberTests(FakerLocale locale)
        {
            Faker.SetLocale(locale);
        }

        [Test]
        public void GeneratePhoneNumber()
        {
            Assert.That(Faker.Phone.Number(), Is.Not.Null);
            Assert.That(Faker.Phone.Number(PhoneNumberType.National), Is.Not.Null);
            Assert.That(Faker.Phone.Number(PhoneNumberType.International), Is.Not.Null);
        }
    }
}
