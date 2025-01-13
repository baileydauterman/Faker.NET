using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Locales.EN.Data;

internal class EnCommerceProductName : IFakerCommerceProductNameDefinition
{
    public string[] Adjective { get; } = {
    "Awesome",
    "Bespoke",
    "Electronic",
    "Elegant",
    "Ergonomic",
    "Fantastic",
    "Generic",
    "Gorgeous",
    "Handcrafted",
    "Handmade",
    "Incredible",
    "Intelligent",
    "Licensed",
    "Luxurious",
    "Modern",
    "Oriental",
    "Practical",
    "Recycled",
    "Refined",
    "Rustic",
    "Sleek",
    "Small",
    "Tasty",
    "Unbranded",
  };

    public string[] Material { get; } = {
    "Bronze",
    "Concrete",
    "Cotton",
    "Fresh",
    "Frozen",
    "Granite",
    "Metal",
    "Plastic",
    "Rubber",
    "Soft",
    "Steel",
    "Wooden",
    };

    public string[] Product { get; } = {
    "Bacon",
    "Ball",
    "Bike",
    "Car",
    "Chair",
    "Cheese",
    "Chicken",
    "Chips",
    "Computer",
    "Fish",
    "Gloves",
    "Hat",
    "Keyboard",
    "Mouse",
    "Pants",
    "Pizza",
    "Salad",
    "Sausages",
    "Shirt",
    "Shoes",
    "Soap",
    "Table",
    "Towels",
    "Tuna",
  };
}
