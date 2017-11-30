using System;
using Newtonsoft.Json;

namespace EncompassRest.LoanBatch
{
    public sealed class BatchUpdateStatus : ExtensibleObject
    {
        [JsonRequired]
        public string Status { get; set; }

        [JsonRequired]
        public DateTime LastModified { get; set; }
    }
}