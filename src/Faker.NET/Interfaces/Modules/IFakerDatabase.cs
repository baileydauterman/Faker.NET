namespace Faker.NET.Interfaces.Modules
{
    public interface IFakerDatabase
    {
        public string Collation();
        public string Column();
        public string Engine();
        public string MongodbObjectId();
        public string Type();
    }
}
