using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassApi.LoanPipeline
{
    /// <summary>
    /// LoanPipelineData
    /// </summary>
    public sealed class LoanPipelineData : ExtensibleObject
    {
        private Dictionary<string, string?>? _fields;

        /// <summary>
        /// LoanPipelineData LoanGuid
        /// </summary>
        [JsonRequired]
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        public string LoanGuid { get; set; }
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.

        /// <summary>
        /// LoanPipelineData Fields
        /// </summary>
        public Dictionary<string, string?>? Fields
        {
            get => _fields;
            set => _fields = value?.Comparer == StringComparer.OrdinalIgnoreCase ? value : new Dictionary<string, string?>(value, StringComparer.OrdinalIgnoreCase);
        }
    }
}