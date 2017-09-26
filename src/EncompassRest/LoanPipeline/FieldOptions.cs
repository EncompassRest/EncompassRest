using System.Collections.Generic;
using EncompassRest.Schema;
using Newtonsoft.Json;

namespace EncompassRest.LoanPipeline
{
    public sealed class FieldOptions
    {
        [JsonProperty(ItemConverterType = typeof(FieldOptionConverter))]
        public List<FieldOption> Options { get; set; }
        public bool? RequireValueFromList { get; set; }
    }
}