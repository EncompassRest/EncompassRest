using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Utilities
{
    internal static class JsonHelper
    {
        internal static readonly CamelCaseNamingStrategy CamelCaseNamingStrategy = new CamelCaseNamingStrategy(processDictionaryKeys: false, overrideSpecifiedNames: false);
        private static readonly PublicContractResolver s_publicContractResolver = new PublicContractResolver();
        internal static readonly CustomContractResolver InternalPrivateContractResolver = new PrivateContractResolver();
        internal static readonly JsonSerializer DefaultPublicSerializer = new JsonSerializer { ContractResolver = s_publicContractResolver, NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.None };
        internal static readonly JsonSerializer DefaultIndentedPublicSerializer = new JsonSerializer { ContractResolver = s_publicContractResolver, NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.Indented };
        internal static readonly Encoding Utf8NoBOM = new UTF8Encoding(false);

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
            ContractResolver = InternalPrivateContractResolver
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

        public static T Clone<T>(this JsonSerializer jsonSerializer, T value)
        {
            var objectType = value?.GetType();
            using (var ms = new MemoryStream())
            {
                using (var sw = new StreamWriter(ms, Utf8NoBOM, 4096, true))
                {
                    jsonSerializer.Serialize(sw, value);
                }
                ms.Position = 0;
                using (var sr = new StreamReader(ms))
                {
                    return (T)jsonSerializer.Deserialize(sr, objectType);
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

        internal abstract class CustomContractResolver : DefaultContractResolver
        {
            protected static readonly JsonConverter DefaultEnumConverter = new EnumJsonConverter(EnumJsonConverter.CamelCaseNameFormat);

            private static readonly ConcurrentDictionary<Type, ConcurrentDictionary<string, BackingFieldInfo>> s_backingFieldProviders = new ConcurrentDictionary<Type, ConcurrentDictionary<string, BackingFieldInfo>>();

            public CustomContractResolver()
            {
                NamingStrategy = CamelCaseNamingStrategy;
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

            protected override IValueProvider CreateMemberValueProvider(MemberInfo member)
            {
                var valueProvider = base.CreateMemberValueProvider(member);
                if (member is PropertyInfo propertyInfo)
                {
                    var propertyTypeInfo = propertyInfo.PropertyType.GetTypeInfo();
                    if (propertyTypeInfo.IsGenericType && !propertyTypeInfo.IsGenericTypeDefinition)
                    {
                        var genericTypeDefinition = propertyTypeInfo.GetGenericTypeDefinition();
                        if (genericTypeDefinition == TypeData.OpenStringEnumValueType || genericTypeDefinition == TypeData.OpenNaType)
                        {
                            valueProvider = new StringValueProvider(valueProvider);
                        }
                    }
                }
                return valueProvider;
            }

            internal BackingFieldInfo GetBackingFieldInfo(Type type, string propertyName)
            {
                var propertyBackingFields = s_backingFieldProviders.GetOrAdd(type, t => new ConcurrentDictionary<string, BackingFieldInfo>());
                return propertyBackingFields.GetOrAdd(propertyName, n =>
                {
                    var backingFieldName = $"_{char.ToLower(n[0])}{n.Substring(1)}";
                    var backingField = type.GetTypeInfo().DeclaredFields.FirstOrDefault(f => f.Name == backingFieldName);
                    return backingField != null ? new BackingFieldInfo(base.CreateMemberValueProvider(backingField), backingField) : null;
                });
            }

            // Required for proper serialization of StringEnumValue and NA
            private class StringValueProvider : IValueProvider
            {
                private readonly IValueProvider _valueProvider;

                public StringValueProvider(IValueProvider valueProvider)
                {
                    _valueProvider = valueProvider;
                }

                public object GetValue(object target) => _valueProvider.GetValue(target).ToString();

                public void SetValue(object target, object value) => _valueProvider.SetValue(target, value);
            }
        }

        internal class BackingFieldInfo
        {
            public IValueProvider ValueProvider { get; }

            public FieldInfo FieldInfo { get; }
            
            public BackingFieldInfo(IValueProvider valueProvider, FieldInfo fieldInfo)
            {
                ValueProvider = valueProvider;
                FieldInfo = fieldInfo;
            }
        }

        private sealed class PublicContractResolver : CustomContractResolver
        {
            protected override void PopulateShouldSerializeMethod(JsonProperty property, PropertyInfo propertyInfo)
            {
                var valueProvider = GetBackingFieldInfo(propertyInfo.DeclaringType, propertyInfo.Name)?.ValueProvider;
                if (valueProvider != null)
                {
                    property.ShouldSerialize = o => valueProvider.GetValue(o) != null;
                }
            }

            protected override JsonConverter ResolveContractConverter(Type objectType)
            {
                var typeData = TypeData.Get(objectType);
                var typeInfo = typeData.TypeInfo;
                if (typeInfo.IsGenericType && !typeInfo.IsGenericTypeDefinition)
                {
                    var genericTypeDefinition = typeInfo.GetGenericTypeDefinition();
                    if (genericTypeDefinition == TypeData.OpenDirtyListType || genericTypeDefinition == TypeData.OpenDirtyDictionaryType)
                    {
                        return null;
                    }
                }
                return base.ResolveContractConverter(objectType);
            }
        }

        private sealed class PrivateContractResolver : CustomContractResolver
        {
            protected override JsonObjectContract CreateObjectContract(Type objectType)
            {
                var contract = base.CreateObjectContract(objectType);
                var objectTypeInfo = objectType.GetTypeInfo();
                if (TypeData<ExtensibleObject>.TypeInfo.IsAssignableFrom(objectTypeInfo))
                {
                    contract.ExtensionDataGetter = o => ((DirtyDictionary<string, object>)(((ExtensibleObject)o).ExtensionData)).GetDirtyItems().Select(p => new KeyValuePair<object, object>(p.Key, p.Value));
                    contract.ExtensionDataSetter = (o, k, v) => ((ExtensibleObject)o).ExtensionData[k] = v;
                    var idPropertyName = ExtensibleObject.GetIdPropertyName(objectTypeInfo);
                    idPropertyName = CamelCaseNamingStrategy.GetPropertyName(idPropertyName, false);
                    var property = contract.Properties.GetClosestMatchProperty(idPropertyName);
                    if (property != null)
                    {
                        property.ShouldSerialize = o => ((IIdentifiable)o).Id != null;
                    }

                    var entityAttribute = objectTypeInfo.GetCustomAttribute<EntityAttribute>(false);
                    if (entityAttribute != null && !string.IsNullOrEmpty(entityAttribute.PropertiesToAlwaysSerialize))
                    {
                        var propertiesToAlwaysSerialize = entityAttribute.PropertiesToAlwaysSerialize.Split(',');
                        foreach (var propertyToAlwaysSerialize in propertiesToAlwaysSerialize)
                        {
                            property = contract.Properties.GetClosestMatchProperty(propertyToAlwaysSerialize);
                            var valueProvider = property.ValueProvider;
                            property.ShouldSerialize = o => valueProvider.GetValue(o) != null;
                        }
                    }
                }
                return contract;
            }

            protected override void PopulateShouldSerializeMethod(JsonProperty property, PropertyInfo propertyInfo)
            {
                var backingFieldInfo = GetBackingFieldInfo(propertyInfo.DeclaringType, propertyInfo.Name);
                IValueProvider valueProvider = null;
                if (backingFieldInfo != null && backingFieldInfo.FieldInfo.FieldType.GetTypeInfo().ImplementedInterfaces.Any(t => t == TypeData<IDirty>.Type))
                {
                    valueProvider = backingFieldInfo.ValueProvider;
                }
                else if (property.PropertyType.GetTypeInfo().ImplementedInterfaces.Any(t => t == TypeData<IDirty>.Type))
                {
                    valueProvider = property.ValueProvider;
                }
                if (valueProvider != null)
                {
                    property.ShouldSerialize = o => ((IDirty)valueProvider.GetValue(o))?.Dirty == true;
                }
            }
        }
    }
}