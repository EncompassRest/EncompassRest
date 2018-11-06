using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Schema
{
    /// <summary>
    /// LoanSchema
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class LoanSchema : ExtensibleObject
    {
        /// <summary>
        /// LoanSchema SchemaVersion
        /// </summary>
        public string SchemaVersion { get; set; }

        /// <summary>
        /// LoanSchema EntityTypes
        /// </summary>
        public Dictionary<string, EntitySchema> EntityTypes { get; set; }
    }
}