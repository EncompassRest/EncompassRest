using Newtonsoft.Json;

namespace EncompassRest.Services.AUS
{
    /// <summary>
    /// AUSOrderCreditDetail
    /// </summary>
    public sealed class AUSOrderCreditDetail : ExtensibleObject
    {
        /// <summary>
        /// Reference to the borrower pair within the loan in whose context this credit service request was placed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// This is the identifier for the credit service request on the credit providers system. It is returned by the provider in the response of the credit service request.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CreditReportIdentifier { get; set; }
    }
}