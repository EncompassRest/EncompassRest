using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Schema
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy), NamingStrategyParameters = new object[] { true, false })]
    public sealed class LoanSchema
    {
        public string SchemaVersion { get; set; }
        public Dictionary<string, EntitySchema> EntityTypes { get; set; }
    }
}