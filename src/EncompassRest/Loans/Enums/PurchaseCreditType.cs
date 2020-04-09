using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PurchaseCreditType
    /// </summary>
    public enum PurchaseCreditType
    {
        /// <summary>
        /// Relocation Funds
        /// </summary>
        [Description("Relocation Funds")]
        RelocationFunds = 0,
        /// <summary>
        /// Employer Asst. Housing
        /// </summary>
        [Description("Employer Asst. Housing")]
        EmployerAssistedHousing = 1,
        /// <summary>
        /// Lease Purchase Fund
        /// </summary>
        [Description("Lease Purchase Fund")]
        LeasePurchaseFund = 2,
        /// <summary>
        /// Cash Deposit on sales contract
        /// </summary>
        [Description("Cash Deposit on sales contract")]
        CashDepositOnSalesContract = 3,
        /// <summary>
        /// Seller Credit
        /// </summary>
        [Description("Seller Credit")]
        SellerCredit = 4,
        /// <summary>
        /// Lender Credit
        /// </summary>
        [Description("Lender Credit")]
        LenderCredit = 5,
        /// <summary>
        /// Borrower Paid Fees
        /// </summary>
        [Description("Borrower Paid Fees")]
        BorrowerPaidFees = 6,
        /// <summary>
        /// Sweat Equity
        /// </summary>
        [Description("Sweat Equity")]
        SweatEquity = 7,
        /// <summary>
        /// Other
        /// </summary>
        Other = 8,
        /// <summary>
        /// Trade Equity From Property Swap
        /// </summary>
        [Description("Trade Equity From Property Swap")]
        TradeEquityFromPropertySwap = 9,
        /// <summary>
        /// MI Premium Refund
        /// </summary>
        [Description("MI Premium Refund")]
        MIPremiumRefund = 10,
        /// <summary>
        /// Lot Equity
        /// </summary>
        [Description("Lot Equity")]
        LotEquity = 11
    }
}