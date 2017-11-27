using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.Schema
{
    public sealed class FieldOptions
    {
        [JsonProperty(ItemConverterType = typeof(FieldOptionConverter))]
        public List<FieldOption> Options { get; set; }
        public bool? RequireValueFromList { get; set; }

        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
    }
}