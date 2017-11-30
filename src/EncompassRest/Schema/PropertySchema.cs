using System.Collections.Generic;
using EncompassRest.Loans;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Schema
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class PropertySchema : ExtensibleObject
    {
        public StringEnumValue<LoanFieldFormat> Format { get; set; }
        public bool? ReadOnly { get; set; }
        public bool? Nullable { get; set; }
        public StringEnumValue<PropertySchemaType> Type { get; set; }
        [JsonProperty(ItemConverterType = typeof(FieldOptionConverter))]
        public List<FieldOption> AllowedValues { get; set; }
        public StringEnumValue<LoanEntity> EntityType { get; set; }
        public bool? Required { get; set; }
        public string Description { get; set; }
        public StringEnumValue<LoanEntity> ElementType { get; set; }
        public string FieldId { get; set; }
        public bool? FixedLength { get; set; }
        public List<string> KeyProperties { get; set; }
        public Dictionary<string, Instance> Instances { get; set; }
        public Dictionary<string, InstancePattern> InstancePatterns { get; set; }
        public Dictionary<string, List<string>> FieldInstances { get; set; }
        public Dictionary<string, List<string>> FieldPatterns { get; set; }
    }
}