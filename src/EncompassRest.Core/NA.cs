using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest
{
    /// <summary>
    /// The <see cref="NA{T}"/> type accepts any value of <typeparamref name="T"/> as well as "NA" and null.
    /// </summary>
    /// <typeparam name="T">The type parameter.</typeparam>
    [JsonConverter(typeof(NAConverter))]
    public struct NA<T> : IEquatable<NA<T>>
    {
        /// <summary>
        /// The explicit conversion operator from an <see cref="NA{T}"/> to an <typeparamref name="T"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static explicit operator T(NA<T> value) => value.Value;

        /// <summary>
        /// The implicit conversion operator from an <typeparamref name="T"/> to an <see cref="NA{T}"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator NA<T>(T value) => new NA<T>(value);

        /// <summary>
        /// The implicit conversion operator from a string such as "NA" or null to an <see cref="NA{T}"/>.
        /// </summary>
        /// <param name="na">The value to convert.</param>
        public static implicit operator NA<T>(string na) => new NA<T>(na);

        private readonly T _value;
        private readonly bool _isNotNull;

        /// <summary>
        /// The value of the object. Throws an <see cref="InvalidOperationException"/> if <see cref="HasValue"/> is <c>false</c>.
        /// </summary>
        public T Value
        {
            get
            {
                if (IsNull)
                {
                    throw new InvalidOperationException("The IsNull property is true");
                }
                if (IsNA)
                {
                    throw new InvalidOperationException("The IsNA property is true");
                }

                return _value;
            }
        }

        /// <summary>
        /// Indicates if the object has a value meaning <see cref="IsNull"/> and <see cref="IsNA"/> are both <c>false</c>.
        /// </summary>
        public bool HasValue => _isNotNull && !IsNA;

        /// <summary>
        /// Indicates the object has a null value.
        /// </summary>
        public bool IsNull => !_isNotNull;

        /// <summary>
        /// Indicates the object has an "NA" value.
        /// </summary>
        public bool IsNA { get; }

        /// <summary>
        /// NA constructor.
        /// </summary>
        /// <param name="na">string value to initialize object as null or "NA".</param>
        public NA(string na)
        {
            _value = default!;
            _isNotNull = na != null;
            IsNA = _isNotNull;
        }

        /// <summary>
        /// NA constructor.
        /// </summary>
        /// <param name="value">value to initialize object.</param>
        public NA(T value)
        {
            _value = value;
            _isNotNull = true;
            IsNA = false;
        }

        /// <summary>
        /// Gets the value if the object has a value or else the default value for <typeparamref name="T"/>.
        /// </summary>
        /// <returns></returns>
        public T GetValueOrDefault() => _value;

        /// <summary>
        /// Gets the value if the object has a value or else the specified default value.
        /// </summary>
        /// <param name="defaultValue">The default value to return if the object does not have a value.</param>
        /// <returns></returns>
        public T GetValueOrDefault(T defaultValue) => HasValue ? _value : defaultValue;

        /// <summary>
        /// Gets the hash code for the object.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() => _isNotNull ? (IsNA ? "NA".GetHashCode() : _value!.GetHashCode()) : 0;

        /// <summary>
        /// Returns the string representation of the object.
        /// </summary>
        /// <returns></returns>
        public override string? ToString() => _isNotNull ? (IsNA ? "NA" : _value!.ToString()) : null;

        /// <summary>
        /// Indicates if this object is equal to the specified object.
        /// </summary>
        /// <param name="obj">The object to compare with.</param>
        /// <returns></returns>
        public override bool Equals(object obj) => obj != null && obj is NA<T> na && Equals(na);

        /// <summary>
        /// Indicates if this object is equal to the specified object.
        /// </summary>
        /// <param name="other">The object to compare with.</param>
        /// <returns></returns>
        public bool Equals(NA<T> other) => IsNull ? other.IsNull : (IsNA ? other.IsNA : (other.HasValue && EqualityComparer<T>.Default.Equals(other._value, _value)));

        /// <summary>
        /// Indicates if the <paramref name="left"/> object is equal to the <paramref name="right"/> object.
        /// </summary>
        /// <param name="left">The first object to compare.</param>
        /// <param name="right">The second object to compare.</param>
        /// <returns></returns>
        public static bool operator ==(NA<T> left, NA<T> right) => left.Equals(right);

        /// <summary>
        /// Indicates if the <paramref name="left"/> object is not equal to the <paramref name="right"/> object.
        /// </summary>
        /// <param name="left">The first object to compare.</param>
        /// <param name="right">The second object to compare.</param>
        /// <returns></returns>
        public static bool operator !=(NA<T> left, NA<T> right) => !(left == right);
    }

    internal sealed class NAConverter : JsonConverter, IStringCreator
    {
        private static readonly ConcurrentDictionary<Type, InternalConverter> _converters = new();

        private static InternalConverter? GetConverter(Type type, bool throwOnNull = false)
        {
            if (!_converters.TryGetValue(type, out var converter) && type.GetTypeInfo().IsGenericType && !type.GetTypeInfo().IsGenericTypeDefinition && type.GetGenericTypeDefinition() == typeof(NA<>))
            {
                converter = _converters.GetOrAdd(type, t => (InternalConverter)Activator.CreateInstance(typeof(InternalConverter<>).MakeGenericType(t.GenericTypeArguments[0])));
            }
            if (converter == null && throwOnNull)
            {
                throw new InvalidOperationException("Converter only supports NA<T> type");
            }
            return converter;
        }

        public override bool CanConvert(Type objectType) => GetConverter(objectType) != null;

        public object Create(Type type, string? value) => GetConverter(type, throwOnNull: true)!.Create(value);

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer) => GetConverter(objectType, throwOnNull: true)!.ReadJson(reader, objectType, existingValue, serializer);

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) => writer.WriteValue(value?.ToString());

        private abstract class InternalConverter
        {
            public abstract object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer);

            public abstract object Create(string? value);
        }

        private sealed class InternalConverter<T> : InternalConverter
        {
            public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
            {
                switch (reader.TokenType)
                {
                    case JsonToken.Null:
                        return new NA<T>();
                    case JsonToken.String when IsNA(reader.Value!.ToString()):
                        return new NA<T>("NA");
                    default:
                        return new NA<T>(serializer.Deserialize<T>(reader)!);
                }
            }

            public override object Create(string? value) => value == null
                ? new NA<T>()
                : (IsNA(value)
                    ? new NA<T>("NA")
                    : (object)new NA<T>(JsonHelper.FromJson<T>(value)));

            private static bool IsNA(string value) => string.Equals(new string(value
#if !STRING_GENERIC_IENUMERABLE
            .Cast<char>()
#endif
            .Where(c => !char.IsPunctuation(c) && !char.IsWhiteSpace(c)).ToArray()), "NA", StringComparison.OrdinalIgnoreCase);
        }
    }
}