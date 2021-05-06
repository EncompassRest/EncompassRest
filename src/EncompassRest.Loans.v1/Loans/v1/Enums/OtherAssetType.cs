using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// OtherAssetType
    /// </summary>
    public enum OtherAssetType
    {
        /// <summary>
        /// Earnest Money
        /// </summary>
        [Description("Earnest Money")]
        EarnestMoney = 0,
        /// <summary>
        /// Employer Assistance
        /// </summary>
        [Description("Employer Assistance")]
        EmployerAssistedHousing = 1,
        /// <summary>
        /// Pending Net Sale Proceeds From Real Estate Assets
        /// </summary>
        [Description("Pending Net Sale Proceeds From Real Estate Assets")]
        PendingNetSaleProceedsFromRealEstateAssets = 2,
        /// <summary>
        /// Proceeds From Sale Of Non Real Estate Asset
        /// </summary>
        [Description("Proceeds From Sale Of Non Real Estate Asset")]
        ProceedsFromSaleOfNonRealEstateAsset = 3,
        /// <summary>
        /// Proceeds From Secured Loan
        /// </summary>
        [Description("Proceeds From Secured Loan")]
        ProceedsFromSecuredLoan = 4,
        /// <summary>
        /// Proceeds From Unsecured Loan
        /// </summary>
        [Description("Proceeds From Unsecured Loan")]
        ProceedsFromUnsecuredLoan = 5,
        /// <summary>
        /// Rent Credit
        /// </summary>
        [Description("Rent Credit")]
        LeasePurchaseCredit = 6,
        /// <summary>
        /// Other
        /// </summary>
        Other = 7,
        /// <summary>
        /// Sweat Equity
        /// </summary>
        [Description("Sweat Equity")]
        SweatEquity = 8,
        /// <summary>
        /// Trade Equity From Property Swap
        /// </summary>
        [Description("Trade Equity From Property Swap")]
        TradeEquityFromPropertySwap = 9,
        /// <summary>
        /// Annuity (FHA/VA)
        /// </summary>
        [Description("Annuity (FHA/VA)")]
        Annuity = 10,
        /// <summary>
        /// Automobile (FHA/VA)
        /// </summary>
        [Description("Automobile (FHA/VA)")]
        Automobile = 11,
        /// <summary>
        /// Boat (FHA/VA)
        /// </summary>
        [Description("Boat (FHA/VA)")]
        Boat = 12,
        /// <summary>
        /// Borrower Primary Home (FHA/VA)
        /// </summary>
        [Description("Borrower Primary Home (FHA/VA)")]
        BorrowerPrimaryHome = 13,
        /// <summary>
        /// Bridge Loan Not Deposited (FHA/VA)
        /// </summary>
        [Description("Bridge Loan Not Deposited (FHA/VA)")]
        BridgeLoanNotDeposited = 14,
        /// <summary>
        /// Cash On Hand
        /// </summary>
        [Description("Cash On Hand")]
        CashOnHand = 15,
        /// <summary>
        /// Lease Purchase Fund
        /// </summary>
        [Description("Lease Purchase Fund")]
        LeasePurchaseFund = 16,
        /// <summary>
        /// Net Worth Of Business Owned (FHA/VA)
        /// </summary>
        [Description("Net Worth Of Business Owned (FHA/VA)")]
        NetWorthOfBusinessOwned = 17,
        /// <summary>
        /// Recreational Vehicle (FHA/VA)
        /// </summary>
        [Description("Recreational Vehicle (FHA/VA)")]
        RecreationalVehicle = 18,
        /// <summary>
        /// Savings Bond (FHA/VA)
        /// </summary>
        [Description("Savings Bond (FHA/VA)")]
        SavingsBond = 19,
        /// <summary>
        /// Severance Package (FHA/VA)
        /// </summary>
        [Description("Severance Package (FHA/VA)")]
        SeverancePackage = 20,
        /// <summary>
        /// Lot Equity
        /// </summary>
        [Description("Lot Equity")]
        LotEquity = 21,
        /// <summary>
        /// Relocation Funds
        /// </summary>
        [Description("Relocation Funds")]
        RelocationFunds = 22
    }
}