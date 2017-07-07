using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ATRQMBorrower : IClean
    {
        private Value<int?> _aTRQMBorrowerIndex;
        public int? ATRQMBorrowerIndex { get { return _aTRQMBorrowerIndex; } set { _aTRQMBorrowerIndex = value; } }
        private Value<string> _aUSRecommendation;
        public string AUSRecommendation { get { return _aUSRecommendation; } set { _aUSRecommendation = value; } }
        private Value<string> _aUSVersion;
        public string AUSVersion { get { return _aUSVersion; } set { _aUSVersion = value; } }
        private Value<decimal?> _borBonusAverageOvertime;
        public decimal? BorBonusAverageOvertime { get { return _borBonusAverageOvertime; } set { _borBonusAverageOvertime = value; } }
        private Value<decimal?> _borBonusMostRecentAmount;
        public decimal? BorBonusMostRecentAmount { get { return _borBonusMostRecentAmount; } set { _borBonusMostRecentAmount = value; } }
        private Value<int?> _borBonusMostRecentMonths;
        public int? BorBonusMostRecentMonths { get { return _borBonusMostRecentMonths; } set { _borBonusMostRecentMonths = value; } }
        private Value<int?> _borBonusMostRecentYear;
        public int? BorBonusMostRecentYear { get { return _borBonusMostRecentYear; } set { _borBonusMostRecentYear = value; } }
        private Value<decimal?> _borBonusPreviousAmount1;
        public decimal? BorBonusPreviousAmount1 { get { return _borBonusPreviousAmount1; } set { _borBonusPreviousAmount1 = value; } }
        private Value<decimal?> _borBonusPreviousAmount2;
        public decimal? BorBonusPreviousAmount2 { get { return _borBonusPreviousAmount2; } set { _borBonusPreviousAmount2 = value; } }
        private Value<int?> _borBonusPreviousMonths1;
        public int? BorBonusPreviousMonths1 { get { return _borBonusPreviousMonths1; } set { _borBonusPreviousMonths1 = value; } }
        private Value<int?> _borBonusPreviousMonths2;
        public int? BorBonusPreviousMonths2 { get { return _borBonusPreviousMonths2; } set { _borBonusPreviousMonths2 = value; } }
        private Value<int?> _borBonusPreviousYear1;
        public int? BorBonusPreviousYear1 { get { return _borBonusPreviousYear1; } set { _borBonusPreviousYear1 = value; } }
        private Value<int?> _borBonusPreviousYear2;
        public int? BorBonusPreviousYear2 { get { return _borBonusPreviousYear2; } set { _borBonusPreviousYear2 = value; } }
        private Value<decimal?> _borCommissionAverageOvertime;
        public decimal? BorCommissionAverageOvertime { get { return _borCommissionAverageOvertime; } set { _borCommissionAverageOvertime = value; } }
        private Value<decimal?> _borCommissionMostRecentAmount;
        public decimal? BorCommissionMostRecentAmount { get { return _borCommissionMostRecentAmount; } set { _borCommissionMostRecentAmount = value; } }
        private Value<int?> _borCommissionMostRecentMonths;
        public int? BorCommissionMostRecentMonths { get { return _borCommissionMostRecentMonths; } set { _borCommissionMostRecentMonths = value; } }
        private Value<int?> _borCommissionMostRecentYear;
        public int? BorCommissionMostRecentYear { get { return _borCommissionMostRecentYear; } set { _borCommissionMostRecentYear = value; } }
        private Value<decimal?> _borCommissionPreviousAmount1;
        public decimal? BorCommissionPreviousAmount1 { get { return _borCommissionPreviousAmount1; } set { _borCommissionPreviousAmount1 = value; } }
        private Value<decimal?> _borCommissionPreviousAmount2;
        public decimal? BorCommissionPreviousAmount2 { get { return _borCommissionPreviousAmount2; } set { _borCommissionPreviousAmount2 = value; } }
        private Value<int?> _borCommissionPreviousMonths1;
        public int? BorCommissionPreviousMonths1 { get { return _borCommissionPreviousMonths1; } set { _borCommissionPreviousMonths1 = value; } }
        private Value<int?> _borCommissionPreviousMonths2;
        public int? BorCommissionPreviousMonths2 { get { return _borCommissionPreviousMonths2; } set { _borCommissionPreviousMonths2 = value; } }
        private Value<int?> _borCommissionPreviousYear1;
        public int? BorCommissionPreviousYear1 { get { return _borCommissionPreviousYear1; } set { _borCommissionPreviousYear1 = value; } }
        private Value<int?> _borCommissionPreviousYear2;
        public int? BorCommissionPreviousYear2 { get { return _borCommissionPreviousYear2; } set { _borCommissionPreviousYear2 = value; } }
        private Value<decimal?> _borContingentLiabilitiesLiabilityAmount1;
        public decimal? BorContingentLiabilitiesLiabilityAmount1 { get { return _borContingentLiabilitiesLiabilityAmount1; } set { _borContingentLiabilitiesLiabilityAmount1 = value; } }
        private Value<decimal?> _borContingentLiabilitiesLiabilityAmount2;
        public decimal? BorContingentLiabilitiesLiabilityAmount2 { get { return _borContingentLiabilitiesLiabilityAmount2; } set { _borContingentLiabilitiesLiabilityAmount2 = value; } }
        private Value<decimal?> _borContingentLiabilitiesLiabilityAmount3;
        public decimal? BorContingentLiabilitiesLiabilityAmount3 { get { return _borContingentLiabilitiesLiabilityAmount3; } set { _borContingentLiabilitiesLiabilityAmount3 = value; } }
        private Value<string> _borContingentLiabilitiesLiabilityDescription1;
        public string BorContingentLiabilitiesLiabilityDescription1 { get { return _borContingentLiabilitiesLiabilityDescription1; } set { _borContingentLiabilitiesLiabilityDescription1 = value; } }
        private Value<string> _borContingentLiabilitiesLiabilityDescription2;
        public string BorContingentLiabilitiesLiabilityDescription2 { get { return _borContingentLiabilitiesLiabilityDescription2; } set { _borContingentLiabilitiesLiabilityDescription2 = value; } }
        private Value<string> _borContingentLiabilitiesLiabilityDescription3;
        public string BorContingentLiabilitiesLiabilityDescription3 { get { return _borContingentLiabilitiesLiabilityDescription3; } set { _borContingentLiabilitiesLiabilityDescription3 = value; } }
        private Value<decimal?> _borContingentLiabilitiesTotalLiabilityAmount;
        public decimal? BorContingentLiabilitiesTotalLiabilityAmount { get { return _borContingentLiabilitiesTotalLiabilityAmount; } set { _borContingentLiabilitiesTotalLiabilityAmount = value; } }
        private Value<decimal?> _borCosignedObligationsCarLoanPayment;
        public decimal? BorCosignedObligationsCarLoanPayment { get { return _borCosignedObligationsCarLoanPayment; } set { _borCosignedObligationsCarLoanPayment = value; } }
        private Value<decimal?> _borCosignedObligationsMortgagePayment;
        public decimal? BorCosignedObligationsMortgagePayment { get { return _borCosignedObligationsMortgagePayment; } set { _borCosignedObligationsMortgagePayment = value; } }
        private Value<decimal?> _borCosignedObligationsOtherPayment;
        public decimal? BorCosignedObligationsOtherPayment { get { return _borCosignedObligationsOtherPayment; } set { _borCosignedObligationsOtherPayment = value; } }
        private Value<string> _borCosignedObligationsOtherPaymentDescription;
        public string BorCosignedObligationsOtherPaymentDescription { get { return _borCosignedObligationsOtherPaymentDescription; } set { _borCosignedObligationsOtherPaymentDescription = value; } }
        private Value<decimal?> _borCosignedObligationsStudentLoanPayment;
        public decimal? BorCosignedObligationsStudentLoanPayment { get { return _borCosignedObligationsStudentLoanPayment; } set { _borCosignedObligationsStudentLoanPayment = value; } }
        private Value<decimal?> _borCosignedObligationsTotalCoMortgagorLiabilities;
        public decimal? BorCosignedObligationsTotalCoMortgagorLiabilities { get { return _borCosignedObligationsTotalCoMortgagorLiabilities; } set { _borCosignedObligationsTotalCoMortgagorLiabilities = value; } }
        private Value<decimal?> _borDividendAverageDividend;
        public decimal? BorDividendAverageDividend { get { return _borDividendAverageDividend; } set { _borDividendAverageDividend = value; } }
        private Value<decimal?> _borDividendPreviousAmount1;
        public decimal? BorDividendPreviousAmount1 { get { return _borDividendPreviousAmount1; } set { _borDividendPreviousAmount1 = value; } }
        private Value<decimal?> _borDividendPreviousAmount2;
        public decimal? BorDividendPreviousAmount2 { get { return _borDividendPreviousAmount2; } set { _borDividendPreviousAmount2 = value; } }
        private Value<int?> _borDividendPreviousMonths1;
        public int? BorDividendPreviousMonths1 { get { return _borDividendPreviousMonths1; } set { _borDividendPreviousMonths1 = value; } }
        private Value<int?> _borDividendPreviousMonths2;
        public int? BorDividendPreviousMonths2 { get { return _borDividendPreviousMonths2; } set { _borDividendPreviousMonths2 = value; } }
        private Value<int?> _borDividendPreviousYear1;
        public int? BorDividendPreviousYear1 { get { return _borDividendPreviousYear1; } set { _borDividendPreviousYear1 = value; } }
        private Value<int?> _borDividendPreviousYear2;
        public int? BorDividendPreviousYear2 { get { return _borDividendPreviousYear2; } set { _borDividendPreviousYear2 = value; } }
        private Value<decimal?> _borDividendRequiredForCashAmount;
        public decimal? BorDividendRequiredForCashAmount { get { return _borDividendRequiredForCashAmount; } set { _borDividendRequiredForCashAmount = value; } }
        private Value<decimal?> _borInterestAverageDividend;
        public decimal? BorInterestAverageDividend { get { return _borInterestAverageDividend; } set { _borInterestAverageDividend = value; } }
        private Value<decimal?> _borInterestPreviousAmount1;
        public decimal? BorInterestPreviousAmount1 { get { return _borInterestPreviousAmount1; } set { _borInterestPreviousAmount1 = value; } }
        private Value<decimal?> _borInterestPreviousAmount2;
        public decimal? BorInterestPreviousAmount2 { get { return _borInterestPreviousAmount2; } set { _borInterestPreviousAmount2 = value; } }
        private Value<int?> _borInterestPreviousMonths1;
        public int? BorInterestPreviousMonths1 { get { return _borInterestPreviousMonths1; } set { _borInterestPreviousMonths1 = value; } }
        private Value<int?> _borInterestPreviousMonths2;
        public int? BorInterestPreviousMonths2 { get { return _borInterestPreviousMonths2; } set { _borInterestPreviousMonths2 = value; } }
        private Value<int?> _borInterestPreviousYear1;
        public int? BorInterestPreviousYear1 { get { return _borInterestPreviousYear1; } set { _borInterestPreviousYear1 = value; } }
        private Value<int?> _borInterestPreviousYear2;
        public int? BorInterestPreviousYear2 { get { return _borInterestPreviousYear2; } set { _borInterestPreviousYear2 = value; } }
        private Value<decimal?> _borInterestRequiredForCashAmount;
        public decimal? BorInterestRequiredForCashAmount { get { return _borInterestRequiredForCashAmount; } set { _borInterestRequiredForCashAmount = value; } }
        private Value<decimal?> _borMilitaryAllowanceClothingAllowance;
        public decimal? BorMilitaryAllowanceClothingAllowance { get { return _borMilitaryAllowanceClothingAllowance; } set { _borMilitaryAllowanceClothingAllowance = value; } }
        private Value<decimal?> _borMilitaryAllowanceOtherAllowance;
        public decimal? BorMilitaryAllowanceOtherAllowance { get { return _borMilitaryAllowanceOtherAllowance; } set { _borMilitaryAllowanceOtherAllowance = value; } }
        private Value<string> _borMilitaryAllowanceOtherAllowanceDescription;
        public string BorMilitaryAllowanceOtherAllowanceDescription { get { return _borMilitaryAllowanceOtherAllowanceDescription; } set { _borMilitaryAllowanceOtherAllowanceDescription = value; } }
        private Value<decimal?> _borMilitaryAllowanceQuartersAllowance;
        public decimal? BorMilitaryAllowanceQuartersAllowance { get { return _borMilitaryAllowanceQuartersAllowance; } set { _borMilitaryAllowanceQuartersAllowance = value; } }
        private Value<decimal?> _borMilitaryAllowanceRationsAllowance;
        public decimal? BorMilitaryAllowanceRationsAllowance { get { return _borMilitaryAllowanceRationsAllowance; } set { _borMilitaryAllowanceRationsAllowance = value; } }
        private Value<decimal?> _borMilitaryAllowanceTotalAllowance;
        public decimal? BorMilitaryAllowanceTotalAllowance { get { return _borMilitaryAllowanceTotalAllowance; } set { _borMilitaryAllowanceTotalAllowance = value; } }
        private Value<decimal?> _borMilitaryAllowanceVariableHousingAllowance;
        public decimal? BorMilitaryAllowanceVariableHousingAllowance { get { return _borMilitaryAllowanceVariableHousingAllowance; } set { _borMilitaryAllowanceVariableHousingAllowance = value; } }
        private Value<decimal?> _borMilitaryBasePay;
        public decimal? BorMilitaryBasePay { get { return _borMilitaryBasePay; } set { _borMilitaryBasePay = value; } }
        private Value<decimal?> _borMilitaryCombatPay;
        public decimal? BorMilitaryCombatPay { get { return _borMilitaryCombatPay; } set { _borMilitaryCombatPay = value; } }
        private Value<decimal?> _borMilitaryFlightPay;
        public decimal? BorMilitaryFlightPay { get { return _borMilitaryFlightPay; } set { _borMilitaryFlightPay = value; } }
        private Value<decimal?> _borMilitaryHazardPay;
        public decimal? BorMilitaryHazardPay { get { return _borMilitaryHazardPay; } set { _borMilitaryHazardPay = value; } }
        private Value<decimal?> _borMilitaryOverseasPay;
        public decimal? BorMilitaryOverseasPay { get { return _borMilitaryOverseasPay; } set { _borMilitaryOverseasPay = value; } }
        private Value<decimal?> _borMilitaryPropPay;
        public decimal? BorMilitaryPropPay { get { return _borMilitaryPropPay; } set { _borMilitaryPropPay = value; } }
        private Value<decimal?> _borMilitaryTotalPay;
        public decimal? BorMilitaryTotalPay { get { return _borMilitaryTotalPay; } set { _borMilitaryTotalPay = value; } }
        private Value<decimal?> _borMonthlyEmplymentIncomeBaseIncome;
        public decimal? BorMonthlyEmplymentIncomeBaseIncome { get { return _borMonthlyEmplymentIncomeBaseIncome; } set { _borMonthlyEmplymentIncomeBaseIncome = value; } }
        private Value<decimal?> _borMonthlyEmplymentIncomeBonuseIncome;
        public decimal? BorMonthlyEmplymentIncomeBonuseIncome { get { return _borMonthlyEmplymentIncomeBonuseIncome; } set { _borMonthlyEmplymentIncomeBonuseIncome = value; } }
        private Value<decimal?> _borMonthlyEmplymentIncomeCommissionIncome;
        public decimal? BorMonthlyEmplymentIncomeCommissionIncome { get { return _borMonthlyEmplymentIncomeCommissionIncome; } set { _borMonthlyEmplymentIncomeCommissionIncome = value; } }
        private Value<decimal?> _borMonthlyEmplymentIncomeDividendInterestIncome;
        public decimal? BorMonthlyEmplymentIncomeDividendInterestIncome { get { return _borMonthlyEmplymentIncomeDividendInterestIncome; } set { _borMonthlyEmplymentIncomeDividendInterestIncome = value; } }
        private Value<decimal?> _borMonthlyEmplymentIncomeOtherIncome1;
        public decimal? BorMonthlyEmplymentIncomeOtherIncome1 { get { return _borMonthlyEmplymentIncomeOtherIncome1; } set { _borMonthlyEmplymentIncomeOtherIncome1 = value; } }
        private Value<decimal?> _borMonthlyEmplymentIncomeOtherIncome2;
        public decimal? BorMonthlyEmplymentIncomeOtherIncome2 { get { return _borMonthlyEmplymentIncomeOtherIncome2; } set { _borMonthlyEmplymentIncomeOtherIncome2 = value; } }
        private Value<decimal?> _borMonthlyEmplymentIncomeOvertimeIncome;
        public decimal? BorMonthlyEmplymentIncomeOvertimeIncome { get { return _borMonthlyEmplymentIncomeOvertimeIncome; } set { _borMonthlyEmplymentIncomeOvertimeIncome = value; } }
        private Value<decimal?> _borMonthlyEmplymentIncomeTotalEmploymentIncome;
        public decimal? BorMonthlyEmplymentIncomeTotalEmploymentIncome { get { return _borMonthlyEmplymentIncomeTotalEmploymentIncome; } set { _borMonthlyEmplymentIncomeTotalEmploymentIncome = value; } }
        private Value<decimal?> _borNonEmploymentIncomeGovtAssitProgramIncome;
        public decimal? BorNonEmploymentIncomeGovtAssitProgramIncome { get { return _borNonEmploymentIncomeGovtAssitProgramIncome; } set { _borNonEmploymentIncomeGovtAssitProgramIncome = value; } }
        private Value<decimal?> _borNonEmploymentIncomeHomeownSubsidyIncome;
        public decimal? BorNonEmploymentIncomeHomeownSubsidyIncome { get { return _borNonEmploymentIncomeHomeownSubsidyIncome; } set { _borNonEmploymentIncomeHomeownSubsidyIncome = value; } }
        private Value<bool?> _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome;
        public bool? BorNonEmploymentIncomeIsOffsetHomeownSubsidyIncome { get { return _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome; } set { _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome = value; } }
        private Value<bool?> _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome;
        public bool? BorNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome { get { return _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome; } set { _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome = value; } }
        private Value<decimal?> _borNonEmploymentIncomeMilitaryIncome;
        public decimal? BorNonEmploymentIncomeMilitaryIncome { get { return _borNonEmploymentIncomeMilitaryIncome; } set { _borNonEmploymentIncomeMilitaryIncome = value; } }
        private Value<decimal?> _borNonEmploymentIncomeMtgCreditCertificateIncome;
        public decimal? BorNonEmploymentIncomeMtgCreditCertificateIncome { get { return _borNonEmploymentIncomeMtgCreditCertificateIncome; } set { _borNonEmploymentIncomeMtgCreditCertificateIncome = value; } }
        private Value<decimal?> _borNonEmploymentIncomeTotalNonEmploymentIncome;
        public decimal? BorNonEmploymentIncomeTotalNonEmploymentIncome { get { return _borNonEmploymentIncomeTotalNonEmploymentIncome; } set { _borNonEmploymentIncomeTotalNonEmploymentIncome = value; } }
        private Value<decimal?> _borNonEmploymentIncomeVABenefitIncome;
        public decimal? BorNonEmploymentIncomeVABenefitIncome { get { return _borNonEmploymentIncomeVABenefitIncome; } set { _borNonEmploymentIncomeVABenefitIncome = value; } }
        private Value<decimal?> _borNonTaxableIncomeChildSupportIncome;
        public decimal? BorNonTaxableIncomeChildSupportIncome { get { return _borNonTaxableIncomeChildSupportIncome; } set { _borNonTaxableIncomeChildSupportIncome = value; } }
        private Value<decimal?> _borNonTaxableIncomeDisabilityIncome;
        public decimal? BorNonTaxableIncomeDisabilityIncome { get { return _borNonTaxableIncomeDisabilityIncome; } set { _borNonTaxableIncomeDisabilityIncome = value; } }
        private Value<decimal?> _borNonTaxableIncomeFedGovtEmplRetirementIncome;
        public decimal? BorNonTaxableIncomeFedGovtEmplRetirementIncome { get { return _borNonTaxableIncomeFedGovtEmplRetirementIncome; } set { _borNonTaxableIncomeFedGovtEmplRetirementIncome = value; } }
        private Value<decimal?> _borNonTaxableIncomeMilitaryAllowances;
        public decimal? BorNonTaxableIncomeMilitaryAllowances { get { return _borNonTaxableIncomeMilitaryAllowances; } set { _borNonTaxableIncomeMilitaryAllowances = value; } }
        private Value<decimal?> _borNonTaxableIncomeOtherIncome;
        public decimal? BorNonTaxableIncomeOtherIncome { get { return _borNonTaxableIncomeOtherIncome; } set { _borNonTaxableIncomeOtherIncome = value; } }
        private Value<decimal?> _borNonTaxableIncomePublicAssistPayments;
        public decimal? BorNonTaxableIncomePublicAssistPayments { get { return _borNonTaxableIncomePublicAssistPayments; } set { _borNonTaxableIncomePublicAssistPayments = value; } }
        private Value<decimal?> _borNonTaxableIncomeRailroadRetirementBenefits;
        public decimal? BorNonTaxableIncomeRailroadRetirementBenefits { get { return _borNonTaxableIncomeRailroadRetirementBenefits; } set { _borNonTaxableIncomeRailroadRetirementBenefits = value; } }
        private Value<decimal?> _borNonTaxableIncomeSocialSecurityIncome;
        public decimal? BorNonTaxableIncomeSocialSecurityIncome { get { return _borNonTaxableIncomeSocialSecurityIncome; } set { _borNonTaxableIncomeSocialSecurityIncome = value; } }
        private Value<decimal?> _borNonTaxableIncomeStateGovtEmplRetirementIncome;
        public decimal? BorNonTaxableIncomeStateGovtEmplRetirementIncome { get { return _borNonTaxableIncomeStateGovtEmplRetirementIncome; } set { _borNonTaxableIncomeStateGovtEmplRetirementIncome = value; } }
        private Value<decimal?> _borNonTaxableIncomeTotalNonTaxableIncome;
        public decimal? BorNonTaxableIncomeTotalNonTaxableIncome { get { return _borNonTaxableIncomeTotalNonTaxableIncome; } set { _borNonTaxableIncomeTotalNonTaxableIncome = value; } }
        private Value<decimal?> _borOtherNotesReceivableIncome;
        public decimal? BorOtherNotesReceivableIncome { get { return _borOtherNotesReceivableIncome; } set { _borOtherNotesReceivableIncome = value; } }
        private Value<decimal?> _borOtherOtherIncome;
        public decimal? BorOtherOtherIncome { get { return _borOtherOtherIncome; } set { _borOtherOtherIncome = value; } }
        private Value<decimal?> _borOtherParttimeIncome;
        public decimal? BorOtherParttimeIncome { get { return _borOtherParttimeIncome; } set { _borOtherParttimeIncome = value; } }
        private Value<decimal?> _borOtherRetirementIncome;
        public decimal? BorOtherRetirementIncome { get { return _borOtherRetirementIncome; } set { _borOtherRetirementIncome = value; } }
        private Value<decimal?> _borOtherSeasonalIncome;
        public decimal? BorOtherSeasonalIncome { get { return _borOtherSeasonalIncome; } set { _borOtherSeasonalIncome = value; } }
        private Value<decimal?> _borOtherSocialSecurityIncome;
        public decimal? BorOtherSocialSecurityIncome { get { return _borOtherSocialSecurityIncome; } set { _borOtherSocialSecurityIncome = value; } }
        private Value<decimal?> _borOtherTipIncome;
        public decimal? BorOtherTipIncome { get { return _borOtherTipIncome; } set { _borOtherTipIncome = value; } }
        private Value<decimal?> _borOtherTrustIncome;
        public decimal? BorOtherTrustIncome { get { return _borOtherTrustIncome; } set { _borOtherTrustIncome = value; } }
        private Value<decimal?> _borOtherUnemploymentIncome;
        public decimal? BorOtherUnemploymentIncome { get { return _borOtherUnemploymentIncome; } set { _borOtherUnemploymentIncome = value; } }
        private Value<decimal?> _borOvertimeAverageOvertime;
        public decimal? BorOvertimeAverageOvertime { get { return _borOvertimeAverageOvertime; } set { _borOvertimeAverageOvertime = value; } }
        private Value<decimal?> _borOvertimeMostRecentAmount;
        public decimal? BorOvertimeMostRecentAmount { get { return _borOvertimeMostRecentAmount; } set { _borOvertimeMostRecentAmount = value; } }
        private Value<int?> _borOvertimeMostRecentMonths;
        public int? BorOvertimeMostRecentMonths { get { return _borOvertimeMostRecentMonths; } set { _borOvertimeMostRecentMonths = value; } }
        private Value<int?> _borOvertimeMostRecentYear;
        public int? BorOvertimeMostRecentYear { get { return _borOvertimeMostRecentYear; } set { _borOvertimeMostRecentYear = value; } }
        private Value<decimal?> _borOvertimePreviousAmount1;
        public decimal? BorOvertimePreviousAmount1 { get { return _borOvertimePreviousAmount1; } set { _borOvertimePreviousAmount1 = value; } }
        private Value<decimal?> _borOvertimePreviousAmount2;
        public decimal? BorOvertimePreviousAmount2 { get { return _borOvertimePreviousAmount2; } set { _borOvertimePreviousAmount2 = value; } }
        private Value<int?> _borOvertimePreviousMonths1;
        public int? BorOvertimePreviousMonths1 { get { return _borOvertimePreviousMonths1; } set { _borOvertimePreviousMonths1 = value; } }
        private Value<int?> _borOvertimePreviousMonths2;
        public int? BorOvertimePreviousMonths2 { get { return _borOvertimePreviousMonths2; } set { _borOvertimePreviousMonths2 = value; } }
        private Value<int?> _borOvertimePreviousYear1;
        public int? BorOvertimePreviousYear1 { get { return _borOvertimePreviousYear1; } set { _borOvertimePreviousYear1 = value; } }
        private Value<int?> _borOvertimePreviousYear2;
        public int? BorOvertimePreviousYear2 { get { return _borOvertimePreviousYear2; } set { _borOvertimePreviousYear2 = value; } }
        private Value<decimal?> _borProjectedIncomeProjectedBonuses;
        public decimal? BorProjectedIncomeProjectedBonuses { get { return _borProjectedIncomeProjectedBonuses; } set { _borProjectedIncomeProjectedBonuses = value; } }
        private Value<decimal?> _borProjectedIncomeProjectedCostLivingAdjustment;
        public decimal? BorProjectedIncomeProjectedCostLivingAdjustment { get { return _borProjectedIncomeProjectedCostLivingAdjustment; } set { _borProjectedIncomeProjectedCostLivingAdjustment = value; } }
        private Value<decimal?> _borProjectedIncomeProjectedNewJobIncome;
        public decimal? BorProjectedIncomeProjectedNewJobIncome { get { return _borProjectedIncomeProjectedNewJobIncome; } set { _borProjectedIncomeProjectedNewJobIncome = value; } }
        private Value<decimal?> _borProjectedIncomeProjectedPerformanceRaises;
        public decimal? BorProjectedIncomeProjectedPerformanceRaises { get { return _borProjectedIncomeProjectedPerformanceRaises; } set { _borProjectedIncomeProjectedPerformanceRaises = value; } }
        private Value<decimal?> _borProjectedIncomeTotalProjectedIncome;
        public decimal? BorProjectedIncomeTotalProjectedIncome { get { return _borProjectedIncomeTotalProjectedIncome; } set { _borProjectedIncomeTotalProjectedIncome = value; } }
        private Value<decimal?> _cobBonusAverageOvertime;
        public decimal? CobBonusAverageOvertime { get { return _cobBonusAverageOvertime; } set { _cobBonusAverageOvertime = value; } }
        private Value<decimal?> _cobBonusMostRecentAmount;
        public decimal? CobBonusMostRecentAmount { get { return _cobBonusMostRecentAmount; } set { _cobBonusMostRecentAmount = value; } }
        private Value<int?> _cobBonusMostRecentMonths;
        public int? CobBonusMostRecentMonths { get { return _cobBonusMostRecentMonths; } set { _cobBonusMostRecentMonths = value; } }
        private Value<int?> _cobBonusMostRecentYear;
        public int? CobBonusMostRecentYear { get { return _cobBonusMostRecentYear; } set { _cobBonusMostRecentYear = value; } }
        private Value<decimal?> _cobBonusPreviousAmount1;
        public decimal? CobBonusPreviousAmount1 { get { return _cobBonusPreviousAmount1; } set { _cobBonusPreviousAmount1 = value; } }
        private Value<decimal?> _cobBonusPreviousAmount2;
        public decimal? CobBonusPreviousAmount2 { get { return _cobBonusPreviousAmount2; } set { _cobBonusPreviousAmount2 = value; } }
        private Value<int?> _cobBonusPreviousMonths1;
        public int? CobBonusPreviousMonths1 { get { return _cobBonusPreviousMonths1; } set { _cobBonusPreviousMonths1 = value; } }
        private Value<int?> _cobBonusPreviousMonths2;
        public int? CobBonusPreviousMonths2 { get { return _cobBonusPreviousMonths2; } set { _cobBonusPreviousMonths2 = value; } }
        private Value<int?> _cobBonusPreviousYear1;
        public int? CobBonusPreviousYear1 { get { return _cobBonusPreviousYear1; } set { _cobBonusPreviousYear1 = value; } }
        private Value<int?> _cobBonusPreviousYear2;
        public int? CobBonusPreviousYear2 { get { return _cobBonusPreviousYear2; } set { _cobBonusPreviousYear2 = value; } }
        private Value<decimal?> _cobCommissionAverageOvertime;
        public decimal? CobCommissionAverageOvertime { get { return _cobCommissionAverageOvertime; } set { _cobCommissionAverageOvertime = value; } }
        private Value<decimal?> _cobCommissionMostRecentAmount;
        public decimal? CobCommissionMostRecentAmount { get { return _cobCommissionMostRecentAmount; } set { _cobCommissionMostRecentAmount = value; } }
        private Value<int?> _cobCommissionMostRecentMonths;
        public int? CobCommissionMostRecentMonths { get { return _cobCommissionMostRecentMonths; } set { _cobCommissionMostRecentMonths = value; } }
        private Value<int?> _cobCommissionMostRecentYear;
        public int? CobCommissionMostRecentYear { get { return _cobCommissionMostRecentYear; } set { _cobCommissionMostRecentYear = value; } }
        private Value<decimal?> _cobCommissionPreviousAmount1;
        public decimal? CobCommissionPreviousAmount1 { get { return _cobCommissionPreviousAmount1; } set { _cobCommissionPreviousAmount1 = value; } }
        private Value<decimal?> _cobCommissionPreviousAmount2;
        public decimal? CobCommissionPreviousAmount2 { get { return _cobCommissionPreviousAmount2; } set { _cobCommissionPreviousAmount2 = value; } }
        private Value<int?> _cobCommissionPreviousMonths1;
        public int? CobCommissionPreviousMonths1 { get { return _cobCommissionPreviousMonths1; } set { _cobCommissionPreviousMonths1 = value; } }
        private Value<int?> _cobCommissionPreviousMonths2;
        public int? CobCommissionPreviousMonths2 { get { return _cobCommissionPreviousMonths2; } set { _cobCommissionPreviousMonths2 = value; } }
        private Value<int?> _cobCommissionPreviousYear1;
        public int? CobCommissionPreviousYear1 { get { return _cobCommissionPreviousYear1; } set { _cobCommissionPreviousYear1 = value; } }
        private Value<int?> _cobCommissionPreviousYear2;
        public int? CobCommissionPreviousYear2 { get { return _cobCommissionPreviousYear2; } set { _cobCommissionPreviousYear2 = value; } }
        private Value<decimal?> _cobDividendAverageDividend;
        public decimal? CobDividendAverageDividend { get { return _cobDividendAverageDividend; } set { _cobDividendAverageDividend = value; } }
        private Value<decimal?> _cobDividendPreviousAmount1;
        public decimal? CobDividendPreviousAmount1 { get { return _cobDividendPreviousAmount1; } set { _cobDividendPreviousAmount1 = value; } }
        private Value<decimal?> _cobDividendPreviousAmount2;
        public decimal? CobDividendPreviousAmount2 { get { return _cobDividendPreviousAmount2; } set { _cobDividendPreviousAmount2 = value; } }
        private Value<int?> _cobDividendPreviousMonths1;
        public int? CobDividendPreviousMonths1 { get { return _cobDividendPreviousMonths1; } set { _cobDividendPreviousMonths1 = value; } }
        private Value<int?> _cobDividendPreviousMonths2;
        public int? CobDividendPreviousMonths2 { get { return _cobDividendPreviousMonths2; } set { _cobDividendPreviousMonths2 = value; } }
        private Value<int?> _cobDividendPreviousYear1;
        public int? CobDividendPreviousYear1 { get { return _cobDividendPreviousYear1; } set { _cobDividendPreviousYear1 = value; } }
        private Value<int?> _cobDividendPreviousYear2;
        public int? CobDividendPreviousYear2 { get { return _cobDividendPreviousYear2; } set { _cobDividendPreviousYear2 = value; } }
        private Value<decimal?> _cobDividendRequiredForCashAmount;
        public decimal? CobDividendRequiredForCashAmount { get { return _cobDividendRequiredForCashAmount; } set { _cobDividendRequiredForCashAmount = value; } }
        private Value<decimal?> _cobInterestAverageDividend;
        public decimal? CobInterestAverageDividend { get { return _cobInterestAverageDividend; } set { _cobInterestAverageDividend = value; } }
        private Value<decimal?> _cobInterestPreviousAmount1;
        public decimal? CobInterestPreviousAmount1 { get { return _cobInterestPreviousAmount1; } set { _cobInterestPreviousAmount1 = value; } }
        private Value<decimal?> _cobInterestPreviousAmount2;
        public decimal? CobInterestPreviousAmount2 { get { return _cobInterestPreviousAmount2; } set { _cobInterestPreviousAmount2 = value; } }
        private Value<int?> _cobInterestPreviousMonths1;
        public int? CobInterestPreviousMonths1 { get { return _cobInterestPreviousMonths1; } set { _cobInterestPreviousMonths1 = value; } }
        private Value<int?> _cobInterestPreviousMonths2;
        public int? CobInterestPreviousMonths2 { get { return _cobInterestPreviousMonths2; } set { _cobInterestPreviousMonths2 = value; } }
        private Value<int?> _cobInterestPreviousYear1;
        public int? CobInterestPreviousYear1 { get { return _cobInterestPreviousYear1; } set { _cobInterestPreviousYear1 = value; } }
        private Value<int?> _cobInterestPreviousYear2;
        public int? CobInterestPreviousYear2 { get { return _cobInterestPreviousYear2; } set { _cobInterestPreviousYear2 = value; } }
        private Value<decimal?> _cobInterestRequiredForCashAmount;
        public decimal? CobInterestRequiredForCashAmount { get { return _cobInterestRequiredForCashAmount; } set { _cobInterestRequiredForCashAmount = value; } }
        private Value<decimal?> _cobMilitaryAllowanceClothingAllowance;
        public decimal? CobMilitaryAllowanceClothingAllowance { get { return _cobMilitaryAllowanceClothingAllowance; } set { _cobMilitaryAllowanceClothingAllowance = value; } }
        private Value<decimal?> _cobMilitaryAllowanceOtherAllowance;
        public decimal? CobMilitaryAllowanceOtherAllowance { get { return _cobMilitaryAllowanceOtherAllowance; } set { _cobMilitaryAllowanceOtherAllowance = value; } }
        private Value<decimal?> _cobMilitaryAllowanceQuartersAllowance;
        public decimal? CobMilitaryAllowanceQuartersAllowance { get { return _cobMilitaryAllowanceQuartersAllowance; } set { _cobMilitaryAllowanceQuartersAllowance = value; } }
        private Value<decimal?> _cobMilitaryAllowanceRationsAllowance;
        public decimal? CobMilitaryAllowanceRationsAllowance { get { return _cobMilitaryAllowanceRationsAllowance; } set { _cobMilitaryAllowanceRationsAllowance = value; } }
        private Value<decimal?> _cobMilitaryAllowanceTotalAllowance;
        public decimal? CobMilitaryAllowanceTotalAllowance { get { return _cobMilitaryAllowanceTotalAllowance; } set { _cobMilitaryAllowanceTotalAllowance = value; } }
        private Value<decimal?> _cobMilitaryAllowanceVariableHousingAllowance;
        public decimal? CobMilitaryAllowanceVariableHousingAllowance { get { return _cobMilitaryAllowanceVariableHousingAllowance; } set { _cobMilitaryAllowanceVariableHousingAllowance = value; } }
        private Value<decimal?> _cobMilitaryBasePay;
        public decimal? CobMilitaryBasePay { get { return _cobMilitaryBasePay; } set { _cobMilitaryBasePay = value; } }
        private Value<decimal?> _cobMilitaryCombatPay;
        public decimal? CobMilitaryCombatPay { get { return _cobMilitaryCombatPay; } set { _cobMilitaryCombatPay = value; } }
        private Value<decimal?> _cobMilitaryFlightPay;
        public decimal? CobMilitaryFlightPay { get { return _cobMilitaryFlightPay; } set { _cobMilitaryFlightPay = value; } }
        private Value<decimal?> _cobMilitaryHazardPay;
        public decimal? CobMilitaryHazardPay { get { return _cobMilitaryHazardPay; } set { _cobMilitaryHazardPay = value; } }
        private Value<decimal?> _cobMilitaryOverseasPay;
        public decimal? CobMilitaryOverseasPay { get { return _cobMilitaryOverseasPay; } set { _cobMilitaryOverseasPay = value; } }
        private Value<decimal?> _cobMilitaryPropPay;
        public decimal? CobMilitaryPropPay { get { return _cobMilitaryPropPay; } set { _cobMilitaryPropPay = value; } }
        private Value<decimal?> _cobMilitaryTotalPay;
        public decimal? CobMilitaryTotalPay { get { return _cobMilitaryTotalPay; } set { _cobMilitaryTotalPay = value; } }
        private Value<decimal?> _cobMonthlyEmplymentIncomeBaseIncome;
        public decimal? CobMonthlyEmplymentIncomeBaseIncome { get { return _cobMonthlyEmplymentIncomeBaseIncome; } set { _cobMonthlyEmplymentIncomeBaseIncome = value; } }
        private Value<decimal?> _cobMonthlyEmplymentIncomeBonuseIncome;
        public decimal? CobMonthlyEmplymentIncomeBonuseIncome { get { return _cobMonthlyEmplymentIncomeBonuseIncome; } set { _cobMonthlyEmplymentIncomeBonuseIncome = value; } }
        private Value<decimal?> _cobMonthlyEmplymentIncomeCommissionIncome;
        public decimal? CobMonthlyEmplymentIncomeCommissionIncome { get { return _cobMonthlyEmplymentIncomeCommissionIncome; } set { _cobMonthlyEmplymentIncomeCommissionIncome = value; } }
        private Value<decimal?> _cobMonthlyEmplymentIncomeDividendInterestIncome;
        public decimal? CobMonthlyEmplymentIncomeDividendInterestIncome { get { return _cobMonthlyEmplymentIncomeDividendInterestIncome; } set { _cobMonthlyEmplymentIncomeDividendInterestIncome = value; } }
        private Value<decimal?> _cobMonthlyEmplymentIncomeOtherIncome1;
        public decimal? CobMonthlyEmplymentIncomeOtherIncome1 { get { return _cobMonthlyEmplymentIncomeOtherIncome1; } set { _cobMonthlyEmplymentIncomeOtherIncome1 = value; } }
        private Value<decimal?> _cobMonthlyEmplymentIncomeOtherIncome2;
        public decimal? CobMonthlyEmplymentIncomeOtherIncome2 { get { return _cobMonthlyEmplymentIncomeOtherIncome2; } set { _cobMonthlyEmplymentIncomeOtherIncome2 = value; } }
        private Value<decimal?> _cobMonthlyEmplymentIncomeOvertimeIncome;
        public decimal? CobMonthlyEmplymentIncomeOvertimeIncome { get { return _cobMonthlyEmplymentIncomeOvertimeIncome; } set { _cobMonthlyEmplymentIncomeOvertimeIncome = value; } }
        private Value<decimal?> _cobMonthlyEmplymentIncomeTotalEmploymentIncome;
        public decimal? CobMonthlyEmplymentIncomeTotalEmploymentIncome { get { return _cobMonthlyEmplymentIncomeTotalEmploymentIncome; } set { _cobMonthlyEmplymentIncomeTotalEmploymentIncome = value; } }
        private Value<decimal?> _cobNonEmploymentIncomeGovtAssitProgramIncome;
        public decimal? CobNonEmploymentIncomeGovtAssitProgramIncome { get { return _cobNonEmploymentIncomeGovtAssitProgramIncome; } set { _cobNonEmploymentIncomeGovtAssitProgramIncome = value; } }
        private Value<decimal?> _cobNonEmploymentIncomeHomeownSubsidyIncome;
        public decimal? CobNonEmploymentIncomeHomeownSubsidyIncome { get { return _cobNonEmploymentIncomeHomeownSubsidyIncome; } set { _cobNonEmploymentIncomeHomeownSubsidyIncome = value; } }
        private Value<decimal?> _cobNonEmploymentIncomeMilitaryIncome;
        public decimal? CobNonEmploymentIncomeMilitaryIncome { get { return _cobNonEmploymentIncomeMilitaryIncome; } set { _cobNonEmploymentIncomeMilitaryIncome = value; } }
        private Value<decimal?> _cobNonEmploymentIncomeMtgCreditCertificateIncome;
        public decimal? CobNonEmploymentIncomeMtgCreditCertificateIncome { get { return _cobNonEmploymentIncomeMtgCreditCertificateIncome; } set { _cobNonEmploymentIncomeMtgCreditCertificateIncome = value; } }
        private Value<decimal?> _cobNonEmploymentIncomeTotalNonEmploymentIncome;
        public decimal? CobNonEmploymentIncomeTotalNonEmploymentIncome { get { return _cobNonEmploymentIncomeTotalNonEmploymentIncome; } set { _cobNonEmploymentIncomeTotalNonEmploymentIncome = value; } }
        private Value<decimal?> _cobNonEmploymentIncomeVABenefitIncome;
        public decimal? CobNonEmploymentIncomeVABenefitIncome { get { return _cobNonEmploymentIncomeVABenefitIncome; } set { _cobNonEmploymentIncomeVABenefitIncome = value; } }
        private Value<decimal?> _cobNonTaxableIncomeChildSupportIncome;
        public decimal? CobNonTaxableIncomeChildSupportIncome { get { return _cobNonTaxableIncomeChildSupportIncome; } set { _cobNonTaxableIncomeChildSupportIncome = value; } }
        private Value<decimal?> _cobNonTaxableIncomeDisabilityIncome;
        public decimal? CobNonTaxableIncomeDisabilityIncome { get { return _cobNonTaxableIncomeDisabilityIncome; } set { _cobNonTaxableIncomeDisabilityIncome = value; } }
        private Value<decimal?> _cobNonTaxableIncomeFedGovtEmplRetirementIncome;
        public decimal? CobNonTaxableIncomeFedGovtEmplRetirementIncome { get { return _cobNonTaxableIncomeFedGovtEmplRetirementIncome; } set { _cobNonTaxableIncomeFedGovtEmplRetirementIncome = value; } }
        private Value<decimal?> _cobNonTaxableIncomeMilitaryAllowances;
        public decimal? CobNonTaxableIncomeMilitaryAllowances { get { return _cobNonTaxableIncomeMilitaryAllowances; } set { _cobNonTaxableIncomeMilitaryAllowances = value; } }
        private Value<decimal?> _cobNonTaxableIncomeOtherIncome;
        public decimal? CobNonTaxableIncomeOtherIncome { get { return _cobNonTaxableIncomeOtherIncome; } set { _cobNonTaxableIncomeOtherIncome = value; } }
        private Value<decimal?> _cobNonTaxableIncomePublicAssistPayments;
        public decimal? CobNonTaxableIncomePublicAssistPayments { get { return _cobNonTaxableIncomePublicAssistPayments; } set { _cobNonTaxableIncomePublicAssistPayments = value; } }
        private Value<decimal?> _cobNonTaxableIncomeRailroadRetirementBenefits;
        public decimal? CobNonTaxableIncomeRailroadRetirementBenefits { get { return _cobNonTaxableIncomeRailroadRetirementBenefits; } set { _cobNonTaxableIncomeRailroadRetirementBenefits = value; } }
        private Value<decimal?> _cobNonTaxableIncomeSocialSecurityIncome;
        public decimal? CobNonTaxableIncomeSocialSecurityIncome { get { return _cobNonTaxableIncomeSocialSecurityIncome; } set { _cobNonTaxableIncomeSocialSecurityIncome = value; } }
        private Value<decimal?> _cobNonTaxableIncomeStateGovtEmplRetirementIncome;
        public decimal? CobNonTaxableIncomeStateGovtEmplRetirementIncome { get { return _cobNonTaxableIncomeStateGovtEmplRetirementIncome; } set { _cobNonTaxableIncomeStateGovtEmplRetirementIncome = value; } }
        private Value<decimal?> _cobNonTaxableIncomeTotalNonTaxableIncome;
        public decimal? CobNonTaxableIncomeTotalNonTaxableIncome { get { return _cobNonTaxableIncomeTotalNonTaxableIncome; } set { _cobNonTaxableIncomeTotalNonTaxableIncome = value; } }
        private Value<decimal?> _cobOtherNotesReceivableIncome;
        public decimal? CobOtherNotesReceivableIncome { get { return _cobOtherNotesReceivableIncome; } set { _cobOtherNotesReceivableIncome = value; } }
        private Value<decimal?> _cobOtherOtherIncome;
        public decimal? CobOtherOtherIncome { get { return _cobOtherOtherIncome; } set { _cobOtherOtherIncome = value; } }
        private Value<decimal?> _cobOtherParttimeIncome;
        public decimal? CobOtherParttimeIncome { get { return _cobOtherParttimeIncome; } set { _cobOtherParttimeIncome = value; } }
        private Value<decimal?> _cobOtherRetirementIncome;
        public decimal? CobOtherRetirementIncome { get { return _cobOtherRetirementIncome; } set { _cobOtherRetirementIncome = value; } }
        private Value<decimal?> _cobOtherSeasonalIncome;
        public decimal? CobOtherSeasonalIncome { get { return _cobOtherSeasonalIncome; } set { _cobOtherSeasonalIncome = value; } }
        private Value<decimal?> _cobOtherSocialSecurityIncome;
        public decimal? CobOtherSocialSecurityIncome { get { return _cobOtherSocialSecurityIncome; } set { _cobOtherSocialSecurityIncome = value; } }
        private Value<decimal?> _cobOtherTipIncome;
        public decimal? CobOtherTipIncome { get { return _cobOtherTipIncome; } set { _cobOtherTipIncome = value; } }
        private Value<decimal?> _cobOtherTrustIncome;
        public decimal? CobOtherTrustIncome { get { return _cobOtherTrustIncome; } set { _cobOtherTrustIncome = value; } }
        private Value<decimal?> _cobOtherUnemploymentIncome;
        public decimal? CobOtherUnemploymentIncome { get { return _cobOtherUnemploymentIncome; } set { _cobOtherUnemploymentIncome = value; } }
        private Value<decimal?> _cobOvertimeAverageOvertime;
        public decimal? CobOvertimeAverageOvertime { get { return _cobOvertimeAverageOvertime; } set { _cobOvertimeAverageOvertime = value; } }
        private Value<decimal?> _cobOvertimeMostRecentAmount;
        public decimal? CobOvertimeMostRecentAmount { get { return _cobOvertimeMostRecentAmount; } set { _cobOvertimeMostRecentAmount = value; } }
        private Value<int?> _cobOvertimeMostRecentMonths;
        public int? CobOvertimeMostRecentMonths { get { return _cobOvertimeMostRecentMonths; } set { _cobOvertimeMostRecentMonths = value; } }
        private Value<int?> _cobOvertimeMostRecentYear;
        public int? CobOvertimeMostRecentYear { get { return _cobOvertimeMostRecentYear; } set { _cobOvertimeMostRecentYear = value; } }
        private Value<decimal?> _cobOvertimePreviousAmount1;
        public decimal? CobOvertimePreviousAmount1 { get { return _cobOvertimePreviousAmount1; } set { _cobOvertimePreviousAmount1 = value; } }
        private Value<decimal?> _cobOvertimePreviousAmount2;
        public decimal? CobOvertimePreviousAmount2 { get { return _cobOvertimePreviousAmount2; } set { _cobOvertimePreviousAmount2 = value; } }
        private Value<int?> _cobOvertimePreviousMonths1;
        public int? CobOvertimePreviousMonths1 { get { return _cobOvertimePreviousMonths1; } set { _cobOvertimePreviousMonths1 = value; } }
        private Value<int?> _cobOvertimePreviousMonths2;
        public int? CobOvertimePreviousMonths2 { get { return _cobOvertimePreviousMonths2; } set { _cobOvertimePreviousMonths2 = value; } }
        private Value<int?> _cobOvertimePreviousYear1;
        public int? CobOvertimePreviousYear1 { get { return _cobOvertimePreviousYear1; } set { _cobOvertimePreviousYear1 = value; } }
        private Value<int?> _cobOvertimePreviousYear2;
        public int? CobOvertimePreviousYear2 { get { return _cobOvertimePreviousYear2; } set { _cobOvertimePreviousYear2 = value; } }
        private Value<decimal?> _cobProjectedIncomeProjectedBonuses;
        public decimal? CobProjectedIncomeProjectedBonuses { get { return _cobProjectedIncomeProjectedBonuses; } set { _cobProjectedIncomeProjectedBonuses = value; } }
        private Value<decimal?> _cobProjectedIncomeProjectedCostLivingAdjustment;
        public decimal? CobProjectedIncomeProjectedCostLivingAdjustment { get { return _cobProjectedIncomeProjectedCostLivingAdjustment; } set { _cobProjectedIncomeProjectedCostLivingAdjustment = value; } }
        private Value<decimal?> _cobProjectedIncomeProjectedNewJobIncome;
        public decimal? CobProjectedIncomeProjectedNewJobIncome { get { return _cobProjectedIncomeProjectedNewJobIncome; } set { _cobProjectedIncomeProjectedNewJobIncome = value; } }
        private Value<decimal?> _cobProjectedIncomeProjectedPerformanceRaises;
        public decimal? CobProjectedIncomeProjectedPerformanceRaises { get { return _cobProjectedIncomeProjectedPerformanceRaises; } set { _cobProjectedIncomeProjectedPerformanceRaises = value; } }
        private Value<decimal?> _cobProjectedIncomeTotalProjectedIncome;
        public decimal? CobProjectedIncomeTotalProjectedIncome { get { return _cobProjectedIncomeTotalProjectedIncome; } set { _cobProjectedIncomeTotalProjectedIncome = value; } }
        private Value<string> _dUCaseIDorLPAUSKey;
        public string DUCaseIDorLPAUSKey { get { return _dUCaseIDorLPAUSKey; } set { _dUCaseIDorLPAUSKey = value; } }
        private Value<DateTime?> _firstSubmissionDate;
        public DateTime? FirstSubmissionDate { get { return _firstSubmissionDate; } set { _firstSubmissionDate = value; } }
        private Value<string> _firstSubmissionTime;
        public string FirstSubmissionTime { get { return _firstSubmissionTime; } set { _firstSubmissionTime = value; } }
        private Value<string> _freddieDocClass;
        public string FreddieDocClass { get { return _freddieDocClass; } set { _freddieDocClass = value; } }
        private Value<decimal?> _housingRatio;
        public decimal? HousingRatio { get { return _housingRatio; } set { _housingRatio = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isEmpty;
        public bool? IsEmpty { get { return _isEmpty; } set { _isEmpty = value; } }
        private Value<DateTime?> _submissionDate;
        public DateTime? SubmissionDate { get { return _submissionDate; } set { _submissionDate = value; } }
        private Value<string> _submissionNumber;
        public string SubmissionNumber { get { return _submissionNumber; } set { _submissionNumber = value; } }
        private Value<string> _submissionTime;
        public string SubmissionTime { get { return _submissionTime; } set { _submissionTime = value; } }
        private Value<string> _submittedBy;
        public string SubmittedBy { get { return _submittedBy; } set { _submittedBy = value; } }
        private Value<decimal?> _totalExpenseRatio;
        public decimal? TotalExpenseRatio { get { return _totalExpenseRatio; } set { _totalExpenseRatio = value; } }
        private Value<decimal?> _totalHousingPayment;
        public decimal? TotalHousingPayment { get { return _totalHousingPayment; } set { _totalHousingPayment = value; } }
        private Value<decimal?> _totalMonthlyAssets;
        public decimal? TotalMonthlyAssets { get { return _totalMonthlyAssets; } set { _totalMonthlyAssets = value; } }
        private Value<decimal?> _totalMonthlyDebt;
        public decimal? TotalMonthlyDebt { get { return _totalMonthlyDebt; } set { _totalMonthlyDebt = value; } }
        private Value<decimal?> _totalMonthlyIncome;
        public decimal? TotalMonthlyIncome { get { return _totalMonthlyIncome; } set { _totalMonthlyIncome = value; } }
        private Value<string> _underwritingRiskAssessOther;
        public string UnderwritingRiskAssessOther { get { return _underwritingRiskAssessOther; } set { _underwritingRiskAssessOther = value; } }
        private Value<string> _underwritingRiskAssessType;
        public string UnderwritingRiskAssessType { get { return _underwritingRiskAssessType; } set { _underwritingRiskAssessType = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _aTRQMBorrowerIndex.Clean
                    && _aUSRecommendation.Clean
                    && _aUSVersion.Clean
                    && _borBonusAverageOvertime.Clean
                    && _borBonusMostRecentAmount.Clean
                    && _borBonusMostRecentMonths.Clean
                    && _borBonusMostRecentYear.Clean
                    && _borBonusPreviousAmount1.Clean
                    && _borBonusPreviousAmount2.Clean
                    && _borBonusPreviousMonths1.Clean
                    && _borBonusPreviousMonths2.Clean
                    && _borBonusPreviousYear1.Clean
                    && _borBonusPreviousYear2.Clean
                    && _borCommissionAverageOvertime.Clean
                    && _borCommissionMostRecentAmount.Clean
                    && _borCommissionMostRecentMonths.Clean
                    && _borCommissionMostRecentYear.Clean
                    && _borCommissionPreviousAmount1.Clean
                    && _borCommissionPreviousAmount2.Clean
                    && _borCommissionPreviousMonths1.Clean
                    && _borCommissionPreviousMonths2.Clean
                    && _borCommissionPreviousYear1.Clean
                    && _borCommissionPreviousYear2.Clean
                    && _borContingentLiabilitiesLiabilityAmount1.Clean
                    && _borContingentLiabilitiesLiabilityAmount2.Clean
                    && _borContingentLiabilitiesLiabilityAmount3.Clean
                    && _borContingentLiabilitiesLiabilityDescription1.Clean
                    && _borContingentLiabilitiesLiabilityDescription2.Clean
                    && _borContingentLiabilitiesLiabilityDescription3.Clean
                    && _borContingentLiabilitiesTotalLiabilityAmount.Clean
                    && _borCosignedObligationsCarLoanPayment.Clean
                    && _borCosignedObligationsMortgagePayment.Clean
                    && _borCosignedObligationsOtherPayment.Clean
                    && _borCosignedObligationsOtherPaymentDescription.Clean
                    && _borCosignedObligationsStudentLoanPayment.Clean
                    && _borCosignedObligationsTotalCoMortgagorLiabilities.Clean
                    && _borDividendAverageDividend.Clean
                    && _borDividendPreviousAmount1.Clean
                    && _borDividendPreviousAmount2.Clean
                    && _borDividendPreviousMonths1.Clean
                    && _borDividendPreviousMonths2.Clean
                    && _borDividendPreviousYear1.Clean
                    && _borDividendPreviousYear2.Clean
                    && _borDividendRequiredForCashAmount.Clean
                    && _borInterestAverageDividend.Clean
                    && _borInterestPreviousAmount1.Clean
                    && _borInterestPreviousAmount2.Clean
                    && _borInterestPreviousMonths1.Clean
                    && _borInterestPreviousMonths2.Clean
                    && _borInterestPreviousYear1.Clean
                    && _borInterestPreviousYear2.Clean
                    && _borInterestRequiredForCashAmount.Clean
                    && _borMilitaryAllowanceClothingAllowance.Clean
                    && _borMilitaryAllowanceOtherAllowance.Clean
                    && _borMilitaryAllowanceOtherAllowanceDescription.Clean
                    && _borMilitaryAllowanceQuartersAllowance.Clean
                    && _borMilitaryAllowanceRationsAllowance.Clean
                    && _borMilitaryAllowanceTotalAllowance.Clean
                    && _borMilitaryAllowanceVariableHousingAllowance.Clean
                    && _borMilitaryBasePay.Clean
                    && _borMilitaryCombatPay.Clean
                    && _borMilitaryFlightPay.Clean
                    && _borMilitaryHazardPay.Clean
                    && _borMilitaryOverseasPay.Clean
                    && _borMilitaryPropPay.Clean
                    && _borMilitaryTotalPay.Clean
                    && _borMonthlyEmplymentIncomeBaseIncome.Clean
                    && _borMonthlyEmplymentIncomeBonuseIncome.Clean
                    && _borMonthlyEmplymentIncomeCommissionIncome.Clean
                    && _borMonthlyEmplymentIncomeDividendInterestIncome.Clean
                    && _borMonthlyEmplymentIncomeOtherIncome1.Clean
                    && _borMonthlyEmplymentIncomeOtherIncome2.Clean
                    && _borMonthlyEmplymentIncomeOvertimeIncome.Clean
                    && _borMonthlyEmplymentIncomeTotalEmploymentIncome.Clean
                    && _borNonEmploymentIncomeGovtAssitProgramIncome.Clean
                    && _borNonEmploymentIncomeHomeownSubsidyIncome.Clean
                    && _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome.Clean
                    && _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome.Clean
                    && _borNonEmploymentIncomeMilitaryIncome.Clean
                    && _borNonEmploymentIncomeMtgCreditCertificateIncome.Clean
                    && _borNonEmploymentIncomeTotalNonEmploymentIncome.Clean
                    && _borNonEmploymentIncomeVABenefitIncome.Clean
                    && _borNonTaxableIncomeChildSupportIncome.Clean
                    && _borNonTaxableIncomeDisabilityIncome.Clean
                    && _borNonTaxableIncomeFedGovtEmplRetirementIncome.Clean
                    && _borNonTaxableIncomeMilitaryAllowances.Clean
                    && _borNonTaxableIncomeOtherIncome.Clean
                    && _borNonTaxableIncomePublicAssistPayments.Clean
                    && _borNonTaxableIncomeRailroadRetirementBenefits.Clean
                    && _borNonTaxableIncomeSocialSecurityIncome.Clean
                    && _borNonTaxableIncomeStateGovtEmplRetirementIncome.Clean
                    && _borNonTaxableIncomeTotalNonTaxableIncome.Clean
                    && _borOtherNotesReceivableIncome.Clean
                    && _borOtherOtherIncome.Clean
                    && _borOtherParttimeIncome.Clean
                    && _borOtherRetirementIncome.Clean
                    && _borOtherSeasonalIncome.Clean
                    && _borOtherSocialSecurityIncome.Clean
                    && _borOtherTipIncome.Clean
                    && _borOtherTrustIncome.Clean
                    && _borOtherUnemploymentIncome.Clean
                    && _borOvertimeAverageOvertime.Clean
                    && _borOvertimeMostRecentAmount.Clean
                    && _borOvertimeMostRecentMonths.Clean
                    && _borOvertimeMostRecentYear.Clean
                    && _borOvertimePreviousAmount1.Clean
                    && _borOvertimePreviousAmount2.Clean
                    && _borOvertimePreviousMonths1.Clean
                    && _borOvertimePreviousMonths2.Clean
                    && _borOvertimePreviousYear1.Clean
                    && _borOvertimePreviousYear2.Clean
                    && _borProjectedIncomeProjectedBonuses.Clean
                    && _borProjectedIncomeProjectedCostLivingAdjustment.Clean
                    && _borProjectedIncomeProjectedNewJobIncome.Clean
                    && _borProjectedIncomeProjectedPerformanceRaises.Clean
                    && _borProjectedIncomeTotalProjectedIncome.Clean
                    && _cobBonusAverageOvertime.Clean
                    && _cobBonusMostRecentAmount.Clean
                    && _cobBonusMostRecentMonths.Clean
                    && _cobBonusMostRecentYear.Clean
                    && _cobBonusPreviousAmount1.Clean
                    && _cobBonusPreviousAmount2.Clean
                    && _cobBonusPreviousMonths1.Clean
                    && _cobBonusPreviousMonths2.Clean
                    && _cobBonusPreviousYear1.Clean
                    && _cobBonusPreviousYear2.Clean
                    && _cobCommissionAverageOvertime.Clean
                    && _cobCommissionMostRecentAmount.Clean
                    && _cobCommissionMostRecentMonths.Clean
                    && _cobCommissionMostRecentYear.Clean
                    && _cobCommissionPreviousAmount1.Clean
                    && _cobCommissionPreviousAmount2.Clean
                    && _cobCommissionPreviousMonths1.Clean
                    && _cobCommissionPreviousMonths2.Clean
                    && _cobCommissionPreviousYear1.Clean
                    && _cobCommissionPreviousYear2.Clean
                    && _cobDividendAverageDividend.Clean
                    && _cobDividendPreviousAmount1.Clean
                    && _cobDividendPreviousAmount2.Clean
                    && _cobDividendPreviousMonths1.Clean
                    && _cobDividendPreviousMonths2.Clean
                    && _cobDividendPreviousYear1.Clean
                    && _cobDividendPreviousYear2.Clean
                    && _cobDividendRequiredForCashAmount.Clean
                    && _cobInterestAverageDividend.Clean
                    && _cobInterestPreviousAmount1.Clean
                    && _cobInterestPreviousAmount2.Clean
                    && _cobInterestPreviousMonths1.Clean
                    && _cobInterestPreviousMonths2.Clean
                    && _cobInterestPreviousYear1.Clean
                    && _cobInterestPreviousYear2.Clean
                    && _cobInterestRequiredForCashAmount.Clean
                    && _cobMilitaryAllowanceClothingAllowance.Clean
                    && _cobMilitaryAllowanceOtherAllowance.Clean
                    && _cobMilitaryAllowanceQuartersAllowance.Clean
                    && _cobMilitaryAllowanceRationsAllowance.Clean
                    && _cobMilitaryAllowanceTotalAllowance.Clean
                    && _cobMilitaryAllowanceVariableHousingAllowance.Clean
                    && _cobMilitaryBasePay.Clean
                    && _cobMilitaryCombatPay.Clean
                    && _cobMilitaryFlightPay.Clean
                    && _cobMilitaryHazardPay.Clean
                    && _cobMilitaryOverseasPay.Clean
                    && _cobMilitaryPropPay.Clean
                    && _cobMilitaryTotalPay.Clean
                    && _cobMonthlyEmplymentIncomeBaseIncome.Clean
                    && _cobMonthlyEmplymentIncomeBonuseIncome.Clean
                    && _cobMonthlyEmplymentIncomeCommissionIncome.Clean
                    && _cobMonthlyEmplymentIncomeDividendInterestIncome.Clean
                    && _cobMonthlyEmplymentIncomeOtherIncome1.Clean
                    && _cobMonthlyEmplymentIncomeOtherIncome2.Clean
                    && _cobMonthlyEmplymentIncomeOvertimeIncome.Clean
                    && _cobMonthlyEmplymentIncomeTotalEmploymentIncome.Clean
                    && _cobNonEmploymentIncomeGovtAssitProgramIncome.Clean
                    && _cobNonEmploymentIncomeHomeownSubsidyIncome.Clean
                    && _cobNonEmploymentIncomeMilitaryIncome.Clean
                    && _cobNonEmploymentIncomeMtgCreditCertificateIncome.Clean
                    && _cobNonEmploymentIncomeTotalNonEmploymentIncome.Clean
                    && _cobNonEmploymentIncomeVABenefitIncome.Clean
                    && _cobNonTaxableIncomeChildSupportIncome.Clean
                    && _cobNonTaxableIncomeDisabilityIncome.Clean
                    && _cobNonTaxableIncomeFedGovtEmplRetirementIncome.Clean
                    && _cobNonTaxableIncomeMilitaryAllowances.Clean
                    && _cobNonTaxableIncomeOtherIncome.Clean
                    && _cobNonTaxableIncomePublicAssistPayments.Clean
                    && _cobNonTaxableIncomeRailroadRetirementBenefits.Clean
                    && _cobNonTaxableIncomeSocialSecurityIncome.Clean
                    && _cobNonTaxableIncomeStateGovtEmplRetirementIncome.Clean
                    && _cobNonTaxableIncomeTotalNonTaxableIncome.Clean
                    && _cobOtherNotesReceivableIncome.Clean
                    && _cobOtherOtherIncome.Clean
                    && _cobOtherParttimeIncome.Clean
                    && _cobOtherRetirementIncome.Clean
                    && _cobOtherSeasonalIncome.Clean
                    && _cobOtherSocialSecurityIncome.Clean
                    && _cobOtherTipIncome.Clean
                    && _cobOtherTrustIncome.Clean
                    && _cobOtherUnemploymentIncome.Clean
                    && _cobOvertimeAverageOvertime.Clean
                    && _cobOvertimeMostRecentAmount.Clean
                    && _cobOvertimeMostRecentMonths.Clean
                    && _cobOvertimeMostRecentYear.Clean
                    && _cobOvertimePreviousAmount1.Clean
                    && _cobOvertimePreviousAmount2.Clean
                    && _cobOvertimePreviousMonths1.Clean
                    && _cobOvertimePreviousMonths2.Clean
                    && _cobOvertimePreviousYear1.Clean
                    && _cobOvertimePreviousYear2.Clean
                    && _cobProjectedIncomeProjectedBonuses.Clean
                    && _cobProjectedIncomeProjectedCostLivingAdjustment.Clean
                    && _cobProjectedIncomeProjectedNewJobIncome.Clean
                    && _cobProjectedIncomeProjectedPerformanceRaises.Clean
                    && _cobProjectedIncomeTotalProjectedIncome.Clean
                    && _dUCaseIDorLPAUSKey.Clean
                    && _firstSubmissionDate.Clean
                    && _firstSubmissionTime.Clean
                    && _freddieDocClass.Clean
                    && _housingRatio.Clean
                    && _id.Clean
                    && _isEmpty.Clean
                    && _submissionDate.Clean
                    && _submissionNumber.Clean
                    && _submissionTime.Clean
                    && _submittedBy.Clean
                    && _totalExpenseRatio.Clean
                    && _totalHousingPayment.Clean
                    && _totalMonthlyAssets.Clean
                    && _totalMonthlyDebt.Clean
                    && _totalMonthlyIncome.Clean
                    && _underwritingRiskAssessOther.Clean
                    && _underwritingRiskAssessType.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var aTRQMBorrowerIndex = _aTRQMBorrowerIndex; aTRQMBorrowerIndex.Clean = value; _aTRQMBorrowerIndex = aTRQMBorrowerIndex;
                var aUSRecommendation = _aUSRecommendation; aUSRecommendation.Clean = value; _aUSRecommendation = aUSRecommendation;
                var aUSVersion = _aUSVersion; aUSVersion.Clean = value; _aUSVersion = aUSVersion;
                var borBonusAverageOvertime = _borBonusAverageOvertime; borBonusAverageOvertime.Clean = value; _borBonusAverageOvertime = borBonusAverageOvertime;
                var borBonusMostRecentAmount = _borBonusMostRecentAmount; borBonusMostRecentAmount.Clean = value; _borBonusMostRecentAmount = borBonusMostRecentAmount;
                var borBonusMostRecentMonths = _borBonusMostRecentMonths; borBonusMostRecentMonths.Clean = value; _borBonusMostRecentMonths = borBonusMostRecentMonths;
                var borBonusMostRecentYear = _borBonusMostRecentYear; borBonusMostRecentYear.Clean = value; _borBonusMostRecentYear = borBonusMostRecentYear;
                var borBonusPreviousAmount1 = _borBonusPreviousAmount1; borBonusPreviousAmount1.Clean = value; _borBonusPreviousAmount1 = borBonusPreviousAmount1;
                var borBonusPreviousAmount2 = _borBonusPreviousAmount2; borBonusPreviousAmount2.Clean = value; _borBonusPreviousAmount2 = borBonusPreviousAmount2;
                var borBonusPreviousMonths1 = _borBonusPreviousMonths1; borBonusPreviousMonths1.Clean = value; _borBonusPreviousMonths1 = borBonusPreviousMonths1;
                var borBonusPreviousMonths2 = _borBonusPreviousMonths2; borBonusPreviousMonths2.Clean = value; _borBonusPreviousMonths2 = borBonusPreviousMonths2;
                var borBonusPreviousYear1 = _borBonusPreviousYear1; borBonusPreviousYear1.Clean = value; _borBonusPreviousYear1 = borBonusPreviousYear1;
                var borBonusPreviousYear2 = _borBonusPreviousYear2; borBonusPreviousYear2.Clean = value; _borBonusPreviousYear2 = borBonusPreviousYear2;
                var borCommissionAverageOvertime = _borCommissionAverageOvertime; borCommissionAverageOvertime.Clean = value; _borCommissionAverageOvertime = borCommissionAverageOvertime;
                var borCommissionMostRecentAmount = _borCommissionMostRecentAmount; borCommissionMostRecentAmount.Clean = value; _borCommissionMostRecentAmount = borCommissionMostRecentAmount;
                var borCommissionMostRecentMonths = _borCommissionMostRecentMonths; borCommissionMostRecentMonths.Clean = value; _borCommissionMostRecentMonths = borCommissionMostRecentMonths;
                var borCommissionMostRecentYear = _borCommissionMostRecentYear; borCommissionMostRecentYear.Clean = value; _borCommissionMostRecentYear = borCommissionMostRecentYear;
                var borCommissionPreviousAmount1 = _borCommissionPreviousAmount1; borCommissionPreviousAmount1.Clean = value; _borCommissionPreviousAmount1 = borCommissionPreviousAmount1;
                var borCommissionPreviousAmount2 = _borCommissionPreviousAmount2; borCommissionPreviousAmount2.Clean = value; _borCommissionPreviousAmount2 = borCommissionPreviousAmount2;
                var borCommissionPreviousMonths1 = _borCommissionPreviousMonths1; borCommissionPreviousMonths1.Clean = value; _borCommissionPreviousMonths1 = borCommissionPreviousMonths1;
                var borCommissionPreviousMonths2 = _borCommissionPreviousMonths2; borCommissionPreviousMonths2.Clean = value; _borCommissionPreviousMonths2 = borCommissionPreviousMonths2;
                var borCommissionPreviousYear1 = _borCommissionPreviousYear1; borCommissionPreviousYear1.Clean = value; _borCommissionPreviousYear1 = borCommissionPreviousYear1;
                var borCommissionPreviousYear2 = _borCommissionPreviousYear2; borCommissionPreviousYear2.Clean = value; _borCommissionPreviousYear2 = borCommissionPreviousYear2;
                var borContingentLiabilitiesLiabilityAmount1 = _borContingentLiabilitiesLiabilityAmount1; borContingentLiabilitiesLiabilityAmount1.Clean = value; _borContingentLiabilitiesLiabilityAmount1 = borContingentLiabilitiesLiabilityAmount1;
                var borContingentLiabilitiesLiabilityAmount2 = _borContingentLiabilitiesLiabilityAmount2; borContingentLiabilitiesLiabilityAmount2.Clean = value; _borContingentLiabilitiesLiabilityAmount2 = borContingentLiabilitiesLiabilityAmount2;
                var borContingentLiabilitiesLiabilityAmount3 = _borContingentLiabilitiesLiabilityAmount3; borContingentLiabilitiesLiabilityAmount3.Clean = value; _borContingentLiabilitiesLiabilityAmount3 = borContingentLiabilitiesLiabilityAmount3;
                var borContingentLiabilitiesLiabilityDescription1 = _borContingentLiabilitiesLiabilityDescription1; borContingentLiabilitiesLiabilityDescription1.Clean = value; _borContingentLiabilitiesLiabilityDescription1 = borContingentLiabilitiesLiabilityDescription1;
                var borContingentLiabilitiesLiabilityDescription2 = _borContingentLiabilitiesLiabilityDescription2; borContingentLiabilitiesLiabilityDescription2.Clean = value; _borContingentLiabilitiesLiabilityDescription2 = borContingentLiabilitiesLiabilityDescription2;
                var borContingentLiabilitiesLiabilityDescription3 = _borContingentLiabilitiesLiabilityDescription3; borContingentLiabilitiesLiabilityDescription3.Clean = value; _borContingentLiabilitiesLiabilityDescription3 = borContingentLiabilitiesLiabilityDescription3;
                var borContingentLiabilitiesTotalLiabilityAmount = _borContingentLiabilitiesTotalLiabilityAmount; borContingentLiabilitiesTotalLiabilityAmount.Clean = value; _borContingentLiabilitiesTotalLiabilityAmount = borContingentLiabilitiesTotalLiabilityAmount;
                var borCosignedObligationsCarLoanPayment = _borCosignedObligationsCarLoanPayment; borCosignedObligationsCarLoanPayment.Clean = value; _borCosignedObligationsCarLoanPayment = borCosignedObligationsCarLoanPayment;
                var borCosignedObligationsMortgagePayment = _borCosignedObligationsMortgagePayment; borCosignedObligationsMortgagePayment.Clean = value; _borCosignedObligationsMortgagePayment = borCosignedObligationsMortgagePayment;
                var borCosignedObligationsOtherPayment = _borCosignedObligationsOtherPayment; borCosignedObligationsOtherPayment.Clean = value; _borCosignedObligationsOtherPayment = borCosignedObligationsOtherPayment;
                var borCosignedObligationsOtherPaymentDescription = _borCosignedObligationsOtherPaymentDescription; borCosignedObligationsOtherPaymentDescription.Clean = value; _borCosignedObligationsOtherPaymentDescription = borCosignedObligationsOtherPaymentDescription;
                var borCosignedObligationsStudentLoanPayment = _borCosignedObligationsStudentLoanPayment; borCosignedObligationsStudentLoanPayment.Clean = value; _borCosignedObligationsStudentLoanPayment = borCosignedObligationsStudentLoanPayment;
                var borCosignedObligationsTotalCoMortgagorLiabilities = _borCosignedObligationsTotalCoMortgagorLiabilities; borCosignedObligationsTotalCoMortgagorLiabilities.Clean = value; _borCosignedObligationsTotalCoMortgagorLiabilities = borCosignedObligationsTotalCoMortgagorLiabilities;
                var borDividendAverageDividend = _borDividendAverageDividend; borDividendAverageDividend.Clean = value; _borDividendAverageDividend = borDividendAverageDividend;
                var borDividendPreviousAmount1 = _borDividendPreviousAmount1; borDividendPreviousAmount1.Clean = value; _borDividendPreviousAmount1 = borDividendPreviousAmount1;
                var borDividendPreviousAmount2 = _borDividendPreviousAmount2; borDividendPreviousAmount2.Clean = value; _borDividendPreviousAmount2 = borDividendPreviousAmount2;
                var borDividendPreviousMonths1 = _borDividendPreviousMonths1; borDividendPreviousMonths1.Clean = value; _borDividendPreviousMonths1 = borDividendPreviousMonths1;
                var borDividendPreviousMonths2 = _borDividendPreviousMonths2; borDividendPreviousMonths2.Clean = value; _borDividendPreviousMonths2 = borDividendPreviousMonths2;
                var borDividendPreviousYear1 = _borDividendPreviousYear1; borDividendPreviousYear1.Clean = value; _borDividendPreviousYear1 = borDividendPreviousYear1;
                var borDividendPreviousYear2 = _borDividendPreviousYear2; borDividendPreviousYear2.Clean = value; _borDividendPreviousYear2 = borDividendPreviousYear2;
                var borDividendRequiredForCashAmount = _borDividendRequiredForCashAmount; borDividendRequiredForCashAmount.Clean = value; _borDividendRequiredForCashAmount = borDividendRequiredForCashAmount;
                var borInterestAverageDividend = _borInterestAverageDividend; borInterestAverageDividend.Clean = value; _borInterestAverageDividend = borInterestAverageDividend;
                var borInterestPreviousAmount1 = _borInterestPreviousAmount1; borInterestPreviousAmount1.Clean = value; _borInterestPreviousAmount1 = borInterestPreviousAmount1;
                var borInterestPreviousAmount2 = _borInterestPreviousAmount2; borInterestPreviousAmount2.Clean = value; _borInterestPreviousAmount2 = borInterestPreviousAmount2;
                var borInterestPreviousMonths1 = _borInterestPreviousMonths1; borInterestPreviousMonths1.Clean = value; _borInterestPreviousMonths1 = borInterestPreviousMonths1;
                var borInterestPreviousMonths2 = _borInterestPreviousMonths2; borInterestPreviousMonths2.Clean = value; _borInterestPreviousMonths2 = borInterestPreviousMonths2;
                var borInterestPreviousYear1 = _borInterestPreviousYear1; borInterestPreviousYear1.Clean = value; _borInterestPreviousYear1 = borInterestPreviousYear1;
                var borInterestPreviousYear2 = _borInterestPreviousYear2; borInterestPreviousYear2.Clean = value; _borInterestPreviousYear2 = borInterestPreviousYear2;
                var borInterestRequiredForCashAmount = _borInterestRequiredForCashAmount; borInterestRequiredForCashAmount.Clean = value; _borInterestRequiredForCashAmount = borInterestRequiredForCashAmount;
                var borMilitaryAllowanceClothingAllowance = _borMilitaryAllowanceClothingAllowance; borMilitaryAllowanceClothingAllowance.Clean = value; _borMilitaryAllowanceClothingAllowance = borMilitaryAllowanceClothingAllowance;
                var borMilitaryAllowanceOtherAllowance = _borMilitaryAllowanceOtherAllowance; borMilitaryAllowanceOtherAllowance.Clean = value; _borMilitaryAllowanceOtherAllowance = borMilitaryAllowanceOtherAllowance;
                var borMilitaryAllowanceOtherAllowanceDescription = _borMilitaryAllowanceOtherAllowanceDescription; borMilitaryAllowanceOtherAllowanceDescription.Clean = value; _borMilitaryAllowanceOtherAllowanceDescription = borMilitaryAllowanceOtherAllowanceDescription;
                var borMilitaryAllowanceQuartersAllowance = _borMilitaryAllowanceQuartersAllowance; borMilitaryAllowanceQuartersAllowance.Clean = value; _borMilitaryAllowanceQuartersAllowance = borMilitaryAllowanceQuartersAllowance;
                var borMilitaryAllowanceRationsAllowance = _borMilitaryAllowanceRationsAllowance; borMilitaryAllowanceRationsAllowance.Clean = value; _borMilitaryAllowanceRationsAllowance = borMilitaryAllowanceRationsAllowance;
                var borMilitaryAllowanceTotalAllowance = _borMilitaryAllowanceTotalAllowance; borMilitaryAllowanceTotalAllowance.Clean = value; _borMilitaryAllowanceTotalAllowance = borMilitaryAllowanceTotalAllowance;
                var borMilitaryAllowanceVariableHousingAllowance = _borMilitaryAllowanceVariableHousingAllowance; borMilitaryAllowanceVariableHousingAllowance.Clean = value; _borMilitaryAllowanceVariableHousingAllowance = borMilitaryAllowanceVariableHousingAllowance;
                var borMilitaryBasePay = _borMilitaryBasePay; borMilitaryBasePay.Clean = value; _borMilitaryBasePay = borMilitaryBasePay;
                var borMilitaryCombatPay = _borMilitaryCombatPay; borMilitaryCombatPay.Clean = value; _borMilitaryCombatPay = borMilitaryCombatPay;
                var borMilitaryFlightPay = _borMilitaryFlightPay; borMilitaryFlightPay.Clean = value; _borMilitaryFlightPay = borMilitaryFlightPay;
                var borMilitaryHazardPay = _borMilitaryHazardPay; borMilitaryHazardPay.Clean = value; _borMilitaryHazardPay = borMilitaryHazardPay;
                var borMilitaryOverseasPay = _borMilitaryOverseasPay; borMilitaryOverseasPay.Clean = value; _borMilitaryOverseasPay = borMilitaryOverseasPay;
                var borMilitaryPropPay = _borMilitaryPropPay; borMilitaryPropPay.Clean = value; _borMilitaryPropPay = borMilitaryPropPay;
                var borMilitaryTotalPay = _borMilitaryTotalPay; borMilitaryTotalPay.Clean = value; _borMilitaryTotalPay = borMilitaryTotalPay;
                var borMonthlyEmplymentIncomeBaseIncome = _borMonthlyEmplymentIncomeBaseIncome; borMonthlyEmplymentIncomeBaseIncome.Clean = value; _borMonthlyEmplymentIncomeBaseIncome = borMonthlyEmplymentIncomeBaseIncome;
                var borMonthlyEmplymentIncomeBonuseIncome = _borMonthlyEmplymentIncomeBonuseIncome; borMonthlyEmplymentIncomeBonuseIncome.Clean = value; _borMonthlyEmplymentIncomeBonuseIncome = borMonthlyEmplymentIncomeBonuseIncome;
                var borMonthlyEmplymentIncomeCommissionIncome = _borMonthlyEmplymentIncomeCommissionIncome; borMonthlyEmplymentIncomeCommissionIncome.Clean = value; _borMonthlyEmplymentIncomeCommissionIncome = borMonthlyEmplymentIncomeCommissionIncome;
                var borMonthlyEmplymentIncomeDividendInterestIncome = _borMonthlyEmplymentIncomeDividendInterestIncome; borMonthlyEmplymentIncomeDividendInterestIncome.Clean = value; _borMonthlyEmplymentIncomeDividendInterestIncome = borMonthlyEmplymentIncomeDividendInterestIncome;
                var borMonthlyEmplymentIncomeOtherIncome1 = _borMonthlyEmplymentIncomeOtherIncome1; borMonthlyEmplymentIncomeOtherIncome1.Clean = value; _borMonthlyEmplymentIncomeOtherIncome1 = borMonthlyEmplymentIncomeOtherIncome1;
                var borMonthlyEmplymentIncomeOtherIncome2 = _borMonthlyEmplymentIncomeOtherIncome2; borMonthlyEmplymentIncomeOtherIncome2.Clean = value; _borMonthlyEmplymentIncomeOtherIncome2 = borMonthlyEmplymentIncomeOtherIncome2;
                var borMonthlyEmplymentIncomeOvertimeIncome = _borMonthlyEmplymentIncomeOvertimeIncome; borMonthlyEmplymentIncomeOvertimeIncome.Clean = value; _borMonthlyEmplymentIncomeOvertimeIncome = borMonthlyEmplymentIncomeOvertimeIncome;
                var borMonthlyEmplymentIncomeTotalEmploymentIncome = _borMonthlyEmplymentIncomeTotalEmploymentIncome; borMonthlyEmplymentIncomeTotalEmploymentIncome.Clean = value; _borMonthlyEmplymentIncomeTotalEmploymentIncome = borMonthlyEmplymentIncomeTotalEmploymentIncome;
                var borNonEmploymentIncomeGovtAssitProgramIncome = _borNonEmploymentIncomeGovtAssitProgramIncome; borNonEmploymentIncomeGovtAssitProgramIncome.Clean = value; _borNonEmploymentIncomeGovtAssitProgramIncome = borNonEmploymentIncomeGovtAssitProgramIncome;
                var borNonEmploymentIncomeHomeownSubsidyIncome = _borNonEmploymentIncomeHomeownSubsidyIncome; borNonEmploymentIncomeHomeownSubsidyIncome.Clean = value; _borNonEmploymentIncomeHomeownSubsidyIncome = borNonEmploymentIncomeHomeownSubsidyIncome;
                var borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome = _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome; borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome.Clean = value; _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome = borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome;
                var borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome = _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome; borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome.Clean = value; _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome = borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome;
                var borNonEmploymentIncomeMilitaryIncome = _borNonEmploymentIncomeMilitaryIncome; borNonEmploymentIncomeMilitaryIncome.Clean = value; _borNonEmploymentIncomeMilitaryIncome = borNonEmploymentIncomeMilitaryIncome;
                var borNonEmploymentIncomeMtgCreditCertificateIncome = _borNonEmploymentIncomeMtgCreditCertificateIncome; borNonEmploymentIncomeMtgCreditCertificateIncome.Clean = value; _borNonEmploymentIncomeMtgCreditCertificateIncome = borNonEmploymentIncomeMtgCreditCertificateIncome;
                var borNonEmploymentIncomeTotalNonEmploymentIncome = _borNonEmploymentIncomeTotalNonEmploymentIncome; borNonEmploymentIncomeTotalNonEmploymentIncome.Clean = value; _borNonEmploymentIncomeTotalNonEmploymentIncome = borNonEmploymentIncomeTotalNonEmploymentIncome;
                var borNonEmploymentIncomeVABenefitIncome = _borNonEmploymentIncomeVABenefitIncome; borNonEmploymentIncomeVABenefitIncome.Clean = value; _borNonEmploymentIncomeVABenefitIncome = borNonEmploymentIncomeVABenefitIncome;
                var borNonTaxableIncomeChildSupportIncome = _borNonTaxableIncomeChildSupportIncome; borNonTaxableIncomeChildSupportIncome.Clean = value; _borNonTaxableIncomeChildSupportIncome = borNonTaxableIncomeChildSupportIncome;
                var borNonTaxableIncomeDisabilityIncome = _borNonTaxableIncomeDisabilityIncome; borNonTaxableIncomeDisabilityIncome.Clean = value; _borNonTaxableIncomeDisabilityIncome = borNonTaxableIncomeDisabilityIncome;
                var borNonTaxableIncomeFedGovtEmplRetirementIncome = _borNonTaxableIncomeFedGovtEmplRetirementIncome; borNonTaxableIncomeFedGovtEmplRetirementIncome.Clean = value; _borNonTaxableIncomeFedGovtEmplRetirementIncome = borNonTaxableIncomeFedGovtEmplRetirementIncome;
                var borNonTaxableIncomeMilitaryAllowances = _borNonTaxableIncomeMilitaryAllowances; borNonTaxableIncomeMilitaryAllowances.Clean = value; _borNonTaxableIncomeMilitaryAllowances = borNonTaxableIncomeMilitaryAllowances;
                var borNonTaxableIncomeOtherIncome = _borNonTaxableIncomeOtherIncome; borNonTaxableIncomeOtherIncome.Clean = value; _borNonTaxableIncomeOtherIncome = borNonTaxableIncomeOtherIncome;
                var borNonTaxableIncomePublicAssistPayments = _borNonTaxableIncomePublicAssistPayments; borNonTaxableIncomePublicAssistPayments.Clean = value; _borNonTaxableIncomePublicAssistPayments = borNonTaxableIncomePublicAssistPayments;
                var borNonTaxableIncomeRailroadRetirementBenefits = _borNonTaxableIncomeRailroadRetirementBenefits; borNonTaxableIncomeRailroadRetirementBenefits.Clean = value; _borNonTaxableIncomeRailroadRetirementBenefits = borNonTaxableIncomeRailroadRetirementBenefits;
                var borNonTaxableIncomeSocialSecurityIncome = _borNonTaxableIncomeSocialSecurityIncome; borNonTaxableIncomeSocialSecurityIncome.Clean = value; _borNonTaxableIncomeSocialSecurityIncome = borNonTaxableIncomeSocialSecurityIncome;
                var borNonTaxableIncomeStateGovtEmplRetirementIncome = _borNonTaxableIncomeStateGovtEmplRetirementIncome; borNonTaxableIncomeStateGovtEmplRetirementIncome.Clean = value; _borNonTaxableIncomeStateGovtEmplRetirementIncome = borNonTaxableIncomeStateGovtEmplRetirementIncome;
                var borNonTaxableIncomeTotalNonTaxableIncome = _borNonTaxableIncomeTotalNonTaxableIncome; borNonTaxableIncomeTotalNonTaxableIncome.Clean = value; _borNonTaxableIncomeTotalNonTaxableIncome = borNonTaxableIncomeTotalNonTaxableIncome;
                var borOtherNotesReceivableIncome = _borOtherNotesReceivableIncome; borOtherNotesReceivableIncome.Clean = value; _borOtherNotesReceivableIncome = borOtherNotesReceivableIncome;
                var borOtherOtherIncome = _borOtherOtherIncome; borOtherOtherIncome.Clean = value; _borOtherOtherIncome = borOtherOtherIncome;
                var borOtherParttimeIncome = _borOtherParttimeIncome; borOtherParttimeIncome.Clean = value; _borOtherParttimeIncome = borOtherParttimeIncome;
                var borOtherRetirementIncome = _borOtherRetirementIncome; borOtherRetirementIncome.Clean = value; _borOtherRetirementIncome = borOtherRetirementIncome;
                var borOtherSeasonalIncome = _borOtherSeasonalIncome; borOtherSeasonalIncome.Clean = value; _borOtherSeasonalIncome = borOtherSeasonalIncome;
                var borOtherSocialSecurityIncome = _borOtherSocialSecurityIncome; borOtherSocialSecurityIncome.Clean = value; _borOtherSocialSecurityIncome = borOtherSocialSecurityIncome;
                var borOtherTipIncome = _borOtherTipIncome; borOtherTipIncome.Clean = value; _borOtherTipIncome = borOtherTipIncome;
                var borOtherTrustIncome = _borOtherTrustIncome; borOtherTrustIncome.Clean = value; _borOtherTrustIncome = borOtherTrustIncome;
                var borOtherUnemploymentIncome = _borOtherUnemploymentIncome; borOtherUnemploymentIncome.Clean = value; _borOtherUnemploymentIncome = borOtherUnemploymentIncome;
                var borOvertimeAverageOvertime = _borOvertimeAverageOvertime; borOvertimeAverageOvertime.Clean = value; _borOvertimeAverageOvertime = borOvertimeAverageOvertime;
                var borOvertimeMostRecentAmount = _borOvertimeMostRecentAmount; borOvertimeMostRecentAmount.Clean = value; _borOvertimeMostRecentAmount = borOvertimeMostRecentAmount;
                var borOvertimeMostRecentMonths = _borOvertimeMostRecentMonths; borOvertimeMostRecentMonths.Clean = value; _borOvertimeMostRecentMonths = borOvertimeMostRecentMonths;
                var borOvertimeMostRecentYear = _borOvertimeMostRecentYear; borOvertimeMostRecentYear.Clean = value; _borOvertimeMostRecentYear = borOvertimeMostRecentYear;
                var borOvertimePreviousAmount1 = _borOvertimePreviousAmount1; borOvertimePreviousAmount1.Clean = value; _borOvertimePreviousAmount1 = borOvertimePreviousAmount1;
                var borOvertimePreviousAmount2 = _borOvertimePreviousAmount2; borOvertimePreviousAmount2.Clean = value; _borOvertimePreviousAmount2 = borOvertimePreviousAmount2;
                var borOvertimePreviousMonths1 = _borOvertimePreviousMonths1; borOvertimePreviousMonths1.Clean = value; _borOvertimePreviousMonths1 = borOvertimePreviousMonths1;
                var borOvertimePreviousMonths2 = _borOvertimePreviousMonths2; borOvertimePreviousMonths2.Clean = value; _borOvertimePreviousMonths2 = borOvertimePreviousMonths2;
                var borOvertimePreviousYear1 = _borOvertimePreviousYear1; borOvertimePreviousYear1.Clean = value; _borOvertimePreviousYear1 = borOvertimePreviousYear1;
                var borOvertimePreviousYear2 = _borOvertimePreviousYear2; borOvertimePreviousYear2.Clean = value; _borOvertimePreviousYear2 = borOvertimePreviousYear2;
                var borProjectedIncomeProjectedBonuses = _borProjectedIncomeProjectedBonuses; borProjectedIncomeProjectedBonuses.Clean = value; _borProjectedIncomeProjectedBonuses = borProjectedIncomeProjectedBonuses;
                var borProjectedIncomeProjectedCostLivingAdjustment = _borProjectedIncomeProjectedCostLivingAdjustment; borProjectedIncomeProjectedCostLivingAdjustment.Clean = value; _borProjectedIncomeProjectedCostLivingAdjustment = borProjectedIncomeProjectedCostLivingAdjustment;
                var borProjectedIncomeProjectedNewJobIncome = _borProjectedIncomeProjectedNewJobIncome; borProjectedIncomeProjectedNewJobIncome.Clean = value; _borProjectedIncomeProjectedNewJobIncome = borProjectedIncomeProjectedNewJobIncome;
                var borProjectedIncomeProjectedPerformanceRaises = _borProjectedIncomeProjectedPerformanceRaises; borProjectedIncomeProjectedPerformanceRaises.Clean = value; _borProjectedIncomeProjectedPerformanceRaises = borProjectedIncomeProjectedPerformanceRaises;
                var borProjectedIncomeTotalProjectedIncome = _borProjectedIncomeTotalProjectedIncome; borProjectedIncomeTotalProjectedIncome.Clean = value; _borProjectedIncomeTotalProjectedIncome = borProjectedIncomeTotalProjectedIncome;
                var cobBonusAverageOvertime = _cobBonusAverageOvertime; cobBonusAverageOvertime.Clean = value; _cobBonusAverageOvertime = cobBonusAverageOvertime;
                var cobBonusMostRecentAmount = _cobBonusMostRecentAmount; cobBonusMostRecentAmount.Clean = value; _cobBonusMostRecentAmount = cobBonusMostRecentAmount;
                var cobBonusMostRecentMonths = _cobBonusMostRecentMonths; cobBonusMostRecentMonths.Clean = value; _cobBonusMostRecentMonths = cobBonusMostRecentMonths;
                var cobBonusMostRecentYear = _cobBonusMostRecentYear; cobBonusMostRecentYear.Clean = value; _cobBonusMostRecentYear = cobBonusMostRecentYear;
                var cobBonusPreviousAmount1 = _cobBonusPreviousAmount1; cobBonusPreviousAmount1.Clean = value; _cobBonusPreviousAmount1 = cobBonusPreviousAmount1;
                var cobBonusPreviousAmount2 = _cobBonusPreviousAmount2; cobBonusPreviousAmount2.Clean = value; _cobBonusPreviousAmount2 = cobBonusPreviousAmount2;
                var cobBonusPreviousMonths1 = _cobBonusPreviousMonths1; cobBonusPreviousMonths1.Clean = value; _cobBonusPreviousMonths1 = cobBonusPreviousMonths1;
                var cobBonusPreviousMonths2 = _cobBonusPreviousMonths2; cobBonusPreviousMonths2.Clean = value; _cobBonusPreviousMonths2 = cobBonusPreviousMonths2;
                var cobBonusPreviousYear1 = _cobBonusPreviousYear1; cobBonusPreviousYear1.Clean = value; _cobBonusPreviousYear1 = cobBonusPreviousYear1;
                var cobBonusPreviousYear2 = _cobBonusPreviousYear2; cobBonusPreviousYear2.Clean = value; _cobBonusPreviousYear2 = cobBonusPreviousYear2;
                var cobCommissionAverageOvertime = _cobCommissionAverageOvertime; cobCommissionAverageOvertime.Clean = value; _cobCommissionAverageOvertime = cobCommissionAverageOvertime;
                var cobCommissionMostRecentAmount = _cobCommissionMostRecentAmount; cobCommissionMostRecentAmount.Clean = value; _cobCommissionMostRecentAmount = cobCommissionMostRecentAmount;
                var cobCommissionMostRecentMonths = _cobCommissionMostRecentMonths; cobCommissionMostRecentMonths.Clean = value; _cobCommissionMostRecentMonths = cobCommissionMostRecentMonths;
                var cobCommissionMostRecentYear = _cobCommissionMostRecentYear; cobCommissionMostRecentYear.Clean = value; _cobCommissionMostRecentYear = cobCommissionMostRecentYear;
                var cobCommissionPreviousAmount1 = _cobCommissionPreviousAmount1; cobCommissionPreviousAmount1.Clean = value; _cobCommissionPreviousAmount1 = cobCommissionPreviousAmount1;
                var cobCommissionPreviousAmount2 = _cobCommissionPreviousAmount2; cobCommissionPreviousAmount2.Clean = value; _cobCommissionPreviousAmount2 = cobCommissionPreviousAmount2;
                var cobCommissionPreviousMonths1 = _cobCommissionPreviousMonths1; cobCommissionPreviousMonths1.Clean = value; _cobCommissionPreviousMonths1 = cobCommissionPreviousMonths1;
                var cobCommissionPreviousMonths2 = _cobCommissionPreviousMonths2; cobCommissionPreviousMonths2.Clean = value; _cobCommissionPreviousMonths2 = cobCommissionPreviousMonths2;
                var cobCommissionPreviousYear1 = _cobCommissionPreviousYear1; cobCommissionPreviousYear1.Clean = value; _cobCommissionPreviousYear1 = cobCommissionPreviousYear1;
                var cobCommissionPreviousYear2 = _cobCommissionPreviousYear2; cobCommissionPreviousYear2.Clean = value; _cobCommissionPreviousYear2 = cobCommissionPreviousYear2;
                var cobDividendAverageDividend = _cobDividendAverageDividend; cobDividendAverageDividend.Clean = value; _cobDividendAverageDividend = cobDividendAverageDividend;
                var cobDividendPreviousAmount1 = _cobDividendPreviousAmount1; cobDividendPreviousAmount1.Clean = value; _cobDividendPreviousAmount1 = cobDividendPreviousAmount1;
                var cobDividendPreviousAmount2 = _cobDividendPreviousAmount2; cobDividendPreviousAmount2.Clean = value; _cobDividendPreviousAmount2 = cobDividendPreviousAmount2;
                var cobDividendPreviousMonths1 = _cobDividendPreviousMonths1; cobDividendPreviousMonths1.Clean = value; _cobDividendPreviousMonths1 = cobDividendPreviousMonths1;
                var cobDividendPreviousMonths2 = _cobDividendPreviousMonths2; cobDividendPreviousMonths2.Clean = value; _cobDividendPreviousMonths2 = cobDividendPreviousMonths2;
                var cobDividendPreviousYear1 = _cobDividendPreviousYear1; cobDividendPreviousYear1.Clean = value; _cobDividendPreviousYear1 = cobDividendPreviousYear1;
                var cobDividendPreviousYear2 = _cobDividendPreviousYear2; cobDividendPreviousYear2.Clean = value; _cobDividendPreviousYear2 = cobDividendPreviousYear2;
                var cobDividendRequiredForCashAmount = _cobDividendRequiredForCashAmount; cobDividendRequiredForCashAmount.Clean = value; _cobDividendRequiredForCashAmount = cobDividendRequiredForCashAmount;
                var cobInterestAverageDividend = _cobInterestAverageDividend; cobInterestAverageDividend.Clean = value; _cobInterestAverageDividend = cobInterestAverageDividend;
                var cobInterestPreviousAmount1 = _cobInterestPreviousAmount1; cobInterestPreviousAmount1.Clean = value; _cobInterestPreviousAmount1 = cobInterestPreviousAmount1;
                var cobInterestPreviousAmount2 = _cobInterestPreviousAmount2; cobInterestPreviousAmount2.Clean = value; _cobInterestPreviousAmount2 = cobInterestPreviousAmount2;
                var cobInterestPreviousMonths1 = _cobInterestPreviousMonths1; cobInterestPreviousMonths1.Clean = value; _cobInterestPreviousMonths1 = cobInterestPreviousMonths1;
                var cobInterestPreviousMonths2 = _cobInterestPreviousMonths2; cobInterestPreviousMonths2.Clean = value; _cobInterestPreviousMonths2 = cobInterestPreviousMonths2;
                var cobInterestPreviousYear1 = _cobInterestPreviousYear1; cobInterestPreviousYear1.Clean = value; _cobInterestPreviousYear1 = cobInterestPreviousYear1;
                var cobInterestPreviousYear2 = _cobInterestPreviousYear2; cobInterestPreviousYear2.Clean = value; _cobInterestPreviousYear2 = cobInterestPreviousYear2;
                var cobInterestRequiredForCashAmount = _cobInterestRequiredForCashAmount; cobInterestRequiredForCashAmount.Clean = value; _cobInterestRequiredForCashAmount = cobInterestRequiredForCashAmount;
                var cobMilitaryAllowanceClothingAllowance = _cobMilitaryAllowanceClothingAllowance; cobMilitaryAllowanceClothingAllowance.Clean = value; _cobMilitaryAllowanceClothingAllowance = cobMilitaryAllowanceClothingAllowance;
                var cobMilitaryAllowanceOtherAllowance = _cobMilitaryAllowanceOtherAllowance; cobMilitaryAllowanceOtherAllowance.Clean = value; _cobMilitaryAllowanceOtherAllowance = cobMilitaryAllowanceOtherAllowance;
                var cobMilitaryAllowanceQuartersAllowance = _cobMilitaryAllowanceQuartersAllowance; cobMilitaryAllowanceQuartersAllowance.Clean = value; _cobMilitaryAllowanceQuartersAllowance = cobMilitaryAllowanceQuartersAllowance;
                var cobMilitaryAllowanceRationsAllowance = _cobMilitaryAllowanceRationsAllowance; cobMilitaryAllowanceRationsAllowance.Clean = value; _cobMilitaryAllowanceRationsAllowance = cobMilitaryAllowanceRationsAllowance;
                var cobMilitaryAllowanceTotalAllowance = _cobMilitaryAllowanceTotalAllowance; cobMilitaryAllowanceTotalAllowance.Clean = value; _cobMilitaryAllowanceTotalAllowance = cobMilitaryAllowanceTotalAllowance;
                var cobMilitaryAllowanceVariableHousingAllowance = _cobMilitaryAllowanceVariableHousingAllowance; cobMilitaryAllowanceVariableHousingAllowance.Clean = value; _cobMilitaryAllowanceVariableHousingAllowance = cobMilitaryAllowanceVariableHousingAllowance;
                var cobMilitaryBasePay = _cobMilitaryBasePay; cobMilitaryBasePay.Clean = value; _cobMilitaryBasePay = cobMilitaryBasePay;
                var cobMilitaryCombatPay = _cobMilitaryCombatPay; cobMilitaryCombatPay.Clean = value; _cobMilitaryCombatPay = cobMilitaryCombatPay;
                var cobMilitaryFlightPay = _cobMilitaryFlightPay; cobMilitaryFlightPay.Clean = value; _cobMilitaryFlightPay = cobMilitaryFlightPay;
                var cobMilitaryHazardPay = _cobMilitaryHazardPay; cobMilitaryHazardPay.Clean = value; _cobMilitaryHazardPay = cobMilitaryHazardPay;
                var cobMilitaryOverseasPay = _cobMilitaryOverseasPay; cobMilitaryOverseasPay.Clean = value; _cobMilitaryOverseasPay = cobMilitaryOverseasPay;
                var cobMilitaryPropPay = _cobMilitaryPropPay; cobMilitaryPropPay.Clean = value; _cobMilitaryPropPay = cobMilitaryPropPay;
                var cobMilitaryTotalPay = _cobMilitaryTotalPay; cobMilitaryTotalPay.Clean = value; _cobMilitaryTotalPay = cobMilitaryTotalPay;
                var cobMonthlyEmplymentIncomeBaseIncome = _cobMonthlyEmplymentIncomeBaseIncome; cobMonthlyEmplymentIncomeBaseIncome.Clean = value; _cobMonthlyEmplymentIncomeBaseIncome = cobMonthlyEmplymentIncomeBaseIncome;
                var cobMonthlyEmplymentIncomeBonuseIncome = _cobMonthlyEmplymentIncomeBonuseIncome; cobMonthlyEmplymentIncomeBonuseIncome.Clean = value; _cobMonthlyEmplymentIncomeBonuseIncome = cobMonthlyEmplymentIncomeBonuseIncome;
                var cobMonthlyEmplymentIncomeCommissionIncome = _cobMonthlyEmplymentIncomeCommissionIncome; cobMonthlyEmplymentIncomeCommissionIncome.Clean = value; _cobMonthlyEmplymentIncomeCommissionIncome = cobMonthlyEmplymentIncomeCommissionIncome;
                var cobMonthlyEmplymentIncomeDividendInterestIncome = _cobMonthlyEmplymentIncomeDividendInterestIncome; cobMonthlyEmplymentIncomeDividendInterestIncome.Clean = value; _cobMonthlyEmplymentIncomeDividendInterestIncome = cobMonthlyEmplymentIncomeDividendInterestIncome;
                var cobMonthlyEmplymentIncomeOtherIncome1 = _cobMonthlyEmplymentIncomeOtherIncome1; cobMonthlyEmplymentIncomeOtherIncome1.Clean = value; _cobMonthlyEmplymentIncomeOtherIncome1 = cobMonthlyEmplymentIncomeOtherIncome1;
                var cobMonthlyEmplymentIncomeOtherIncome2 = _cobMonthlyEmplymentIncomeOtherIncome2; cobMonthlyEmplymentIncomeOtherIncome2.Clean = value; _cobMonthlyEmplymentIncomeOtherIncome2 = cobMonthlyEmplymentIncomeOtherIncome2;
                var cobMonthlyEmplymentIncomeOvertimeIncome = _cobMonthlyEmplymentIncomeOvertimeIncome; cobMonthlyEmplymentIncomeOvertimeIncome.Clean = value; _cobMonthlyEmplymentIncomeOvertimeIncome = cobMonthlyEmplymentIncomeOvertimeIncome;
                var cobMonthlyEmplymentIncomeTotalEmploymentIncome = _cobMonthlyEmplymentIncomeTotalEmploymentIncome; cobMonthlyEmplymentIncomeTotalEmploymentIncome.Clean = value; _cobMonthlyEmplymentIncomeTotalEmploymentIncome = cobMonthlyEmplymentIncomeTotalEmploymentIncome;
                var cobNonEmploymentIncomeGovtAssitProgramIncome = _cobNonEmploymentIncomeGovtAssitProgramIncome; cobNonEmploymentIncomeGovtAssitProgramIncome.Clean = value; _cobNonEmploymentIncomeGovtAssitProgramIncome = cobNonEmploymentIncomeGovtAssitProgramIncome;
                var cobNonEmploymentIncomeHomeownSubsidyIncome = _cobNonEmploymentIncomeHomeownSubsidyIncome; cobNonEmploymentIncomeHomeownSubsidyIncome.Clean = value; _cobNonEmploymentIncomeHomeownSubsidyIncome = cobNonEmploymentIncomeHomeownSubsidyIncome;
                var cobNonEmploymentIncomeMilitaryIncome = _cobNonEmploymentIncomeMilitaryIncome; cobNonEmploymentIncomeMilitaryIncome.Clean = value; _cobNonEmploymentIncomeMilitaryIncome = cobNonEmploymentIncomeMilitaryIncome;
                var cobNonEmploymentIncomeMtgCreditCertificateIncome = _cobNonEmploymentIncomeMtgCreditCertificateIncome; cobNonEmploymentIncomeMtgCreditCertificateIncome.Clean = value; _cobNonEmploymentIncomeMtgCreditCertificateIncome = cobNonEmploymentIncomeMtgCreditCertificateIncome;
                var cobNonEmploymentIncomeTotalNonEmploymentIncome = _cobNonEmploymentIncomeTotalNonEmploymentIncome; cobNonEmploymentIncomeTotalNonEmploymentIncome.Clean = value; _cobNonEmploymentIncomeTotalNonEmploymentIncome = cobNonEmploymentIncomeTotalNonEmploymentIncome;
                var cobNonEmploymentIncomeVABenefitIncome = _cobNonEmploymentIncomeVABenefitIncome; cobNonEmploymentIncomeVABenefitIncome.Clean = value; _cobNonEmploymentIncomeVABenefitIncome = cobNonEmploymentIncomeVABenefitIncome;
                var cobNonTaxableIncomeChildSupportIncome = _cobNonTaxableIncomeChildSupportIncome; cobNonTaxableIncomeChildSupportIncome.Clean = value; _cobNonTaxableIncomeChildSupportIncome = cobNonTaxableIncomeChildSupportIncome;
                var cobNonTaxableIncomeDisabilityIncome = _cobNonTaxableIncomeDisabilityIncome; cobNonTaxableIncomeDisabilityIncome.Clean = value; _cobNonTaxableIncomeDisabilityIncome = cobNonTaxableIncomeDisabilityIncome;
                var cobNonTaxableIncomeFedGovtEmplRetirementIncome = _cobNonTaxableIncomeFedGovtEmplRetirementIncome; cobNonTaxableIncomeFedGovtEmplRetirementIncome.Clean = value; _cobNonTaxableIncomeFedGovtEmplRetirementIncome = cobNonTaxableIncomeFedGovtEmplRetirementIncome;
                var cobNonTaxableIncomeMilitaryAllowances = _cobNonTaxableIncomeMilitaryAllowances; cobNonTaxableIncomeMilitaryAllowances.Clean = value; _cobNonTaxableIncomeMilitaryAllowances = cobNonTaxableIncomeMilitaryAllowances;
                var cobNonTaxableIncomeOtherIncome = _cobNonTaxableIncomeOtherIncome; cobNonTaxableIncomeOtherIncome.Clean = value; _cobNonTaxableIncomeOtherIncome = cobNonTaxableIncomeOtherIncome;
                var cobNonTaxableIncomePublicAssistPayments = _cobNonTaxableIncomePublicAssistPayments; cobNonTaxableIncomePublicAssistPayments.Clean = value; _cobNonTaxableIncomePublicAssistPayments = cobNonTaxableIncomePublicAssistPayments;
                var cobNonTaxableIncomeRailroadRetirementBenefits = _cobNonTaxableIncomeRailroadRetirementBenefits; cobNonTaxableIncomeRailroadRetirementBenefits.Clean = value; _cobNonTaxableIncomeRailroadRetirementBenefits = cobNonTaxableIncomeRailroadRetirementBenefits;
                var cobNonTaxableIncomeSocialSecurityIncome = _cobNonTaxableIncomeSocialSecurityIncome; cobNonTaxableIncomeSocialSecurityIncome.Clean = value; _cobNonTaxableIncomeSocialSecurityIncome = cobNonTaxableIncomeSocialSecurityIncome;
                var cobNonTaxableIncomeStateGovtEmplRetirementIncome = _cobNonTaxableIncomeStateGovtEmplRetirementIncome; cobNonTaxableIncomeStateGovtEmplRetirementIncome.Clean = value; _cobNonTaxableIncomeStateGovtEmplRetirementIncome = cobNonTaxableIncomeStateGovtEmplRetirementIncome;
                var cobNonTaxableIncomeTotalNonTaxableIncome = _cobNonTaxableIncomeTotalNonTaxableIncome; cobNonTaxableIncomeTotalNonTaxableIncome.Clean = value; _cobNonTaxableIncomeTotalNonTaxableIncome = cobNonTaxableIncomeTotalNonTaxableIncome;
                var cobOtherNotesReceivableIncome = _cobOtherNotesReceivableIncome; cobOtherNotesReceivableIncome.Clean = value; _cobOtherNotesReceivableIncome = cobOtherNotesReceivableIncome;
                var cobOtherOtherIncome = _cobOtherOtherIncome; cobOtherOtherIncome.Clean = value; _cobOtherOtherIncome = cobOtherOtherIncome;
                var cobOtherParttimeIncome = _cobOtherParttimeIncome; cobOtherParttimeIncome.Clean = value; _cobOtherParttimeIncome = cobOtherParttimeIncome;
                var cobOtherRetirementIncome = _cobOtherRetirementIncome; cobOtherRetirementIncome.Clean = value; _cobOtherRetirementIncome = cobOtherRetirementIncome;
                var cobOtherSeasonalIncome = _cobOtherSeasonalIncome; cobOtherSeasonalIncome.Clean = value; _cobOtherSeasonalIncome = cobOtherSeasonalIncome;
                var cobOtherSocialSecurityIncome = _cobOtherSocialSecurityIncome; cobOtherSocialSecurityIncome.Clean = value; _cobOtherSocialSecurityIncome = cobOtherSocialSecurityIncome;
                var cobOtherTipIncome = _cobOtherTipIncome; cobOtherTipIncome.Clean = value; _cobOtherTipIncome = cobOtherTipIncome;
                var cobOtherTrustIncome = _cobOtherTrustIncome; cobOtherTrustIncome.Clean = value; _cobOtherTrustIncome = cobOtherTrustIncome;
                var cobOtherUnemploymentIncome = _cobOtherUnemploymentIncome; cobOtherUnemploymentIncome.Clean = value; _cobOtherUnemploymentIncome = cobOtherUnemploymentIncome;
                var cobOvertimeAverageOvertime = _cobOvertimeAverageOvertime; cobOvertimeAverageOvertime.Clean = value; _cobOvertimeAverageOvertime = cobOvertimeAverageOvertime;
                var cobOvertimeMostRecentAmount = _cobOvertimeMostRecentAmount; cobOvertimeMostRecentAmount.Clean = value; _cobOvertimeMostRecentAmount = cobOvertimeMostRecentAmount;
                var cobOvertimeMostRecentMonths = _cobOvertimeMostRecentMonths; cobOvertimeMostRecentMonths.Clean = value; _cobOvertimeMostRecentMonths = cobOvertimeMostRecentMonths;
                var cobOvertimeMostRecentYear = _cobOvertimeMostRecentYear; cobOvertimeMostRecentYear.Clean = value; _cobOvertimeMostRecentYear = cobOvertimeMostRecentYear;
                var cobOvertimePreviousAmount1 = _cobOvertimePreviousAmount1; cobOvertimePreviousAmount1.Clean = value; _cobOvertimePreviousAmount1 = cobOvertimePreviousAmount1;
                var cobOvertimePreviousAmount2 = _cobOvertimePreviousAmount2; cobOvertimePreviousAmount2.Clean = value; _cobOvertimePreviousAmount2 = cobOvertimePreviousAmount2;
                var cobOvertimePreviousMonths1 = _cobOvertimePreviousMonths1; cobOvertimePreviousMonths1.Clean = value; _cobOvertimePreviousMonths1 = cobOvertimePreviousMonths1;
                var cobOvertimePreviousMonths2 = _cobOvertimePreviousMonths2; cobOvertimePreviousMonths2.Clean = value; _cobOvertimePreviousMonths2 = cobOvertimePreviousMonths2;
                var cobOvertimePreviousYear1 = _cobOvertimePreviousYear1; cobOvertimePreviousYear1.Clean = value; _cobOvertimePreviousYear1 = cobOvertimePreviousYear1;
                var cobOvertimePreviousYear2 = _cobOvertimePreviousYear2; cobOvertimePreviousYear2.Clean = value; _cobOvertimePreviousYear2 = cobOvertimePreviousYear2;
                var cobProjectedIncomeProjectedBonuses = _cobProjectedIncomeProjectedBonuses; cobProjectedIncomeProjectedBonuses.Clean = value; _cobProjectedIncomeProjectedBonuses = cobProjectedIncomeProjectedBonuses;
                var cobProjectedIncomeProjectedCostLivingAdjustment = _cobProjectedIncomeProjectedCostLivingAdjustment; cobProjectedIncomeProjectedCostLivingAdjustment.Clean = value; _cobProjectedIncomeProjectedCostLivingAdjustment = cobProjectedIncomeProjectedCostLivingAdjustment;
                var cobProjectedIncomeProjectedNewJobIncome = _cobProjectedIncomeProjectedNewJobIncome; cobProjectedIncomeProjectedNewJobIncome.Clean = value; _cobProjectedIncomeProjectedNewJobIncome = cobProjectedIncomeProjectedNewJobIncome;
                var cobProjectedIncomeProjectedPerformanceRaises = _cobProjectedIncomeProjectedPerformanceRaises; cobProjectedIncomeProjectedPerformanceRaises.Clean = value; _cobProjectedIncomeProjectedPerformanceRaises = cobProjectedIncomeProjectedPerformanceRaises;
                var cobProjectedIncomeTotalProjectedIncome = _cobProjectedIncomeTotalProjectedIncome; cobProjectedIncomeTotalProjectedIncome.Clean = value; _cobProjectedIncomeTotalProjectedIncome = cobProjectedIncomeTotalProjectedIncome;
                var dUCaseIDorLPAUSKey = _dUCaseIDorLPAUSKey; dUCaseIDorLPAUSKey.Clean = value; _dUCaseIDorLPAUSKey = dUCaseIDorLPAUSKey;
                var firstSubmissionDate = _firstSubmissionDate; firstSubmissionDate.Clean = value; _firstSubmissionDate = firstSubmissionDate;
                var firstSubmissionTime = _firstSubmissionTime; firstSubmissionTime.Clean = value; _firstSubmissionTime = firstSubmissionTime;
                var freddieDocClass = _freddieDocClass; freddieDocClass.Clean = value; _freddieDocClass = freddieDocClass;
                var housingRatio = _housingRatio; housingRatio.Clean = value; _housingRatio = housingRatio;
                var id = _id; id.Clean = value; _id = id;
                var isEmpty = _isEmpty; isEmpty.Clean = value; _isEmpty = isEmpty;
                var submissionDate = _submissionDate; submissionDate.Clean = value; _submissionDate = submissionDate;
                var submissionNumber = _submissionNumber; submissionNumber.Clean = value; _submissionNumber = submissionNumber;
                var submissionTime = _submissionTime; submissionTime.Clean = value; _submissionTime = submissionTime;
                var submittedBy = _submittedBy; submittedBy.Clean = value; _submittedBy = submittedBy;
                var totalExpenseRatio = _totalExpenseRatio; totalExpenseRatio.Clean = value; _totalExpenseRatio = totalExpenseRatio;
                var totalHousingPayment = _totalHousingPayment; totalHousingPayment.Clean = value; _totalHousingPayment = totalHousingPayment;
                var totalMonthlyAssets = _totalMonthlyAssets; totalMonthlyAssets.Clean = value; _totalMonthlyAssets = totalMonthlyAssets;
                var totalMonthlyDebt = _totalMonthlyDebt; totalMonthlyDebt.Clean = value; _totalMonthlyDebt = totalMonthlyDebt;
                var totalMonthlyIncome = _totalMonthlyIncome; totalMonthlyIncome.Clean = value; _totalMonthlyIncome = totalMonthlyIncome;
                var underwritingRiskAssessOther = _underwritingRiskAssessOther; underwritingRiskAssessOther.Clean = value; _underwritingRiskAssessOther = underwritingRiskAssessOther;
                var underwritingRiskAssessType = _underwritingRiskAssessType; underwritingRiskAssessType.Clean = value; _underwritingRiskAssessType = underwritingRiskAssessType;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ATRQMBorrower()
        {
            Clean = true;
        }
    }
}