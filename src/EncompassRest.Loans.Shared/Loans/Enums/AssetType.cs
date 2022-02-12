using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// AssetType
/// </summary>
public enum AssetType
{
    /// <summary>
    /// Checking Account
    /// </summary>
    [Description("Checking Account")]
    CheckingAccount = 0,
    /// <summary>
    /// Savings Account
    /// </summary>
    [Description("Savings Account")]
    SavingsAccount = 1,
    /// <summary>
    /// Mutual Funds
    /// </summary>
    [Description("Mutual Funds")]
    MutualFund = 2,
    /// <summary>
    /// Other Liquid Assets
    /// </summary>
    [Description("Other Liquid Assets")]
    OtherLiquidAssets = 3,
    /// <summary>
    /// Net Proceeds From Real Estate Assets
    /// </summary>
    [Description("Net Proceeds From Real Estate Assets")]
    PendingNetSaleProceedsFromRealEstateAssets = 4,
    /// <summary>
    /// Certificate Of Deposit
    /// </summary>
    [Description("Certificate Of Deposit")]
    CertificateOfDepositTimeDeposit = 5,
    /// <summary>
    /// Money Market Fund
    /// </summary>
    [Description("Money Market Fund")]
    MoneyMarketFund = 6,
    /// <summary>
    /// Trust Account
    /// </summary>
    [Description("Trust Account")]
    TrustAccount = 7,
    /// <summary>
    /// Retirement Funds
    /// </summary>
    [Description("Retirement Funds")]
    RetirementFund = 8,
    /// <summary>
    /// Gifts Total
    /// </summary>
    [Description("Gifts Total")]
    GiftsTotal = 9,
    /// <summary>
    /// Gifts Not Deposited
    /// </summary>
    [Description("Gifts Not Deposited")]
    GiftsNotDeposited = 10,
    /// <summary>
    /// Gift Of Equity
    /// </summary>
    [Description("Gift Of Equity")]
    GiftOfEquity = 11,
    /// <summary>
    /// Bridge Loan Not Deposited
    /// </summary>
    [Description("Bridge Loan Not Deposited")]
    BridgeLoanNotDeposited = 12,
    /// <summary>
    /// Secured Borrowed Funds Not Deposited
    /// </summary>
    [Description("Secured Borrowed Funds Not Deposited")]
    SecuredBorrowedFundsNotDeposited = 13,
    /// <summary>
    /// Cash Deposit On Sales Contract
    /// </summary>
    [Description("Cash Deposit On Sales Contract")]
    CashDepositOnSalesContract = 14,
    /// <summary>
    /// Cash On Hand
    /// </summary>
    [Description("Cash On Hand")]
    CashOnHand = 15,
    /// <summary>
    /// Net Worth Of Business Owned
    /// </summary>
    [Description("Net Worth Of Business Owned")]
    NetWorthOfBusinessOwned = 16,
    /// <summary>
    /// Other Non Liquid Assets
    /// </summary>
    [Description("Other Non Liquid Assets")]
    OtherNonLiquidAssets = 17,
    /// <summary>
    /// Net Equity
    /// </summary>
    [Description("Net Equity")]
    NetEquity = 18,
    /// <summary>
    /// Life Insurance
    /// </summary>
    [Description("Life Insurance")]
    LifeInsurance = 19,
    /// <summary>
    /// Automobile
    /// </summary>
    Automobile = 20,
    /// <summary>
    /// Stock
    /// </summary>
    Stock = 21,
    /// <summary>
    /// Other
    /// </summary>
    Other = 22,
    /// <summary>
    /// Stock Options
    /// </summary>
    [Description("Stock Options")]
    StockOptions = 23,
    /// <summary>
    /// Bond
    /// </summary>
    Bond = 24,
    /// <summary>
    /// Individual Development Account
    /// </summary>
    [Description("Individual Development Account")]
    IndividualDevelopmentAccount = 25
}