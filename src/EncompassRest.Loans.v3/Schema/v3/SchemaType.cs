using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace EncompassRest.Schema.v3
{
    /// <summary>
    /// SchemaType
    /// </summary>
    public enum SchemaType
    {
        /// <summary>
        /// object
        /// </summary>
        [EnumMember(Value = "object")]
        Object,
        /// <summary>
        /// string
        /// </summary>
        [EnumMember(Value = "string")]
        String,
        /// <summary>
        /// null
        /// </summary>
        [EnumMember(Value = "null")]
        Null,
        /// <summary>
        /// boolean
        /// </summary>
        [EnumMember(Value = "boolean")]
        Boolean,
        /// <summary>
        /// number
        /// </summary>
        [EnumMember(Value = "number")]
        Number,
        /// <summary>
        /// integer
        /// </summary>
        [EnumMember(Value = "integer")]
        Integer,
        /// <summary>
        /// array
        /// </summary>
        [EnumMember(Value = "array")]
        Array
    }

    internal sealed class SchemaTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => false;

        public override bool CanWrite => false;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => reader.TokenType switch
        {
            JsonToken.StartArray => serializer.Deserialize<List<StringEnumValue<SchemaType>>>(reader),
            JsonToken.String => new List<StringEnumValue<SchemaType>> { serializer.Deserialize<string>(reader) },
            _ => throw new InvalidOperationException($"Cannot handle token type of {reader.TokenType}"),
        };

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => throw new NotSupportedException();
    }
}
