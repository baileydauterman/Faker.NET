using CustomValue = Faker.NET.Custom;

namespace Faker.NET.Tests.Custom
{
    internal class Custom
    {
        [SetUp]
        public void SetUp()
        {
            data = new List<string>()
            {
                "Pizza",
                "Cheesecake",
                "Mac & Cheese",

            };

            secondData = new List<string>()
            {
                "Milkshake",
                "Lemonade",
                "Cola",
            };
        }

        [Test]
        public void CreateCustom()
        {
            var custom = new CustomValue.Custom(data, secondData);

            _ = custom.Get();
            _ = custom.Get(true);
        }

        List<string> data;
        List<string> secondData;
    }
}
