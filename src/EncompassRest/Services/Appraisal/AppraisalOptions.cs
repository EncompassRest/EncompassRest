using System;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Services.Appraisal
{
    public sealed class AppraisalOptions : ServiceOptions
    {
        public new StringEnumValue<AppraisalRequestType> RequestType => base.RequestType;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string TrackingId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ClientGroup { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string AMC { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? IntendToProceedReceivedDate { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DisclosureDate { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? EarlyAppraisalConsent { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string OrderedBy { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationEmail { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DueDate { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? RushOrder { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? Complex { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<AppraisalLoanPurpose> LoanPurpose { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<AppraisalLoanType> LoanType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<AppraisalOccupancy> Occupancy { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<AppraisalPropertyType> PropertyType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string PropertyRights { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalContacts Contacts { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalPayment Payment { get; set; }

        public AppraisalOptions(AppraisalRequestType requestType)
            : this(requestType.Validate(nameof(requestType)).GetValue())
        {
        }

        public AppraisalOptions(string requestType)
            : base(requestType)
        {
        }
    }
}