using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.Schema
{
    public sealed class FieldOptions : ExtensibleObject
    {
        [JsonProperty(ItemConverterType = typeof(FieldOptionConverter))]
        public List<FieldOption> Options { get; set; }

        public bool? RequireValueFromList { get; set; }
    }
}