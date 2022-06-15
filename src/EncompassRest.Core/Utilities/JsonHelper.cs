using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        internal static readonly JsonSerializer DefaultDirtySerializer = new JsonSerializer { ContractResolver = InternalPrivateContractResolver, ObjectCreationHandling = ObjectCreationHandling.Replace, Formatting = Formatting.None };
        internal static readonly JsonSerializer DefaultIndentedDirtySerializer = new JsonSerializer { ContractResolver = InternalPrivateContractResolver, Formatting = Formatting.Indented };
        internal static readonly Encoding Utf8NoBOM = new UTF8Encoding(false);

        public static JsonSerializer CreatePublicSerializer(JsonSerializer existingSerializer)
        {
            var publicSerializer = new JsonSerializer
            {
                SerializationBinder = existingSerializer.SerializationBinder,
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
                TypeNameAssemblyFormatHandling = existingSerializer.TypeNameAssemblyFormatHandling,
                TypeNameHandling = existingSerializer.TypeNameHandling
            };
            foreach (var converter in existingSerializer.Converters)
            {
                publicSerializer.Converters.Add(converter);
            }
            return publicSerializer;
        }

        public static T FromJson<T>(string json) => (T)FromJson(json, TypeData<T>.Type);

        public static object FromJson(string json) => FromJson(json, null);

        public static object FromJson(string json, Type? type)
        {
            using (var reader = new StringReader(json))
            {
                return FromJson(reader, type);
            }
        }

        public static T FromJson<T>(TextReader reader) => (T)FromJson(reader, TypeData<T>.Type);

        public static object FromJson(TextReader reader) => FromJson(reader, null);

        public static object FromJson(TextReader reader, Type? type) => DefaultDirtySerializer.Deserialize(reader, type!)!;

        public static void PopulateFromJson(string json, object target)
        {
            using (var reader = new StringReader(json))
            {
                PopulateFromJson(reader, target);
            }
        }

        public static void PopulateFromJson(TextReader reader, object target)
        {
            Preconditions.NotNull(target, nameof(target));

            var type = target.GetType();
            using (var jReader = new JsonTextReader(reader))
            {
                var jToken = DefaultDirtySerializer.Deserialize<JToken>(jReader)!;
                var source = jToken.ToObject(type, DefaultDirtySerializer)!;

                var contract = InternalPrivateContractResolver.ResolveContract(type);
                switch (contract)
                {
                    case JsonObjectContract objectContract:
                        PopulateObject((JObject)jToken, objectContract, (ExtensibleObject)source, (ExtensibleObject)target);
                        break;
                    case JsonDictionaryContract dictionaryContract:
                        PopulateDictionary((JObject)jToken, dictionaryContract, (IDictionary)source, (IDictionary)target);
                        break;
                    case JsonArrayContract arrayContract:
                        PopulateArray((JArray)jToken, arrayContract, (IList)source, (IList)target);
                        break;
                    default:
                        throw new InvalidOperationException($"Invalid type for population");
                }
            }
        }

        private static void PopulateObject(JObject jObject, JsonObjectContract objectContract, ExtensibleObject source, ExtensibleObject target)
        {
            var targetExtensionData = target.ExtensionData;
            foreach (var jProperty in jObject.Properties())
            {
                var property = objectContract.Properties.GetClosestMatchProperty(jProperty.Name);
                if (property == null)
                {
                    targetExtensionData[jProperty.Name] = jProperty.Value;
                }
                else
                {
                    var propertyValueProvider = property.ValueProvider!;
                    object? targetValue;
                    object? sourceValue;
                    if (source is DirtyExtensibleObject dirtySource && target is DirtyExtensibleObject dirtyTarget)
                    {
                        var underlyingName = property.UnderlyingName!;

                        targetValue = dirtyTarget.Properties.TryGetValue(underlyingName, out var v) ? (v is IValue tv ? tv.Value : v) : null;
                        sourceValue = dirtySource.Properties.TryGetValue(underlyingName, out v) ? (v is IValue sv ? sv.Value : v) : null;
                    }
                    else
                    {
                        targetValue = propertyValueProvider.GetValue(target);
                        sourceValue = propertyValueProvider.GetValue(source);
                    }
                    var value = jProperty.Value;
                    var setValue = true;
                    if (targetValue != null && sourceValue != null && !(value is JValue))
                    {
                        var propertyContract = InternalPrivateContractResolver.ResolveContract(property.PropertyType!);
                        switch (propertyContract)
                        {
                            case JsonObjectContract propertyObjectContract:
                                PopulateObject((JObject)value, propertyObjectContract, (ExtensibleObject)sourceValue, (ExtensibleObject)targetValue);
                                setValue = false;
                                break;
                            case JsonDictionaryContract dictionaryContract:
                                PopulateDictionary((JObject)value, dictionaryContract, (IDictionary)sourceValue, (IDictionary)targetValue);
                                setValue = false;
                                break;
                            case JsonArrayContract arrayContract:
                                PopulateArray((JArray)value, arrayContract, (IList)sourceValue, (IList)targetValue);
                                setValue = false;
                                break;
                        }
                    }
                    if (setValue)
                    {
                        propertyValueProvider.SetValue(target, sourceValue);
                    }
                }
            }
        }

        private static void PopulateDictionary(JObject jObject, JsonDictionaryContract dictionaryContract, IDictionary source, IDictionary target)
        {
            var valueContract = InternalPrivateContractResolver.ResolveContract(dictionaryContract.DictionaryValueType!);
            foreach (DictionaryEntry entry in source)
            {
                var key = entry.Key;
                var value = entry.Value;
                var setValue = true;
                if (value != null && target.Contains(key))
                {
                    var existingValue = target[key];
                    if (existingValue != null)
                    {
                        var jToken = jObject[key]!;
                        switch (valueContract)
                        {
                            case JsonObjectContract objectContract:
                                PopulateObject((JObject)jToken, objectContract, (ExtensibleObject)value, (ExtensibleObject)existingValue);
                                setValue = false;
                                break;
                            case JsonDictionaryContract jsonDictionaryContract:
                                PopulateDictionary((JObject)jToken, jsonDictionaryContract, (IDictionary)value, (IDictionary)existingValue);
                                setValue = false;
                                break;
                            case JsonArrayContract arrayContract:
                                PopulateArray((JArray)jToken, arrayContract, (IList)value, (IList)existingValue);
                                setValue = false;
                                break;
                        }
                    }
                }
                if (setValue)
                {
                    target[key] = value;
                }
            }
            var entriesToDelete = new List<DictionaryEntry>();
            foreach (DictionaryEntry entry in target)
            {
                if (!source.Contains(entry.Key))
                {
                    entriesToDelete.Add(entry);
                }
            }
            foreach (var entryToDelete in entriesToDelete)
            {
                target.Remove(entryToDelete.Key);
                if (entryToDelete.Value is DirtyExtensibleObject dirtyExtensibleObject)
                {
                    dirtyExtensibleObject.ClearPropertyChangedEvent();
                    dirtyExtensibleObject.ClearPropertyChangingEvent();
                }
            }
        }
        
        private static void PopulateArray(JArray jArray, JsonArrayContract arrayContract, IList source, IList target)
        {
            if (target.Count > 0 && target is IEnumerable<DirtyExtensibleObject> targetEnumerable)
            {
                var objectContract = (JsonObjectContract)InternalPrivateContractResolver.ResolveContract(arrayContract.CollectionItemType!);
                var sourceEnumerable = (IEnumerable<DirtyExtensibleObject>)source;
                for (var i = target.Count - 1; i >= 0; --i)
                {
                    var targetItem = (DirtyExtensibleObject?)target[i];
                    var id = ((IIdentifiable?)targetItem)?.Id;
                    if (!string.IsNullOrEmpty(id) && Extensions.IndexOf(sourceEnumerable, id!) < 0)
                    {
                        target.RemoveAt(i);
                        targetItem!.ClearPropertyChangedEvent();
                        targetItem.ClearPropertyChangingEvent();
                    }
                }
                for (var i = 0; i < source.Count; ++i)
                {
                    var sourceItem = (DirtyExtensibleObject?)source[i];
                    if (i == target.Count)
                    {
                        target.Add(sourceItem);
                    }
                    else
                    {
                        DirtyExtensibleObject? existing;
                        var id = ((IIdentifiable?)sourceItem)?.Id;
                        int index;
                        if (!string.IsNullOrEmpty(id) && (index = Extensions.IndexOf(targetEnumerable, id!)) >= i)
                        {
                            existing = (DirtyExtensibleObject)target[index];
                            for (var j = i; j < index; ++j)
                            {
                                target[j + 1] = target[j];
                            }
                            target[i] = existing;
                        }
                        else
                        {
                            existing = (DirtyExtensibleObject)target[i];
                            if (!string.IsNullOrEmpty(((IIdentifiable)existing)?.Id))
                            {
                                target.Insert(i, sourceItem);
                                existing = null;
                            }
                        }
                        if (existing != null)
                        {
                            PopulateObject((JObject)jArray[i], objectContract, sourceItem!, existing);
                        }
                    }
                }
                for (var i = target.Count - 1; i >= source.Count; --i)
                {
                    var targetItem = (DirtyExtensibleObject)target[i];
                    target.RemoveAt(i);
                    targetItem.ClearPropertyChangedEvent();
                    targetItem.ClearPropertyChangingEvent();
                }
            }
            else
            {
                target.Clear();
                foreach (var item in source)
                {
                    target.Add(item);
                }
            }
        }

        public static string ToJson<T>(this T value) => ToJson(value, TypeData<T>.Type);

        public static string ToJson(object? value) => ToJson(value, (Type?)null);

        public static string ToJson(object? value, Type? type)
        {
            using (var writer = new StringWriter(new StringBuilder(256), CultureInfo.InvariantCulture))
            {
                ToJson(value, type, writer);
                return writer.ToString();
            }
        }

        public static void ToJson<T>(T value, TextWriter writer) => ToJson(value, TypeData<T>.Type, writer);

        public static void ToJson(object? value, TextWriter writer) => ToJson(value, null, writer);

        public static void ToJson(object? value, Type? type, TextWriter writer) => DefaultDirtySerializer.Serialize(writer, value, type!);

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
                    return (T)jsonSerializer.Deserialize(sr, objectType!)!;
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

            public CustomContractResolver()
            {
                NamingStrategy = CamelCaseNamingStrategy;
            }

            protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
            {
                var property = base.CreateProperty(member, memberSerialization);
                if (member is PropertyInfo propertyInfo)
                {
                    var enumFormatAttribute = (EnumFormatAttribute)property.AttributeProvider!.GetAttributes(TypeData<EnumFormatAttribute>.Type, false).FirstOrDefault();
                    if (enumFormatAttribute != null)
                    {
                        property.Converter = new EnumJsonConverter(enumFormatAttribute.EnumFormat);
                    }
                    PopulateShouldSerializeMethod(property, propertyInfo);
                }
                return property;
            }

            protected abstract void PopulateShouldSerializeMethod(JsonProperty property, PropertyInfo propertyInfo);

            protected override JsonConverter? ResolveContractConverter(Type objectType)
            {
                var typeData = TypeData.Get(objectType);
                if (typeData.IsEnum || typeData.NonNullableValueTypeData?.IsEnum == true)
                {
                    var enumFormatAttribute = (typeData.NonNullableValueTypeData?.Type ?? objectType).GetCustomAttribute<EnumFormatAttribute>();
                    if (enumFormatAttribute != null)
                    {
                        return new EnumJsonConverter(enumFormatAttribute.EnumFormat);
                    }
                    else
                    {
                        return DefaultEnumConverter;
                    }
                }
                var jsonConverterAttribute = objectType.GetCustomAttribute<JsonConverterAttribute>(true);
                if (jsonConverterAttribute != null)
                {
                    var converterType = jsonConverterAttribute.ConverterType;
                    if (converterType == TypeData<PublicallySerializableConverter>.Type)
                    {
                        return null;
                    }
                    if (objectType.IsGenericType && !objectType.IsGenericTypeDefinition && converterType.IsGenericTypeDefinition)
                    {
                        return (JsonConverter)Activator.CreateInstance(jsonConverterAttribute.ConverterType.MakeGenericType(objectType.GenericTypeArguments), jsonConverterAttribute.ConverterParameters);
                    }
                }
                return base.ResolveContractConverter(objectType);
            }

            protected override IValueProvider CreateMemberValueProvider(MemberInfo member)
            {
                var valueProvider = base.CreateMemberValueProvider(member);
                if (member is PropertyInfo propertyInfo)
                {
                    var propertyType = propertyInfo.PropertyType;
                    if (propertyType == TypeData<StringDecimalValue>.Type)
                    {
                        var propertyContract = ResolveContract(propertyType);
                        valueProvider = new StringValueProvider(valueProvider, (IStringCreator)propertyContract.Converter!, propertyType);
                    }
                    else
                    {
                        if (propertyType.IsGenericType && !propertyType.IsGenericTypeDefinition)
                        {
                            var genericTypeDefinition = propertyType.GetGenericTypeDefinition();
                            if (genericTypeDefinition == TypeData.OpenStringEnumValueType || genericTypeDefinition == TypeData.OpenNaType)
                            {
                                var propertyContract = ResolveContract(propertyType);
                                valueProvider = new StringValueProvider(valueProvider, (IStringCreator)propertyContract.Converter!, propertyType);
                            }
                        }
                    }
                }
                return valueProvider;
            }

            // Required for proper serialization of StringEnumValue, NA, and StringDecimalValue
            private class StringValueProvider : IValueProvider
            {
                private readonly IValueProvider _valueProvider;
                private readonly IStringCreator _stringCreator;
                private readonly Type _type;

                public StringValueProvider(IValueProvider valueProvider, IStringCreator stringCreator, Type type)
                {
                    _valueProvider = valueProvider;
                    _stringCreator = stringCreator;
                    _type = type;
                }

                public object GetValue(object target) => _valueProvider.GetValue(target)!.ToString();

                public void SetValue(object target, object? value)
                {
                    var str = value as string;
                    _valueProvider.SetValue(target, str is not null || value is null ? _stringCreator.Create(_type, str) : value);
                }
            }
        }

        private sealed class PublicContractResolver : CustomContractResolver
        {
            protected override void PopulateShouldSerializeMethod(JsonProperty property, PropertyInfo propertyInfo)
            {
                if (TypeData<DirtyExtensibleObject>.Type.IsAssignableFrom(property.DeclaringType))
                {
                    property.ShouldSerialize = o => ((DirtyExtensibleObject)o).Properties.ContainsKey(propertyInfo.Name);
                }
            }

            protected override JsonConverter? ResolveContractConverter(Type objectType)
            {
                if (objectType.IsGenericType && !objectType.IsGenericTypeDefinition)
                {
                    var genericTypeDefinition = objectType.GetGenericTypeDefinition();
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
                if (TypeData<ExtensibleObject>.Type.IsAssignableFrom(objectType))
                {
                    contract.ExtensionDataGetter = o => ((DirtyDictionary<string, object?>)((ExtensibleObject)o).ExtensionData).GetDirtyItems().Select(p => KeyValuePair.Create((object)p.Key, p.Value!));
                    contract.ExtensionDataSetter = (o, k, v) => ((ExtensibleObject)o).ExtensionData[k] = v;
                    if (TypeData<DirtyExtensibleObject>.Type.IsAssignableFrom(objectType))
                    {
                        var idPropertyName = DirtyExtensibleObject.GetIdPropertyName(objectType);
                        idPropertyName = CamelCaseNamingStrategy.GetPropertyName(idPropertyName, false);
                        var idProperty = contract.Properties.GetClosestMatchProperty(idPropertyName);
                        if (idProperty != null && idProperty.DeclaringType!.GetProperty(idProperty.UnderlyingName).GetCustomAttribute<NeverSerializeAttribute>() == null)
                        {
                            idProperty.ShouldSerialize = o => ((IIdentifiable)o).Id != null;
                        }

                        ReadEntityAttributes(objectType, contract);
                    }
                }
                return contract;
            }

            private static void ReadEntityAttributes(Type objectType, JsonObjectContract contract)
            {
                var baseType = objectType.BaseType;
                if (baseType != null)
                {
                    ReadEntityAttributes(baseType, contract);
                }
                var entityAttribute = objectType.GetCustomAttribute<EntityAttribute>(false);
                if (entityAttribute != null && !string.IsNullOrEmpty(entityAttribute.PropertiesToAlwaysSerialize))
                {
                    var propertiesToAlwaysSerialize = entityAttribute.PropertiesToAlwaysSerialize!.Split(',');
                    foreach (var propertyToAlwaysSerialize in propertiesToAlwaysSerialize)
                    {
                        var property = contract.Properties.GetClosestMatchProperty(propertyToAlwaysSerialize)!;
                        var valueProvider = property.ValueProvider!;
                        property.ShouldSerialize = o => valueProvider.GetValue(o) != null;
                    }
                }
            }

            protected override void PopulateShouldSerializeMethod(JsonProperty property, PropertyInfo propertyInfo)
            {
                if (TypeData<DirtyExtensibleObject>.Type.IsAssignableFrom(property.DeclaringType))
                {
                    if (propertyInfo.GetCustomAttribute<NeverSerializeAttribute>() != null)
                    {
                        property.ShouldSerialize = o => false;
                    }
                    else
                    {
                        property.ShouldSerialize = o => ((DirtyExtensibleObject)o).Properties.TryGetValue(propertyInfo.Name, out var value) && value.Dirty;
                    }
                }
            }
        }
    }
}