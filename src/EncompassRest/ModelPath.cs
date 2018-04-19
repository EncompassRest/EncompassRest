using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using EncompassRest.Utilities;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace EncompassRest
{
    internal sealed class ModelPath : IEquatable<ModelPath>
    {
        public ModelPathContext Context { get; }

        public string RootObjectName { get; }

        public IReadOnlyList<PathSegment> Segments { get; }

        internal ModelPath(ModelPathContext context, string modelPath)
        {
            Context = context;
            var segments = new List<PathSegment>();
            var i = 0;
            int start;
            while (i < modelPath.Length)
            {
                var c = modelPath[i];
                switch (c)
                {
                    case '[':
                        if (RootObjectName == null)
                        {
                            RootObjectName = modelPath.Substring(0, i);
                        }
                        Increment(ref i);
                        c = modelPath[i];
                        StringBuilder sb;
                        int? index;
                        string propertyName;
                        switch (c)
                        {
                            case '(':
                                Increment(ref i);
                                EatWhiteSpace(ref i);
                                sb = new StringBuilder();
                                c = modelPath[i];
                                ObjectFilter filter = null;
                                while (c != ')')
                                {
                                    switch (c)
                                    {
                                        case '\'':
                                            Increment(ref i);
                                            propertyName = GetPropertyName(ref i);
                                            if (string.IsNullOrEmpty(propertyName))
                                            {
                                                throw new ArgumentException("bad path");
                                            }
                                            Increment(ref i);
                                            break;
                                        default:
                                            var s = i;
                                            while (char.IsLetterOrDigit(c) || c == '_')
                                            {
                                                Increment(ref i);
                                                c = modelPath[i];
                                            }
                                            if (s == i)
                                            {
                                                throw new ArgumentException("bad path");
                                            }
                                            propertyName = modelPath.Substring(s, i - s);
                                            break;
                                    }
                                    EatWhiteSpace(ref i);
                                    if (modelPath[i] != '=')
                                    {
                                        throw new ArgumentException("bad path");
                                    }
                                    Increment(ref i);
                                    if (modelPath[i] != '=')
                                    {
                                        throw new ArgumentException("bad path");
                                    }
                                    Increment(ref i);
                                    EatWhiteSpace(ref i);

                                    string value;
                                    c = modelPath[i];
                                    switch (c)
                                    {
                                        case '\'':
                                            Increment(ref i);
                                            value = GetPropertyName(ref i);
                                            Increment(ref i);
                                            break;
                                        default:
                                            start = i;
                                            var integerValue = 0;
                                            while (char.IsDigit(c))
                                            {
                                                integerValue = integerValue * 10 + (c - '0');
                                                Increment(ref i);
                                                c = modelPath[i];
                                            }
                                            if (start == i)
                                            {
                                                throw new ArgumentException("only integers allowed in unescaped filter values");
                                            }
                                            value = integerValue.ToString();
                                            break;
                                    }
                                    var propertyFilter = new PropertyFilter(propertyName, value);
                                    EatWhiteSpace(ref i);
                                    c = modelPath[i];
                                    if (c == '&')
                                    {
                                        Increment(ref i);
                                        if (modelPath[i] != '&')
                                        {
                                            throw new ArgumentException("bad path");
                                        }
                                        Increment(ref i);
                                        EatWhiteSpace(ref i);
                                        if (modelPath[i] == ')')
                                        {
                                            throw new ArgumentException("bad path");
                                        }
                                    }
                                    filter = filter?.And(propertyFilter) ?? propertyFilter;
                                    c = modelPath[i];
                                }
                                if (filter == null)
                                {
                                    throw new ArgumentException("bad path");
                                }
                                Increment(ref i);
                                if (modelPath[i] != ']')
                                {
                                    throw new ArgumentException("bad path");
                                }
                                index = null;
                                if (i + 2 < modelPath.Length && modelPath[i + 1] == '[' && char.IsDigit(modelPath[i + 2]))
                                {
                                    i += 2;
                                    c = modelPath[i];
                                    index = 0;
                                    while (char.IsDigit(c))
                                    {
                                        index = index * 10 + (c - '0');
                                        Increment(ref i);
                                        c = modelPath[i];
                                    }
                                    if (c != ']')
                                    {
                                        throw new ArgumentException("only digits in non-filter brackets");
                                    }
                                }
                                segments.Add(new ArraySegment(this, filter, index));
                                break;
                            case ']':
                                throw new ArgumentException("no empty brackets");
                            case '\'':
                                Increment(ref i);
                                propertyName = GetPropertyName(ref i);
                                if (string.IsNullOrEmpty(propertyName))
                                {
                                    throw new ArgumentException("bad path");
                                }
                                segments.Add(new PropertySegment(this, propertyName));
                                Increment(ref i);
                                if (modelPath[i] != ']')
                                {
                                    throw new ArgumentException("bad path");
                                }
                                break;
                            default:
                                index = 0;
                                while (char.IsDigit(c))
                                {
                                    index = index * 10 + (c - '0');
                                    Increment(ref i);
                                    c = modelPath[i];
                                }
                                if (c != ']')
                                {
                                    throw new ArgumentException("only digits in non-filter brackets");
                                }
                                segments.Add(new ArraySegment(this, index.GetValueOrDefault()));
                                break;
                        }
                        break;
                    case '.':
                        if (RootObjectName == null)
                        {
                            RootObjectName = modelPath.Substring(0, i);
                        }
                        Increment(ref i);
                        start = i;
                        while (i < modelPath.Length && char.IsLetterOrDigit((c = modelPath[i])) || c == '_')
                        {
                            ++i;
                        }
                        if (i == start)
                        {
                            throw new ArgumentException("bad path");
                        }
                        segments.Add(new PropertySegment(this, modelPath.Substring(start, i - start)));
                        --i;
                        break;
                }
                ++i;
            }
            if (RootObjectName == null)
            {
                throw new ArgumentException("bad path");
            }
            Segments = segments.AsReadOnly();

            // Local functions
            void Increment(ref int value)
            {
                ++i;
                if (i >= modelPath.Length)
                {
                    throw new ArgumentException("bad path");
                }
            }

            string GetPropertyName(ref int value)
            {
                var sb = new StringBuilder();
                var c = modelPath[value];
                while (c != '\'')
                {
                    if (c == '\\')
                    {
                        ++value;
                        if (value >= modelPath.Length)
                        {
                            throw new ArgumentException("bad path");
                        }
                        c = modelPath[value];
                        if (c != '\\' && c != '\'')
                        {
                            throw new ArgumentException("bad escape character");
                        }
                        sb.Append(c);
                        break;
                    }
                    sb.Append(c);
                    ++value;
                    if (value >= modelPath.Length)
                    {
                        throw new ArgumentException("bad path");
                    }
                    c = modelPath[value];
                }
                return sb.ToString();
            }

            void EatWhiteSpace(ref int index, bool throwAtEnd = true)
            {
                while (index < modelPath.Length ? char.IsWhiteSpace(modelPath[index]) : (throwAtEnd ? throw new ArgumentException("bad path") : false))
                {
                    ++index;
                }
            }
        }

        public object GetValue(object root) => GetValue(root, out _);

        public object GetValue(object root, out Type declaredType)
        {
            Preconditions.NotNull(root, nameof(root));

            var value = root;
            declaredType = null;
            foreach (var segment in Segments)
            {
                value = segment.GetValue(value, out declaredType);
                if (value == null)
                {
                    return null;
                }
            }
            return value;
        }

        public void SetValue(object root, object value) => SetValue(root, t => value);

        public void SetValue(object root, Func<Type, object> valueProvider)
        {
            Preconditions.NotNull(root, nameof(root));
            Preconditions.NotNull(valueProvider, nameof(valueProvider));

            var parent = root;
            for (var i = 1; i < Segments.Count; ++i)
            {
                var segment = Segments[i - 1];
                parent = segment.GetValue(parent, out var declaredType, true, Segments[i] is PropertySegment);
            }
            Segments[Segments.Count - 1].SetValue(parent, valueProvider);
        }

        public Type GetDeclaredType(Type rootType)
        {
            var declaredType = rootType;
            foreach (var segment in Segments)
            {
                declaredType = segment.GetDeclaredType(declaredType);
                if (declaredType == null)
                {
                    return null;
                }
            }
            return declaredType;
        }

        public TAttribute GetAttribute<TAttribute>(Type rootType)
            where TAttribute : Attribute => GetAttributes<TAttribute>(rootType).FirstOrDefault();

        public IList<TAttribute> GetAttributes<TAttribute>(Type rootType)
            where TAttribute : Attribute
        {
            var attributes = GetAttributes(rootType, TypeData<TAttribute>.Type);
            return attributes.Cast<TAttribute>().ToList();
        }

        public IList<Attribute> GetAttributes(Type rootType) => GetAttributes(rootType, null);

        public IList<Attribute> GetAttributes(Type rootType, Type attributeType)
        {
            var lastSegment = Segments[Segments.Count - 1];
            if (lastSegment is PropertySegment propertySegment)
            {
                var declaredType = rootType;
                for (var i = 1; i < Segments.Count; ++i)
                {
                    var segment = Segments[i - 1];
                    declaredType = segment.GetDeclaredType(declaredType);
                    if (declaredType == null)
                    {
                        break;
                    }
                }
                if (declaredType != null)
                {
                    var contract = JsonHelper.InternalPrivateContractResolver.ResolveContract(declaredType);
                    if (contract is JsonObjectContract objectContract)
                    {
                        var propertyName = propertySegment.GetPropertyName();
                        var property = objectContract.Properties.GetClosestMatchProperty(propertyName);
                        if (property != null)
                        {
                            var attributeProvider = property.AttributeProvider;
                            return attributeType != null ? attributeProvider.GetAttributes(attributeType, false) : attributeProvider.GetAttributes(false);
                        }
                    }
                }
            }
            return new Attribute[0];
        }

        public override string ToString() => $"{RootObjectName}{string.Concat(Segments)}";

        public override int GetHashCode() => Segments.Aggregate(StringComparer.OrdinalIgnoreCase.GetHashCode(RootObjectName), (current, segment) => current ^ segment.GetHashCode());

        public override bool Equals(object obj) => Equals(obj as ModelPath);

        public bool Equals(ModelPath other)
        {
            if (other == null || !string.Equals(RootObjectName, other.RootObjectName, StringComparison.OrdinalIgnoreCase) || Segments.Count != other.Segments.Count)
            {
                return false;
            }
            for (var i = 0; i < Segments.Count; ++i)
            {
                if (!Segments[i].Equals(other.Segments[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private static string EscapeWithTick(string value, out bool escapeNeeded)
        {
            escapeNeeded = char.IsDigit(value[0]) || !value.All(c => char.IsLetterOrDigit(c) || c == '_');
            return escapeNeeded ? value.Replace("'", "\\'").Replace("\\", "\\\\") : value;
        }

        public abstract class PathSegment : IEquatable<PathSegment>
        {
            public ModelPath Path { get; }

            internal PathSegment(ModelPath path)
            {
                Path = path;
            }

            public abstract Type GetDeclaredType(Type parentType);

            public object GetValue(object parent) => GetValue(parent, out _);

            public abstract object GetValue(object parent, out Type declaredType, bool createIfNotExists = false, bool nextIsProperty = true);

            public void SetValue(object parent, object value) => SetValue(parent, t => value);

            public abstract void SetValue(object parent, Func<Type, object> valueProvider);

            public abstract override string ToString();

            public abstract override int GetHashCode();

            public sealed override bool Equals(object obj) => Equals(obj as PathSegment);

            public abstract bool Equals(PathSegment other);
        }

        public sealed class PropertySegment : PathSegment
        {
            public string PropertyName { get; }

            public PropertySegment(ModelPath path, string propertyName)
                : base(path)
            {
                Preconditions.NotNullOrEmpty(propertyName, nameof(propertyName));

                PropertyName = propertyName;
            }

            internal string GetPropertyName() => Path.Context.PropertyNameTransformer?.Invoke(PropertyName) ?? PropertyName;

            public override Type GetDeclaredType(Type parentType)
            {
                Preconditions.NotNull(parentType, nameof(parentType));

                var contract = JsonHelper.InternalPrivateContractResolver.ResolveContract(parentType);
                switch (contract)
                {
                    case JsonObjectContract objectContract:
                        var propertyName = GetPropertyName();
                        return objectContract.Properties.GetClosestMatchProperty(propertyName)?.PropertyType;
                    default:
                        return null;
                }
            }

            public override object GetValue(object parent, out Type declaredType, bool createIfNotExists = false, bool nextIsProperty = true)
            {
                Preconditions.NotNull(parent, nameof(parent));
                
                var contract = JsonHelper.InternalPrivateContractResolver.ResolveContract(parent.GetType());
                JToken tokenValue;
                object value;
                var propertyName = GetPropertyName();
                switch (contract)
                {
                    case JsonObjectContract objectContract:
                        var property = objectContract.Properties.GetClosestMatchProperty(propertyName);
                        if (property != null)
                        {
                            declaredType = property.PropertyType;
                            value = property.ValueProvider.GetValue(parent);
                            if (createIfNotExists && value == null)
                            {
                                var json = nextIsProperty ? "{}" : "[]";
                                value = JsonHelper.FromJson(json, declaredType);
                                property.ValueProvider.SetValue(parent, value);
                            }
                            return value;
                        }
                        else
                        {
                            var extensionData = objectContract.ExtensionDataGetter(parent);
                            if (extensionData != null)
                            {
                                foreach (var pair in extensionData)
                                {
                                    if (string.Equals(propertyName, pair.Key as string, StringComparison.OrdinalIgnoreCase))
                                    {
                                        declaredType = pair.Value?.GetType();
                                        return pair.Value;
                                    }
                                }

                                if (createIfNotExists)
                                {
                                    tokenValue = nextIsProperty ? new JObject() : (JToken)new JArray();
                                    objectContract.ExtensionDataSetter(parent, propertyName, tokenValue);
                                    declaredType = tokenValue.GetType();
                                    return tokenValue;
                                }
                            }
                        }
                        break;
                    case JsonLinqContract linqContract:
                        if (parent is JObject jObject)
                        {
                            if (jObject.TryGetValue(propertyName, StringComparison.OrdinalIgnoreCase, out tokenValue))
                            {
                                declaredType = tokenValue?.GetType();
                                return tokenValue;
                            }
                            else if (createIfNotExists)
                            {
                                tokenValue = nextIsProperty ? new JObject() : (JToken)new JArray();
                                jObject.Add(propertyName, tokenValue);
                                declaredType = tokenValue.GetType();
                                return tokenValue;
                            }
                        }
                        break;
                    case JsonDictionaryContract dictionaryContract:
                        if (parent is IDictionary dictionary)
                        {
                            declaredType = dictionaryContract.DictionaryValueType;
                            if (dictionary.Contains(propertyName))
                            {
                                return dictionary[propertyName];
                            }
                            else if (createIfNotExists)
                            {
                                var json = nextIsProperty ? "{}" : "[]";
                                value = JsonHelper.FromJson(json, declaredType);
                                dictionary[propertyName] = value;
                                return value;
                            }
                        }
                        break;
                }
                declaredType = null;
                return null;
            }

            public override void SetValue(object parent, Func<Type, object> valueProvider)
            {
                Preconditions.NotNull(parent, nameof(parent));

                var contract = JsonHelper.InternalPrivateContractResolver.ResolveContract(parent.GetType());
                object value;
                var propertyName = GetPropertyName();
                switch (contract)
                {
                    case JsonObjectContract objectContract:
                        var property = objectContract.Properties.GetClosestMatchProperty(propertyName);
                        if (property != null)
                        {
                            value = valueProvider(property.PropertyType);
                            property.ValueProvider.SetValue(parent, value);
                        }
                        else
                        {
                            value = valueProvider(null);
                            objectContract.ExtensionDataSetter?.Invoke(parent, propertyName, value);
                        }
                        break;
                    case JsonLinqContract linqContract:
                        if (parent is JObject jObject)
                        {
                            value = valueProvider(null);
                            jObject[propertyName] = value != null ? JToken.FromObject(value) : null;
                        }
                        break;
                    case JsonDictionaryContract dictionaryContract:
                        if (parent is IDictionary dictionary)
                        {
                            value = valueProvider(dictionaryContract.DictionaryValueType);
                            dictionary[propertyName] = value;
                        }
                        break;
                }
            }

            public override string ToString()
            {
                var escapedPropertyName = EscapeWithTick(PropertyName, out var escapeNeeded);
                return escapeNeeded ? $"['{escapedPropertyName}']" : $".{escapedPropertyName}";
            }

            public override int GetHashCode() => StringComparer.OrdinalIgnoreCase.GetHashCode(PropertyName);

            public override bool Equals(PathSegment other) => other is PropertySegment propertySegment && string.Equals(PropertyName, propertySegment.PropertyName, StringComparison.OrdinalIgnoreCase);
        }

        public sealed class ArraySegment : PathSegment
        {
            public int? Index { get; }

            public ObjectFilter Filter { get; }

            public ArraySegment(ModelPath path, int index)
                : this(path, null, index)
            {
            }

            public ArraySegment(ModelPath path, ObjectFilter filter, int? index = null)
                : base(path)
            {
                if (!index.HasValue && filter == null)
                {
                    throw new ArgumentException("index must have a value when not using a filter");
                }

                Index = index;
                Filter = filter;
            }

            public override Type GetDeclaredType(Type parentType)
            {
                var parentTypeInfo = parentType.GetTypeInfo();
                var declaredType = TypeData<JToken>.Type;
                foreach (var implementedInterface in parentTypeInfo.ImplementedInterfaces)
                {
                    var implementedInterfaceTypeInfo = implementedInterface.GetTypeInfo();
                    if (implementedInterfaceTypeInfo.IsGenericType && !implementedInterfaceTypeInfo.IsGenericTypeDefinition)
                    {
                        var genericTypeDefinition = implementedInterface.GetGenericTypeDefinition();
                        if (genericTypeDefinition == TypeData.OpenIEnumerableType)
                        {
                            declaredType = implementedInterfaceTypeInfo.GenericTypeArguments[0];
                        }
                    }
                }
                return declaredType;
            }

            public override object GetValue(object parent, out Type declaredType, bool createIfNotExists = false, bool nextIsProperty = true)
            {
                Preconditions.NotNull(parent, nameof(parent));
                if (!(parent is IList list))
                {
                    throw new ArgumentException("must be an IList", nameof(parent));
                }

                declaredType = GetDeclaredType(parent.GetType());

                Path.Context.Settings.TryGetValue(GetPropertyPath(), out var settings);

                var propertyNameTransformer = Path.Context.PropertyNameTransformer;

                var filteredList = list;
                if (Filter != null)
                {
                    filteredList = new List<object>();
                    foreach (var item in list)
                    {
                        if (Filter.Evaluate(item, settings, propertyNameTransformer))
                        {
                            filteredList.Add(item);
                        }
                    }
                }

                var indexOffset = settings?.IndexOffset ?? Path.Context.DefaultIndexOffset;

                var index = (Index ?? indexOffset) - indexOffset;
                if (index < filteredList.Count)
                {
                    return filteredList[index];
                }
                else if (createIfNotExists)
                {
                    var json = "{}";
                    if (Filter != null)
                    {
                        var sb = new StringBuilder();
                        sb.Append('{');
                        foreach (var propertyFilter in Filter)
                        {
                            var propertyName = Path.Context.PropertyNameTransformer?.Invoke(propertyFilter.PropertyName) ?? propertyFilter.PropertyName;
                            sb.Append('"').Append(propertyName).Append(@""":");
                            sb.Append('"').Append(propertyFilter.Value).Append(@""",");
                        }
                        --sb.Length;
                        sb.Append('}');
                        json = sb.ToString();
                    }
                    object result = null;
                    for (var i = filteredList.Count; i <= index; ++i)
                    {
                        result = JsonHelper.FromJson(json, declaredType);
                        list.Add(result);
                    }
                    return result;
                }
                return null;
            }

            private string GetPropertyPath()
            {
                var sb = new StringBuilder();
                sb.Append(Path.RootObjectName).Append('.');
                foreach (var segment in Path.Segments)
                {
                    if (segment is PropertySegment propertySegment)
                    {
                        sb.Append(propertySegment.PropertyName).Append('.');
                    }
                    else if (ReferenceEquals(segment, this))
                    {
                        break;
                    }
                }
                --sb.Length;
                return sb.ToString();
            }

            public override void SetValue(object parent, Func<Type, object> valueProvider) => throw new NotSupportedException();

            public override string ToString() => $"{(Filter != null ? $"[({Filter})]" : string.Empty)}{(Index.HasValue ? $"[{Index}]" : string.Empty)}";

            public override int GetHashCode()
            {
                var propertyPath = GetPropertyPath();
                Path.Context.Settings.TryGetValue(propertyPath, out var settings);
                var propertyFilters = CreatePropertyFilterListWithDefaults(settings?.DefaultValues);
                return propertyFilters.Aggregate(Index ?? settings?.IndexOffset ?? Path.Context.DefaultIndexOffset, (current, f) => current ^ StringComparer.OrdinalIgnoreCase.GetHashCode(f.PropertyName) ^ StringComparer.OrdinalIgnoreCase.GetHashCode(f.Value));
            }

            public override bool Equals(PathSegment other)
            {
                if (other is ArraySegment arraySegment)
                {
                    var propertyPath = GetPropertyPath();
                    Path.Context.Settings.TryGetValue(propertyPath, out var settings);
                    var defaultIndex = settings?.IndexOffset ?? Path.Context.DefaultIndexOffset;
                    if ((Index ?? defaultIndex) == (arraySegment.Index ?? defaultIndex))
                    {
                        var defaultValues = settings?.DefaultValues;
                        var firstFilters = CreatePropertyFilterListWithDefaults(defaultValues);
                        var secondFilters = arraySegment.CreatePropertyFilterListWithDefaults(defaultValues);
                        if (firstFilters.Count != secondFilters.Count)
                        {
                            return false;
                        }
                        return firstFilters.All(f => secondFilters.Any(sf => string.Equals(sf.PropertyName, f.PropertyName, StringComparison.OrdinalIgnoreCase) && string.Equals(sf.Value, f.Value, StringComparison.OrdinalIgnoreCase)));
                    }
                }
                return false;
            }

            private List<PropertyFilter> CreatePropertyFilterListWithDefaults(IDictionary<string, string> defaultValues)
            {
                var filters = Filter != null ? new List<PropertyFilter>(Filter) : new List<PropertyFilter>();
                if (defaultValues != null)
                {
                    foreach (var pair in defaultValues)
                    {
                        if (!filters.Any(f => string.Equals(f.PropertyName, pair.Key, StringComparison.OrdinalIgnoreCase) && string.Equals(f.Value, pair.Value, StringComparison.OrdinalIgnoreCase)))
                        {
                            filters.Add(new PropertyFilter(pair.Key, pair.Value));
                        }
                    }
                }
                return filters;
            }
        }

        public class ObjectFilter : IEnumerable<PropertyFilter>
        {
            private readonly List<PropertyFilter> _terms;

            public int Count => _terms?.Count ?? 1;

            internal ObjectFilter()
            {
            }

            private ObjectFilter(PropertyFilter first, PropertyFilter second)
            {
                _terms = new List<PropertyFilter> { first, second };
            }

            public ObjectFilter And(PropertyFilter filter)
            {
                Preconditions.NotNull(filter, nameof(filter));

                if (this is PropertyFilter firstPropertyFilter)
                {
                    return new ObjectFilter(firstPropertyFilter, filter);
                }

                _terms.Add(filter);
                return this;
            }

            public virtual bool Evaluate(object value, ModelPathSettings settings, Func<string, string> propertyNameTransformer) => _terms.All(term => term.Evaluate(value, settings, propertyNameTransformer));

            public override string ToString() => string.Join(" && ", _terms);

            public IEnumerator<PropertyFilter> GetEnumerator()
            {
                if (this is PropertyFilter propertyFilter)
                {
                    yield return propertyFilter;
                }
                else
                {
                    foreach (var term in _terms)
                    {
                        yield return term;
                    }
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public sealed class PropertyFilter : ObjectFilter
        {
            public string PropertyName { get; }

            public string Value { get; }

            public PropertyFilter(string propertyName, string value)
            {
                Preconditions.NotNullOrEmpty(propertyName, nameof(propertyName));

                PropertyName = propertyName;
                Value = value;
            }

            public override bool Evaluate(object value, ModelPathSettings settings, Func<string, string> propertyNameTransformer)
            {
                Preconditions.NotNull(value, nameof(value));

                var valueType = value.GetType();
                var contract = JsonHelper.InternalPrivateContractResolver.ResolveContract(valueType);
                if (!(contract is JsonObjectContract objectContract))
                {
                    throw new InvalidOperationException($"value's type must resolve to a json object contract");
                }
                var propertyName = propertyNameTransformer?.Invoke(PropertyName) ?? PropertyName;
                var property = objectContract.Properties.GetClosestMatchProperty(propertyName);
                if (property == null)
                {
                    throw new InvalidOperationException($"Could not find property {propertyName} on {valueType}");
                }

                var retrievedValue = property.ValueProvider.GetValue(value);
                return retrievedValue == null ? settings?.DefaultValues.ContainsKey(propertyName) == true : string.Equals(Value, retrievedValue.ToString(), StringComparison.OrdinalIgnoreCase);
            }

            public override string ToString()
            {
                var propertyNameEscaped = EscapeWithTick(PropertyName, out var escapeNeeded);
                return $"{(escapeNeeded ? $"'{propertyNameEscaped}'" : propertyNameEscaped)} == '{EscapeWithTick(Value, out _)}'";
            }
        }
    }
}