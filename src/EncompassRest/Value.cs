using System;
using Newtonsoft.Json;

namespace EncompassRest
{
    /// <summary>
    /// Value wrapper to use for dirty checking. It also serializes and deserializes the value properly.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [JsonConverter(typeof(ValueConverter<>))]
    internal struct Value<T> : IClean
    {
        public static implicit operator T(Value<T> value) => value._value;

        public static implicit operator Value<T>(T value) => new Value<T>(value);

        private readonly T _value;

        public bool Clean { get; set; }

        public Value(T value)
        {
            _value = value;
            Clean = false;
        }

        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value?.ToString();
    }
    
    internal sealed class ValueConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(Value<T>);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => new Value<T>(serializer.Deserialize<T>(reader));

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => serializer.Serialize(writer, (T)(Value<T>)value, typeof(T));
    }
}