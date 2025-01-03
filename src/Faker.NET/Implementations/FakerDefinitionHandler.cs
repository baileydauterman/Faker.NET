namespace Faker.NET.Implementations;

internal abstract class FakerDefinitionHandler<T>
{
    public FakerDefinitionHandler()
    {
        Data = Activator.CreateInstance<T>();
    }

    internal readonly T Data;
}
