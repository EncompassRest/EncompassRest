using System.Collections.Generic;

namespace EncompassRest.Schema
{
    /// <summary>
    /// EntitySchema
    /// </summary>
    public sealed class EntitySchema : ExtensibleObject
    {
        /// <summary>
        /// EntitySchema Properties
        /// </summary>
        public Dictionary<string, PropertySchema> Properties { get; set; }
    }
}