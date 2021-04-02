using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// OriginateLoanOrderCreditProductPricingRights
    /// </summary>
    public sealed class OriginateLoanOrderCreditProductPricingRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _orderCredit;
        private OriginateLoanRights? _originateLoan;
        private DirtyValue<bool?>? _productAndPricing;

        /// <summary>
        /// OriginateLoanOrderCreditProductPricingRights OrderCredit
        /// </summary>
        public bool? OrderCredit { get => _orderCredit; set => SetField(ref _orderCredit, value); }

        /// <summary>
        /// OriginateLoanOrderCreditProductPricingRights OriginateLoan
        /// </summary>
        [AllowNull]
        public OriginateLoanRights OriginateLoan { get => GetField(ref _originateLoan); set => SetField(ref _originateLoan, value); }

        /// <summary>
        /// OriginateLoanOrderCreditProductPricingRights ProductAndPricing
        /// </summary>
        public bool? ProductAndPricing { get => _productAndPricing; set => SetField(ref _productAndPricing, value); }
    }
}