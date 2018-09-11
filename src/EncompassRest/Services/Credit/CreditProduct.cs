using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Services.Credit
{
    public sealed class CreditProduct : ServiceProduct
    {
        public new CreditOptions Options => (CreditOptions)base.Options;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public CreditPreferences Preferences { get; set; }

        public CreditProduct(EntityReference entityRef, CreditOptions options)
            : this(entityRef, options, ServiceType.Credit.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name))
        {
        }

        public CreditProduct(EntityReference entityRef, CreditOptions options, string name)
            : base(entityRef, options, name)
        {
        }
    }
}