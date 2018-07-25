using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Services.Flood
{
    public sealed class FloodProductDetails : SerializableObject
    {
        private StringEnumValue<FloodProductName> _name;

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

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }
    }
}