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
        private protected DirtyDictionary<string, object> _extensionData;
        /// <summary>
        /// Extension Data
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>(StringComparer.OrdinalIgnoreCase)); set => _extensionData = new DirtyDictionary<string, object>(value, StringComparer.OrdinalIgnoreCase); }

        internal ExtensibleObject()
        {
        }
    }
}