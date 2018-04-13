using System.Collections.Generic;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Services.AUS
{
    public sealed class AUSOptions : ServiceOptions
    {
        public new StringEnumValue<AUSRequestType> RequestType => base.RequestType;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string AUSReportIdentifier { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CreditProviderCode { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IList<AUSOrderCreditDetail> OrderCreditDetails { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<AUSProductDescription> ProductDescription { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string AUSReportLoanIdentifier { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CreditProviderAffiliateCode { get; set; }

        public AUSOptions(AUSRequestType requestType)
            : this(requestType.Validate(nameof(requestType)).AsString(EnumFormat.EnumMemberValue, EnumFormat.Name))
        {
        }

        public AUSOptions(string requestType)
            : base(requestType)
        {
        }
    }
}