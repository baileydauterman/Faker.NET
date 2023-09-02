using Faker.NET.Common;

namespace Faker.NET.EN.Commerce
{
    internal class ProductName : FakerText
    {
        public override string Get(bool useAlternate = false)
        {
            return $"{Adjective} {Material} {Product}";
        }

        public string Adjective => AdjectiveList[Faker.Randomizer.Next(AdjectiveList.Count)];
        public string Material => MaterialList[Faker.Randomizer.Next(MaterialList.Count)];
        public string Product => ProductList[Faker.Randomizer.Next(ProductList.Count)];

        public List<string> AdjectiveList = new()
        {
            "Small",
            "Ergonomic",
            "Electronic",
            "Rustic",
            "Intelligent",
            "Gorgeous",
            "Incredible",
            "Elegant",
            "Fantastic",
            "Practical",
            "Modern",
            "Recycled",
            "Sleek",
            "Bespoke",
            "Awesome",
            "Generic",
            "Handcrafted",
            "Handmade",
            "Oriental",
            "Licensed",
            "Luxurious",
            "Refined",
            "Unbranded",
            "Tasty",
        };

        public List<string> MaterialList = new()
        {
            "Steel",
            "Bronze",
            "Wooden",
            "Concrete",
            "Plastic",
            "Cotton",
            "Granite",
            "Rubber",
            "Metal",
            "Soft",
            "Fresh",
            "Frozen",
        };

        public List<string> ProductList = new()
        {
            "Chair",
            "Car",
            "Computer",
            "Keyboard",
            "Mouse",
            "Bike",
            "Ball",
            "Gloves",
            "Pants",
            "Shirt",
            "Table",
            "Shoes",
            "Hat",
            "Towels",
            "Soap",
            "Tuna",
            "Chicken",
            "Fish",
            "Cheese",
            "Bacon",
            "Pizza",
            "Salad",
            "Sausages",
            "Chips",
        };
    }
}
