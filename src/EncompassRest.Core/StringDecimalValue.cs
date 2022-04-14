using System;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest
{
    /// <summary>
    /// A string wrapper type which is assignable to and from <see cref="decimal"/>.
    /// For use when a string property returned from an Api most often represents a decimal value.
    /// </summary>
    [JsonConverter(typeof(StringDecimalValueConverter))]
    public struct StringDecimalValue : IEquatable<StringDecimalValue>
    {
        /// <summary>
        /// The implicit conversion operator from a string to a <see cref="StringDecimalValue"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator StringDecimalValue(string? value) => new(value);

        /// <summary>
        /// The implicit conversion operator from a <see cref="StringDecimalValue"/> to a string.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator string?(StringDecimalValue value) => value.StringValue;

        /// <summary>
        /// The implicit conversion operator from a <see cref="decimal"/> to a <see cref="StringDecimalValue"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator StringDecimalValue(decimal? value) => new(value);

        /// <summary>
        /// The implicit conversion operator from a <see cref="StringDecimalValue"/> to a <see cref="decimal"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator decimal?(StringDecimalValue value) => value.Value;

        /// <summary>
        /// The string value.
        /// </summary>
        public string? StringValue { get; }

        /// <summary>
        /// The decimal value.
        /// </summary>
        public decimal? Value { get; }

        /// <summary>
        /// The StringEnumValue constructor for a string value.
        /// </summary>
        /// <param name="value">The string value to initialize the object with.</param>
        public StringDecimalValue(string? value)
        {
            StringValue = value;
            Value = decimal.TryParse(value, out var result) ? result : null;
        }

        /// <summary>
        /// The StringEnumValue constructor for a <see cref="decimal"/> value.
        /// </summary>
        /// <param name="value">The <see cref="decimal"/> value to initialize the object with.</param>
        public StringDecimalValue(decimal? value)
        {
            StringValue = value?.ToString();
            Value = value;
        }

        /// <summary>
        /// Returns the string representation of the object.
        /// </summary>
        /// <returns></returns>
        public override string? ToString() => StringValue;

        /// <summary>
        /// Gets the hash code for the object.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() => Value?.GetHashCode() ?? StringValue?.GetHashCode() ?? 0;

        /// <summary>
        /// Indicates if this object is equal to the specified object.
        /// </summary>
        /// <param name="obj">The object to compare with.</param>
        /// <returns></returns>
        public override bool Equals(object obj) => obj != null && obj is StringDecimalValue sdv && Equals(sdv);

        /// <summary>
        /// Indicates if this object is equal to the specified object.
        /// </summary>
        /// <param name="other">The object to compare with.</param>
        /// <returns></returns>
        public bool Equals(StringDecimalValue other) => other.Value.HasValue || Value.HasValue ? other.Value == Value : other.StringValue == StringValue;

        /// <summary>
        /// Indicates if the <paramref name="left"/> object is equal to the <paramref name="right"/> object.
        /// </summary>
        /// <param name="left">The first object to compare.</param>
        /// <param name="right">The second object to compare.</param>
        /// <returns></returns>
        public static bool operator ==(StringDecimalValue left, StringDecimalValue right) => left.Equals(right);

        /// <summary>
        /// Indicates if the <paramref name="left"/> object is not equal to the <paramref name="right"/> object.
        /// </summary>
        /// <param name="left">The first object to compare.</param>
        /// <param name="right">The second object to compare.</param>
        /// <returns></returns>
        public static bool operator !=(StringDecimalValue left, StringDecimalValue right) => !(left == right);
    }

    internal sealed class StringDecimalValueConverter : JsonConverter, IStringCreator
    {
        public override bool CanConvert(Type objectType) => objectType == TypeData<StringDecimalValue>.Type;

        public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer) => new StringDecimalValue(reader.Value?.ToString());

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) => writer.WriteValue(value is StringDecimalValue sdv ? sdv.StringValue : value?.ToString());

        public object Create(string? value) => new StringDecimalValue(value);
    }
}