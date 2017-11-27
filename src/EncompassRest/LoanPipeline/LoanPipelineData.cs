using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.LoanPipeline
{
    public sealed class LoanPipelineData
    {
        private Dictionary<string, string> _fields;

        [JsonRequired]
        public string LoanGuid { get; set; }

        public Dictionary<string, string> Fields
        {
            get => _fields;
            set => _fields = value?.Comparer == StringComparer.OrdinalIgnoreCase ? value : new Dictionary<string, string>(value, StringComparer.OrdinalIgnoreCase);
        }

        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
    }
}