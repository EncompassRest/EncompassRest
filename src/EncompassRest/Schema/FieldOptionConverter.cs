using System;
using Newtonsoft.Json;

namespace EncompassRest.Schema
{
    internal sealed class FieldOptionConverter : JsonConverter
    {
        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType) => objectType == typeof(FieldOption);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                    var value = reader.Value.ToString();
                    return new FieldOption { Value = value, Text = value };
                default:
                    return serializer.Deserialize<FieldOption>(reader);
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }
    }
}