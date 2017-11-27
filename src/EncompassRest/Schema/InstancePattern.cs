using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace EncompassRest.Schema
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InstancePattern
    {
        public int IndexOffset { get; set; }
        public string IndexToken { get; set; }
        public int MaxIndex { get; set; }
        public Dictionary<string, string> Match { get; set; }

        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
    }
}