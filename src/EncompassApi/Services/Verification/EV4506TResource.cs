using Newtonsoft.Json;

namespace EncompassApi.Services.Verification
{
    /// <summary>
    /// EV4506TResource
    /// </summary>
    public sealed class EV4506TResource : ExtensibleObject
    {
        /// <summary>
        /// EV4506TResource AttachmentId
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? AttachmentId { get; set; }

        /// <summary>
        /// EV4506TResource Type
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TResourceType> Type { get; set; }

        /// <summary>
        /// EV4506TResource Description
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; }
    }
}