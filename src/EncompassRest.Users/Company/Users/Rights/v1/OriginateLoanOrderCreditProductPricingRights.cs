using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// OriginateLoanOrderCreditProductPricingRights
    /// </summary>
    public sealed class OriginateLoanOrderCreditProductPricingRights : DirtyExtensibleObject
    {
        /// <summary>
        /// OriginateLoanOrderCreditProductPricingRights OrderCredit
        /// </summary>
        public bool? OrderCredit { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// OriginateLoanOrderCreditProductPricingRights OriginateLoan
        /// </summary>
        [AllowNull]
        public OriginateLoanRights OriginateLoan { get => GetEntity<OriginateLoanRights>(); set => SetEntity(value); }

        /// <summary>
        /// OriginateLoanOrderCreditProductPricingRights ProductAndPricing
        /// </summary>
        public bool? ProductAndPricing { get => GetValue<bool?>(); set => SetValue(value); }
    }
}