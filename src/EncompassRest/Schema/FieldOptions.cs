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
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        public List<FieldOption> Options { get; set; }
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.

        /// <summary>
        /// FieldOptions RequireValueFromList
        /// </summary>
        public bool? RequireValueFromList { get; set; }
    }
}