using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace EncompassRest.Schema
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InstancePattern : ExtensibleObject
    {
        public int IndexOffset { get; set; }

        public string IndexToken { get; set; }

        public int MaxIndex { get; set; }

        public Dictionary<string, string> Match { get; set; }
    }
}