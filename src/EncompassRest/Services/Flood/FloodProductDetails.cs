using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Services.Flood
{
    /// <summary>
    /// FloodProductDetails
    /// </summary>
    public sealed class FloodProductDetails : ExtensibleObject
    {
        private StringEnumValue<FloodProductName> _name;

        /// <summary>
        /// The name of the flood product being ordered.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<FloodProductName> Name
        {
            get => _name;
            set
            {
                _name = value;
                Id = value.EnumValue?.AsString(EnumFormat.DecimalValue) ?? Id;
            }
        }

        /// <summary>
        /// ServiceLink product identifier for the specific Flood product being requested.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }
    }
}