using System;
using EnumsNET;
using EnumsNET.NonGeneric;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Utilities
{
    internal enum EnumOutput
    {
        Integer,
        Name,
        CamelCaseName,
        EnumMemberValue
    }

    internal static class EnumOutputExtensions
    {
        public static EnumFormat GetEnumFormat(this EnumOutput value)
        {
            switch (value)
            {
                case EnumOutput.Name:
                    return EnumFormat.Name;
                case EnumOutput.CamelCaseName:
                    return EnumJsonConverter.CamelCaseNameFormat;
                case EnumOutput.EnumMemberValue:
                    return EnumFormat.EnumMemberValue;
                default:
                    return EnumFormat.DecimalValue;
            }
        }
    }

    internal sealed class EnumJsonConverter : JsonConverter
    {
        internal static readonly EnumFormat CamelCaseNameFormat;
        internal static readonly EnumFormat[] CamelCaseNameFormatArray;
        private static readonly CamelCaseNamingStrategy s_camelCaseNamingStrategy;

        static EnumJsonConverter()
        {
            s_camelCaseNamingStrategy = new CamelCaseNamingStrategy();
            CamelCaseNameFormat = Enums.RegisterCustomEnumFormat(member => s_camelCaseNamingStrategy.GetPropertyName(member.Name, false));
            CamelCaseNameFormatArray = new[] { CamelCaseNameFormat };
        }

        private readonly EnumFormat[] _enumFormats;

        public EnumOutput EnumOutput { get; }

        public EnumJsonConverter()
            : this(EnumOutput.Name)
        {
        }

        public EnumJsonConverter(EnumOutput enumOutput)
        {
            enumOutput.Validate(nameof(enumOutput));

            EnumOutput = enumOutput;
            _enumFormats = new[] { enumOutput.GetEnumFormat() };
        }

        public override bool CanConvert(Type objectType)
        {
            var data = TypeData.Get(objectType);
            return data.IsEnum || data.NonNullableValueTypeData?.IsEnum == true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                switch (reader.TokenType)
                {
                    case JsonToken.Null:
                        if (!TypeData.Get(objectType).IsNullable)
                        {
                            throw new JsonSerializationException($"Cannot convert null value to {objectType}.");
                        }
                        return null;
                    case JsonToken.String:
                        return NonGenericEnums.Parse(objectType, (string)reader.Value, _enumFormats);
                    case JsonToken.Integer:
                        return NonGenericEnums.ToObject(objectType, reader.Value);
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
                if (EnumOutput != EnumOutput.Integer)
                {
                    var member = NonGenericEnums.GetMember(enumType, value);
                    if (member != null)
                    {
                        writer.WriteValue(member.AsString(_enumFormats));
                        return;
                    }
                }
                writer.WriteRawValue(NonGenericEnums.AsString(enumType, value, EnumFormat.DecimalValue));
            }
        }
    }
}