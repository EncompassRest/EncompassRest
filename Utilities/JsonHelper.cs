using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Utilities
{
    internal static class JsonHelper
    {
        private static JsonSerializerSettings DefaultSettings { get; } = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            Formatting = Formatting.None,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy(processDictionaryKeys: true, overrideSpecifiedNames: false)
            },
            Converters = new JsonConverter[] { new StringEnumConverter(true) }
        };

        public static T FromJson<T>(string json) => (T)FromJson(json, typeof(T));

        public static object FromJson(string json) => FromJson(json, null);

        public static object FromJson(string json, Type type) => JsonConvert.DeserializeObject(json, type, DefaultSettings);

        public static T FromJson<T>(TextReader reader) => (T)FromJson(reader, typeof(T));

        public static object FromJson(TextReader reader) => FromJson(reader, null);

        public static object FromJson(TextReader reader, Type type) => JsonSerializer.Create(DefaultSettings).Deserialize(reader, type);

        public static string ToJson<T>(this T value) => ToJson(value, typeof(T));

        public static string ToJson(object value) => ToJson(value, (Type)null);

        public static string ToJson(object value, Type type) => JsonConvert.SerializeObject(value, type, DefaultSettings);

        public static void ToJson<T>(T value, TextWriter writer) => ToJson(value, typeof(T), writer);

        public static void ToJson(object value, TextWriter writer) => ToJson(value, null, writer);

        public static void ToJson(object value, Type type, TextWriter writer) => JsonSerializer.Create(DefaultSettings).Serialize(writer, value, type);
    }
}
