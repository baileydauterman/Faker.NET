using Faker.NET.Names;
using Faker.NET.Numbers;

// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Hello, my name is {Name.FirstName}");
Console.WriteLine($"{Name.LastName}");
Console.WriteLine($"{Name.FullName}");
Console.WriteLine($"{Name.FullName}, {Name.Suffix}");
Console.WriteLine($"{Name.Prefix} {Name.FullName}, {Name.Suffix}");
Console.WriteLine($"{Name.Prefix} {Name.FullName}, {Name.Suffix} works as {Name.JobTitle}");

Console.WriteLine($"{Number.NumberString}");

Number.Format = "###-##-####";

Console.WriteLine($"{Number.NumberString}");

Number.Format = "##########";

Console.WriteLine($"{Number.NumberString}");
