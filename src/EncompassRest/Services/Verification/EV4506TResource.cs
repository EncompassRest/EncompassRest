using Newtonsoft.Json;

namespace EncompassRest.Services.Verification
{
    public sealed class EV4506TResource
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string AttachmentId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TResourceType> Type { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }
}