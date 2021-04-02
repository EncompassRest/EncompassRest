using System.Collections.Generic;
using EncompassApi.Extensions;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassApi.Services.Verification
{
    /// <summary>
    /// EV4506TOptions
    /// </summary>
    public sealed class EV4506TOptions : ServiceOptions
    {
        /// <summary>
        /// Determines how to authenticate to the vendor.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? DigiCert { get; set; }

        /// <summary>
        /// Indicates the type of order.
        /// </summary>
        public new StringEnumValue<EV4506TRequestType> RequestType => base.RequestType;

        /// <summary>
        /// Indicates type of request.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TRequestOption> RequestOption { get; set; }

        /// <summary>
        /// Indicates whose tax returns you are verifying.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TTaxReturnFor> TaxReturnFor { get; set; }

        /// <summary>
        /// Borrower's monthly income. Required field if choosing a borrower/joint tax return.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BorrowerMonthlyIncome { get; set; }

        /// <summary>
        /// Co-borrower's monthly income. Required field if choosing a coBorrower/joint tax return.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CoBorrowerMonthlyIncome { get; set; }

        /// <summary>
        /// EV4506TOptions CalculateIncomeVariance
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public EV4506TCalculateIncomeVariance? CalculateIncomeVariance { get; set; }

        /// <summary>
        /// The income variance percentage, as a number between 1 and 20.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? CalculateIncomeVariancePercentage { get; set; }

        /// <summary>
        /// EV4506TOptions ComparisonMethod
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TComparisonMethod> ComparisonMethod { get; set; }

        /// <summary>
        /// Additional contact email, used as an endpoint for receiving documents.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? AdditionalEmailId { get; set; }

        /// <summary>
        /// Employer Identification Number. Required if ordering a business product (Form 1065 or Form 1120).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? EinNumber { get; set; }

        /// <summary>
        /// Field used to identify which corporation the borrower works for, if they work for one.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? CorporationName { get; set; }

        /// <summary>
        /// Street address of the borrower's company. Required if ordering a business product (Form 1065 or Form 1120).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Address { get; set; }

        /// <summary>
        /// State of the borrower's company. Required if ordering a business product (Form 1065 or Form 1120).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<State> State { get; set; }

        /// <summary>
        /// City of the borrower's company. Required if ordering a business product (Form 1065 or Form 1120).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? City { get; set; }

        /// <summary>
        /// ZIP code of the borrower's company. Required if ordering a business product (Form 1065 or Form 1120).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Zip { get; set; }

        /// <summary>
        /// EV4506TOptions Product_1040
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TOrderProduct> Product_1040 { get; set; }

        /// <summary>
        /// EV4506TOptions TranscriptType_1040
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TTranscriptType> TranscriptType_1040 { get; set; }

        /// <summary>
        /// EV4506TOptions Product_1065
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TOrderProduct> Product_1065 { get; set; }

        /// <summary>
        /// EV4506TOptions TranscriptType_1065
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TTranscriptType> TranscriptType_1065 { get; set; }

        /// <summary>
        /// EV4506TOptions Product_1120
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TOrderProduct> Product_1120 { get; set; }

        /// <summary>
        /// EV4506TOptions TranscriptType_1120
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TTranscriptType> TranscriptType_1120 { get; set; }

        /// <summary>
        /// EV4506TOptions Product_W2
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TOrderProduct> Product_W2 { get; set; }

        /// <summary>
        /// EV4506TOptions Product_1099
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EV4506TOrderProduct> Product_1099 { get; set; }

        /// <summary>
        /// Comma-separated string indicating which years of transcript are being ordered.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? TranscriptYear { get; set; }

        /// <summary>
        /// EV4506TOptions Resources
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IList<EV4506TResource>? Resources { get; set; }

        /// <summary>
        /// EV4506TOptions constructor.
        /// </summary>
        /// <param name="requestType">Indicates the type of order.</param>
        public EV4506TOptions(EV4506TRequestType requestType)
            : this(requestType.Validate(nameof(requestType)).GetValue()!)
        {
        }

        /// <summary>
        /// EV4506TOptions constructor.
        /// </summary>
        /// <param name="requestType">Indicates the type of order.</param>
        public EV4506TOptions(string requestType)
            : base(requestType)
        {
        }
    }
}