using Faker.NET.API;
using Faker.NET.Common;

namespace Faker.NET.Tests.Custom
{
    internal class Custom
    {
        [Test]
        public void CreateCustom()
        {
            Faker.Custom = new CustomClass();

            _ = Faker.Custom.GetValue();
        }

        private class CustomClass : IFakerCustom
        {
            public string[] Data { get; set; } = new string[]
            {
                "Pizza",
                "Cheesecake",
                "Mac & Cheese",

            };

            /// <inheritdoc />
            public string GetValue() => Data.GetRandom();
        }
    }
}
