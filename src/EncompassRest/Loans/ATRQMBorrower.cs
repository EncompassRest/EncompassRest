using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ATRQMBorrower
    {
        public Value<int?> ATRQMBorrowerIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeATRQMBorrowerIndex() => !ATRQMBorrowerIndex.Clean;
        public Value<string> AUSRecommendation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUSRecommendation() => !AUSRecommendation.Clean;
        public Value<string> AUSVersion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUSVersion() => !AUSVersion.Clean;
        public Value<decimal?> BorBonusAverageOvertime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusAverageOvertime() => !BorBonusAverageOvertime.Clean;
        public Value<decimal?> BorBonusMostRecentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusMostRecentAmount() => !BorBonusMostRecentAmount.Clean;
        public Value<int?> BorBonusMostRecentMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusMostRecentMonths() => !BorBonusMostRecentMonths.Clean;
        public Value<int?> BorBonusMostRecentYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusMostRecentYear() => !BorBonusMostRecentYear.Clean;
        public Value<decimal?> BorBonusPreviousAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusPreviousAmount1() => !BorBonusPreviousAmount1.Clean;
        public Value<decimal?> BorBonusPreviousAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusPreviousAmount2() => !BorBonusPreviousAmount2.Clean;
        public Value<int?> BorBonusPreviousMonths1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusPreviousMonths1() => !BorBonusPreviousMonths1.Clean;
        public Value<int?> BorBonusPreviousMonths2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusPreviousMonths2() => !BorBonusPreviousMonths2.Clean;
        public Value<int?> BorBonusPreviousYear1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusPreviousYear1() => !BorBonusPreviousYear1.Clean;
        public Value<int?> BorBonusPreviousYear2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusPreviousYear2() => !BorBonusPreviousYear2.Clean;
        public Value<decimal?> BorCommissionAverageOvertime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionAverageOvertime() => !BorCommissionAverageOvertime.Clean;
        public Value<decimal?> BorCommissionMostRecentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionMostRecentAmount() => !BorCommissionMostRecentAmount.Clean;
        public Value<int?> BorCommissionMostRecentMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionMostRecentMonths() => !BorCommissionMostRecentMonths.Clean;
        public Value<int?> BorCommissionMostRecentYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionMostRecentYear() => !BorCommissionMostRecentYear.Clean;
        public Value<decimal?> BorCommissionPreviousAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionPreviousAmount1() => !BorCommissionPreviousAmount1.Clean;
        public Value<decimal?> BorCommissionPreviousAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionPreviousAmount2() => !BorCommissionPreviousAmount2.Clean;
        public Value<int?> BorCommissionPreviousMonths1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionPreviousMonths1() => !BorCommissionPreviousMonths1.Clean;
        public Value<int?> BorCommissionPreviousMonths2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionPreviousMonths2() => !BorCommissionPreviousMonths2.Clean;
        public Value<int?> BorCommissionPreviousYear1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionPreviousYear1() => !BorCommissionPreviousYear1.Clean;
        public Value<int?> BorCommissionPreviousYear2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionPreviousYear2() => !BorCommissionPreviousYear2.Clean;
        public Value<decimal?> BorContingentLiabilitiesLiabilityAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorContingentLiabilitiesLiabilityAmount1() => !BorContingentLiabilitiesLiabilityAmount1.Clean;
        public Value<decimal?> BorContingentLiabilitiesLiabilityAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorContingentLiabilitiesLiabilityAmount2() => !BorContingentLiabilitiesLiabilityAmount2.Clean;
        public Value<decimal?> BorContingentLiabilitiesLiabilityAmount3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorContingentLiabilitiesLiabilityAmount3() => !BorContingentLiabilitiesLiabilityAmount3.Clean;
        public Value<string> BorContingentLiabilitiesLiabilityDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorContingentLiabilitiesLiabilityDescription1() => !BorContingentLiabilitiesLiabilityDescription1.Clean;
        public Value<string> BorContingentLiabilitiesLiabilityDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorContingentLiabilitiesLiabilityDescription2() => !BorContingentLiabilitiesLiabilityDescription2.Clean;
        public Value<string> BorContingentLiabilitiesLiabilityDescription3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorContingentLiabilitiesLiabilityDescription3() => !BorContingentLiabilitiesLiabilityDescription3.Clean;
        public Value<decimal?> BorContingentLiabilitiesTotalLiabilityAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorContingentLiabilitiesTotalLiabilityAmount() => !BorContingentLiabilitiesTotalLiabilityAmount.Clean;
        public Value<decimal?> BorCosignedObligationsCarLoanPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCosignedObligationsCarLoanPayment() => !BorCosignedObligationsCarLoanPayment.Clean;
        public Value<decimal?> BorCosignedObligationsMortgagePayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCosignedObligationsMortgagePayment() => !BorCosignedObligationsMortgagePayment.Clean;
        public Value<decimal?> BorCosignedObligationsOtherPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCosignedObligationsOtherPayment() => !BorCosignedObligationsOtherPayment.Clean;
        public Value<string> BorCosignedObligationsOtherPaymentDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCosignedObligationsOtherPaymentDescription() => !BorCosignedObligationsOtherPaymentDescription.Clean;
        public Value<decimal?> BorCosignedObligationsStudentLoanPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCosignedObligationsStudentLoanPayment() => !BorCosignedObligationsStudentLoanPayment.Clean;
        public Value<decimal?> BorCosignedObligationsTotalCoMortgagorLiabilities { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCosignedObligationsTotalCoMortgagorLiabilities() => !BorCosignedObligationsTotalCoMortgagorLiabilities.Clean;
        public Value<decimal?> BorDividendAverageDividend { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorDividendAverageDividend() => !BorDividendAverageDividend.Clean;
        public Value<decimal?> BorDividendPreviousAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorDividendPreviousAmount1() => !BorDividendPreviousAmount1.Clean;
        public Value<decimal?> BorDividendPreviousAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorDividendPreviousAmount2() => !BorDividendPreviousAmount2.Clean;
        public Value<int?> BorDividendPreviousMonths1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorDividendPreviousMonths1() => !BorDividendPreviousMonths1.Clean;
        public Value<int?> BorDividendPreviousMonths2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorDividendPreviousMonths2() => !BorDividendPreviousMonths2.Clean;
        public Value<int?> BorDividendPreviousYear1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorDividendPreviousYear1() => !BorDividendPreviousYear1.Clean;
        public Value<int?> BorDividendPreviousYear2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorDividendPreviousYear2() => !BorDividendPreviousYear2.Clean;
        public Value<decimal?> BorDividendRequiredForCashAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorDividendRequiredForCashAmount() => !BorDividendRequiredForCashAmount.Clean;
        public Value<decimal?> BorInterestAverageDividend { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorInterestAverageDividend() => !BorInterestAverageDividend.Clean;
        public Value<decimal?> BorInterestPreviousAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorInterestPreviousAmount1() => !BorInterestPreviousAmount1.Clean;
        public Value<decimal?> BorInterestPreviousAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorInterestPreviousAmount2() => !BorInterestPreviousAmount2.Clean;
        public Value<int?> BorInterestPreviousMonths1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorInterestPreviousMonths1() => !BorInterestPreviousMonths1.Clean;
        public Value<int?> BorInterestPreviousMonths2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorInterestPreviousMonths2() => !BorInterestPreviousMonths2.Clean;
        public Value<int?> BorInterestPreviousYear1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorInterestPreviousYear1() => !BorInterestPreviousYear1.Clean;
        public Value<int?> BorInterestPreviousYear2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorInterestPreviousYear2() => !BorInterestPreviousYear2.Clean;
        public Value<decimal?> BorInterestRequiredForCashAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorInterestRequiredForCashAmount() => !BorInterestRequiredForCashAmount.Clean;
        public Value<decimal?> BorMilitaryAllowanceClothingAllowance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryAllowanceClothingAllowance() => !BorMilitaryAllowanceClothingAllowance.Clean;
        public Value<decimal?> BorMilitaryAllowanceOtherAllowance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryAllowanceOtherAllowance() => !BorMilitaryAllowanceOtherAllowance.Clean;
        public Value<string> BorMilitaryAllowanceOtherAllowanceDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryAllowanceOtherAllowanceDescription() => !BorMilitaryAllowanceOtherAllowanceDescription.Clean;
        public Value<decimal?> BorMilitaryAllowanceQuartersAllowance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryAllowanceQuartersAllowance() => !BorMilitaryAllowanceQuartersAllowance.Clean;
        public Value<decimal?> BorMilitaryAllowanceRationsAllowance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryAllowanceRationsAllowance() => !BorMilitaryAllowanceRationsAllowance.Clean;
        public Value<decimal?> BorMilitaryAllowanceTotalAllowance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryAllowanceTotalAllowance() => !BorMilitaryAllowanceTotalAllowance.Clean;
        public Value<decimal?> BorMilitaryAllowanceVariableHousingAllowance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryAllowanceVariableHousingAllowance() => !BorMilitaryAllowanceVariableHousingAllowance.Clean;
        public Value<decimal?> BorMilitaryBasePay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryBasePay() => !BorMilitaryBasePay.Clean;
        public Value<decimal?> BorMilitaryCombatPay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryCombatPay() => !BorMilitaryCombatPay.Clean;
        public Value<decimal?> BorMilitaryFlightPay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryFlightPay() => !BorMilitaryFlightPay.Clean;
        public Value<decimal?> BorMilitaryHazardPay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryHazardPay() => !BorMilitaryHazardPay.Clean;
        public Value<decimal?> BorMilitaryOverseasPay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryOverseasPay() => !BorMilitaryOverseasPay.Clean;
        public Value<decimal?> BorMilitaryPropPay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryPropPay() => !BorMilitaryPropPay.Clean;
        public Value<decimal?> BorMilitaryTotalPay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryTotalPay() => !BorMilitaryTotalPay.Clean;
        public Value<decimal?> BorMonthlyEmplymentIncomeBaseIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMonthlyEmplymentIncomeBaseIncome() => !BorMonthlyEmplymentIncomeBaseIncome.Clean;
        public Value<decimal?> BorMonthlyEmplymentIncomeBonuseIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMonthlyEmplymentIncomeBonuseIncome() => !BorMonthlyEmplymentIncomeBonuseIncome.Clean;
        public Value<decimal?> BorMonthlyEmplymentIncomeCommissionIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMonthlyEmplymentIncomeCommissionIncome() => !BorMonthlyEmplymentIncomeCommissionIncome.Clean;
        public Value<decimal?> BorMonthlyEmplymentIncomeDividendInterestIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMonthlyEmplymentIncomeDividendInterestIncome() => !BorMonthlyEmplymentIncomeDividendInterestIncome.Clean;
        public Value<decimal?> BorMonthlyEmplymentIncomeOtherIncome1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMonthlyEmplymentIncomeOtherIncome1() => !BorMonthlyEmplymentIncomeOtherIncome1.Clean;
        public Value<decimal?> BorMonthlyEmplymentIncomeOtherIncome2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMonthlyEmplymentIncomeOtherIncome2() => !BorMonthlyEmplymentIncomeOtherIncome2.Clean;
        public Value<decimal?> BorMonthlyEmplymentIncomeOvertimeIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMonthlyEmplymentIncomeOvertimeIncome() => !BorMonthlyEmplymentIncomeOvertimeIncome.Clean;
        public Value<decimal?> BorMonthlyEmplymentIncomeTotalEmploymentIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMonthlyEmplymentIncomeTotalEmploymentIncome() => !BorMonthlyEmplymentIncomeTotalEmploymentIncome.Clean;
        public Value<decimal?> BorNonEmploymentIncomeGovtAssitProgramIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonEmploymentIncomeGovtAssitProgramIncome() => !BorNonEmploymentIncomeGovtAssitProgramIncome.Clean;
        public Value<decimal?> BorNonEmploymentIncomeHomeownSubsidyIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonEmploymentIncomeHomeownSubsidyIncome() => !BorNonEmploymentIncomeHomeownSubsidyIncome.Clean;
        public Value<bool?> BorNonEmploymentIncomeIsOffsetHomeownSubsidyIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonEmploymentIncomeIsOffsetHomeownSubsidyIncome() => !BorNonEmploymentIncomeIsOffsetHomeownSubsidyIncome.Clean;
        public Value<bool?> BorNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome() => !BorNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome.Clean;
        public Value<decimal?> BorNonEmploymentIncomeMilitaryIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonEmploymentIncomeMilitaryIncome() => !BorNonEmploymentIncomeMilitaryIncome.Clean;
        public Value<decimal?> BorNonEmploymentIncomeMtgCreditCertificateIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonEmploymentIncomeMtgCreditCertificateIncome() => !BorNonEmploymentIncomeMtgCreditCertificateIncome.Clean;
        public Value<decimal?> BorNonEmploymentIncomeTotalNonEmploymentIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonEmploymentIncomeTotalNonEmploymentIncome() => !BorNonEmploymentIncomeTotalNonEmploymentIncome.Clean;
        public Value<decimal?> BorNonEmploymentIncomeVABenefitIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonEmploymentIncomeVABenefitIncome() => !BorNonEmploymentIncomeVABenefitIncome.Clean;
        public Value<decimal?> BorNonTaxableIncomeChildSupportIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomeChildSupportIncome() => !BorNonTaxableIncomeChildSupportIncome.Clean;
        public Value<decimal?> BorNonTaxableIncomeDisabilityIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomeDisabilityIncome() => !BorNonTaxableIncomeDisabilityIncome.Clean;
        public Value<decimal?> BorNonTaxableIncomeFedGovtEmplRetirementIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomeFedGovtEmplRetirementIncome() => !BorNonTaxableIncomeFedGovtEmplRetirementIncome.Clean;
        public Value<decimal?> BorNonTaxableIncomeMilitaryAllowances { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomeMilitaryAllowances() => !BorNonTaxableIncomeMilitaryAllowances.Clean;
        public Value<decimal?> BorNonTaxableIncomeOtherIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomeOtherIncome() => !BorNonTaxableIncomeOtherIncome.Clean;
        public Value<decimal?> BorNonTaxableIncomePublicAssistPayments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomePublicAssistPayments() => !BorNonTaxableIncomePublicAssistPayments.Clean;
        public Value<decimal?> BorNonTaxableIncomeRailroadRetirementBenefits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomeRailroadRetirementBenefits() => !BorNonTaxableIncomeRailroadRetirementBenefits.Clean;
        public Value<decimal?> BorNonTaxableIncomeSocialSecurityIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomeSocialSecurityIncome() => !BorNonTaxableIncomeSocialSecurityIncome.Clean;
        public Value<decimal?> BorNonTaxableIncomeStateGovtEmplRetirementIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomeStateGovtEmplRetirementIncome() => !BorNonTaxableIncomeStateGovtEmplRetirementIncome.Clean;
        public Value<decimal?> BorNonTaxableIncomeTotalNonTaxableIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomeTotalNonTaxableIncome() => !BorNonTaxableIncomeTotalNonTaxableIncome.Clean;
        public Value<decimal?> BorOtherNotesReceivableIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOtherNotesReceivableIncome() => !BorOtherNotesReceivableIncome.Clean;
        public Value<decimal?> BorOtherOtherIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOtherOtherIncome() => !BorOtherOtherIncome.Clean;
        public Value<decimal?> BorOtherParttimeIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOtherParttimeIncome() => !BorOtherParttimeIncome.Clean;
        public Value<decimal?> BorOtherRetirementIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOtherRetirementIncome() => !BorOtherRetirementIncome.Clean;
        public Value<decimal?> BorOtherSeasonalIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOtherSeasonalIncome() => !BorOtherSeasonalIncome.Clean;
        public Value<decimal?> BorOtherSocialSecurityIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOtherSocialSecurityIncome() => !BorOtherSocialSecurityIncome.Clean;
        public Value<decimal?> BorOtherTipIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOtherTipIncome() => !BorOtherTipIncome.Clean;
        public Value<decimal?> BorOtherTrustIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOtherTrustIncome() => !BorOtherTrustIncome.Clean;
        public Value<decimal?> BorOtherUnemploymentIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOtherUnemploymentIncome() => !BorOtherUnemploymentIncome.Clean;
        public Value<decimal?> BorOvertimeAverageOvertime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimeAverageOvertime() => !BorOvertimeAverageOvertime.Clean;
        public Value<decimal?> BorOvertimeMostRecentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimeMostRecentAmount() => !BorOvertimeMostRecentAmount.Clean;
        public Value<int?> BorOvertimeMostRecentMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimeMostRecentMonths() => !BorOvertimeMostRecentMonths.Clean;
        public Value<int?> BorOvertimeMostRecentYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimeMostRecentYear() => !BorOvertimeMostRecentYear.Clean;
        public Value<decimal?> BorOvertimePreviousAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimePreviousAmount1() => !BorOvertimePreviousAmount1.Clean;
        public Value<decimal?> BorOvertimePreviousAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimePreviousAmount2() => !BorOvertimePreviousAmount2.Clean;
        public Value<int?> BorOvertimePreviousMonths1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimePreviousMonths1() => !BorOvertimePreviousMonths1.Clean;
        public Value<int?> BorOvertimePreviousMonths2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimePreviousMonths2() => !BorOvertimePreviousMonths2.Clean;
        public Value<int?> BorOvertimePreviousYear1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimePreviousYear1() => !BorOvertimePreviousYear1.Clean;
        public Value<int?> BorOvertimePreviousYear2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimePreviousYear2() => !BorOvertimePreviousYear2.Clean;
        public Value<decimal?> BorProjectedIncomeProjectedBonuses { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorProjectedIncomeProjectedBonuses() => !BorProjectedIncomeProjectedBonuses.Clean;
        public Value<decimal?> BorProjectedIncomeProjectedCostLivingAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorProjectedIncomeProjectedCostLivingAdjustment() => !BorProjectedIncomeProjectedCostLivingAdjustment.Clean;
        public Value<decimal?> BorProjectedIncomeProjectedNewJobIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorProjectedIncomeProjectedNewJobIncome() => !BorProjectedIncomeProjectedNewJobIncome.Clean;
        public Value<decimal?> BorProjectedIncomeProjectedPerformanceRaises { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorProjectedIncomeProjectedPerformanceRaises() => !BorProjectedIncomeProjectedPerformanceRaises.Clean;
        public Value<decimal?> BorProjectedIncomeTotalProjectedIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorProjectedIncomeTotalProjectedIncome() => !BorProjectedIncomeTotalProjectedIncome.Clean;
        public Value<decimal?> CobBonusAverageOvertime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusAverageOvertime() => !CobBonusAverageOvertime.Clean;
        public Value<decimal?> CobBonusMostRecentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusMostRecentAmount() => !CobBonusMostRecentAmount.Clean;
        public Value<int?> CobBonusMostRecentMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusMostRecentMonths() => !CobBonusMostRecentMonths.Clean;
        public Value<int?> CobBonusMostRecentYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusMostRecentYear() => !CobBonusMostRecentYear.Clean;
        public Value<decimal?> CobBonusPreviousAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusPreviousAmount1() => !CobBonusPreviousAmount1.Clean;
        public Value<decimal?> CobBonusPreviousAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusPreviousAmount2() => !CobBonusPreviousAmount2.Clean;
        public Value<int?> CobBonusPreviousMonths1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusPreviousMonths1() => !CobBonusPreviousMonths1.Clean;
        public Value<int?> CobBonusPreviousMonths2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusPreviousMonths2() => !CobBonusPreviousMonths2.Clean;
        public Value<int?> CobBonusPreviousYear1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusPreviousYear1() => !CobBonusPreviousYear1.Clean;
        public Value<int?> CobBonusPreviousYear2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusPreviousYear2() => !CobBonusPreviousYear2.Clean;
        public Value<decimal?> CobCommissionAverageOvertime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionAverageOvertime() => !CobCommissionAverageOvertime.Clean;
        public Value<decimal?> CobCommissionMostRecentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionMostRecentAmount() => !CobCommissionMostRecentAmount.Clean;
        public Value<int?> CobCommissionMostRecentMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionMostRecentMonths() => !CobCommissionMostRecentMonths.Clean;
        public Value<int?> CobCommissionMostRecentYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionMostRecentYear() => !CobCommissionMostRecentYear.Clean;
        public Value<decimal?> CobCommissionPreviousAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionPreviousAmount1() => !CobCommissionPreviousAmount1.Clean;
        public Value<decimal?> CobCommissionPreviousAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionPreviousAmount2() => !CobCommissionPreviousAmount2.Clean;
        public Value<int?> CobCommissionPreviousMonths1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionPreviousMonths1() => !CobCommissionPreviousMonths1.Clean;
        public Value<int?> CobCommissionPreviousMonths2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionPreviousMonths2() => !CobCommissionPreviousMonths2.Clean;
        public Value<int?> CobCommissionPreviousYear1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionPreviousYear1() => !CobCommissionPreviousYear1.Clean;
        public Value<int?> CobCommissionPreviousYear2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionPreviousYear2() => !CobCommissionPreviousYear2.Clean;
        public Value<decimal?> CobDividendAverageDividend { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobDividendAverageDividend() => !CobDividendAverageDividend.Clean;
        public Value<decimal?> CobDividendPreviousAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobDividendPreviousAmount1() => !CobDividendPreviousAmount1.Clean;
        public Value<decimal?> CobDividendPreviousAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobDividendPreviousAmount2() => !CobDividendPreviousAmount2.Clean;
        public Value<int?> CobDividendPreviousMonths1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobDividendPreviousMonths1() => !CobDividendPreviousMonths1.Clean;
        public Value<int?> CobDividendPreviousMonths2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobDividendPreviousMonths2() => !CobDividendPreviousMonths2.Clean;
        public Value<int?> CobDividendPreviousYear1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobDividendPreviousYear1() => !CobDividendPreviousYear1.Clean;
        public Value<int?> CobDividendPreviousYear2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobDividendPreviousYear2() => !CobDividendPreviousYear2.Clean;
        public Value<decimal?> CobDividendRequiredForCashAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobDividendRequiredForCashAmount() => !CobDividendRequiredForCashAmount.Clean;
        public Value<decimal?> CobInterestAverageDividend { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobInterestAverageDividend() => !CobInterestAverageDividend.Clean;
        public Value<decimal?> CobInterestPreviousAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobInterestPreviousAmount1() => !CobInterestPreviousAmount1.Clean;
        public Value<decimal?> CobInterestPreviousAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobInterestPreviousAmount2() => !CobInterestPreviousAmount2.Clean;
        public Value<int?> CobInterestPreviousMonths1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobInterestPreviousMonths1() => !CobInterestPreviousMonths1.Clean;
        public Value<int?> CobInterestPreviousMonths2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobInterestPreviousMonths2() => !CobInterestPreviousMonths2.Clean;
        public Value<int?> CobInterestPreviousYear1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobInterestPreviousYear1() => !CobInterestPreviousYear1.Clean;
        public Value<int?> CobInterestPreviousYear2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobInterestPreviousYear2() => !CobInterestPreviousYear2.Clean;
        public Value<decimal?> CobInterestRequiredForCashAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobInterestRequiredForCashAmount() => !CobInterestRequiredForCashAmount.Clean;
        public Value<decimal?> CobMilitaryAllowanceClothingAllowance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryAllowanceClothingAllowance() => !CobMilitaryAllowanceClothingAllowance.Clean;
        public Value<decimal?> CobMilitaryAllowanceOtherAllowance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryAllowanceOtherAllowance() => !CobMilitaryAllowanceOtherAllowance.Clean;
        public Value<decimal?> CobMilitaryAllowanceQuartersAllowance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryAllowanceQuartersAllowance() => !CobMilitaryAllowanceQuartersAllowance.Clean;
        public Value<decimal?> CobMilitaryAllowanceRationsAllowance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryAllowanceRationsAllowance() => !CobMilitaryAllowanceRationsAllowance.Clean;
        public Value<decimal?> CobMilitaryAllowanceTotalAllowance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryAllowanceTotalAllowance() => !CobMilitaryAllowanceTotalAllowance.Clean;
        public Value<decimal?> CobMilitaryAllowanceVariableHousingAllowance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryAllowanceVariableHousingAllowance() => !CobMilitaryAllowanceVariableHousingAllowance.Clean;
        public Value<decimal?> CobMilitaryBasePay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryBasePay() => !CobMilitaryBasePay.Clean;
        public Value<decimal?> CobMilitaryCombatPay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryCombatPay() => !CobMilitaryCombatPay.Clean;
        public Value<decimal?> CobMilitaryFlightPay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryFlightPay() => !CobMilitaryFlightPay.Clean;
        public Value<decimal?> CobMilitaryHazardPay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryHazardPay() => !CobMilitaryHazardPay.Clean;
        public Value<decimal?> CobMilitaryOverseasPay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryOverseasPay() => !CobMilitaryOverseasPay.Clean;
        public Value<decimal?> CobMilitaryPropPay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryPropPay() => !CobMilitaryPropPay.Clean;
        public Value<decimal?> CobMilitaryTotalPay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryTotalPay() => !CobMilitaryTotalPay.Clean;
        public Value<decimal?> CobMonthlyEmplymentIncomeBaseIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMonthlyEmplymentIncomeBaseIncome() => !CobMonthlyEmplymentIncomeBaseIncome.Clean;
        public Value<decimal?> CobMonthlyEmplymentIncomeBonuseIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMonthlyEmplymentIncomeBonuseIncome() => !CobMonthlyEmplymentIncomeBonuseIncome.Clean;
        public Value<decimal?> CobMonthlyEmplymentIncomeCommissionIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMonthlyEmplymentIncomeCommissionIncome() => !CobMonthlyEmplymentIncomeCommissionIncome.Clean;
        public Value<decimal?> CobMonthlyEmplymentIncomeDividendInterestIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMonthlyEmplymentIncomeDividendInterestIncome() => !CobMonthlyEmplymentIncomeDividendInterestIncome.Clean;
        public Value<decimal?> CobMonthlyEmplymentIncomeOtherIncome1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMonthlyEmplymentIncomeOtherIncome1() => !CobMonthlyEmplymentIncomeOtherIncome1.Clean;
        public Value<decimal?> CobMonthlyEmplymentIncomeOtherIncome2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMonthlyEmplymentIncomeOtherIncome2() => !CobMonthlyEmplymentIncomeOtherIncome2.Clean;
        public Value<decimal?> CobMonthlyEmplymentIncomeOvertimeIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMonthlyEmplymentIncomeOvertimeIncome() => !CobMonthlyEmplymentIncomeOvertimeIncome.Clean;
        public Value<decimal?> CobMonthlyEmplymentIncomeTotalEmploymentIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMonthlyEmplymentIncomeTotalEmploymentIncome() => !CobMonthlyEmplymentIncomeTotalEmploymentIncome.Clean;
        public Value<decimal?> CobNonEmploymentIncomeGovtAssitProgramIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonEmploymentIncomeGovtAssitProgramIncome() => !CobNonEmploymentIncomeGovtAssitProgramIncome.Clean;
        public Value<decimal?> CobNonEmploymentIncomeHomeownSubsidyIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonEmploymentIncomeHomeownSubsidyIncome() => !CobNonEmploymentIncomeHomeownSubsidyIncome.Clean;
        public Value<decimal?> CobNonEmploymentIncomeMilitaryIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonEmploymentIncomeMilitaryIncome() => !CobNonEmploymentIncomeMilitaryIncome.Clean;
        public Value<decimal?> CobNonEmploymentIncomeMtgCreditCertificateIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonEmploymentIncomeMtgCreditCertificateIncome() => !CobNonEmploymentIncomeMtgCreditCertificateIncome.Clean;
        public Value<decimal?> CobNonEmploymentIncomeTotalNonEmploymentIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonEmploymentIncomeTotalNonEmploymentIncome() => !CobNonEmploymentIncomeTotalNonEmploymentIncome.Clean;
        public Value<decimal?> CobNonEmploymentIncomeVABenefitIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonEmploymentIncomeVABenefitIncome() => !CobNonEmploymentIncomeVABenefitIncome.Clean;
        public Value<decimal?> CobNonTaxableIncomeChildSupportIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomeChildSupportIncome() => !CobNonTaxableIncomeChildSupportIncome.Clean;
        public Value<decimal?> CobNonTaxableIncomeDisabilityIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomeDisabilityIncome() => !CobNonTaxableIncomeDisabilityIncome.Clean;
        public Value<decimal?> CobNonTaxableIncomeFedGovtEmplRetirementIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomeFedGovtEmplRetirementIncome() => !CobNonTaxableIncomeFedGovtEmplRetirementIncome.Clean;
        public Value<decimal?> CobNonTaxableIncomeMilitaryAllowances { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomeMilitaryAllowances() => !CobNonTaxableIncomeMilitaryAllowances.Clean;
        public Value<decimal?> CobNonTaxableIncomeOtherIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomeOtherIncome() => !CobNonTaxableIncomeOtherIncome.Clean;
        public Value<decimal?> CobNonTaxableIncomePublicAssistPayments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomePublicAssistPayments() => !CobNonTaxableIncomePublicAssistPayments.Clean;
        public Value<decimal?> CobNonTaxableIncomeRailroadRetirementBenefits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomeRailroadRetirementBenefits() => !CobNonTaxableIncomeRailroadRetirementBenefits.Clean;
        public Value<decimal?> CobNonTaxableIncomeSocialSecurityIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomeSocialSecurityIncome() => !CobNonTaxableIncomeSocialSecurityIncome.Clean;
        public Value<decimal?> CobNonTaxableIncomeStateGovtEmplRetirementIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomeStateGovtEmplRetirementIncome() => !CobNonTaxableIncomeStateGovtEmplRetirementIncome.Clean;
        public Value<decimal?> CobNonTaxableIncomeTotalNonTaxableIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomeTotalNonTaxableIncome() => !CobNonTaxableIncomeTotalNonTaxableIncome.Clean;
        public Value<decimal?> CobOtherNotesReceivableIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOtherNotesReceivableIncome() => !CobOtherNotesReceivableIncome.Clean;
        public Value<decimal?> CobOtherOtherIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOtherOtherIncome() => !CobOtherOtherIncome.Clean;
        public Value<decimal?> CobOtherParttimeIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOtherParttimeIncome() => !CobOtherParttimeIncome.Clean;
        public Value<decimal?> CobOtherRetirementIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOtherRetirementIncome() => !CobOtherRetirementIncome.Clean;
        public Value<decimal?> CobOtherSeasonalIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOtherSeasonalIncome() => !CobOtherSeasonalIncome.Clean;
        public Value<decimal?> CobOtherSocialSecurityIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOtherSocialSecurityIncome() => !CobOtherSocialSecurityIncome.Clean;
        public Value<decimal?> CobOtherTipIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOtherTipIncome() => !CobOtherTipIncome.Clean;
        public Value<decimal?> CobOtherTrustIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOtherTrustIncome() => !CobOtherTrustIncome.Clean;
        public Value<decimal?> CobOtherUnemploymentIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOtherUnemploymentIncome() => !CobOtherUnemploymentIncome.Clean;
        public Value<decimal?> CobOvertimeAverageOvertime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimeAverageOvertime() => !CobOvertimeAverageOvertime.Clean;
        public Value<decimal?> CobOvertimeMostRecentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimeMostRecentAmount() => !CobOvertimeMostRecentAmount.Clean;
        public Value<int?> CobOvertimeMostRecentMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimeMostRecentMonths() => !CobOvertimeMostRecentMonths.Clean;
        public Value<int?> CobOvertimeMostRecentYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimeMostRecentYear() => !CobOvertimeMostRecentYear.Clean;
        public Value<decimal?> CobOvertimePreviousAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimePreviousAmount1() => !CobOvertimePreviousAmount1.Clean;
        public Value<decimal?> CobOvertimePreviousAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimePreviousAmount2() => !CobOvertimePreviousAmount2.Clean;
        public Value<int?> CobOvertimePreviousMonths1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimePreviousMonths1() => !CobOvertimePreviousMonths1.Clean;
        public Value<int?> CobOvertimePreviousMonths2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimePreviousMonths2() => !CobOvertimePreviousMonths2.Clean;
        public Value<int?> CobOvertimePreviousYear1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimePreviousYear1() => !CobOvertimePreviousYear1.Clean;
        public Value<int?> CobOvertimePreviousYear2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimePreviousYear2() => !CobOvertimePreviousYear2.Clean;
        public Value<decimal?> CobProjectedIncomeProjectedBonuses { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobProjectedIncomeProjectedBonuses() => !CobProjectedIncomeProjectedBonuses.Clean;
        public Value<decimal?> CobProjectedIncomeProjectedCostLivingAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobProjectedIncomeProjectedCostLivingAdjustment() => !CobProjectedIncomeProjectedCostLivingAdjustment.Clean;
        public Value<decimal?> CobProjectedIncomeProjectedNewJobIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobProjectedIncomeProjectedNewJobIncome() => !CobProjectedIncomeProjectedNewJobIncome.Clean;
        public Value<decimal?> CobProjectedIncomeProjectedPerformanceRaises { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobProjectedIncomeProjectedPerformanceRaises() => !CobProjectedIncomeProjectedPerformanceRaises.Clean;
        public Value<decimal?> CobProjectedIncomeTotalProjectedIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobProjectedIncomeTotalProjectedIncome() => !CobProjectedIncomeTotalProjectedIncome.Clean;
        public Value<string> DUCaseIDorLPAUSKey { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDUCaseIDorLPAUSKey() => !DUCaseIDorLPAUSKey.Clean;
        public Value<DateTime?> FirstSubmissionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstSubmissionDate() => !FirstSubmissionDate.Clean;
        public Value<string> FirstSubmissionTime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstSubmissionTime() => !FirstSubmissionTime.Clean;
        public Value<string> FreddieDocClass { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDocClass() => !FreddieDocClass.Clean;
        public Value<decimal?> HousingRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHousingRatio() => !HousingRatio.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IsEmpty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEmpty() => !IsEmpty.Clean;
        public Value<DateTime?> SubmissionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmissionDate() => !SubmissionDate.Clean;
        public Value<string> SubmissionNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmissionNumber() => !SubmissionNumber.Clean;
        public Value<string> SubmissionTime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmissionTime() => !SubmissionTime.Clean;
        public Value<string> SubmittedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittedBy() => !SubmittedBy.Clean;
        public Value<decimal?> TotalExpenseRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalExpenseRatio() => !TotalExpenseRatio.Clean;
        public Value<decimal?> TotalHousingPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalHousingPayment() => !TotalHousingPayment.Clean;
        public Value<decimal?> TotalMonthlyAssets { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMonthlyAssets() => !TotalMonthlyAssets.Clean;
        public Value<decimal?> TotalMonthlyDebt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMonthlyDebt() => !TotalMonthlyDebt.Clean;
        public Value<decimal?> TotalMonthlyIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMonthlyIncome() => !TotalMonthlyIncome.Clean;
        public Value<string> UnderwritingRiskAssessOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingRiskAssessOther() => !UnderwritingRiskAssessOther.Clean;
        public Value<string> UnderwritingRiskAssessType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingRiskAssessType() => !UnderwritingRiskAssessType.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = ATRQMBorrowerIndex.Clean
                    && AUSRecommendation.Clean
                    && AUSVersion.Clean
                    && BorBonusAverageOvertime.Clean
                    && BorBonusMostRecentAmount.Clean
                    && BorBonusMostRecentMonths.Clean
                    && BorBonusMostRecentYear.Clean
                    && BorBonusPreviousAmount1.Clean
                    && BorBonusPreviousAmount2.Clean
                    && BorBonusPreviousMonths1.Clean
                    && BorBonusPreviousMonths2.Clean
                    && BorBonusPreviousYear1.Clean
                    && BorBonusPreviousYear2.Clean
                    && BorCommissionAverageOvertime.Clean
                    && BorCommissionMostRecentAmount.Clean
                    && BorCommissionMostRecentMonths.Clean
                    && BorCommissionMostRecentYear.Clean
                    && BorCommissionPreviousAmount1.Clean
                    && BorCommissionPreviousAmount2.Clean
                    && BorCommissionPreviousMonths1.Clean
                    && BorCommissionPreviousMonths2.Clean
                    && BorCommissionPreviousYear1.Clean
                    && BorCommissionPreviousYear2.Clean
                    && BorContingentLiabilitiesLiabilityAmount1.Clean
                    && BorContingentLiabilitiesLiabilityAmount2.Clean
                    && BorContingentLiabilitiesLiabilityAmount3.Clean
                    && BorContingentLiabilitiesLiabilityDescription1.Clean
                    && BorContingentLiabilitiesLiabilityDescription2.Clean
                    && BorContingentLiabilitiesLiabilityDescription3.Clean
                    && BorContingentLiabilitiesTotalLiabilityAmount.Clean
                    && BorCosignedObligationsCarLoanPayment.Clean
                    && BorCosignedObligationsMortgagePayment.Clean
                    && BorCosignedObligationsOtherPayment.Clean
                    && BorCosignedObligationsOtherPaymentDescription.Clean
                    && BorCosignedObligationsStudentLoanPayment.Clean
                    && BorCosignedObligationsTotalCoMortgagorLiabilities.Clean
                    && BorDividendAverageDividend.Clean
                    && BorDividendPreviousAmount1.Clean
                    && BorDividendPreviousAmount2.Clean
                    && BorDividendPreviousMonths1.Clean
                    && BorDividendPreviousMonths2.Clean
                    && BorDividendPreviousYear1.Clean
                    && BorDividendPreviousYear2.Clean
                    && BorDividendRequiredForCashAmount.Clean
                    && BorInterestAverageDividend.Clean
                    && BorInterestPreviousAmount1.Clean
                    && BorInterestPreviousAmount2.Clean
                    && BorInterestPreviousMonths1.Clean
                    && BorInterestPreviousMonths2.Clean
                    && BorInterestPreviousYear1.Clean
                    && BorInterestPreviousYear2.Clean
                    && BorInterestRequiredForCashAmount.Clean
                    && BorMilitaryAllowanceClothingAllowance.Clean
                    && BorMilitaryAllowanceOtherAllowance.Clean
                    && BorMilitaryAllowanceOtherAllowanceDescription.Clean
                    && BorMilitaryAllowanceQuartersAllowance.Clean
                    && BorMilitaryAllowanceRationsAllowance.Clean
                    && BorMilitaryAllowanceTotalAllowance.Clean
                    && BorMilitaryAllowanceVariableHousingAllowance.Clean
                    && BorMilitaryBasePay.Clean
                    && BorMilitaryCombatPay.Clean
                    && BorMilitaryFlightPay.Clean
                    && BorMilitaryHazardPay.Clean
                    && BorMilitaryOverseasPay.Clean
                    && BorMilitaryPropPay.Clean
                    && BorMilitaryTotalPay.Clean
                    && BorMonthlyEmplymentIncomeBaseIncome.Clean
                    && BorMonthlyEmplymentIncomeBonuseIncome.Clean
                    && BorMonthlyEmplymentIncomeCommissionIncome.Clean
                    && BorMonthlyEmplymentIncomeDividendInterestIncome.Clean
                    && BorMonthlyEmplymentIncomeOtherIncome1.Clean
                    && BorMonthlyEmplymentIncomeOtherIncome2.Clean
                    && BorMonthlyEmplymentIncomeOvertimeIncome.Clean
                    && BorMonthlyEmplymentIncomeTotalEmploymentIncome.Clean
                    && BorNonEmploymentIncomeGovtAssitProgramIncome.Clean
                    && BorNonEmploymentIncomeHomeownSubsidyIncome.Clean
                    && BorNonEmploymentIncomeIsOffsetHomeownSubsidyIncome.Clean
                    && BorNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome.Clean
                    && BorNonEmploymentIncomeMilitaryIncome.Clean
                    && BorNonEmploymentIncomeMtgCreditCertificateIncome.Clean
                    && BorNonEmploymentIncomeTotalNonEmploymentIncome.Clean
                    && BorNonEmploymentIncomeVABenefitIncome.Clean
                    && BorNonTaxableIncomeChildSupportIncome.Clean
                    && BorNonTaxableIncomeDisabilityIncome.Clean
                    && BorNonTaxableIncomeFedGovtEmplRetirementIncome.Clean
                    && BorNonTaxableIncomeMilitaryAllowances.Clean
                    && BorNonTaxableIncomeOtherIncome.Clean
                    && BorNonTaxableIncomePublicAssistPayments.Clean
                    && BorNonTaxableIncomeRailroadRetirementBenefits.Clean
                    && BorNonTaxableIncomeSocialSecurityIncome.Clean
                    && BorNonTaxableIncomeStateGovtEmplRetirementIncome.Clean
                    && BorNonTaxableIncomeTotalNonTaxableIncome.Clean
                    && BorOtherNotesReceivableIncome.Clean
                    && BorOtherOtherIncome.Clean
                    && BorOtherParttimeIncome.Clean
                    && BorOtherRetirementIncome.Clean
                    && BorOtherSeasonalIncome.Clean
                    && BorOtherSocialSecurityIncome.Clean
                    && BorOtherTipIncome.Clean
                    && BorOtherTrustIncome.Clean
                    && BorOtherUnemploymentIncome.Clean
                    && BorOvertimeAverageOvertime.Clean
                    && BorOvertimeMostRecentAmount.Clean
                    && BorOvertimeMostRecentMonths.Clean
                    && BorOvertimeMostRecentYear.Clean
                    && BorOvertimePreviousAmount1.Clean
                    && BorOvertimePreviousAmount2.Clean
                    && BorOvertimePreviousMonths1.Clean
                    && BorOvertimePreviousMonths2.Clean
                    && BorOvertimePreviousYear1.Clean
                    && BorOvertimePreviousYear2.Clean
                    && BorProjectedIncomeProjectedBonuses.Clean
                    && BorProjectedIncomeProjectedCostLivingAdjustment.Clean
                    && BorProjectedIncomeProjectedNewJobIncome.Clean
                    && BorProjectedIncomeProjectedPerformanceRaises.Clean
                    && BorProjectedIncomeTotalProjectedIncome.Clean
                    && CobBonusAverageOvertime.Clean
                    && CobBonusMostRecentAmount.Clean
                    && CobBonusMostRecentMonths.Clean
                    && CobBonusMostRecentYear.Clean
                    && CobBonusPreviousAmount1.Clean
                    && CobBonusPreviousAmount2.Clean
                    && CobBonusPreviousMonths1.Clean
                    && CobBonusPreviousMonths2.Clean
                    && CobBonusPreviousYear1.Clean
                    && CobBonusPreviousYear2.Clean
                    && CobCommissionAverageOvertime.Clean
                    && CobCommissionMostRecentAmount.Clean
                    && CobCommissionMostRecentMonths.Clean
                    && CobCommissionMostRecentYear.Clean
                    && CobCommissionPreviousAmount1.Clean
                    && CobCommissionPreviousAmount2.Clean
                    && CobCommissionPreviousMonths1.Clean
                    && CobCommissionPreviousMonths2.Clean
                    && CobCommissionPreviousYear1.Clean
                    && CobCommissionPreviousYear2.Clean
                    && CobDividendAverageDividend.Clean
                    && CobDividendPreviousAmount1.Clean
                    && CobDividendPreviousAmount2.Clean
                    && CobDividendPreviousMonths1.Clean
                    && CobDividendPreviousMonths2.Clean
                    && CobDividendPreviousYear1.Clean
                    && CobDividendPreviousYear2.Clean
                    && CobDividendRequiredForCashAmount.Clean
                    && CobInterestAverageDividend.Clean
                    && CobInterestPreviousAmount1.Clean
                    && CobInterestPreviousAmount2.Clean
                    && CobInterestPreviousMonths1.Clean
                    && CobInterestPreviousMonths2.Clean
                    && CobInterestPreviousYear1.Clean
                    && CobInterestPreviousYear2.Clean
                    && CobInterestRequiredForCashAmount.Clean
                    && CobMilitaryAllowanceClothingAllowance.Clean
                    && CobMilitaryAllowanceOtherAllowance.Clean
                    && CobMilitaryAllowanceQuartersAllowance.Clean
                    && CobMilitaryAllowanceRationsAllowance.Clean
                    && CobMilitaryAllowanceTotalAllowance.Clean
                    && CobMilitaryAllowanceVariableHousingAllowance.Clean
                    && CobMilitaryBasePay.Clean
                    && CobMilitaryCombatPay.Clean
                    && CobMilitaryFlightPay.Clean
                    && CobMilitaryHazardPay.Clean
                    && CobMilitaryOverseasPay.Clean
                    && CobMilitaryPropPay.Clean
                    && CobMilitaryTotalPay.Clean
                    && CobMonthlyEmplymentIncomeBaseIncome.Clean
                    && CobMonthlyEmplymentIncomeBonuseIncome.Clean
                    && CobMonthlyEmplymentIncomeCommissionIncome.Clean
                    && CobMonthlyEmplymentIncomeDividendInterestIncome.Clean
                    && CobMonthlyEmplymentIncomeOtherIncome1.Clean
                    && CobMonthlyEmplymentIncomeOtherIncome2.Clean
                    && CobMonthlyEmplymentIncomeOvertimeIncome.Clean
                    && CobMonthlyEmplymentIncomeTotalEmploymentIncome.Clean
                    && CobNonEmploymentIncomeGovtAssitProgramIncome.Clean
                    && CobNonEmploymentIncomeHomeownSubsidyIncome.Clean
                    && CobNonEmploymentIncomeMilitaryIncome.Clean
                    && CobNonEmploymentIncomeMtgCreditCertificateIncome.Clean
                    && CobNonEmploymentIncomeTotalNonEmploymentIncome.Clean
                    && CobNonEmploymentIncomeVABenefitIncome.Clean
                    && CobNonTaxableIncomeChildSupportIncome.Clean
                    && CobNonTaxableIncomeDisabilityIncome.Clean
                    && CobNonTaxableIncomeFedGovtEmplRetirementIncome.Clean
                    && CobNonTaxableIncomeMilitaryAllowances.Clean
                    && CobNonTaxableIncomeOtherIncome.Clean
                    && CobNonTaxableIncomePublicAssistPayments.Clean
                    && CobNonTaxableIncomeRailroadRetirementBenefits.Clean
                    && CobNonTaxableIncomeSocialSecurityIncome.Clean
                    && CobNonTaxableIncomeStateGovtEmplRetirementIncome.Clean
                    && CobNonTaxableIncomeTotalNonTaxableIncome.Clean
                    && CobOtherNotesReceivableIncome.Clean
                    && CobOtherOtherIncome.Clean
                    && CobOtherParttimeIncome.Clean
                    && CobOtherRetirementIncome.Clean
                    && CobOtherSeasonalIncome.Clean
                    && CobOtherSocialSecurityIncome.Clean
                    && CobOtherTipIncome.Clean
                    && CobOtherTrustIncome.Clean
                    && CobOtherUnemploymentIncome.Clean
                    && CobOvertimeAverageOvertime.Clean
                    && CobOvertimeMostRecentAmount.Clean
                    && CobOvertimeMostRecentMonths.Clean
                    && CobOvertimeMostRecentYear.Clean
                    && CobOvertimePreviousAmount1.Clean
                    && CobOvertimePreviousAmount2.Clean
                    && CobOvertimePreviousMonths1.Clean
                    && CobOvertimePreviousMonths2.Clean
                    && CobOvertimePreviousYear1.Clean
                    && CobOvertimePreviousYear2.Clean
                    && CobProjectedIncomeProjectedBonuses.Clean
                    && CobProjectedIncomeProjectedCostLivingAdjustment.Clean
                    && CobProjectedIncomeProjectedNewJobIncome.Clean
                    && CobProjectedIncomeProjectedPerformanceRaises.Clean
                    && CobProjectedIncomeTotalProjectedIncome.Clean
                    && DUCaseIDorLPAUSKey.Clean
                    && FirstSubmissionDate.Clean
                    && FirstSubmissionTime.Clean
                    && FreddieDocClass.Clean
                    && HousingRatio.Clean
                    && Id.Clean
                    && IsEmpty.Clean
                    && SubmissionDate.Clean
                    && SubmissionNumber.Clean
                    && SubmissionTime.Clean
                    && SubmittedBy.Clean
                    && TotalExpenseRatio.Clean
                    && TotalHousingPayment.Clean
                    && TotalMonthlyAssets.Clean
                    && TotalMonthlyDebt.Clean
                    && TotalMonthlyIncome.Clean
                    && UnderwritingRiskAssessOther.Clean
                    && UnderwritingRiskAssessType.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = ATRQMBorrowerIndex; v0.Clean = value; ATRQMBorrowerIndex = v0;
                var v1 = AUSRecommendation; v1.Clean = value; AUSRecommendation = v1;
                var v2 = AUSVersion; v2.Clean = value; AUSVersion = v2;
                var v3 = BorBonusAverageOvertime; v3.Clean = value; BorBonusAverageOvertime = v3;
                var v4 = BorBonusMostRecentAmount; v4.Clean = value; BorBonusMostRecentAmount = v4;
                var v5 = BorBonusMostRecentMonths; v5.Clean = value; BorBonusMostRecentMonths = v5;
                var v6 = BorBonusMostRecentYear; v6.Clean = value; BorBonusMostRecentYear = v6;
                var v7 = BorBonusPreviousAmount1; v7.Clean = value; BorBonusPreviousAmount1 = v7;
                var v8 = BorBonusPreviousAmount2; v8.Clean = value; BorBonusPreviousAmount2 = v8;
                var v9 = BorBonusPreviousMonths1; v9.Clean = value; BorBonusPreviousMonths1 = v9;
                var v10 = BorBonusPreviousMonths2; v10.Clean = value; BorBonusPreviousMonths2 = v10;
                var v11 = BorBonusPreviousYear1; v11.Clean = value; BorBonusPreviousYear1 = v11;
                var v12 = BorBonusPreviousYear2; v12.Clean = value; BorBonusPreviousYear2 = v12;
                var v13 = BorCommissionAverageOvertime; v13.Clean = value; BorCommissionAverageOvertime = v13;
                var v14 = BorCommissionMostRecentAmount; v14.Clean = value; BorCommissionMostRecentAmount = v14;
                var v15 = BorCommissionMostRecentMonths; v15.Clean = value; BorCommissionMostRecentMonths = v15;
                var v16 = BorCommissionMostRecentYear; v16.Clean = value; BorCommissionMostRecentYear = v16;
                var v17 = BorCommissionPreviousAmount1; v17.Clean = value; BorCommissionPreviousAmount1 = v17;
                var v18 = BorCommissionPreviousAmount2; v18.Clean = value; BorCommissionPreviousAmount2 = v18;
                var v19 = BorCommissionPreviousMonths1; v19.Clean = value; BorCommissionPreviousMonths1 = v19;
                var v20 = BorCommissionPreviousMonths2; v20.Clean = value; BorCommissionPreviousMonths2 = v20;
                var v21 = BorCommissionPreviousYear1; v21.Clean = value; BorCommissionPreviousYear1 = v21;
                var v22 = BorCommissionPreviousYear2; v22.Clean = value; BorCommissionPreviousYear2 = v22;
                var v23 = BorContingentLiabilitiesLiabilityAmount1; v23.Clean = value; BorContingentLiabilitiesLiabilityAmount1 = v23;
                var v24 = BorContingentLiabilitiesLiabilityAmount2; v24.Clean = value; BorContingentLiabilitiesLiabilityAmount2 = v24;
                var v25 = BorContingentLiabilitiesLiabilityAmount3; v25.Clean = value; BorContingentLiabilitiesLiabilityAmount3 = v25;
                var v26 = BorContingentLiabilitiesLiabilityDescription1; v26.Clean = value; BorContingentLiabilitiesLiabilityDescription1 = v26;
                var v27 = BorContingentLiabilitiesLiabilityDescription2; v27.Clean = value; BorContingentLiabilitiesLiabilityDescription2 = v27;
                var v28 = BorContingentLiabilitiesLiabilityDescription3; v28.Clean = value; BorContingentLiabilitiesLiabilityDescription3 = v28;
                var v29 = BorContingentLiabilitiesTotalLiabilityAmount; v29.Clean = value; BorContingentLiabilitiesTotalLiabilityAmount = v29;
                var v30 = BorCosignedObligationsCarLoanPayment; v30.Clean = value; BorCosignedObligationsCarLoanPayment = v30;
                var v31 = BorCosignedObligationsMortgagePayment; v31.Clean = value; BorCosignedObligationsMortgagePayment = v31;
                var v32 = BorCosignedObligationsOtherPayment; v32.Clean = value; BorCosignedObligationsOtherPayment = v32;
                var v33 = BorCosignedObligationsOtherPaymentDescription; v33.Clean = value; BorCosignedObligationsOtherPaymentDescription = v33;
                var v34 = BorCosignedObligationsStudentLoanPayment; v34.Clean = value; BorCosignedObligationsStudentLoanPayment = v34;
                var v35 = BorCosignedObligationsTotalCoMortgagorLiabilities; v35.Clean = value; BorCosignedObligationsTotalCoMortgagorLiabilities = v35;
                var v36 = BorDividendAverageDividend; v36.Clean = value; BorDividendAverageDividend = v36;
                var v37 = BorDividendPreviousAmount1; v37.Clean = value; BorDividendPreviousAmount1 = v37;
                var v38 = BorDividendPreviousAmount2; v38.Clean = value; BorDividendPreviousAmount2 = v38;
                var v39 = BorDividendPreviousMonths1; v39.Clean = value; BorDividendPreviousMonths1 = v39;
                var v40 = BorDividendPreviousMonths2; v40.Clean = value; BorDividendPreviousMonths2 = v40;
                var v41 = BorDividendPreviousYear1; v41.Clean = value; BorDividendPreviousYear1 = v41;
                var v42 = BorDividendPreviousYear2; v42.Clean = value; BorDividendPreviousYear2 = v42;
                var v43 = BorDividendRequiredForCashAmount; v43.Clean = value; BorDividendRequiredForCashAmount = v43;
                var v44 = BorInterestAverageDividend; v44.Clean = value; BorInterestAverageDividend = v44;
                var v45 = BorInterestPreviousAmount1; v45.Clean = value; BorInterestPreviousAmount1 = v45;
                var v46 = BorInterestPreviousAmount2; v46.Clean = value; BorInterestPreviousAmount2 = v46;
                var v47 = BorInterestPreviousMonths1; v47.Clean = value; BorInterestPreviousMonths1 = v47;
                var v48 = BorInterestPreviousMonths2; v48.Clean = value; BorInterestPreviousMonths2 = v48;
                var v49 = BorInterestPreviousYear1; v49.Clean = value; BorInterestPreviousYear1 = v49;
                var v50 = BorInterestPreviousYear2; v50.Clean = value; BorInterestPreviousYear2 = v50;
                var v51 = BorInterestRequiredForCashAmount; v51.Clean = value; BorInterestRequiredForCashAmount = v51;
                var v52 = BorMilitaryAllowanceClothingAllowance; v52.Clean = value; BorMilitaryAllowanceClothingAllowance = v52;
                var v53 = BorMilitaryAllowanceOtherAllowance; v53.Clean = value; BorMilitaryAllowanceOtherAllowance = v53;
                var v54 = BorMilitaryAllowanceOtherAllowanceDescription; v54.Clean = value; BorMilitaryAllowanceOtherAllowanceDescription = v54;
                var v55 = BorMilitaryAllowanceQuartersAllowance; v55.Clean = value; BorMilitaryAllowanceQuartersAllowance = v55;
                var v56 = BorMilitaryAllowanceRationsAllowance; v56.Clean = value; BorMilitaryAllowanceRationsAllowance = v56;
                var v57 = BorMilitaryAllowanceTotalAllowance; v57.Clean = value; BorMilitaryAllowanceTotalAllowance = v57;
                var v58 = BorMilitaryAllowanceVariableHousingAllowance; v58.Clean = value; BorMilitaryAllowanceVariableHousingAllowance = v58;
                var v59 = BorMilitaryBasePay; v59.Clean = value; BorMilitaryBasePay = v59;
                var v60 = BorMilitaryCombatPay; v60.Clean = value; BorMilitaryCombatPay = v60;
                var v61 = BorMilitaryFlightPay; v61.Clean = value; BorMilitaryFlightPay = v61;
                var v62 = BorMilitaryHazardPay; v62.Clean = value; BorMilitaryHazardPay = v62;
                var v63 = BorMilitaryOverseasPay; v63.Clean = value; BorMilitaryOverseasPay = v63;
                var v64 = BorMilitaryPropPay; v64.Clean = value; BorMilitaryPropPay = v64;
                var v65 = BorMilitaryTotalPay; v65.Clean = value; BorMilitaryTotalPay = v65;
                var v66 = BorMonthlyEmplymentIncomeBaseIncome; v66.Clean = value; BorMonthlyEmplymentIncomeBaseIncome = v66;
                var v67 = BorMonthlyEmplymentIncomeBonuseIncome; v67.Clean = value; BorMonthlyEmplymentIncomeBonuseIncome = v67;
                var v68 = BorMonthlyEmplymentIncomeCommissionIncome; v68.Clean = value; BorMonthlyEmplymentIncomeCommissionIncome = v68;
                var v69 = BorMonthlyEmplymentIncomeDividendInterestIncome; v69.Clean = value; BorMonthlyEmplymentIncomeDividendInterestIncome = v69;
                var v70 = BorMonthlyEmplymentIncomeOtherIncome1; v70.Clean = value; BorMonthlyEmplymentIncomeOtherIncome1 = v70;
                var v71 = BorMonthlyEmplymentIncomeOtherIncome2; v71.Clean = value; BorMonthlyEmplymentIncomeOtherIncome2 = v71;
                var v72 = BorMonthlyEmplymentIncomeOvertimeIncome; v72.Clean = value; BorMonthlyEmplymentIncomeOvertimeIncome = v72;
                var v73 = BorMonthlyEmplymentIncomeTotalEmploymentIncome; v73.Clean = value; BorMonthlyEmplymentIncomeTotalEmploymentIncome = v73;
                var v74 = BorNonEmploymentIncomeGovtAssitProgramIncome; v74.Clean = value; BorNonEmploymentIncomeGovtAssitProgramIncome = v74;
                var v75 = BorNonEmploymentIncomeHomeownSubsidyIncome; v75.Clean = value; BorNonEmploymentIncomeHomeownSubsidyIncome = v75;
                var v76 = BorNonEmploymentIncomeIsOffsetHomeownSubsidyIncome; v76.Clean = value; BorNonEmploymentIncomeIsOffsetHomeownSubsidyIncome = v76;
                var v77 = BorNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome; v77.Clean = value; BorNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome = v77;
                var v78 = BorNonEmploymentIncomeMilitaryIncome; v78.Clean = value; BorNonEmploymentIncomeMilitaryIncome = v78;
                var v79 = BorNonEmploymentIncomeMtgCreditCertificateIncome; v79.Clean = value; BorNonEmploymentIncomeMtgCreditCertificateIncome = v79;
                var v80 = BorNonEmploymentIncomeTotalNonEmploymentIncome; v80.Clean = value; BorNonEmploymentIncomeTotalNonEmploymentIncome = v80;
                var v81 = BorNonEmploymentIncomeVABenefitIncome; v81.Clean = value; BorNonEmploymentIncomeVABenefitIncome = v81;
                var v82 = BorNonTaxableIncomeChildSupportIncome; v82.Clean = value; BorNonTaxableIncomeChildSupportIncome = v82;
                var v83 = BorNonTaxableIncomeDisabilityIncome; v83.Clean = value; BorNonTaxableIncomeDisabilityIncome = v83;
                var v84 = BorNonTaxableIncomeFedGovtEmplRetirementIncome; v84.Clean = value; BorNonTaxableIncomeFedGovtEmplRetirementIncome = v84;
                var v85 = BorNonTaxableIncomeMilitaryAllowances; v85.Clean = value; BorNonTaxableIncomeMilitaryAllowances = v85;
                var v86 = BorNonTaxableIncomeOtherIncome; v86.Clean = value; BorNonTaxableIncomeOtherIncome = v86;
                var v87 = BorNonTaxableIncomePublicAssistPayments; v87.Clean = value; BorNonTaxableIncomePublicAssistPayments = v87;
                var v88 = BorNonTaxableIncomeRailroadRetirementBenefits; v88.Clean = value; BorNonTaxableIncomeRailroadRetirementBenefits = v88;
                var v89 = BorNonTaxableIncomeSocialSecurityIncome; v89.Clean = value; BorNonTaxableIncomeSocialSecurityIncome = v89;
                var v90 = BorNonTaxableIncomeStateGovtEmplRetirementIncome; v90.Clean = value; BorNonTaxableIncomeStateGovtEmplRetirementIncome = v90;
                var v91 = BorNonTaxableIncomeTotalNonTaxableIncome; v91.Clean = value; BorNonTaxableIncomeTotalNonTaxableIncome = v91;
                var v92 = BorOtherNotesReceivableIncome; v92.Clean = value; BorOtherNotesReceivableIncome = v92;
                var v93 = BorOtherOtherIncome; v93.Clean = value; BorOtherOtherIncome = v93;
                var v94 = BorOtherParttimeIncome; v94.Clean = value; BorOtherParttimeIncome = v94;
                var v95 = BorOtherRetirementIncome; v95.Clean = value; BorOtherRetirementIncome = v95;
                var v96 = BorOtherSeasonalIncome; v96.Clean = value; BorOtherSeasonalIncome = v96;
                var v97 = BorOtherSocialSecurityIncome; v97.Clean = value; BorOtherSocialSecurityIncome = v97;
                var v98 = BorOtherTipIncome; v98.Clean = value; BorOtherTipIncome = v98;
                var v99 = BorOtherTrustIncome; v99.Clean = value; BorOtherTrustIncome = v99;
                var v100 = BorOtherUnemploymentIncome; v100.Clean = value; BorOtherUnemploymentIncome = v100;
                var v101 = BorOvertimeAverageOvertime; v101.Clean = value; BorOvertimeAverageOvertime = v101;
                var v102 = BorOvertimeMostRecentAmount; v102.Clean = value; BorOvertimeMostRecentAmount = v102;
                var v103 = BorOvertimeMostRecentMonths; v103.Clean = value; BorOvertimeMostRecentMonths = v103;
                var v104 = BorOvertimeMostRecentYear; v104.Clean = value; BorOvertimeMostRecentYear = v104;
                var v105 = BorOvertimePreviousAmount1; v105.Clean = value; BorOvertimePreviousAmount1 = v105;
                var v106 = BorOvertimePreviousAmount2; v106.Clean = value; BorOvertimePreviousAmount2 = v106;
                var v107 = BorOvertimePreviousMonths1; v107.Clean = value; BorOvertimePreviousMonths1 = v107;
                var v108 = BorOvertimePreviousMonths2; v108.Clean = value; BorOvertimePreviousMonths2 = v108;
                var v109 = BorOvertimePreviousYear1; v109.Clean = value; BorOvertimePreviousYear1 = v109;
                var v110 = BorOvertimePreviousYear2; v110.Clean = value; BorOvertimePreviousYear2 = v110;
                var v111 = BorProjectedIncomeProjectedBonuses; v111.Clean = value; BorProjectedIncomeProjectedBonuses = v111;
                var v112 = BorProjectedIncomeProjectedCostLivingAdjustment; v112.Clean = value; BorProjectedIncomeProjectedCostLivingAdjustment = v112;
                var v113 = BorProjectedIncomeProjectedNewJobIncome; v113.Clean = value; BorProjectedIncomeProjectedNewJobIncome = v113;
                var v114 = BorProjectedIncomeProjectedPerformanceRaises; v114.Clean = value; BorProjectedIncomeProjectedPerformanceRaises = v114;
                var v115 = BorProjectedIncomeTotalProjectedIncome; v115.Clean = value; BorProjectedIncomeTotalProjectedIncome = v115;
                var v116 = CobBonusAverageOvertime; v116.Clean = value; CobBonusAverageOvertime = v116;
                var v117 = CobBonusMostRecentAmount; v117.Clean = value; CobBonusMostRecentAmount = v117;
                var v118 = CobBonusMostRecentMonths; v118.Clean = value; CobBonusMostRecentMonths = v118;
                var v119 = CobBonusMostRecentYear; v119.Clean = value; CobBonusMostRecentYear = v119;
                var v120 = CobBonusPreviousAmount1; v120.Clean = value; CobBonusPreviousAmount1 = v120;
                var v121 = CobBonusPreviousAmount2; v121.Clean = value; CobBonusPreviousAmount2 = v121;
                var v122 = CobBonusPreviousMonths1; v122.Clean = value; CobBonusPreviousMonths1 = v122;
                var v123 = CobBonusPreviousMonths2; v123.Clean = value; CobBonusPreviousMonths2 = v123;
                var v124 = CobBonusPreviousYear1; v124.Clean = value; CobBonusPreviousYear1 = v124;
                var v125 = CobBonusPreviousYear2; v125.Clean = value; CobBonusPreviousYear2 = v125;
                var v126 = CobCommissionAverageOvertime; v126.Clean = value; CobCommissionAverageOvertime = v126;
                var v127 = CobCommissionMostRecentAmount; v127.Clean = value; CobCommissionMostRecentAmount = v127;
                var v128 = CobCommissionMostRecentMonths; v128.Clean = value; CobCommissionMostRecentMonths = v128;
                var v129 = CobCommissionMostRecentYear; v129.Clean = value; CobCommissionMostRecentYear = v129;
                var v130 = CobCommissionPreviousAmount1; v130.Clean = value; CobCommissionPreviousAmount1 = v130;
                var v131 = CobCommissionPreviousAmount2; v131.Clean = value; CobCommissionPreviousAmount2 = v131;
                var v132 = CobCommissionPreviousMonths1; v132.Clean = value; CobCommissionPreviousMonths1 = v132;
                var v133 = CobCommissionPreviousMonths2; v133.Clean = value; CobCommissionPreviousMonths2 = v133;
                var v134 = CobCommissionPreviousYear1; v134.Clean = value; CobCommissionPreviousYear1 = v134;
                var v135 = CobCommissionPreviousYear2; v135.Clean = value; CobCommissionPreviousYear2 = v135;
                var v136 = CobDividendAverageDividend; v136.Clean = value; CobDividendAverageDividend = v136;
                var v137 = CobDividendPreviousAmount1; v137.Clean = value; CobDividendPreviousAmount1 = v137;
                var v138 = CobDividendPreviousAmount2; v138.Clean = value; CobDividendPreviousAmount2 = v138;
                var v139 = CobDividendPreviousMonths1; v139.Clean = value; CobDividendPreviousMonths1 = v139;
                var v140 = CobDividendPreviousMonths2; v140.Clean = value; CobDividendPreviousMonths2 = v140;
                var v141 = CobDividendPreviousYear1; v141.Clean = value; CobDividendPreviousYear1 = v141;
                var v142 = CobDividendPreviousYear2; v142.Clean = value; CobDividendPreviousYear2 = v142;
                var v143 = CobDividendRequiredForCashAmount; v143.Clean = value; CobDividendRequiredForCashAmount = v143;
                var v144 = CobInterestAverageDividend; v144.Clean = value; CobInterestAverageDividend = v144;
                var v145 = CobInterestPreviousAmount1; v145.Clean = value; CobInterestPreviousAmount1 = v145;
                var v146 = CobInterestPreviousAmount2; v146.Clean = value; CobInterestPreviousAmount2 = v146;
                var v147 = CobInterestPreviousMonths1; v147.Clean = value; CobInterestPreviousMonths1 = v147;
                var v148 = CobInterestPreviousMonths2; v148.Clean = value; CobInterestPreviousMonths2 = v148;
                var v149 = CobInterestPreviousYear1; v149.Clean = value; CobInterestPreviousYear1 = v149;
                var v150 = CobInterestPreviousYear2; v150.Clean = value; CobInterestPreviousYear2 = v150;
                var v151 = CobInterestRequiredForCashAmount; v151.Clean = value; CobInterestRequiredForCashAmount = v151;
                var v152 = CobMilitaryAllowanceClothingAllowance; v152.Clean = value; CobMilitaryAllowanceClothingAllowance = v152;
                var v153 = CobMilitaryAllowanceOtherAllowance; v153.Clean = value; CobMilitaryAllowanceOtherAllowance = v153;
                var v154 = CobMilitaryAllowanceQuartersAllowance; v154.Clean = value; CobMilitaryAllowanceQuartersAllowance = v154;
                var v155 = CobMilitaryAllowanceRationsAllowance; v155.Clean = value; CobMilitaryAllowanceRationsAllowance = v155;
                var v156 = CobMilitaryAllowanceTotalAllowance; v156.Clean = value; CobMilitaryAllowanceTotalAllowance = v156;
                var v157 = CobMilitaryAllowanceVariableHousingAllowance; v157.Clean = value; CobMilitaryAllowanceVariableHousingAllowance = v157;
                var v158 = CobMilitaryBasePay; v158.Clean = value; CobMilitaryBasePay = v158;
                var v159 = CobMilitaryCombatPay; v159.Clean = value; CobMilitaryCombatPay = v159;
                var v160 = CobMilitaryFlightPay; v160.Clean = value; CobMilitaryFlightPay = v160;
                var v161 = CobMilitaryHazardPay; v161.Clean = value; CobMilitaryHazardPay = v161;
                var v162 = CobMilitaryOverseasPay; v162.Clean = value; CobMilitaryOverseasPay = v162;
                var v163 = CobMilitaryPropPay; v163.Clean = value; CobMilitaryPropPay = v163;
                var v164 = CobMilitaryTotalPay; v164.Clean = value; CobMilitaryTotalPay = v164;
                var v165 = CobMonthlyEmplymentIncomeBaseIncome; v165.Clean = value; CobMonthlyEmplymentIncomeBaseIncome = v165;
                var v166 = CobMonthlyEmplymentIncomeBonuseIncome; v166.Clean = value; CobMonthlyEmplymentIncomeBonuseIncome = v166;
                var v167 = CobMonthlyEmplymentIncomeCommissionIncome; v167.Clean = value; CobMonthlyEmplymentIncomeCommissionIncome = v167;
                var v168 = CobMonthlyEmplymentIncomeDividendInterestIncome; v168.Clean = value; CobMonthlyEmplymentIncomeDividendInterestIncome = v168;
                var v169 = CobMonthlyEmplymentIncomeOtherIncome1; v169.Clean = value; CobMonthlyEmplymentIncomeOtherIncome1 = v169;
                var v170 = CobMonthlyEmplymentIncomeOtherIncome2; v170.Clean = value; CobMonthlyEmplymentIncomeOtherIncome2 = v170;
                var v171 = CobMonthlyEmplymentIncomeOvertimeIncome; v171.Clean = value; CobMonthlyEmplymentIncomeOvertimeIncome = v171;
                var v172 = CobMonthlyEmplymentIncomeTotalEmploymentIncome; v172.Clean = value; CobMonthlyEmplymentIncomeTotalEmploymentIncome = v172;
                var v173 = CobNonEmploymentIncomeGovtAssitProgramIncome; v173.Clean = value; CobNonEmploymentIncomeGovtAssitProgramIncome = v173;
                var v174 = CobNonEmploymentIncomeHomeownSubsidyIncome; v174.Clean = value; CobNonEmploymentIncomeHomeownSubsidyIncome = v174;
                var v175 = CobNonEmploymentIncomeMilitaryIncome; v175.Clean = value; CobNonEmploymentIncomeMilitaryIncome = v175;
                var v176 = CobNonEmploymentIncomeMtgCreditCertificateIncome; v176.Clean = value; CobNonEmploymentIncomeMtgCreditCertificateIncome = v176;
                var v177 = CobNonEmploymentIncomeTotalNonEmploymentIncome; v177.Clean = value; CobNonEmploymentIncomeTotalNonEmploymentIncome = v177;
                var v178 = CobNonEmploymentIncomeVABenefitIncome; v178.Clean = value; CobNonEmploymentIncomeVABenefitIncome = v178;
                var v179 = CobNonTaxableIncomeChildSupportIncome; v179.Clean = value; CobNonTaxableIncomeChildSupportIncome = v179;
                var v180 = CobNonTaxableIncomeDisabilityIncome; v180.Clean = value; CobNonTaxableIncomeDisabilityIncome = v180;
                var v181 = CobNonTaxableIncomeFedGovtEmplRetirementIncome; v181.Clean = value; CobNonTaxableIncomeFedGovtEmplRetirementIncome = v181;
                var v182 = CobNonTaxableIncomeMilitaryAllowances; v182.Clean = value; CobNonTaxableIncomeMilitaryAllowances = v182;
                var v183 = CobNonTaxableIncomeOtherIncome; v183.Clean = value; CobNonTaxableIncomeOtherIncome = v183;
                var v184 = CobNonTaxableIncomePublicAssistPayments; v184.Clean = value; CobNonTaxableIncomePublicAssistPayments = v184;
                var v185 = CobNonTaxableIncomeRailroadRetirementBenefits; v185.Clean = value; CobNonTaxableIncomeRailroadRetirementBenefits = v185;
                var v186 = CobNonTaxableIncomeSocialSecurityIncome; v186.Clean = value; CobNonTaxableIncomeSocialSecurityIncome = v186;
                var v187 = CobNonTaxableIncomeStateGovtEmplRetirementIncome; v187.Clean = value; CobNonTaxableIncomeStateGovtEmplRetirementIncome = v187;
                var v188 = CobNonTaxableIncomeTotalNonTaxableIncome; v188.Clean = value; CobNonTaxableIncomeTotalNonTaxableIncome = v188;
                var v189 = CobOtherNotesReceivableIncome; v189.Clean = value; CobOtherNotesReceivableIncome = v189;
                var v190 = CobOtherOtherIncome; v190.Clean = value; CobOtherOtherIncome = v190;
                var v191 = CobOtherParttimeIncome; v191.Clean = value; CobOtherParttimeIncome = v191;
                var v192 = CobOtherRetirementIncome; v192.Clean = value; CobOtherRetirementIncome = v192;
                var v193 = CobOtherSeasonalIncome; v193.Clean = value; CobOtherSeasonalIncome = v193;
                var v194 = CobOtherSocialSecurityIncome; v194.Clean = value; CobOtherSocialSecurityIncome = v194;
                var v195 = CobOtherTipIncome; v195.Clean = value; CobOtherTipIncome = v195;
                var v196 = CobOtherTrustIncome; v196.Clean = value; CobOtherTrustIncome = v196;
                var v197 = CobOtherUnemploymentIncome; v197.Clean = value; CobOtherUnemploymentIncome = v197;
                var v198 = CobOvertimeAverageOvertime; v198.Clean = value; CobOvertimeAverageOvertime = v198;
                var v199 = CobOvertimeMostRecentAmount; v199.Clean = value; CobOvertimeMostRecentAmount = v199;
                var v200 = CobOvertimeMostRecentMonths; v200.Clean = value; CobOvertimeMostRecentMonths = v200;
                var v201 = CobOvertimeMostRecentYear; v201.Clean = value; CobOvertimeMostRecentYear = v201;
                var v202 = CobOvertimePreviousAmount1; v202.Clean = value; CobOvertimePreviousAmount1 = v202;
                var v203 = CobOvertimePreviousAmount2; v203.Clean = value; CobOvertimePreviousAmount2 = v203;
                var v204 = CobOvertimePreviousMonths1; v204.Clean = value; CobOvertimePreviousMonths1 = v204;
                var v205 = CobOvertimePreviousMonths2; v205.Clean = value; CobOvertimePreviousMonths2 = v205;
                var v206 = CobOvertimePreviousYear1; v206.Clean = value; CobOvertimePreviousYear1 = v206;
                var v207 = CobOvertimePreviousYear2; v207.Clean = value; CobOvertimePreviousYear2 = v207;
                var v208 = CobProjectedIncomeProjectedBonuses; v208.Clean = value; CobProjectedIncomeProjectedBonuses = v208;
                var v209 = CobProjectedIncomeProjectedCostLivingAdjustment; v209.Clean = value; CobProjectedIncomeProjectedCostLivingAdjustment = v209;
                var v210 = CobProjectedIncomeProjectedNewJobIncome; v210.Clean = value; CobProjectedIncomeProjectedNewJobIncome = v210;
                var v211 = CobProjectedIncomeProjectedPerformanceRaises; v211.Clean = value; CobProjectedIncomeProjectedPerformanceRaises = v211;
                var v212 = CobProjectedIncomeTotalProjectedIncome; v212.Clean = value; CobProjectedIncomeTotalProjectedIncome = v212;
                var v213 = DUCaseIDorLPAUSKey; v213.Clean = value; DUCaseIDorLPAUSKey = v213;
                var v214 = FirstSubmissionDate; v214.Clean = value; FirstSubmissionDate = v214;
                var v215 = FirstSubmissionTime; v215.Clean = value; FirstSubmissionTime = v215;
                var v216 = FreddieDocClass; v216.Clean = value; FreddieDocClass = v216;
                var v217 = HousingRatio; v217.Clean = value; HousingRatio = v217;
                var v218 = Id; v218.Clean = value; Id = v218;
                var v219 = IsEmpty; v219.Clean = value; IsEmpty = v219;
                var v220 = SubmissionDate; v220.Clean = value; SubmissionDate = v220;
                var v221 = SubmissionNumber; v221.Clean = value; SubmissionNumber = v221;
                var v222 = SubmissionTime; v222.Clean = value; SubmissionTime = v222;
                var v223 = SubmittedBy; v223.Clean = value; SubmittedBy = v223;
                var v224 = TotalExpenseRatio; v224.Clean = value; TotalExpenseRatio = v224;
                var v225 = TotalHousingPayment; v225.Clean = value; TotalHousingPayment = v225;
                var v226 = TotalMonthlyAssets; v226.Clean = value; TotalMonthlyAssets = v226;
                var v227 = TotalMonthlyDebt; v227.Clean = value; TotalMonthlyDebt = v227;
                var v228 = TotalMonthlyIncome; v228.Clean = value; TotalMonthlyIncome = v228;
                var v229 = UnderwritingRiskAssessOther; v229.Clean = value; UnderwritingRiskAssessOther = v229;
                var v230 = UnderwritingRiskAssessType; v230.Clean = value; UnderwritingRiskAssessType = v230;
                _settingClean = 0;
            }
        }
    }
}