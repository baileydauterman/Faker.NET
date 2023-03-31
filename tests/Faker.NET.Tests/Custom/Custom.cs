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
            var custom = new Faker.NET.Custom.Custom(data, secondData);

            _ = custom.Primary;
            _ = custom.Secondary;
        }

        List<string> data;
        List<string> secondData;
    }
}
