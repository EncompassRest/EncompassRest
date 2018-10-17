using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    public sealed class LoanFieldMappings : IDictionary<string, string>, IReadOnlyDictionary<string, string>
    {
        internal readonly ConcurrentDictionary<string, FieldDescriptor> _standardFields = new ConcurrentDictionary<string, FieldDescriptor>(StringComparer.OrdinalIgnoreCase);
        internal readonly ConcurrentDictionary<string, FieldDescriptor> _virtualFields = new ConcurrentDictionary<string, FieldDescriptor>(StringComparer.OrdinalIgnoreCase);

        public string this[string fieldId]
        {
            get
            {
                Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

                if (!_standardFields.TryGetValue(fieldId, out var descriptor) && !_virtualFields.TryGetValue(fieldId, out descriptor))
                {
                    throw new KeyNotFoundException(fieldId);
                }
                return descriptor.ModelPath;
            }
            set
            {
                Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));
                Preconditions.NotNullOrEmpty(value, nameof(value));

                var descriptor = CreateFieldDescriptor(fieldId, value, true);
                (descriptor.Type == LoanFieldType.Virtual ? _virtualFields : _standardFields)[fieldId] = descriptor;
            }
        }

        public ICollection<string> FieldIds => _standardFields.Keys.Concat(_virtualFields.Keys).ToList();

        public ICollection<string> ModelPaths => _standardFields.Values.Concat(_virtualFields.Values).Select(d => d.ModelPath).ToList();

        public int Count => _standardFields.Count + _virtualFields.Count;

        bool ICollection<KeyValuePair<string, string>>.IsReadOnly => false;

        ICollection<string> IDictionary<string, string>.Keys => FieldIds;

        ICollection<string> IDictionary<string, string>.Values => ModelPaths;

        IEnumerable<string> IReadOnlyDictionary<string, string>.Keys => FieldIds;

        IEnumerable<string> IReadOnlyDictionary<string, string>.Values => ModelPaths;

        internal LoanFieldMappings()
        {
        }

        public bool TryAdd(string fieldId, string modelPath, bool validatePathExists = true)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));
            Preconditions.NotNullOrEmpty(modelPath, nameof(modelPath));

            var descriptor = CreateFieldDescriptor(fieldId, modelPath, validatePathExists);
            return (descriptor.Type == LoanFieldType.Virtual ? _virtualFields : _standardFields).TryAdd(fieldId, descriptor);
        }

        internal void AddField(FieldDescriptor descriptor) => (descriptor.Type == LoanFieldType.Virtual ? _virtualFields : _standardFields).TryAdd(descriptor.FieldId, descriptor);

        public bool ContainsKey(string fieldId)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return _standardFields.ContainsKey(fieldId) || _virtualFields.ContainsKey(fieldId);
        }

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            foreach (var pair in _standardFields)
            {
                yield return new KeyValuePair<string, string>(pair.Key, pair.Value.ModelPath);
            }

            foreach (var pair in _virtualFields)
            {
                yield return new KeyValuePair<string, string>(pair.Key, pair.Value.ModelPath);
            }
        }

        public bool TryRemove(string fieldId, out string modelPath)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            if (_standardFields.TryRemove(fieldId, out var descriptor) || _virtualFields.TryRemove(fieldId, out descriptor))
            {
                modelPath = descriptor.ModelPath;
                return true;
            }
            modelPath = null;
            return false;
        }

        public bool TryGetValue(string fieldId, out string modelPath)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            if (TryGetDescriptor(fieldId, out var descriptor))
            {
                modelPath = descriptor.ModelPath;
                return true;
            }
            modelPath = null;
            return false;
        }

        internal bool TryGetDescriptor(string fieldId, out FieldDescriptor descriptor) => _standardFields.TryGetValue(fieldId, out descriptor) || _virtualFields.TryGetValue(fieldId, out descriptor);

        public string GetOrAdd(string fieldId, string modelPath) => GetOrAdd(fieldId, () => modelPath);

        public string GetOrAdd(string fieldId, Func<string> modelPathFactory)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));
            Preconditions.NotNull(modelPathFactory, nameof(modelPathFactory));

            if (!_standardFields.TryGetValue(fieldId, out var descriptor) && !_virtualFields.TryGetValue(fieldId, out descriptor))
            {
                var modelPath = modelPathFactory();
                descriptor = CreateFieldDescriptor(fieldId, modelPath, true);
                descriptor = (descriptor.Type == LoanFieldType.Virtual ? _virtualFields : _standardFields).GetOrAdd(fieldId, descriptor);
            }
            return descriptor.ModelPath;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        void IDictionary<string, string>.Add(string key, string value)
        {
            if (!TryAdd(key, value))
            {
                throw new ArgumentException("An element with the same fieldId already exists in the collection");
            }
        }

        void ICollection<KeyValuePair<string, string>>.Add(KeyValuePair<string, string> item) => ((IDictionary<string, string>)this).Add(item.Key, item.Value);

        bool IDictionary<string, string>.Remove(string key) => TryRemove(key, out _);

        bool ICollection<KeyValuePair<string, string>>.Remove(KeyValuePair<string, string> item) => (_standardFields.TryGetValue(item.Key, out var descriptor) || _virtualFields.TryGetValue(item.Key, out descriptor)) && descriptor._modelPath.Equals(LoanFieldDescriptors.CreateModelPath(item.Value)) && TryRemove(item.Key, out _);

        bool ICollection<KeyValuePair<string, string>>.Contains(KeyValuePair<string, string> item) => (_standardFields.TryGetValue(item.Key, out var descriptor) || _virtualFields.TryGetValue(item.Key, out descriptor)) && descriptor._modelPath.Equals(LoanFieldDescriptors.CreateModelPath(item.Value));

        void ICollection<KeyValuePair<string, string>>.CopyTo(KeyValuePair<string, string>[] array, int arrayIndex) => this.ToList().CopyTo(array, arrayIndex);

        void ICollection<KeyValuePair<string, string>>.Clear() => throw new NotSupportedException();

        private static FieldDescriptor CreateFieldDescriptor(string fieldId, string modelPath, bool validatePathExists)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));
            Preconditions.NotNullOrEmpty(modelPath, nameof(modelPath));

            var path = LoanFieldDescriptors.CreateModelPath(modelPath);
            if (path == null)
            {
                throw new ArgumentException("bad modelPath");
            }
            if (!string.Equals(path.RootObjectName, "Loan", StringComparison.Ordinal))
            {
                throw new ArgumentException("modelPath must start with Loan");
            }

            var descriptor = new FieldDescriptor(fieldId, path, modelPath, string.Empty);

            if (validatePathExists && descriptor.Type != LoanFieldType.Virtual && descriptor.ValueType == LoanFieldValueType.Unknown)
            {
                throw new ArgumentException("modelPath must resolve to a valid property type");
            }

            return descriptor;
        }
    }
}