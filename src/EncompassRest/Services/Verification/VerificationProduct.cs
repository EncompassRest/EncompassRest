using Newtonsoft.Json;

namespace EncompassRest.Services.Verification
{
    public abstract class VerificationProduct : ServiceProduct
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public VerificationPreferences Preferences { get; set; }

        internal VerificationProduct(EntityReference entityRef, ServiceOptions options)
            : base(entityRef, options, ServiceType.Verification)
        {
        }
    }
}