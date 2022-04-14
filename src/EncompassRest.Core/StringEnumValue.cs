using System;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest
{
    /// <summary>
    /// A string wrapper type which is assignable to and from <typeparamref name="TEnum"/>.
    /// For use when a string property returned from an Api has a set number of options but allows
    /// support for any string value for when the Enum is not updated to support the given option.
    /// </summary>
    /// <typeparam name="TEnum">The enum type.</typeparam>
    [JsonConverter(typeof(StringEnumValueConverter<>))]
    public struct StringEnumValue<TEnum> : IEquatable<StringEnumValue<TEnum>>
        where TEnum : struct, Enum
    {
        /// <summary>
        /// The implicit conversion operator from a string to a <see cref="StringEnumValue{TEnum}"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator StringEnumValue<TEnum>(string? value) => new StringEnumValue<TEnum>(value);

        /// <summary>
        /// The implicit conversion operator from a <see cref="StringEnumValue{TEnum}"/> to a string.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator string?(StringEnumValue<TEnum> value) => value.Value;

        /// <summary>
        /// The implicit conversion operator from an <typeparamref name="TEnum?"/> to a <see cref="StringEnumValue{TEnum}"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator StringEnumValue<TEnum>(TEnum? value) => new StringEnumValue<TEnum>(value);

        /// <summary>
        /// The implicit conversion operator from a <see cref="StringEnumValue{TEnum}"/> to an <typeparamref name="TEnum?"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator TEnum?(StringEnumValue<TEnum> value) => value.EnumValue;

        /// <summary>
        /// The string value.
        /// </summary>
        public string? Value { get; }

        /// <summary>
        /// The enum value if defined else <c>null</c>.
        /// </summary>
        public TEnum? EnumValue => Value != null && Enums.TryParse(Value, true, out TEnum value, EnumFormat.EnumMemberValue, EnumFormat.Name) ? value : (TEnum?)null;

        /// <summary>
        /// The StringEnumValue constructor for a string value.
        /// </summary>
        /// <param name="value">The string value to initialize the object with.</param>
        public StringEnumValue(string? value)
        {
            Value = value;
        }

        /// <summary>
        /// The StringEnumValue constructor for an <typeparamref name="TEnum?"/> value.
        /// </summary>
        /// <param name="value">The <typeparamref name="TEnum?"/> value to initialize the object with.</param>
        public StringEnumValue(TEnum? value)
            : this(value?.Validate(nameof(value)).GetValue())
        {
        }

        /// <summary>
        /// Returns the string representation of the object.
        /// </summary>
        /// <returns></returns>
        public override string? ToString() => Value;

        /// <summary>
        /// Gets the hash code for the object.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() => Value?.GetHashCode() ?? 0;

        /// <summary>
        /// Indicates if this object is equal to the specified object.
        /// </summary>
        /// <param name="obj">The object to compare with.</param>
        /// <returns></returns>
        public override bool Equals(object obj) => obj != null && obj is StringEnumValue<TEnum> sev && Equals(sev);

        /// <summary>
        /// Indicates if this object is equal to the specified object.
        /// </summary>
        /// <param name="other">The object to compare with.</param>
        /// <returns></returns>
        public bool Equals(StringEnumValue<TEnum> other) => other.Value == Value;

        /// <summary>
        /// Indicates if the <paramref name="left"/> object is equal to the <paramref name="right"/> object.
        /// </summary>
        /// <param name="left">The first object to compare.</param>
        /// <param name="right">The second object to compare.</param>
        /// <returns></returns>
        public static bool operator ==(StringEnumValue<TEnum> left, StringEnumValue<TEnum> right) => left.Equals(right);

        /// <summary>
        /// Indicates if the <paramref name="left"/> object is not equal to the <paramref name="right"/> object.
        /// </summary>
        /// <param name="left">The first object to compare.</param>
        /// <param name="right">The second object to compare.</param>
        /// <returns></returns>
        public static bool operator !=(StringEnumValue<TEnum> left, StringEnumValue<TEnum> right) => !(left == right);
    }

    internal sealed class StringEnumValueConverter<TEnum> : JsonConverter, IStringCreator
        where TEnum : struct, Enum
    {
        public override bool CanConvert(Type objectType) => objectType == TypeData<StringEnumValue<TEnum>>.Type;

        public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer) => new StringEnumValue<TEnum>(reader.Value?.ToString());

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) => writer.WriteValue(value is StringEnumValue<TEnum> sev ? sev.Value : value?.ToString());

        public object Create(string? value) => new StringEnumValue<TEnum>(value);
    }
}