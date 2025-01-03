using System;
using Faker.NET.Common.Person;

namespace Faker.NET.Attributes;

public class FakerPersonBioAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Person.Bio();
}

public class FakerPersonFirstNameAttribute : FakerAttribute
{
    public Sex? Sex { get; set; } = null;
    public override object GetPropertyValue() => Faker.Person.FirstName(Sex);
}

public class FakerPersonFullNameAttribute : FakerAttribute
{
    public string? FirstName { get; set; } = null;
    public string? LastName { get; set; } = null;
    public Sex? Sex { get; set; } = null;

    public override object GetPropertyValue() => Faker.Person.FullName(FirstName, LastName, Sex);
}

public class FakerPersonGenderAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Person.Gender();
}

public class FakerPersonJobAreaAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Person.JobArea();
}

public class FakerPersonJobDescriptorAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Person.JobDescriptor();
}
public class FakerPersonJobTitleAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Person.JobTitle();
}

public class FakerPersonJobTypeAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Person.JobType();
}

public class FakerPersonLastNameAttribute : FakerAttribute
{
    public Sex? Sex { get; set; } = null;
    public override object GetPropertyValue() => Faker.Person.LastName(Sex);
}

public class FakerPersonMiddleNameAttribute : FakerAttribute
{
    public Sex? Sex { get; set; } = null;
    public override object GetPropertyValue() => Faker.Person.MiddleName(Sex);
}

public class FakerPersonPrefixAttribute : FakerAttribute
{
    public Sex? Sex { get; set; } = null;
    public override object GetPropertyValue() => Faker.Person.Prefix(Sex);
}

public class FakerPersonSexAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Person.Sex();
}

public class FakerPersonSuffixAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Person.Suffix();
}

public class FakerPersonZodiacSignAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Person.ZodiacSign();
}