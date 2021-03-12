using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// BorrowerContactsRights
    /// </summary>
    public sealed class BorrowerContactsRights : ContactsClassRights
    {
        private OriginateLoanOrderCreditProductPricingRights? _originateLoanOrderCreditProductPricing;
        private DirtyValue<bool?>? _reassignContacts;

        /// <summary>
        /// BorrowerContactsRights OriginateLoanOrderCreditProductPricing
        /// </summary>
        [JsonProperty("originateLoan/OrderCredit/ProductPricing")]
        [AllowNull]
        public OriginateLoanOrderCreditProductPricingRights OriginateLoanOrderCreditProductPricing { get => GetField(ref _originateLoanOrderCreditProductPricing); set => SetField(ref _originateLoanOrderCreditProductPricing, value); }

        /// <summary>
        /// BorrowerContactsRights ReassignContacts
        /// </summary>
        public bool? ReassignContacts { get => _reassignContacts; set => SetField(ref _reassignContacts, value); }
    }
}