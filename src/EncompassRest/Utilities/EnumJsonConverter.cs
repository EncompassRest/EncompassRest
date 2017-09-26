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
        CamelCaseName
    }

    internal sealed class EnumJsonConverter : JsonConverter
    {
        private static readonly CamelCaseNamingStrategy s_camelCaseNamingStrategy = new CamelCaseNamingStrategy();

        public EnumOutput EnumOutput { get; }

        public EnumJsonConverter()
            : this(EnumOutput.Name)
        {
        }

        public EnumJsonConverter(EnumOutput enumOutput)
        {
            enumOutput.Validate(nameof(enumOutput));

            EnumOutput = enumOutput;
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
                        return NonGenericEnums.Parse(objectType, (string)reader.Value, EnumOutput == EnumOutput.CamelCaseName);
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
                    var name = NonGenericEnums.GetName(enumType, value);
                    if (name != null)
                    {
                        if (EnumOutput == EnumOutput.CamelCaseName)
                        {
                            name = s_camelCaseNamingStrategy.GetPropertyName(name, false);
                        }
                        writer.WriteValue(name);
                        return;
                    }
                }
                writer.WriteRawValue(NonGenericEnums.AsString(enumType, value, EnumFormat.DecimalValue));
            }
        }
    }
}