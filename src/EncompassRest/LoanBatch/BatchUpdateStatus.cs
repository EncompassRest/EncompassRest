using System;
using Newtonsoft.Json;

namespace EncompassRest.LoanBatch
{
    /// <summary>
    /// BatchUpdateStatus
    /// </summary>
    public sealed class BatchUpdateStatus : ExtensibleObject
    {
        /// <summary>
        /// BatchUpdateStatus Status
        /// </summary>
        [JsonRequired]
        public string Status { get; set; }

        /// <summary>
        /// BatchUpdateStatus LastModified
        /// </summary>
        [JsonRequired]
        public DateTime LastModified { get; set; }
    }
}