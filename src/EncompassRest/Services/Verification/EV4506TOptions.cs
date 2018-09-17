using System.Collections.Generic;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Services.Verification
{
    public sealed class EV4506TOptions : ServiceOptions
    {
        public new StringEnumValue<EV4506TRequestType> RequestType => base.RequestType;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? DigiCert { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TRequestOption> RequestOption { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TTaxReturnFor> TaxReturnFor { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BorrowerMonthlyIncome { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CoBorrowerMonthlyIncome { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public EV4506TCalculateIncomeVariance? CalculateIncomeVariance { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? CalculateIncomeVariancePercentage { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TComparisonMethod> ComparisonMethod { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalEmailId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string EinNumber { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CorporationName { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TOrderProduct> Product_1040 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TTranscriptType> TranscriptType_1040 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TOrderProduct> Product_1065 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TTranscriptType> TranscriptType_1065 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TOrderProduct> Product_1120 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TTranscriptType> TranscriptType_1120 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TOrderProduct> Product_W2 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TOrderProduct> Product_1099 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string TranscriptYear { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IList<EV4506TResource> Resources { get; set; }

        public EV4506TOptions(EV4506TRequestType requestType)
            : this(requestType.Validate(nameof(requestType)).GetValue())
        {
        }

        public EV4506TOptions(string requestType)
            : base(requestType)
        {
        }
    }
}