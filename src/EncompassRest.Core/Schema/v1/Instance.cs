using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace EncompassRest.Schema.v1
{
    /// <summary>
    /// Instance
    /// </summary>
    [JsonConverter(typeof(InstanceConverter))]
    public abstract class Instance
    {
        /// <summary>
        /// The instance type.
        /// </summary>
        [JsonIgnore]
        public abstract InstanceType Type { get; }
    }

    internal sealed class InstanceConverter : JsonConverter<Instance>
    {
        public override bool CanWrite => false;

        public override Instance ReadJson(JsonReader reader, Type objectType, Instance? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    return new StringDictionaryInstance(serializer.Deserialize<Dictionary<string, string>>(reader)!);
                case JsonToken.StartArray:
                    var list = serializer.Deserialize<List<object>>(reader)!;
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

        public override void WriteJson(JsonWriter writer, Instance? value, JsonSerializer serializer) => throw new NotSupportedException();
    }
}