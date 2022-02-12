using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// UCDPayoffType
/// </summary>
public enum UCDPayoffType
{
    /// <summary>
    /// Borrower Estimated Total Monthly Liability Payment
    /// </summary>
    [Description("Borrower Estimated Total Monthly Liability Payment")]
    BorrowerEstimatedTotalMonthlyLiabilityPayment = 0,
    /// <summary>
    /// Collections Judgments And Liens
    /// </summary>
    [Description("Collections Judgments And Liens")]
    CollectionsJudgmentsAndLiens = 1,
    /// <summary>
    /// Deferred Student Loan
    /// </summary>
    [Description("Deferred Student Loan")]
    DeferredStudentLoan = 2,
    /// <summary>
    /// Delinquent Taxes
    /// </summary>
    [Description("Delinquent Taxes")]
    DelinquentTaxes = 3,
    /// <summary>
    /// First Position Mortgage Lien
    /// </summary>
    [Description("First Position Mortgage Lien")]
    FirstPositionMortgageLien = 4,
    /// <summary>
    /// Garnishments
    /// </summary>
    Garnishments = 5,
    /// <summary>
    /// HELOC
    /// </summary>
    HELOC = 6,
    /// <summary>
    /// Homeowners Association Lien
    /// </summary>
    [Description("Homeowners Association Lien")]
    HomeownersAssociationLien = 7,
    /// <summary>
    /// Installment
    /// </summary>
    Installment = 8,
    /// <summary>
    /// Lease Payment
    /// </summary>
    [Description("Lease Payment")]
    LeasePayment = 9,
    /// <summary>
    /// Mortgage Loan
    /// </summary>
    [Description("Mortgage Loan")]
    MortgageLoan = 10,
    /// <summary>
    /// Open 30-Day Charge Account
    /// </summary>
    [Description("Open 30-Day Charge Account")]
    Open30DayChargeAccount = 11,
    /// <summary>
    /// Other
    /// </summary>
    Other = 12,
    /// <summary>
    /// Personal Loan
    /// </summary>
    [Description("Personal Loan")]
    PersonalLoan = 13,
    /// <summary>
    /// Revolving
    /// </summary>
    Revolving = 14,
    /// <summary>
    /// Second Position Mortgage Lien
    /// </summary>
    [Description("Second Position Mortgage Lien")]
    SecondPositionMortgageLien = 15,
    /// <summary>
    /// Taxes
    /// </summary>
    Taxes = 16,
    /// <summary>
    /// Tax Lien
    /// </summary>
    [Description("Tax Lien")]
    TaxLien = 17,
    /// <summary>
    /// Third Position Mortgage Lien
    /// </summary>
    [Description("Third Position Mortgage Lien")]
    ThirdPositionMortgageLien = 18,
    /// <summary>
    /// Unsecured Home Improvement Loan Installment
    /// </summary>
    [Description("Unsecured Home Improvement Loan Installment")]
    UnsecuredHomeImprovementLoanInstallment = 19,
    /// <summary>
    /// Unsecured Home Improvement Loan Revolving
    /// </summary>
    [Description("Unsecured Home Improvement Loan Revolving")]
    UnsecuredHomeImprovementLoanRevolving = 20
}