using System.Collections.Generic;

namespace EncompassRest.Schema
{
    public sealed class EntitySchema : ExtensibleObject
    {
        public Dictionary<string, PropertySchema> Properties { get; set; }
    }
}