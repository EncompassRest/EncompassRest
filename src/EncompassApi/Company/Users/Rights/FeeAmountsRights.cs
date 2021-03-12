using Newtonsoft.Json;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// FeeAmountsRights
    /// </summary>
    public sealed class FeeAmountsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _borrowerAmountOnly;
        private DirtyValue<bool?>? _brokerLenderOtherAmounts;
        private DirtyValue<bool?>? _sellerAmountSellerCreditSellerObligated;

        /// <summary>
        /// FeeAmountsRights BorrowerAmountOnly
        /// </summary>
        public bool? BorrowerAmountOnly { get => _borrowerAmountOnly; set => SetField(ref _borrowerAmountOnly, value); }

        /// <summary>
        /// FeeAmountsRights BrokerLenderOtherAmounts
        /// </summary>
        [JsonProperty("broker,Lender,OtherAmounts")]
        public bool? BrokerLenderOtherAmounts { get => _brokerLenderOtherAmounts; set => SetField(ref _brokerLenderOtherAmounts, value); }

        /// <summary>
        /// FeeAmountsRights SellerAmountSellerCreditSellerObligated
        /// </summary>
        [JsonProperty("sellerAmount,SellerCredit,SellerObligated")]
        public bool? SellerAmountSellerCreditSellerObligated { get => _sellerAmountSellerCreditSellerObligated; set => SetField(ref _sellerAmountSellerCreditSellerObligated, value); }
    }
}