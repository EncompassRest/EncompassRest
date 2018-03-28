using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    public sealed class LoanFieldPatternMappings : IDictionary<string, string>, IReadOnlyDictionary<string, string>
    {
        private readonly ConcurrentDictionary<string, string> _dictionary;

        public string this[string fieldPattern]
        {
            get
            {
                Preconditions.NotNullOrEmpty(fieldPattern, nameof(fieldPattern));

                return _dictionary[fieldPattern];
            }
            set
            {
                ValidateFieldPattern(fieldPattern);
                ValidateModelPathPattern(value);

                _dictionary[fieldPattern] = value;
            }
        }

        public ICollection<string> FieldPatterns => _dictionary.Keys;

        public ICollection<string> ModelPathPatterns => _dictionary.Values;

        public int Count => _dictionary.Count;

        bool ICollection<KeyValuePair<string, string>>.IsReadOnly => false;

        ICollection<string> IDictionary<string, string>.Keys => FieldPatterns;

        ICollection<string> IDictionary<string, string>.Values => ModelPathPatterns;

        IEnumerable<string> IReadOnlyDictionary<string, string>.Keys => FieldPatterns;

        IEnumerable<string> IReadOnlyDictionary<string, string>.Values => ModelPathPatterns;

        internal LoanFieldPatternMappings(ConcurrentDictionary<string, string> dictionary)
        {
            _dictionary = dictionary;
        }

        public bool TryAdd(string fieldPattern, string modelPathPattern)
        {
            ValidateFieldPattern(fieldPattern);
            ValidateModelPathPattern(modelPathPattern);

            return _dictionary.TryAdd(fieldPattern, modelPathPattern);
        }

        public bool TryRemove(string fieldPattern, out string modelPathPattern) => _dictionary.TryRemove(fieldPattern, out modelPathPattern);

        public bool TryGetValue(string fieldPattern, out string modelPathPattern) => _dictionary.TryGetValue(fieldPattern, out modelPathPattern);

        public string GetOrAdd(string fieldPattern, string modelPathPattern) => GetOrAdd(fieldPattern, () => modelPathPattern);

        public string GetOrAdd(string fieldPattern, Func<string> modelPathPatternFactory)
        {
            Preconditions.NotNullOrEmpty(fieldPattern, nameof(fieldPattern));
            Preconditions.NotNull(modelPathPatternFactory, nameof(modelPathPatternFactory));

            return _dictionary.GetOrAdd(fieldPattern, f =>
            {
                ValidateFieldPattern(f);
                var modelPathPattern = modelPathPatternFactory();
                ValidateModelPathPattern(modelPathPattern);
                return modelPathPattern;
            });
        }

        public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex) => ((IDictionary<string, string>)_dictionary).CopyTo(array, arrayIndex);

        public bool ContainsKey(string fieldPattern) => _dictionary.ContainsKey(fieldPattern);

        private void ValidateFieldPattern(string fieldPattern)
        {
            Preconditions.NotNull(fieldPattern, nameof(fieldPattern));
            if (fieldPattern.Length < 5)
            {
                throw new ArgumentException("fieldPattern must be at least 5 characters long");
            }

            var nnIndex = fieldPattern.IndexOf("NN");
            if (nnIndex < 0 || (nnIndex != fieldPattern.Length - 5 && nnIndex != fieldPattern.Length - 4) || fieldPattern.IndexOf("NN", nnIndex + 1) >= 0)
            {
                throw new ArgumentException("fieldPattern's NN is missing, in the wrong spot, or occurs multiple times");
            }
        }

        private void ValidateModelPathPattern(string modelPathPattern)
        {
            Preconditions.NotNullOrEmpty(modelPathPattern, nameof(modelPathPattern));

            var nnIndex = modelPathPattern.IndexOf("[NN]");
            if (nnIndex < 0 || modelPathPattern.IndexOf("[NN]", nnIndex + 4) >= 0)
            {
                throw new ArgumentException("modelPathPattern must contain a single instance of NN");
            }

            var modelPath = LoanFields.ModelPathContext.Create($"{modelPathPattern.Substring(0, nnIndex + 1)}1{modelPathPattern.Substring(nnIndex + 3)}");
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

        bool ICollection<KeyValuePair<string, string>>.Contains(KeyValuePair<string, string> item) => _dictionary.TryGetValue(item.Key, out var modelPathPattern) && string.Equals(item.Value, modelPathPattern, StringComparison.OrdinalIgnoreCase);
        
        public IEnumerator<KeyValuePair<string, string>> GetEnumerator() => _dictionary.GetEnumerator();

        bool IDictionary<string, string>.Remove(string key) => TryRemove(key, out _);

        bool ICollection<KeyValuePair<string, string>>.Remove(KeyValuePair<string, string> item) => _dictionary.TryGetValue(item.Key, out var modelPathPattern) && string.Equals(item.Value, modelPathPattern, StringComparison.OrdinalIgnoreCase) && _dictionary.TryRemove(item.Value, out modelPathPattern);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
