using Newtonsoft.Json;

namespace EncompassRest.Services.AUS
{
    /// <summary>
    /// AUSPreferences
    /// </summary>
    public sealed class AUSPreferences : SerializableObject
    {
        /// <summary>
        /// Whether or not user to import the underwriting conditions specified by Fannie Mae in its underwriting report returned in their response.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? ImportConditions { get; set; }

        /// <summary>
        /// Specific type of underwriting conditions to import.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<AUSConditionType> ConditionType { get; set; }
    }
}