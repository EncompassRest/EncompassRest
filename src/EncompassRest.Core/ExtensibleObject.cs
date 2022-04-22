using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest
{
    /// <summary>
    /// Base class that supports extension data and json serialization.
    /// </summary>
    public abstract class ExtensibleObject : SerializableObject
    {
        private protected DirtyDictionary<string, object?>? _extensionData;

        /// <summary>
        /// Extension Data
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object?> ExtensionData
        {
            get => _extensionData ??= new(StringComparer.OrdinalIgnoreCase);
            set
            {
                if (!ReferenceEquals(_extensionData, value))
                {
                    _extensionData = value != null ? new(value, StringComparer.OrdinalIgnoreCase) : null;
                }
            }
        }
    }
}