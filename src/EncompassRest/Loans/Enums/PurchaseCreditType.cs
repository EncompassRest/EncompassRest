using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PurchaseCreditType
    /// </summary>
    public enum PurchaseCreditType
    {
        /// <summary>
        /// Relocation Funds (FNMA/FRE)
        /// </summary>
        [Description("Relocation Funds (FNMA/FRE)")]
        RelocationFunds = 0,
        /// <summary>
        /// Employer Asst. Housing (FNMA/FRE)
        /// </summary>
        [Description("Employer Asst. Housing (FNMA/FRE)")]
        EmployerAssistedHousing = 1,
        /// <summary>
        /// Lease Purchase Fund (FNMA/FRE)
        /// </summary>
        [Description("Lease Purchase Fund (FNMA/FRE)")]
        LeasePurchaseFund = 2,
        /// <summary>
        /// Cash Deposit On Sales Contract
        /// </summary>
        [Description("Cash Deposit On Sales Contract")]
        CashDepositOnSalesContract = 3,
        /// <summary>
        /// Seller Credit - Retired
        /// </summary>
        [Description("Seller Credit - Retired")]
        SellerCredit = 4,
        /// <summary>
        /// Lender Credit - Retired
        /// </summary>
        [Description("Lender Credit - Retired")]
        LenderCredit = 5,
        /// <summary>
        /// Borrower Paid Fees (FNMA Retired)
        /// </summary>
        [Description("Borrower Paid Fees (FNMA Retired)")]
        BorrowerPaidFees = 6,
        /// <summary>
        /// Sweat Equity (FNMA/FRE)
        /// </summary>
        [Description("Sweat Equity (FNMA/FRE)")]
        SweatEquity = 7,
        /// <summary>
        /// Other (FNMA/FRE)
        /// </summary>
        [Description("Other (FNMA/FRE)")]
        Other = 8,
        /// <summary>
        /// Trade Equity From Property Swap (FNMA/FRE)
        /// </summary>
        [Description("Trade Equity From Property Swap (FNMA/FRE)")]
        TradeEquityFromPropertySwap = 9,
        /// <summary>
        /// MI Premium Refund - Retired
        /// </summary>
        [Description("MI Premium Refund - Retired")]
        MIPremiumRefund = 10,
        /// <summary>
        /// Lot Equity (FNMA/FRE)
        /// </summary>
        [Description("Lot Equity (FNMA/FRE)")]
        LotEquity = 11
    }
}