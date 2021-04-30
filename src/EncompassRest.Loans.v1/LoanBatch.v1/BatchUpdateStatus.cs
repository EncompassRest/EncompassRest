using System;
using Newtonsoft.Json;

namespace EncompassRest.LoanBatch.v1
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
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        public string Status { get; set; }
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.

        /// <summary>
        /// BatchUpdateStatus LastModified
        /// </summary>
        [JsonRequired]
        public DateTime LastModified { get; set; }
    }
}