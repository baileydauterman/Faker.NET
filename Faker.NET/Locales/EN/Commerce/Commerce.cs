namespace Faker.NET.Locales.EN.Commerce
{
    public static class Commerce
    {
        public static string Department
        {
            get => department.Get();
        }

        public static string Product
        {
            get => product.Get();
        }

        private static Department department = new();
        private static ProductName product = new();
    }
}
