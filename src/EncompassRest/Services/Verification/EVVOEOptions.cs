using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Services.Verification
{
    public sealed class EVVOEOptions : ServiceOptions
    {
        public new StringEnumValue<EVVOERequestType> RequestType => base.RequestType;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? DigiCert { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EVVOEReportOn> ReportOn { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EVVOEEmployment> Employment { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EVVOEEmployer> Employer { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationReportIdentifier { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string SalaryKey { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string EmployerName { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string EmployerCode { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string AlternateId { get; set; }

        public EVVOEOptions(EVVOERequestType requestType)
            : this(requestType.Validate(nameof(requestType)).AsString(EnumFormat.EnumMemberValue, EnumFormat.Name))
        {
        }

        public EVVOEOptions(string requestType)
            : base(requestType)
        {
        }
    }
}