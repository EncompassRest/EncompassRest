using System;
using Newtonsoft.Json;

namespace EncompassRest.Schema
{
    internal sealed class FieldOptionConverter : JsonConverter<FieldOption>
    {
        public override bool CanWrite => false;

        public override FieldOption ReadJson(JsonReader reader, Type objectType, FieldOption? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                    var value = reader.Value!.ToString();
                    return new FieldOption(value);
                default:
                    return serializer.Deserialize<FieldOption>(reader)!;
            }
        }

        public override void WriteJson(JsonWriter writer, FieldOption? value, JsonSerializer serializer) => throw new NotSupportedException();
    }
}