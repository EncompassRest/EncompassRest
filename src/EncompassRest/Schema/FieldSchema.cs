using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Schema
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class FieldSchema
    {
        public string Format { get; set; }
        public bool? ReadOnly { get; set; }
        public bool? Nullable { get; set; }
        public string Type { get; set; }
        [JsonProperty(ItemConverterType = typeof(FieldOptionConverter))]
        public List<FieldOption> AllowedValues { get; set; }
        public string EntityType { get; set; }
        public bool? Required { get; set; }
        public string Description { get; set; }
        public string ElementType { get; set; }
        public string FieldId { get; set; }
        public bool? FixedLength { get; set; }
    }
}