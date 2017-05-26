using System;
using System.Collections.Concurrent;
using System.Reflection;
using Newtonsoft.Json;

namespace EncompassRest
{
    /// <summary>
    /// Value wrapper to use for dirty checking. It also serializes and deserializes the value properly.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [JsonConverter(typeof(ValueConverter))]
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

    internal sealed class ValueConverter : JsonConverter
    {
        private static readonly Type s_openNullableType = typeof(Nullable<>);
        private static readonly Type s_openJsonNullableType = typeof(Value<>);
        private static readonly Type s_openJsonNullableConverterInternalType = typeof(ValueConverterInternal<>);
        private static readonly ConcurrentDictionary<Type, IValueConverter> s_converters = new ConcurrentDictionary<Type, IValueConverter>();

        private static IValueConverter GetConverter(Type type) => s_converters.GetOrAdd(type, t =>
        {
            var typeInfo = t.GetTypeInfo();
            var isGenericAndNotDefinition = typeInfo.IsGenericType && !typeInfo.IsGenericTypeDefinition;
            Type genericTypeDefinition = null;
            if (typeInfo.IsValueType && isGenericAndNotDefinition && (genericTypeDefinition = t.GetGenericTypeDefinition()) == s_openNullableType)
            {
                return GetConverter(t.GenericTypeArguments[0]);
            }
            return isGenericAndNotDefinition && (genericTypeDefinition ?? t.GetGenericTypeDefinition()) == s_openJsonNullableType
                ? (IValueConverter)Activator.CreateInstance(s_openJsonNullableConverterInternalType.MakeGenericType(t.GenericTypeArguments[0]))
                : null;
        });

        public override bool CanConvert(Type objectType) => GetConverter(objectType) != null;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => GetConverter(objectType).ReadJson(reader, serializer);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => GetConverter(value.GetType()).WriteJson(writer, value, serializer);
    }

    internal interface IValueConverter
    {
        object ReadJson(JsonReader reader, JsonSerializer serializer);
        void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);
    }

    internal sealed class ValueConverterInternal<T> : IValueConverter
    {
        public object ReadJson(JsonReader reader, JsonSerializer serializer) => new Value<T>(serializer.Deserialize<T>(reader));

        public void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => serializer.Serialize(writer, (T)(Value<T>)value, typeof(T));
    }
}