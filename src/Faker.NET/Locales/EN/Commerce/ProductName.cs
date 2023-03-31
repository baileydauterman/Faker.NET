using Faker.NET.Common;

namespace Faker.NET.EN.Commerce
{
    internal class ProductName : FakerText
    {
        public override string Get(bool useAlternate = false)
        {
            return $"{Adjective[Randomizer.Next(Adjective.Count)]} {Material[Randomizer.Next(Material.Count)]} {Product[Randomizer.Next(Product.Count)]}";
        }

        public List<string> Adjective = new()
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

        public List<string> Material = new()
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

        public List<string> Product = new()
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
