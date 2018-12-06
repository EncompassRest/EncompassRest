using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.Schema
{
    /// <summary>
    /// FieldOptions
    /// </summary>
    public sealed class FieldOptions : ExtensibleObject
    {
        /// <summary>
        /// FieldOptions Options
        /// </summary>
        [JsonProperty(ItemConverterType = typeof(FieldOptionConverter))]
        public List<FieldOption> Options { get; set; }

        /// <summary>
        /// FieldOptions RequireValueFromList
        /// </summary>
        public bool? RequireValueFromList { get; set; }
    }
}