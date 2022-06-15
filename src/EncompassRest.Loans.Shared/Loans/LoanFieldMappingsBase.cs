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
    /// LoanFieldMappingsBase
    /// </summary>
    public abstract class LoanFieldMappingsBase : IDictionary<string, string>, IReadOnlyDictionary<string, string>
    {
        internal readonly ConcurrentDictionary<string, FieldDescriptorBase> _standardFields = new ConcurrentDictionary<string, FieldDescriptorBase>(StringComparer.OrdinalIgnoreCase);
        internal readonly ConcurrentDictionary<string, FieldDescriptorBase> _virtualFields = new ConcurrentDictionary<string, FieldDescriptorBase>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Gets or sets the loan field mapping for the specified field id. e.g. HMDA.X32 => Loan.Hmda.Income, VEND.X263 => Loan.Contacts[(ContactType == 'INVESTOR')].Name
        /// </summary>
        /// <param name="fieldId">The field id to get or set its loan field mapping.</param>
        /// <returns></returns>
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

        /// <summary>
        /// The field ids in the collection.
        /// </summary>
        public ICollection<string> FieldIds => ((IReadOnlyDictionary<string, string>)this).Keys.ToList();

        /// <summary>
        /// The model paths in the collection.
        /// </summary>
        public ICollection<string> ModelPaths => ((IReadOnlyDictionary<string, string>)this).Values.ToList();

        /// <summary>
        /// The number of field mappings in the collection.
        /// </summary>
        public int Count => _standardFields.Count + _virtualFields.Count;

        bool ICollection<KeyValuePair<string, string>>.IsReadOnly => false;

        ICollection<string> IDictionary<string, string>.Keys => FieldIds;

        ICollection<string> IDictionary<string, string>.Values => ModelPaths;

        IEnumerable<string> IReadOnlyDictionary<string, string>.Keys => _standardFields.Keys.Concat(_virtualFields.Keys);

        IEnumerable<string> IReadOnlyDictionary<string, string>.Values => _standardFields.Values.Concat(_virtualFields.Values).Select(d => d.ModelPath);

        internal LoanFieldMappingsBase()
        {
        }

        /// <summary>
        /// Tries to add the specified field mapping to the colleciton.
        /// </summary>
        /// <param name="fieldId">The field id to add.</param>
        /// <param name="modelPath">The field's model path to add.</param>
        /// <param name="validatePathExists">Indicates whether the model path should validate if the path exists in the loan object.</param>
        /// <returns></returns>
        public bool TryAdd(string fieldId, string modelPath, bool validatePathExists = true)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));
            Preconditions.NotNullOrEmpty(modelPath, nameof(modelPath));

            var descriptor = CreateFieldDescriptor(fieldId, modelPath, validatePathExists);
            return (descriptor.Type == LoanFieldType.Virtual ? _virtualFields : _standardFields).TryAdd(fieldId, descriptor);
        }

        internal void AddField(FieldDescriptorBase descriptor) => (descriptor.Type == LoanFieldType.Virtual ? _virtualFields : _standardFields).TryAdd(descriptor.FieldId, descriptor);

        /// <summary>
        /// Indicates whether the specified field is contained within the collection.
        /// </summary>
        /// <param name="fieldId">The field id to search for.</param>
        /// <returns></returns>
        public bool ContainsKey(string fieldId)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return _standardFields.ContainsKey(fieldId) || _virtualFields.ContainsKey(fieldId);
        }

        /// <summary>
        /// Gets an enumerator for iterating over the collection.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Tries to remove the specified field from the collection.
        /// </summary>
        /// <param name="fieldId">The field id to remove.</param>
        /// <param name="modelPath">The model path associated with the removed field.</param>
        /// <returns></returns>
        public bool TryRemove(string fieldId, [NotNullWhen(true)] out string? modelPath)
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

        /// <summary>
        /// Tries to retrieve the model path associated with the specified field id.
        /// </summary>
        /// <param name="fieldId">The field id to search for.</param>
        /// <param name="modelPath">The model path associated with the field.</param>
        /// <returns></returns>
#pragma warning disable CS8767 // Nullability of reference types in type of parameter doesn't match implicitly implemented member (possibly because of nullability attributes).
        public bool TryGetValue(string fieldId, [NotNullWhen(true)] out string? modelPath)
#pragma warning restore CS8767 // Nullability of reference types in type of parameter doesn't match implicitly implemented member (possibly because of nullability attributes).
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

        internal bool TryGetDescriptor(string fieldId, [NotNullWhen(true)] out FieldDescriptorBase? descriptor) => _standardFields.TryGetValue(fieldId, out descriptor) || _virtualFields.TryGetValue(fieldId, out descriptor);

        /// <summary>
        /// Gets or adds the model path for the specified field id.
        /// </summary>
        /// <param name="fieldId">The field id to search for or add.</param>
        /// <param name="modelPath">The model path to add if necessary.</param>
        /// <returns></returns>
        public string GetOrAdd(string fieldId, string modelPath) => GetOrAdd(fieldId, () => modelPath);

        /// <summary>
        /// Gets or adds the model path for the specified field id.
        /// </summary>
        /// <param name="fieldId">The field id to search for or add.</param>
        /// <param name="modelPathFactory">The function to retrieve a model path to add if necessary.</param>
        /// <returns></returns>
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

        bool ICollection<KeyValuePair<string, string>>.Remove(KeyValuePair<string, string> item) => (_standardFields.TryGetValue(item.Key, out var descriptor) || _virtualFields.TryGetValue(item.Key, out descriptor)) && descriptor._modelPath.Equals(CreateModelPath(item.Value)) && TryRemove(item.Key, out _);

        bool ICollection<KeyValuePair<string, string>>.Contains(KeyValuePair<string, string> item) => (_standardFields.TryGetValue(item.Key, out var descriptor) || _virtualFields.TryGetValue(item.Key, out descriptor)) && descriptor._modelPath.Equals(CreateModelPath(item.Value));

        void ICollection<KeyValuePair<string, string>>.CopyTo(KeyValuePair<string, string>[] array, int arrayIndex) => this.ToList().CopyTo(array, arrayIndex);

        void ICollection<KeyValuePair<string, string>>.Clear() => throw new NotSupportedException();

        private FieldDescriptorBase CreateFieldDescriptor(string fieldId, string modelPath, bool validatePathExists)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));
            Preconditions.NotNullOrEmpty(modelPath, nameof(modelPath));

            var path = CreateModelPath(modelPath);
            if (path == null)
            {
                throw new ArgumentException("bad modelPath");
            }
            if (!string.Equals(path.RootObjectName, "Loan", StringComparison.Ordinal))
            {
                throw new ArgumentException("modelPath must start with Loan");
            }

            var descriptor = CreateFieldDescriptor(fieldId, path, modelPath);

            if (validatePathExists && descriptor.Type != LoanFieldType.Virtual && descriptor.ValueType == LoanFieldValueType.Unknown)
            {
                throw new ArgumentException("modelPath must resolve to a valid property type");
            }

            descriptor._userAdded = true;
            return descriptor;
        }

        internal abstract ModelPath? CreateModelPath(string modelPath);

        internal abstract FieldDescriptorBase CreateFieldDescriptor(string fieldId, ModelPath path, string modelPath);
    }
}