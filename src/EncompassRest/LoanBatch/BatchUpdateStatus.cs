using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EncompassRest.LoanBatch
{
    public sealed class BatchUpdateStatus
    {
        [JsonRequired]
        public string Status { get; set; }

        [JsonRequired]
        public DateTime LastModified { get; set; }

        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
    }
}