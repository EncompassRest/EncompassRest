using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.LoanPipeline
{
    /// <summary>
    /// LoanPipelineData
    /// </summary>
    public sealed class LoanPipelineData : ExtensibleObject
    {
        private Dictionary<string, string> _fields;

        /// <summary>
        /// LoanPipelineData LoanGuid
        /// </summary>
        [JsonRequired]
        public string LoanGuid { get; set; }

        /// <summary>
        /// LoanPipelineData Fields
        /// </summary>
        public Dictionary<string, string> Fields
        {
            get => _fields;
            set => _fields = value?.Comparer == StringComparer.OrdinalIgnoreCase ? value : new Dictionary<string, string>(value, StringComparer.OrdinalIgnoreCase);
        }
    }
}