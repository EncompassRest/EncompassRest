using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ATRQMBorrower
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class ATRQMBorrower : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// ATRQMBorrower ATRQMBorrowerIndex
    /// </summary>
    public int? ATRQMBorrowerIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Latest Submission - AUS Recommendation [AUSF.X3]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AUSRecommendation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Latest Submission - AUS Version # [AUSF.X12]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AUSVersion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Average Overtime [QM.X228]
    /// </summary>
    public decimal? BorBonusAverageOvertime { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Most Recent Amount [QM.X218]
    /// </summary>
    public decimal? BorBonusMostRecentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Most Recent Months [QM.X217]
    /// </summary>
    public int? BorBonusMostRecentMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Most Recent Year [QM.X354]
    /// </summary>
    public int? BorBonusMostRecentYear { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Amount 1 [QM.X222]
    /// </summary>
    public decimal? BorBonusPreviousAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Amount 2 [QM.X226]
    /// </summary>
    public decimal? BorBonusPreviousAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Months 1 [QM.X221]
    /// </summary>
    public int? BorBonusPreviousMonths1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Months 2 [QM.X225]
    /// </summary>
    public int? BorBonusPreviousMonths2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Year 1 [QM.X220]
    /// </summary>
    public int? BorBonusPreviousYear1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Year 2 [QM.X224]
    /// </summary>
    public int? BorBonusPreviousYear2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Average Overtime [QM.X237]
    /// </summary>
    public decimal? BorCommissionAverageOvertime { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Most Recent Amount [QM.X231]
    /// </summary>
    public decimal? BorCommissionMostRecentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Most Recent Months [QM.X230]
    /// </summary>
    public int? BorCommissionMostRecentMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Most Recent Year [QM.X356]
    /// </summary>
    public int? BorCommissionMostRecentYear { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Amount 1 [QM.X235]
    /// </summary>
    public decimal? BorCommissionPreviousAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Amount 2 [QM.X360]
    /// </summary>
    public decimal? BorCommissionPreviousAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Months 1 [QM.X234]
    /// </summary>
    public int? BorCommissionPreviousMonths1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Months 2 [QM.X359]
    /// </summary>
    public int? BorCommissionPreviousMonths2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Year 1 [QM.X233]
    /// </summary>
    public int? BorCommissionPreviousYear1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Year 2 [QM.X358]
    /// </summary>
    public int? BorCommissionPreviousYear2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Contingent Liabilities on Assumed Mortgages - Liability Amount [QM.X192]
    /// </summary>
    public decimal? BorContingentLiabilitiesLiabilityAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Contingent Liabilities on Assumed Mortgages - Liability Amount [QM.X194]
    /// </summary>
    public decimal? BorContingentLiabilitiesLiabilityAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Contingent Liabilities on Assumed Mortgages - Liability Amount [QM.X196]
    /// </summary>
    public decimal? BorContingentLiabilitiesLiabilityAmount3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Contingent Liabilities on Assumed Mortgages - Liability Description 1 [QM.X191]
    /// </summary>
    public StringEnumValue<BorContingentLiabilitiesLiabilityDescription> BorContingentLiabilitiesLiabilityDescription1 { get => GetValue<StringEnumValue<BorContingentLiabilitiesLiabilityDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Contingent Liabilities on Assumed Mortgages - Liability Description 2 [QM.X193]
    /// </summary>
    public StringEnumValue<BorContingentLiabilitiesLiabilityDescription> BorContingentLiabilitiesLiabilityDescription2 { get => GetValue<StringEnumValue<BorContingentLiabilitiesLiabilityDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Contingent Liabilities on Assumed Mortgages - Liability Description 3 [QM.X195]
    /// </summary>
    public StringEnumValue<BorContingentLiabilitiesLiabilityDescription> BorContingentLiabilitiesLiabilityDescription3 { get => GetValue<StringEnumValue<BorContingentLiabilitiesLiabilityDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Contingent Liabilities on Assumed Mortgages - Total Liability Amount [QM.X197]
    /// </summary>
    public decimal? BorContingentLiabilitiesTotalLiabilityAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Contingent Liabilities on Cosigned Obligations - Car Loan Payment [QM.X198]
    /// </summary>
    public decimal? BorCosignedObligationsCarLoanPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Contingent Liabilities on Cosigned Obligations - Mortgage Payment [QM.X200]
    /// </summary>
    public decimal? BorCosignedObligationsMortgagePayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Contingent Liabilities on Cosigned Obligations - Other Payment [QM.X202]
    /// </summary>
    public decimal? BorCosignedObligationsOtherPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Contingent Liabilities on Cosigned Obligations - Other Payment Description [QM.X201]
    /// </summary>
    public string? BorCosignedObligationsOtherPaymentDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Contingent Liabilities on Cosigned Obligations - Student Loan Payment [QM.X199]
    /// </summary>
    public decimal? BorCosignedObligationsStudentLoanPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Contingent Liabilities on Cosigned Obligations - Total CoMortgagor Liabilities [QM.X203]
    /// </summary>
    public decimal? BorCosignedObligationsTotalCoMortgagorLiabilities { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Dividend - Average Dividend [QM.X249]
    /// </summary>
    public decimal? BorDividendAverageDividend { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Amount 1 [QM.X241]
    /// </summary>
    public decimal? BorDividendPreviousAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Amount 2 [QM.X245]
    /// </summary>
    public decimal? BorDividendPreviousAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Months 1 [QM.X240]
    /// </summary>
    public int? BorDividendPreviousMonths1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Months 2 [QM.X244]
    /// </summary>
    public int? BorDividendPreviousMonths2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Year 1 [QM.X239]
    /// </summary>
    public int? BorDividendPreviousYear1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Year 2 [QM.X243]
    /// </summary>
    public int? BorDividendPreviousYear2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Dividend - Required For Cash Inv [QM.X247]
    /// </summary>
    public decimal? BorDividendRequiredForCashAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Interest - Average Dividend [QM.X261]
    /// </summary>
    public decimal? BorInterestAverageDividend { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Amount 1 [QM.X253]
    /// </summary>
    public decimal? BorInterestPreviousAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Amount 2 [QM.X257]
    /// </summary>
    public decimal? BorInterestPreviousAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Months 1 [QM.X252]
    /// </summary>
    public int? BorInterestPreviousMonths1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Months 2 [QM.X256]
    /// </summary>
    public int? BorInterestPreviousMonths2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Year 1 [QM.X251]
    /// </summary>
    public int? BorInterestPreviousYear1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Year 2 [QM.X255]
    /// </summary>
    public int? BorInterestPreviousYear2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Interest - Required For Cash Inv [QM.X259]
    /// </summary>
    public decimal? BorInterestRequiredForCashAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Clothing Allowance [QM.X295]
    /// </summary>
    public decimal? BorMilitaryAllowanceClothingAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Other Allowance [QM.X299]
    /// </summary>
    public decimal? BorMilitaryAllowanceOtherAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Other Allowance Description [QM.X307]
    /// </summary>
    public string? BorMilitaryAllowanceOtherAllowanceDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Quarters Allowance [QM.X298]
    /// </summary>
    public decimal? BorMilitaryAllowanceQuartersAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Rations Allowance [QM.X296]
    /// </summary>
    public decimal? BorMilitaryAllowanceRationsAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Total Allowances [QM.X300]
    /// </summary>
    public decimal? BorMilitaryAllowanceTotalAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Variable Housing Allowance [QM.X297]
    /// </summary>
    public decimal? BorMilitaryAllowanceVariableHousingAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military - Base Pay [QM.X281]
    /// </summary>
    public decimal? BorMilitaryBasePay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military - Combat Pay [QM.X282]
    /// </summary>
    public decimal? BorMilitaryCombatPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military - Flight Pay [QM.X283]
    /// </summary>
    public decimal? BorMilitaryFlightPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military - Hazard Pay [QM.X284]
    /// </summary>
    public decimal? BorMilitaryHazardPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military - Overseas Pay [QM.X285]
    /// </summary>
    public decimal? BorMilitaryOverseasPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military - Prop Pay [QM.X286]
    /// </summary>
    public decimal? BorMilitaryPropPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military - Total Military Income [QM.X287]
    /// </summary>
    public decimal? BorMilitaryTotalPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Base [QM.X137]
    /// </summary>
    public decimal? BorMonthlyEmplymentIncomeBaseIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Bonuses [QM.X139]
    /// </summary>
    public decimal? BorMonthlyEmplymentIncomeBonuseIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Commissions [QM.X140]
    /// </summary>
    public decimal? BorMonthlyEmplymentIncomeCommissionIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Dividend and Interest [QM.X141]
    /// </summary>
    public decimal? BorMonthlyEmplymentIncomeDividendInterestIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Other Income 1 [QM.X142]
    /// </summary>
    public decimal? BorMonthlyEmplymentIncomeOtherIncome1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Other Income 2 [QM.X143]
    /// </summary>
    public decimal? BorMonthlyEmplymentIncomeOtherIncome2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Overtime [QM.X138]
    /// </summary>
    public decimal? BorMonthlyEmplymentIncomeOvertimeIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Total Monthly Employment Income [QM.X144]
    /// </summary>
    public decimal? BorMonthlyEmplymentIncomeTotalEmploymentIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non-Employment Income - Government Assitant Program [QM.X165]
    /// </summary>
    public decimal? BorNonEmploymentIncomeGovtAssitProgramIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non-Employment Income - Homeown. Subsidy [QM.X167]
    /// </summary>
    public decimal? BorNonEmploymentIncomeHomeownSubsidyIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non-Employment Income - Will be used to 'offset' mortgage payment and deducted from total income [QM.X336]
    /// </summary>
    public bool? BorNonEmploymentIncomeIsOffsetHomeownSubsidyIncome { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non-Employment Income - Will be used to 'offset' mortgage payment and deducted from total income [QM.X335]
    /// </summary>
    public bool? BorNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non-Employment Income - Military [QM.X163]
    /// </summary>
    public decimal? BorNonEmploymentIncomeMilitaryIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non-Employment Income - Mtg. Credit Certificate Income [QM.X166]
    /// </summary>
    public decimal? BorNonEmploymentIncomeMtgCreditCertificateIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non-Employment Income - Total [QM.X310]
    /// </summary>
    public decimal? BorNonEmploymentIncomeTotalNonEmploymentIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non-Employment Income - VA Benefit [QM.X164]
    /// </summary>
    public decimal? BorNonEmploymentIncomeVABenefitIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non Taxable Income - Child Support [QM.X179]
    /// </summary>
    public decimal? BorNonTaxableIncomeChildSupportIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non Taxable Income - Disability [QM.X177]
    /// </summary>
    public decimal? BorNonTaxableIncomeDisabilityIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non Taxable Income - Fed Govt. Empl. Retirement [QM.X174]
    /// </summary>
    public decimal? BorNonTaxableIncomeFedGovtEmplRetirementIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non Taxable Income - Military Allowances [QM.X180]
    /// </summary>
    public decimal? BorNonTaxableIncomeMilitaryAllowances { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non Taxable Income - Other Income [QM.X181]
    /// </summary>
    public decimal? BorNonTaxableIncomeOtherIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non Taxable Income - Public Assistant Payments [QM.X178]
    /// </summary>
    public decimal? BorNonTaxableIncomePublicAssistPayments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non Taxable Income - Railroad Retirement Benefits [QM.X175]
    /// </summary>
    public decimal? BorNonTaxableIncomeRailroadRetirementBenefits { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non Taxable Income - Social Security [QM.X173]
    /// </summary>
    public decimal? BorNonTaxableIncomeSocialSecurityIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non Taxable Income - State Gov't. Empl. Retirement [QM.X176]
    /// </summary>
    public decimal? BorNonTaxableIncomeStateGovtEmplRetirementIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non-Taxable Income - Total [QM.X312]
    /// </summary>
    public decimal? BorNonTaxableIncomeTotalNonTaxableIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Other - Notes Receivable [QM.X271]
    /// </summary>
    public decimal? BorOtherNotesReceivableIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Other Income - Other [QM.X263]
    /// </summary>
    public decimal? BorOtherOtherIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Other - Part-time [QM.X269]
    /// </summary>
    public decimal? BorOtherParttimeIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Other - Retirement [QM.X264]
    /// </summary>
    public decimal? BorOtherRetirementIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Other - Seasonal [QM.X270]
    /// </summary>
    public decimal? BorOtherSeasonalIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Other - Social Security [QM.X265]
    /// </summary>
    public decimal? BorOtherSocialSecurityIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Other - Tip [QM.X268]
    /// </summary>
    public decimal? BorOtherTipIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Other - Trust [QM.X266]
    /// </summary>
    public decimal? BorOtherTrustIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Other - Unemployment [QM.X267]
    /// </summary>
    public decimal? BorOtherUnemploymentIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Average Overtime [QM.X215]
    /// </summary>
    public decimal? BorOvertimeAverageOvertime { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Most Recent Amount [QM.X205]
    /// </summary>
    public decimal? BorOvertimeMostRecentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Most Recent Months [QM.X204]
    /// </summary>
    public int? BorOvertimeMostRecentMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Most Recent Year [QM.X352]
    /// </summary>
    public int? BorOvertimeMostRecentYear { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Amount 1 [QM.X209]
    /// </summary>
    public decimal? BorOvertimePreviousAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Amount 2 [QM.X213]
    /// </summary>
    public decimal? BorOvertimePreviousAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Months 1 [QM.X208]
    /// </summary>
    public int? BorOvertimePreviousMonths1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Months 2 [QM.X212]
    /// </summary>
    public int? BorOvertimePreviousMonths2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Year 1 [QM.X207]
    /// </summary>
    public int? BorOvertimePreviousYear1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Year 2 [QM.X211]
    /// </summary>
    public int? BorOvertimePreviousYear2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Projected Income - Bonuses [QM.X157]
    /// </summary>
    public decimal? BorProjectedIncomeProjectedBonuses { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Projected Income - Cost of Living Adj. [QM.X155]
    /// </summary>
    public decimal? BorProjectedIncomeProjectedCostLivingAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Projected Income - New Job [QM.X158]
    /// </summary>
    public decimal? BorProjectedIncomeProjectedNewJobIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Projected Income - Performance Raises [QM.X156]
    /// </summary>
    public decimal? BorProjectedIncomeProjectedPerformanceRaises { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Projected Income - Total Projected Income [QM.X308]
    /// </summary>
    public decimal? BorProjectedIncomeTotalProjectedIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Average Overtime [QM.X229]
    /// </summary>
    public decimal? CobBonusAverageOvertime { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Most Recent Amount [QM.X219]
    /// </summary>
    public decimal? CobBonusMostRecentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Most Recent Months [QM.X319]
    /// </summary>
    public int? CobBonusMostRecentMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Most Recent Year [QM.X355]
    /// </summary>
    public int? CobBonusMostRecentYear { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Amount 1 [QM.X223]
    /// </summary>
    public decimal? CobBonusPreviousAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Amount 2 [QM.X227]
    /// </summary>
    public decimal? CobBonusPreviousAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Months 1 [QM.X321]
    /// </summary>
    public int? CobBonusPreviousMonths1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Months 2 [QM.X323]
    /// </summary>
    public int? CobBonusPreviousMonths2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Year 1 [QM.X320]
    /// </summary>
    public int? CobBonusPreviousYear1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Year 2 [QM.X322]
    /// </summary>
    public int? CobBonusPreviousYear2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Average Overtime [QM.X238]
    /// </summary>
    public decimal? CobCommissionAverageOvertime { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Most Recent Amount [QM.X232]
    /// </summary>
    public decimal? CobCommissionMostRecentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Most Recent Months [QM.X324]
    /// </summary>
    public int? CobCommissionMostRecentMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Most Recent Year [QM.X357]
    /// </summary>
    public int? CobCommissionMostRecentYear { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Amount 1 [QM.X236]
    /// </summary>
    public decimal? CobCommissionPreviousAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Amount 2 [QM.X363]
    /// </summary>
    public decimal? CobCommissionPreviousAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Months 1 [QM.X326]
    /// </summary>
    public int? CobCommissionPreviousMonths1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Months 2 [QM.X362]
    /// </summary>
    public int? CobCommissionPreviousMonths2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Year 1 [QM.X325]
    /// </summary>
    public int? CobCommissionPreviousYear1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Year 2 [QM.X361]
    /// </summary>
    public int? CobCommissionPreviousYear2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Dividend - Average Dividend [QM.X250]
    /// </summary>
    public decimal? CobDividendAverageDividend { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Amount 1 [QM.X242]
    /// </summary>
    public decimal? CobDividendPreviousAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Amount 2 [QM.X246]
    /// </summary>
    public decimal? CobDividendPreviousAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Months 1 [QM.X328]
    /// </summary>
    public int? CobDividendPreviousMonths1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Months 2 [QM.X330]
    /// </summary>
    public int? CobDividendPreviousMonths2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Year 1 [QM.X327]
    /// </summary>
    public int? CobDividendPreviousYear1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Year 2 [QM.X329]
    /// </summary>
    public int? CobDividendPreviousYear2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Dividend - Required For Cash Inv [QM.X248]
    /// </summary>
    public decimal? CobDividendRequiredForCashAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Interest - Average Dividend [QM.X262]
    /// </summary>
    public decimal? CobInterestAverageDividend { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Amount 1 [QM.X254]
    /// </summary>
    public decimal? CobInterestPreviousAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Amount 2 [QM.X258]
    /// </summary>
    public decimal? CobInterestPreviousAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Months 1 [QM.X332]
    /// </summary>
    public int? CobInterestPreviousMonths1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Months 2 [QM.X334]
    /// </summary>
    public int? CobInterestPreviousMonths2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Year 1 [QM.X331]
    /// </summary>
    public int? CobInterestPreviousYear1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Year 2 [QM.X333]
    /// </summary>
    public int? CobInterestPreviousYear2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Interest - Required For Cash Inv [QM.X260]
    /// </summary>
    public decimal? CobInterestRequiredForCashAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Clothing Allowance [QM.X301]
    /// </summary>
    public decimal? CobMilitaryAllowanceClothingAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Other Allowance [QM.X305]
    /// </summary>
    public decimal? CobMilitaryAllowanceOtherAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Quarters Allowance [QM.X304]
    /// </summary>
    public decimal? CobMilitaryAllowanceQuartersAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Rations Allowance [QM.X302]
    /// </summary>
    public decimal? CobMilitaryAllowanceRationsAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Total Allowances [QM.X306]
    /// </summary>
    public decimal? CobMilitaryAllowanceTotalAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Variable Housing Allowance [QM.X303]
    /// </summary>
    public decimal? CobMilitaryAllowanceVariableHousingAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military - Base Pay [QM.X288]
    /// </summary>
    public decimal? CobMilitaryBasePay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military - Combat Pay [QM.X289]
    /// </summary>
    public decimal? CobMilitaryCombatPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military - Flight Pay [QM.X290]
    /// </summary>
    public decimal? CobMilitaryFlightPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military - Hazard Pay [QM.X291]
    /// </summary>
    public decimal? CobMilitaryHazardPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military - Overseas Pay [QM.X292]
    /// </summary>
    public decimal? CobMilitaryOverseasPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military - Prop Pay [QM.X293]
    /// </summary>
    public decimal? CobMilitaryPropPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Military - Total Military Income [QM.X294]
    /// </summary>
    public decimal? CobMilitaryTotalPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Base [QM.X145]
    /// </summary>
    public decimal? CobMonthlyEmplymentIncomeBaseIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Bonuses [QM.X147]
    /// </summary>
    public decimal? CobMonthlyEmplymentIncomeBonuseIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Commissions [QM.X148]
    /// </summary>
    public decimal? CobMonthlyEmplymentIncomeCommissionIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Dividend and Interest [QM.X149]
    /// </summary>
    public decimal? CobMonthlyEmplymentIncomeDividendInterestIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Other Income 1 [QM.X150]
    /// </summary>
    public decimal? CobMonthlyEmplymentIncomeOtherIncome1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Other Income 2 [QM.X151]
    /// </summary>
    public decimal? CobMonthlyEmplymentIncomeOtherIncome2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Overtime [QM.X146]
    /// </summary>
    public decimal? CobMonthlyEmplymentIncomeOvertimeIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Total Monthly Employment Income [QM.X152]
    /// </summary>
    public decimal? CobMonthlyEmplymentIncomeTotalEmploymentIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non-Employment Income - Government Assitant Program [QM.X170]
    /// </summary>
    public decimal? CobNonEmploymentIncomeGovtAssitProgramIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non-Employment Income - Homeown. Subsidy [QM.X172]
    /// </summary>
    public decimal? CobNonEmploymentIncomeHomeownSubsidyIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non-Employment Income - Military [QM.X168]
    /// </summary>
    public decimal? CobNonEmploymentIncomeMilitaryIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non-Employment Income - Mtg. Credit Certificate Income [QM.X171]
    /// </summary>
    public decimal? CobNonEmploymentIncomeMtgCreditCertificateIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non-Employment Income - Total [QM.X311]
    /// </summary>
    public decimal? CobNonEmploymentIncomeTotalNonEmploymentIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non-Employment Income - VA Benefit [QM.X169]
    /// </summary>
    public decimal? CobNonEmploymentIncomeVABenefitIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non Taxable Income - Child Support [QM.X188]
    /// </summary>
    public decimal? CobNonTaxableIncomeChildSupportIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non Taxable Income - Disability [QM.X186]
    /// </summary>
    public decimal? CobNonTaxableIncomeDisabilityIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non Taxable Income - Fed Govt. Empl. Retirement [QM.X183]
    /// </summary>
    public decimal? CobNonTaxableIncomeFedGovtEmplRetirementIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non Taxable Income - Military Allowances [QM.X189]
    /// </summary>
    public decimal? CobNonTaxableIncomeMilitaryAllowances { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non Taxable Income - Other Income [QM.X190]
    /// </summary>
    public decimal? CobNonTaxableIncomeOtherIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non Taxable Income - Public Assistant Payments [QM.X187]
    /// </summary>
    public decimal? CobNonTaxableIncomePublicAssistPayments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non Taxable Income - Railroad Retirement Benefits [QM.X184]
    /// </summary>
    public decimal? CobNonTaxableIncomeRailroadRetirementBenefits { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non Taxable Income - Social Security [QM.X182]
    /// </summary>
    public decimal? CobNonTaxableIncomeSocialSecurityIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non Taxable Income - State Gov't. Empl. Retirement [QM.X185]
    /// </summary>
    public decimal? CobNonTaxableIncomeStateGovtEmplRetirementIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Non-Taxable Income - Total [QM.X313]
    /// </summary>
    public decimal? CobNonTaxableIncomeTotalNonTaxableIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Other - Notes Receivable [QM.X280]
    /// </summary>
    public decimal? CobOtherNotesReceivableIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Other Income - Other [QM.X272]
    /// </summary>
    public decimal? CobOtherOtherIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Other - Part-time [QM.X278]
    /// </summary>
    public decimal? CobOtherParttimeIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Other - Retirement [QM.X273]
    /// </summary>
    public decimal? CobOtherRetirementIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Other - Seasonal [QM.X279]
    /// </summary>
    public decimal? CobOtherSeasonalIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Other - Social Security [QM.X274]
    /// </summary>
    public decimal? CobOtherSocialSecurityIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Other - Tip [QM.X277]
    /// </summary>
    public decimal? CobOtherTipIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Other - Trust [QM.X275]
    /// </summary>
    public decimal? CobOtherTrustIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Other - Unemployment [QM.X276]
    /// </summary>
    public decimal? CobOtherUnemploymentIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Average Overtime [QM.X216]
    /// </summary>
    public decimal? CobOvertimeAverageOvertime { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Most Recent Amount [QM.X206]
    /// </summary>
    public decimal? CobOvertimeMostRecentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Most Recent Months [QM.X314]
    /// </summary>
    public int? CobOvertimeMostRecentMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Most Recent Year [QM.X353]
    /// </summary>
    public int? CobOvertimeMostRecentYear { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Amount 1 [QM.X210]
    /// </summary>
    public decimal? CobOvertimePreviousAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Amount 2 [QM.X214]
    /// </summary>
    public decimal? CobOvertimePreviousAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Months 1 [QM.X316]
    /// </summary>
    public int? CobOvertimePreviousMonths1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Months 2 [QM.X318]
    /// </summary>
    public int? CobOvertimePreviousMonths2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Year 1 [QM.X315]
    /// </summary>
    public int? CobOvertimePreviousYear1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Year 2 [QM.X317]
    /// </summary>
    public int? CobOvertimePreviousYear2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Projected Income - Bonuses [QM.X161]
    /// </summary>
    public decimal? CobProjectedIncomeProjectedBonuses { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Projected Income - Cost of Living Adj. [QM.X159]
    /// </summary>
    public decimal? CobProjectedIncomeProjectedCostLivingAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Projected Income - New Job [QM.X162]
    /// </summary>
    public decimal? CobProjectedIncomeProjectedNewJobIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Projected Income - Performance Raises [QM.X160]
    /// </summary>
    public decimal? CobProjectedIncomeProjectedPerformanceRaises { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Projected Income - Total Projected Income [QM.X309]
    /// </summary>
    public decimal? CobProjectedIncomeTotalProjectedIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Latest Submission - DU Case ID/ LP AUS Key # [AUSF.X4]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DUCaseIDorLPAUSKey { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Latest Submission - First Submission Date [AUSF.X9]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? FirstSubmissionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Latest Submission - First Submission Time [AUSF.X10]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? FirstSubmissionTime { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Latest Submission - Doc Class (Freddie) [AUSF.X5]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? FreddieDocClass { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Latest Submission - Housing Ratio [AUSF.X17]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? HousingRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ATRQMBorrower Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ATRQMBorrower IsEmpty
    /// </summary>
    public bool? IsEmpty { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Latest Submission - Submission Date [AUSF.X7]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? SubmissionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Latest Submission - Submission Number [AUSF.X11]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SubmissionNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Latest Submission - Submission Time [AUSF.X8]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SubmissionTime { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Latest Submission - Submitted By [AUSF.X6]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SubmittedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Latest Submission - Total Expense Ratio [AUSF.X18]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? TotalExpenseRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Latest Submission - Total Housing Payment [AUSF.X13]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalHousingPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Latest Submission - Total Monthly Assets [AUSF.X15]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMonthlyAssets { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Latest Submission - Total Monthly Debt [AUSF.X16]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMonthlyDebt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Latest Submission - Total Monthly Income [AUSF.X14]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMonthlyIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Latest Submission - Underwriting Risk Assess Other Type [AUSF.X2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? UnderwritingRiskAssessOther { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Latest Submission - Underwriting Risk Assess Type [AUSF.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? UnderwritingRiskAssessType { get => GetValue<string?>(); set => SetValue(value); }
}