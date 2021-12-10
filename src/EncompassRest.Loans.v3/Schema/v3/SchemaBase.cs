using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EncompassRest.Schema.v3;

/// <summary>
/// SchemaBase
/// </summary>
public abstract class SchemaBase : ExtensibleObject
{
    /// <summary>
    /// PropertySchema Ref
    /// </summary>
    [JsonProperty("$ref")]
    public string? Ref { get; set; }

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
    /// PropertySchema Enum
    /// </summary>
    public List<string?>? Enum { get; set; }
}