using Newtonsoft.Json;

namespace EncompassRest.Services.Verification
{
    /// <summary>
    /// VerificationProduct
    /// </summary>
    public abstract class VerificationProduct : ServiceProduct
    {
        /// <summary>
        /// VerificationProduct Preferences.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public VerificationPreferences Preferences { get; set; }

        /// <summary>
        /// The associated branch ID of the lender.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string BranchId { get; set; }

        internal VerificationProduct(EntityReference entityRef, ServiceOptions options)
            : this(entityRef, options, ServiceType.Verification.GetValue())
        {
        }

        internal VerificationProduct(EntityReference entityRef, ServiceOptions options, string name)
            : base(entityRef, options, name)
        {
        }
    }
}