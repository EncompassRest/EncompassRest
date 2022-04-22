using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ATRQMCommon
/// </summary>
public sealed partial class ATRQMCommon : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// ATR QM - Qualification - Fees Included in Points and Fees Test - Fees Paid to Affiliates [QM.X134]
    /// </summary>
    public decimal? AffiliatesFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - APOR Max Bona Fide Discount Point % [QM.X364]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? APORMaxBonaFideDiscountPoint { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - ARM Recast Date [QM.X8]
    /// </summary>
    public DateTime? ARMRecastDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - ARM Recast Monthly Payment [QM.X9]
    /// </summary>
    public decimal? ARMRecastMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LPA - Asset Representation And Warranty Relief Eligibility Type [AUSF.X62]
    /// </summary>
    public string? AssetRepresentationAndWarrantyReliefEligibilityType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Ability-to-Repay Loan Type [QM.X23]
    /// </summary>
    public StringEnumValue<ATRLoanType> ATRLoanType { get => GetValue<StringEnumValue<ATRLoanType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Data Discrepency Resolution Comments [AUSF.X20]
    /// </summary>
    public string? AUSDataDiscrepencyResolutionComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Data Discrepency Resolution Date [AUSF.X19]
    /// </summary>
    public DateTime? AUSDataDiscrepencyResolutionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Data Discrepency Resolution User [AUSF.X21]
    /// </summary>
    public string? AUSDataDiscrepencyResolvedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Bona Fide Discount Point % [QM.X369]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BonaFideDiscountPoint { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Bona Fide Discount Point Amount [QM.X370]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BonaFideDiscountPointAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Fees from 2010 Itemization - Broker Compensation when rate was set [QM.X372]
    /// </summary>
    public bool? BrokerCompensationWhenRateSet { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Buydown Seller Paid Sec 32 Points and Fees [QM.X378]
    /// </summary>
    public decimal? BuydownSellerPaidSec32PointsFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Collateral Rep and Warranty Relief Eligibility Type [AUSF.X61]
    /// </summary>
    public StringEnumValue<CollateralRepandWarrReliefEligibilityType> CollateralRepandWarrReliefEligibilityType { get => GetValue<StringEnumValue<CollateralRepandWarrReliefEligibilityType>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Fees Included in Points and Fees Test - Compensation Paid to Brokers [QM.X133]
    /// </summary>
    public decimal? CompensationPTBFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Fees Included in Points and Fees Test - Credit Related Insurance Premium [QM.X132]
    /// </summary>
    public decimal? CreditInsPremiumFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Creditor Type [QM.X104]
    /// </summary>
    public bool? CreditorType { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Creditor Type Description [QM.X105]
    /// </summary>
    public StringEnumValue<CreditorTypeDescription> CreditorTypeDescription { get => GetValue<StringEnumValue<CreditorTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Credit Type [QM.X110]
    /// </summary>
    public bool? CreditType { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Current Qualified Mortgage Fee Threshold Amount [QM.X121]
    /// </summary>
    public decimal? CurrentQMFeeThresholdAmt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Current Qualified Mortgage Fee Threshold Percentage [QM.X122]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CurrentQMFeeThresholdPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Date of last monthly payment [QM.X4]
    /// </summary>
    public DateTime? DateOfLastMonthlyPayment { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Fees from 2010 Itemization - Discount Points Amount [QM.X111]
    /// </summary>
    public decimal? DiscountPointAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Fees Included in Points and Fees Test - Discount Point Fees [QM.X128]
    /// </summary>
    public decimal? DiscountPointFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Fees from 2010 Itemization - Discount Points % [QM.X136]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DiscountPointPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (4V) [AUSF.X55]
    /// </summary>
    public string? DocumentationGuidelineMessages4V { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (5C) [AUSF.X56]
    /// </summary>
    public string? DocumentationGuidelineMessages5C { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (8Y) [AUSF.X25]
    /// </summary>
    public string? DocumentationGuidelineMessages8Y { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CN) [AUSF.X26]
    /// </summary>
    public string? DocumentationGuidelineMessagesCN { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CP) [AUSF.X27]
    /// </summary>
    public string? DocumentationGuidelineMessagesCP { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CV) [AUSF.X28]
    /// </summary>
    public string? DocumentationGuidelineMessagesCV { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CY) [AUSF.X57]
    /// </summary>
    public string? DocumentationGuidelineMessagesCY { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CZ) [AUSF.X29]
    /// </summary>
    public string? DocumentationGuidelineMessagesCZ { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (DP) [AUSF.X58]
    /// </summary>
    public string? DocumentationGuidelineMessagesDP { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (DZ) [AUSF.X45]
    /// </summary>
    public string? DocumentationGuidelineMessagesDZ { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (E5) [AUSF.X51]
    /// </summary>
    public string? DocumentationGuidelineMessagesE5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (IM) [AUSF.X53]
    /// </summary>
    public string? DocumentationGuidelineMessagesIM { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (IQ) [AUSF.X54]
    /// </summary>
    public string? DocumentationGuidelineMessagesIQ { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (JF) [AUSF.X47]
    /// </summary>
    public string? DocumentationGuidelineMessagesJF { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QJ) [AUSF.X46]
    /// </summary>
    public string? DocumentationGuidelineMessagesQJ { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QN) [AUSF.X48]
    /// </summary>
    public string? DocumentationGuidelineMessagesQN { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QQ) [AUSF.X50]
    /// </summary>
    public string? DocumentationGuidelineMessagesQQ { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QS) [AUSF.X52]
    /// </summary>
    public string? DocumentationGuidelineMessagesQS { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (U7) [AUSF.X49]
    /// </summary>
    public string? DocumentationGuidelineMessagesU7 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X1) [AUSF.X30]
    /// </summary>
    public string? DocumentationGuidelineMessagesX1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X3) [AUSF.X31]
    /// </summary>
    public string? DocumentationGuidelineMessagesX3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X5) [AUSF.X32]
    /// </summary>
    public string? DocumentationGuidelineMessagesX5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X7) [AUSF.X33]
    /// </summary>
    public string? DocumentationGuidelineMessagesX7 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XA) [AUSF.X34]
    /// </summary>
    public string? DocumentationGuidelineMessagesXA { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XM) [AUSF.X35]
    /// </summary>
    public string? DocumentationGuidelineMessagesXM { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XP) [AUSF.X36]
    /// </summary>
    public string? DocumentationGuidelineMessagesXP { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XR) [AUSF.X37]
    /// </summary>
    public string? DocumentationGuidelineMessagesXR { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XT) [AUSF.X38]
    /// </summary>
    public string? DocumentationGuidelineMessagesXT { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (Y8) [AUSF.X39]
    /// </summary>
    public string? DocumentationGuidelineMessagesY8 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YG) [AUSF.X40]
    /// </summary>
    public string? DocumentationGuidelineMessagesYG { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YJ) [AUSF.X41]
    /// </summary>
    public string? DocumentationGuidelineMessagesYJ { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YY) [AUSF.X59]
    /// </summary>
    public string? DocumentationGuidelineMessagesYY { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YZ) [AUSF.X60]
    /// </summary>
    public string? DocumentationGuidelineMessagesYZ { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM - Non-Stardard to Standard Refinance Eligibility - This Loan may or may not be eligible for the Non-Standard to Standard Refinance exception to ATR QM [QM.X1]
    /// </summary>
    public StringEnumValue<EligibleNonStandardToStandard> EligibleNonStandardToStandard { get => GetValue<StringEnumValue<EligibleNonStandardToStandard>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Fees Included in Points and Fees Test - Finance Charge Fees [QM.X126]
    /// </summary>
    public decimal? FinanceChargeFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - First Change/Recast [QM.X7]
    /// </summary>
    public int? FirstChangeRecase { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - First Pmt Due Date after recast [QM.X15]
    /// </summary>
    public DateTime? FirstPmtDateAfterRecast { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Fully Amortized Monthly payment after Interest Only Recast [QM.X12]
    /// </summary>
    public decimal? FullPaymentAfterInterestOnly { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Fully Amortized Monthly payment after Neg. Am Recast [QM.X14]
    /// </summary>
    public decimal? FullyARMPaymentAfterNegAm { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Fully Index Rate Housing Ratio [QM.X115]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? FullyIndexRateHousingRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Fully Index Rate Max Total Payment [QM.X114]
    /// </summary>
    public decimal? FullyIndexRateMaxTotalPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Fully Index Rate Monthly Payment [QM.X373]
    /// </summary>
    public decimal? FullyIndexRateMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Fully Index Rate Total Debt Ratio [QM.X116]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? FullyIndexRateTotalDebtRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Alimony [QM.X37]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralATRStatusAlimony { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Assets [QM.X35]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralATRStatusAssets { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Child Support [QM.X38]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralATRStatusChildSupport { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Covered Loan [QM.X29]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralATRStatusCoveredLoan { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Credit History [QM.X39]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralATRStatusCreditHistory { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Debt Obligations [QM.X36]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralATRStatusDebtObligations { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Debt to Income Ratio [QM.X27]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralATRStatusDTI { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Employment [QM.X33]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralATRStatusEmployment { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Income [QM.X34]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralATRStatusIncome { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Mtg. Related Obligations [QM.X31]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralATRStatusMtgRelatedObligations { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Status of Eligibility [QM.X26]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralATRStatusOverall { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Residual Income [QM.X28]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralATRStatusResidualIncome { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Simultaneous Loan [QM.X30]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralATRStatusSimultaneousLoan { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Calculated Threshold [QM.X83]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? GSEAgencyQMCalculatedThreshold { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Alimony [QM.X79]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusAlimony { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Assets [QM.X77]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusAssets { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Balloon Payment [QM.X66]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusBalloonPayment { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Child Support [QM.X80]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusChildSupport { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Covered Loan [QM.X71]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusCoveredLoan { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Credit History [QM.X81]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusCreditHistory { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Debt Obligations [QM.X78]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusDebtObligations { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Debt to Income Ratio [QM.X69]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusDTI { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Employment [QM.X75]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusEmployment { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Income [QM.X76]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusIncome { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Interest Only [QM.X64]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusInterestOnly { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Loan Term [QM.X63]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusLoanTerm { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Mtg. Related Obligations [QM.X73]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusMtgRelatedObligations { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Negative Amortization [QM.X65]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusNegativeAmortization { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Status of Eligibility [QM.X62]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusOverall { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Points and Fees Limit [QM.X68]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusPointsFeesLimit { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Prepayment Penalty [QM.X67]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusPrepaymentPenalty { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - QM Available [QM.X380]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<GSEAgencyQMStatusQMAvailable> GSEAgencyQMStatusQMAvailable { get => GetValue<StringEnumValue<GSEAgencyQMStatusQMAvailable>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Residual Income [QM.X70]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusResidualIncome { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Safe Harbor Eligibility [QM.X82]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusSafeHarborEligibility { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Simultaneous Loan [QM.X72]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusSimultaneousLoan { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Has the Consumer had more than one 30-day Late Mortgage Payment in the last 12 Months? [QM.X3]
    /// </summary>
    public bool? Has30DayLatePayment { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATRQMCommon Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Initial Max Total Payment [QM.X113]
    /// </summary>
    public decimal? InitialMaxTotalPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Initial Rate Housing Ratio [QM.X375]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? InitialRateHousingRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Initial Rate Monthly Payment [QM.X374]
    /// </summary>
    public decimal? InitialRateMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Initial Rate Total Debt Ratio [QM.X376]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? InitialRateTotalDebtRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Interest Only Months [QM.X10]
    /// </summary>
    public int? InterestOnlyMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Interest Only Recast Date [QM.X11]
    /// </summary>
    public DateTime? InterestOnlyRecastDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Is the Consumer likely to Default at the Recast Payment Amount? [QM.X16]
    /// </summary>
    public bool? IsConsumerLiklyDefault { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Standard to Standard Refinance Eligibility - Creditor is current holder or servicer  [QM.X379]
    /// </summary>
    public bool? IsCurrentHolderOrServicer { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Is Loan Eligible for Safe Harbor? [QM.X25]
    /// </summary>
    public StringEnumValue<YesNoOrNA> IsEligibleForSafeHarbor { get => GetValue<StringEnumValue<YesNoOrNA>>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Alimony Obligations [QM.X343]
    /// </summary>
    public bool? IsEvaluatedAlimonyObligations { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Child Support Obligations [QM.X342]
    /// </summary>
    public bool? IsEvaluatedChildSupportObligations { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Credit History [QM.X347]
    /// </summary>
    public bool? IsEvaluatedCreditHistory { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Current Employment Status [QM.X344]
    /// </summary>
    public bool? IsEvaluatedCurrentEmploymentStatus { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Current or Expected Assets [QM.X346]
    /// </summary>
    public bool? IsEvaluatedCurrentExpectedAssets { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Current or Expected Income [QM.X345]
    /// </summary>
    public bool? IsEvaluatedCurrentExpectedIncome { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Debt Obligations [QM.X341]
    /// </summary>
    public bool? IsEvaluatedDebtObligations { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Debt to Income Ratio [QM.X348]
    /// </summary>
    public bool? IsEvaluatedDebtToIncomeRatio { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Monthly Covered Loan Payment [QM.X338]
    /// </summary>
    public bool? IsEvaluatedMonthlyCoveredLoanPayment { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Monthly Mortgage Related Obligations [QM.X340]
    /// </summary>
    public bool? IsEvaluatedMonthlyMortgageRelatedObligations { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Monthly Simultaneous Loan Payment [QM.X339]
    /// </summary>
    public bool? IsEvaluatedMonthlySimultaneousLoanPayment { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Residual Income [QM.X349]
    /// </summary>
    public bool? IsEvaluatedResidualIncome { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - This Loan is a Higher-Priced Covered Transaction [QM.X135]
    /// </summary>
    public StringEnumValue<IsOrIsNot> IsHigherPricedLoan { get => GetValue<StringEnumValue<IsOrIsNot>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - QM HPCT Test [QM.X382]
    /// </summary>
    public StringEnumValue<IsOrIsNot> IsQmHigherPricedLoan { get => GetValue<StringEnumValue<IsOrIsNot>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 24 [AUSF.X63]
    /// </summary>
    public string? LoanProcessingInformationCode24 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 31 [AUSF.X64]
    /// </summary>
    public string? LoanProcessingInformationCode31 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 32 [AUSF.X65]
    /// </summary>
    public string? LoanProcessingInformationCode32 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 33 [AUSF.X66]
    /// </summary>
    public string? LoanProcessingInformationCode33 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 97 [AUSF.X67]
    /// </summary>
    public string? LoanProcessingInformationCode97 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code JR [AUSF.X68]
    /// </summary>
    public string? LoanProcessingInformationCodeJr { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code JT [AUSF.X69]
    /// </summary>
    public string? LoanProcessingInformationCodeJt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (D4) [AUSF.X24]
    /// </summary>
    public string? LoanProcessingInformationD4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (GO) [AUSF.X23]
    /// </summary>
    public string? LoanProcessingInformationGO { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (HA) [AUSF.X22]
    /// </summary>
    public string? LoanProcessingInformationHA { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (LE) [AUSF.X43]
    /// </summary>
    public string? LoanProcessingInformationLE { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (LF) [AUSF.X44]
    /// </summary>
    public string? LoanProcessingInformationLF { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (MA) [AUSF.X42]
    /// </summary>
    public string? LoanProcessingInformationMA { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Loan Program [QM.X106]
    /// </summary>
    public bool? LoanProgram { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Loan Program Description [QM.X107]
    /// </summary>
    public StringEnumValue<LoanProgramDescription> LoanProgramDescription { get => GetValue<StringEnumValue<LoanProgramDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Is the Interest Rate fixed for at least 5 years? [QM.X17]
    /// </summary>
    public bool? LoanRateFixedin5Years { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Fees from 2010 Itemization - LO (Broker) Compensation [QM.X371]
    /// </summary>
    public decimal? LOBrokerCompensationAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Max Rate During First 5 Years - Housing Ratio [QM.X118]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Max5YrsHousingRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Max Rate During First 5 Years - Max P &amp; I [QM.X337]
    /// </summary>
    public decimal? Max5YrsPrincipleAndInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Max Rate During First 5 Years - Total Debt Ratio [QM.X119]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Max5YrsTotalDebtRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Max Rate During First 5 Years - Max Total Payment [QM.X117]
    /// </summary>
    public decimal? Max5YrsTotalPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Fees Included in Points and Fees Test - Max Prepayment Penalty [QM.X130]
    /// </summary>
    public decimal? MaxPrepaymentPenaltyFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Neg. Am Recast Date [QM.X13]
    /// </summary>
    public DateTime? NegAmRecastDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Does the New Monthly payment decrease by 10% or more? [QM.X18]
    /// </summary>
    public bool? PaymentDecreasedBy10Percent { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Points and Fees Threshold met? [QM.X21]
    /// </summary>
    public bool? PointsFeesThresholdMet { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Fees Included in Points and Fees Test - Prepayment Penalty Payoff [QM.X131]
    /// </summary>
    public decimal? PrepaymentPenaltyPayoffFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Prepay Penalty Percentage [QM.X112]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PrepayPenaltyPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Is the New loan likely to prevent the Consumers default? [QM.X22]
    /// </summary>
    public bool? PreventConsumersDefault { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Primary Aus Id [AUSF.X71]
    /// </summary>
    public string? PrimaryAusId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Will this refinance cause the Principal Balance to increase? [QM.X6]
    /// </summary>
    public bool? PrincipalBalanceIncreased { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Does the New Loan have deferred Principal payments? [QM.X20]
    /// </summary>
    public bool? PrincipalHasDeferred { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - QM APR % [QM.X381]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? QmAprPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Qualified Mortgage Loan Type [QM.X24]
    /// </summary>
    public StringEnumValue<QMLoanType> QMLoanType { get => GetValue<StringEnumValue<QMLoanType>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Rate Reduction Basis Points % [QM.X365]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RateReductionBasisPoints { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Rate Reduction Discount Points % [QM.X366]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RateReductionDiscountPoints { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Rate Reduction Max Bona Fide Discount Point % [QM.X367]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RateReductionMaxBonaFideDiscountPoint { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Fees Included in Points and Fees Test - Real Estate Related Fees [QM.X127]
    /// </summary>
    public decimal? RealEstateFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Difference between recast monthly payment and new payment [QM.X19]
    /// </summary>
    public decimal? RecastDifferencePayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Reg-Z Total Loan Amount [QM.X120]
    /// </summary>
    public decimal? RegZTotalLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Required Services - Lender Selected Amount [QM.X125]
    /// </summary>
    public decimal? RequiredServicesLenderSelectedAmt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Calculated Threshold [QM.X102]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? SmallCreditorQMCalculatedThreshold { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Alimony [QM.X99]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusAlimony { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Assets [QM.X97]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusAssets { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Balloon Payment [QM.X88]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusBalloonPayment { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Child Support [QM.X100]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusChildSupport { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Covered Loan [QM.X93]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusCoveredLoan { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Debt Obligations [QM.X98]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusDebtObligations { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Debt to Income Ratio [QM.X91]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusDTI { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Income [QM.X96]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusIncome { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Interest Only [QM.X86]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusInterestOnly { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Loan Term [QM.X85]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusLoanTerm { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Mtg. Related Obligations [QM.X94]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusMtgRelatedObligations { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Negative Amortization [QM.X87]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusNegativeAmortization { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Status of Eligibility [QM.X84]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusOverall { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Points and Fees Limit [QM.X90]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusPointsFeesLimit { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Prepayment Penalty [QM.X89]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusPrepaymentPenalty { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Residual Income [QM.X92]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusResidualIncome { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Safe Harbor Eligibility [QM.X101]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusSafeHarborEligibility { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Calculated Threshold [QM.X61]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? StandardQMCalculatedThreshold { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Alimony [QM.X57]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusAlimony { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Assets [QM.X55]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusAssets { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Balloon Payment [QM.X44]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusBalloonPayment { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Child Support [QM.X58]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusChildSupport { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Covered Loan [QM.X49]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusCoveredLoan { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Credit History [QM.X59]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusCreditHistory { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Debt Obligations [QM.X56]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusDebtObligations { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Debt to Income Ratio [QM.X47]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusDTI { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Employment [QM.X53]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusEmployment { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Income [QM.X54]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusIncome { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Interest Only [QM.X42]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusInterestOnly { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Loan Term [QM.X41]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusLoanTerm { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Mtg. Related Obligations [QM.X51]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusMtgRelatedObligations { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Negative Amortization [QM.X43]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusNegativeAmortization { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Status of Eligibility [QM.X40]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusOverall { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Points and Fees Limit [QM.X46]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusPointsFeesLimit { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Prepayment Penalty [QM.X45]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusPrepaymentPenalty { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Results of the QM APR to APOR Test [QM.X384]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusPriceLimit { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Residual Income [QM.X48]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusResidualIncome { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Safe Harbor Eligibility [QM.X60]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusSafeHarborEligibility { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Simultaneous Loan [QM.X50]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQMStatusSimultaneousLoan { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Starting Adjusted Rate Max Bona Fide Discount Point % [QM.X368]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? StartingAdjustedRateMaxBonaFideDiscountPoint { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Credit History [QM.X351]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StatusCreditHistory { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Simultaneous Loan [QM.X350]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StatusSimultaneousLoan { get => GetValue<StringEnumValue<ATRQMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - This Loan exceed the threshold for Qualified Mortgages [QM.X124]
    /// </summary>
    public StringEnumValue<DoesOrDoesNot2> ThresholdExceedsQM { get => GetValue<StringEnumValue<DoesOrDoesNot2>>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Title Services and Lender's Title Ins [QM.X377]
    /// </summary>
    public decimal? TitleServicesLenderTitleinsuranceFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Total Co-Mortgagor Income [QM.X153]
    /// </summary>
    public decimal? TotalCoMortgagorIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Total Income [QM.X154]
    /// </summary>
    public decimal? TotalIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Total Points and Fees Percentage Applicable Under Section 32 [QM.X123]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? TotalPointsFeesSec32Percent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Transaction is exempt from Reg. Z Ability-to-Repay requirements [QM.X103]
    /// </summary>
    public bool? TransactionExemptFromRegZ { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - UCD Requirement [AUSF.X70]
    /// </summary>
    public string? UcdRequirement { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Eligibility - Unit Count [QM.X108]
    /// </summary>
    public bool? UnitCount { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Fees Included in Points and Fees Test - Upfront PMI [QM.X129]
    /// </summary>
    public decimal? UpfrontPMIFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Qualification - Use Price-Based Limit for General QM [QM.X383]
    /// </summary>
    public bool? UsePriceBasedLimitTest { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Refinance with Original Creditor  [QM.X2]
    /// </summary>
    public bool? WithOriginalCreditor { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Written Application Date [QM.X5]
    /// </summary>
    public DateTime? WrittenApplicationDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}