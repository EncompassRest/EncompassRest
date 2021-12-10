using System;
using Newtonsoft.Json;
using EncompassRest.Utilities;

namespace EncompassRest.Schema
{
    internal sealed class FieldOptionConverter : JsonConverter
    {
        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType) => objectType == TypeData<FieldOption>.Type;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                    var value = reader.Value.ToString();
                    return new FieldOption(value);
                default:
                    return serializer.Deserialize<FieldOption>(reader);
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => throw new NotSupportedException();
    }
}