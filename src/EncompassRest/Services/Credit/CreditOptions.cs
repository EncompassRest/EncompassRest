using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Services.Credit
{
    /// <summary>
    /// CreditOptions
    /// </summary>
    public sealed class CreditOptions : ServiceOptions
    {
        /// <summary>
        /// Determines how to authenticate to CoreLogic Credco.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? DigiCert { get; set; }

        /// <summary>
        /// Indicates the request type being submitted.
        /// </summary>
        public new StringEnumValue<CreditRequestType> RequestType => base.RequestType;

        /// <summary>
        /// CreditOptions ReportOn
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<CreditReportOn> ReportOn { get; set; }

        /// <summary>
        /// Type of credit report.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<CreditReportType> ReportType { get; set; }

        /// <summary>
        /// Identifier assigned by CoreLogic Credco. It is returned in the response and is required to reissue or update a report.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CreditReportIdentifier { get; set; }

        /// <summary>
        /// Comment or note to add to the request.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        /// <summary>
        /// Whether to exclude zero liability balances from future credit report import files.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeZeroForImportLiabilities { get; set; }

        /// <summary>
        /// A value of true indicates the request is submitted to Experian.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreditBureauExperian { get; set; }

        /// <summary>
        /// A value of true indicates the request is submitted to Equifax.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreditBureauEquifax { get; set; }

        /// <summary>
        /// A value of true indicates the request is submitted to TransUnion.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreditBureauTransUnion { get; set; }

        /// <summary>
        /// Indicates whether to retrieve the credit score from the partner.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FicoScore { get; set; }

        /// <summary>
        /// Indicates whether to initiate a fraud search while retrieving the credit score.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FraudSearch { get; set; }

        /// <summary>
        /// CreditOptions ProductCode
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ProductCode { get; set; }

        /// <summary>
        /// CreditOptions constructor.
        /// </summary>
        /// <param name="requestType">Indicates the request type being submitted.</param>
        public CreditOptions(CreditRequestType requestType)
            : this(requestType.Validate(nameof(requestType)).GetValue())
        {
        }

        /// <summary>
        /// CreditOptions constructor.
        /// </summary>
        /// <param name="requestType">Indicates the request type being submitted.</param>
        public CreditOptions(string requestType)
            : base(requestType)
        {
        }
    }
}