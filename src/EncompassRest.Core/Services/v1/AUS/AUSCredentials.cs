using Newtonsoft.Json;

namespace EncompassRest.Services.v1.AUS
{
    /// <summary>
    /// AUSCredentials
    /// </summary>
    public sealed class AUSCredentials : ServiceCredentials
    {
        /// <summary>
        /// Account username for credit provider with whom credit will be reissued as part of the underwriting service request.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? CreditProviderUserName { get; set; }

        /// <summary>
        /// Account password for credit provider with whom credit will be reissued as part of the underwriting service request.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? CreditProviderPassword { get; set; }

        /// <summary>
        /// The ID that Fannie Mae assigns to identify and authenticate your institution on their underwriting platform. To retrieve your DU institution ID, please contact Fannie Mae.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? InstitutionId { get; set; }

        /// <summary>
        /// Freddie Mac LPA password. This is a product-level password used to authenticate your entitlement to an AUS request with LPA.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? LPPassword { get; set; }

        /// <summary>
        /// Organization identifier that Freddie Mac assigns to identify and authenticate your institution on their underwriting platform. To retrieve your LP Seller Service Number, contact Freddie Mac.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? SellerServicerNumber { get; set; }

        /// <summary>
        /// Identifies the third-party originator who is requesting the underwriting service via Encompass TPO connect.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? TPOAccountIdentifier { get; set; }
    }
}