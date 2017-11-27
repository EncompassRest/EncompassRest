using EncompassRest.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EncompassRest.Schema
{
    [JsonConverter(typeof(InstanceConverter))]
    public abstract class Instance
    {
        [JsonIgnore]
        public abstract InstanceType Type { get; }
    }

    internal sealed class InstanceConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == TypeData<Instance>.Type;

        public override bool CanWrite => false;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    return new StringDictionaryInstance(serializer.Deserialize<Dictionary<string, string>>(reader));
                case JsonToken.StartArray:
                    var list = serializer.Deserialize<List<object>>(reader);
                    if (list.Count > 0)
                    {
                        var first = list[0];
                        if (first is string)
                        {
                            return new StringListInstance(list.Cast<string>());
                        }
                        else
                        {
                            return new IntListInstance(list.Select(value => Convert.ToInt32(value)));
                        }
                    }
                    else
                    {
                        return new StringListInstance();
                    }
                default:
                    throw new InvalidOperationException($"Cannot handle token type of {reader.TokenType}");
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => throw new NotSupportedException();
    }
}