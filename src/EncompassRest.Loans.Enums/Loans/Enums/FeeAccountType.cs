using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// FeeAccountType
/// </summary>
public enum FeeAccountType
{
    /// <summary>
    /// Borough Property Tax
    /// </summary>
    [Description("Borough Property Tax")]
    BoroughPropertyTax = 0,
    /// <summary>
    /// City Property Tax
    /// </summary>
    [Description("City Property Tax")]
    CityPropertyTax = 1,
    /// <summary>
    /// Condominium Association Dues
    /// </summary>
    [Description("Condominium Association Dues")]
    CondominiumAssociationDues = 2,
    /// <summary>
    /// Condominium Association Special Assessment
    /// </summary>
    [Description("Condominium Association Special Assessment")]
    CondominiumAssociationSpecialAssessment = 3,
    /// <summary>
    /// Cooperative Association Dues
    /// </summary>
    [Description("Cooperative Association Dues")]
    CooperativeAssociationDues = 4,
    /// <summary>
    /// Cooperative Association Special Assessment
    /// </summary>
    [Description("Cooperative Association Special Assessment")]
    CooperativeAssociationSpecialAssessment = 5,
    /// <summary>
    /// County Property Tax
    /// </summary>
    [Description("County Property Tax")]
    CountyPropertyTax = 6,
    /// <summary>
    /// District Property Tax
    /// </summary>
    [Description("District Property Tax")]
    DistrictPropertyTax = 7,
    /// <summary>
    /// Earthquake Insurance Premium
    /// </summary>
    [Description("Earthquake Insurance Premium")]
    EarthquakeInsurancePremium = 8,
    /// <summary>
    /// Flood Insurance Premium
    /// </summary>
    [Description("Flood Insurance Premium")]
    FloodInsurancePremium = 9,
    /// <summary>
    /// Ground Rent
    /// </summary>
    [Description("Ground Rent")]
    GroundRent = 10,
    /// <summary>
    /// Hail Insurance Premium
    /// </summary>
    [Description("Hail Insurance Premium")]
    HailInsurancePremium = 11,
    /// <summary>
    /// Hazard Insurance Premium
    /// </summary>
    [Description("Hazard Insurance Premium")]
    HazardInsurancePremium = 12,
    /// <summary>
    /// Homeowners Association Dues
    /// </summary>
    [Description("Homeowners Association Dues")]
    HomeownersAssociationDues = 13,
    /// <summary>
    /// Homeowners Association Special Assessment
    /// </summary>
    [Description("Homeowners Association Special Assessment")]
    HomeownersAssociationSpecialAssessment = 14,
    /// <summary>
    /// Homeowners Insurance Premium
    /// </summary>
    [Description("Homeowners Insurance Premium")]
    HomeownersInsurancePremium = 15,
    /// <summary>
    /// Interest On Loan Assumption
    /// </summary>
    [Description("Interest On Loan Assumption")]
    InterestOnLoanAssumption = 16,
    /// <summary>
    /// Mortgage Insurance Premium
    /// </summary>
    [Description("Mortgage Insurance Premium")]
    MortgageInsurancePremium = 17,
    /// <summary>
    /// Other
    /// </summary>
    Other = 18,
    /// <summary>
    /// Past Due Property Tax
    /// </summary>
    [Description("Past Due Property Tax")]
    PastDuePropertyTax = 19,
    /// <summary>
    /// Rent From Subject Property
    /// </summary>
    [Description("Rent From Subject Property")]
    RentFromSubjectProperty = 20,
    /// <summary>
    /// State Property Tax
    /// </summary>
    [Description("State Property Tax")]
    StatePropertyTax = 21,
    /// <summary>
    /// Town Property Tax
    /// </summary>
    [Description("Town Property Tax")]
    TownPropertyTax = 22,
    /// <summary>
    /// Utilities
    /// </summary>
    Utilities = 23,
    /// <summary>
    /// Volcano Insurance Premium
    /// </summary>
    [Description("Volcano Insurance Premium")]
    VolcanoInsurancePremium = 24,
    /// <summary>
    /// Wind And Storm Insurance Premium
    /// </summary>
    [Description("Wind And Storm Insurance Premium")]
    WindAndStormInsurancePremium = 25,
    /// <summary>
    /// Collections Judgments And Liens
    /// </summary>
    [Description("Collections Judgments And Liens")]
    CollectionsJudgmentsAndLiens = 26,
    /// <summary>
    /// Delinquent Taxes
    /// </summary>
    [Description("Delinquent Taxes")]
    DelinquentTaxes = 27,
    /// <summary>
    /// HELOC
    /// </summary>
    HELOC = 28,
    /// <summary>
    /// Taxes
    /// </summary>
    Taxes = 29,
    /// <summary>
    /// Tax Lien
    /// </summary>
    [Description("Tax Lien")]
    TaxLien = 30,
    /// <summary>
    /// Third Position Mortgage Lien
    /// </summary>
    [Description("Third Position Mortgage Lien")]
    ThirdPositionMortgageLien = 31,
    /// <summary>
    /// Deferred Student Loan
    /// </summary>
    [Description("Deferred Student Loan")]
    DeferredStudentLoan = 32,
    /// <summary>
    /// Garnishments
    /// </summary>
    Garnishments = 33,
    /// <summary>
    /// Installment
    /// </summary>
    Installment = 34,
    /// <summary>
    /// Open 30 Day Charge Account
    /// </summary>
    [Description("Open 30 Day Charge Account")]
    Open30DayChargeAccount = 35,
    /// <summary>
    /// Personal Loan
    /// </summary>
    [Description("Personal Loan")]
    PersonalLoan = 36,
    /// <summary>
    /// Revolving
    /// </summary>
    Revolving = 37,
    /// <summary>
    /// Unsecured Home Improvement Loan Installment
    /// </summary>
    [Description("Unsecured Home Improvement Loan Installment")]
    UnsecuredHomeImprovementLoanInstallment = 38,
    /// <summary>
    /// Borrower Estimated Total Monthly Liability Payment
    /// </summary>
    [Description("Borrower Estimated Total Monthly Liability Payment")]
    BorrowerEstimatedTotalMonthlyLiabilityPayment = 39,
    /// <summary>
    /// First Position Mortgage Lien
    /// </summary>
    [Description("First Position Mortgage Lien")]
    FirstPositionMortgageLien = 40,
    /// <summary>
    /// Homeowners Association Lien
    /// </summary>
    [Description("Homeowners Association Lien")]
    HomeownersAssociationLien = 41,
    /// <summary>
    /// Lease Payment
    /// </summary>
    [Description("Lease Payment")]
    LeasePayment = 42,
    /// <summary>
    /// Mortgage Loan
    /// </summary>
    [Description("Mortgage Loan")]
    MortgageLoan = 43,
    /// <summary>
    /// Second Position Mortgage Lien
    /// </summary>
    [Description("Second Position Mortgage Lien")]
    SecondPositionMortgageLien = 44,
    /// <summary>
    /// Unsecured Home Improvement Loan Revolving
    /// </summary>
    [Description("Unsecured Home Improvement Loan Revolving")]
    UnsecuredHomeImprovementLoanRevolving = 45,
    /// <summary>
    /// Fuel Costs
    /// </summary>
    [Description("Fuel Costs")]
    FuelCosts = 46,
    /// <summary>
    /// Repairs
    /// </summary>
    Repairs = 47,
    /// <summary>
    /// Sellers Escrow Assumption
    /// </summary>
    [Description("Sellers Escrow Assumption")]
    SellersEscrowAssumption = 48,
    /// <summary>
    /// Sellers Mortgage Insurance Assumption
    /// </summary>
    [Description("Sellers Mortgage Insurance Assumption")]
    SellersMortgageInsuranceAssumption = 49,
    /// <summary>
    /// Tenant Security Deposit
    /// </summary>
    [Description("Tenant Security Deposit")]
    TenantSecurityDeposit = 50,
    /// <summary>
    /// Proceeds Of Subordinate Liens
    /// </summary>
    [Description("Proceeds Of Subordinate Liens")]
    ProceedsOfSubordinateLiens = 51,
    /// <summary>
    /// Gift
    /// </summary>
    Gift = 52,
    /// <summary>
    /// Grant
    /// </summary>
    Grant = 53,
    /// <summary>
    /// Rebate Credit
    /// </summary>
    [Description("Rebate Credit")]
    RebateCredit = 54,
    /// <summary>
    /// Relocation Funds
    /// </summary>
    [Description("Relocation Funds")]
    RelocationFunds = 55,
    /// <summary>
    /// Sweat Equity
    /// </summary>
    [Description("Sweat Equity")]
    SweatEquity = 56,
    /// <summary>
    /// Trade Equity
    /// </summary>
    [Description("Trade Equity")]
    TradeEquity = 57
}