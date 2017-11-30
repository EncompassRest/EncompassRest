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
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Utilities
{
    internal static class JsonHelper
    {
        private static readonly PublicContractResolver s_publicContractResolver = new PublicContractResolver();

        public static JsonSerializer CreatePublicSerializer(JsonSerializer existingSerializer)
        {
            var publicSerializer = new JsonSerializer
            {
                Binder = existingSerializer.Binder,
                CheckAdditionalContent = existingSerializer.CheckAdditionalContent,
                ConstructorHandling = existingSerializer.ConstructorHandling,
                Context = existingSerializer.Context,
                ContractResolver = s_publicContractResolver,
                Culture = existingSerializer.Culture,
                DateFormatHandling = existingSerializer.DateFormatHandling,
                DateFormatString = existingSerializer.DateFormatString,
                DateParseHandling = existingSerializer.DateParseHandling,
                DateTimeZoneHandling = existingSerializer.DateTimeZoneHandling,
                DefaultValueHandling = existingSerializer.DefaultValueHandling,
                EqualityComparer = existingSerializer.EqualityComparer,
                FloatFormatHandling = existingSerializer.FloatFormatHandling,
                FloatParseHandling = existingSerializer.FloatParseHandling,
                Formatting = existingSerializer.Formatting,
                MaxDepth = existingSerializer.MaxDepth,
                MetadataPropertyHandling = existingSerializer.MetadataPropertyHandling,
                MissingMemberHandling = existingSerializer.MissingMemberHandling,
                NullValueHandling = existingSerializer.NullValueHandling,
                ObjectCreationHandling = existingSerializer.ObjectCreationHandling,
                PreserveReferencesHandling = existingSerializer.PreserveReferencesHandling,
                ReferenceLoopHandling = existingSerializer.ReferenceLoopHandling,
                ReferenceResolver = existingSerializer.ReferenceResolver,
                StringEscapeHandling = existingSerializer.StringEscapeHandling,
                TraceWriter = existingSerializer.TraceWriter,
                TypeNameAssemblyFormat = existingSerializer.TypeNameAssemblyFormat,
                TypeNameHandling = existingSerializer.TypeNameHandling
            };
            foreach (var converter in existingSerializer.Converters)
            {
                publicSerializer.Converters.Add(converter);
            }
            return publicSerializer;
        }

        private static readonly JsonSerializer s_serializer = JsonSerializer.Create(new JsonSerializerSettings
        {
            Formatting = Formatting.None,
            ObjectCreationHandling = ObjectCreationHandling.Replace,
            ContractResolver = new PrivateContractResolver()
        });

        public static T FromJson<T>(string json) => (T)FromJson(json, TypeData<T>.Type);

        public static object FromJson(string json) => FromJson(json, null);

        public static object FromJson(string json, Type type)
        {
            using (var reader = new StringReader(json))
            {
                return FromJson(reader, type);
            }
        }

        public static T FromJson<T>(TextReader reader) => (T)FromJson(reader, TypeData<T>.Type);

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

        public static string ToJson<T>(this T value) => ToJson(value, TypeData<T>.Type);

        public static string ToJson(object value) => ToJson(value, (Type)null);

        public static string ToJson(object value, Type type)
        {
            using (var writer = new StringWriter(new StringBuilder(256), CultureInfo.InvariantCulture))
            {
                ToJson(value, type, writer);
                return writer.ToString();
            }
        }

        public static void ToJson<T>(T value, TextWriter writer) => ToJson(value, TypeData<T>.Type, writer);

        public static void ToJson(object value, TextWriter writer) => ToJson(value, null, writer);

        public static void ToJson(object value, Type type, TextWriter writer) => s_serializer.Serialize(writer, value, type);

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

        private abstract class CustomContractResolver : DefaultContractResolver
        {
            protected static readonly JsonConverter DefaultEnumConverter = new EnumJsonConverter(EnumJsonConverter.CamelCaseNameFormat);

            public CustomContractResolver()
            {
                NamingStrategy = new CamelCaseNamingStrategy(processDictionaryKeys: true, overrideSpecifiedNames: false);
            }

            protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
            {
                var property = base.CreateProperty(member, memberSerialization);
                if (member is PropertyInfo propertyInfo)
                {
                    var enumFormatAttribute = (EnumFormatAttribute)property.AttributeProvider.GetAttributes(TypeData<EnumFormatAttribute>.Type, false).FirstOrDefault();
                    if (enumFormatAttribute != null)
                    {
                        property.Converter = new EnumJsonConverter(enumFormatAttribute.EnumFormat);
                    }
                    PopulateShouldSerializeMethod(property, propertyInfo);
                }
                return property;
            }

            protected abstract void PopulateShouldSerializeMethod(JsonProperty property, PropertyInfo propertyInfo);

            protected override JsonConverter ResolveContractConverter(Type objectType)
            {
                var typeData = TypeData.Get(objectType);
                var typeInfo = typeData.TypeInfo;
                if (typeData.IsEnum || typeData.NonNullableValueTypeData?.IsEnum == true)
                {
                    var enumFormatAttribute = (typeData.NonNullableValueTypeData?.TypeInfo ?? typeInfo).GetCustomAttribute<EnumFormatAttribute>();
                    if (enumFormatAttribute != null)
                    {
                        return new EnumJsonConverter(enumFormatAttribute.EnumFormat);
                    }
                    else
                    {
                        return DefaultEnumConverter;
                    }
                }
                var jsonConverterAttribute = typeInfo.GetCustomAttribute<JsonConverterAttribute>(true);
                if (jsonConverterAttribute != null)
                {
                    var converterType = jsonConverterAttribute.ConverterType;
                    if (converterType == TypeData<PublicallySerializableConverter>.Type)
                    {
                        return null;
                    }
                    if (typeInfo.IsGenericType && !typeInfo.IsGenericTypeDefinition && converterType.GetTypeInfo().IsGenericTypeDefinition)
                    {
                        return (JsonConverter)Activator.CreateInstance(jsonConverterAttribute.ConverterType.MakeGenericType(typeInfo.GenericTypeArguments), jsonConverterAttribute.ConverterParameters);
                    }
                }
                return base.ResolveContractConverter(objectType);
            }
        }

        private sealed class PublicContractResolver : CustomContractResolver
        {
            protected override void PopulateShouldSerializeMethod(JsonProperty property, PropertyInfo propertyInfo)
            {
                var propertyName = propertyInfo.Name;
                var backingFieldName = $"_{char.ToLower(propertyName[0])}{propertyName.Substring(1)}";
                var backingField = propertyInfo.DeclaringType.GetTypeInfo().DeclaredFields.FirstOrDefault(f => f.Name == backingFieldName);
                if (backingField != null)
                {
                    var backingFieldValueProvider = base.CreateMemberValueProvider(backingField);
                    property.ShouldSerialize = o => backingFieldValueProvider.GetValue(o) != null;
                }
            }

            private static Type s_openStringEnumValueType = typeof(StringEnumValue<>);

            protected override IValueProvider CreateMemberValueProvider(MemberInfo member)
            {
                var valueProvider = base.CreateMemberValueProvider(member);
                if (member is PropertyInfo propertyInfo)
                {
                    var propertyTypeInfo = propertyInfo.PropertyType.GetTypeInfo();
                    if (propertyTypeInfo.IsGenericType && !propertyTypeInfo.IsGenericTypeDefinition && propertyTypeInfo.GetGenericTypeDefinition() == s_openStringEnumValueType)
                    {
                        valueProvider = new StringEnumValueProvider(valueProvider);
                    }
                }
                return valueProvider;
            }

            // Required for proper Public Serialization
            private class StringEnumValueProvider : IValueProvider
            {
                private readonly IValueProvider _valueProvider;

                public StringEnumValueProvider(IValueProvider valueProvider)
                {
                    _valueProvider = valueProvider;
                }

                public object GetValue(object target) => _valueProvider.GetValue(target).ToString();

                public void SetValue(object target, object value) => _valueProvider.SetValue(target, value);
            }
        }

        private sealed class PrivateContractResolver : CustomContractResolver
        {
            protected override JsonObjectContract CreateObjectContract(Type objectType)
            {
                var contract = base.CreateObjectContract(objectType);
                if (TypeData<ExtensibleObject>.TypeInfo.IsAssignableFrom(objectType.GetTypeInfo()))
                {
                    contract.ExtensionDataGetter = o => ((DirtyDictionary<string, object>)(((ExtensibleObject)o).ExtensionData)).GetDirtyItems().Select(p => new KeyValuePair<object, object>(p.Key, p.Value));
                    contract.ExtensionDataSetter = (o, k, v) => ((ExtensibleObject)o).ExtensionData[k] = v;
                }
                return contract;
            }

            protected override void PopulateShouldSerializeMethod(JsonProperty property, PropertyInfo propertyInfo)
            {
                var toAssignShouldSerializeMethod = true;
                var propertyName = propertyInfo.Name;
                if (propertyInfo.DeclaringType == TypeData<CustomField>.Type)
                {
                    if (propertyName == "Id")
                    {
                        property.ShouldSerialize = o => false;
                        toAssignShouldSerializeMethod = false;
                    }
                    else if (propertyName == "FieldName")
                    {
                        property.ShouldSerialize = o => true;
                        toAssignShouldSerializeMethod = false;
                    }
                }
                if (toAssignShouldSerializeMethod)
                {
                    if (propertyName == "Id")
                    {
                        property.ShouldSerialize = o => property.ValueProvider.GetValue(o) != null;
                    }
                    else
                    {
                        var backingFieldName = $"_{char.ToLower(propertyName[0])}{propertyName.Substring(1)}";
                        var backingField = propertyInfo.DeclaringType.GetTypeInfo().DeclaredFields.FirstOrDefault(f => f.Name == backingFieldName && f.FieldType.GetTypeInfo().ImplementedInterfaces.Contains(TypeData<IDirty>.Type));
                        if (backingField != null)
                        {
                            var backingFieldValueProvider = CreateMemberValueProvider(backingField);
                            property.ShouldSerialize = o => ((IDirty)backingFieldValueProvider.GetValue(o))?.Dirty == true;
                        }
                        else if (propertyInfo.PropertyType.GetTypeInfo().ImplementedInterfaces.Contains(TypeData<IDirty>.Type))
                        {
                            property.ShouldSerialize = o => ((IDirty)property.ValueProvider.GetValue(o))?.Dirty == true;
                        }
                    }
                }
            }
        }
    }
}