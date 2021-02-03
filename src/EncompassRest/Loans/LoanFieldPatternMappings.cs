using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LoanFieldPatternMappings
    /// </summary>
    public sealed class LoanFieldPatternMappings : IDictionary<string, string>, IReadOnlyDictionary<string, string>
    {
        internal readonly LoanFieldPatternMappingsCollection _standardFieldPatterns = new LoanFieldPatternMappingsCollection();
        internal readonly LoanFieldPatternMappingsCollection _virtualFieldPatterns = new LoanFieldPatternMappingsCollection();

        /// <summary>
        /// Gets or sets the loan field mapping for the specified field pattern. e.g. HUD{0:00}01 => Loan.Hud1Es.Hud1EsDates[{0}].Date
        /// </summary>
        /// <param name="fieldPattern">The field pattern to get or set its loan field mapping.</param>
        /// <returns></returns>
        public string this[string fieldPattern]
        {
            get => TryGetValue(fieldPattern, out var modelPathPattern) ? modelPathPattern : throw new KeyNotFoundException();
            set
            {
                Preconditions.NotNullOrEmpty(fieldPattern, nameof(fieldPattern));
                Preconditions.NotNullOrEmpty(value, nameof(value));

                var descriptor = CreateFieldDescriptor(fieldPattern, value);
                (descriptor.Type == LoanFieldType.Virtual ? _virtualFieldPatterns : _standardFieldPatterns)[fieldPattern] = descriptor;
            }
        }

        /// <summary>
        /// The field id patterns in the collection.
        /// </summary>
        public ICollection<string> FieldPatterns => ((IReadOnlyDictionary<string, string>)this).Keys.ToList();

        /// <summary>
        /// The model path patterns in the collection.
        /// </summary>
        public ICollection<string> ModelPathPatterns => ((IReadOnlyDictionary<string, string>)this).Values.ToList();

        /// <summary>
        /// The number of field pattern mappings in the collection.
        /// </summary>
        public int Count => _standardFieldPatterns.Count + _virtualFieldPatterns.Count;

        bool ICollection<KeyValuePair<string, string>>.IsReadOnly => false;

        ICollection<string> IDictionary<string, string>.Keys => FieldPatterns;

        ICollection<string> IDictionary<string, string>.Values => ModelPathPatterns;

        IEnumerable<string> IReadOnlyDictionary<string, string>.Keys => _standardFieldPatterns.FieldPatterns.Concat(_virtualFieldPatterns.FieldPatterns);

        IEnumerable<string> IReadOnlyDictionary<string, string>.Values => _standardFieldPatterns.Descriptors.Concat(_virtualFieldPatterns.Descriptors).Select(d => d.ModelPath);

        internal LoanFieldPatternMappings()
        {
        }

        /// <summary>
        /// Tries to add the specified field pattern mapping to the colleciton.
        /// </summary>
        /// <param name="fieldPattern">The field pattern to add.</param>
        /// <param name="modelPathPattern">The field pattern's model path pattern to add.</param>
        /// <returns></returns>
        public bool TryAdd(string fieldPattern, string modelPathPattern)
        {
            Preconditions.NotNullOrEmpty(fieldPattern, nameof(fieldPattern));
            Preconditions.NotNullOrEmpty(modelPathPattern, nameof(modelPathPattern));

            var descriptor = CreateFieldDescriptor(fieldPattern, modelPathPattern);
            return (descriptor.Type == LoanFieldType.Virtual ? _virtualFieldPatterns : _standardFieldPatterns).TryAdd(fieldPattern, descriptor);
        }

        internal void AddField(FieldDescriptor descriptor) => (descriptor.Type == LoanFieldType.Virtual ? _virtualFieldPatterns : _standardFieldPatterns).TryAdd(descriptor.FieldId, descriptor);

        /// <summary>
        /// Tries to remove the specified field pattern from the collection.
        /// </summary>
        /// <param name="fieldPattern">The field pattern to remove.</param>
        /// <param name="modelPathPattern">The model path pattern associated with the removed field pattern.</param>
        /// <returns></returns>
        public bool TryRemove(string fieldPattern, [NotNullWhen(true)] out string? modelPathPattern)
        {
            Preconditions.NotNullOrEmpty(fieldPattern, nameof(fieldPattern));

            if (_standardFieldPatterns.TryRemove(fieldPattern, out var descriptor) || _virtualFieldPatterns.TryRemove(fieldPattern, out descriptor))
            {
                modelPathPattern = descriptor.ModelPath;
                return true;
            }
            modelPathPattern = null;
            return false;
        }

        /// <summary>
        /// Tries to retrieve the model path pattern associated with the specified field pattern.
        /// </summary>
        /// <param name="fieldPattern">The field pattern to search for.</param>
        /// <param name="modelPathPattern">The model path pattern associated with the field pattern.</param>
        /// <returns></returns>
#pragma warning disable CS8767 // Nullability of reference types in type of parameter doesn't match implicitly implemented member (possibly because of nullability attributes).
        public bool TryGetValue(string fieldPattern, [NotNullWhen(true)] out string? modelPathPattern)
#pragma warning restore CS8767 // Nullability of reference types in type of parameter doesn't match implicitly implemented member (possibly because of nullability attributes).
        {
            Preconditions.NotNullOrEmpty(fieldPattern, nameof(fieldPattern));

            if (_standardFieldPatterns.TryGetValue(fieldPattern, out var descriptor) || _virtualFieldPatterns.TryGetValue(fieldPattern, out descriptor))
            {
                modelPathPattern = descriptor.ModelPath;
                return true;
            }
            modelPathPattern = null;
            return false;
        }

        /// <summary>
        /// Gets or adds the model path pattern for the specified field pattern.
        /// </summary>
        /// <param name="fieldPattern">The field pattern to search for or add.</param>
        /// <param name="modelPathPattern">The model path pattern to add if necessary.</param>
        /// <returns></returns>
        public string GetOrAdd(string fieldPattern, string modelPathPattern) => GetOrAdd(fieldPattern, () => modelPathPattern);

        /// <summary>
        /// Gets or adds the model path pattern for the specified field pattern.
        /// </summary>
        /// <param name="fieldPattern">The field pattern to search for or add.</param>
        /// <param name="modelPathPatternFactory">The function to retrieve a model path pattern to add if necessary.</param>
        /// <returns></returns>
        public string GetOrAdd(string fieldPattern, Func<string> modelPathPatternFactory)
        {
            Preconditions.NotNullOrEmpty(fieldPattern, nameof(fieldPattern));
            Preconditions.NotNull(modelPathPatternFactory, nameof(modelPathPatternFactory));

            if (!_standardFieldPatterns.TryGetValue(fieldPattern, out var descriptor) && !_virtualFieldPatterns.TryGetValue(fieldPattern, out descriptor))
            {
                var modelPathPattern = modelPathPatternFactory();
                descriptor = CreateFieldDescriptor(fieldPattern, modelPathPattern);
                descriptor = (descriptor.Type == LoanFieldType.Virtual ? _virtualFieldPatterns : _standardFieldPatterns).GetOrAdd(fieldPattern, descriptor);
            }
            return descriptor.ModelPath;
        }

        void ICollection<KeyValuePair<string, string>>.CopyTo(KeyValuePair<string, string>[] array, int arrayIndex) => this.ToList().CopyTo(array, arrayIndex);

        /// <summary>
        /// Indicates whether the specified field pattern is contained within the collection.
        /// </summary>
        /// <param name="fieldPattern">The field pattern to search for.</param>
        /// <returns></returns>
        public bool ContainsKey(string fieldPattern) => TryGetValue(fieldPattern, out _);

        internal bool TryGetDescriptorForFieldId(string fieldId, [NotNullWhen(true)] out FieldDescriptor? descriptor)
        {
            _standardFieldPatterns.TryGetDescriptorForFieldId(fieldId, out var descriptor1);
            _virtualFieldPatterns.TryGetDescriptorForFieldId(fieldId, out var descriptor2);
            if (descriptor1 != null)
            {
                descriptor = descriptor1;
                if (descriptor2 != null && descriptor2.InstanceSpecifier!.Length < descriptor1.InstanceSpecifier!.Length)
                {
                    descriptor = descriptor2;
                }
            }
            else
            {
                descriptor = descriptor2;
            }
            return descriptor != null;
        }

        private FieldDescriptor CreateFieldDescriptor(string fieldPattern, string modelPathPattern)
        {
            Preconditions.NotNullOrEmpty(modelPathPattern, nameof(modelPathPattern));

            var instanceSpecifierIndex = modelPathPattern.IndexOf("{0");
            if (instanceSpecifierIndex < 0 || modelPathPattern.IndexOf("{0", instanceSpecifierIndex + 2) >= 0)
            {
                throw new ArgumentException("modelPathPattern must contain a single instance of an instance specifier {0}");
            }

            var descriptor = new FieldDescriptor(fieldPattern, LoanFieldDescriptors.CreateModelPath(string.Format(modelPathPattern, 1))!, modelPathPattern, string.Empty);
            if (descriptor._modelPath == null)
            {
                throw new ArgumentException("bad modelPathPattern");
            }

            descriptor._userAdded = true;
            return descriptor;
        }

        void IDictionary<string, string>.Add(string key, string value)
        {
            if (!TryAdd(key, value))
            {
                throw new ArgumentException("An element with the same fieldPattern already exists in the collection");
            }
        }

        void ICollection<KeyValuePair<string, string>>.Add(KeyValuePair<string, string> item) => ((IDictionary<string, string>)this).Add(item.Key, item.Value);

        void ICollection<KeyValuePair<string, string>>.Clear() => throw new NotSupportedException();

        bool ICollection<KeyValuePair<string, string>>.Contains(KeyValuePair<string, string> item) => TryGetValue(item.Key, out var modelPathPattern) && string.Equals(item.Value, modelPathPattern, StringComparison.OrdinalIgnoreCase);

        /// <summary>
        /// Gets an enumerator for iterating over the collection.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            foreach (var pair in _standardFieldPatterns)
            {
                yield return new KeyValuePair<string, string>(pair.Key, pair.Value.ModelPath);
            }

            foreach (var pair in _virtualFieldPatterns)
            {
                yield return new KeyValuePair<string, string>(pair.Key, pair.Value.ModelPath);
            }
        }

        bool IDictionary<string, string>.Remove(string key) => TryRemove(key, out _);

        bool ICollection<KeyValuePair<string, string>>.Remove(KeyValuePair<string, string> item) => TryGetValue(item.Key, out var modelPathPattern) && string.Equals(item.Value, modelPathPattern, StringComparison.OrdinalIgnoreCase) && TryRemove(item.Value, out _);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        internal sealed class LoanFieldPatternMappingsCollection : IEnumerable<KeyValuePair<string, FieldDescriptor>>
        {
            private sealed class Node
            {
                public readonly ConcurrentDictionary<string, Node> Nodes = new ConcurrentDictionary<string, Node>(StringComparer.OrdinalIgnoreCase);

                public ConcurrentDictionary<string, InstanceSpecifierAndDescriptor> Values = new ConcurrentDictionary<string, InstanceSpecifierAndDescriptor>(StringComparer.OrdinalIgnoreCase);

                public int Count => Nodes.Sum(p => p.Value.Count) + Values.Count;

                public IEnumerable<KeyValuePair<string, FieldDescriptor>> Enumerate(List<string> path)
                {
                    foreach (var pair in Values)
                    {
                        yield return new KeyValuePair<string, FieldDescriptor>(string.Concat(path) + pair.Value.InstanceSpecifier + pair.Key, pair.Value.Descriptor);
                    }
                    foreach (var pair in Nodes)
                    {
                        path.Add(pair.Key);
                        foreach (var p in pair.Value.Enumerate(path))
                        {
                            yield return p;
                        }
                        path.RemoveAt(path.Count - 1);
                    }
                }

                public sealed class InstanceSpecifierAndDescriptor
                {
                    public string InstanceSpecifier { get; }

                    public FieldDescriptor Descriptor { get; }

                    public InstanceSpecifierAndDescriptor(string instanceSpecifier, FieldDescriptor descriptor)
                    {
                        InstanceSpecifier = instanceSpecifier;
                        Descriptor = descriptor;
                    }
                }
            }

            private readonly Node _root = new Node();

            public FieldDescriptor this[string fieldPattern]
            {
                get => TryGetValue(fieldPattern, out var modelPathPattern) ? modelPathPattern : throw new KeyNotFoundException();
                set
                {
                    ValidateFieldPattern(fieldPattern, out var instanceSpecifierIndex);
                    var endBracketIndex = fieldPattern.IndexOf('}', instanceSpecifierIndex + 2);

                    var node = _root;
                    var start = 0;
                    while (start < instanceSpecifierIndex)
                    {
                        var periodIndex = fieldPattern.IndexOf('.', start, instanceSpecifierIndex - start);
                        if (periodIndex < 0)
                        {
                            periodIndex = instanceSpecifierIndex - 1;
                        }
                        node = node.Nodes.GetOrAdd(fieldPattern.Substring(start, periodIndex - start + 1), new Node());
                        start = periodIndex + 1;
                    }

                    var postfix = fieldPattern.Substring(endBracketIndex + 1);
                    var instanceSpecifier = fieldPattern.Substring(instanceSpecifierIndex, endBracketIndex - instanceSpecifierIndex + 1);
                    node.Values[postfix] = new Node.InstanceSpecifierAndDescriptor(instanceSpecifier, value);
                }
            }

            public ICollection<string> FieldPatterns => this.Select(p => p.Key).ToList();

            public ICollection<FieldDescriptor> Descriptors => this.Select(p => p.Value).ToList();

            public int Count => _root.Count;

            internal LoanFieldPatternMappingsCollection()
            {
            }

            public bool TryAdd(string fieldPattern, FieldDescriptor descriptor)
            {
                ValidateFieldPattern(fieldPattern, out var instanceSpecifierIndex);
                return TryAdd(fieldPattern, instanceSpecifierIndex, descriptor);
            }

            private bool TryAdd(string fieldPattern, int instanceSpecifierIndex, FieldDescriptor descriptor)
            {
                var endBracketIndex = fieldPattern.IndexOf('}', instanceSpecifierIndex + 2);

                var node = _root;
                var start = 0;
                while (start < instanceSpecifierIndex)
                {
                    var periodIndex = fieldPattern.IndexOf('.', start, instanceSpecifierIndex - start);
                    if (periodIndex < 0)
                    {
                        periodIndex = instanceSpecifierIndex - 1;
                    }
                    node = node.Nodes.GetOrAdd(fieldPattern.Substring(start, periodIndex - start + 1), new Node());
                    start = periodIndex + 1;
                }

                var postfix = fieldPattern.Substring(endBracketIndex + 1);
                var instanceSpecifier = fieldPattern.Substring(instanceSpecifierIndex, endBracketIndex - instanceSpecifierIndex + 1);
                return node.Values.TryAdd(postfix, new Node.InstanceSpecifierAndDescriptor(instanceSpecifier, descriptor));
            }

            public bool TryRemove(string fieldPattern, [NotNullWhen(true)] out FieldDescriptor? descriptor)
            {
                ValidateFieldPattern(fieldPattern, out var instanceSpecifierIndex);
                var endBracketIndex = fieldPattern.IndexOf('}', instanceSpecifierIndex + 2);

                var node = _root;
                var start = 0;
                while (start < instanceSpecifierIndex)
                {
                    var periodIndex = fieldPattern.IndexOf('.', start, instanceSpecifierIndex - start);
                    if (periodIndex < 0)
                    {
                        periodIndex = instanceSpecifierIndex - 1;
                    }
                    if (!node.Nodes.TryGetValue(fieldPattern.Substring(start, periodIndex - start + 1), out node))
                    {
                        descriptor = null;
                        return false;
                    }
                    start = periodIndex + 1;
                }

                var postfix = fieldPattern.Substring(endBracketIndex + 1);
                if (node.Values.TryRemove(postfix, out var instanceSpecifierAndDescriptor))
                {
                    descriptor = instanceSpecifierAndDescriptor.Descriptor;
                    return true;
                }
                descriptor = null;
                return false;
            }

            public bool TryGetValue(string fieldPattern, [NotNullWhen(true)] out FieldDescriptor? descriptor)
            {
                ValidateFieldPattern(fieldPattern, out var instanceSpecifierIndex);
                var endBracketIndex = fieldPattern.IndexOf('}', instanceSpecifierIndex + 2);

                var node = _root;
                var start = 0;
                while (start < instanceSpecifierIndex)
                {
                    var periodIndex = fieldPattern.IndexOf('.', start, instanceSpecifierIndex - start);
                    if (periodIndex < 0)
                    {
                        periodIndex = instanceSpecifierIndex - 1;
                    }
                    if (!node.Nodes.TryGetValue(fieldPattern.Substring(start, periodIndex - start + 1), out node))
                    {
                        descriptor = null;
                        return false;
                    }
                    start = periodIndex + 1;
                }

                var postfix = fieldPattern.Substring(endBracketIndex + 1);
                if (node.Values.TryGetValue(postfix, out var instanceSpecifierAndDescriptor))
                {
                    descriptor = instanceSpecifierAndDescriptor.Descriptor;
                    return true;
                }
                descriptor = null;
                return false;
            }

            public FieldDescriptor GetOrAdd(string fieldPattern, FieldDescriptor descriptor)
            {
                ValidateFieldPattern(fieldPattern, out var instanceSpecifierIndex);
                var endBracketIndex = fieldPattern.IndexOf('}', instanceSpecifierIndex + 2);

                var node = _root;
                var start = 0;
                while (start < instanceSpecifierIndex)
                {
                    var periodIndex = fieldPattern.IndexOf('.', start, instanceSpecifierIndex - start);
                    if (periodIndex < 0)
                    {
                        periodIndex = instanceSpecifierIndex - 1;
                    }
                    node = node.Nodes.GetOrAdd(fieldPattern.Substring(start, periodIndex - start + 1), new Node());
                    start = periodIndex + 1;
                }

                var postfix = fieldPattern.Substring(endBracketIndex + 1);
                var instanceSpecifier = fieldPattern.Substring(instanceSpecifierIndex, endBracketIndex - instanceSpecifierIndex + 1);
                var retrievedDescriptor = node.Values.GetOrAdd(postfix, p => new Node.InstanceSpecifierAndDescriptor(instanceSpecifier, descriptor)).Descriptor;
                return retrievedDescriptor;
            }

            internal bool TryGetDescriptorForFieldId(string fieldId, [NotNullWhen(true)] out FieldDescriptor? descriptor)
            {
                var originalFieldId = fieldId;
                fieldId = fieldId.ToLower();
                var node = _root;
                var start = 0;
                descriptor = null;
                bool found;
                do
                {
                    found = false;
                    foreach (var pair in node.Values)
                    {
                        var postfix = pair.Key;
                        var instanceSpecifierFormat = pair.Value.InstanceSpecifier;
                        var instanceSpecifierLength = string.Format(instanceSpecifierFormat, 1).Length;
                        if (instanceSpecifierLength > 1 ? fieldId.Length - start - instanceSpecifierLength >= postfix.Length : fieldId.Length - postfix.Length > start)
                        {
                            var i = 0;
                            while (i < postfix.Length && char.ToLower(postfix[i]) == fieldId[fieldId.Length - postfix.Length + i])
                            {
                                ++i;
                            }
                            if (i == postfix.Length)
                            {
                                var instanceSpecifier = originalFieldId.Substring(start, originalFieldId.Length - start - postfix.Length);
                                descriptor = pair.Value.Descriptor.GetInstanceDescriptor(instanceSpecifier);
                                if (instanceSpecifierLength > 1 && (fieldId.Length - start - instanceSpecifierLength) != postfix.Length)
                                {
                                    found = true;
                                }
                                else
                                {
                                    return true;
                                }
                            }
                        }
                    }
                    if (found)
                    {
#pragma warning disable CS8762 // Parameter may not have a null value when exiting in some condition.
                        return true;
#pragma warning restore CS8762 // Parameter may not have a null value when exiting in some condition.
                    }
                    var newStart = start;
                    foreach (var pair in node.Nodes)
                    {
                        var prefix = pair.Key;
                        if (start + prefix.Length < fieldId.Length)
                        {
                            var i = 0;
                            while (i < prefix.Length && char.ToLower(prefix[i]) == fieldId[start + i])
                            {
                                ++i;
                            }
                            if (i == prefix.Length)
                            {
                                found = true;
                                node = pair.Value;
                                newStart = start + prefix.Length;
                                if (prefix.Length > 0 && prefix[prefix.Length - 1] == '.')
                                {
                                    break;
                                }
                            }
                        }
                    }
                    start = newStart;
                } while (found);
                return false;
            }

            private void ValidateFieldPattern(string fieldPattern, out int instanceSpecifierIndex)
            {
                Preconditions.NotNullOrEmpty(fieldPattern, nameof(fieldPattern));

                instanceSpecifierIndex = fieldPattern.IndexOf("{0");
                if (instanceSpecifierIndex < 0 || fieldPattern.IndexOf("{0", instanceSpecifierIndex + 2) >= 0)
                {
                    throw new ArgumentException("fieldPattern must contain a single instance of an instance specifier {0}");
                }

                string.Format(fieldPattern, 1);
            }

            public IEnumerator<KeyValuePair<string, FieldDescriptor>> GetEnumerator()
            {
                foreach (var pair in _root.Enumerate(new List<string>()))
                {
                    yield return pair;
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}