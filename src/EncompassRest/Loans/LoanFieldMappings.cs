using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans
{
    public sealed class LoanFieldMappings : IDictionary<string, string>, IReadOnlyDictionary<string, string>
    {
        internal readonly ConcurrentDictionary<string, ModelPath> _dictionary;
        private FieldIdCollection _fieldIds;
        private ModelPathCollection _modelPaths;

        public string this[string fieldId]
        {
            get
            {
                Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

                return _dictionary[fieldId.ToUpper()].ToString();
            }
            set
            {
                fieldId = fieldId?.ToUpper();
                var path = CreateModelPath(fieldId, value, true);
                _dictionary[fieldId] = path;
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

        internal LoanFieldMappings(ConcurrentDictionary<string, ModelPath> dictionary)
        {
            _dictionary = dictionary;
        }

        public bool TryAdd(string fieldId, string modelPath, bool validatePathExists = true)
        {
            fieldId = fieldId?.ToUpper();
            var path = CreateModelPath(fieldId, modelPath, validatePathExists);
            return _dictionary.TryAdd(fieldId, path);
        }

        private ModelPath CreateModelPath(string fieldId, string modelPath, bool validatePathExists)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));
            Preconditions.NotNullOrEmpty(modelPath, nameof(modelPath));

            var path = new ModelPath(modelPath);
            if (!string.Equals(path.RootObjectName, "Loan", StringComparison.Ordinal))
            {
                throw new ArgumentException("modelPath must start with Loan");
            }

            if (validatePathExists)
            {
                var loanField = new LoanField(fieldId, null, path);
                if (!loanField.Type.IsDefined())
                {
                    throw new ArgumentException("modelPath must resolve to a valid property type");
                }
            }

            return path;
        }

        public bool ContainsKey(string fieldId)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return _dictionary.ContainsKey(fieldId.ToUpper());
        }

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            foreach (var pair in _dictionary)
            {
                yield return new KeyValuePair<string, string>(pair.Key, pair.Value.ToString());
            }
        }

        public bool TryRemove(string fieldId, out string modelPath)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            var success = _dictionary.TryRemove(fieldId.ToUpper(), out var path);
            modelPath = path?.ToString();
            return success;
        }

        public bool TryGetValue(string fieldId, out string modelPath)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            var success = _dictionary.TryGetValue(fieldId.ToUpper(), out var path);
            modelPath = path?.ToString();
            return success;
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

        bool ICollection<KeyValuePair<string, string>>.Remove(KeyValuePair<string, string> item) => _dictionary.TryGetValue(item.Key?.ToUpper(), out var modelPath) && modelPath.Equals(ModelPath.Create(item.Value)) && _dictionary.TryRemove(item.Key, out modelPath);

        bool ICollection<KeyValuePair<string, string>>.Contains(KeyValuePair<string, string> item) => _dictionary.TryGetValue(item.Key?.ToUpper(), out var modelPath) && modelPath.Equals(ModelPath.Create(item.Value));

        void ICollection<KeyValuePair<string, string>>.CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
        {
            Preconditions.NotNull(array, nameof(array));
            Preconditions.LessThan(arrayIndex, nameof(arrayIndex), array.Length, $"{nameof(array)}.Length");
            Preconditions.GreaterThanOrEquals(array.Length - arrayIndex, $"{nameof(array)}.Length - {nameof(arrayIndex)}", Count, nameof(Count));

            var i = 0;
            foreach (var pair in _dictionary)
            {
                array[arrayIndex + i] = new KeyValuePair<string, string>(pair.Key, pair.Value.ToString());
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
                var modelPath = ModelPath.Create(item);
                if (modelPath != null)
                {
                    foreach (var pair in _loanFieldMappings._dictionary)
                    {
                        if (pair.Value.Equals(modelPath))
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
                    array[arrayIndex + i] = pair.Value.ToString();
                    ++i;
                }
            }

            public IEnumerator<string> GetEnumerator()
            {
                foreach (var pair in _loanFieldMappings._dictionary)
                {
                    yield return pair.Value.ToString();
                }
            }

            public bool Remove(string item) => throw new NotSupportedException();

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}