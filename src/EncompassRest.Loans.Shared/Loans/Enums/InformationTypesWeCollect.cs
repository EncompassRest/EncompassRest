using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// InformationTypesWeCollect
/// </summary>
public enum InformationTypesWeCollect
{
    /// <summary>
    /// Account balances
    /// </summary>
    [EnumMember(Value = "Account balances")]
    AccountBalances = 0,
    /// <summary>
    /// Account transactions
    /// </summary>
    [EnumMember(Value = "Account transactions")]
    AccountTransactions = 1,
    /// <summary>
    /// Assets
    /// </summary>
    Assets = 2,
    /// <summary>
    /// Checking account information
    /// </summary>
    [EnumMember(Value = "Checking account information")]
    CheckingAccountInformation = 3,
    /// <summary>
    /// Credit-based insurance scores
    /// </summary>
    [EnumMember(Value = "Credit-based insurance scores")]
    CreditBasedInsuranceScores = 4,
    /// <summary>
    /// Credit card or other debt
    /// </summary>
    [EnumMember(Value = "Credit card or other debt")]
    CreditCardOrOtherDebt = 5,
    /// <summary>
    /// Credit history
    /// </summary>
    [EnumMember(Value = "Credit history")]
    CreditHistory = 6,
    /// <summary>
    /// Credit scores
    /// </summary>
    [EnumMember(Value = "Credit scores")]
    CreditScores = 7,
    /// <summary>
    /// Employment information
    /// </summary>
    [EnumMember(Value = "Employment information")]
    EmploymentInformation = 8,
    /// <summary>
    /// Income
    /// </summary>
    Income = 9,
    /// <summary>
    /// Insurance claim
    /// </summary>
    [Description("Insurance claim")]
    [EnumMember(Value = "Insurance claim history")]
    InsuranceClaimHistory = 10,
    /// <summary>
    /// Investment experience
    /// </summary>
    [EnumMember(Value = "Investment experience")]
    InvestmentExperience = 11,
    /// <summary>
    /// Medical information
    /// </summary>
    [EnumMember(Value = "Medical information")]
    MedicalInformation = 12,
    /// <summary>
    /// Medical-related debts
    /// </summary>
    [EnumMember(Value = "Medical-related debts")]
    MedicalRelatedDebts = 13,
    /// <summary>
    /// Mortgage rates and payments
    /// </summary>
    [EnumMember(Value = "Mortgage rates and payments")]
    MortgageRatesAndPayments = 14,
    /// <summary>
    /// Overdraft history
    /// </summary>
    [EnumMember(Value = "Overdraft history")]
    OverdraftHistory = 15,
    /// <summary>
    /// Payment history
    /// </summary>
    [EnumMember(Value = "Payment history")]
    PaymentHistory = 16,
    /// <summary>
    /// Purchase history
    /// </summary>
    [EnumMember(Value = "Purchase history")]
    PurchaseHistory = 17,
    /// <summary>
    /// Retirement assets
    /// </summary>
    [EnumMember(Value = "Retirement assets")]
    RetirementAssets = 18,
    /// <summary>
    /// Risk tolerance
    /// </summary>
    [EnumMember(Value = "Risk tolerance")]
    RiskTolerance = 19,
    /// <summary>
    /// Transaction history
    /// </summary>
    [EnumMember(Value = "Transaction history")]
    TransactionHistory = 20,
    /// <summary>
    /// Transaction or loss history
    /// </summary>
    [EnumMember(Value = "Transaction or loss history")]
    TransactionOrLossHistory = 21,
    /// <summary>
    /// Wire transfer instructions
    /// </summary>
    [EnumMember(Value = "Wire transfer instructions")]
    WireTransferInstructions = 22
}