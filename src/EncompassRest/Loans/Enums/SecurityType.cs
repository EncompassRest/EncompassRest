using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// SecurityType
    /// </summary>
    public enum SecurityType
    {
        /// <summary>
        /// The goods or property being purchased
        /// </summary>
        [Description("The goods or property being purchased")]
        TheGoodsOrPropertyBeingPurchased = 0,
        /// <summary>
        /// Real property you already own
        /// </summary>
        [Description("Real property you already own")]
        RealPropertyYouAlreadyOwn = 1
    }
}