using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Utilities
{
    internal static class JsonHelper
    {
        private static readonly JsonSerializer s_serializer = JsonSerializer.Create(DefaultSettings);

        public static JsonSerializerSettings DefaultSettings = new JsonSerializerSettings
        {
            Formatting = Formatting.None,
            ContractResolver = new CustomContractResolver()
        };

        public static T FromJson<T>(string json) => (T)FromJson(json, typeof(T));

        public static object FromJson(string json) => FromJson(json, null);

        public static object FromJson(string json, Type type)
        {
            using (var reader = new StringReader(json))
            {
                return FromJson(reader, type);
            }
        }

        public static T FromJson<T>(TextReader reader) => (T)FromJson(reader, typeof(T));

        public static object FromJson(TextReader reader) => FromJson(reader, null);

        public static object FromJson(TextReader reader, Type type) => s_serializer.Deserialize(reader, type);

        public static void PopulateFromJson(string json, object target)
        {
            using (var reader = new StringReader(json))
            {
                PopulateFromJson(reader, target);
            }
        }

        public static void PopulateFromJson(TextReader reader, object target) => s_serializer.Populate(reader, target);

        public static string ToJson<T>(this T value) => ToJson(value, typeof(T));

        public static string ToJson(object value) => ToJson(value, (Type)null);

        public static string ToJson(object value, Type type)
        {
            using (var writer = new StringWriter(new StringBuilder(256), CultureInfo.InvariantCulture))
            {
                ToJson(value, type, writer);
                return writer.ToString();
            }
        }

        public static void ToJson<T>(T value, TextWriter writer) => ToJson(value, typeof(T), writer);

        public static void ToJson(object value, TextWriter writer) => ToJson(value, null, writer);

        public static void ToJson(object value, Type type, TextWriter writer) => s_serializer.Serialize(writer, value, type);

        public static List<JToken> FindTokens(this JToken containerToken, string name)
        {
            var matches = new List<JToken>();
            FindTokens(containerToken, name, matches);
            return matches;
        }

        private static void FindTokens(JToken containerToken, string name, List<JToken> matches)
        {
            if (containerToken.Type == JTokenType.Object)
            {
                foreach (var child in containerToken.Children<JProperty>())
                {
                    if (child.Name == name)
                    {
                        matches.Add(child.Value);
                    }
                    FindTokens(child.Value, name, matches);
                }
            }
            else if (containerToken.Type == JTokenType.Array)
            {
                foreach (var child in containerToken.Children())
                {
                    FindTokens(child, name, matches);
                }
            }
        }

        public static async Task<T> ReadAsAsync<T>(this HttpContent content)
        {
            using (var stream = await content.ReadAsStreamAsync().ConfigureAwait(false))
            {
                using (var reader = new StreamReader(stream))
                {
                    return FromJson<T>(reader);
                }
            }
        }

        private sealed class CustomContractResolver : DefaultContractResolver
        {
            private static readonly StringEnumConverter s_enumConverter = new StringEnumConverter(true);

            public CustomContractResolver()
            {
                NamingStrategy = new CamelCaseNamingStrategy(processDictionaryKeys: true, overrideSpecifiedNames: false);
            }

            protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
            {
                var property = base.CreateProperty(member, memberSerialization);
                var propertyInfo = member as PropertyInfo;
                if (propertyInfo != null)
                {
                    if (propertyInfo.PropertyType.GetTypeInfo().ImplementedInterfaces.Contains(typeof(IClean)))
                    {
                        property.ShouldSerialize = o => o != null && ((IClean)propertyInfo.GetValue(o))?.Clean == false;
                    }
                    else
                    {
                        var propertyName = propertyInfo.Name;
                        var backingFieldName = $"_{char.ToLower(propertyName[0])}{propertyName.Substring(1)}";
                        var backingField = propertyInfo.DeclaringType.GetTypeInfo().DeclaredFields.FirstOrDefault(f => f.Name == backingFieldName && f.FieldType.GetTypeInfo().ImplementedInterfaces.Contains(typeof(IClean)));
                        if (backingField != null)
                        {
                            property.ShouldSerialize = o => o != null && ((IClean)backingField.GetValue(o))?.Clean == false;
                        }
                    }
                }
                return property;
            }

            protected override JsonConverter ResolveContractConverter(Type objectType)
            {
                var typeInfo = objectType.GetTypeInfo();
                if (typeInfo.IsEnum)
                {
                    return s_enumConverter;
                }
                if (typeInfo.IsGenericType && !typeInfo.IsGenericTypeDefinition)
                {
                    var jsonConverterAttribute = typeInfo.GetCustomAttribute<JsonConverterAttribute>();
                    if (jsonConverterAttribute != null && jsonConverterAttribute.ConverterType.GetTypeInfo().IsGenericTypeDefinition)
                    {
                        return (JsonConverter)Activator.CreateInstance(jsonConverterAttribute.ConverterType.MakeGenericType(typeInfo.GenericTypeArguments), jsonConverterAttribute.ConverterParameters);
                    }
                }
                return base.ResolveContractConverter(objectType);
            }
        }
    }
}