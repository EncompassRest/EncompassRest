using Newtonsoft.Json;

namespace EncompassRest.Services.Appraisal
{
    public sealed class AppraisalPayment : SerializableObject
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<AppraisalPaymentType> PaymentType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string AccountHolderFirstName { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string AccountHolderMiddleName { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string AccountHolderLastName { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string EmailToSendReceipt { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAddress { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<State> State { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }
    }
}