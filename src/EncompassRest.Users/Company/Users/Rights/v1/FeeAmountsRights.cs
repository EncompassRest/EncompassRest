using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// FeeAmountsRights
    /// </summary>
    public sealed class FeeAmountsRights : ParentAccessRights
    {
        /// <summary>
        /// FeeAmountsRights BorrowerAmountOnly
        /// </summary>
        public bool? BorrowerAmountOnly { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// FeeAmountsRights BrokerLenderOtherAmounts
        /// </summary>
        [JsonProperty("broker,Lender,OtherAmounts")]
        public bool? BrokerLenderOtherAmounts { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// FeeAmountsRights SellerAmountSellerCreditSellerObligated
        /// </summary>
        [JsonProperty("sellerAmount,SellerCredit,SellerObligated")]
        public bool? SellerAmountSellerCreditSellerObligated { get => GetValue<bool?>(); set => SetValue(value); }
    }
}