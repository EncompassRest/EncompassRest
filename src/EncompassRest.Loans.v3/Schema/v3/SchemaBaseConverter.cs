using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EncompassRest.Schema.v3;

internal sealed class SchemaBaseConverter<T> : JsonConverter<T>
    where T : SchemaBase, new()
{
    public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        var jObject = serializer.Deserialize<JObject>(reader);
        return jObject.TryGetValue("$ref", out var reference)
            ? new T { Ref = reference?.ToString() }
            : jObject.ToObject<T>(serializer);
    }

    public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer) => throw new NotSupportedException();

    public override bool CanWrite => false;
}