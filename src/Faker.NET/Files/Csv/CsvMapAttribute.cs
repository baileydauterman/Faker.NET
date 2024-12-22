namespace Faker.NET.Files.Csv
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CsvMapAttribute : Attribute
    {
        /// <summary>
        /// The value that will be displayed in the csv when it is created.
        /// Can be used as the value to get property if the name is the same
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// The value used to get the specified property. E.g. "Name.First"
        /// </summary>
        public Type Property { get; set; }

        /// <summary>
        /// Name of field
        /// </summary>
        public string Field { get; set; }

        public object GetPropertyValue()
        {
            return Property.Name switch
            {
                "IFakerName" => GetFieldValue(Faker.Name),
                "IFakerComputer" => GetFieldValue(Faker.Internet),
                "IFakerUser" => GetFieldValue(Faker.User),
                "IFakerLorem" => GetFieldValue(Faker.Lorem),
                "IFakerLocation" => GetFieldValue(Faker.Location),
                _ => throw new NotSupportedException(Property.Name),
            };
        }

        private string GetFieldValue(object value)
        {
            var type = value.GetType();
            var field = type.GetProperty(Field);
            return (string)field.GetValue(value);
        }
    }
}
