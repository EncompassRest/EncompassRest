using System;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Utilities
{
    internal sealed class EnumJsonConverter : JsonConverter
    {
        internal static readonly EnumFormat CamelCaseNameFormat = Enums.RegisterCustomEnumFormat(member => JsonHelper.CamelCaseNamingStrategy.GetPropertyName(member.Name, false));
        
        public EnumFormat EnumFormat { get; }

        public EnumJsonConverter()
            : this(EnumFormat.Name)
        {
        }

        public EnumJsonConverter(EnumFormat enumFormat)
        {
            enumFormat.Validate(nameof(enumFormat));

            EnumFormat = enumFormat;
        }

        public override bool CanConvert(Type objectType)
        {
            var data = TypeData.Get(objectType);
            return data.IsEnum || data.NonNullableValueTypeData?.IsEnum == true;
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            try
            {
                var typeData = TypeData.Get(objectType);
                switch (reader.TokenType)
                {
                    case JsonToken.Null:
                        if (!typeData.IsNullable)
                        {
                            throw new JsonSerializationException($"Cannot convert null value to {objectType}.");
                        }
                        return null;
                    case JsonToken.String:
                        return Enums.Parse(typeData.NonNullableValueTypeData?.Type ?? objectType, (string)reader.Value, ignoreCase: false, EnumFormat);
                    case JsonToken.Integer:
                        return Enums.ToObject(typeData.NonNullableValueTypeData?.Type ?? objectType, reader.Value);
                    default:
                        throw new JsonSerializationException($"Unexpected token {reader.TokenType} when parsing enum.");
                }
            }
            catch (Exception ex)
            {
                throw new JsonSerializationException($"Error converting value {reader.Value} to type '{objectType}'", ex);
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                var enumType = value.GetType();
                enumType = Nullable.GetUnderlyingType(enumType) ?? enumType;
                if (EnumFormat != EnumFormat.DecimalValue)
                {
                    var member = Enums.GetMember(enumType, value);
                    if (member != null)
                    {
                        writer.WriteValue(member.AsString(EnumFormat));
                        return;
                    }
                }
                writer.WriteRawValue(Enums.AsString(enumType, value, EnumFormat.DecimalValue));
            }
        }
    }
}