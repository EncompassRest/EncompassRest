using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ConstructionManagement
/// </summary>
public sealed partial class ConstructionManagement : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Construction Management Project Data - Additional Disbursements Conditions [CONST.X56]
    /// </summary>
    public string? AdditionalDisbursementsConditions { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Architect's Certificate Date [CONST.X34]
    /// </summary>
    public DateTime? ArchitectsCertificateDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Architect's Certificate Indicator [CONST.X33]
    /// </summary>
    public bool? ArchitectsCertificateIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// As Completed Appraised Value [CONST.X59]
    /// </summary>
    public decimal? AsCompletedAppraisedValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// As Completed Purchase Price [CONST.X58]
    /// </summary>
    public decimal? AsCompletedPurchasePrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Budget Date [CONST.X30]
    /// </summary>
    public DateTime? BudgetDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Budget Indicator [CONST.X29]
    /// </summary>
    public bool? BudgetIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Commitment Expiration Date [CONST.X12]
    /// </summary>
    public DateTime? CommitmentExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Commitment Letter Date [CONST.X11]
    /// </summary>
    public DateTime? CommitmentLetterDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Loan Info - Const. Completion Date [CONST.X3]
    /// </summary>
    public DateTime? ConstCompletionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Loan Info - Construction Only Amortization Type [CONST.X13]
    /// </summary>
    public StringEnumValue<ConstOnlyAmortizationType> ConstOnlyAmortizationType { get => GetValue<StringEnumValue<ConstOnlyAmortizationType>>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Construction Contract Indicator [CONST.X27]
    /// </summary>
    public bool? ConstructionContractIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Construction Contract Issued Date [CONST.X10]
    /// </summary>
    public DateTime? ConstructionContractIssuedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Construction Contract Received Date [CONST.X28]
    /// </summary>
    public DateTime? ConstructionContractReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction period included in the Loan Terms Flag [CONST.X1]
    /// </summary>
    public bool? ConstructionPeriodIncludedInLoanTermFlag { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Contractor's Agreement Date [CONST.X32]
    /// </summary>
    public DateTime? ContractorsAgreementDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Contractor's Agreement Indicator [CONST.X31]
    /// </summary>
    public bool? ContractorsAgreementIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Cost of Improvements Included in Liabilities [CONST.X73]
    /// </summary>
    public bool? CostImprovementsIncluded { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Environmental Assessment Date [CONST.X36]
    /// </summary>
    public DateTime? EnvironmentalAssessmentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Environmental Assessment Indicator [CONST.X35]
    /// </summary>
    public bool? EnvironmentalAssessmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Flood Hazard Determination Date [CONST.X48]
    /// </summary>
    public DateTime? FloodHazardDeterminationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Flood Hazard Determination Indicator [CONST.X47]
    /// </summary>
    public bool? FloodHazardDeterminationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Future Advance Period (mths) [CONST.X54]
    /// </summary>
    public int? FutureAdvancePeriod { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Loan Info - Holdback $ [CONST.X8]
    /// </summary>
    public decimal? HoldbackAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Loan Info - Holdback % [CONST.X7]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HoldbackPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Lien Agent (North Carolina) Date [CONST.X46]
    /// </summary>
    public DateTime? LienAgentNorthCarolinaDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Lien Agent (North Carolina) Indicator [CONST.X45]
    /// </summary>
    public bool? LienAgentNorthCarolinaIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - List of Construction Agreements Date [CONST.X50]
    /// </summary>
    public DateTime? ListOfConstructionAgreementsDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - List of Construction Agreements Indicator [CONST.X49]
    /// </summary>
    public bool? ListOfConstructionAgreementsIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Loan Info - Max LTV % [CONST.X5]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MaxLtvPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Minimum days between disbursements [CONST.X55]
    /// </summary>
    public int? MinimumDaysBetweenDisbursements { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Other Date [CONST.X52]
    /// </summary>
    public DateTime? OtherDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Other Description [CONST.X53]
    /// </summary>
    public string? OtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Other Indicator [CONST.X51]
    /// </summary>
    public bool? OtherIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Partial Prepayments Election [CONST.X57]
    /// </summary>
    public StringEnumValue<PartialPrepaymentsElection> PartialPrepaymentsElection { get => GetValue<StringEnumValue<PartialPrepaymentsElection>>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Payment and Performance Bonds Date [CONST.X44]
    /// </summary>
    public DateTime? PaymentAndPerformanceBondsDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Payment and Performance Bonds Indicator [CONST.X43]
    /// </summary>
    public bool? PaymentAndPerformanceBondsIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Percolation Test Date [CONST.X42]
    /// </summary>
    public DateTime? PercolationTestDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Percolation Test Indicator [CONST.X41]
    /// </summary>
    public bool? PercolationTestIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Permits Date [CONST.X22]
    /// </summary>
    public DateTime? PermitsDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Permits Indicator [CONST.X21]
    /// </summary>
    public bool? PermitsIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Plans and Specifications Date [CONST.X26]
    /// </summary>
    public DateTime? PlansAndSpecificationsDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Plans and Specifications Indicator [CONST.X25]
    /// </summary>
    public bool? PlansAndSpecificationsIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Loan Info - Project Delay Surcharge % [CONST.X9]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ProjectDelaySurchargePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Return Lender's copy of this commitment within days [CONST.X14]
    /// </summary>
    public int? ReturnLendersCopyCommitmentDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Loan Info - Secured by Separate Property [CONST.X2]
    /// </summary>
    public bool? SecuredBySeparateProperty { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Soil Report Date [CONST.X38]
    /// </summary>
    public DateTime? SoilReportDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Soil Report Indicator [CONST.X37]
    /// </summary>
    public bool? SoilReportIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Survey Date [CONST.X20]
    /// </summary>
    public DateTime? SurveyDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Survey Indicator [CONST.X19]
    /// </summary>
    public bool? SurveyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Take-out Commitment Date [CONST.X16]
    /// </summary>
    public DateTime? TakeOutCommitmentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Take-out Commitment Indicator [CONST.X15]
    /// </summary>
    public bool? TakeOutCommitmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Take-Out Commitment Letter Date [CONST.X67]
    /// </summary>
    public DateTime? TakeOutCommitmentIssuedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Take-Out Lender Address [CONST.X63]
    /// </summary>
    public string? TakeOutLenderAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Take-Out Lender City [CONST.X64]
    /// </summary>
    public string? TakeOutLenderCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Take-Out Lender Contact Name [CONST.X68]
    /// </summary>
    public string? TakeOutLenderContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Take-Out Lender Contact Title [CONST.X69]
    /// </summary>
    public string? TakeOutLenderContactTitle { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Take-Out Lender Email [CONST.X71]
    /// </summary>
    public string? TakeOutLenderEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Take-Out Lender Fax [CONST.X72]
    /// </summary>
    public string? TakeOutLenderFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Take-Out Lender License # [CONST.X62]
    /// </summary>
    public string? TakeOutLenderLicenseNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Take-Out Lender Name [CONST.X60]
    /// </summary>
    public string? TakeOutLenderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Take-Out Lender NMLS # [CONST.X61]
    /// </summary>
    public string? TakeOutLenderNmlsNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Take-Out Lender Phone [CONST.X70]
    /// </summary>
    public string? TakeOutLenderPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Take-Out Lender State [CONST.X65]
    /// </summary>
    public string? TakeOutLenderState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Take-Out Lender Zipcode [CONST.X66]
    /// </summary>
    public string? TakeOutLenderZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Title Insurance Date [CONST.X18]
    /// </summary>
    public DateTime? TitleInsuranceDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Title Insurance Indicator [CONST.X17]
    /// </summary>
    public bool? TitleInsuranceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Utility Letters Date [CONST.X24]
    /// </summary>
    public DateTime? UtilityLettersDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Utility Letters Indicator [CONST.X23]
    /// </summary>
    public bool? UtilityLettersIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Water Test Date [CONST.X40]
    /// </summary>
    public DateTime? WaterTestDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management Project Data - Water Test Indicator [CONST.X39]
    /// </summary>
    public bool? WaterTestIndicator { get => GetValue<bool?>(); set => SetValue(value); }
}