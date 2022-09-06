using Faker.NET.Common;

namespace Faker.NET.Locales.EN.Commerce
{
    internal class Department : IFakerText
    {
        public Department() : base()
        {
            Data = new()
            {
                "Books",
                "Movies",
                "Music",
                "Games",
                "Electronics",
                "Computers",
                "Home",
                "Garden",
                "Tools",
                "Grocery",
                "Health",
                "Beauty",
                "Toys",
                "Kids",
                "Baby",
                "Clothing",
                "Shoes",
                "Jewelery",
                "Sports",
                "Outdoors",
                "Automotive",
                "Industrial",
            };
        }
    }
}
