using System;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest
{
    /// <summary>
    /// A string wrapper type which is assignable to and from <typeparamref name="TEnum"/>.
    /// For use when a string property returned from an API has a set number of options but allows
    /// support for any string value for when the Enum is not updated to support the given option.
    /// </summary>
    /// <typeparam name="TEnum"></typeparam>
    [JsonConverter(typeof(StringEnumValueConverter<>))]
    public struct StringEnumValue<TEnum>
        where TEnum : struct, Enum
    {
        public static implicit operator StringEnumValue<TEnum>(string value) => new StringEnumValue<TEnum>(value);

        public static implicit operator string(StringEnumValue<TEnum> value) => value.Value;

        public static implicit operator StringEnumValue<TEnum>(TEnum? value) => new StringEnumValue<TEnum>(value);

        public static implicit operator TEnum?(StringEnumValue<TEnum> value) => value.EnumValue;

        public string Value { get; }

        public TEnum? EnumValue => Value != null && Enums.TryParse(Value, true, out TEnum value, EnumFormat.EnumMemberValue, EnumFormat.Name) ? value : (TEnum?)null;

        public StringEnumValue(string value)
        {
            Value = value;
        }

        public StringEnumValue(TEnum? value)
            : this(value?.Validate(nameof(value)).GetValue())
        {
        }

        public override string ToString() => Value;

        public override int GetHashCode() => Value?.GetHashCode() ?? 0;

        public override bool Equals(object obj) => obj != null && obj is StringEnumValue<TEnum> sev && sev.Value == Value;
    }

    internal sealed class StringEnumValueConverter<TEnum> : JsonConverter, IStringCreator
        where TEnum : struct, Enum
    {
        public override bool CanConvert(Type objectType) => objectType == TypeData<StringEnumValue<TEnum>>.Type;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => new StringEnumValue<TEnum>(reader.Value?.ToString());

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => writer.WriteValue(value is StringEnumValue<TEnum> sev ? sev.Value : value?.ToString());

        public object Create(string value) => new StringEnumValue<TEnum>(value);
    }
}