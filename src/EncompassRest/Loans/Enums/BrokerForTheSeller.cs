using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// BrokerForTheSeller
    /// </summary>
    public enum BrokerForTheSeller
    {
        /// <summary>
        /// The seller
        /// </summary>
        [Description("The seller")]
        Seller = 0,
        /// <summary>
        /// You (the buyer)
        /// </summary>
        [Description("You (the buyer)")]
        Buyer = 1,
        /// <summary>
        /// You and the seller
        /// </summary>
        [Description("You and the seller")]
        BuyerAndSeller = 2
    }
}