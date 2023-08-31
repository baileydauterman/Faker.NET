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
            var type = Property.Name switch
            {
                "IFakerName" => Faker.Name.GetType(),
                "IFakerComputer" => Faker.Computer.GetType(),
                _ => throw new NotSupportedException(Property.Name)
            };

            var field = type.GetProperty(Field);

            return field.GetValue(null);

            //var split = Property.Split('.', 2);

            //var props = typeof(Faker).GetProperty(split[0]);

            //if (props is null)
            //{
            //    throw new Exception($"Unable to find property {Property}");
            //}

            //return props.GetValue(split[1]);
        }
    }
}
