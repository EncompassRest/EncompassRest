using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    public sealed class LoanFieldMappings : IDictionary<string, string>, IReadOnlyDictionary<string, string>
    {
        internal readonly ConcurrentDictionary<string, FieldDescriptor> _dictionary = new ConcurrentDictionary<string, FieldDescriptor>();
        private FieldIdCollection _fieldIds;
        private ModelPathCollection _modelPaths;

        public string this[string fieldId]
        {
            get
            {
                Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

                return _dictionary[fieldId].ModelPath;
            }
            set
            {
                var descriptor = CreateFieldDescriptor(fieldId, value, true);
                _dictionary[fieldId] = descriptor;
                switch (descriptor.Type)
                {
                    case LoanFieldType.Standard:
                        LoanFieldDescriptors.s_standardFields[fieldId] = descriptor;
                        break;
                    case LoanFieldType.Virtual:
                        LoanFieldDescriptors.s_virtualFields[fieldId] = descriptor;
                        break;
                }
            }
        }

        public ICollection<string> FieldIds
        {
            get
            {
                var fieldIds = _fieldIds;
                return fieldIds ?? Interlocked.CompareExchange(ref _fieldIds, (fieldIds = new FieldIdCollection(this)), null) ?? fieldIds;
            }
        }

        public ICollection<string> ModelPaths
        {
            get
            {
                var modelPaths = _modelPaths;
                return modelPaths ?? Interlocked.CompareExchange(ref _modelPaths, (modelPaths = new ModelPathCollection(this)), null) ?? modelPaths;
            }
        }

        public int Count => _dictionary.Count;

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
            var descriptor = CreateFieldDescriptor(fieldId, modelPath, validatePathExists);
            if (_dictionary.TryAdd(fieldId, descriptor))
            {
                switch (descriptor.Type)
                {
                    case LoanFieldType.Standard:
                        LoanFieldDescriptors.s_standardFields.TryAdd(fieldId, descriptor);
                        break;
                    case LoanFieldType.Virtual:
                        LoanFieldDescriptors.s_virtualFields.TryAdd(fieldId, descriptor);
                        break;
                }
                return true;
            }
            return false;
        }

        internal void AddVirtualField(FieldDescriptor descriptor)
        {
            var fieldId = descriptor.FieldId;
            _dictionary.TryAdd(fieldId, descriptor);
            LoanFieldDescriptors.s_virtualFields.TryAdd(fieldId, descriptor);
        }

        private FieldDescriptor CreateFieldDescriptor(string fieldId, string modelPath, bool validatePathExists)
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

            var loanFieldType = LoanFieldType.Standard;
            var isBorrowerPairSpecific = false;
            if (modelPath.StartsWith("Loan.CustomFields", StringComparison.OrdinalIgnoreCase))
            {
                loanFieldType = LoanFieldType.Custom;
            }
            else if (modelPath.StartsWith("Loan.VirtualFields", StringComparison.OrdinalIgnoreCase))
            {
                loanFieldType = LoanFieldType.Virtual;
            }
            else if (modelPath.StartsWith("Loan.CurrentApplication.", StringComparison.OrdinalIgnoreCase))
            {
                isBorrowerPairSpecific = true;
            }

            var descriptor = new FieldDescriptor(fieldId, path, loanFieldType, isBorrowerPairSpecific);

            if (validatePathExists && descriptor.Type != LoanFieldType.Virtual && descriptor.ValueType == LoanFieldValueType.Unknown)
            {
                throw new ArgumentException("modelPath must resolve to a valid property type");
            }

            return descriptor;
        }

        public bool ContainsKey(string fieldId)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return _dictionary.ContainsKey(fieldId);
        }

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            foreach (var pair in _dictionary)
            {
                yield return new KeyValuePair<string, string>(pair.Key, pair.Value.ModelPath);
            }
        }

        public bool TryRemove(string fieldId, out string modelPath)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            if (_dictionary.TryRemove(fieldId, out var descriptor))
            {
                modelPath = descriptor?.ModelPath;
                switch (descriptor.Type)
                {
                    case LoanFieldType.Standard:
                        LoanFieldDescriptors.s_standardFields.TryRemove(fieldId, out _);
                        break;
                    case LoanFieldType.Virtual:
                        LoanFieldDescriptors.s_virtualFields.TryRemove(fieldId, out _);
                        break;
                }
                return true;
            }
            modelPath = null;
            return false;
        }

        public bool TryGetValue(string fieldId, out string modelPath)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            var success = _dictionary.TryGetValue(fieldId, out var descriptor);
            modelPath = descriptor?.ModelPath;
            return success;
        }

        public string GetOrAdd(string fieldId, string modelPath) => GetOrAdd(fieldId, () => modelPath);

        public string GetOrAdd(string fieldId, Func<string> modelPathFactory)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));
            Preconditions.NotNull(modelPathFactory, nameof(modelPathFactory));

            FieldDescriptor descriptor = null;
            var retrievedDescriptor = _dictionary.GetOrAdd(fieldId, f => (descriptor = CreateFieldDescriptor(f, modelPathFactory(), true)));
            if (ReferenceEquals(descriptor, retrievedDescriptor))
            {
                switch (descriptor.Type)
                {
                    case LoanFieldType.Standard:
                        LoanFieldDescriptors.s_standardFields.TryAdd(fieldId, descriptor);
                        break;
                    case LoanFieldType.Virtual:
                        LoanFieldDescriptors.s_virtualFields.TryAdd(fieldId, descriptor);
                        break;
                }
            }
            return retrievedDescriptor.ModelPath;
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

        bool ICollection<KeyValuePair<string, string>>.Remove(KeyValuePair<string, string> item) => _dictionary.TryGetValue(item.Key, out var descriptor) && descriptor._modelPath.Equals(LoanFieldDescriptors.CreateModelPath(item.Value)) && _dictionary.TryRemove(item.Key, out descriptor);

        bool ICollection<KeyValuePair<string, string>>.Contains(KeyValuePair<string, string> item) => _dictionary.TryGetValue(item.Key, out var descriptor) && descriptor._modelPath.Equals(LoanFieldDescriptors.CreateModelPath(item.Value));

        void ICollection<KeyValuePair<string, string>>.CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
        {
            Preconditions.NotNull(array, nameof(array));
            Preconditions.LessThan(arrayIndex, nameof(arrayIndex), array.Length, $"{nameof(array)}.Length");
            Preconditions.GreaterThanOrEquals(array.Length - arrayIndex, $"{nameof(array)}.Length - {nameof(arrayIndex)}", Count, nameof(Count));

            var i = 0;
            foreach (var pair in _dictionary)
            {
                array[arrayIndex + i] = new KeyValuePair<string, string>(pair.Key, pair.Value.ModelPath);
                ++i;
            }
        }

        void ICollection<KeyValuePair<string, string>>.Clear() => throw new NotSupportedException();

        private sealed class FieldIdCollection : ICollection<string>
        {
            private readonly LoanFieldMappings _loanFieldMappings;

            public int Count => _loanFieldMappings.Count;

            public bool IsReadOnly => true;

            public FieldIdCollection(LoanFieldMappings loanFieldMappings)
            {
                _loanFieldMappings = loanFieldMappings;
            }

            public void Add(string item) => throw new NotSupportedException();

            public void Clear() => throw new NotSupportedException();

            public bool Contains(string item) => _loanFieldMappings.ContainsKey(item);

            public void CopyTo(string[] array, int arrayIndex) => _loanFieldMappings._dictionary.Keys.CopyTo(array, arrayIndex);

            public IEnumerator<string> GetEnumerator() => _loanFieldMappings._dictionary.Keys.GetEnumerator();

            public bool Remove(string item) => throw new NotSupportedException();

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        private sealed class ModelPathCollection : ICollection<string>
        {
            private readonly LoanFieldMappings _loanFieldMappings;

            public int Count => _loanFieldMappings.Count;

            public bool IsReadOnly => true;

            public ModelPathCollection(LoanFieldMappings loanFieldMappings)
            {
                _loanFieldMappings = loanFieldMappings;
            }

            public void Add(string item) => throw new NotSupportedException();

            public void Clear() => throw new NotSupportedException();

            public bool Contains(string item)
            {
                var modelPath = LoanFieldDescriptors.CreateModelPath(item);
                if (modelPath != null)
                {
                    foreach (var pair in _loanFieldMappings._dictionary)
                    {
                        if (pair.Value._modelPath.Equals(modelPath))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }

            public void CopyTo(string[] array, int arrayIndex)
            {
                Preconditions.NotNull(array, nameof(array));
                Preconditions.LessThan(arrayIndex, nameof(arrayIndex), array.Length, $"{nameof(array)}.Length");
                Preconditions.GreaterThanOrEquals(array.Length - arrayIndex, $"{nameof(array)}.Length - {nameof(arrayIndex)}", Count, nameof(Count));

                var i = 0;
                foreach (var pair in _loanFieldMappings._dictionary)
                {
                    array[arrayIndex + i] = pair.Value.ModelPath;
                    ++i;
                }
            }

            public IEnumerator<string> GetEnumerator()
            {
                foreach (var pair in _loanFieldMappings._dictionary)
                {
                    yield return pair.Value.ModelPath;
                }
            }

            public bool Remove(string item) => throw new NotSupportedException();

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}