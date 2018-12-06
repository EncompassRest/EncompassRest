using System.Collections.Generic;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Services.AUS
{
    /// <summary>
    /// AUSOptions
    /// </summary>
    public sealed class AUSOptions : ServiceOptions
    {
        /// <summary>
        /// The type of underwriting request to place with the AUS provider.
        /// </summary>
        public new StringEnumValue<AUSRequestType> RequestType => base.RequestType;

        /// <summary>
        /// The identifier for an existing request on the AUS provider's platform.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string AUSReportIdentifier { get; set; }

        /// <summary>
        /// AUS provider's identifier for the credit service provider that processed the credit service request(s) for the subject loan.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CreditProviderCode { get; set; }

        /// <summary>
        /// Object array that encapsulates details of the various credit service requests that were placed during the life of the loan (up to the point where underwriting is being requested).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IList<AUSOrderCreditDetail> OrderCreditDetails { get; set; }

        /// <summary>
        /// The underwriting product request.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<AUSProductDescription> ProductDescription { get; set; }

        /// <summary>
        /// Identifier for a loan being referenced in an existing AUS request on Freddie Mac's platform.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string AUSReportLoanIdentifier { get; set; }

        /// <summary>
        /// This is an identifier for an affiliate of a credit provider on Freddie Mac's platform.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CreditProviderAffiliateCode { get; set; }

        /// <summary>
        /// AUSOptions constructor.
        /// </summary>
        /// <param name="requestType">The type of underwriting request to place with the AUS provider.</param>
        public AUSOptions(AUSRequestType requestType)
            : this(requestType.Validate(nameof(requestType)).GetValue())
        {
        }

        /// <summary>
        /// AUSOptions constructor.
        /// </summary>
        /// <param name="requestType">The type of underwriting request to place with the AUS provider.</param>
        public AUSOptions(string requestType)
            : base(requestType)
        {
        }
    }
}