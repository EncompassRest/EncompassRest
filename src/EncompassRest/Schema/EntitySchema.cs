using System.Collections.Generic;

namespace EncompassRest.Schema
{
    public sealed class EntitySchema
    {
        public Dictionary<string, FieldSchema> Properties { get; set; }
    }
}