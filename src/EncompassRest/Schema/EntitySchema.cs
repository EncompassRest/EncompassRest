using System.Collections.Generic;

namespace EncompassRest.Schema
{
    public sealed class EntitySchema
    {
        public Dictionary<string, PropertySchema> Properties { get; set; }
    }
}