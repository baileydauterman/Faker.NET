namespace Faker.NET.Implementations.Modules;

internal abstract class FakerDefinitionHandler<T>
{
    public FakerDefinitionHandler()
    {
        Data = Activator.CreateInstance<T>();
    }

    internal readonly T Data;
}
