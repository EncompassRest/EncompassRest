using System;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest
{
    internal sealed class PublicallySerializableConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => true;

        public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            var publicSerializer = JsonHelper.CreatePublicSerializer(serializer);
            publicSerializer.CheckAdditionalContent = false;
            return publicSerializer.Deserialize(reader, objectType)!;
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            var publicSerializer = JsonHelper.CreatePublicSerializer(serializer);
            publicSerializer.Serialize(writer, value);
        }
    }
}