using System;
using EncompassApi.Extensions;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassApi.Services.Appraisal
{
    /// <summary>
    /// AppraisalOptions
    /// </summary>
    public sealed class AppraisalOptions : ServiceOptions
    {
        /// <summary>
        /// Type of appraisal service request.
        /// </summary>
        public new StringEnumValue<AppraisalRequestType> RequestType => base.RequestType;

        /// <summary>
        /// Tracking ID of an existing appraisal service order with Mercury Network.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? TrackingId { get; set; }

        /// <summary>
        /// The ID of the product to use from the Appraisal Management Company (AMC) via Mercury.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ProductId { get; set; }

        /// <summary>
        /// An Appraisal Management Company that is exposing its services via Mercury Network has the option to group its clients so that it can differentiate its product offerings/services.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientGroup { get; set; }

        /// <summary>
        /// Identifier that Mercury Network assigns to the various Appraisal Management Companies that are exposing their appraisal services via Mercury.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? AMC { get; set; }

        /// <summary>
        /// The date on which the lending organization received intent from the borrower/consumer to proceed with the loan.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? IntendToProceedReceivedDate { get; set; }

        /// <summary>
        /// The date on which all loan related documents/fees are disclosed and acknowledged by the borrower/consumer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DisclosureDate { get; set; }

        /// <summary>
        /// Whether or not consent for an early appraisal has been received by the lending organization from the borrower/consumer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? EarlyAppraisalConsent { get; set; }

        /// <summary>
        /// The loan officer who has initiated the appraisal service request.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? OrderedBy { get; set; }

        /// <summary>
        /// The lending organization's email that Mercury Network will send notifications to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? NotificationEmail { get; set; }

        /// <summary>
        /// The date by which the lending organization would like to receive a completed appraisal report.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Whether or not to place a rush order/expedited appraisal processing.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? RushOrder { get; set; }

        /// <summary>
        /// Whether or not to request a complex appraisal report with more valuation details.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? Complex { get; set; }

        /// <summary>
        /// The purpose of the loan.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<AppraisalLoanPurpose> LoanPurpose { get; set; }

        /// <summary>
        /// The specific type of loan.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<AppraisalLoanType> LoanType { get; set; }

        /// <summary>
        /// The occupancy type of the property being appraised.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<AppraisalOccupancy> Occupancy { get; set; }

        /// <summary>
        /// The type of property being appraised.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<AppraisalPropertyType> PropertyType { get; set; }

        /// <summary>
        /// The legal apparatus by which the occupant of the property rightfully resides within it
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? PropertyRights { get; set; }

        /// <summary>
        /// Contact information to be made available to the Appraisal Management Company executing the service request.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalContacts? Contacts { get; set; }

        /// <summary>
        /// Object that encapsulates payment information for the appraisal service request.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalPayment? Payment { get; set; }

        /// <summary>
        /// AppraisalOptions constructor.
        /// </summary>
        /// <param name="requestType">Type of appraisal service request.</param>
        public AppraisalOptions(AppraisalRequestType requestType)
            : this(requestType.Validate(nameof(requestType)).GetValue()!)
        {
        }

        /// <summary>
        /// AppraisalOptions constructor.
        /// </summary>
        /// <param name="requestType">Type of appraisal service request.</param>
        public AppraisalOptions(string requestType)
            : base(requestType)
        {
        }
    }
}