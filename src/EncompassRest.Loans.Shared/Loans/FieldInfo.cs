using System.Collections.Generic;
using EncompassRest.Schema;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    internal abstract class FieldInfo
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public LoanFieldFormat? Format { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<FieldOption>? Options { get; set; }

        public string FieldId { get; }

        public string? Description { get; set; }

        protected FieldInfo(string fieldId)
        {
            FieldId = fieldId;
        }
    }
}