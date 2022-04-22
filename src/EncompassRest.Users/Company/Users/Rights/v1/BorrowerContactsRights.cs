using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// BorrowerContactsRights
    /// </summary>
    public sealed class BorrowerContactsRights : ContactsClassRights
    {
        /// <summary>
        /// BorrowerContactsRights OriginateLoanOrderCreditProductPricing
        /// </summary>
        [JsonProperty("originateLoan/OrderCredit/ProductPricing")]
        [AllowNull]
        public OriginateLoanOrderCreditProductPricingRights OriginateLoanOrderCreditProductPricing { get => GetEntity<OriginateLoanOrderCreditProductPricingRights>(); set => SetEntity(value); }

        /// <summary>
        /// BorrowerContactsRights ReassignContacts
        /// </summary>
        public bool? ReassignContacts { get => GetValue<bool?>(); set => SetValue(value); }
    }
}