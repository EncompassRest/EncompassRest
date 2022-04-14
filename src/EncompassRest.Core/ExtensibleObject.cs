using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest
{
    /// <summary>
    /// Base interface that supports extension data and json serialization.
    /// </summary>
    public interface IExtensibleObject : ISerializableObject
    {
        /// <summary>
        /// Extension Data
        /// </summary>
        IDictionary<string, object?> ExtensionData { get; set; }
    }

    /// <summary>
    /// Base class that supports extension data and json serialization.
    /// </summary>
    public abstract class ExtensibleObject : SerializableObject, IExtensibleObject
    {
        private protected DirtyDictionary<string, object?>? _extensionData;

        /// <inheritdoc/>
        [JsonExtensionData]
        public IDictionary<string, object?> ExtensionData { get => GetField(ref _extensionData); set => SetField(ref _extensionData, value); }

        internal bool SetField<T>(ref DirtyDictionary<string, T>? field, IDictionary<string, T>? value)
        {
            if (!ReferenceEquals(field, value))
            {
                field = value != null ? new DirtyDictionary<string, T>(value, StringComparer.OrdinalIgnoreCase) : null;
                return true;
            }
            return false;
        }

        internal IDictionary<string, T> GetField<T>(ref DirtyDictionary<string, T>? field) => field ??= new DirtyDictionary<string, T>(StringComparer.OrdinalIgnoreCase);

        internal ExtensibleObject()
        {
        }
    }
}