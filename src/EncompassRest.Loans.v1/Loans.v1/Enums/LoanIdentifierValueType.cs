using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// LoanIdentifierValueType
    /// </summary>
    public enum LoanIdentifierValueType
    {
        /// <summary>
        /// BuyUp BuyDown
        /// </summary>
        [Description("BuyUp BuyDown")]
        BuyUpBuyDown = 0,
        /// <summary>
        /// Whole Loan
        /// </summary>
        [Description("Whole Loan")]
        WholeLoan = 1,
        /// <summary>
        /// Guaranty Fee
        /// </summary>
        [Description("Guaranty Fee")]
        GuarantyFee = 2
    }
}