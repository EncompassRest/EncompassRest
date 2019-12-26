using System.Collections.Generic;
using EncompassRest.Loans;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Schema
{
    /// <summary>
    /// PropertySchema
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class PropertySchema : ExtensibleObject
    {
        /// <summary>
        /// PropertySchema Format
        /// </summary>
        public StringEnumValue<LoanFieldFormat> Format { get; set; }

        /// <summary>
        /// PropertySchema ReadOnly
        /// </summary>
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// PropertySchema Nullable
        /// </summary>
        public bool? Nullable { get; set; }

        /// <summary>
        /// PropertySchema Type
        /// </summary>
        public StringEnumValue<PropertySchemaType> Type { get; set; }

        /// <summary>
        /// PropertySchema AllowedValues
        /// </summary>
        [JsonProperty(ItemConverterType = typeof(FieldOptionConverter))]
        public List<FieldOption>? AllowedValues { get; set; }

        /// <summary>
        /// PropertySchema EntityType
        /// </summary>
        public StringEnumValue<LoanEntity> EntityType { get; set; }

        /// <summary>
        /// PropertySchema Required
        /// </summary>
        public bool? Required { get; set; }

        /// <summary>
        /// PropertySchema Description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// PropertySchema ElementType
        /// </summary>
        public StringEnumValue<LoanEntity> ElementType { get; set; }

        /// <summary>
        /// PropertySchema FieldId
        /// </summary>
        public string? FieldId { get; set; }

        /// <summary>
        /// PropertySchema FixedLength
        /// </summary>
        public bool? FixedLength { get; set; }

        /// <summary>
        /// PropertySchema KeyProperties
        /// </summary>
        public List<string>? KeyProperties { get; set; }

        /// <summary>
        /// PropertySchema Instances
        /// </summary>
        public Dictionary<string, Instance>? Instances { get; set; }

        /// <summary>
        /// PropertySchema InstancePatterns
        /// </summary>
        public Dictionary<string, InstancePattern>? InstancePatterns { get; set; }

        /// <summary>
        /// PropertySchema FieldInstances
        /// </summary>
        public Dictionary<string, List<string>>? FieldInstances { get; set; }

        /// <summary>
        /// PropertySchema FieldPatterns
        /// </summary>
        public Dictionary<string, List<string>>? FieldPatterns { get; set; }
    }
}