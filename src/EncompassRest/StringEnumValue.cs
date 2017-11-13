using System;
using EncompassRest.Utilities;
using EnumsNET;
using EnumsNET.Unsafe;
using Newtonsoft.Json;

namespace EncompassRest
{
    [JsonConverter(typeof(StringEnumValueConverter<>))]
    public struct StringEnumValue<TEnum> : IDirty
        where TEnum : struct
    {
        private static readonly EnumFormat[] s_enumFormats = new[] { EnumFormat.EnumMemberValue, EnumFormat.Name };

        public static implicit operator StringEnumValue<TEnum>(string value) => new StringEnumValue<TEnum>(value);

        public static implicit operator string(StringEnumValue<TEnum> value) => value.Value;

        public static implicit operator StringEnumValue<TEnum>(TEnum? value) => new StringEnumValue<TEnum>(value);

        public static implicit operator TEnum? (StringEnumValue<TEnum> value) => value.EnumValue;

        public string Value { get; }

        public TEnum? EnumValue => !string.IsNullOrEmpty(Value) && UnsafeEnums.TryParse(Value, out TEnum value, s_enumFormats) ? value : (TEnum?)null;

        internal bool Dirty { get; set; }

        public StringEnumValue(string value)
        {
            Value = value;
            Dirty = true;
        }

        public StringEnumValue(TEnum? value)
        {
            if (value.HasValue)
            {
                var nonNullableValue = value.GetValueOrDefault();
                UnsafeEnums.Validate(nonNullableValue, nameof(value));
                Value = UnsafeEnums.AsString(nonNullableValue, EnumFormat.EnumMemberValue, EnumFormat.Name);
            }
            else
            {
                Value = null;
            }
            Dirty = true;
        }

        public override string ToString() => Value;

        public override int GetHashCode() => Value?.GetHashCode() ?? 0;

        public override bool Equals(object obj) => obj != null && obj is StringEnumValue<TEnum> && ((StringEnumValue<TEnum>)obj).Value == Value;

        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }

    internal sealed class StringEnumValueConverter<TEnum> : JsonConverter
        where TEnum : struct
    {
        public override bool CanConvert(Type objectType) => objectType == TypeData<StringEnumValue<TEnum>>.Type;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => new StringEnumValue<TEnum>(reader.Value?.ToString());

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => writer.WriteValue(value is StringEnumValue<TEnum> ? ((StringEnumValue<TEnum>)value).Value : value?.ToString());
    }
}