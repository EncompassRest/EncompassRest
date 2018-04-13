using Newtonsoft.Json;

namespace EncompassRest.Services.Credit
{
    public sealed class CreditProduct : ServiceProduct
    {
        public new CreditOptions Options => (CreditOptions)base.Options;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public CreditPreferences Preferences { get; set; }

        public CreditProduct(EntityReference entityRef, CreditOptions options)
            : base(entityRef, options, ServiceType.Credit)
        {
        }
    }
}