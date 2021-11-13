using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EncompassRest.Schema.v3
{
    /// <summary>
    /// EntitySchema
    /// </summary>
    public class EntitySchema : ExtensibleObject
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        /// <summary>
        /// EntitySchema Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// EntitySchema Type
        /// </summary>
        [JsonConverter(typeof(SchemaTypeConverter))]
        public List<StringEnumValue<SchemaType>> Type { get; set; }

        /// <summary>
        /// EntitySchema AdditionalProperties
        /// </summary>
        public JToken AdditionalProperties { get; set; }

        /// <summary>
        /// EntitySchema Properties
        /// </summary>
        public Dictionary<string, PropertySchema> Properties { get; set; }

        /// <summary>
        /// EntitySchema Definitions
        /// </summary>
        public Dictionary<string, EntitySchema> Definitions { get; set; }

        /// <summary>
        /// EntitySchema Required
        /// </summary>
        public List<string>? Required { get; set; }

        [JsonConstructor]
        internal EntitySchema()
        {
        }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}
