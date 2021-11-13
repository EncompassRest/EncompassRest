using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EncompassRest.Schema.v3
{
    /// <summary>
    /// PropertySchema
    /// </summary>
    public sealed class PropertySchema : ExtensibleObject
    {
        /// <summary>
        /// PropertySchema Type
        /// </summary>
        [JsonConverter(typeof(SchemaTypeConverter))]
        public List<StringEnumValue<SchemaType>>? Type { get; set; }

        /// <summary>
        /// PropertySchema AdditionalProperties
        /// </summary>
        public JToken? AdditionalProperties { get; set; }

        /// <summary>
        /// PropertySchema Items
        /// </summary>
        public JObject? Items { get; set; }

        /// <summary>
        /// PropertySchema Enum
        /// </summary>
        public List<string>? Enum { get; set; }

        /// <summary>
        /// PropertySchema MaxLength
        /// </summary>
        public int? MaxLength { get; set; }

        /// <summary>
        /// PropertySchema Format
        /// </summary>
        public StringEnumValue<PropertyFormat> Format { get; set; }

        /// <summary>
        /// PropertySchema Ref
        /// </summary>
        [JsonProperty("$ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// PropertySchema Minimum
        /// </summary>
        public decimal? Minimum { get; set; }

        /// <summary>
        /// PropertySchema Maximum
        /// </summary>
        public decimal? Maximum { get; set; }

        /// <summary>
        /// PropertySchema Default
        /// </summary>
        public int? Default { get; set; }
    }
}
