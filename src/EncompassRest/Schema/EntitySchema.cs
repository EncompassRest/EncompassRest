using System.Collections.Generic;

namespace EncompassRest.Schema
{
    public sealed class EntitySchema
    {
        public Dictionary<string, PropertySchema> Properties { get; set; }

        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
    }
}