using Faker.NET.Common;
using Faker.NET.Locales.EN.Data;

namespace Faker.NET.Locales.EN
{
    public class Commerce
    {
        public string Department => CommerceData.Department.GetRandom();

        public string Product => $"{_adjective} {_material} {_product}";

        private string _adjective => CommerceData.Adjective.GetRandom();

        private string _material => CommerceData.Material.GetRandom();

        private string _product => CommerceData.Product.GetRandom();
    }
}
