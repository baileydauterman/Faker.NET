using System;

namespace Faker.NET.Tests.Utils;

public abstract class FileBasedTestClass
{
    [TearDown]
    public void CleanUp()
    {
        IO.CleanTempDirectory();
    }
}
