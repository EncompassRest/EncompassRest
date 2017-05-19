using System;
using Newtonsoft.Json;

namespace EncompassRest.LoanBatch
{
    public sealed class BatchUpdateStatus
    {
        [JsonRequired]
        public string Status { get; set; }

        [JsonRequired]
        public DateTime LastModified { get; set; }
    }
}