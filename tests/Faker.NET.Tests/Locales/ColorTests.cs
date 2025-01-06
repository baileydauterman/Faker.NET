using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Locales
{
    internal class ColorTests : DeterministicTestClass
    {
        [Test]
        public void Cmyk()
        {
            var color = Faker.Color.Cmyk();

            Assert.Multiple(() =>
            {
                Assert.That(color.Cyan, Is.EqualTo(0.51));
                Assert.That(color.Magenta, Is.EqualTo(0.18));
                Assert.That(color.Yellow, Is.EqualTo(0.62));
                Assert.That(color.Key, Is.EqualTo(0.40));
                Assert.That(color.ForCss(), Is.EqualTo("cmyk(51%, 18%, 62%, 40%)"));
            });
        }

        [Test]
        public void Rgb()
        {
            var color = Faker.Color.Rgb(greenBase: 155);

            Assert.Multiple(() =>
            {
                Assert.That(color.Red, Is.EqualTo(129));
                Assert.That(color.Green, Is.EqualTo(155));
                Assert.That(color.Blue, Is.EqualTo(45));
                Assert.That(color.ToString(), Is.EqualTo("(129, 155, 45)"));
            });
        }
    }
}
