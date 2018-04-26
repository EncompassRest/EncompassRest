using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Services.Flood
{
    public sealed class FloodOptions : ServiceOptions
    {
        public new StringEnumValue<FloodRequestType> RequestType => base.RequestType;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FloodProductDetails ProductDetails { get; set; }

        public FloodOptions(FloodRequestType requestType)
            : this(requestType.Validate(nameof(requestType)).AsString(EnumFormat.EnumMemberValue, EnumFormat.Name))
        {
        }

        public FloodOptions(string requestType)
            : base(requestType)
        {
        }
    }
}