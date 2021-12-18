using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FhaVaLoanPurposeOfLoan
    /// </summary>
    public enum FhaVaLoanPurposeOfLoan
    {
        /// <summary>
        /// Purchase Manufactured Home &amp; Lot
        /// </summary>
        [Description("Purchase Manufactured Home & Lot")]
        PurchaseManufacturedHomeAndLot = 0,
        /// <summary>
        /// Refi. Manufactured Home / Lot Loan
        /// </summary>
        [Description("Refi. Manufactured Home / Lot Loan")]
        RefinanceManufacturedHomeLotLoan = 1,
        /// <summary>
        /// Purchase Home (Prev Occupied)
        /// </summary>
        [Description("Purchase Home (Prev Occupied)")]
        PurchaseHomePrevOccupied = 2,
        /// <summary>
        /// Refinance
        /// </summary>
        Refinance = 3,
        /// <summary>
        /// Purchase Existing Condo Unit
        /// </summary>
        [Description("Purchase Existing Condo Unit")]
        PurchaseExistingCondoUnit = 4,
        /// <summary>
        /// Purchase New Condo Unit
        /// </summary>
        [Description("Purchase New Condo Unit")]
        PurchaseNewCondoUnit = 5,
        /// <summary>
        /// Refi. Manufactured Home to Buy Lot
        /// </summary>
        [Description("Refi. Manufactured Home to Buy Lot")]
        RefinanceManufacturedHomeToBuyLot = 6,
        /// <summary>
        /// Purchase Home (Not Prev Occupied)
        /// </summary>
        [Description("Purchase Home (Not Prev Occupied)")]
        PurchaseHomeNotPrevOccupied = 7,
        /// <summary>
        /// Purchase Manufactured Home
        /// </summary>
        [Description("Purchase Manufactured Home")]
        PurchaseManufacturedHome = 8,
        /// <summary>
        /// Finance Co-op Purchase
        /// </summary>
        [Description("Finance Co-op Purchase")]
        FinanceCoOpPurchase = 9,
        /// <summary>
        /// Construct Home
        /// </summary>
        [Description("Construct Home")]
        ConstructionHome = 10,
        /// <summary>
        /// Finance Improvement
        /// </summary>
        [Description("Finance Improvement")]
        FinanceImprovement = 11
    }
}