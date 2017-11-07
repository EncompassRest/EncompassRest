using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EncompassRest.Loans;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Utilities
{
    internal static class JsonHelper
    {
        private static readonly JsonSerializer s_serializer = JsonSerializer.Create(new JsonSerializerSettings
        {
            Formatting = Formatting.None,
            ObjectCreationHandling = ObjectCreationHandling.Replace,
            ContractResolver = new CustomContractResolver()
        });

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

        public static async Task PopulateAsync(this HttpContent content, object target)
        {
            using (var stream = await content.ReadAsStreamAsync().ConfigureAwait(false))
            {
                using (var reader = new StreamReader(stream))
                {
                    PopulateFromJson(reader, target);
                }
            }
        }

        private sealed class CustomContractResolver : DefaultContractResolver
        {
            private static readonly JsonConverter s_enumConverter = new EnumJsonConverter(EnumOutput.CamelCaseName);

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
                    var enumOutputAttribute = propertyInfo.GetCustomAttribute<EnumOutputAttribute>(false);
                    if (enumOutputAttribute != null)
                    {
                        property.Converter = new EnumJsonConverter(enumOutputAttribute.EnumOutput);
                    }
                    var toAssignShouldSerializeMethod = true;
                    if (member.DeclaringType == TypeData<CustomField>.Type)
                    {
                        if (propertyInfo.Name == "Id")
                        {
                            property.ShouldSerialize = o => false;
                            toAssignShouldSerializeMethod = false;
                        }
                        else if (propertyInfo.Name == "FieldName")
                        {
                            property.ShouldSerialize = o => true;
                            toAssignShouldSerializeMethod = false;
                        }
                    }
                    if (toAssignShouldSerializeMethod)
                    {
                        var propertyName = propertyInfo.Name;
                        if (propertyName == "Id")
                        {
                            property.ShouldSerialize = o => propertyInfo.GetValue(o) != null;
                        }
                        else
                        {
                            var backingFieldName = $"_{char.ToLower(propertyName[0])}{propertyName.Substring(1)}";
                            var backingField = propertyInfo.DeclaringType.GetTypeInfo().DeclaredFields.FirstOrDefault(f => f.Name == backingFieldName && f.FieldType.GetTypeInfo().ImplementedInterfaces.Contains(typeof(IDirty)));
                            if (backingField != null)
                            {
                                property.ShouldSerialize = o => ((IDirty)backingField.GetValue(o))?.Dirty == true;
                            }
                            else if (propertyInfo.PropertyType.GetTypeInfo().ImplementedInterfaces.Contains(typeof(IDirty)))
                            {
                                property.ShouldSerialize = o => ((IDirty)propertyInfo.GetValue(o))?.Dirty == true;
                            }
                        }
                    }
                }
                return property;
            }

            protected override JsonConverter ResolveContractConverter(Type objectType)
            {
                var typeData = TypeData.Get(objectType);
                if (typeData.IsEnum || typeData.NonNullableValueTypeData?.IsEnum == true)
                {
                    var enumOutputAttribute = typeData.TypeInfo.GetCustomAttribute<EnumOutputAttribute>();
                    if (enumOutputAttribute != null)
                    {
                        return new EnumJsonConverter(enumOutputAttribute.EnumOutput);
                    }
                    else
                    {
                        return s_enumConverter;
                    }
                }
                if (typeData.TypeInfo.IsGenericType && !typeData.TypeInfo.IsGenericTypeDefinition)
                {
                    var jsonConverterAttribute = typeData.TypeInfo.GetCustomAttribute<JsonConverterAttribute>();
                    if (jsonConverterAttribute != null && jsonConverterAttribute.ConverterType.GetTypeInfo().IsGenericTypeDefinition)
                    {
                        return (JsonConverter)Activator.CreateInstance(jsonConverterAttribute.ConverterType.MakeGenericType(typeData.TypeInfo.GenericTypeArguments), jsonConverterAttribute.ConverterParameters);
                    }
                }
                return base.ResolveContractConverter(objectType);
            }
        }
    }
}