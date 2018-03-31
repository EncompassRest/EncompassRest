using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    public sealed class LoanFieldPatternMappings : IDictionary<string, string>, IReadOnlyDictionary<string, string>
    {
        private sealed class Node
        {
            public readonly ConcurrentDictionary<string, Node> Nodes = new ConcurrentDictionary<string, Node>(StringComparer.OrdinalIgnoreCase);

            public ConcurrentDictionary<string, InstanceSpecifierAndModelPathPattern> Values = new ConcurrentDictionary<string, InstanceSpecifierAndModelPathPattern>(StringComparer.OrdinalIgnoreCase);

            public int Count => Nodes.Sum(p => p.Value.Count) + Values.Count;

            public IEnumerable<KeyValuePair<string, string>> Enumerate(List<string> path)
            {
                foreach (var pair in Values)
                {
                    yield return new KeyValuePair<string, string>(string.Concat(path) + pair.Value.InstanceSpecifier + pair.Key, pair.Value.ModelPathPattern);
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

            public sealed class InstanceSpecifierAndModelPathPattern
            {
                public string InstanceSpecifier { get; }

                public string ModelPathPattern { get; }

                public InstanceSpecifierAndModelPathPattern(string instanceSpecifier, string modelPathPattern)
                {
                    InstanceSpecifier = instanceSpecifier;
                    ModelPathPattern = modelPathPattern;
                }
            }
        }

        private readonly Node _root = new Node();

        public string this[string fieldPattern]
        {
            get => TryGetValue(fieldPattern, out var modelPathPattern) ? modelPathPattern : throw new KeyNotFoundException();
            set
            {
                ValidateFieldPattern(fieldPattern, out var instanceSpecifierIndex);
                ValidateModelPathPattern(value);
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
                node.Values[postfix] = new Node.InstanceSpecifierAndModelPathPattern(instanceSpecifier, value);
            }
        }

        public ICollection<string> FieldPatterns => this.Select(p => p.Key).ToList();

        public ICollection<string> ModelPathPatterns => this.Select(p => p.Value).ToList();

        public int Count => _root.Count;

        bool ICollection<KeyValuePair<string, string>>.IsReadOnly => false;

        ICollection<string> IDictionary<string, string>.Keys => FieldPatterns;

        ICollection<string> IDictionary<string, string>.Values => ModelPathPatterns;

        IEnumerable<string> IReadOnlyDictionary<string, string>.Keys => FieldPatterns;

        IEnumerable<string> IReadOnlyDictionary<string, string>.Values => ModelPathPatterns;

        internal LoanFieldPatternMappings(IDictionary<string, string> dictionary)
        {
            foreach (var pair in dictionary)
            {
                TryAdd(pair.Key, pair.Value);
            }
        }

        public bool TryAdd(string fieldPattern, string modelPathPattern)
        {
            ValidateFieldPattern(fieldPattern, out var instanceSpecifierIndex);
            ValidateModelPathPattern(modelPathPattern);
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
            return node.Values.TryAdd(postfix, new Node.InstanceSpecifierAndModelPathPattern(instanceSpecifier, modelPathPattern));
        }

        public bool TryRemove(string fieldPattern, out string modelPathPattern)
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
                    modelPathPattern = null;
                    return false;
                }
                start = periodIndex + 1;
            }

            var postfix = fieldPattern.Substring(endBracketIndex + 1);
            if (node.Values.TryRemove(postfix, out var instanceSpecifierAndModelPathPattern))
            {
                modelPathPattern = instanceSpecifierAndModelPathPattern.ModelPathPattern;
                return true;
            }
            modelPathPattern = null;
            return false;
        }

        public bool TryGetValue(string fieldPattern, out string modelPathPattern)
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
                    modelPathPattern = null;
                    return false;
                }
                start = periodIndex + 1;
            }

            var postfix = fieldPattern.Substring(endBracketIndex + 1);
            if (node.Values.TryGetValue(postfix, out var instanceSpecifierAndModelPathPattern))
            {
                modelPathPattern = instanceSpecifierAndModelPathPattern.ModelPathPattern;
                return true;
            }
            modelPathPattern = null;
            return false;
        }

        public string GetOrAdd(string fieldPattern, string modelPathPattern) => GetOrAdd(fieldPattern, p => modelPathPattern);

        public string GetOrAdd(string fieldPattern, Func<string, string> modelPathPatternFactory)
        {
            Preconditions.NotNull(modelPathPatternFactory, nameof(modelPathPatternFactory));

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
            return node.Values.GetOrAdd(postfix, p =>
            {
                var modelPathPattern = modelPathPatternFactory(p);
                ValidateModelPathPattern(modelPathPattern);
                return new Node.InstanceSpecifierAndModelPathPattern(instanceSpecifier, modelPathPattern);
            }).ModelPathPattern;
        }

        public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex) => this.ToList().CopyTo(array, arrayIndex);

        public bool ContainsKey(string fieldPattern) => TryGetValue(fieldPattern, out _);

        internal bool TryGetModelPathForFieldId(string fieldId, out ModelPath modelPath, out string instanceSpecifier)
        {
            var originalFieldId = fieldId;
            fieldId = fieldId.ToLower();
            var node = _root;
            var start = 0;
            bool found;
            do
            {
                found = false;
                foreach (var pair in node.Values)
                {
                    var postfix = pair.Key;
                    var instanceSpecifierLength = string.Format(pair.Value.InstanceSpecifier, 1).Length;
                    if (instanceSpecifierLength > 1 ? fieldId.Length - start - instanceSpecifierLength == postfix.Length : fieldId.Length - postfix.Length > start)
                    {
                        var i = 0;
                        while (i < postfix.Length && char.ToLower(postfix[i]) == fieldId[fieldId.Length - postfix.Length + i])
                        {
                            ++i;
                        }
                        if (i == postfix.Length)
                        {
                            instanceSpecifier = originalFieldId.Substring(start, originalFieldId.Length - start - postfix.Length);
                            modelPath = LoanFields.ModelPathContext.Create(string.Format(pair.Value.ModelPathPattern, instanceSpecifier));
                            return true;
                        }
                    }
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
            instanceSpecifier = null;
            modelPath = null;
            return false;
        }

        private void ValidateFieldPattern(string fieldPattern, out int instanceSpecifierIndex)
        {
            Preconditions.NotNullOrEmpty(fieldPattern, nameof(fieldPattern));

            instanceSpecifierIndex = fieldPattern.IndexOf("{0");
            if (instanceSpecifierIndex < 0 || fieldPattern.IndexOf("{0", instanceSpecifierIndex + 2) >= 0)
            {
                throw new ArgumentException("fieldPattern's instance specifier {0} is missing, in the wrong spot, or occurs multiple times");
            }

            string.Format(fieldPattern, 1);
        }

        private void ValidateModelPathPattern(string modelPathPattern)
        {
            Preconditions.NotNullOrEmpty(modelPathPattern, nameof(modelPathPattern));

            var instanceSpecifierIndex = modelPathPattern.IndexOf("{0");
            if (instanceSpecifierIndex < 0 || modelPathPattern.IndexOf("{0", instanceSpecifierIndex + 2) >= 0)
            {
                throw new ArgumentException("modelPathPattern must contain a single instance of NN");
            }

            var modelPath = LoanFields.ModelPathContext.Create(string.Format(modelPathPattern, 1));
            if (modelPath == null)
            {
                throw new ArgumentException("bad modelPathPattern");
            }
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
        
        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            foreach (var pair in _root.Enumerate(new List<string>()))
            {
                yield return pair;
            }
        }

        bool IDictionary<string, string>.Remove(string key) => TryRemove(key, out _);

        bool ICollection<KeyValuePair<string, string>>.Remove(KeyValuePair<string, string> item) => TryGetValue(item.Key, out var modelPathPattern) && string.Equals(item.Value, modelPathPattern, StringComparison.OrdinalIgnoreCase) && TryRemove(item.Value, out modelPathPattern);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
