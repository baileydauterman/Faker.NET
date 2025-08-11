using System;

namespace Faker.NET.Tests.Utils;

public static class IO
{
    public static string GetRandomTempFilePath()
    {
        return Path.Combine(Path.GetTempPath(), $"fakernet_{Path.GetRandomFileName()}");
    }

    public static void CleanTempDirectory()
    {
        foreach (var file in Directory.GetFiles(Path.GetTempPath(), "fakernet_*"))
        {
            File.Delete(file);
        }
    }
}
