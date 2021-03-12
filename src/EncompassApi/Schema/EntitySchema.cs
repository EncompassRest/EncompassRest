using System.Collections.Generic;

namespace EncompassApi.Schema
{
    /// <summary>
    /// EntitySchema
    /// </summary>
    public sealed class EntitySchema : ExtensibleObject
    {
        /// <summary>
        /// EntitySchema Properties
        /// </summary>
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        public Dictionary<string, PropertySchema> Properties { get; set; }
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
    }
}