using Newtonsoft.Json;

namespace EncompassApi.Services.Appraisal
{
    /// <summary>
    /// AppraisalPayment
    /// </summary>
    public sealed class AppraisalPayment : ExtensibleObject
    {
        /// <summary>
        /// The method of payment for the service.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<AppraisalPaymentType> PaymentType { get; set; }

        /// <summary>
        /// Account holder first name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? AccountHolderFirstName { get; set; }

        /// <summary>
        /// Account holder middle name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? AccountHolderMiddleName { get; set; }

        /// <summary>
        /// Account holder last name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? AccountHolderLastName { get; set; }

        /// <summary>
        /// Email where receipt of payment is to be sent.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailToSendReceipt { get; set; }

        /// <summary>
        /// Billing address for payment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? BillingAddress { get; set; }

        /// <summary>
        /// City under billing address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? City { get; set; }

        /// <summary>
        /// State under billing address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<State> State { get; set; }

        /// <summary>
        /// Zip code under billing address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Zip { get; set; }
    }
}