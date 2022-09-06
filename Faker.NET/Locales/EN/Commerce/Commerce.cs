namespace Faker.NET.Locales.EN.Commerce
{
    public class Commerce
    {
        public string Department
        {
            get => department.Get();
        }

        public string Product
        {
            get => product.Get();
        }

        private Department department = new();
        private ProductName product = new();
    }
}
