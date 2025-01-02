namespace Faker.NET.Modules.Interfaces
{
    public interface IFakerCommerce
    {
        public string Department();
        public string Isbn();
        public string Price(int decimalPlaces = 2, int min = 1, int max = 1000, string symbol = "");
        public string Product();
        public string ProductAdjective();
        public string ProductDescription();
        public string ProductMaterial();
        public string ProductName();
    }
}
