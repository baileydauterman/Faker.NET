namespace Faker.NET.EN.Commerce
{
    public static class Commerce
    {
        public static string Department => department.Get();

        public static string Product => product.Get();

        private readonly static Department department = new();
        private readonly static ProductName product = new();
    }
}
