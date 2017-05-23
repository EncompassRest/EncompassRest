using System;
using System.Collections.Concurrent;
using System.Reflection;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest
{
    /// <summary>
    /// Wrapper struct that allows returning a null json value.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [JsonConverter(typeof(JsonNullableConverter))]
    public sealed class JsonNullable<T>
    {
        public static implicit operator T(JsonNullable<T> value)
        {
            Preconditions.NotNull(value, nameof(value));
            return value.Value;
        }

        public static implicit operator JsonNullable<T>(T value) => new JsonNullable<T>(value);

        public T Value { get; }

        public JsonNullable(T value)
        {
            Value = value;
        }

        public override int GetHashCode() => Value?.GetHashCode() ?? 0;

        public override string ToString() => Value?.ToString();
    }

    internal sealed class JsonNullableConverter : JsonConverter
    {
        private static readonly Type s_openNullableType = typeof(Nullable<>);
        private static readonly Type s_openJsonNullableType = typeof(JsonNullable<>);
        private static readonly Type s_openJsonNullableConverterInternalType = typeof(JsonNullableConverterInternal<>);
        private static readonly ConcurrentDictionary<Type, IJsonNullableConverter> s_converters = new ConcurrentDictionary<Type, IJsonNullableConverter>();

        private static IJsonNullableConverter GetConverter(Type type) => s_converters.GetOrAdd(type, t =>
        {
            var typeInfo = t.GetTypeInfo();
            var isGenericAndNotDefinition = typeInfo.IsGenericType && !typeInfo.IsGenericTypeDefinition;
            Type genericTypeDefinition = null;
            if (typeInfo.IsValueType && isGenericAndNotDefinition && (genericTypeDefinition = t.GetGenericTypeDefinition()) == s_openNullableType)
            {
                return GetConverter(t.GenericTypeArguments[0]);
            }
            return isGenericAndNotDefinition && (genericTypeDefinition ?? t.GetGenericTypeDefinition()) == s_openJsonNullableType
                ? (IJsonNullableConverter)Activator.CreateInstance(s_openJsonNullableConverterInternalType.MakeGenericType(t.GenericTypeArguments[0]))
                : null;
        });

        public override bool CanConvert(Type objectType) => GetConverter(objectType) != null;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => GetConverter(objectType).ReadJson(reader, serializer);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => GetConverter(value.GetType()).WriteJson(writer, value, serializer);
    }

    internal interface IJsonNullableConverter
    {
        object ReadJson(JsonReader reader, JsonSerializer serializer);
        void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);
    }

    internal sealed class JsonNullableConverterInternal<T> : IJsonNullableConverter
    {
        public object ReadJson(JsonReader reader, JsonSerializer serializer) => new JsonNullable<T>(serializer.Deserialize<T>(reader));

        public void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => serializer.Serialize(writer, (T)(JsonNullable<T>)value, typeof(T));
    }
}