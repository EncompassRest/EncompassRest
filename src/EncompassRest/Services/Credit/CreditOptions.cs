using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Services.Credit
{
    public sealed class CreditOptions : ServiceOptions
    {
        public new StringEnumValue<CreditRequestType> RequestType => base.RequestType;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? DigiCert { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<CreditReportOn> ReportOn { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<CreditReportType> ReportType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CreditReportIdentifier { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ProductCode { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeZeroForImportLiabilities { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreditBureauExperian { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreditBureauEquifax { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreditBureauTransUnion { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FicoScore { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FraudSearch { get; set; }

        public CreditOptions(CreditRequestType requestType)
            : this(requestType.Validate(nameof(requestType)).GetValue())
        {
        }

        public CreditOptions(string requestType)
            : base(requestType)
        {
        }
    }
}