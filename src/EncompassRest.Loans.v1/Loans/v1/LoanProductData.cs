using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LoanProductData
/// </summary>
public sealed partial class LoanProductData : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// HELOC Agreement Amends and Restates Indicator [4671]
    /// </summary>
    public bool? AgreementAmmendsRestatesIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Amount Apply To Down Payment [4493]
    /// </summary>
    public decimal? AmountApplyToDownPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Annual Fee [1891]
    /// </summary>
    public decimal? AnnualFeeNeededAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ARM Apply Life Cap Low [ARM.ApplyLfCpLow]
    /// </summary>
    public bool? ApplyLifeCapLowIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Disclosure Type [1959]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"UST1YW\":\"1 Year UST CM (weekly)\",\"UST3YW\":\"3 Year UST CM (weekly)\",\"UST5YW\":\"5 Year UST CM (weekly)\",\"UST7YW\":\"7 Year UST CM (weekly)\",\"UST10YW\":\"10 Year UST CM (weekly)\",\"UST20YW\":\"20 Year UST CM (weekly)\",\"UST30YW\":\"30 Year UST CM (weekly)\",\"UST1Y\":\"1 Year US Treasury CM (daily)\",\"UST3Y\":\"3 Year US Treasury CM (daily)\",\"UST5Y\":\"5 Year US Treasury CM (daily)\",\"UST7Y\":\"7 Year US Treasury CM (daily)\",\"UST10Y\":\"10 Year US Treasury CM (daily)\",\"UST20Y\":\"20 Year US Treasury CM (daily)\",\"UST30Y\":\"30 Year US Treasury CM (daily)\",\"3MoCD(12MoAvg)\":\"3-MonthCD (12-Month Avg)\",\"6MCDW\":\"6 Month CD (Secondary Market) weekly\",\"UST6M\":\"6 Month US Treasury CM (daily)\",\"FRBCommercial3M\":\"90 Day AA Commercial Paper Rates (Nonfinancial)\",\"WSJPrime\":\"WSJ Prime Rate (daily)\",\"WSJPrimeWkly\":\"WSJ Prime Rate (weekly)\"}")]
    public StringEnumValue<IndexMargin> ArmDisclosureType { get => GetValue<StringEnumValue<IndexMargin>>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae ARM Index Type [MORNET.X70]
    /// </summary>
    public StringEnumValue<ArmIndexType> ArmIndexType { get => GetValue<StringEnumValue<ArmIndexType>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Amort Type Balloon [1659]
    /// </summary>
    public bool? BalloonIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Term Due In [325]
    /// </summary>
    public int? BalloonLoanMaturityTermMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Est Closing Date [4114]
    /// </summary>
    public DateTime? BorrowerEstimatedClosingDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Branch Location NMLS ID [NMLS.X9]
    /// </summary>
    public string? BranchLocationNmlsId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Branch Manager NMLS ID [NMLS.X8]
    /// </summary>
    public string? BranchManagerNmlsId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProductData Buydowns
    /// </summary>
    [AllowNull]
    public IList<Buydown> Buydowns { get => GetList<Buydown>(); set => SetList(value); }

    /// <summary>
    /// Freddie Mac Lender Rate Adj Convertible [1290]
    /// </summary>
    public bool? ConvertibleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Discounted [1967]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"is\":\"Yes\",\"is not\":\"No\"}")]
    public StringEnumValue<IsOrIsNot> Discounted { get => GetValue<StringEnumValue<IsOrIsNot>>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Discounted Rate [1968]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DiscountedRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Draw Period Mos [1889]
    /// </summary>
    public int? DrawPeriodMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Escrow Waived [MORNET.X15]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Escrow will be waived\"}")]
    public bool? EscrowWaiverIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Exclude this Loan from the NMLS Report [NMLS.X15]
    /// </summary>
    public bool? ExcludeLoanFromNMLSReportIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ARM Floor Basis [ARM.FlrBasis]
    /// </summary>
    public StringEnumValue<FloorBasis> FloorBasis { get => GetValue<StringEnumValue<FloorBasis>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Floor Rate [1699]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? FloorPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Floor Rate - Display field with KBYO rounding rules [KBYO.XD1699]
    /// </summary>
    public string? FloorPercentUI { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ARM Floor Verbiage Type [ARM.FlrVerbgTyp]
    /// </summary>
    public StringEnumValue<FloorVerbiage> FloorVerbiage { get => GetValue<StringEnumValue<FloorVerbiage>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Amort Type ARM Descr [995]
    /// </summary>
    public string? FnmProductPlanIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender ARM Index [CASASRN.X135]
    /// </summary>
    public StringEnumValue<FreddieMacArmIndexType> FreddieMacArmIndexType { get => GetValue<StringEnumValue<FreddieMacArmIndexType>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Offering Identifier [CASASRN.X163]
    /// </summary>
    public StringEnumValue<FreOfferingIdentifier> FreOfferingIdentifier { get => GetValue<StringEnumValue<FreOfferingIdentifier>>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Prepymt Penalty Type of Prepay 1 [1946]
    /// </summary>
    public StringEnumValue<FullPrepaymentPenaltyOptionType> FullPrepaymentPenaltyOptionType { get => GetValue<StringEnumValue<FullPrepaymentPenaltyOptionType>>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Project Classification [1012]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"A_IIICondominium\":\"Freddie Mac: Streamlined Review\",\"B_IICondominium\":\"Freddie Mac: Established Project\",\"C_ICondominium\":\"Freddie Mac: New Project\",\"DetachedProject\":\"Freddie Mac: Detached Project\",\"2To4UnitProject\":\"Freddie Mac: 2-To-4-Unit Project\",\"ReciprocalReview\":\"Freddie Mac: Reciprocal Review\",\"E_PUD\":\"Fannie Mae: E Established PUD Project\",\"F_PUD\":\"Fannie Mae: F New PUD Project\",\"P_LimitedReviewNew\":\"Fannie Mae: P Limited Review - New Condo Project\",\"Q_LimitedReviewEst\":\"Fannie Mae: Q Limited Review - Established Condo Project\",\"R_ExpeditedNew\":\"Fannie Mae: R Full Review - New Condo Project\",\"S_ExpeditedEst\":\"Fannie Mae: S Full Review - Established Condo Project\",\"T_FannieMaeReview\":\"Fannie Mae: T Fannie Mae Review through PERS - Condo Project\",\"U_FHAapproved\":\"Fannie Mae: U FHA-approved Condo Project\",\"V_NoReviewSiteCondo\":\"Fannie Mae: V Condo Project Review Waived\",\"OneCooperative\":\"Other: One Cooperative\",\"TwoCooperative\":\"Other: Two Cooperative\",\"TCooperative\":\"Other: T Cooperative\",\"T_PUD\":\"Other: T/PUD\",\"III PUD\":\"Other: PUD\",\"V_RefiPlus\":\"Other: V/Refi Plus\",\"Approved FHA/VA Condominium Project Or Spot Loan\":\"Other: Approved FHA/VA Condominium Project Or Spot Loan\",\"G_NotInAProjectOrDevelopment\":\"Other: G/Not in a Project or Development\"}")]
    public StringEnumValue<ProjectType> GseProjectClassificationType { get => GetValue<StringEnumValue<ProjectType>>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Type Fannie Mae [1041]
    /// </summary>
    public StringEnumValue<PropertyType> GsePropertyType { get => GetValue<StringEnumValue<PropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Prepay Penalty Mths Hard Prepayment Period [3536]
    /// </summary>
    public int? HardPrepaymentPenaltyMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Auto Debit Discount Percent [4587]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocAutoDebitDiscount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Auto Debit Feature [4586]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Auto Debit Feature\"}")]
    public bool? HelocAutoDebitFeature { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Calculation Sign [4466]
    /// </summary>
    public StringEnumValue<HelocCalcSign> HelocCalcSign { get => GetValue<StringEnumValue<HelocCalcSign>>(); set => SetValue(value); }

    /// <summary>
    /// Heloc Collect Interim Interest Indicator [4665]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Collect Interim Interest\"}")]
    public bool? HelocCollectInterimInterestIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Daily Periodic Rate Percent [4549]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? HelocDailyPeriodicRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Draw Extension Months [4567]
    /// </summary>
    public int? HelocDrawExtensionMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Draw Fraction Balance Dividend [4564]
    /// </summary>
    public int? HelocDrawFractionBalancedividend { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Draw Fraction Balance Divisor [4565]
    /// </summary>
    public int? HelocDrawFractionBalancedivisor { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Draw Payment Basis [4559]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Rate\"}")]
    public bool? HelocDrawPaymentBasis { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Draw Payment Basis Type [4560]
    /// </summary>
    public StringEnumValue<PaymentBasisType> HelocDrawPaymentBasisType { get => GetValue<StringEnumValue<PaymentBasisType>>(); set => SetValue(value); }

    /// <summary>
    /// Heloc Escrow Account Indicator [4556]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Escrow Account\"}")]
    public bool? HelocEscrowAccountIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Force Minimum Payment [4472]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Force Minimum Payment\"}")]
    public bool? HelocForceMinimumPayment { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Fraction Balance Dividend [4469]
    /// </summary>
    public int? HelocFractionBalancedividend { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Fraction Balance Divisor [4470]
    /// </summary>
    public int? HelocFractionBalancedivisor { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProductData HelocHistoricalIndexYearSettings
    /// </summary>
    [AllowNull]
    public IList<HelocHistoricalIndexYearSetting> HelocHistoricalIndexYearSettings { get => GetList<HelocHistoricalIndexYearSetting>(); set => SetList(value); }

    /// <summary>
    /// HELOC Historical Table Day Index [HHI.X1]
    /// </summary>
    public int? HelocHistoricalTableDayIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Historical Table Default Margin [HHI.X3]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocHistoricalTableDefaultMargin { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Historical Table Month Index [HHI.X2]
    /// </summary>
    public int? HelocHistoricalTableMonthIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Historical Table Name [4629]
    /// </summary>
    public string? HelocHistoricalTableName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Heloc Initial Balance Used [4484]
    /// </summary>
    public StringEnumValue<HelocBalance> HelocInitialBalanceUsed { get => GetValue<StringEnumValue<HelocBalance>>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Initial Calculation Sign [4477]
    /// </summary>
    public StringEnumValue<HelocCalcSign> HelocInitialCalcSign { get => GetValue<StringEnumValue<HelocCalcSign>>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Initial Force Minimum Payment [4483]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Force Minimum Payment\"}")]
    public bool? HelocInitialForceMinimumPayment { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Initial Fraction Balance Dividend [4480]
    /// </summary>
    public int? HelocInitialFractionBalancedividend { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Initial Fraction Balance Divisor [4481]
    /// </summary>
    public int? HelocInitialFractionBalancedivisor { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Initial Payment Basis [4475]
    /// </summary>
    public StringEnumValue<HelocPaymentBasis> HelocInitialPaymentBasis { get => GetValue<StringEnumValue<HelocPaymentBasis>>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Initial Payment Basis Type [4530]
    /// </summary>
    public StringEnumValue<PaymentBasisType> HelocInitialPaymentBasisType { get => GetValue<StringEnumValue<PaymentBasisType>>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Initial Percent [4478]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocInitialPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Initial Percentage of Balance [4482]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocInitialPercentageofBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Heloc initial P &amp; I [4479]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"P & I\"}")]
    public bool? HelocInitialPI { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Initial Rate [4476]
    /// </summary>
    public StringEnumValue<HelocInitialRate> HelocInitialRate { get => GetValue<StringEnumValue<HelocInitialRate>>(); set => SetValue(value); }

    /// <summary>
    /// Heloc Initial Term [4485]
    /// </summary>
    public int? HelocInitialTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Initial Mortgage Number of Days [4491]
    /// </summary>
    public StringEnumValue<PerDiemCalculationMethodType> HelocInitPerDiemCalculationMethodType { get => GetValue<StringEnumValue<PerDiemCalculationMethodType>>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Installment Loan APR [4585]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocInstallmentLoanAPR { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Installment Loan Fincance Charge [4581]
    /// </summary>
    public decimal? HelocInstallmentLoanFinanceCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Installment Loan Margin [4582]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocInstallmentLoanMargin { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Installment Loan Max APR [4583]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocInstallmentLoanMaxAPR { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Installment Loan Min APR [4584]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocInstallmentLoanMinAPR { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Heloc Installment Loan Option Indicator [4557]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Installment Loan Option\"}")]
    public bool? HelocInstallmentLoanOptionIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Installment Loan Term Year From [4579]
    /// </summary>
    public int? HelocInstallmentLoanTermYearFrom { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Installment Loan Term Year To [4580]
    /// </summary>
    public int? HelocInstallmentLoanTermYearTo { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Heloc Interest Only [4468]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Interest Only\"}")]
    public bool? HelocInterestOnly { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Lien Position [4494]
    /// </summary>
    public StringEnumValue<LienPosition> HELOCLienPosition { get => GetValue<StringEnumValue<LienPosition>>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Maximum Open Installment Loans [4578]
    /// </summary>
    public int? HelocMaxOpenInstallmentLoans { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Minimum Initial Advance Percent [4553]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocMinimumInitialAdvancePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Heloc Minimum Initial Advance Required Indicator [4552]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Minimum Initial Advance Required\"}")]
    public bool? HelocMinimumInitialAdvanceRequiredIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Minimum Subsequent Advance Amount [4554]
    /// </summary>
    public decimal? HelocMinimumSubsequentAdvanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Minimum Subsequent Advance Percent [4555]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocMinimumSubsequentAdvancePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Minimum Installment Loan Amount [4577]
    /// </summary>
    public decimal? HelocMinInstallmentLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Monthly Periodic Rate Percent [4550]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? HelocMonthlyPeriodicRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Heloc New Financing Not Linked Credit Limit  [4490]
    /// </summary>
    public decimal? HelocNewFinancingNotLinkedCreditLimit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Heloc New Financing Not Linked Draw Amount [4489]
    /// </summary>
    public decimal? HelocNewFinancingNotLinkedDrawAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Paper Billing Fee [4588]
    /// </summary>
    public decimal? HelocPaperBillingFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Payment Basis [4464]
    /// </summary>
    public StringEnumValue<HelocPaymentBasis> HelocPaymentBasis { get => GetValue<StringEnumValue<HelocPaymentBasis>>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Payment Basis Type [4531]
    /// </summary>
    public StringEnumValue<PaymentBasisType> HelocPaymentBasisType { get => GetValue<StringEnumValue<PaymentBasisType>>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Percent [4467]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Percentage of Balance [4471]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocPercentageofBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Periodic Rate Indicator [4551]
    /// </summary>
    public StringEnumValue<HelocPeriodicRateIndicator> HelocPeriodicRateIndicator { get => GetValue<StringEnumValue<HelocPeriodicRateIndicator>>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Period Template Name [1985]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? HelocPeriodTemplateName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Photocopy Fee [4589]
    /// </summary>
    public decimal? HelocPhotocopyFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Heloc Property Insurance Indicator [4661]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Borrower can obtain property insurance from or through Lender\"}")]
    public bool? HelocPropertyInsuranceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Qualifying Balance [4473]
    /// </summary>
    public StringEnumValue<HelocBalance> HelocQualifyingBalance { get => GetValue<StringEnumValue<HelocBalance>>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Qualifying Term [4474]
    /// </summary>
    public int? HelocQualifyingTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Rate [4465]
    /// </summary>
    public StringEnumValue<HelocRate> HelocRate { get => GetValue<StringEnumValue<HelocRate>>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Refundable Fee [4591]
    /// </summary>
    public string? HelocRefundableFee { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Repayment Basis [4568]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Rate\"}")]
    public bool? HelocRepaymentBasis { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Repayment Basis Type [4569]
    /// </summary>
    public StringEnumValue<PaymentBasisType> HelocRepaymentBasisType { get => GetValue<StringEnumValue<PaymentBasisType>>(); set => SetValue(value); }

    /// <summary>
    /// LoanProductData HelocRepaymentDrawPeriods
    /// </summary>
    [AllowNull]
    public IList<HelocRepaymentDrawPeriod> HelocRepaymentDrawPeriods { get => GetList<HelocRepaymentDrawPeriod>(); set => SetList(value); }

    /// <summary>
    /// HELOC Repayment Fraction Balance Dividend [4574]
    /// </summary>
    public int? HelocRepaymentFractionBalancedividend { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Repayment Fraction Balance Divisor [4575]
    /// </summary>
    public int? HelocRepaymentFractionBalancedivisor { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Repayment Interest Only Indicator [4573]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"I/O\"}")]
    public bool? HelocRepaymentInterestOnlyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Repayment Minimum Payment Amount [4576]
    /// </summary>
    public decimal? HelocRepaymentMinPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Research Fee [4590]
    /// </summary>
    public decimal? HelocResearchFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Standard Historical Table Indicator [4630]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Standard Historical Table\"}")]
    public bool? HelocStandardHistoricalTableIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// AL Non-Depository Institution [4624]
    /// </summary>
    public bool? HelocTAALNonDepositoryIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// APR cannot [4611]
    /// </summary>
    public StringEnumValue<HelocTAAPPChangeOption> HelocTAAPPChangeOption { get => GetValue<StringEnumValue<HelocTAAPPChangeOption>>(); set => SetValue(value); }

    /// <summary>
    /// Advance Period Payment Rounding options [4607]
    /// </summary>
    public StringEnumValue<HelocTAAPPRoundingOption> HelocTAAPPRoundingOption { get => GetValue<StringEnumValue<HelocTAAPPRoundingOption>>(); set => SetValue(value); }

    /// <summary>
    /// Recent APR lender has charged [4593]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocTAAPRCharged { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Draw Option: Credit Card [4601]
    /// </summary>
    public bool? HelocTACreditCardIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Unauthorized Use of Credit Card notification address [4625]
    /// </summary>
    public string? HelocTACreditCardMisuseNotificationAddr { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Unauthorized Use of Credit Card email address [4628]
    /// </summary>
    public string? HelocTACreditCardMisuseNotificationEmailAddr { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Unauthorized Use of Credit Card notification toll free phone number [4626]
    /// </summary>
    public string? HelocTACreditCardMisuseNotificationPhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Unauthorized Use of Credit Card web address [4627]
    /// </summary>
    public string? HelocTACreditCardMisuseNotificationWebAddr { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Finance charges on your Credit Account determined by applying [4608]
    /// </summary>
    public StringEnumValue<HelocTADailyBalanceType> HelocTADailyBalanceType { get => GetValue<StringEnumValue<HelocTADailyBalanceType>>(); set => SetValue(value); }

    /// <summary>
    /// Fixed daily periodic rate for Installment Loan rounding [4614]
    /// </summary>
    public StringEnumValue<HelocTADailyRateRoundingOption> HelocTADailyRateRoundingOption { get => GetValue<StringEnumValue<HelocTADailyRateRoundingOption>>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Draw Option: Draw Check or Draw Draft [4597]
    /// </summary>
    public StringEnumValue<HelocTADrawCheckIndicator> HelocTADrawCheckIndicator { get => GetValue<StringEnumValue<HelocTADrawCheckIndicator>>(); set => SetValue(value); }

    /// <summary>
    /// Fees charged to borrower to use the HELOC account (what and when) [4594]
    /// </summary>
    public string? HelocTAFeesCharged { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Index Reference date options [4609]
    /// </summary>
    public StringEnumValue<HelocTAIndexRefDateOption> HelocTAIndexRefDateOption { get => GetValue<StringEnumValue<HelocTAIndexRefDateOption>>(); set => SetValue(value); }

    /// <summary>
    /// Installment Loan Index Reference Date [4618]
    /// </summary>
    public StringEnumValue<HelocTAInstallmentIndexRefDateOption> HelocTAInstallmentIndexRefDateOption { get => GetValue<StringEnumValue<HelocTAInstallmentIndexRefDateOption>>(); set => SetValue(value); }

    /// <summary>
    /// Installment loan discounted APR [4616]
    /// </summary>
    public bool? HelocTAInstallmentLoanDiscountedAPRIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Installment Loan - word to use to replace "discount" [4617]
    /// </summary>
    public string? HelocTAInstallmentLoanDiscountWord { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Installment loan payments applied method [4620]
    /// </summary>
    public string? HelocTAInstallmentLoanPaymentAppliedMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Installment Loan Periodic Rate Rounding Percentage [4615]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocTAInstallmentLoanPeriodicRateRoundingPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Installment Loan Termination Method [4619]
    /// </summary>
    public string? HelocTAInstallmentLoanTerminationMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intro Rate applied if monthly periodic rate is used [4595]
    /// </summary>
    public StringEnumValue<HelocTAIntroRateAppliedOn> HelocTAIntroRateAppliedOn { get => GetValue<StringEnumValue<HelocTAIntroRateAppliedOn>>(); set => SetValue(value); }

    /// <summary>
    /// Lender will pay the following third-party closing costs at closing [4622]
    /// </summary>
    public string? HelocTALenderToPay3rdPartyCost { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Draw Option: Overdraft Protection [4602]
    /// </summary>
    public bool? HelocTAOverdraftProtectionIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// If charging an Over Limit charge choose an Over Limit Charge Imposed option [4596]
    /// </summary>
    public StringEnumValue<HelocTAOverLimitChargeOption> HelocTAOverLimitChargeOption { get => GetValue<StringEnumValue<HelocTAOverLimitChargeOption>>(); set => SetValue(value); }

    /// <summary>
    /// Periodic Cap Applied to Advance Period [4612]
    /// </summary>
    public bool? HelocTAPeriodicCapAppliedToAdvancePeriod { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Periodic Cap Applied to Repayment Period [4613]
    /// </summary>
    public bool? HelocTAPeriodicCapAppliedToRepaymentPeriod { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Periodic Rate and APR Adjustments [4610]
    /// </summary>
    public StringEnumValue<HelocTAPeriodicRateAdjDayOption> HelocTAPeriodicRateAdjDayOption { get => GetValue<StringEnumValue<HelocTAPeriodicRateAdjDayOption>>(); set => SetValue(value); }

    /// <summary>
    /// The fixed repayment term must be in one-year (12-month) increments, and may not end later than [4592]
    /// </summary>
    public StringEnumValue<HelocTARepaymentTermEndBy> HelocTARepaymentTermEndBy { get => GetValue<StringEnumValue<HelocTARepaymentTermEndBy>>(); set => SetValue(value); }

    /// <summary>
    /// Request an Advance by Written Authorization: In Person [4603]
    /// </summary>
    public bool? HelocTARequestAdvanceInPersonIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Request an Advance by Written Authorization: In Person location [4605]
    /// </summary>
    public string? HelocTARequestAdvanceInPersonLocation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request an Advance by Written Authorization: Via the Internet [4604]
    /// </summary>
    public bool? HelocTARequestAdvanceViaInternetIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Request an Advance by Written Authorization: Written Authoirzation web address [4606]
    /// </summary>
    public string? HelocTARequestAdvanceViaInternetURL { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Draw Option: Request by Phone [4599]
    /// </summary>
    public bool? HelocTARequestByPhoneIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lender intends to require repay of some/all third-party closing costs at closing [4621]
    /// </summary>
    public bool? HelocTARequireRepayIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Right to Setoff [4623]
    /// </summary>
    public bool? HelocTARightToSetoffIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Draw Option: Written Authorization [4600]
    /// </summary>
    public bool? HelocTAWrittenAuthorizationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProductData Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Index [688]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? IndexCurrentValuePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ARM Index Lookback Period [ARM.IdxLkbckPrd]
    /// </summary>
    public StringEnumValue<IndexLookbackPeriod> IndexLookbackPeriod { get => GetValue<StringEnumValue<IndexLookbackPeriod>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Margin [689]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? IndexMarginPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Margin - Display field with KBYO rounding rules [KBYO.XD689]
    /// </summary>
    public string? IndexMarginPercentUI { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Initial Advance [1888]
    /// </summary>
    public decimal? InitialAdvanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Initial Application Amount [NMLS.X11]
    /// </summary>
    public decimal? InitialApplicationAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Inquiry Or Pre-Qualification [NMLS.X13]
    /// </summary>
    public bool? InquiryOrPreQualificationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Representative [4672]
    /// </summary>
    public string? LenderRepresentative { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Representative Cell Phone [4677]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? LenderRepresentativeCellPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Representative Email address [4674]
    /// </summary>
    public string? LenderRepresentativeEmailAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Representative First/ Last Name [4673]
    /// </summary>
    public string? LenderRepresentativeFirstLastName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Representative Job Title [4683]
    /// </summary>
    public string? LenderRepresentativeJobTitle { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Representative Role ID [4675]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LenderRepresentativeRoleId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Representative User ID [4682]
    /// </summary>
    public string? LenderRepresentativeUserId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Representative User Type [4684]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LenderRepresentativeUserType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Representative Work Phone [4676]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? LenderRepresentativeWorkPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Lien Position [420]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"SecondLien\":\"Subordinate\"}")]
    public StringEnumValue<LienType> LienPriorityType { get => GetValue<StringEnumValue<LienType>>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Loan Doc Type Code [MORNET.X67]
    /// </summary>
    public StringEnumValue<LoanDocumentationType> LoanDocumentationType { get => GetValue<StringEnumValue<LoanDocumentationType>>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Repymt Type Code [424]
    /// </summary>
    public StringEnumValue<LoanRepaymentType> LoanRepaymentType { get => GetValue<StringEnumValue<LoanRepaymentType>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Est Closing Date [763]
    /// </summary>
    public DateTime? LoanScheduledClosingDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Maximum Monthly Payment [NEWHUD.X11]
    /// </summary>
    public decimal? MaximumMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Max Life Interest Cap [2625]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MaxLifeInterestCapPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Max Life Interest Cap - Display field with KBYO rounding rules [KBYO.XD2625]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MaxLifeInterestCapPercentUI { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Mtg Ins Coverage Factor [430]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MiCoveragePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Min Advance Amt [1892]
    /// </summary>
    public decimal? MinimumAdvanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Max Allowable APR [1893]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MinimumAllowableApr { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Minimum Draw Period Payment [HELOC.MinAdvPct]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MinimumDrawPeroidPaymentPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Minimum Payment [1483]
    /// </summary>
    public decimal? MinimumPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Minimum Payment Less Than Amt [HELOC.MinPmtLessThanAmt]
    /// </summary>
    public decimal? MinimumPaymentLessThanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Pymt Factor [1413]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MinimumPaymentPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Minimum Payment UPB Amt [HELOC.MinPmtUnpdBalAmt]
    /// </summary>
    public decimal? MinimumPaymentUpbAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Min. Payment UPB [HELOC.MinPmtUPB]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MinimumPaymentUpbPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Minimum Repay Period Payment [HELOC.MinRepmtPct]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MinimumRepayPeriodPaymentPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Prepay Penalty Mths Applied To Prpymt Pnlty Fee [2829]
    /// </summary>
    public int? MonthsAppliedToPrepaymentPenaltyFeeCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Max Bal % [698]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? NegativeAmortizationLimitPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Net (Initial and Final) [NMLS.X12]
    /// </summary>
    public decimal? NetInitialAndFinal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Documentation Type [NMLS.X3]
    /// </summary>
    public StringEnumValue<NmlsDocumentationType> NmlsDocumentationType { get => GetValue<StringEnumValue<NmlsDocumentationType>>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Residential First Mortgage Type [NMLS.X2]
    /// </summary>
    public StringEnumValue<NmlsFirstMortgageType> NmlsFirstMortgageType { get => GetValue<StringEnumValue<NmlsFirstMortgageType>>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Trans Details Lien Status [NMLS.X17]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\"]")]
    public StringEnumValue<LienStatus> NmlsLienStatus { get => GetValue<StringEnumValue<LienStatus>>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Loan Type [NMLS.X1]
    /// </summary>
    public StringEnumValue<NmlsLoanType> NmlsLoanType { get => GetValue<StringEnumValue<NmlsLoanType>>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Option ARM Indicator [NMLS.X4]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Option ARM\",\"N\":\"Not Option ARM\"}")]
    public bool? NmlsOptionARMIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Piggyback or Funded HELOC Indicator [NMLS.X5]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Includes piggyback second or funded HELOC\",\"N\":\"Does not include piggyback second or funded HELOC\"}")]
    public bool? NmlsPiggyBackOrFundedHELOCIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Production Sold To [NMLS.X7]
    /// </summary>
    public StringEnumValue<NmlsProductionSoldToType> NmlsProductionSoldToType { get => GetValue<StringEnumValue<NmlsProductionSoldToType>>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Subject Property Type [NMLS.X16]
    /// </summary>
    public StringEnumValue<HmdaPropertyType> NmlsPropertyType { get => GetValue<StringEnumValue<HmdaPropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Refinance Purpose [NMLS.X6]
    /// </summary>
    public StringEnumValue<NmlsRefinancePurposeType> NmlsRefinancePurposeType { get => GetValue<StringEnumValue<NmlsRefinancePurposeType>>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Reverse Mortgage Type [NMLS.X10]
    /// </summary>
    public StringEnumValue<NmlsReverseMortgageType> NmlsReverseMortgageType { get => GetValue<StringEnumValue<NmlsReverseMortgageType>>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Oral Request for Extension of Credit [NMLS.X14]
    /// </summary>
    public bool? OralRequestForExtensionOfCreditIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Over Limit Charge [HELOC.OvrLmtChg]
    /// </summary>
    public decimal? OverLimitCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Over Limit Return Charge [HELOC.OvrLmtRtnChg]
    /// </summary>
    public decimal? OverLimitReturnCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Participation Fees: The total amount(s) payable at or before account opening for participation in an open-end credit plan. [HELOC.ParticipationFees]
    /// </summary>
    public decimal? ParticipationFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Pymt Adj Period [690]
    /// </summary>
    public int? PaymentAdjustmentDurationMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Pymt Adj Cap [691]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PaymentAdjustmentPeriodicCapPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Amort Type Biweekly [423]
    /// </summary>
    public StringEnumValue<PaymentFrequencyType> PaymentFrequencyType { get => GetValue<StringEnumValue<PaymentFrequencyType>>(); set => SetValue(value); }

    /// <summary>
    /// LoanProductData PrepaymentPenalties
    /// </summary>
    [AllowNull]
    public IList<PrepaymentPenalty> PrepaymentPenalties { get => GetList<PrepaymentPenalty>(); set => SetList(value); }

    /// <summary>
    /// Amount REGZ Prepayment Penalty Based On [2830]
    /// </summary>
    public StringEnumValue<PrepaymentPenaltyBasedOn> PrepaymentPenaltyBasedOn { get => GetValue<StringEnumValue<PrepaymentPenaltyBasedOn>>(); set => SetValue(value); }

    /// <summary>
    /// Prepayment Penalty [675]
    /// </summary>
    public bool? PrepaymentPenaltyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Prepymt Penalty Prepymt as a % 1 [1948]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PrepaymentPenaltyPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Prepymt Penalty Prepymt Period 1 [1947]
    /// </summary>
    public int? PrepaymentPenaltyTermMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Prepay Verbiage Type [Terms.PrepyVrbgTyp]
    /// </summary>
    public StringEnumValue<PrepaymentPenaltyVerbiage> PrepaymentPenaltyVerbiage { get => GetValue<StringEnumValue<PrepaymentPenaltyVerbiage>>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Product Name [MORNET.X66]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ProductName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Qual Rate [1014]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? QualifyingRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Rate Adj Period [694]
    /// </summary>
    public int? RateAdjustmentDurationMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Life Cap [247]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RateAdjustmentLifetimeCapPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM First Rate Adj Cap [697]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RateAdjustmentPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM First Rate Adj Cap - Display fields with KBYO rounding rules [KBYO.XD697]
    /// </summary>
    public string? RateAdjustmentPercentUI { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Rate Cap [695]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RateAdjustmentSubsequentCapPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Rate Cap - Display fields with KBYO rounding rules [KBYO.XD695]
    /// </summary>
    public string? RateAdjustmentSubsequentCapPercentUI { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Release Recording Charge [HELOC.RlsRecgChg]
    /// </summary>
    public decimal? ReleaseRecoringCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Buydown Dsbmt Sum Total Subsidy Bal [3120]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? RemainingBuydownAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Repay Period Mos [1890]
    /// </summary>
    public int? RepayPeriodMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Returned Check Charge Amt. [HELOC.RtdChkChgAmt]
    /// </summary>
    public decimal? ReturnedCheckCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Returned Check Charge Rate [HELOC.RtdChkChgRat]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ReturnedCheckChargeRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Returned Check Charge Max. [HELOC.RtdChkChgMax]
    /// </summary>
    public decimal? ReturnedCheckMaxCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Returned Check Charge Min. [HELOC.RtdChkChgMin]
    /// </summary>
    public decimal? ReturnedCheckMinCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Round Index To % [1700]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RoundPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Round Index Up/Down [SYS.X1]
    /// </summary>
    public StringEnumValue<RoundType> RoundType { get => GetValue<StringEnumValue<RoundType>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details First Pymt Adj Date [3054]
    /// </summary>
    public DateTime? ScheduledFirstPaymentAdjustmentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details First Pymt Date [682]
    /// </summary>
    public DateTime? ScheduledFirstPaymentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Stop Payment Charge [HELOC.StopPmtChrg]
    /// </summary>
    public decimal? StopPaymentCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM First Period Change [696]
    /// </summary>
    public int? SubsequentRateAdjustmentMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Termination Fee [1986]
    /// </summary>
    public decimal? TerminationFeeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Termination Fee Mos [1987]
    /// </summary>
    public int? TerminationPeriodMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Third Party Fees Range - From [1965]
    /// </summary>
    public decimal? ThirdPartyFeeFromAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Third Party Fees Range - To [1966]
    /// </summary>
    public decimal? ThirdPartyFeeToAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Timely Payment Reduction Percent [2634]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? TimelyPaymentRateReductionPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Timely Payment Rewards [2633]
    /// </summary>
    public StringEnumValue<TimelyPaymentRewards> TimelyPaymentRewards { get => GetValue<StringEnumValue<TimelyPaymentRewards>>(); set => SetValue(value); }

    /// <summary>
    /// Buydown Dsbmt Sum Tot. Subsidy Amt [3119]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalSubsidyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Transaction Fees: The total amount of fees charged each time a withdrawal or other specified transaction is made on a line of credit, such as a balance transfer fee or a cash advance fee. [HELOC.TransactionFees]
    /// </summary>
    public decimal? TransactionFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Wire Fee [HELOC.WireFee]
    /// </summary>
    public decimal? WireFee { get => GetValue<decimal?>(); set => SetValue(value); }
}