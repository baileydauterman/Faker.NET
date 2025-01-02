namespace Faker.NET.Implementations;

public abstract class FakerDefinitionHandler<T>
{
    public FakerDefinitionHandler()
    {
        Data = Activator.CreateInstance<T>();
    }

    internal readonly T Data;
}
