using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.Schema.v3;

/// <summary>
/// AdditionalProperties
/// </summary>
public sealed class AdditionalProperties : ExtensibleObject
{
    /// <summary>
    /// PropertySchema Type
    /// </summary>
    [JsonConverter(typeof(SchemaTypeConverter))]
    public List<StringEnumValue<SchemaType>>? Type { get; set; }
}

internal sealed class AdditionalPropertiesConverter : JsonConverter<AdditionalProperties>
{
    public override bool CanWrite => false;

    public override AdditionalProperties? ReadJson(JsonReader reader, Type objectType, AdditionalProperties? existingValue, bool hasExistingValue, JsonSerializer serializer) => reader.TokenType switch
    {
        JsonToken.Boolean => null,
        JsonToken.StartObject => serializer.Deserialize<AdditionalProperties>(reader),
        _ => throw new InvalidOperationException($"Cannot handle token type of {reader.TokenType}")
    };

    public override void WriteJson(JsonWriter writer, AdditionalProperties? value, JsonSerializer serializer) => throw new NotSupportedException();
}