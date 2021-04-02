using System;
using EncompassApi.Loans.Enums;
using EncompassApi.Schema;

namespace EncompassApi.Loans
{
    /// <summary>
    /// ATRQMBorrower
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class ATRQMBorrower : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?>? _aTRQMBorrowerIndex;
        private DirtyValue<string?>? _aUSRecommendation;
        private DirtyValue<string?>? _aUSVersion;
        private DirtyValue<decimal?>? _borBonusAverageOvertime;
        private DirtyValue<decimal?>? _borBonusMostRecentAmount;
        private DirtyValue<int?>? _borBonusMostRecentMonths;
        private DirtyValue<int?>? _borBonusMostRecentYear;
        private DirtyValue<decimal?>? _borBonusPreviousAmount1;
        private DirtyValue<decimal?>? _borBonusPreviousAmount2;
        private DirtyValue<int?>? _borBonusPreviousMonths1;
        private DirtyValue<int?>? _borBonusPreviousMonths2;
        private DirtyValue<int?>? _borBonusPreviousYear1;
        private DirtyValue<int?>? _borBonusPreviousYear2;
        private DirtyValue<decimal?>? _borCommissionAverageOvertime;
        private DirtyValue<decimal?>? _borCommissionMostRecentAmount;
        private DirtyValue<int?>? _borCommissionMostRecentMonths;
        private DirtyValue<int?>? _borCommissionMostRecentYear;
        private DirtyValue<decimal?>? _borCommissionPreviousAmount1;
        private DirtyValue<decimal?>? _borCommissionPreviousAmount2;
        private DirtyValue<int?>? _borCommissionPreviousMonths1;
        private DirtyValue<int?>? _borCommissionPreviousMonths2;
        private DirtyValue<int?>? _borCommissionPreviousYear1;
        private DirtyValue<int?>? _borCommissionPreviousYear2;
        private DirtyValue<decimal?>? _borContingentLiabilitiesLiabilityAmount1;
        private DirtyValue<decimal?>? _borContingentLiabilitiesLiabilityAmount2;
        private DirtyValue<decimal?>? _borContingentLiabilitiesLiabilityAmount3;
        private DirtyValue<StringEnumValue<BorContingentLiabilitiesLiabilityDescription>>? _borContingentLiabilitiesLiabilityDescription1;
        private DirtyValue<StringEnumValue<BorContingentLiabilitiesLiabilityDescription>>? _borContingentLiabilitiesLiabilityDescription2;
        private DirtyValue<StringEnumValue<BorContingentLiabilitiesLiabilityDescription>>? _borContingentLiabilitiesLiabilityDescription3;
        private DirtyValue<decimal?>? _borContingentLiabilitiesTotalLiabilityAmount;
        private DirtyValue<decimal?>? _borCosignedObligationsCarLoanPayment;
        private DirtyValue<decimal?>? _borCosignedObligationsMortgagePayment;
        private DirtyValue<decimal?>? _borCosignedObligationsOtherPayment;
        private DirtyValue<string?>? _borCosignedObligationsOtherPaymentDescription;
        private DirtyValue<decimal?>? _borCosignedObligationsStudentLoanPayment;
        private DirtyValue<decimal?>? _borCosignedObligationsTotalCoMortgagorLiabilities;
        private DirtyValue<decimal?>? _borDividendAverageDividend;
        private DirtyValue<decimal?>? _borDividendPreviousAmount1;
        private DirtyValue<decimal?>? _borDividendPreviousAmount2;
        private DirtyValue<int?>? _borDividendPreviousMonths1;
        private DirtyValue<int?>? _borDividendPreviousMonths2;
        private DirtyValue<int?>? _borDividendPreviousYear1;
        private DirtyValue<int?>? _borDividendPreviousYear2;
        private DirtyValue<decimal?>? _borDividendRequiredForCashAmount;
        private DirtyValue<decimal?>? _borInterestAverageDividend;
        private DirtyValue<decimal?>? _borInterestPreviousAmount1;
        private DirtyValue<decimal?>? _borInterestPreviousAmount2;
        private DirtyValue<int?>? _borInterestPreviousMonths1;
        private DirtyValue<int?>? _borInterestPreviousMonths2;
        private DirtyValue<int?>? _borInterestPreviousYear1;
        private DirtyValue<int?>? _borInterestPreviousYear2;
        private DirtyValue<decimal?>? _borInterestRequiredForCashAmount;
        private DirtyValue<decimal?>? _borMilitaryAllowanceClothingAllowance;
        private DirtyValue<decimal?>? _borMilitaryAllowanceOtherAllowance;
        private DirtyValue<string?>? _borMilitaryAllowanceOtherAllowanceDescription;
        private DirtyValue<decimal?>? _borMilitaryAllowanceQuartersAllowance;
        private DirtyValue<decimal?>? _borMilitaryAllowanceRationsAllowance;
        private DirtyValue<decimal?>? _borMilitaryAllowanceTotalAllowance;
        private DirtyValue<decimal?>? _borMilitaryAllowanceVariableHousingAllowance;
        private DirtyValue<decimal?>? _borMilitaryBasePay;
        private DirtyValue<decimal?>? _borMilitaryCombatPay;
        private DirtyValue<decimal?>? _borMilitaryFlightPay;
        private DirtyValue<decimal?>? _borMilitaryHazardPay;
        private DirtyValue<decimal?>? _borMilitaryOverseasPay;
        private DirtyValue<decimal?>? _borMilitaryPropPay;
        private DirtyValue<decimal?>? _borMilitaryTotalPay;
        private DirtyValue<decimal?>? _borMonthlyEmplymentIncomeBaseIncome;
        private DirtyValue<decimal?>? _borMonthlyEmplymentIncomeBonuseIncome;
        private DirtyValue<decimal?>? _borMonthlyEmplymentIncomeCommissionIncome;
        private DirtyValue<decimal?>? _borMonthlyEmplymentIncomeDividendInterestIncome;
        private DirtyValue<decimal?>? _borMonthlyEmplymentIncomeOtherIncome1;
        private DirtyValue<decimal?>? _borMonthlyEmplymentIncomeOtherIncome2;
        private DirtyValue<decimal?>? _borMonthlyEmplymentIncomeOvertimeIncome;
        private DirtyValue<decimal?>? _borMonthlyEmplymentIncomeTotalEmploymentIncome;
        private DirtyValue<decimal?>? _borNonEmploymentIncomeGovtAssitProgramIncome;
        private DirtyValue<decimal?>? _borNonEmploymentIncomeHomeownSubsidyIncome;
        private DirtyValue<bool?>? _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome;
        private DirtyValue<bool?>? _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome;
        private DirtyValue<decimal?>? _borNonEmploymentIncomeMilitaryIncome;
        private DirtyValue<decimal?>? _borNonEmploymentIncomeMtgCreditCertificateIncome;
        private DirtyValue<decimal?>? _borNonEmploymentIncomeTotalNonEmploymentIncome;
        private DirtyValue<decimal?>? _borNonEmploymentIncomeVABenefitIncome;
        private DirtyValue<decimal?>? _borNonTaxableIncomeChildSupportIncome;
        private DirtyValue<decimal?>? _borNonTaxableIncomeDisabilityIncome;
        private DirtyValue<decimal?>? _borNonTaxableIncomeFedGovtEmplRetirementIncome;
        private DirtyValue<decimal?>? _borNonTaxableIncomeMilitaryAllowances;
        private DirtyValue<decimal?>? _borNonTaxableIncomeOtherIncome;
        private DirtyValue<decimal?>? _borNonTaxableIncomePublicAssistPayments;
        private DirtyValue<decimal?>? _borNonTaxableIncomeRailroadRetirementBenefits;
        private DirtyValue<decimal?>? _borNonTaxableIncomeSocialSecurityIncome;
        private DirtyValue<decimal?>? _borNonTaxableIncomeStateGovtEmplRetirementIncome;
        private DirtyValue<decimal?>? _borNonTaxableIncomeTotalNonTaxableIncome;
        private DirtyValue<decimal?>? _borOtherNotesReceivableIncome;
        private DirtyValue<decimal?>? _borOtherOtherIncome;
        private DirtyValue<decimal?>? _borOtherParttimeIncome;
        private DirtyValue<decimal?>? _borOtherRetirementIncome;
        private DirtyValue<decimal?>? _borOtherSeasonalIncome;
        private DirtyValue<decimal?>? _borOtherSocialSecurityIncome;
        private DirtyValue<decimal?>? _borOtherTipIncome;
        private DirtyValue<decimal?>? _borOtherTrustIncome;
        private DirtyValue<decimal?>? _borOtherUnemploymentIncome;
        private DirtyValue<decimal?>? _borOvertimeAverageOvertime;
        private DirtyValue<decimal?>? _borOvertimeMostRecentAmount;
        private DirtyValue<int?>? _borOvertimeMostRecentMonths;
        private DirtyValue<int?>? _borOvertimeMostRecentYear;
        private DirtyValue<decimal?>? _borOvertimePreviousAmount1;
        private DirtyValue<decimal?>? _borOvertimePreviousAmount2;
        private DirtyValue<int?>? _borOvertimePreviousMonths1;
        private DirtyValue<int?>? _borOvertimePreviousMonths2;
        private DirtyValue<int?>? _borOvertimePreviousYear1;
        private DirtyValue<int?>? _borOvertimePreviousYear2;
        private DirtyValue<decimal?>? _borProjectedIncomeProjectedBonuses;
        private DirtyValue<decimal?>? _borProjectedIncomeProjectedCostLivingAdjustment;
        private DirtyValue<decimal?>? _borProjectedIncomeProjectedNewJobIncome;
        private DirtyValue<decimal?>? _borProjectedIncomeProjectedPerformanceRaises;
        private DirtyValue<decimal?>? _borProjectedIncomeTotalProjectedIncome;
        private DirtyValue<decimal?>? _cobBonusAverageOvertime;
        private DirtyValue<decimal?>? _cobBonusMostRecentAmount;
        private DirtyValue<int?>? _cobBonusMostRecentMonths;
        private DirtyValue<int?>? _cobBonusMostRecentYear;
        private DirtyValue<decimal?>? _cobBonusPreviousAmount1;
        private DirtyValue<decimal?>? _cobBonusPreviousAmount2;
        private DirtyValue<int?>? _cobBonusPreviousMonths1;
        private DirtyValue<int?>? _cobBonusPreviousMonths2;
        private DirtyValue<int?>? _cobBonusPreviousYear1;
        private DirtyValue<int?>? _cobBonusPreviousYear2;
        private DirtyValue<decimal?>? _cobCommissionAverageOvertime;
        private DirtyValue<decimal?>? _cobCommissionMostRecentAmount;
        private DirtyValue<int?>? _cobCommissionMostRecentMonths;
        private DirtyValue<int?>? _cobCommissionMostRecentYear;
        private DirtyValue<decimal?>? _cobCommissionPreviousAmount1;
        private DirtyValue<decimal?>? _cobCommissionPreviousAmount2;
        private DirtyValue<int?>? _cobCommissionPreviousMonths1;
        private DirtyValue<int?>? _cobCommissionPreviousMonths2;
        private DirtyValue<int?>? _cobCommissionPreviousYear1;
        private DirtyValue<int?>? _cobCommissionPreviousYear2;
        private DirtyValue<decimal?>? _cobDividendAverageDividend;
        private DirtyValue<decimal?>? _cobDividendPreviousAmount1;
        private DirtyValue<decimal?>? _cobDividendPreviousAmount2;
        private DirtyValue<int?>? _cobDividendPreviousMonths1;
        private DirtyValue<int?>? _cobDividendPreviousMonths2;
        private DirtyValue<int?>? _cobDividendPreviousYear1;
        private DirtyValue<int?>? _cobDividendPreviousYear2;
        private DirtyValue<decimal?>? _cobDividendRequiredForCashAmount;
        private DirtyValue<decimal?>? _cobInterestAverageDividend;
        private DirtyValue<decimal?>? _cobInterestPreviousAmount1;
        private DirtyValue<decimal?>? _cobInterestPreviousAmount2;
        private DirtyValue<int?>? _cobInterestPreviousMonths1;
        private DirtyValue<int?>? _cobInterestPreviousMonths2;
        private DirtyValue<int?>? _cobInterestPreviousYear1;
        private DirtyValue<int?>? _cobInterestPreviousYear2;
        private DirtyValue<decimal?>? _cobInterestRequiredForCashAmount;
        private DirtyValue<decimal?>? _cobMilitaryAllowanceClothingAllowance;
        private DirtyValue<decimal?>? _cobMilitaryAllowanceOtherAllowance;
        private DirtyValue<decimal?>? _cobMilitaryAllowanceQuartersAllowance;
        private DirtyValue<decimal?>? _cobMilitaryAllowanceRationsAllowance;
        private DirtyValue<decimal?>? _cobMilitaryAllowanceTotalAllowance;
        private DirtyValue<decimal?>? _cobMilitaryAllowanceVariableHousingAllowance;
        private DirtyValue<decimal?>? _cobMilitaryBasePay;
        private DirtyValue<decimal?>? _cobMilitaryCombatPay;
        private DirtyValue<decimal?>? _cobMilitaryFlightPay;
        private DirtyValue<decimal?>? _cobMilitaryHazardPay;
        private DirtyValue<decimal?>? _cobMilitaryOverseasPay;
        private DirtyValue<decimal?>? _cobMilitaryPropPay;
        private DirtyValue<decimal?>? _cobMilitaryTotalPay;
        private DirtyValue<decimal?>? _cobMonthlyEmplymentIncomeBaseIncome;
        private DirtyValue<decimal?>? _cobMonthlyEmplymentIncomeBonuseIncome;
        private DirtyValue<decimal?>? _cobMonthlyEmplymentIncomeCommissionIncome;
        private DirtyValue<decimal?>? _cobMonthlyEmplymentIncomeDividendInterestIncome;
        private DirtyValue<decimal?>? _cobMonthlyEmplymentIncomeOtherIncome1;
        private DirtyValue<decimal?>? _cobMonthlyEmplymentIncomeOtherIncome2;
        private DirtyValue<decimal?>? _cobMonthlyEmplymentIncomeOvertimeIncome;
        private DirtyValue<decimal?>? _cobMonthlyEmplymentIncomeTotalEmploymentIncome;
        private DirtyValue<decimal?>? _cobNonEmploymentIncomeGovtAssitProgramIncome;
        private DirtyValue<decimal?>? _cobNonEmploymentIncomeHomeownSubsidyIncome;
        private DirtyValue<decimal?>? _cobNonEmploymentIncomeMilitaryIncome;
        private DirtyValue<decimal?>? _cobNonEmploymentIncomeMtgCreditCertificateIncome;
        private DirtyValue<decimal?>? _cobNonEmploymentIncomeTotalNonEmploymentIncome;
        private DirtyValue<decimal?>? _cobNonEmploymentIncomeVABenefitIncome;
        private DirtyValue<decimal?>? _cobNonTaxableIncomeChildSupportIncome;
        private DirtyValue<decimal?>? _cobNonTaxableIncomeDisabilityIncome;
        private DirtyValue<decimal?>? _cobNonTaxableIncomeFedGovtEmplRetirementIncome;
        private DirtyValue<decimal?>? _cobNonTaxableIncomeMilitaryAllowances;
        private DirtyValue<decimal?>? _cobNonTaxableIncomeOtherIncome;
        private DirtyValue<decimal?>? _cobNonTaxableIncomePublicAssistPayments;
        private DirtyValue<decimal?>? _cobNonTaxableIncomeRailroadRetirementBenefits;
        private DirtyValue<decimal?>? _cobNonTaxableIncomeSocialSecurityIncome;
        private DirtyValue<decimal?>? _cobNonTaxableIncomeStateGovtEmplRetirementIncome;
        private DirtyValue<decimal?>? _cobNonTaxableIncomeTotalNonTaxableIncome;
        private DirtyValue<decimal?>? _cobOtherNotesReceivableIncome;
        private DirtyValue<decimal?>? _cobOtherOtherIncome;
        private DirtyValue<decimal?>? _cobOtherParttimeIncome;
        private DirtyValue<decimal?>? _cobOtherRetirementIncome;
        private DirtyValue<decimal?>? _cobOtherSeasonalIncome;
        private DirtyValue<decimal?>? _cobOtherSocialSecurityIncome;
        private DirtyValue<decimal?>? _cobOtherTipIncome;
        private DirtyValue<decimal?>? _cobOtherTrustIncome;
        private DirtyValue<decimal?>? _cobOtherUnemploymentIncome;
        private DirtyValue<decimal?>? _cobOvertimeAverageOvertime;
        private DirtyValue<decimal?>? _cobOvertimeMostRecentAmount;
        private DirtyValue<int?>? _cobOvertimeMostRecentMonths;
        private DirtyValue<int?>? _cobOvertimeMostRecentYear;
        private DirtyValue<decimal?>? _cobOvertimePreviousAmount1;
        private DirtyValue<decimal?>? _cobOvertimePreviousAmount2;
        private DirtyValue<int?>? _cobOvertimePreviousMonths1;
        private DirtyValue<int?>? _cobOvertimePreviousMonths2;
        private DirtyValue<int?>? _cobOvertimePreviousYear1;
        private DirtyValue<int?>? _cobOvertimePreviousYear2;
        private DirtyValue<decimal?>? _cobProjectedIncomeProjectedBonuses;
        private DirtyValue<decimal?>? _cobProjectedIncomeProjectedCostLivingAdjustment;
        private DirtyValue<decimal?>? _cobProjectedIncomeProjectedNewJobIncome;
        private DirtyValue<decimal?>? _cobProjectedIncomeProjectedPerformanceRaises;
        private DirtyValue<decimal?>? _cobProjectedIncomeTotalProjectedIncome;
        private DirtyValue<string?>? _dUCaseIDorLPAUSKey;
        private DirtyValue<DateTime?>? _firstSubmissionDate;
        private DirtyValue<string?>? _firstSubmissionTime;
        private DirtyValue<string?>? _freddieDocClass;
        private DirtyValue<decimal?>? _housingRatio;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _isEmpty;
        private DirtyValue<DateTime?>? _submissionDate;
        private DirtyValue<string?>? _submissionNumber;
        private DirtyValue<string?>? _submissionTime;
        private DirtyValue<string?>? _submittedBy;
        private DirtyValue<decimal?>? _totalExpenseRatio;
        private DirtyValue<decimal?>? _totalHousingPayment;
        private DirtyValue<decimal?>? _totalMonthlyAssets;
        private DirtyValue<decimal?>? _totalMonthlyDebt;
        private DirtyValue<decimal?>? _totalMonthlyIncome;
        private DirtyValue<string?>? _underwritingRiskAssessOther;
        private DirtyValue<string?>? _underwritingRiskAssessType;

        /// <summary>
        /// ATRQMBorrower ATRQMBorrowerIndex
        /// </summary>
        public int? ATRQMBorrowerIndex { get => _aTRQMBorrowerIndex; set => SetField(ref _aTRQMBorrowerIndex, value); }

        /// <summary>
        /// AUS Tracking - Latest Submission - AUS Recommendation [AUSF.X3]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? AUSRecommendation { get => _aUSRecommendation; set => SetField(ref _aUSRecommendation, value); }

        /// <summary>
        /// AUS Tracking - Latest Submission - AUS Version # [AUSF.X12]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? AUSVersion { get => _aUSVersion; set => SetField(ref _aUSVersion, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Average Overtime [QM.X228]
        /// </summary>
        public decimal? BorBonusAverageOvertime { get => _borBonusAverageOvertime; set => SetField(ref _borBonusAverageOvertime, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Most Recent Amount [QM.X218]
        /// </summary>
        public decimal? BorBonusMostRecentAmount { get => _borBonusMostRecentAmount; set => SetField(ref _borBonusMostRecentAmount, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Most Recent Months [QM.X217]
        /// </summary>
        public int? BorBonusMostRecentMonths { get => _borBonusMostRecentMonths; set => SetField(ref _borBonusMostRecentMonths, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Most Recent Year [QM.X354]
        /// </summary>
        public int? BorBonusMostRecentYear { get => _borBonusMostRecentYear; set => SetField(ref _borBonusMostRecentYear, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Amount 1 [QM.X222]
        /// </summary>
        public decimal? BorBonusPreviousAmount1 { get => _borBonusPreviousAmount1; set => SetField(ref _borBonusPreviousAmount1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Amount 2 [QM.X226]
        /// </summary>
        public decimal? BorBonusPreviousAmount2 { get => _borBonusPreviousAmount2; set => SetField(ref _borBonusPreviousAmount2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Months 1 [QM.X221]
        /// </summary>
        public int? BorBonusPreviousMonths1 { get => _borBonusPreviousMonths1; set => SetField(ref _borBonusPreviousMonths1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Months 2 [QM.X225]
        /// </summary>
        public int? BorBonusPreviousMonths2 { get => _borBonusPreviousMonths2; set => SetField(ref _borBonusPreviousMonths2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Year 1 [QM.X220]
        /// </summary>
        public int? BorBonusPreviousYear1 { get => _borBonusPreviousYear1; set => SetField(ref _borBonusPreviousYear1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Year 2 [QM.X224]
        /// </summary>
        public int? BorBonusPreviousYear2 { get => _borBonusPreviousYear2; set => SetField(ref _borBonusPreviousYear2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Average Overtime [QM.X237]
        /// </summary>
        public decimal? BorCommissionAverageOvertime { get => _borCommissionAverageOvertime; set => SetField(ref _borCommissionAverageOvertime, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Most Recent Amount [QM.X231]
        /// </summary>
        public decimal? BorCommissionMostRecentAmount { get => _borCommissionMostRecentAmount; set => SetField(ref _borCommissionMostRecentAmount, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Most Recent Months [QM.X230]
        /// </summary>
        public int? BorCommissionMostRecentMonths { get => _borCommissionMostRecentMonths; set => SetField(ref _borCommissionMostRecentMonths, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Most Recent Year [QM.X356]
        /// </summary>
        public int? BorCommissionMostRecentYear { get => _borCommissionMostRecentYear; set => SetField(ref _borCommissionMostRecentYear, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Amount 1 [QM.X235]
        /// </summary>
        public decimal? BorCommissionPreviousAmount1 { get => _borCommissionPreviousAmount1; set => SetField(ref _borCommissionPreviousAmount1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Amount 2 [QM.X360]
        /// </summary>
        public decimal? BorCommissionPreviousAmount2 { get => _borCommissionPreviousAmount2; set => SetField(ref _borCommissionPreviousAmount2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Months 1 [QM.X234]
        /// </summary>
        public int? BorCommissionPreviousMonths1 { get => _borCommissionPreviousMonths1; set => SetField(ref _borCommissionPreviousMonths1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Months 2 [QM.X359]
        /// </summary>
        public int? BorCommissionPreviousMonths2 { get => _borCommissionPreviousMonths2; set => SetField(ref _borCommissionPreviousMonths2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Year 1 [QM.X233]
        /// </summary>
        public int? BorCommissionPreviousYear1 { get => _borCommissionPreviousYear1; set => SetField(ref _borCommissionPreviousYear1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Year 2 [QM.X358]
        /// </summary>
        public int? BorCommissionPreviousYear2 { get => _borCommissionPreviousYear2; set => SetField(ref _borCommissionPreviousYear2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Contingent Liabilities on Assumed Mortgages - Liability Amount [QM.X192]
        /// </summary>
        public decimal? BorContingentLiabilitiesLiabilityAmount1 { get => _borContingentLiabilitiesLiabilityAmount1; set => SetField(ref _borContingentLiabilitiesLiabilityAmount1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Contingent Liabilities on Assumed Mortgages - Liability Amount [QM.X194]
        /// </summary>
        public decimal? BorContingentLiabilitiesLiabilityAmount2 { get => _borContingentLiabilitiesLiabilityAmount2; set => SetField(ref _borContingentLiabilitiesLiabilityAmount2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Contingent Liabilities on Assumed Mortgages - Liability Amount [QM.X196]
        /// </summary>
        public decimal? BorContingentLiabilitiesLiabilityAmount3 { get => _borContingentLiabilitiesLiabilityAmount3; set => SetField(ref _borContingentLiabilitiesLiabilityAmount3, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Contingent Liabilities on Assumed Mortgages - Liability Description 1 [QM.X191]
        /// </summary>
        public StringEnumValue<BorContingentLiabilitiesLiabilityDescription> BorContingentLiabilitiesLiabilityDescription1 { get => _borContingentLiabilitiesLiabilityDescription1; set => SetField(ref _borContingentLiabilitiesLiabilityDescription1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Contingent Liabilities on Assumed Mortgages - Liability Description 2 [QM.X193]
        /// </summary>
        public StringEnumValue<BorContingentLiabilitiesLiabilityDescription> BorContingentLiabilitiesLiabilityDescription2 { get => _borContingentLiabilitiesLiabilityDescription2; set => SetField(ref _borContingentLiabilitiesLiabilityDescription2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Contingent Liabilities on Assumed Mortgages - Liability Description 3 [QM.X195]
        /// </summary>
        public StringEnumValue<BorContingentLiabilitiesLiabilityDescription> BorContingentLiabilitiesLiabilityDescription3 { get => _borContingentLiabilitiesLiabilityDescription3; set => SetField(ref _borContingentLiabilitiesLiabilityDescription3, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Contingent Liabilities on Assumed Mortgages - Total Liability Amount [QM.X197]
        /// </summary>
        public decimal? BorContingentLiabilitiesTotalLiabilityAmount { get => _borContingentLiabilitiesTotalLiabilityAmount; set => SetField(ref _borContingentLiabilitiesTotalLiabilityAmount, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Contingent Liabilities on Cosigned Obligations - Car Loan Payment [QM.X198]
        /// </summary>
        public decimal? BorCosignedObligationsCarLoanPayment { get => _borCosignedObligationsCarLoanPayment; set => SetField(ref _borCosignedObligationsCarLoanPayment, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Contingent Liabilities on Cosigned Obligations - Mortgage Payment [QM.X200]
        /// </summary>
        public decimal? BorCosignedObligationsMortgagePayment { get => _borCosignedObligationsMortgagePayment; set => SetField(ref _borCosignedObligationsMortgagePayment, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Contingent Liabilities on Cosigned Obligations - Other Payment [QM.X202]
        /// </summary>
        public decimal? BorCosignedObligationsOtherPayment { get => _borCosignedObligationsOtherPayment; set => SetField(ref _borCosignedObligationsOtherPayment, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Contingent Liabilities on Cosigned Obligations - Other Payment Description [QM.X201]
        /// </summary>
        public string? BorCosignedObligationsOtherPaymentDescription { get => _borCosignedObligationsOtherPaymentDescription; set => SetField(ref _borCosignedObligationsOtherPaymentDescription, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Contingent Liabilities on Cosigned Obligations - Student Loan Payment [QM.X199]
        /// </summary>
        public decimal? BorCosignedObligationsStudentLoanPayment { get => _borCosignedObligationsStudentLoanPayment; set => SetField(ref _borCosignedObligationsStudentLoanPayment, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Contingent Liabilities on Cosigned Obligations - Total CoMortgagor Liabilities [QM.X203]
        /// </summary>
        public decimal? BorCosignedObligationsTotalCoMortgagorLiabilities { get => _borCosignedObligationsTotalCoMortgagorLiabilities; set => SetField(ref _borCosignedObligationsTotalCoMortgagorLiabilities, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Dividend - Average Dividend [QM.X249]
        /// </summary>
        public decimal? BorDividendAverageDividend { get => _borDividendAverageDividend; set => SetField(ref _borDividendAverageDividend, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Amount 1 [QM.X241]
        /// </summary>
        public decimal? BorDividendPreviousAmount1 { get => _borDividendPreviousAmount1; set => SetField(ref _borDividendPreviousAmount1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Amount 2 [QM.X245]
        /// </summary>
        public decimal? BorDividendPreviousAmount2 { get => _borDividendPreviousAmount2; set => SetField(ref _borDividendPreviousAmount2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Months 1 [QM.X240]
        /// </summary>
        public int? BorDividendPreviousMonths1 { get => _borDividendPreviousMonths1; set => SetField(ref _borDividendPreviousMonths1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Months 2 [QM.X244]
        /// </summary>
        public int? BorDividendPreviousMonths2 { get => _borDividendPreviousMonths2; set => SetField(ref _borDividendPreviousMonths2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Year 1 [QM.X239]
        /// </summary>
        public int? BorDividendPreviousYear1 { get => _borDividendPreviousYear1; set => SetField(ref _borDividendPreviousYear1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Year 2 [QM.X243]
        /// </summary>
        public int? BorDividendPreviousYear2 { get => _borDividendPreviousYear2; set => SetField(ref _borDividendPreviousYear2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Dividend - Required For Cash Inv [QM.X247]
        /// </summary>
        public decimal? BorDividendRequiredForCashAmount { get => _borDividendRequiredForCashAmount; set => SetField(ref _borDividendRequiredForCashAmount, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Interest - Average Dividend [QM.X261]
        /// </summary>
        public decimal? BorInterestAverageDividend { get => _borInterestAverageDividend; set => SetField(ref _borInterestAverageDividend, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Amount 1 [QM.X253]
        /// </summary>
        public decimal? BorInterestPreviousAmount1 { get => _borInterestPreviousAmount1; set => SetField(ref _borInterestPreviousAmount1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Amount 2 [QM.X257]
        /// </summary>
        public decimal? BorInterestPreviousAmount2 { get => _borInterestPreviousAmount2; set => SetField(ref _borInterestPreviousAmount2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Months 1 [QM.X252]
        /// </summary>
        public int? BorInterestPreviousMonths1 { get => _borInterestPreviousMonths1; set => SetField(ref _borInterestPreviousMonths1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Months 2 [QM.X256]
        /// </summary>
        public int? BorInterestPreviousMonths2 { get => _borInterestPreviousMonths2; set => SetField(ref _borInterestPreviousMonths2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Year 1 [QM.X251]
        /// </summary>
        public int? BorInterestPreviousYear1 { get => _borInterestPreviousYear1; set => SetField(ref _borInterestPreviousYear1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Year 2 [QM.X255]
        /// </summary>
        public int? BorInterestPreviousYear2 { get => _borInterestPreviousYear2; set => SetField(ref _borInterestPreviousYear2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Interest - Required For Cash Inv [QM.X259]
        /// </summary>
        public decimal? BorInterestRequiredForCashAmount { get => _borInterestRequiredForCashAmount; set => SetField(ref _borInterestRequiredForCashAmount, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Clothing Allowance [QM.X295]
        /// </summary>
        public decimal? BorMilitaryAllowanceClothingAllowance { get => _borMilitaryAllowanceClothingAllowance; set => SetField(ref _borMilitaryAllowanceClothingAllowance, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Other Allowance [QM.X299]
        /// </summary>
        public decimal? BorMilitaryAllowanceOtherAllowance { get => _borMilitaryAllowanceOtherAllowance; set => SetField(ref _borMilitaryAllowanceOtherAllowance, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Other Allowance Description [QM.X307]
        /// </summary>
        public string? BorMilitaryAllowanceOtherAllowanceDescription { get => _borMilitaryAllowanceOtherAllowanceDescription; set => SetField(ref _borMilitaryAllowanceOtherAllowanceDescription, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Quarters Allowance [QM.X298]
        /// </summary>
        public decimal? BorMilitaryAllowanceQuartersAllowance { get => _borMilitaryAllowanceQuartersAllowance; set => SetField(ref _borMilitaryAllowanceQuartersAllowance, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Rations Allowance [QM.X296]
        /// </summary>
        public decimal? BorMilitaryAllowanceRationsAllowance { get => _borMilitaryAllowanceRationsAllowance; set => SetField(ref _borMilitaryAllowanceRationsAllowance, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Total Allowances [QM.X300]
        /// </summary>
        public decimal? BorMilitaryAllowanceTotalAllowance { get => _borMilitaryAllowanceTotalAllowance; set => SetField(ref _borMilitaryAllowanceTotalAllowance, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Variable Housing Allowance [QM.X297]
        /// </summary>
        public decimal? BorMilitaryAllowanceVariableHousingAllowance { get => _borMilitaryAllowanceVariableHousingAllowance; set => SetField(ref _borMilitaryAllowanceVariableHousingAllowance, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military - Base Pay [QM.X281]
        /// </summary>
        public decimal? BorMilitaryBasePay { get => _borMilitaryBasePay; set => SetField(ref _borMilitaryBasePay, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military - Combat Pay [QM.X282]
        /// </summary>
        public decimal? BorMilitaryCombatPay { get => _borMilitaryCombatPay; set => SetField(ref _borMilitaryCombatPay, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military - Flight Pay [QM.X283]
        /// </summary>
        public decimal? BorMilitaryFlightPay { get => _borMilitaryFlightPay; set => SetField(ref _borMilitaryFlightPay, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military - Hazard Pay [QM.X284]
        /// </summary>
        public decimal? BorMilitaryHazardPay { get => _borMilitaryHazardPay; set => SetField(ref _borMilitaryHazardPay, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military - Overseas Pay [QM.X285]
        /// </summary>
        public decimal? BorMilitaryOverseasPay { get => _borMilitaryOverseasPay; set => SetField(ref _borMilitaryOverseasPay, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military - Prop Pay [QM.X286]
        /// </summary>
        public decimal? BorMilitaryPropPay { get => _borMilitaryPropPay; set => SetField(ref _borMilitaryPropPay, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military - Total Military Income [QM.X287]
        /// </summary>
        public decimal? BorMilitaryTotalPay { get => _borMilitaryTotalPay; set => SetField(ref _borMilitaryTotalPay, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Base [QM.X137]
        /// </summary>
        public decimal? BorMonthlyEmplymentIncomeBaseIncome { get => _borMonthlyEmplymentIncomeBaseIncome; set => SetField(ref _borMonthlyEmplymentIncomeBaseIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Bonuses [QM.X139]
        /// </summary>
        public decimal? BorMonthlyEmplymentIncomeBonuseIncome { get => _borMonthlyEmplymentIncomeBonuseIncome; set => SetField(ref _borMonthlyEmplymentIncomeBonuseIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Commissions [QM.X140]
        /// </summary>
        public decimal? BorMonthlyEmplymentIncomeCommissionIncome { get => _borMonthlyEmplymentIncomeCommissionIncome; set => SetField(ref _borMonthlyEmplymentIncomeCommissionIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Dividend and Interest [QM.X141]
        /// </summary>
        public decimal? BorMonthlyEmplymentIncomeDividendInterestIncome { get => _borMonthlyEmplymentIncomeDividendInterestIncome; set => SetField(ref _borMonthlyEmplymentIncomeDividendInterestIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Other Income 1 [QM.X142]
        /// </summary>
        public decimal? BorMonthlyEmplymentIncomeOtherIncome1 { get => _borMonthlyEmplymentIncomeOtherIncome1; set => SetField(ref _borMonthlyEmplymentIncomeOtherIncome1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Other Income 2 [QM.X143]
        /// </summary>
        public decimal? BorMonthlyEmplymentIncomeOtherIncome2 { get => _borMonthlyEmplymentIncomeOtherIncome2; set => SetField(ref _borMonthlyEmplymentIncomeOtherIncome2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Overtime [QM.X138]
        /// </summary>
        public decimal? BorMonthlyEmplymentIncomeOvertimeIncome { get => _borMonthlyEmplymentIncomeOvertimeIncome; set => SetField(ref _borMonthlyEmplymentIncomeOvertimeIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Total Monthly Employment Income [QM.X144]
        /// </summary>
        public decimal? BorMonthlyEmplymentIncomeTotalEmploymentIncome { get => _borMonthlyEmplymentIncomeTotalEmploymentIncome; set => SetField(ref _borMonthlyEmplymentIncomeTotalEmploymentIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non-Employment Income - Government Assitant Program [QM.X165]
        /// </summary>
        public decimal? BorNonEmploymentIncomeGovtAssitProgramIncome { get => _borNonEmploymentIncomeGovtAssitProgramIncome; set => SetField(ref _borNonEmploymentIncomeGovtAssitProgramIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non-Employment Income - Homeown. Subsidy [QM.X167]
        /// </summary>
        public decimal? BorNonEmploymentIncomeHomeownSubsidyIncome { get => _borNonEmploymentIncomeHomeownSubsidyIncome; set => SetField(ref _borNonEmploymentIncomeHomeownSubsidyIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non-Employment Income - Will be used to 'offset' mortgage payment and deducted from total income [QM.X336]
        /// </summary>
        public bool? BorNonEmploymentIncomeIsOffsetHomeownSubsidyIncome { get => _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome; set => SetField(ref _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non-Employment Income - Will be used to 'offset' mortgage payment and deducted from total income [QM.X335]
        /// </summary>
        public bool? BorNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome { get => _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome; set => SetField(ref _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non-Employment Income - Military [QM.X163]
        /// </summary>
        public decimal? BorNonEmploymentIncomeMilitaryIncome { get => _borNonEmploymentIncomeMilitaryIncome; set => SetField(ref _borNonEmploymentIncomeMilitaryIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non-Employment Income - Mtg. Credit Certificate Income [QM.X166]
        /// </summary>
        public decimal? BorNonEmploymentIncomeMtgCreditCertificateIncome { get => _borNonEmploymentIncomeMtgCreditCertificateIncome; set => SetField(ref _borNonEmploymentIncomeMtgCreditCertificateIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non-Employment Income - Total [QM.X310]
        /// </summary>
        public decimal? BorNonEmploymentIncomeTotalNonEmploymentIncome { get => _borNonEmploymentIncomeTotalNonEmploymentIncome; set => SetField(ref _borNonEmploymentIncomeTotalNonEmploymentIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non-Employment Income - VA Benefit [QM.X164]
        /// </summary>
        public decimal? BorNonEmploymentIncomeVABenefitIncome { get => _borNonEmploymentIncomeVABenefitIncome; set => SetField(ref _borNonEmploymentIncomeVABenefitIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non Taxable Income - Child Support [QM.X179]
        /// </summary>
        public decimal? BorNonTaxableIncomeChildSupportIncome { get => _borNonTaxableIncomeChildSupportIncome; set => SetField(ref _borNonTaxableIncomeChildSupportIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non Taxable Income - Disability [QM.X177]
        /// </summary>
        public decimal? BorNonTaxableIncomeDisabilityIncome { get => _borNonTaxableIncomeDisabilityIncome; set => SetField(ref _borNonTaxableIncomeDisabilityIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non Taxable Income - Fed Govt. Empl. Retirement [QM.X174]
        /// </summary>
        public decimal? BorNonTaxableIncomeFedGovtEmplRetirementIncome { get => _borNonTaxableIncomeFedGovtEmplRetirementIncome; set => SetField(ref _borNonTaxableIncomeFedGovtEmplRetirementIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non Taxable Income - Military Allowances [QM.X180]
        /// </summary>
        public decimal? BorNonTaxableIncomeMilitaryAllowances { get => _borNonTaxableIncomeMilitaryAllowances; set => SetField(ref _borNonTaxableIncomeMilitaryAllowances, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non Taxable Income - Other Income [QM.X181]
        /// </summary>
        public decimal? BorNonTaxableIncomeOtherIncome { get => _borNonTaxableIncomeOtherIncome; set => SetField(ref _borNonTaxableIncomeOtherIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non Taxable Income - Public Assistant Payments [QM.X178]
        /// </summary>
        public decimal? BorNonTaxableIncomePublicAssistPayments { get => _borNonTaxableIncomePublicAssistPayments; set => SetField(ref _borNonTaxableIncomePublicAssistPayments, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non Taxable Income - Railroad Retirement Benefits [QM.X175]
        /// </summary>
        public decimal? BorNonTaxableIncomeRailroadRetirementBenefits { get => _borNonTaxableIncomeRailroadRetirementBenefits; set => SetField(ref _borNonTaxableIncomeRailroadRetirementBenefits, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non Taxable Income - Social Security [QM.X173]
        /// </summary>
        public decimal? BorNonTaxableIncomeSocialSecurityIncome { get => _borNonTaxableIncomeSocialSecurityIncome; set => SetField(ref _borNonTaxableIncomeSocialSecurityIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non Taxable Income - State Gov't. Empl. Retirement [QM.X176]
        /// </summary>
        public decimal? BorNonTaxableIncomeStateGovtEmplRetirementIncome { get => _borNonTaxableIncomeStateGovtEmplRetirementIncome; set => SetField(ref _borNonTaxableIncomeStateGovtEmplRetirementIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non-Taxable Income - Total [QM.X312]
        /// </summary>
        public decimal? BorNonTaxableIncomeTotalNonTaxableIncome { get => _borNonTaxableIncomeTotalNonTaxableIncome; set => SetField(ref _borNonTaxableIncomeTotalNonTaxableIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Other - Notes Receivable [QM.X271]
        /// </summary>
        public decimal? BorOtherNotesReceivableIncome { get => _borOtherNotesReceivableIncome; set => SetField(ref _borOtherNotesReceivableIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Other Income - Other [QM.X263]
        /// </summary>
        public decimal? BorOtherOtherIncome { get => _borOtherOtherIncome; set => SetField(ref _borOtherOtherIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Other - Part-time [QM.X269]
        /// </summary>
        public decimal? BorOtherParttimeIncome { get => _borOtherParttimeIncome; set => SetField(ref _borOtherParttimeIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Other - Retirement [QM.X264]
        /// </summary>
        public decimal? BorOtherRetirementIncome { get => _borOtherRetirementIncome; set => SetField(ref _borOtherRetirementIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Other - Seasonal [QM.X270]
        /// </summary>
        public decimal? BorOtherSeasonalIncome { get => _borOtherSeasonalIncome; set => SetField(ref _borOtherSeasonalIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Other - Social Security [QM.X265]
        /// </summary>
        public decimal? BorOtherSocialSecurityIncome { get => _borOtherSocialSecurityIncome; set => SetField(ref _borOtherSocialSecurityIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Other - Tip [QM.X268]
        /// </summary>
        public decimal? BorOtherTipIncome { get => _borOtherTipIncome; set => SetField(ref _borOtherTipIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Other - Trust [QM.X266]
        /// </summary>
        public decimal? BorOtherTrustIncome { get => _borOtherTrustIncome; set => SetField(ref _borOtherTrustIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Other - Unemployment [QM.X267]
        /// </summary>
        public decimal? BorOtherUnemploymentIncome { get => _borOtherUnemploymentIncome; set => SetField(ref _borOtherUnemploymentIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Average Overtime [QM.X215]
        /// </summary>
        public decimal? BorOvertimeAverageOvertime { get => _borOvertimeAverageOvertime; set => SetField(ref _borOvertimeAverageOvertime, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Most Recent Amount [QM.X205]
        /// </summary>
        public decimal? BorOvertimeMostRecentAmount { get => _borOvertimeMostRecentAmount; set => SetField(ref _borOvertimeMostRecentAmount, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Most Recent Months [QM.X204]
        /// </summary>
        public int? BorOvertimeMostRecentMonths { get => _borOvertimeMostRecentMonths; set => SetField(ref _borOvertimeMostRecentMonths, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Most Recent Year [QM.X352]
        /// </summary>
        public int? BorOvertimeMostRecentYear { get => _borOvertimeMostRecentYear; set => SetField(ref _borOvertimeMostRecentYear, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Amount 1 [QM.X209]
        /// </summary>
        public decimal? BorOvertimePreviousAmount1 { get => _borOvertimePreviousAmount1; set => SetField(ref _borOvertimePreviousAmount1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Amount 2 [QM.X213]
        /// </summary>
        public decimal? BorOvertimePreviousAmount2 { get => _borOvertimePreviousAmount2; set => SetField(ref _borOvertimePreviousAmount2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Months 1 [QM.X208]
        /// </summary>
        public int? BorOvertimePreviousMonths1 { get => _borOvertimePreviousMonths1; set => SetField(ref _borOvertimePreviousMonths1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Months 2 [QM.X212]
        /// </summary>
        public int? BorOvertimePreviousMonths2 { get => _borOvertimePreviousMonths2; set => SetField(ref _borOvertimePreviousMonths2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Year 1 [QM.X207]
        /// </summary>
        public int? BorOvertimePreviousYear1 { get => _borOvertimePreviousYear1; set => SetField(ref _borOvertimePreviousYear1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Year 2 [QM.X211]
        /// </summary>
        public int? BorOvertimePreviousYear2 { get => _borOvertimePreviousYear2; set => SetField(ref _borOvertimePreviousYear2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Projected Income - Bonuses [QM.X157]
        /// </summary>
        public decimal? BorProjectedIncomeProjectedBonuses { get => _borProjectedIncomeProjectedBonuses; set => SetField(ref _borProjectedIncomeProjectedBonuses, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Projected Income - Cost of Living Adj. [QM.X155]
        /// </summary>
        public decimal? BorProjectedIncomeProjectedCostLivingAdjustment { get => _borProjectedIncomeProjectedCostLivingAdjustment; set => SetField(ref _borProjectedIncomeProjectedCostLivingAdjustment, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Projected Income - New Job [QM.X158]
        /// </summary>
        public decimal? BorProjectedIncomeProjectedNewJobIncome { get => _borProjectedIncomeProjectedNewJobIncome; set => SetField(ref _borProjectedIncomeProjectedNewJobIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Projected Income - Performance Raises [QM.X156]
        /// </summary>
        public decimal? BorProjectedIncomeProjectedPerformanceRaises { get => _borProjectedIncomeProjectedPerformanceRaises; set => SetField(ref _borProjectedIncomeProjectedPerformanceRaises, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Projected Income - Total Projected Income [QM.X308]
        /// </summary>
        public decimal? BorProjectedIncomeTotalProjectedIncome { get => _borProjectedIncomeTotalProjectedIncome; set => SetField(ref _borProjectedIncomeTotalProjectedIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Average Overtime [QM.X229]
        /// </summary>
        public decimal? CobBonusAverageOvertime { get => _cobBonusAverageOvertime; set => SetField(ref _cobBonusAverageOvertime, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Most Recent Amount [QM.X219]
        /// </summary>
        public decimal? CobBonusMostRecentAmount { get => _cobBonusMostRecentAmount; set => SetField(ref _cobBonusMostRecentAmount, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Most Recent Months [QM.X319]
        /// </summary>
        public int? CobBonusMostRecentMonths { get => _cobBonusMostRecentMonths; set => SetField(ref _cobBonusMostRecentMonths, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Most Recent Year [QM.X355]
        /// </summary>
        public int? CobBonusMostRecentYear { get => _cobBonusMostRecentYear; set => SetField(ref _cobBonusMostRecentYear, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Amount 1 [QM.X223]
        /// </summary>
        public decimal? CobBonusPreviousAmount1 { get => _cobBonusPreviousAmount1; set => SetField(ref _cobBonusPreviousAmount1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Amount 2 [QM.X227]
        /// </summary>
        public decimal? CobBonusPreviousAmount2 { get => _cobBonusPreviousAmount2; set => SetField(ref _cobBonusPreviousAmount2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Months 1 [QM.X321]
        /// </summary>
        public int? CobBonusPreviousMonths1 { get => _cobBonusPreviousMonths1; set => SetField(ref _cobBonusPreviousMonths1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Months 2 [QM.X323]
        /// </summary>
        public int? CobBonusPreviousMonths2 { get => _cobBonusPreviousMonths2; set => SetField(ref _cobBonusPreviousMonths2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Year 1 [QM.X320]
        /// </summary>
        public int? CobBonusPreviousYear1 { get => _cobBonusPreviousYear1; set => SetField(ref _cobBonusPreviousYear1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Bonus - Previous Year 2 [QM.X322]
        /// </summary>
        public int? CobBonusPreviousYear2 { get => _cobBonusPreviousYear2; set => SetField(ref _cobBonusPreviousYear2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Average Overtime [QM.X238]
        /// </summary>
        public decimal? CobCommissionAverageOvertime { get => _cobCommissionAverageOvertime; set => SetField(ref _cobCommissionAverageOvertime, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Most Recent Amount [QM.X232]
        /// </summary>
        public decimal? CobCommissionMostRecentAmount { get => _cobCommissionMostRecentAmount; set => SetField(ref _cobCommissionMostRecentAmount, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Most Recent Months [QM.X324]
        /// </summary>
        public int? CobCommissionMostRecentMonths { get => _cobCommissionMostRecentMonths; set => SetField(ref _cobCommissionMostRecentMonths, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Most Recent Year [QM.X357]
        /// </summary>
        public int? CobCommissionMostRecentYear { get => _cobCommissionMostRecentYear; set => SetField(ref _cobCommissionMostRecentYear, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Amount 1 [QM.X236]
        /// </summary>
        public decimal? CobCommissionPreviousAmount1 { get => _cobCommissionPreviousAmount1; set => SetField(ref _cobCommissionPreviousAmount1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Amount 2 [QM.X363]
        /// </summary>
        public decimal? CobCommissionPreviousAmount2 { get => _cobCommissionPreviousAmount2; set => SetField(ref _cobCommissionPreviousAmount2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Months 1 [QM.X326]
        /// </summary>
        public int? CobCommissionPreviousMonths1 { get => _cobCommissionPreviousMonths1; set => SetField(ref _cobCommissionPreviousMonths1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Months 2 [QM.X362]
        /// </summary>
        public int? CobCommissionPreviousMonths2 { get => _cobCommissionPreviousMonths2; set => SetField(ref _cobCommissionPreviousMonths2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Year 1 [QM.X325]
        /// </summary>
        public int? CobCommissionPreviousYear1 { get => _cobCommissionPreviousYear1; set => SetField(ref _cobCommissionPreviousYear1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Commission - Previous Year 2 [QM.X361]
        /// </summary>
        public int? CobCommissionPreviousYear2 { get => _cobCommissionPreviousYear2; set => SetField(ref _cobCommissionPreviousYear2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Dividend - Average Dividend [QM.X250]
        /// </summary>
        public decimal? CobDividendAverageDividend { get => _cobDividendAverageDividend; set => SetField(ref _cobDividendAverageDividend, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Amount 1 [QM.X242]
        /// </summary>
        public decimal? CobDividendPreviousAmount1 { get => _cobDividendPreviousAmount1; set => SetField(ref _cobDividendPreviousAmount1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Amount 2 [QM.X246]
        /// </summary>
        public decimal? CobDividendPreviousAmount2 { get => _cobDividendPreviousAmount2; set => SetField(ref _cobDividendPreviousAmount2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Months 1 [QM.X328]
        /// </summary>
        public int? CobDividendPreviousMonths1 { get => _cobDividendPreviousMonths1; set => SetField(ref _cobDividendPreviousMonths1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Months 2 [QM.X330]
        /// </summary>
        public int? CobDividendPreviousMonths2 { get => _cobDividendPreviousMonths2; set => SetField(ref _cobDividendPreviousMonths2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Year 1 [QM.X327]
        /// </summary>
        public int? CobDividendPreviousYear1 { get => _cobDividendPreviousYear1; set => SetField(ref _cobDividendPreviousYear1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Dividend - Previous Year 2 [QM.X329]
        /// </summary>
        public int? CobDividendPreviousYear2 { get => _cobDividendPreviousYear2; set => SetField(ref _cobDividendPreviousYear2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Dividend - Required For Cash Inv [QM.X248]
        /// </summary>
        public decimal? CobDividendRequiredForCashAmount { get => _cobDividendRequiredForCashAmount; set => SetField(ref _cobDividendRequiredForCashAmount, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Interest - Average Dividend [QM.X262]
        /// </summary>
        public decimal? CobInterestAverageDividend { get => _cobInterestAverageDividend; set => SetField(ref _cobInterestAverageDividend, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Amount 1 [QM.X254]
        /// </summary>
        public decimal? CobInterestPreviousAmount1 { get => _cobInterestPreviousAmount1; set => SetField(ref _cobInterestPreviousAmount1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Amount 2 [QM.X258]
        /// </summary>
        public decimal? CobInterestPreviousAmount2 { get => _cobInterestPreviousAmount2; set => SetField(ref _cobInterestPreviousAmount2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Months 1 [QM.X332]
        /// </summary>
        public int? CobInterestPreviousMonths1 { get => _cobInterestPreviousMonths1; set => SetField(ref _cobInterestPreviousMonths1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Months 2 [QM.X334]
        /// </summary>
        public int? CobInterestPreviousMonths2 { get => _cobInterestPreviousMonths2; set => SetField(ref _cobInterestPreviousMonths2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Year 1 [QM.X331]
        /// </summary>
        public int? CobInterestPreviousYear1 { get => _cobInterestPreviousYear1; set => SetField(ref _cobInterestPreviousYear1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Interest - Previous Year 2 [QM.X333]
        /// </summary>
        public int? CobInterestPreviousYear2 { get => _cobInterestPreviousYear2; set => SetField(ref _cobInterestPreviousYear2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Interest - Required For Cash Inv [QM.X260]
        /// </summary>
        public decimal? CobInterestRequiredForCashAmount { get => _cobInterestRequiredForCashAmount; set => SetField(ref _cobInterestRequiredForCashAmount, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Clothing Allowance [QM.X301]
        /// </summary>
        public decimal? CobMilitaryAllowanceClothingAllowance { get => _cobMilitaryAllowanceClothingAllowance; set => SetField(ref _cobMilitaryAllowanceClothingAllowance, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Other Allowance [QM.X305]
        /// </summary>
        public decimal? CobMilitaryAllowanceOtherAllowance { get => _cobMilitaryAllowanceOtherAllowance; set => SetField(ref _cobMilitaryAllowanceOtherAllowance, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Quarters Allowance [QM.X304]
        /// </summary>
        public decimal? CobMilitaryAllowanceQuartersAllowance { get => _cobMilitaryAllowanceQuartersAllowance; set => SetField(ref _cobMilitaryAllowanceQuartersAllowance, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Rations Allowance [QM.X302]
        /// </summary>
        public decimal? CobMilitaryAllowanceRationsAllowance { get => _cobMilitaryAllowanceRationsAllowance; set => SetField(ref _cobMilitaryAllowanceRationsAllowance, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Total Allowances [QM.X306]
        /// </summary>
        public decimal? CobMilitaryAllowanceTotalAllowance { get => _cobMilitaryAllowanceTotalAllowance; set => SetField(ref _cobMilitaryAllowanceTotalAllowance, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military Allowances - Variable Housing Allowance [QM.X303]
        /// </summary>
        public decimal? CobMilitaryAllowanceVariableHousingAllowance { get => _cobMilitaryAllowanceVariableHousingAllowance; set => SetField(ref _cobMilitaryAllowanceVariableHousingAllowance, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military - Base Pay [QM.X288]
        /// </summary>
        public decimal? CobMilitaryBasePay { get => _cobMilitaryBasePay; set => SetField(ref _cobMilitaryBasePay, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military - Combat Pay [QM.X289]
        /// </summary>
        public decimal? CobMilitaryCombatPay { get => _cobMilitaryCombatPay; set => SetField(ref _cobMilitaryCombatPay, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military - Flight Pay [QM.X290]
        /// </summary>
        public decimal? CobMilitaryFlightPay { get => _cobMilitaryFlightPay; set => SetField(ref _cobMilitaryFlightPay, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military - Hazard Pay [QM.X291]
        /// </summary>
        public decimal? CobMilitaryHazardPay { get => _cobMilitaryHazardPay; set => SetField(ref _cobMilitaryHazardPay, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military - Overseas Pay [QM.X292]
        /// </summary>
        public decimal? CobMilitaryOverseasPay { get => _cobMilitaryOverseasPay; set => SetField(ref _cobMilitaryOverseasPay, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military - Prop Pay [QM.X293]
        /// </summary>
        public decimal? CobMilitaryPropPay { get => _cobMilitaryPropPay; set => SetField(ref _cobMilitaryPropPay, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Military - Total Military Income [QM.X294]
        /// </summary>
        public decimal? CobMilitaryTotalPay { get => _cobMilitaryTotalPay; set => SetField(ref _cobMilitaryTotalPay, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Base [QM.X145]
        /// </summary>
        public decimal? CobMonthlyEmplymentIncomeBaseIncome { get => _cobMonthlyEmplymentIncomeBaseIncome; set => SetField(ref _cobMonthlyEmplymentIncomeBaseIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Bonuses [QM.X147]
        /// </summary>
        public decimal? CobMonthlyEmplymentIncomeBonuseIncome { get => _cobMonthlyEmplymentIncomeBonuseIncome; set => SetField(ref _cobMonthlyEmplymentIncomeBonuseIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Commissions [QM.X148]
        /// </summary>
        public decimal? CobMonthlyEmplymentIncomeCommissionIncome { get => _cobMonthlyEmplymentIncomeCommissionIncome; set => SetField(ref _cobMonthlyEmplymentIncomeCommissionIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Dividend and Interest [QM.X149]
        /// </summary>
        public decimal? CobMonthlyEmplymentIncomeDividendInterestIncome { get => _cobMonthlyEmplymentIncomeDividendInterestIncome; set => SetField(ref _cobMonthlyEmplymentIncomeDividendInterestIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Other Income 1 [QM.X150]
        /// </summary>
        public decimal? CobMonthlyEmplymentIncomeOtherIncome1 { get => _cobMonthlyEmplymentIncomeOtherIncome1; set => SetField(ref _cobMonthlyEmplymentIncomeOtherIncome1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Other Income 2 [QM.X151]
        /// </summary>
        public decimal? CobMonthlyEmplymentIncomeOtherIncome2 { get => _cobMonthlyEmplymentIncomeOtherIncome2; set => SetField(ref _cobMonthlyEmplymentIncomeOtherIncome2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Overtime [QM.X146]
        /// </summary>
        public decimal? CobMonthlyEmplymentIncomeOvertimeIncome { get => _cobMonthlyEmplymentIncomeOvertimeIncome; set => SetField(ref _cobMonthlyEmplymentIncomeOvertimeIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Total Monthly Employment Income [QM.X152]
        /// </summary>
        public decimal? CobMonthlyEmplymentIncomeTotalEmploymentIncome { get => _cobMonthlyEmplymentIncomeTotalEmploymentIncome; set => SetField(ref _cobMonthlyEmplymentIncomeTotalEmploymentIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non-Employment Income - Government Assitant Program [QM.X170]
        /// </summary>
        public decimal? CobNonEmploymentIncomeGovtAssitProgramIncome { get => _cobNonEmploymentIncomeGovtAssitProgramIncome; set => SetField(ref _cobNonEmploymentIncomeGovtAssitProgramIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non-Employment Income - Homeown. Subsidy [QM.X172]
        /// </summary>
        public decimal? CobNonEmploymentIncomeHomeownSubsidyIncome { get => _cobNonEmploymentIncomeHomeownSubsidyIncome; set => SetField(ref _cobNonEmploymentIncomeHomeownSubsidyIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non-Employment Income - Military [QM.X168]
        /// </summary>
        public decimal? CobNonEmploymentIncomeMilitaryIncome { get => _cobNonEmploymentIncomeMilitaryIncome; set => SetField(ref _cobNonEmploymentIncomeMilitaryIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non-Employment Income - Mtg. Credit Certificate Income [QM.X171]
        /// </summary>
        public decimal? CobNonEmploymentIncomeMtgCreditCertificateIncome { get => _cobNonEmploymentIncomeMtgCreditCertificateIncome; set => SetField(ref _cobNonEmploymentIncomeMtgCreditCertificateIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non-Employment Income - Total [QM.X311]
        /// </summary>
        public decimal? CobNonEmploymentIncomeTotalNonEmploymentIncome { get => _cobNonEmploymentIncomeTotalNonEmploymentIncome; set => SetField(ref _cobNonEmploymentIncomeTotalNonEmploymentIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non-Employment Income - VA Benefit [QM.X169]
        /// </summary>
        public decimal? CobNonEmploymentIncomeVABenefitIncome { get => _cobNonEmploymentIncomeVABenefitIncome; set => SetField(ref _cobNonEmploymentIncomeVABenefitIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non Taxable Income - Child Support [QM.X188]
        /// </summary>
        public decimal? CobNonTaxableIncomeChildSupportIncome { get => _cobNonTaxableIncomeChildSupportIncome; set => SetField(ref _cobNonTaxableIncomeChildSupportIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non Taxable Income - Disability [QM.X186]
        /// </summary>
        public decimal? CobNonTaxableIncomeDisabilityIncome { get => _cobNonTaxableIncomeDisabilityIncome; set => SetField(ref _cobNonTaxableIncomeDisabilityIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non Taxable Income - Fed Govt. Empl. Retirement [QM.X183]
        /// </summary>
        public decimal? CobNonTaxableIncomeFedGovtEmplRetirementIncome { get => _cobNonTaxableIncomeFedGovtEmplRetirementIncome; set => SetField(ref _cobNonTaxableIncomeFedGovtEmplRetirementIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non Taxable Income - Military Allowances [QM.X189]
        /// </summary>
        public decimal? CobNonTaxableIncomeMilitaryAllowances { get => _cobNonTaxableIncomeMilitaryAllowances; set => SetField(ref _cobNonTaxableIncomeMilitaryAllowances, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non Taxable Income - Other Income [QM.X190]
        /// </summary>
        public decimal? CobNonTaxableIncomeOtherIncome { get => _cobNonTaxableIncomeOtherIncome; set => SetField(ref _cobNonTaxableIncomeOtherIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non Taxable Income - Public Assistant Payments [QM.X187]
        /// </summary>
        public decimal? CobNonTaxableIncomePublicAssistPayments { get => _cobNonTaxableIncomePublicAssistPayments; set => SetField(ref _cobNonTaxableIncomePublicAssistPayments, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non Taxable Income - Railroad Retirement Benefits [QM.X184]
        /// </summary>
        public decimal? CobNonTaxableIncomeRailroadRetirementBenefits { get => _cobNonTaxableIncomeRailroadRetirementBenefits; set => SetField(ref _cobNonTaxableIncomeRailroadRetirementBenefits, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non Taxable Income - Social Security [QM.X182]
        /// </summary>
        public decimal? CobNonTaxableIncomeSocialSecurityIncome { get => _cobNonTaxableIncomeSocialSecurityIncome; set => SetField(ref _cobNonTaxableIncomeSocialSecurityIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non Taxable Income - State Gov't. Empl. Retirement [QM.X185]
        /// </summary>
        public decimal? CobNonTaxableIncomeStateGovtEmplRetirementIncome { get => _cobNonTaxableIncomeStateGovtEmplRetirementIncome; set => SetField(ref _cobNonTaxableIncomeStateGovtEmplRetirementIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Non-Taxable Income - Total [QM.X313]
        /// </summary>
        public decimal? CobNonTaxableIncomeTotalNonTaxableIncome { get => _cobNonTaxableIncomeTotalNonTaxableIncome; set => SetField(ref _cobNonTaxableIncomeTotalNonTaxableIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Other - Notes Receivable [QM.X280]
        /// </summary>
        public decimal? CobOtherNotesReceivableIncome { get => _cobOtherNotesReceivableIncome; set => SetField(ref _cobOtherNotesReceivableIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Other Income - Other [QM.X272]
        /// </summary>
        public decimal? CobOtherOtherIncome { get => _cobOtherOtherIncome; set => SetField(ref _cobOtherOtherIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Other - Part-time [QM.X278]
        /// </summary>
        public decimal? CobOtherParttimeIncome { get => _cobOtherParttimeIncome; set => SetField(ref _cobOtherParttimeIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Other - Retirement [QM.X273]
        /// </summary>
        public decimal? CobOtherRetirementIncome { get => _cobOtherRetirementIncome; set => SetField(ref _cobOtherRetirementIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Other - Seasonal [QM.X279]
        /// </summary>
        public decimal? CobOtherSeasonalIncome { get => _cobOtherSeasonalIncome; set => SetField(ref _cobOtherSeasonalIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Other - Social Security [QM.X274]
        /// </summary>
        public decimal? CobOtherSocialSecurityIncome { get => _cobOtherSocialSecurityIncome; set => SetField(ref _cobOtherSocialSecurityIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Other - Tip [QM.X277]
        /// </summary>
        public decimal? CobOtherTipIncome { get => _cobOtherTipIncome; set => SetField(ref _cobOtherTipIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Other - Trust [QM.X275]
        /// </summary>
        public decimal? CobOtherTrustIncome { get => _cobOtherTrustIncome; set => SetField(ref _cobOtherTrustIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Other - Unemployment [QM.X276]
        /// </summary>
        public decimal? CobOtherUnemploymentIncome { get => _cobOtherUnemploymentIncome; set => SetField(ref _cobOtherUnemploymentIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Average Overtime [QM.X216]
        /// </summary>
        public decimal? CobOvertimeAverageOvertime { get => _cobOvertimeAverageOvertime; set => SetField(ref _cobOvertimeAverageOvertime, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Most Recent Amount [QM.X206]
        /// </summary>
        public decimal? CobOvertimeMostRecentAmount { get => _cobOvertimeMostRecentAmount; set => SetField(ref _cobOvertimeMostRecentAmount, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Most Recent Months [QM.X314]
        /// </summary>
        public int? CobOvertimeMostRecentMonths { get => _cobOvertimeMostRecentMonths; set => SetField(ref _cobOvertimeMostRecentMonths, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Most Recent Year [QM.X353]
        /// </summary>
        public int? CobOvertimeMostRecentYear { get => _cobOvertimeMostRecentYear; set => SetField(ref _cobOvertimeMostRecentYear, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Amount 1 [QM.X210]
        /// </summary>
        public decimal? CobOvertimePreviousAmount1 { get => _cobOvertimePreviousAmount1; set => SetField(ref _cobOvertimePreviousAmount1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Amount 2 [QM.X214]
        /// </summary>
        public decimal? CobOvertimePreviousAmount2 { get => _cobOvertimePreviousAmount2; set => SetField(ref _cobOvertimePreviousAmount2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Months 1 [QM.X316]
        /// </summary>
        public int? CobOvertimePreviousMonths1 { get => _cobOvertimePreviousMonths1; set => SetField(ref _cobOvertimePreviousMonths1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Months 2 [QM.X318]
        /// </summary>
        public int? CobOvertimePreviousMonths2 { get => _cobOvertimePreviousMonths2; set => SetField(ref _cobOvertimePreviousMonths2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Year 1 [QM.X315]
        /// </summary>
        public int? CobOvertimePreviousYear1 { get => _cobOvertimePreviousYear1; set => SetField(ref _cobOvertimePreviousYear1, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income Details - Overtime - Previous Year 2 [QM.X317]
        /// </summary>
        public int? CobOvertimePreviousYear2 { get => _cobOvertimePreviousYear2; set => SetField(ref _cobOvertimePreviousYear2, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Projected Income - Bonuses [QM.X161]
        /// </summary>
        public decimal? CobProjectedIncomeProjectedBonuses { get => _cobProjectedIncomeProjectedBonuses; set => SetField(ref _cobProjectedIncomeProjectedBonuses, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Projected Income - Cost of Living Adj. [QM.X159]
        /// </summary>
        public decimal? CobProjectedIncomeProjectedCostLivingAdjustment { get => _cobProjectedIncomeProjectedCostLivingAdjustment; set => SetField(ref _cobProjectedIncomeProjectedCostLivingAdjustment, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Projected Income - New Job [QM.X162]
        /// </summary>
        public decimal? CobProjectedIncomeProjectedNewJobIncome { get => _cobProjectedIncomeProjectedNewJobIncome; set => SetField(ref _cobProjectedIncomeProjectedNewJobIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Projected Income - Performance Raises [QM.X160]
        /// </summary>
        public decimal? CobProjectedIncomeProjectedPerformanceRaises { get => _cobProjectedIncomeProjectedPerformanceRaises; set => SetField(ref _cobProjectedIncomeProjectedPerformanceRaises, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Projected Income - Total Projected Income [QM.X309]
        /// </summary>
        public decimal? CobProjectedIncomeTotalProjectedIncome { get => _cobProjectedIncomeTotalProjectedIncome; set => SetField(ref _cobProjectedIncomeTotalProjectedIncome, value); }

        /// <summary>
        /// AUS Tracking - Latest Submission - DU Case ID/ LP AUS Key # [AUSF.X4]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? DUCaseIDorLPAUSKey { get => _dUCaseIDorLPAUSKey; set => SetField(ref _dUCaseIDorLPAUSKey, value); }

        /// <summary>
        /// AUS Tracking - Latest Submission - First Submission Date [AUSF.X9]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? FirstSubmissionDate { get => _firstSubmissionDate; set => SetField(ref _firstSubmissionDate, value); }

        /// <summary>
        /// AUS Tracking - Latest Submission - First Submission Time [AUSF.X10]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? FirstSubmissionTime { get => _firstSubmissionTime; set => SetField(ref _firstSubmissionTime, value); }

        /// <summary>
        /// AUS Tracking - Latest Submission - Doc Class (Freddie) [AUSF.X5]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? FreddieDocClass { get => _freddieDocClass; set => SetField(ref _freddieDocClass, value); }

        /// <summary>
        /// AUS Tracking - Latest Submission - Housing Ratio [AUSF.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? HousingRatio { get => _housingRatio; set => SetField(ref _housingRatio, value); }

        /// <summary>
        /// ATRQMBorrower Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// ATRQMBorrower IsEmpty
        /// </summary>
        public bool? IsEmpty { get => _isEmpty; set => SetField(ref _isEmpty, value); }

        /// <summary>
        /// AUS Tracking - Latest Submission - Submission Date [AUSF.X7]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? SubmissionDate { get => _submissionDate; set => SetField(ref _submissionDate, value); }

        /// <summary>
        /// AUS Tracking - Latest Submission - Submission Number [AUSF.X11]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? SubmissionNumber { get => _submissionNumber; set => SetField(ref _submissionNumber, value); }

        /// <summary>
        /// AUS Tracking - Latest Submission - Submission Time [AUSF.X8]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? SubmissionTime { get => _submissionTime; set => SetField(ref _submissionTime, value); }

        /// <summary>
        /// AUS Tracking - Latest Submission - Submitted By [AUSF.X6]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? SubmittedBy { get => _submittedBy; set => SetField(ref _submittedBy, value); }

        /// <summary>
        /// AUS Tracking - Latest Submission - Total Expense Ratio [AUSF.X18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? TotalExpenseRatio { get => _totalExpenseRatio; set => SetField(ref _totalExpenseRatio, value); }

        /// <summary>
        /// AUS Tracking - Latest Submission - Total Housing Payment [AUSF.X13]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalHousingPayment { get => _totalHousingPayment; set => SetField(ref _totalHousingPayment, value); }

        /// <summary>
        /// AUS Tracking - Latest Submission - Total Monthly Assets [AUSF.X15]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalMonthlyAssets { get => _totalMonthlyAssets; set => SetField(ref _totalMonthlyAssets, value); }

        /// <summary>
        /// AUS Tracking - Latest Submission - Total Monthly Debt [AUSF.X16]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalMonthlyDebt { get => _totalMonthlyDebt; set => SetField(ref _totalMonthlyDebt, value); }

        /// <summary>
        /// AUS Tracking - Latest Submission - Total Monthly Income [AUSF.X14]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalMonthlyIncome { get => _totalMonthlyIncome; set => SetField(ref _totalMonthlyIncome, value); }

        /// <summary>
        /// AUS Tracking - Latest Submission - Underwriting Risk Assess Other Type [AUSF.X2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? UnderwritingRiskAssessOther { get => _underwritingRiskAssessOther; set => SetField(ref _underwritingRiskAssessOther, value); }

        /// <summary>
        /// AUS Tracking - Latest Submission - Underwriting Risk Assess Type [AUSF.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? UnderwritingRiskAssessType { get => _underwritingRiskAssessType; set => SetField(ref _underwritingRiskAssessType, value); }
    }
}