using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ATRQMBorrower
    {
        private Value<int?> _aTRQMBorrowerIndex;
        public int? ATRQMBorrowerIndex { get { return _aTRQMBorrowerIndex; } set { _aTRQMBorrowerIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeATRQMBorrowerIndex() => !_aTRQMBorrowerIndex.Clean;
        private Value<string> _aUSRecommendation;
        public string AUSRecommendation { get { return _aUSRecommendation; } set { _aUSRecommendation = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUSRecommendation() => !_aUSRecommendation.Clean;
        private Value<string> _aUSVersion;
        public string AUSVersion { get { return _aUSVersion; } set { _aUSVersion = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUSVersion() => !_aUSVersion.Clean;
        private Value<decimal?> _borBonusAverageOvertime;
        public decimal? BorBonusAverageOvertime { get { return _borBonusAverageOvertime; } set { _borBonusAverageOvertime = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusAverageOvertime() => !_borBonusAverageOvertime.Clean;
        private Value<decimal?> _borBonusMostRecentAmount;
        public decimal? BorBonusMostRecentAmount { get { return _borBonusMostRecentAmount; } set { _borBonusMostRecentAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusMostRecentAmount() => !_borBonusMostRecentAmount.Clean;
        private Value<int?> _borBonusMostRecentMonths;
        public int? BorBonusMostRecentMonths { get { return _borBonusMostRecentMonths; } set { _borBonusMostRecentMonths = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusMostRecentMonths() => !_borBonusMostRecentMonths.Clean;
        private Value<int?> _borBonusMostRecentYear;
        public int? BorBonusMostRecentYear { get { return _borBonusMostRecentYear; } set { _borBonusMostRecentYear = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusMostRecentYear() => !_borBonusMostRecentYear.Clean;
        private Value<decimal?> _borBonusPreviousAmount1;
        public decimal? BorBonusPreviousAmount1 { get { return _borBonusPreviousAmount1; } set { _borBonusPreviousAmount1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusPreviousAmount1() => !_borBonusPreviousAmount1.Clean;
        private Value<decimal?> _borBonusPreviousAmount2;
        public decimal? BorBonusPreviousAmount2 { get { return _borBonusPreviousAmount2; } set { _borBonusPreviousAmount2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusPreviousAmount2() => !_borBonusPreviousAmount2.Clean;
        private Value<int?> _borBonusPreviousMonths1;
        public int? BorBonusPreviousMonths1 { get { return _borBonusPreviousMonths1; } set { _borBonusPreviousMonths1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusPreviousMonths1() => !_borBonusPreviousMonths1.Clean;
        private Value<int?> _borBonusPreviousMonths2;
        public int? BorBonusPreviousMonths2 { get { return _borBonusPreviousMonths2; } set { _borBonusPreviousMonths2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusPreviousMonths2() => !_borBonusPreviousMonths2.Clean;
        private Value<int?> _borBonusPreviousYear1;
        public int? BorBonusPreviousYear1 { get { return _borBonusPreviousYear1; } set { _borBonusPreviousYear1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusPreviousYear1() => !_borBonusPreviousYear1.Clean;
        private Value<int?> _borBonusPreviousYear2;
        public int? BorBonusPreviousYear2 { get { return _borBonusPreviousYear2; } set { _borBonusPreviousYear2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorBonusPreviousYear2() => !_borBonusPreviousYear2.Clean;
        private Value<decimal?> _borCommissionAverageOvertime;
        public decimal? BorCommissionAverageOvertime { get { return _borCommissionAverageOvertime; } set { _borCommissionAverageOvertime = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionAverageOvertime() => !_borCommissionAverageOvertime.Clean;
        private Value<decimal?> _borCommissionMostRecentAmount;
        public decimal? BorCommissionMostRecentAmount { get { return _borCommissionMostRecentAmount; } set { _borCommissionMostRecentAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionMostRecentAmount() => !_borCommissionMostRecentAmount.Clean;
        private Value<int?> _borCommissionMostRecentMonths;
        public int? BorCommissionMostRecentMonths { get { return _borCommissionMostRecentMonths; } set { _borCommissionMostRecentMonths = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionMostRecentMonths() => !_borCommissionMostRecentMonths.Clean;
        private Value<int?> _borCommissionMostRecentYear;
        public int? BorCommissionMostRecentYear { get { return _borCommissionMostRecentYear; } set { _borCommissionMostRecentYear = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionMostRecentYear() => !_borCommissionMostRecentYear.Clean;
        private Value<decimal?> _borCommissionPreviousAmount1;
        public decimal? BorCommissionPreviousAmount1 { get { return _borCommissionPreviousAmount1; } set { _borCommissionPreviousAmount1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionPreviousAmount1() => !_borCommissionPreviousAmount1.Clean;
        private Value<decimal?> _borCommissionPreviousAmount2;
        public decimal? BorCommissionPreviousAmount2 { get { return _borCommissionPreviousAmount2; } set { _borCommissionPreviousAmount2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionPreviousAmount2() => !_borCommissionPreviousAmount2.Clean;
        private Value<int?> _borCommissionPreviousMonths1;
        public int? BorCommissionPreviousMonths1 { get { return _borCommissionPreviousMonths1; } set { _borCommissionPreviousMonths1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionPreviousMonths1() => !_borCommissionPreviousMonths1.Clean;
        private Value<int?> _borCommissionPreviousMonths2;
        public int? BorCommissionPreviousMonths2 { get { return _borCommissionPreviousMonths2; } set { _borCommissionPreviousMonths2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionPreviousMonths2() => !_borCommissionPreviousMonths2.Clean;
        private Value<int?> _borCommissionPreviousYear1;
        public int? BorCommissionPreviousYear1 { get { return _borCommissionPreviousYear1; } set { _borCommissionPreviousYear1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionPreviousYear1() => !_borCommissionPreviousYear1.Clean;
        private Value<int?> _borCommissionPreviousYear2;
        public int? BorCommissionPreviousYear2 { get { return _borCommissionPreviousYear2; } set { _borCommissionPreviousYear2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCommissionPreviousYear2() => !_borCommissionPreviousYear2.Clean;
        private Value<decimal?> _borContingentLiabilitiesLiabilityAmount1;
        public decimal? BorContingentLiabilitiesLiabilityAmount1 { get { return _borContingentLiabilitiesLiabilityAmount1; } set { _borContingentLiabilitiesLiabilityAmount1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorContingentLiabilitiesLiabilityAmount1() => !_borContingentLiabilitiesLiabilityAmount1.Clean;
        private Value<decimal?> _borContingentLiabilitiesLiabilityAmount2;
        public decimal? BorContingentLiabilitiesLiabilityAmount2 { get { return _borContingentLiabilitiesLiabilityAmount2; } set { _borContingentLiabilitiesLiabilityAmount2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorContingentLiabilitiesLiabilityAmount2() => !_borContingentLiabilitiesLiabilityAmount2.Clean;
        private Value<decimal?> _borContingentLiabilitiesLiabilityAmount3;
        public decimal? BorContingentLiabilitiesLiabilityAmount3 { get { return _borContingentLiabilitiesLiabilityAmount3; } set { _borContingentLiabilitiesLiabilityAmount3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorContingentLiabilitiesLiabilityAmount3() => !_borContingentLiabilitiesLiabilityAmount3.Clean;
        private Value<string> _borContingentLiabilitiesLiabilityDescription1;
        public string BorContingentLiabilitiesLiabilityDescription1 { get { return _borContingentLiabilitiesLiabilityDescription1; } set { _borContingentLiabilitiesLiabilityDescription1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorContingentLiabilitiesLiabilityDescription1() => !_borContingentLiabilitiesLiabilityDescription1.Clean;
        private Value<string> _borContingentLiabilitiesLiabilityDescription2;
        public string BorContingentLiabilitiesLiabilityDescription2 { get { return _borContingentLiabilitiesLiabilityDescription2; } set { _borContingentLiabilitiesLiabilityDescription2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorContingentLiabilitiesLiabilityDescription2() => !_borContingentLiabilitiesLiabilityDescription2.Clean;
        private Value<string> _borContingentLiabilitiesLiabilityDescription3;
        public string BorContingentLiabilitiesLiabilityDescription3 { get { return _borContingentLiabilitiesLiabilityDescription3; } set { _borContingentLiabilitiesLiabilityDescription3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorContingentLiabilitiesLiabilityDescription3() => !_borContingentLiabilitiesLiabilityDescription3.Clean;
        private Value<decimal?> _borContingentLiabilitiesTotalLiabilityAmount;
        public decimal? BorContingentLiabilitiesTotalLiabilityAmount { get { return _borContingentLiabilitiesTotalLiabilityAmount; } set { _borContingentLiabilitiesTotalLiabilityAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorContingentLiabilitiesTotalLiabilityAmount() => !_borContingentLiabilitiesTotalLiabilityAmount.Clean;
        private Value<decimal?> _borCosignedObligationsCarLoanPayment;
        public decimal? BorCosignedObligationsCarLoanPayment { get { return _borCosignedObligationsCarLoanPayment; } set { _borCosignedObligationsCarLoanPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCosignedObligationsCarLoanPayment() => !_borCosignedObligationsCarLoanPayment.Clean;
        private Value<decimal?> _borCosignedObligationsMortgagePayment;
        public decimal? BorCosignedObligationsMortgagePayment { get { return _borCosignedObligationsMortgagePayment; } set { _borCosignedObligationsMortgagePayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCosignedObligationsMortgagePayment() => !_borCosignedObligationsMortgagePayment.Clean;
        private Value<decimal?> _borCosignedObligationsOtherPayment;
        public decimal? BorCosignedObligationsOtherPayment { get { return _borCosignedObligationsOtherPayment; } set { _borCosignedObligationsOtherPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCosignedObligationsOtherPayment() => !_borCosignedObligationsOtherPayment.Clean;
        private Value<string> _borCosignedObligationsOtherPaymentDescription;
        public string BorCosignedObligationsOtherPaymentDescription { get { return _borCosignedObligationsOtherPaymentDescription; } set { _borCosignedObligationsOtherPaymentDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCosignedObligationsOtherPaymentDescription() => !_borCosignedObligationsOtherPaymentDescription.Clean;
        private Value<decimal?> _borCosignedObligationsStudentLoanPayment;
        public decimal? BorCosignedObligationsStudentLoanPayment { get { return _borCosignedObligationsStudentLoanPayment; } set { _borCosignedObligationsStudentLoanPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCosignedObligationsStudentLoanPayment() => !_borCosignedObligationsStudentLoanPayment.Clean;
        private Value<decimal?> _borCosignedObligationsTotalCoMortgagorLiabilities;
        public decimal? BorCosignedObligationsTotalCoMortgagorLiabilities { get { return _borCosignedObligationsTotalCoMortgagorLiabilities; } set { _borCosignedObligationsTotalCoMortgagorLiabilities = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorCosignedObligationsTotalCoMortgagorLiabilities() => !_borCosignedObligationsTotalCoMortgagorLiabilities.Clean;
        private Value<decimal?> _borDividendAverageDividend;
        public decimal? BorDividendAverageDividend { get { return _borDividendAverageDividend; } set { _borDividendAverageDividend = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorDividendAverageDividend() => !_borDividendAverageDividend.Clean;
        private Value<decimal?> _borDividendPreviousAmount1;
        public decimal? BorDividendPreviousAmount1 { get { return _borDividendPreviousAmount1; } set { _borDividendPreviousAmount1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorDividendPreviousAmount1() => !_borDividendPreviousAmount1.Clean;
        private Value<decimal?> _borDividendPreviousAmount2;
        public decimal? BorDividendPreviousAmount2 { get { return _borDividendPreviousAmount2; } set { _borDividendPreviousAmount2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorDividendPreviousAmount2() => !_borDividendPreviousAmount2.Clean;
        private Value<int?> _borDividendPreviousMonths1;
        public int? BorDividendPreviousMonths1 { get { return _borDividendPreviousMonths1; } set { _borDividendPreviousMonths1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorDividendPreviousMonths1() => !_borDividendPreviousMonths1.Clean;
        private Value<int?> _borDividendPreviousMonths2;
        public int? BorDividendPreviousMonths2 { get { return _borDividendPreviousMonths2; } set { _borDividendPreviousMonths2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorDividendPreviousMonths2() => !_borDividendPreviousMonths2.Clean;
        private Value<int?> _borDividendPreviousYear1;
        public int? BorDividendPreviousYear1 { get { return _borDividendPreviousYear1; } set { _borDividendPreviousYear1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorDividendPreviousYear1() => !_borDividendPreviousYear1.Clean;
        private Value<int?> _borDividendPreviousYear2;
        public int? BorDividendPreviousYear2 { get { return _borDividendPreviousYear2; } set { _borDividendPreviousYear2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorDividendPreviousYear2() => !_borDividendPreviousYear2.Clean;
        private Value<decimal?> _borDividendRequiredForCashAmount;
        public decimal? BorDividendRequiredForCashAmount { get { return _borDividendRequiredForCashAmount; } set { _borDividendRequiredForCashAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorDividendRequiredForCashAmount() => !_borDividendRequiredForCashAmount.Clean;
        private Value<decimal?> _borInterestAverageDividend;
        public decimal? BorInterestAverageDividend { get { return _borInterestAverageDividend; } set { _borInterestAverageDividend = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorInterestAverageDividend() => !_borInterestAverageDividend.Clean;
        private Value<decimal?> _borInterestPreviousAmount1;
        public decimal? BorInterestPreviousAmount1 { get { return _borInterestPreviousAmount1; } set { _borInterestPreviousAmount1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorInterestPreviousAmount1() => !_borInterestPreviousAmount1.Clean;
        private Value<decimal?> _borInterestPreviousAmount2;
        public decimal? BorInterestPreviousAmount2 { get { return _borInterestPreviousAmount2; } set { _borInterestPreviousAmount2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorInterestPreviousAmount2() => !_borInterestPreviousAmount2.Clean;
        private Value<int?> _borInterestPreviousMonths1;
        public int? BorInterestPreviousMonths1 { get { return _borInterestPreviousMonths1; } set { _borInterestPreviousMonths1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorInterestPreviousMonths1() => !_borInterestPreviousMonths1.Clean;
        private Value<int?> _borInterestPreviousMonths2;
        public int? BorInterestPreviousMonths2 { get { return _borInterestPreviousMonths2; } set { _borInterestPreviousMonths2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorInterestPreviousMonths2() => !_borInterestPreviousMonths2.Clean;
        private Value<int?> _borInterestPreviousYear1;
        public int? BorInterestPreviousYear1 { get { return _borInterestPreviousYear1; } set { _borInterestPreviousYear1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorInterestPreviousYear1() => !_borInterestPreviousYear1.Clean;
        private Value<int?> _borInterestPreviousYear2;
        public int? BorInterestPreviousYear2 { get { return _borInterestPreviousYear2; } set { _borInterestPreviousYear2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorInterestPreviousYear2() => !_borInterestPreviousYear2.Clean;
        private Value<decimal?> _borInterestRequiredForCashAmount;
        public decimal? BorInterestRequiredForCashAmount { get { return _borInterestRequiredForCashAmount; } set { _borInterestRequiredForCashAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorInterestRequiredForCashAmount() => !_borInterestRequiredForCashAmount.Clean;
        private Value<decimal?> _borMilitaryAllowanceClothingAllowance;
        public decimal? BorMilitaryAllowanceClothingAllowance { get { return _borMilitaryAllowanceClothingAllowance; } set { _borMilitaryAllowanceClothingAllowance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryAllowanceClothingAllowance() => !_borMilitaryAllowanceClothingAllowance.Clean;
        private Value<decimal?> _borMilitaryAllowanceOtherAllowance;
        public decimal? BorMilitaryAllowanceOtherAllowance { get { return _borMilitaryAllowanceOtherAllowance; } set { _borMilitaryAllowanceOtherAllowance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryAllowanceOtherAllowance() => !_borMilitaryAllowanceOtherAllowance.Clean;
        private Value<string> _borMilitaryAllowanceOtherAllowanceDescription;
        public string BorMilitaryAllowanceOtherAllowanceDescription { get { return _borMilitaryAllowanceOtherAllowanceDescription; } set { _borMilitaryAllowanceOtherAllowanceDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryAllowanceOtherAllowanceDescription() => !_borMilitaryAllowanceOtherAllowanceDescription.Clean;
        private Value<decimal?> _borMilitaryAllowanceQuartersAllowance;
        public decimal? BorMilitaryAllowanceQuartersAllowance { get { return _borMilitaryAllowanceQuartersAllowance; } set { _borMilitaryAllowanceQuartersAllowance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryAllowanceQuartersAllowance() => !_borMilitaryAllowanceQuartersAllowance.Clean;
        private Value<decimal?> _borMilitaryAllowanceRationsAllowance;
        public decimal? BorMilitaryAllowanceRationsAllowance { get { return _borMilitaryAllowanceRationsAllowance; } set { _borMilitaryAllowanceRationsAllowance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryAllowanceRationsAllowance() => !_borMilitaryAllowanceRationsAllowance.Clean;
        private Value<decimal?> _borMilitaryAllowanceTotalAllowance;
        public decimal? BorMilitaryAllowanceTotalAllowance { get { return _borMilitaryAllowanceTotalAllowance; } set { _borMilitaryAllowanceTotalAllowance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryAllowanceTotalAllowance() => !_borMilitaryAllowanceTotalAllowance.Clean;
        private Value<decimal?> _borMilitaryAllowanceVariableHousingAllowance;
        public decimal? BorMilitaryAllowanceVariableHousingAllowance { get { return _borMilitaryAllowanceVariableHousingAllowance; } set { _borMilitaryAllowanceVariableHousingAllowance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryAllowanceVariableHousingAllowance() => !_borMilitaryAllowanceVariableHousingAllowance.Clean;
        private Value<decimal?> _borMilitaryBasePay;
        public decimal? BorMilitaryBasePay { get { return _borMilitaryBasePay; } set { _borMilitaryBasePay = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryBasePay() => !_borMilitaryBasePay.Clean;
        private Value<decimal?> _borMilitaryCombatPay;
        public decimal? BorMilitaryCombatPay { get { return _borMilitaryCombatPay; } set { _borMilitaryCombatPay = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryCombatPay() => !_borMilitaryCombatPay.Clean;
        private Value<decimal?> _borMilitaryFlightPay;
        public decimal? BorMilitaryFlightPay { get { return _borMilitaryFlightPay; } set { _borMilitaryFlightPay = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryFlightPay() => !_borMilitaryFlightPay.Clean;
        private Value<decimal?> _borMilitaryHazardPay;
        public decimal? BorMilitaryHazardPay { get { return _borMilitaryHazardPay; } set { _borMilitaryHazardPay = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryHazardPay() => !_borMilitaryHazardPay.Clean;
        private Value<decimal?> _borMilitaryOverseasPay;
        public decimal? BorMilitaryOverseasPay { get { return _borMilitaryOverseasPay; } set { _borMilitaryOverseasPay = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryOverseasPay() => !_borMilitaryOverseasPay.Clean;
        private Value<decimal?> _borMilitaryPropPay;
        public decimal? BorMilitaryPropPay { get { return _borMilitaryPropPay; } set { _borMilitaryPropPay = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryPropPay() => !_borMilitaryPropPay.Clean;
        private Value<decimal?> _borMilitaryTotalPay;
        public decimal? BorMilitaryTotalPay { get { return _borMilitaryTotalPay; } set { _borMilitaryTotalPay = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMilitaryTotalPay() => !_borMilitaryTotalPay.Clean;
        private Value<decimal?> _borMonthlyEmplymentIncomeBaseIncome;
        public decimal? BorMonthlyEmplymentIncomeBaseIncome { get { return _borMonthlyEmplymentIncomeBaseIncome; } set { _borMonthlyEmplymentIncomeBaseIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMonthlyEmplymentIncomeBaseIncome() => !_borMonthlyEmplymentIncomeBaseIncome.Clean;
        private Value<decimal?> _borMonthlyEmplymentIncomeBonuseIncome;
        public decimal? BorMonthlyEmplymentIncomeBonuseIncome { get { return _borMonthlyEmplymentIncomeBonuseIncome; } set { _borMonthlyEmplymentIncomeBonuseIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMonthlyEmplymentIncomeBonuseIncome() => !_borMonthlyEmplymentIncomeBonuseIncome.Clean;
        private Value<decimal?> _borMonthlyEmplymentIncomeCommissionIncome;
        public decimal? BorMonthlyEmplymentIncomeCommissionIncome { get { return _borMonthlyEmplymentIncomeCommissionIncome; } set { _borMonthlyEmplymentIncomeCommissionIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMonthlyEmplymentIncomeCommissionIncome() => !_borMonthlyEmplymentIncomeCommissionIncome.Clean;
        private Value<decimal?> _borMonthlyEmplymentIncomeDividendInterestIncome;
        public decimal? BorMonthlyEmplymentIncomeDividendInterestIncome { get { return _borMonthlyEmplymentIncomeDividendInterestIncome; } set { _borMonthlyEmplymentIncomeDividendInterestIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMonthlyEmplymentIncomeDividendInterestIncome() => !_borMonthlyEmplymentIncomeDividendInterestIncome.Clean;
        private Value<decimal?> _borMonthlyEmplymentIncomeOtherIncome1;
        public decimal? BorMonthlyEmplymentIncomeOtherIncome1 { get { return _borMonthlyEmplymentIncomeOtherIncome1; } set { _borMonthlyEmplymentIncomeOtherIncome1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMonthlyEmplymentIncomeOtherIncome1() => !_borMonthlyEmplymentIncomeOtherIncome1.Clean;
        private Value<decimal?> _borMonthlyEmplymentIncomeOtherIncome2;
        public decimal? BorMonthlyEmplymentIncomeOtherIncome2 { get { return _borMonthlyEmplymentIncomeOtherIncome2; } set { _borMonthlyEmplymentIncomeOtherIncome2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMonthlyEmplymentIncomeOtherIncome2() => !_borMonthlyEmplymentIncomeOtherIncome2.Clean;
        private Value<decimal?> _borMonthlyEmplymentIncomeOvertimeIncome;
        public decimal? BorMonthlyEmplymentIncomeOvertimeIncome { get { return _borMonthlyEmplymentIncomeOvertimeIncome; } set { _borMonthlyEmplymentIncomeOvertimeIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMonthlyEmplymentIncomeOvertimeIncome() => !_borMonthlyEmplymentIncomeOvertimeIncome.Clean;
        private Value<decimal?> _borMonthlyEmplymentIncomeTotalEmploymentIncome;
        public decimal? BorMonthlyEmplymentIncomeTotalEmploymentIncome { get { return _borMonthlyEmplymentIncomeTotalEmploymentIncome; } set { _borMonthlyEmplymentIncomeTotalEmploymentIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorMonthlyEmplymentIncomeTotalEmploymentIncome() => !_borMonthlyEmplymentIncomeTotalEmploymentIncome.Clean;
        private Value<decimal?> _borNonEmploymentIncomeGovtAssitProgramIncome;
        public decimal? BorNonEmploymentIncomeGovtAssitProgramIncome { get { return _borNonEmploymentIncomeGovtAssitProgramIncome; } set { _borNonEmploymentIncomeGovtAssitProgramIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonEmploymentIncomeGovtAssitProgramIncome() => !_borNonEmploymentIncomeGovtAssitProgramIncome.Clean;
        private Value<decimal?> _borNonEmploymentIncomeHomeownSubsidyIncome;
        public decimal? BorNonEmploymentIncomeHomeownSubsidyIncome { get { return _borNonEmploymentIncomeHomeownSubsidyIncome; } set { _borNonEmploymentIncomeHomeownSubsidyIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonEmploymentIncomeHomeownSubsidyIncome() => !_borNonEmploymentIncomeHomeownSubsidyIncome.Clean;
        private Value<bool?> _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome;
        public bool? BorNonEmploymentIncomeIsOffsetHomeownSubsidyIncome { get { return _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome; } set { _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonEmploymentIncomeIsOffsetHomeownSubsidyIncome() => !_borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome.Clean;
        private Value<bool?> _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome;
        public bool? BorNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome { get { return _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome; } set { _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome() => !_borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome.Clean;
        private Value<decimal?> _borNonEmploymentIncomeMilitaryIncome;
        public decimal? BorNonEmploymentIncomeMilitaryIncome { get { return _borNonEmploymentIncomeMilitaryIncome; } set { _borNonEmploymentIncomeMilitaryIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonEmploymentIncomeMilitaryIncome() => !_borNonEmploymentIncomeMilitaryIncome.Clean;
        private Value<decimal?> _borNonEmploymentIncomeMtgCreditCertificateIncome;
        public decimal? BorNonEmploymentIncomeMtgCreditCertificateIncome { get { return _borNonEmploymentIncomeMtgCreditCertificateIncome; } set { _borNonEmploymentIncomeMtgCreditCertificateIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonEmploymentIncomeMtgCreditCertificateIncome() => !_borNonEmploymentIncomeMtgCreditCertificateIncome.Clean;
        private Value<decimal?> _borNonEmploymentIncomeTotalNonEmploymentIncome;
        public decimal? BorNonEmploymentIncomeTotalNonEmploymentIncome { get { return _borNonEmploymentIncomeTotalNonEmploymentIncome; } set { _borNonEmploymentIncomeTotalNonEmploymentIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonEmploymentIncomeTotalNonEmploymentIncome() => !_borNonEmploymentIncomeTotalNonEmploymentIncome.Clean;
        private Value<decimal?> _borNonEmploymentIncomeVABenefitIncome;
        public decimal? BorNonEmploymentIncomeVABenefitIncome { get { return _borNonEmploymentIncomeVABenefitIncome; } set { _borNonEmploymentIncomeVABenefitIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonEmploymentIncomeVABenefitIncome() => !_borNonEmploymentIncomeVABenefitIncome.Clean;
        private Value<decimal?> _borNonTaxableIncomeChildSupportIncome;
        public decimal? BorNonTaxableIncomeChildSupportIncome { get { return _borNonTaxableIncomeChildSupportIncome; } set { _borNonTaxableIncomeChildSupportIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomeChildSupportIncome() => !_borNonTaxableIncomeChildSupportIncome.Clean;
        private Value<decimal?> _borNonTaxableIncomeDisabilityIncome;
        public decimal? BorNonTaxableIncomeDisabilityIncome { get { return _borNonTaxableIncomeDisabilityIncome; } set { _borNonTaxableIncomeDisabilityIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomeDisabilityIncome() => !_borNonTaxableIncomeDisabilityIncome.Clean;
        private Value<decimal?> _borNonTaxableIncomeFedGovtEmplRetirementIncome;
        public decimal? BorNonTaxableIncomeFedGovtEmplRetirementIncome { get { return _borNonTaxableIncomeFedGovtEmplRetirementIncome; } set { _borNonTaxableIncomeFedGovtEmplRetirementIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomeFedGovtEmplRetirementIncome() => !_borNonTaxableIncomeFedGovtEmplRetirementIncome.Clean;
        private Value<decimal?> _borNonTaxableIncomeMilitaryAllowances;
        public decimal? BorNonTaxableIncomeMilitaryAllowances { get { return _borNonTaxableIncomeMilitaryAllowances; } set { _borNonTaxableIncomeMilitaryAllowances = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomeMilitaryAllowances() => !_borNonTaxableIncomeMilitaryAllowances.Clean;
        private Value<decimal?> _borNonTaxableIncomeOtherIncome;
        public decimal? BorNonTaxableIncomeOtherIncome { get { return _borNonTaxableIncomeOtherIncome; } set { _borNonTaxableIncomeOtherIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomeOtherIncome() => !_borNonTaxableIncomeOtherIncome.Clean;
        private Value<decimal?> _borNonTaxableIncomePublicAssistPayments;
        public decimal? BorNonTaxableIncomePublicAssistPayments { get { return _borNonTaxableIncomePublicAssistPayments; } set { _borNonTaxableIncomePublicAssistPayments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomePublicAssistPayments() => !_borNonTaxableIncomePublicAssistPayments.Clean;
        private Value<decimal?> _borNonTaxableIncomeRailroadRetirementBenefits;
        public decimal? BorNonTaxableIncomeRailroadRetirementBenefits { get { return _borNonTaxableIncomeRailroadRetirementBenefits; } set { _borNonTaxableIncomeRailroadRetirementBenefits = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomeRailroadRetirementBenefits() => !_borNonTaxableIncomeRailroadRetirementBenefits.Clean;
        private Value<decimal?> _borNonTaxableIncomeSocialSecurityIncome;
        public decimal? BorNonTaxableIncomeSocialSecurityIncome { get { return _borNonTaxableIncomeSocialSecurityIncome; } set { _borNonTaxableIncomeSocialSecurityIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomeSocialSecurityIncome() => !_borNonTaxableIncomeSocialSecurityIncome.Clean;
        private Value<decimal?> _borNonTaxableIncomeStateGovtEmplRetirementIncome;
        public decimal? BorNonTaxableIncomeStateGovtEmplRetirementIncome { get { return _borNonTaxableIncomeStateGovtEmplRetirementIncome; } set { _borNonTaxableIncomeStateGovtEmplRetirementIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomeStateGovtEmplRetirementIncome() => !_borNonTaxableIncomeStateGovtEmplRetirementIncome.Clean;
        private Value<decimal?> _borNonTaxableIncomeTotalNonTaxableIncome;
        public decimal? BorNonTaxableIncomeTotalNonTaxableIncome { get { return _borNonTaxableIncomeTotalNonTaxableIncome; } set { _borNonTaxableIncomeTotalNonTaxableIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorNonTaxableIncomeTotalNonTaxableIncome() => !_borNonTaxableIncomeTotalNonTaxableIncome.Clean;
        private Value<decimal?> _borOtherNotesReceivableIncome;
        public decimal? BorOtherNotesReceivableIncome { get { return _borOtherNotesReceivableIncome; } set { _borOtherNotesReceivableIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOtherNotesReceivableIncome() => !_borOtherNotesReceivableIncome.Clean;
        private Value<decimal?> _borOtherOtherIncome;
        public decimal? BorOtherOtherIncome { get { return _borOtherOtherIncome; } set { _borOtherOtherIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOtherOtherIncome() => !_borOtherOtherIncome.Clean;
        private Value<decimal?> _borOtherParttimeIncome;
        public decimal? BorOtherParttimeIncome { get { return _borOtherParttimeIncome; } set { _borOtherParttimeIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOtherParttimeIncome() => !_borOtherParttimeIncome.Clean;
        private Value<decimal?> _borOtherRetirementIncome;
        public decimal? BorOtherRetirementIncome { get { return _borOtherRetirementIncome; } set { _borOtherRetirementIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOtherRetirementIncome() => !_borOtherRetirementIncome.Clean;
        private Value<decimal?> _borOtherSeasonalIncome;
        public decimal? BorOtherSeasonalIncome { get { return _borOtherSeasonalIncome; } set { _borOtherSeasonalIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOtherSeasonalIncome() => !_borOtherSeasonalIncome.Clean;
        private Value<decimal?> _borOtherSocialSecurityIncome;
        public decimal? BorOtherSocialSecurityIncome { get { return _borOtherSocialSecurityIncome; } set { _borOtherSocialSecurityIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOtherSocialSecurityIncome() => !_borOtherSocialSecurityIncome.Clean;
        private Value<decimal?> _borOtherTipIncome;
        public decimal? BorOtherTipIncome { get { return _borOtherTipIncome; } set { _borOtherTipIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOtherTipIncome() => !_borOtherTipIncome.Clean;
        private Value<decimal?> _borOtherTrustIncome;
        public decimal? BorOtherTrustIncome { get { return _borOtherTrustIncome; } set { _borOtherTrustIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOtherTrustIncome() => !_borOtherTrustIncome.Clean;
        private Value<decimal?> _borOtherUnemploymentIncome;
        public decimal? BorOtherUnemploymentIncome { get { return _borOtherUnemploymentIncome; } set { _borOtherUnemploymentIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOtherUnemploymentIncome() => !_borOtherUnemploymentIncome.Clean;
        private Value<decimal?> _borOvertimeAverageOvertime;
        public decimal? BorOvertimeAverageOvertime { get { return _borOvertimeAverageOvertime; } set { _borOvertimeAverageOvertime = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimeAverageOvertime() => !_borOvertimeAverageOvertime.Clean;
        private Value<decimal?> _borOvertimeMostRecentAmount;
        public decimal? BorOvertimeMostRecentAmount { get { return _borOvertimeMostRecentAmount; } set { _borOvertimeMostRecentAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimeMostRecentAmount() => !_borOvertimeMostRecentAmount.Clean;
        private Value<int?> _borOvertimeMostRecentMonths;
        public int? BorOvertimeMostRecentMonths { get { return _borOvertimeMostRecentMonths; } set { _borOvertimeMostRecentMonths = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimeMostRecentMonths() => !_borOvertimeMostRecentMonths.Clean;
        private Value<int?> _borOvertimeMostRecentYear;
        public int? BorOvertimeMostRecentYear { get { return _borOvertimeMostRecentYear; } set { _borOvertimeMostRecentYear = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimeMostRecentYear() => !_borOvertimeMostRecentYear.Clean;
        private Value<decimal?> _borOvertimePreviousAmount1;
        public decimal? BorOvertimePreviousAmount1 { get { return _borOvertimePreviousAmount1; } set { _borOvertimePreviousAmount1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimePreviousAmount1() => !_borOvertimePreviousAmount1.Clean;
        private Value<decimal?> _borOvertimePreviousAmount2;
        public decimal? BorOvertimePreviousAmount2 { get { return _borOvertimePreviousAmount2; } set { _borOvertimePreviousAmount2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimePreviousAmount2() => !_borOvertimePreviousAmount2.Clean;
        private Value<int?> _borOvertimePreviousMonths1;
        public int? BorOvertimePreviousMonths1 { get { return _borOvertimePreviousMonths1; } set { _borOvertimePreviousMonths1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimePreviousMonths1() => !_borOvertimePreviousMonths1.Clean;
        private Value<int?> _borOvertimePreviousMonths2;
        public int? BorOvertimePreviousMonths2 { get { return _borOvertimePreviousMonths2; } set { _borOvertimePreviousMonths2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimePreviousMonths2() => !_borOvertimePreviousMonths2.Clean;
        private Value<int?> _borOvertimePreviousYear1;
        public int? BorOvertimePreviousYear1 { get { return _borOvertimePreviousYear1; } set { _borOvertimePreviousYear1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimePreviousYear1() => !_borOvertimePreviousYear1.Clean;
        private Value<int?> _borOvertimePreviousYear2;
        public int? BorOvertimePreviousYear2 { get { return _borOvertimePreviousYear2; } set { _borOvertimePreviousYear2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorOvertimePreviousYear2() => !_borOvertimePreviousYear2.Clean;
        private Value<decimal?> _borProjectedIncomeProjectedBonuses;
        public decimal? BorProjectedIncomeProjectedBonuses { get { return _borProjectedIncomeProjectedBonuses; } set { _borProjectedIncomeProjectedBonuses = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorProjectedIncomeProjectedBonuses() => !_borProjectedIncomeProjectedBonuses.Clean;
        private Value<decimal?> _borProjectedIncomeProjectedCostLivingAdjustment;
        public decimal? BorProjectedIncomeProjectedCostLivingAdjustment { get { return _borProjectedIncomeProjectedCostLivingAdjustment; } set { _borProjectedIncomeProjectedCostLivingAdjustment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorProjectedIncomeProjectedCostLivingAdjustment() => !_borProjectedIncomeProjectedCostLivingAdjustment.Clean;
        private Value<decimal?> _borProjectedIncomeProjectedNewJobIncome;
        public decimal? BorProjectedIncomeProjectedNewJobIncome { get { return _borProjectedIncomeProjectedNewJobIncome; } set { _borProjectedIncomeProjectedNewJobIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorProjectedIncomeProjectedNewJobIncome() => !_borProjectedIncomeProjectedNewJobIncome.Clean;
        private Value<decimal?> _borProjectedIncomeProjectedPerformanceRaises;
        public decimal? BorProjectedIncomeProjectedPerformanceRaises { get { return _borProjectedIncomeProjectedPerformanceRaises; } set { _borProjectedIncomeProjectedPerformanceRaises = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorProjectedIncomeProjectedPerformanceRaises() => !_borProjectedIncomeProjectedPerformanceRaises.Clean;
        private Value<decimal?> _borProjectedIncomeTotalProjectedIncome;
        public decimal? BorProjectedIncomeTotalProjectedIncome { get { return _borProjectedIncomeTotalProjectedIncome; } set { _borProjectedIncomeTotalProjectedIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorProjectedIncomeTotalProjectedIncome() => !_borProjectedIncomeTotalProjectedIncome.Clean;
        private Value<decimal?> _cobBonusAverageOvertime;
        public decimal? CobBonusAverageOvertime { get { return _cobBonusAverageOvertime; } set { _cobBonusAverageOvertime = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusAverageOvertime() => !_cobBonusAverageOvertime.Clean;
        private Value<decimal?> _cobBonusMostRecentAmount;
        public decimal? CobBonusMostRecentAmount { get { return _cobBonusMostRecentAmount; } set { _cobBonusMostRecentAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusMostRecentAmount() => !_cobBonusMostRecentAmount.Clean;
        private Value<int?> _cobBonusMostRecentMonths;
        public int? CobBonusMostRecentMonths { get { return _cobBonusMostRecentMonths; } set { _cobBonusMostRecentMonths = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusMostRecentMonths() => !_cobBonusMostRecentMonths.Clean;
        private Value<int?> _cobBonusMostRecentYear;
        public int? CobBonusMostRecentYear { get { return _cobBonusMostRecentYear; } set { _cobBonusMostRecentYear = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusMostRecentYear() => !_cobBonusMostRecentYear.Clean;
        private Value<decimal?> _cobBonusPreviousAmount1;
        public decimal? CobBonusPreviousAmount1 { get { return _cobBonusPreviousAmount1; } set { _cobBonusPreviousAmount1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusPreviousAmount1() => !_cobBonusPreviousAmount1.Clean;
        private Value<decimal?> _cobBonusPreviousAmount2;
        public decimal? CobBonusPreviousAmount2 { get { return _cobBonusPreviousAmount2; } set { _cobBonusPreviousAmount2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusPreviousAmount2() => !_cobBonusPreviousAmount2.Clean;
        private Value<int?> _cobBonusPreviousMonths1;
        public int? CobBonusPreviousMonths1 { get { return _cobBonusPreviousMonths1; } set { _cobBonusPreviousMonths1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusPreviousMonths1() => !_cobBonusPreviousMonths1.Clean;
        private Value<int?> _cobBonusPreviousMonths2;
        public int? CobBonusPreviousMonths2 { get { return _cobBonusPreviousMonths2; } set { _cobBonusPreviousMonths2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusPreviousMonths2() => !_cobBonusPreviousMonths2.Clean;
        private Value<int?> _cobBonusPreviousYear1;
        public int? CobBonusPreviousYear1 { get { return _cobBonusPreviousYear1; } set { _cobBonusPreviousYear1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusPreviousYear1() => !_cobBonusPreviousYear1.Clean;
        private Value<int?> _cobBonusPreviousYear2;
        public int? CobBonusPreviousYear2 { get { return _cobBonusPreviousYear2; } set { _cobBonusPreviousYear2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobBonusPreviousYear2() => !_cobBonusPreviousYear2.Clean;
        private Value<decimal?> _cobCommissionAverageOvertime;
        public decimal? CobCommissionAverageOvertime { get { return _cobCommissionAverageOvertime; } set { _cobCommissionAverageOvertime = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionAverageOvertime() => !_cobCommissionAverageOvertime.Clean;
        private Value<decimal?> _cobCommissionMostRecentAmount;
        public decimal? CobCommissionMostRecentAmount { get { return _cobCommissionMostRecentAmount; } set { _cobCommissionMostRecentAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionMostRecentAmount() => !_cobCommissionMostRecentAmount.Clean;
        private Value<int?> _cobCommissionMostRecentMonths;
        public int? CobCommissionMostRecentMonths { get { return _cobCommissionMostRecentMonths; } set { _cobCommissionMostRecentMonths = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionMostRecentMonths() => !_cobCommissionMostRecentMonths.Clean;
        private Value<int?> _cobCommissionMostRecentYear;
        public int? CobCommissionMostRecentYear { get { return _cobCommissionMostRecentYear; } set { _cobCommissionMostRecentYear = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionMostRecentYear() => !_cobCommissionMostRecentYear.Clean;
        private Value<decimal?> _cobCommissionPreviousAmount1;
        public decimal? CobCommissionPreviousAmount1 { get { return _cobCommissionPreviousAmount1; } set { _cobCommissionPreviousAmount1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionPreviousAmount1() => !_cobCommissionPreviousAmount1.Clean;
        private Value<decimal?> _cobCommissionPreviousAmount2;
        public decimal? CobCommissionPreviousAmount2 { get { return _cobCommissionPreviousAmount2; } set { _cobCommissionPreviousAmount2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionPreviousAmount2() => !_cobCommissionPreviousAmount2.Clean;
        private Value<int?> _cobCommissionPreviousMonths1;
        public int? CobCommissionPreviousMonths1 { get { return _cobCommissionPreviousMonths1; } set { _cobCommissionPreviousMonths1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionPreviousMonths1() => !_cobCommissionPreviousMonths1.Clean;
        private Value<int?> _cobCommissionPreviousMonths2;
        public int? CobCommissionPreviousMonths2 { get { return _cobCommissionPreviousMonths2; } set { _cobCommissionPreviousMonths2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionPreviousMonths2() => !_cobCommissionPreviousMonths2.Clean;
        private Value<int?> _cobCommissionPreviousYear1;
        public int? CobCommissionPreviousYear1 { get { return _cobCommissionPreviousYear1; } set { _cobCommissionPreviousYear1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionPreviousYear1() => !_cobCommissionPreviousYear1.Clean;
        private Value<int?> _cobCommissionPreviousYear2;
        public int? CobCommissionPreviousYear2 { get { return _cobCommissionPreviousYear2; } set { _cobCommissionPreviousYear2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobCommissionPreviousYear2() => !_cobCommissionPreviousYear2.Clean;
        private Value<decimal?> _cobDividendAverageDividend;
        public decimal? CobDividendAverageDividend { get { return _cobDividendAverageDividend; } set { _cobDividendAverageDividend = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobDividendAverageDividend() => !_cobDividendAverageDividend.Clean;
        private Value<decimal?> _cobDividendPreviousAmount1;
        public decimal? CobDividendPreviousAmount1 { get { return _cobDividendPreviousAmount1; } set { _cobDividendPreviousAmount1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobDividendPreviousAmount1() => !_cobDividendPreviousAmount1.Clean;
        private Value<decimal?> _cobDividendPreviousAmount2;
        public decimal? CobDividendPreviousAmount2 { get { return _cobDividendPreviousAmount2; } set { _cobDividendPreviousAmount2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobDividendPreviousAmount2() => !_cobDividendPreviousAmount2.Clean;
        private Value<int?> _cobDividendPreviousMonths1;
        public int? CobDividendPreviousMonths1 { get { return _cobDividendPreviousMonths1; } set { _cobDividendPreviousMonths1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobDividendPreviousMonths1() => !_cobDividendPreviousMonths1.Clean;
        private Value<int?> _cobDividendPreviousMonths2;
        public int? CobDividendPreviousMonths2 { get { return _cobDividendPreviousMonths2; } set { _cobDividendPreviousMonths2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobDividendPreviousMonths2() => !_cobDividendPreviousMonths2.Clean;
        private Value<int?> _cobDividendPreviousYear1;
        public int? CobDividendPreviousYear1 { get { return _cobDividendPreviousYear1; } set { _cobDividendPreviousYear1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobDividendPreviousYear1() => !_cobDividendPreviousYear1.Clean;
        private Value<int?> _cobDividendPreviousYear2;
        public int? CobDividendPreviousYear2 { get { return _cobDividendPreviousYear2; } set { _cobDividendPreviousYear2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobDividendPreviousYear2() => !_cobDividendPreviousYear2.Clean;
        private Value<decimal?> _cobDividendRequiredForCashAmount;
        public decimal? CobDividendRequiredForCashAmount { get { return _cobDividendRequiredForCashAmount; } set { _cobDividendRequiredForCashAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobDividendRequiredForCashAmount() => !_cobDividendRequiredForCashAmount.Clean;
        private Value<decimal?> _cobInterestAverageDividend;
        public decimal? CobInterestAverageDividend { get { return _cobInterestAverageDividend; } set { _cobInterestAverageDividend = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobInterestAverageDividend() => !_cobInterestAverageDividend.Clean;
        private Value<decimal?> _cobInterestPreviousAmount1;
        public decimal? CobInterestPreviousAmount1 { get { return _cobInterestPreviousAmount1; } set { _cobInterestPreviousAmount1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobInterestPreviousAmount1() => !_cobInterestPreviousAmount1.Clean;
        private Value<decimal?> _cobInterestPreviousAmount2;
        public decimal? CobInterestPreviousAmount2 { get { return _cobInterestPreviousAmount2; } set { _cobInterestPreviousAmount2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobInterestPreviousAmount2() => !_cobInterestPreviousAmount2.Clean;
        private Value<int?> _cobInterestPreviousMonths1;
        public int? CobInterestPreviousMonths1 { get { return _cobInterestPreviousMonths1; } set { _cobInterestPreviousMonths1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobInterestPreviousMonths1() => !_cobInterestPreviousMonths1.Clean;
        private Value<int?> _cobInterestPreviousMonths2;
        public int? CobInterestPreviousMonths2 { get { return _cobInterestPreviousMonths2; } set { _cobInterestPreviousMonths2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobInterestPreviousMonths2() => !_cobInterestPreviousMonths2.Clean;
        private Value<int?> _cobInterestPreviousYear1;
        public int? CobInterestPreviousYear1 { get { return _cobInterestPreviousYear1; } set { _cobInterestPreviousYear1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobInterestPreviousYear1() => !_cobInterestPreviousYear1.Clean;
        private Value<int?> _cobInterestPreviousYear2;
        public int? CobInterestPreviousYear2 { get { return _cobInterestPreviousYear2; } set { _cobInterestPreviousYear2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobInterestPreviousYear2() => !_cobInterestPreviousYear2.Clean;
        private Value<decimal?> _cobInterestRequiredForCashAmount;
        public decimal? CobInterestRequiredForCashAmount { get { return _cobInterestRequiredForCashAmount; } set { _cobInterestRequiredForCashAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobInterestRequiredForCashAmount() => !_cobInterestRequiredForCashAmount.Clean;
        private Value<decimal?> _cobMilitaryAllowanceClothingAllowance;
        public decimal? CobMilitaryAllowanceClothingAllowance { get { return _cobMilitaryAllowanceClothingAllowance; } set { _cobMilitaryAllowanceClothingAllowance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryAllowanceClothingAllowance() => !_cobMilitaryAllowanceClothingAllowance.Clean;
        private Value<decimal?> _cobMilitaryAllowanceOtherAllowance;
        public decimal? CobMilitaryAllowanceOtherAllowance { get { return _cobMilitaryAllowanceOtherAllowance; } set { _cobMilitaryAllowanceOtherAllowance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryAllowanceOtherAllowance() => !_cobMilitaryAllowanceOtherAllowance.Clean;
        private Value<decimal?> _cobMilitaryAllowanceQuartersAllowance;
        public decimal? CobMilitaryAllowanceQuartersAllowance { get { return _cobMilitaryAllowanceQuartersAllowance; } set { _cobMilitaryAllowanceQuartersAllowance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryAllowanceQuartersAllowance() => !_cobMilitaryAllowanceQuartersAllowance.Clean;
        private Value<decimal?> _cobMilitaryAllowanceRationsAllowance;
        public decimal? CobMilitaryAllowanceRationsAllowance { get { return _cobMilitaryAllowanceRationsAllowance; } set { _cobMilitaryAllowanceRationsAllowance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryAllowanceRationsAllowance() => !_cobMilitaryAllowanceRationsAllowance.Clean;
        private Value<decimal?> _cobMilitaryAllowanceTotalAllowance;
        public decimal? CobMilitaryAllowanceTotalAllowance { get { return _cobMilitaryAllowanceTotalAllowance; } set { _cobMilitaryAllowanceTotalAllowance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryAllowanceTotalAllowance() => !_cobMilitaryAllowanceTotalAllowance.Clean;
        private Value<decimal?> _cobMilitaryAllowanceVariableHousingAllowance;
        public decimal? CobMilitaryAllowanceVariableHousingAllowance { get { return _cobMilitaryAllowanceVariableHousingAllowance; } set { _cobMilitaryAllowanceVariableHousingAllowance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryAllowanceVariableHousingAllowance() => !_cobMilitaryAllowanceVariableHousingAllowance.Clean;
        private Value<decimal?> _cobMilitaryBasePay;
        public decimal? CobMilitaryBasePay { get { return _cobMilitaryBasePay; } set { _cobMilitaryBasePay = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryBasePay() => !_cobMilitaryBasePay.Clean;
        private Value<decimal?> _cobMilitaryCombatPay;
        public decimal? CobMilitaryCombatPay { get { return _cobMilitaryCombatPay; } set { _cobMilitaryCombatPay = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryCombatPay() => !_cobMilitaryCombatPay.Clean;
        private Value<decimal?> _cobMilitaryFlightPay;
        public decimal? CobMilitaryFlightPay { get { return _cobMilitaryFlightPay; } set { _cobMilitaryFlightPay = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryFlightPay() => !_cobMilitaryFlightPay.Clean;
        private Value<decimal?> _cobMilitaryHazardPay;
        public decimal? CobMilitaryHazardPay { get { return _cobMilitaryHazardPay; } set { _cobMilitaryHazardPay = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryHazardPay() => !_cobMilitaryHazardPay.Clean;
        private Value<decimal?> _cobMilitaryOverseasPay;
        public decimal? CobMilitaryOverseasPay { get { return _cobMilitaryOverseasPay; } set { _cobMilitaryOverseasPay = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryOverseasPay() => !_cobMilitaryOverseasPay.Clean;
        private Value<decimal?> _cobMilitaryPropPay;
        public decimal? CobMilitaryPropPay { get { return _cobMilitaryPropPay; } set { _cobMilitaryPropPay = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryPropPay() => !_cobMilitaryPropPay.Clean;
        private Value<decimal?> _cobMilitaryTotalPay;
        public decimal? CobMilitaryTotalPay { get { return _cobMilitaryTotalPay; } set { _cobMilitaryTotalPay = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMilitaryTotalPay() => !_cobMilitaryTotalPay.Clean;
        private Value<decimal?> _cobMonthlyEmplymentIncomeBaseIncome;
        public decimal? CobMonthlyEmplymentIncomeBaseIncome { get { return _cobMonthlyEmplymentIncomeBaseIncome; } set { _cobMonthlyEmplymentIncomeBaseIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMonthlyEmplymentIncomeBaseIncome() => !_cobMonthlyEmplymentIncomeBaseIncome.Clean;
        private Value<decimal?> _cobMonthlyEmplymentIncomeBonuseIncome;
        public decimal? CobMonthlyEmplymentIncomeBonuseIncome { get { return _cobMonthlyEmplymentIncomeBonuseIncome; } set { _cobMonthlyEmplymentIncomeBonuseIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMonthlyEmplymentIncomeBonuseIncome() => !_cobMonthlyEmplymentIncomeBonuseIncome.Clean;
        private Value<decimal?> _cobMonthlyEmplymentIncomeCommissionIncome;
        public decimal? CobMonthlyEmplymentIncomeCommissionIncome { get { return _cobMonthlyEmplymentIncomeCommissionIncome; } set { _cobMonthlyEmplymentIncomeCommissionIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMonthlyEmplymentIncomeCommissionIncome() => !_cobMonthlyEmplymentIncomeCommissionIncome.Clean;
        private Value<decimal?> _cobMonthlyEmplymentIncomeDividendInterestIncome;
        public decimal? CobMonthlyEmplymentIncomeDividendInterestIncome { get { return _cobMonthlyEmplymentIncomeDividendInterestIncome; } set { _cobMonthlyEmplymentIncomeDividendInterestIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMonthlyEmplymentIncomeDividendInterestIncome() => !_cobMonthlyEmplymentIncomeDividendInterestIncome.Clean;
        private Value<decimal?> _cobMonthlyEmplymentIncomeOtherIncome1;
        public decimal? CobMonthlyEmplymentIncomeOtherIncome1 { get { return _cobMonthlyEmplymentIncomeOtherIncome1; } set { _cobMonthlyEmplymentIncomeOtherIncome1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMonthlyEmplymentIncomeOtherIncome1() => !_cobMonthlyEmplymentIncomeOtherIncome1.Clean;
        private Value<decimal?> _cobMonthlyEmplymentIncomeOtherIncome2;
        public decimal? CobMonthlyEmplymentIncomeOtherIncome2 { get { return _cobMonthlyEmplymentIncomeOtherIncome2; } set { _cobMonthlyEmplymentIncomeOtherIncome2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMonthlyEmplymentIncomeOtherIncome2() => !_cobMonthlyEmplymentIncomeOtherIncome2.Clean;
        private Value<decimal?> _cobMonthlyEmplymentIncomeOvertimeIncome;
        public decimal? CobMonthlyEmplymentIncomeOvertimeIncome { get { return _cobMonthlyEmplymentIncomeOvertimeIncome; } set { _cobMonthlyEmplymentIncomeOvertimeIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMonthlyEmplymentIncomeOvertimeIncome() => !_cobMonthlyEmplymentIncomeOvertimeIncome.Clean;
        private Value<decimal?> _cobMonthlyEmplymentIncomeTotalEmploymentIncome;
        public decimal? CobMonthlyEmplymentIncomeTotalEmploymentIncome { get { return _cobMonthlyEmplymentIncomeTotalEmploymentIncome; } set { _cobMonthlyEmplymentIncomeTotalEmploymentIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobMonthlyEmplymentIncomeTotalEmploymentIncome() => !_cobMonthlyEmplymentIncomeTotalEmploymentIncome.Clean;
        private Value<decimal?> _cobNonEmploymentIncomeGovtAssitProgramIncome;
        public decimal? CobNonEmploymentIncomeGovtAssitProgramIncome { get { return _cobNonEmploymentIncomeGovtAssitProgramIncome; } set { _cobNonEmploymentIncomeGovtAssitProgramIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonEmploymentIncomeGovtAssitProgramIncome() => !_cobNonEmploymentIncomeGovtAssitProgramIncome.Clean;
        private Value<decimal?> _cobNonEmploymentIncomeHomeownSubsidyIncome;
        public decimal? CobNonEmploymentIncomeHomeownSubsidyIncome { get { return _cobNonEmploymentIncomeHomeownSubsidyIncome; } set { _cobNonEmploymentIncomeHomeownSubsidyIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonEmploymentIncomeHomeownSubsidyIncome() => !_cobNonEmploymentIncomeHomeownSubsidyIncome.Clean;
        private Value<decimal?> _cobNonEmploymentIncomeMilitaryIncome;
        public decimal? CobNonEmploymentIncomeMilitaryIncome { get { return _cobNonEmploymentIncomeMilitaryIncome; } set { _cobNonEmploymentIncomeMilitaryIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonEmploymentIncomeMilitaryIncome() => !_cobNonEmploymentIncomeMilitaryIncome.Clean;
        private Value<decimal?> _cobNonEmploymentIncomeMtgCreditCertificateIncome;
        public decimal? CobNonEmploymentIncomeMtgCreditCertificateIncome { get { return _cobNonEmploymentIncomeMtgCreditCertificateIncome; } set { _cobNonEmploymentIncomeMtgCreditCertificateIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonEmploymentIncomeMtgCreditCertificateIncome() => !_cobNonEmploymentIncomeMtgCreditCertificateIncome.Clean;
        private Value<decimal?> _cobNonEmploymentIncomeTotalNonEmploymentIncome;
        public decimal? CobNonEmploymentIncomeTotalNonEmploymentIncome { get { return _cobNonEmploymentIncomeTotalNonEmploymentIncome; } set { _cobNonEmploymentIncomeTotalNonEmploymentIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonEmploymentIncomeTotalNonEmploymentIncome() => !_cobNonEmploymentIncomeTotalNonEmploymentIncome.Clean;
        private Value<decimal?> _cobNonEmploymentIncomeVABenefitIncome;
        public decimal? CobNonEmploymentIncomeVABenefitIncome { get { return _cobNonEmploymentIncomeVABenefitIncome; } set { _cobNonEmploymentIncomeVABenefitIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonEmploymentIncomeVABenefitIncome() => !_cobNonEmploymentIncomeVABenefitIncome.Clean;
        private Value<decimal?> _cobNonTaxableIncomeChildSupportIncome;
        public decimal? CobNonTaxableIncomeChildSupportIncome { get { return _cobNonTaxableIncomeChildSupportIncome; } set { _cobNonTaxableIncomeChildSupportIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomeChildSupportIncome() => !_cobNonTaxableIncomeChildSupportIncome.Clean;
        private Value<decimal?> _cobNonTaxableIncomeDisabilityIncome;
        public decimal? CobNonTaxableIncomeDisabilityIncome { get { return _cobNonTaxableIncomeDisabilityIncome; } set { _cobNonTaxableIncomeDisabilityIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomeDisabilityIncome() => !_cobNonTaxableIncomeDisabilityIncome.Clean;
        private Value<decimal?> _cobNonTaxableIncomeFedGovtEmplRetirementIncome;
        public decimal? CobNonTaxableIncomeFedGovtEmplRetirementIncome { get { return _cobNonTaxableIncomeFedGovtEmplRetirementIncome; } set { _cobNonTaxableIncomeFedGovtEmplRetirementIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomeFedGovtEmplRetirementIncome() => !_cobNonTaxableIncomeFedGovtEmplRetirementIncome.Clean;
        private Value<decimal?> _cobNonTaxableIncomeMilitaryAllowances;
        public decimal? CobNonTaxableIncomeMilitaryAllowances { get { return _cobNonTaxableIncomeMilitaryAllowances; } set { _cobNonTaxableIncomeMilitaryAllowances = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomeMilitaryAllowances() => !_cobNonTaxableIncomeMilitaryAllowances.Clean;
        private Value<decimal?> _cobNonTaxableIncomeOtherIncome;
        public decimal? CobNonTaxableIncomeOtherIncome { get { return _cobNonTaxableIncomeOtherIncome; } set { _cobNonTaxableIncomeOtherIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomeOtherIncome() => !_cobNonTaxableIncomeOtherIncome.Clean;
        private Value<decimal?> _cobNonTaxableIncomePublicAssistPayments;
        public decimal? CobNonTaxableIncomePublicAssistPayments { get { return _cobNonTaxableIncomePublicAssistPayments; } set { _cobNonTaxableIncomePublicAssistPayments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomePublicAssistPayments() => !_cobNonTaxableIncomePublicAssistPayments.Clean;
        private Value<decimal?> _cobNonTaxableIncomeRailroadRetirementBenefits;
        public decimal? CobNonTaxableIncomeRailroadRetirementBenefits { get { return _cobNonTaxableIncomeRailroadRetirementBenefits; } set { _cobNonTaxableIncomeRailroadRetirementBenefits = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomeRailroadRetirementBenefits() => !_cobNonTaxableIncomeRailroadRetirementBenefits.Clean;
        private Value<decimal?> _cobNonTaxableIncomeSocialSecurityIncome;
        public decimal? CobNonTaxableIncomeSocialSecurityIncome { get { return _cobNonTaxableIncomeSocialSecurityIncome; } set { _cobNonTaxableIncomeSocialSecurityIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomeSocialSecurityIncome() => !_cobNonTaxableIncomeSocialSecurityIncome.Clean;
        private Value<decimal?> _cobNonTaxableIncomeStateGovtEmplRetirementIncome;
        public decimal? CobNonTaxableIncomeStateGovtEmplRetirementIncome { get { return _cobNonTaxableIncomeStateGovtEmplRetirementIncome; } set { _cobNonTaxableIncomeStateGovtEmplRetirementIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomeStateGovtEmplRetirementIncome() => !_cobNonTaxableIncomeStateGovtEmplRetirementIncome.Clean;
        private Value<decimal?> _cobNonTaxableIncomeTotalNonTaxableIncome;
        public decimal? CobNonTaxableIncomeTotalNonTaxableIncome { get { return _cobNonTaxableIncomeTotalNonTaxableIncome; } set { _cobNonTaxableIncomeTotalNonTaxableIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobNonTaxableIncomeTotalNonTaxableIncome() => !_cobNonTaxableIncomeTotalNonTaxableIncome.Clean;
        private Value<decimal?> _cobOtherNotesReceivableIncome;
        public decimal? CobOtherNotesReceivableIncome { get { return _cobOtherNotesReceivableIncome; } set { _cobOtherNotesReceivableIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOtherNotesReceivableIncome() => !_cobOtherNotesReceivableIncome.Clean;
        private Value<decimal?> _cobOtherOtherIncome;
        public decimal? CobOtherOtherIncome { get { return _cobOtherOtherIncome; } set { _cobOtherOtherIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOtherOtherIncome() => !_cobOtherOtherIncome.Clean;
        private Value<decimal?> _cobOtherParttimeIncome;
        public decimal? CobOtherParttimeIncome { get { return _cobOtherParttimeIncome; } set { _cobOtherParttimeIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOtherParttimeIncome() => !_cobOtherParttimeIncome.Clean;
        private Value<decimal?> _cobOtherRetirementIncome;
        public decimal? CobOtherRetirementIncome { get { return _cobOtherRetirementIncome; } set { _cobOtherRetirementIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOtherRetirementIncome() => !_cobOtherRetirementIncome.Clean;
        private Value<decimal?> _cobOtherSeasonalIncome;
        public decimal? CobOtherSeasonalIncome { get { return _cobOtherSeasonalIncome; } set { _cobOtherSeasonalIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOtherSeasonalIncome() => !_cobOtherSeasonalIncome.Clean;
        private Value<decimal?> _cobOtherSocialSecurityIncome;
        public decimal? CobOtherSocialSecurityIncome { get { return _cobOtherSocialSecurityIncome; } set { _cobOtherSocialSecurityIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOtherSocialSecurityIncome() => !_cobOtherSocialSecurityIncome.Clean;
        private Value<decimal?> _cobOtherTipIncome;
        public decimal? CobOtherTipIncome { get { return _cobOtherTipIncome; } set { _cobOtherTipIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOtherTipIncome() => !_cobOtherTipIncome.Clean;
        private Value<decimal?> _cobOtherTrustIncome;
        public decimal? CobOtherTrustIncome { get { return _cobOtherTrustIncome; } set { _cobOtherTrustIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOtherTrustIncome() => !_cobOtherTrustIncome.Clean;
        private Value<decimal?> _cobOtherUnemploymentIncome;
        public decimal? CobOtherUnemploymentIncome { get { return _cobOtherUnemploymentIncome; } set { _cobOtherUnemploymentIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOtherUnemploymentIncome() => !_cobOtherUnemploymentIncome.Clean;
        private Value<decimal?> _cobOvertimeAverageOvertime;
        public decimal? CobOvertimeAverageOvertime { get { return _cobOvertimeAverageOvertime; } set { _cobOvertimeAverageOvertime = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimeAverageOvertime() => !_cobOvertimeAverageOvertime.Clean;
        private Value<decimal?> _cobOvertimeMostRecentAmount;
        public decimal? CobOvertimeMostRecentAmount { get { return _cobOvertimeMostRecentAmount; } set { _cobOvertimeMostRecentAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimeMostRecentAmount() => !_cobOvertimeMostRecentAmount.Clean;
        private Value<int?> _cobOvertimeMostRecentMonths;
        public int? CobOvertimeMostRecentMonths { get { return _cobOvertimeMostRecentMonths; } set { _cobOvertimeMostRecentMonths = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimeMostRecentMonths() => !_cobOvertimeMostRecentMonths.Clean;
        private Value<int?> _cobOvertimeMostRecentYear;
        public int? CobOvertimeMostRecentYear { get { return _cobOvertimeMostRecentYear; } set { _cobOvertimeMostRecentYear = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimeMostRecentYear() => !_cobOvertimeMostRecentYear.Clean;
        private Value<decimal?> _cobOvertimePreviousAmount1;
        public decimal? CobOvertimePreviousAmount1 { get { return _cobOvertimePreviousAmount1; } set { _cobOvertimePreviousAmount1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimePreviousAmount1() => !_cobOvertimePreviousAmount1.Clean;
        private Value<decimal?> _cobOvertimePreviousAmount2;
        public decimal? CobOvertimePreviousAmount2 { get { return _cobOvertimePreviousAmount2; } set { _cobOvertimePreviousAmount2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimePreviousAmount2() => !_cobOvertimePreviousAmount2.Clean;
        private Value<int?> _cobOvertimePreviousMonths1;
        public int? CobOvertimePreviousMonths1 { get { return _cobOvertimePreviousMonths1; } set { _cobOvertimePreviousMonths1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimePreviousMonths1() => !_cobOvertimePreviousMonths1.Clean;
        private Value<int?> _cobOvertimePreviousMonths2;
        public int? CobOvertimePreviousMonths2 { get { return _cobOvertimePreviousMonths2; } set { _cobOvertimePreviousMonths2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimePreviousMonths2() => !_cobOvertimePreviousMonths2.Clean;
        private Value<int?> _cobOvertimePreviousYear1;
        public int? CobOvertimePreviousYear1 { get { return _cobOvertimePreviousYear1; } set { _cobOvertimePreviousYear1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimePreviousYear1() => !_cobOvertimePreviousYear1.Clean;
        private Value<int?> _cobOvertimePreviousYear2;
        public int? CobOvertimePreviousYear2 { get { return _cobOvertimePreviousYear2; } set { _cobOvertimePreviousYear2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobOvertimePreviousYear2() => !_cobOvertimePreviousYear2.Clean;
        private Value<decimal?> _cobProjectedIncomeProjectedBonuses;
        public decimal? CobProjectedIncomeProjectedBonuses { get { return _cobProjectedIncomeProjectedBonuses; } set { _cobProjectedIncomeProjectedBonuses = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobProjectedIncomeProjectedBonuses() => !_cobProjectedIncomeProjectedBonuses.Clean;
        private Value<decimal?> _cobProjectedIncomeProjectedCostLivingAdjustment;
        public decimal? CobProjectedIncomeProjectedCostLivingAdjustment { get { return _cobProjectedIncomeProjectedCostLivingAdjustment; } set { _cobProjectedIncomeProjectedCostLivingAdjustment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobProjectedIncomeProjectedCostLivingAdjustment() => !_cobProjectedIncomeProjectedCostLivingAdjustment.Clean;
        private Value<decimal?> _cobProjectedIncomeProjectedNewJobIncome;
        public decimal? CobProjectedIncomeProjectedNewJobIncome { get { return _cobProjectedIncomeProjectedNewJobIncome; } set { _cobProjectedIncomeProjectedNewJobIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobProjectedIncomeProjectedNewJobIncome() => !_cobProjectedIncomeProjectedNewJobIncome.Clean;
        private Value<decimal?> _cobProjectedIncomeProjectedPerformanceRaises;
        public decimal? CobProjectedIncomeProjectedPerformanceRaises { get { return _cobProjectedIncomeProjectedPerformanceRaises; } set { _cobProjectedIncomeProjectedPerformanceRaises = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobProjectedIncomeProjectedPerformanceRaises() => !_cobProjectedIncomeProjectedPerformanceRaises.Clean;
        private Value<decimal?> _cobProjectedIncomeTotalProjectedIncome;
        public decimal? CobProjectedIncomeTotalProjectedIncome { get { return _cobProjectedIncomeTotalProjectedIncome; } set { _cobProjectedIncomeTotalProjectedIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCobProjectedIncomeTotalProjectedIncome() => !_cobProjectedIncomeTotalProjectedIncome.Clean;
        private Value<string> _dUCaseIDorLPAUSKey;
        public string DUCaseIDorLPAUSKey { get { return _dUCaseIDorLPAUSKey; } set { _dUCaseIDorLPAUSKey = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDUCaseIDorLPAUSKey() => !_dUCaseIDorLPAUSKey.Clean;
        private Value<DateTime?> _firstSubmissionDate;
        public DateTime? FirstSubmissionDate { get { return _firstSubmissionDate; } set { _firstSubmissionDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstSubmissionDate() => !_firstSubmissionDate.Clean;
        private Value<string> _firstSubmissionTime;
        public string FirstSubmissionTime { get { return _firstSubmissionTime; } set { _firstSubmissionTime = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstSubmissionTime() => !_firstSubmissionTime.Clean;
        private Value<string> _freddieDocClass;
        public string FreddieDocClass { get { return _freddieDocClass; } set { _freddieDocClass = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDocClass() => !_freddieDocClass.Clean;
        private Value<decimal?> _housingRatio;
        public decimal? HousingRatio { get { return _housingRatio; } set { _housingRatio = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHousingRatio() => !_housingRatio.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<bool?> _isEmpty;
        public bool? IsEmpty { get { return _isEmpty; } set { _isEmpty = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEmpty() => !_isEmpty.Clean;
        private Value<DateTime?> _submissionDate;
        public DateTime? SubmissionDate { get { return _submissionDate; } set { _submissionDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmissionDate() => !_submissionDate.Clean;
        private Value<string> _submissionNumber;
        public string SubmissionNumber { get { return _submissionNumber; } set { _submissionNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmissionNumber() => !_submissionNumber.Clean;
        private Value<string> _submissionTime;
        public string SubmissionTime { get { return _submissionTime; } set { _submissionTime = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmissionTime() => !_submissionTime.Clean;
        private Value<string> _submittedBy;
        public string SubmittedBy { get { return _submittedBy; } set { _submittedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittedBy() => !_submittedBy.Clean;
        private Value<decimal?> _totalExpenseRatio;
        public decimal? TotalExpenseRatio { get { return _totalExpenseRatio; } set { _totalExpenseRatio = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalExpenseRatio() => !_totalExpenseRatio.Clean;
        private Value<decimal?> _totalHousingPayment;
        public decimal? TotalHousingPayment { get { return _totalHousingPayment; } set { _totalHousingPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalHousingPayment() => !_totalHousingPayment.Clean;
        private Value<decimal?> _totalMonthlyAssets;
        public decimal? TotalMonthlyAssets { get { return _totalMonthlyAssets; } set { _totalMonthlyAssets = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMonthlyAssets() => !_totalMonthlyAssets.Clean;
        private Value<decimal?> _totalMonthlyDebt;
        public decimal? TotalMonthlyDebt { get { return _totalMonthlyDebt; } set { _totalMonthlyDebt = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMonthlyDebt() => !_totalMonthlyDebt.Clean;
        private Value<decimal?> _totalMonthlyIncome;
        public decimal? TotalMonthlyIncome { get { return _totalMonthlyIncome; } set { _totalMonthlyIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMonthlyIncome() => !_totalMonthlyIncome.Clean;
        private Value<string> _underwritingRiskAssessOther;
        public string UnderwritingRiskAssessOther { get { return _underwritingRiskAssessOther; } set { _underwritingRiskAssessOther = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingRiskAssessOther() => !_underwritingRiskAssessOther.Clean;
        private Value<string> _underwritingRiskAssessType;
        public string UnderwritingRiskAssessType { get { return _underwritingRiskAssessType; } set { _underwritingRiskAssessType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingRiskAssessType() => !_underwritingRiskAssessType.Clean;
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
                var v0 = _aTRQMBorrowerIndex; v0.Clean = value; _aTRQMBorrowerIndex = v0;
                var v1 = _aUSRecommendation; v1.Clean = value; _aUSRecommendation = v1;
                var v2 = _aUSVersion; v2.Clean = value; _aUSVersion = v2;
                var v3 = _borBonusAverageOvertime; v3.Clean = value; _borBonusAverageOvertime = v3;
                var v4 = _borBonusMostRecentAmount; v4.Clean = value; _borBonusMostRecentAmount = v4;
                var v5 = _borBonusMostRecentMonths; v5.Clean = value; _borBonusMostRecentMonths = v5;
                var v6 = _borBonusMostRecentYear; v6.Clean = value; _borBonusMostRecentYear = v6;
                var v7 = _borBonusPreviousAmount1; v7.Clean = value; _borBonusPreviousAmount1 = v7;
                var v8 = _borBonusPreviousAmount2; v8.Clean = value; _borBonusPreviousAmount2 = v8;
                var v9 = _borBonusPreviousMonths1; v9.Clean = value; _borBonusPreviousMonths1 = v9;
                var v10 = _borBonusPreviousMonths2; v10.Clean = value; _borBonusPreviousMonths2 = v10;
                var v11 = _borBonusPreviousYear1; v11.Clean = value; _borBonusPreviousYear1 = v11;
                var v12 = _borBonusPreviousYear2; v12.Clean = value; _borBonusPreviousYear2 = v12;
                var v13 = _borCommissionAverageOvertime; v13.Clean = value; _borCommissionAverageOvertime = v13;
                var v14 = _borCommissionMostRecentAmount; v14.Clean = value; _borCommissionMostRecentAmount = v14;
                var v15 = _borCommissionMostRecentMonths; v15.Clean = value; _borCommissionMostRecentMonths = v15;
                var v16 = _borCommissionMostRecentYear; v16.Clean = value; _borCommissionMostRecentYear = v16;
                var v17 = _borCommissionPreviousAmount1; v17.Clean = value; _borCommissionPreviousAmount1 = v17;
                var v18 = _borCommissionPreviousAmount2; v18.Clean = value; _borCommissionPreviousAmount2 = v18;
                var v19 = _borCommissionPreviousMonths1; v19.Clean = value; _borCommissionPreviousMonths1 = v19;
                var v20 = _borCommissionPreviousMonths2; v20.Clean = value; _borCommissionPreviousMonths2 = v20;
                var v21 = _borCommissionPreviousYear1; v21.Clean = value; _borCommissionPreviousYear1 = v21;
                var v22 = _borCommissionPreviousYear2; v22.Clean = value; _borCommissionPreviousYear2 = v22;
                var v23 = _borContingentLiabilitiesLiabilityAmount1; v23.Clean = value; _borContingentLiabilitiesLiabilityAmount1 = v23;
                var v24 = _borContingentLiabilitiesLiabilityAmount2; v24.Clean = value; _borContingentLiabilitiesLiabilityAmount2 = v24;
                var v25 = _borContingentLiabilitiesLiabilityAmount3; v25.Clean = value; _borContingentLiabilitiesLiabilityAmount3 = v25;
                var v26 = _borContingentLiabilitiesLiabilityDescription1; v26.Clean = value; _borContingentLiabilitiesLiabilityDescription1 = v26;
                var v27 = _borContingentLiabilitiesLiabilityDescription2; v27.Clean = value; _borContingentLiabilitiesLiabilityDescription2 = v27;
                var v28 = _borContingentLiabilitiesLiabilityDescription3; v28.Clean = value; _borContingentLiabilitiesLiabilityDescription3 = v28;
                var v29 = _borContingentLiabilitiesTotalLiabilityAmount; v29.Clean = value; _borContingentLiabilitiesTotalLiabilityAmount = v29;
                var v30 = _borCosignedObligationsCarLoanPayment; v30.Clean = value; _borCosignedObligationsCarLoanPayment = v30;
                var v31 = _borCosignedObligationsMortgagePayment; v31.Clean = value; _borCosignedObligationsMortgagePayment = v31;
                var v32 = _borCosignedObligationsOtherPayment; v32.Clean = value; _borCosignedObligationsOtherPayment = v32;
                var v33 = _borCosignedObligationsOtherPaymentDescription; v33.Clean = value; _borCosignedObligationsOtherPaymentDescription = v33;
                var v34 = _borCosignedObligationsStudentLoanPayment; v34.Clean = value; _borCosignedObligationsStudentLoanPayment = v34;
                var v35 = _borCosignedObligationsTotalCoMortgagorLiabilities; v35.Clean = value; _borCosignedObligationsTotalCoMortgagorLiabilities = v35;
                var v36 = _borDividendAverageDividend; v36.Clean = value; _borDividendAverageDividend = v36;
                var v37 = _borDividendPreviousAmount1; v37.Clean = value; _borDividendPreviousAmount1 = v37;
                var v38 = _borDividendPreviousAmount2; v38.Clean = value; _borDividendPreviousAmount2 = v38;
                var v39 = _borDividendPreviousMonths1; v39.Clean = value; _borDividendPreviousMonths1 = v39;
                var v40 = _borDividendPreviousMonths2; v40.Clean = value; _borDividendPreviousMonths2 = v40;
                var v41 = _borDividendPreviousYear1; v41.Clean = value; _borDividendPreviousYear1 = v41;
                var v42 = _borDividendPreviousYear2; v42.Clean = value; _borDividendPreviousYear2 = v42;
                var v43 = _borDividendRequiredForCashAmount; v43.Clean = value; _borDividendRequiredForCashAmount = v43;
                var v44 = _borInterestAverageDividend; v44.Clean = value; _borInterestAverageDividend = v44;
                var v45 = _borInterestPreviousAmount1; v45.Clean = value; _borInterestPreviousAmount1 = v45;
                var v46 = _borInterestPreviousAmount2; v46.Clean = value; _borInterestPreviousAmount2 = v46;
                var v47 = _borInterestPreviousMonths1; v47.Clean = value; _borInterestPreviousMonths1 = v47;
                var v48 = _borInterestPreviousMonths2; v48.Clean = value; _borInterestPreviousMonths2 = v48;
                var v49 = _borInterestPreviousYear1; v49.Clean = value; _borInterestPreviousYear1 = v49;
                var v50 = _borInterestPreviousYear2; v50.Clean = value; _borInterestPreviousYear2 = v50;
                var v51 = _borInterestRequiredForCashAmount; v51.Clean = value; _borInterestRequiredForCashAmount = v51;
                var v52 = _borMilitaryAllowanceClothingAllowance; v52.Clean = value; _borMilitaryAllowanceClothingAllowance = v52;
                var v53 = _borMilitaryAllowanceOtherAllowance; v53.Clean = value; _borMilitaryAllowanceOtherAllowance = v53;
                var v54 = _borMilitaryAllowanceOtherAllowanceDescription; v54.Clean = value; _borMilitaryAllowanceOtherAllowanceDescription = v54;
                var v55 = _borMilitaryAllowanceQuartersAllowance; v55.Clean = value; _borMilitaryAllowanceQuartersAllowance = v55;
                var v56 = _borMilitaryAllowanceRationsAllowance; v56.Clean = value; _borMilitaryAllowanceRationsAllowance = v56;
                var v57 = _borMilitaryAllowanceTotalAllowance; v57.Clean = value; _borMilitaryAllowanceTotalAllowance = v57;
                var v58 = _borMilitaryAllowanceVariableHousingAllowance; v58.Clean = value; _borMilitaryAllowanceVariableHousingAllowance = v58;
                var v59 = _borMilitaryBasePay; v59.Clean = value; _borMilitaryBasePay = v59;
                var v60 = _borMilitaryCombatPay; v60.Clean = value; _borMilitaryCombatPay = v60;
                var v61 = _borMilitaryFlightPay; v61.Clean = value; _borMilitaryFlightPay = v61;
                var v62 = _borMilitaryHazardPay; v62.Clean = value; _borMilitaryHazardPay = v62;
                var v63 = _borMilitaryOverseasPay; v63.Clean = value; _borMilitaryOverseasPay = v63;
                var v64 = _borMilitaryPropPay; v64.Clean = value; _borMilitaryPropPay = v64;
                var v65 = _borMilitaryTotalPay; v65.Clean = value; _borMilitaryTotalPay = v65;
                var v66 = _borMonthlyEmplymentIncomeBaseIncome; v66.Clean = value; _borMonthlyEmplymentIncomeBaseIncome = v66;
                var v67 = _borMonthlyEmplymentIncomeBonuseIncome; v67.Clean = value; _borMonthlyEmplymentIncomeBonuseIncome = v67;
                var v68 = _borMonthlyEmplymentIncomeCommissionIncome; v68.Clean = value; _borMonthlyEmplymentIncomeCommissionIncome = v68;
                var v69 = _borMonthlyEmplymentIncomeDividendInterestIncome; v69.Clean = value; _borMonthlyEmplymentIncomeDividendInterestIncome = v69;
                var v70 = _borMonthlyEmplymentIncomeOtherIncome1; v70.Clean = value; _borMonthlyEmplymentIncomeOtherIncome1 = v70;
                var v71 = _borMonthlyEmplymentIncomeOtherIncome2; v71.Clean = value; _borMonthlyEmplymentIncomeOtherIncome2 = v71;
                var v72 = _borMonthlyEmplymentIncomeOvertimeIncome; v72.Clean = value; _borMonthlyEmplymentIncomeOvertimeIncome = v72;
                var v73 = _borMonthlyEmplymentIncomeTotalEmploymentIncome; v73.Clean = value; _borMonthlyEmplymentIncomeTotalEmploymentIncome = v73;
                var v74 = _borNonEmploymentIncomeGovtAssitProgramIncome; v74.Clean = value; _borNonEmploymentIncomeGovtAssitProgramIncome = v74;
                var v75 = _borNonEmploymentIncomeHomeownSubsidyIncome; v75.Clean = value; _borNonEmploymentIncomeHomeownSubsidyIncome = v75;
                var v76 = _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome; v76.Clean = value; _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome = v76;
                var v77 = _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome; v77.Clean = value; _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome = v77;
                var v78 = _borNonEmploymentIncomeMilitaryIncome; v78.Clean = value; _borNonEmploymentIncomeMilitaryIncome = v78;
                var v79 = _borNonEmploymentIncomeMtgCreditCertificateIncome; v79.Clean = value; _borNonEmploymentIncomeMtgCreditCertificateIncome = v79;
                var v80 = _borNonEmploymentIncomeTotalNonEmploymentIncome; v80.Clean = value; _borNonEmploymentIncomeTotalNonEmploymentIncome = v80;
                var v81 = _borNonEmploymentIncomeVABenefitIncome; v81.Clean = value; _borNonEmploymentIncomeVABenefitIncome = v81;
                var v82 = _borNonTaxableIncomeChildSupportIncome; v82.Clean = value; _borNonTaxableIncomeChildSupportIncome = v82;
                var v83 = _borNonTaxableIncomeDisabilityIncome; v83.Clean = value; _borNonTaxableIncomeDisabilityIncome = v83;
                var v84 = _borNonTaxableIncomeFedGovtEmplRetirementIncome; v84.Clean = value; _borNonTaxableIncomeFedGovtEmplRetirementIncome = v84;
                var v85 = _borNonTaxableIncomeMilitaryAllowances; v85.Clean = value; _borNonTaxableIncomeMilitaryAllowances = v85;
                var v86 = _borNonTaxableIncomeOtherIncome; v86.Clean = value; _borNonTaxableIncomeOtherIncome = v86;
                var v87 = _borNonTaxableIncomePublicAssistPayments; v87.Clean = value; _borNonTaxableIncomePublicAssistPayments = v87;
                var v88 = _borNonTaxableIncomeRailroadRetirementBenefits; v88.Clean = value; _borNonTaxableIncomeRailroadRetirementBenefits = v88;
                var v89 = _borNonTaxableIncomeSocialSecurityIncome; v89.Clean = value; _borNonTaxableIncomeSocialSecurityIncome = v89;
                var v90 = _borNonTaxableIncomeStateGovtEmplRetirementIncome; v90.Clean = value; _borNonTaxableIncomeStateGovtEmplRetirementIncome = v90;
                var v91 = _borNonTaxableIncomeTotalNonTaxableIncome; v91.Clean = value; _borNonTaxableIncomeTotalNonTaxableIncome = v91;
                var v92 = _borOtherNotesReceivableIncome; v92.Clean = value; _borOtherNotesReceivableIncome = v92;
                var v93 = _borOtherOtherIncome; v93.Clean = value; _borOtherOtherIncome = v93;
                var v94 = _borOtherParttimeIncome; v94.Clean = value; _borOtherParttimeIncome = v94;
                var v95 = _borOtherRetirementIncome; v95.Clean = value; _borOtherRetirementIncome = v95;
                var v96 = _borOtherSeasonalIncome; v96.Clean = value; _borOtherSeasonalIncome = v96;
                var v97 = _borOtherSocialSecurityIncome; v97.Clean = value; _borOtherSocialSecurityIncome = v97;
                var v98 = _borOtherTipIncome; v98.Clean = value; _borOtherTipIncome = v98;
                var v99 = _borOtherTrustIncome; v99.Clean = value; _borOtherTrustIncome = v99;
                var v100 = _borOtherUnemploymentIncome; v100.Clean = value; _borOtherUnemploymentIncome = v100;
                var v101 = _borOvertimeAverageOvertime; v101.Clean = value; _borOvertimeAverageOvertime = v101;
                var v102 = _borOvertimeMostRecentAmount; v102.Clean = value; _borOvertimeMostRecentAmount = v102;
                var v103 = _borOvertimeMostRecentMonths; v103.Clean = value; _borOvertimeMostRecentMonths = v103;
                var v104 = _borOvertimeMostRecentYear; v104.Clean = value; _borOvertimeMostRecentYear = v104;
                var v105 = _borOvertimePreviousAmount1; v105.Clean = value; _borOvertimePreviousAmount1 = v105;
                var v106 = _borOvertimePreviousAmount2; v106.Clean = value; _borOvertimePreviousAmount2 = v106;
                var v107 = _borOvertimePreviousMonths1; v107.Clean = value; _borOvertimePreviousMonths1 = v107;
                var v108 = _borOvertimePreviousMonths2; v108.Clean = value; _borOvertimePreviousMonths2 = v108;
                var v109 = _borOvertimePreviousYear1; v109.Clean = value; _borOvertimePreviousYear1 = v109;
                var v110 = _borOvertimePreviousYear2; v110.Clean = value; _borOvertimePreviousYear2 = v110;
                var v111 = _borProjectedIncomeProjectedBonuses; v111.Clean = value; _borProjectedIncomeProjectedBonuses = v111;
                var v112 = _borProjectedIncomeProjectedCostLivingAdjustment; v112.Clean = value; _borProjectedIncomeProjectedCostLivingAdjustment = v112;
                var v113 = _borProjectedIncomeProjectedNewJobIncome; v113.Clean = value; _borProjectedIncomeProjectedNewJobIncome = v113;
                var v114 = _borProjectedIncomeProjectedPerformanceRaises; v114.Clean = value; _borProjectedIncomeProjectedPerformanceRaises = v114;
                var v115 = _borProjectedIncomeTotalProjectedIncome; v115.Clean = value; _borProjectedIncomeTotalProjectedIncome = v115;
                var v116 = _cobBonusAverageOvertime; v116.Clean = value; _cobBonusAverageOvertime = v116;
                var v117 = _cobBonusMostRecentAmount; v117.Clean = value; _cobBonusMostRecentAmount = v117;
                var v118 = _cobBonusMostRecentMonths; v118.Clean = value; _cobBonusMostRecentMonths = v118;
                var v119 = _cobBonusMostRecentYear; v119.Clean = value; _cobBonusMostRecentYear = v119;
                var v120 = _cobBonusPreviousAmount1; v120.Clean = value; _cobBonusPreviousAmount1 = v120;
                var v121 = _cobBonusPreviousAmount2; v121.Clean = value; _cobBonusPreviousAmount2 = v121;
                var v122 = _cobBonusPreviousMonths1; v122.Clean = value; _cobBonusPreviousMonths1 = v122;
                var v123 = _cobBonusPreviousMonths2; v123.Clean = value; _cobBonusPreviousMonths2 = v123;
                var v124 = _cobBonusPreviousYear1; v124.Clean = value; _cobBonusPreviousYear1 = v124;
                var v125 = _cobBonusPreviousYear2; v125.Clean = value; _cobBonusPreviousYear2 = v125;
                var v126 = _cobCommissionAverageOvertime; v126.Clean = value; _cobCommissionAverageOvertime = v126;
                var v127 = _cobCommissionMostRecentAmount; v127.Clean = value; _cobCommissionMostRecentAmount = v127;
                var v128 = _cobCommissionMostRecentMonths; v128.Clean = value; _cobCommissionMostRecentMonths = v128;
                var v129 = _cobCommissionMostRecentYear; v129.Clean = value; _cobCommissionMostRecentYear = v129;
                var v130 = _cobCommissionPreviousAmount1; v130.Clean = value; _cobCommissionPreviousAmount1 = v130;
                var v131 = _cobCommissionPreviousAmount2; v131.Clean = value; _cobCommissionPreviousAmount2 = v131;
                var v132 = _cobCommissionPreviousMonths1; v132.Clean = value; _cobCommissionPreviousMonths1 = v132;
                var v133 = _cobCommissionPreviousMonths2; v133.Clean = value; _cobCommissionPreviousMonths2 = v133;
                var v134 = _cobCommissionPreviousYear1; v134.Clean = value; _cobCommissionPreviousYear1 = v134;
                var v135 = _cobCommissionPreviousYear2; v135.Clean = value; _cobCommissionPreviousYear2 = v135;
                var v136 = _cobDividendAverageDividend; v136.Clean = value; _cobDividendAverageDividend = v136;
                var v137 = _cobDividendPreviousAmount1; v137.Clean = value; _cobDividendPreviousAmount1 = v137;
                var v138 = _cobDividendPreviousAmount2; v138.Clean = value; _cobDividendPreviousAmount2 = v138;
                var v139 = _cobDividendPreviousMonths1; v139.Clean = value; _cobDividendPreviousMonths1 = v139;
                var v140 = _cobDividendPreviousMonths2; v140.Clean = value; _cobDividendPreviousMonths2 = v140;
                var v141 = _cobDividendPreviousYear1; v141.Clean = value; _cobDividendPreviousYear1 = v141;
                var v142 = _cobDividendPreviousYear2; v142.Clean = value; _cobDividendPreviousYear2 = v142;
                var v143 = _cobDividendRequiredForCashAmount; v143.Clean = value; _cobDividendRequiredForCashAmount = v143;
                var v144 = _cobInterestAverageDividend; v144.Clean = value; _cobInterestAverageDividend = v144;
                var v145 = _cobInterestPreviousAmount1; v145.Clean = value; _cobInterestPreviousAmount1 = v145;
                var v146 = _cobInterestPreviousAmount2; v146.Clean = value; _cobInterestPreviousAmount2 = v146;
                var v147 = _cobInterestPreviousMonths1; v147.Clean = value; _cobInterestPreviousMonths1 = v147;
                var v148 = _cobInterestPreviousMonths2; v148.Clean = value; _cobInterestPreviousMonths2 = v148;
                var v149 = _cobInterestPreviousYear1; v149.Clean = value; _cobInterestPreviousYear1 = v149;
                var v150 = _cobInterestPreviousYear2; v150.Clean = value; _cobInterestPreviousYear2 = v150;
                var v151 = _cobInterestRequiredForCashAmount; v151.Clean = value; _cobInterestRequiredForCashAmount = v151;
                var v152 = _cobMilitaryAllowanceClothingAllowance; v152.Clean = value; _cobMilitaryAllowanceClothingAllowance = v152;
                var v153 = _cobMilitaryAllowanceOtherAllowance; v153.Clean = value; _cobMilitaryAllowanceOtherAllowance = v153;
                var v154 = _cobMilitaryAllowanceQuartersAllowance; v154.Clean = value; _cobMilitaryAllowanceQuartersAllowance = v154;
                var v155 = _cobMilitaryAllowanceRationsAllowance; v155.Clean = value; _cobMilitaryAllowanceRationsAllowance = v155;
                var v156 = _cobMilitaryAllowanceTotalAllowance; v156.Clean = value; _cobMilitaryAllowanceTotalAllowance = v156;
                var v157 = _cobMilitaryAllowanceVariableHousingAllowance; v157.Clean = value; _cobMilitaryAllowanceVariableHousingAllowance = v157;
                var v158 = _cobMilitaryBasePay; v158.Clean = value; _cobMilitaryBasePay = v158;
                var v159 = _cobMilitaryCombatPay; v159.Clean = value; _cobMilitaryCombatPay = v159;
                var v160 = _cobMilitaryFlightPay; v160.Clean = value; _cobMilitaryFlightPay = v160;
                var v161 = _cobMilitaryHazardPay; v161.Clean = value; _cobMilitaryHazardPay = v161;
                var v162 = _cobMilitaryOverseasPay; v162.Clean = value; _cobMilitaryOverseasPay = v162;
                var v163 = _cobMilitaryPropPay; v163.Clean = value; _cobMilitaryPropPay = v163;
                var v164 = _cobMilitaryTotalPay; v164.Clean = value; _cobMilitaryTotalPay = v164;
                var v165 = _cobMonthlyEmplymentIncomeBaseIncome; v165.Clean = value; _cobMonthlyEmplymentIncomeBaseIncome = v165;
                var v166 = _cobMonthlyEmplymentIncomeBonuseIncome; v166.Clean = value; _cobMonthlyEmplymentIncomeBonuseIncome = v166;
                var v167 = _cobMonthlyEmplymentIncomeCommissionIncome; v167.Clean = value; _cobMonthlyEmplymentIncomeCommissionIncome = v167;
                var v168 = _cobMonthlyEmplymentIncomeDividendInterestIncome; v168.Clean = value; _cobMonthlyEmplymentIncomeDividendInterestIncome = v168;
                var v169 = _cobMonthlyEmplymentIncomeOtherIncome1; v169.Clean = value; _cobMonthlyEmplymentIncomeOtherIncome1 = v169;
                var v170 = _cobMonthlyEmplymentIncomeOtherIncome2; v170.Clean = value; _cobMonthlyEmplymentIncomeOtherIncome2 = v170;
                var v171 = _cobMonthlyEmplymentIncomeOvertimeIncome; v171.Clean = value; _cobMonthlyEmplymentIncomeOvertimeIncome = v171;
                var v172 = _cobMonthlyEmplymentIncomeTotalEmploymentIncome; v172.Clean = value; _cobMonthlyEmplymentIncomeTotalEmploymentIncome = v172;
                var v173 = _cobNonEmploymentIncomeGovtAssitProgramIncome; v173.Clean = value; _cobNonEmploymentIncomeGovtAssitProgramIncome = v173;
                var v174 = _cobNonEmploymentIncomeHomeownSubsidyIncome; v174.Clean = value; _cobNonEmploymentIncomeHomeownSubsidyIncome = v174;
                var v175 = _cobNonEmploymentIncomeMilitaryIncome; v175.Clean = value; _cobNonEmploymentIncomeMilitaryIncome = v175;
                var v176 = _cobNonEmploymentIncomeMtgCreditCertificateIncome; v176.Clean = value; _cobNonEmploymentIncomeMtgCreditCertificateIncome = v176;
                var v177 = _cobNonEmploymentIncomeTotalNonEmploymentIncome; v177.Clean = value; _cobNonEmploymentIncomeTotalNonEmploymentIncome = v177;
                var v178 = _cobNonEmploymentIncomeVABenefitIncome; v178.Clean = value; _cobNonEmploymentIncomeVABenefitIncome = v178;
                var v179 = _cobNonTaxableIncomeChildSupportIncome; v179.Clean = value; _cobNonTaxableIncomeChildSupportIncome = v179;
                var v180 = _cobNonTaxableIncomeDisabilityIncome; v180.Clean = value; _cobNonTaxableIncomeDisabilityIncome = v180;
                var v181 = _cobNonTaxableIncomeFedGovtEmplRetirementIncome; v181.Clean = value; _cobNonTaxableIncomeFedGovtEmplRetirementIncome = v181;
                var v182 = _cobNonTaxableIncomeMilitaryAllowances; v182.Clean = value; _cobNonTaxableIncomeMilitaryAllowances = v182;
                var v183 = _cobNonTaxableIncomeOtherIncome; v183.Clean = value; _cobNonTaxableIncomeOtherIncome = v183;
                var v184 = _cobNonTaxableIncomePublicAssistPayments; v184.Clean = value; _cobNonTaxableIncomePublicAssistPayments = v184;
                var v185 = _cobNonTaxableIncomeRailroadRetirementBenefits; v185.Clean = value; _cobNonTaxableIncomeRailroadRetirementBenefits = v185;
                var v186 = _cobNonTaxableIncomeSocialSecurityIncome; v186.Clean = value; _cobNonTaxableIncomeSocialSecurityIncome = v186;
                var v187 = _cobNonTaxableIncomeStateGovtEmplRetirementIncome; v187.Clean = value; _cobNonTaxableIncomeStateGovtEmplRetirementIncome = v187;
                var v188 = _cobNonTaxableIncomeTotalNonTaxableIncome; v188.Clean = value; _cobNonTaxableIncomeTotalNonTaxableIncome = v188;
                var v189 = _cobOtherNotesReceivableIncome; v189.Clean = value; _cobOtherNotesReceivableIncome = v189;
                var v190 = _cobOtherOtherIncome; v190.Clean = value; _cobOtherOtherIncome = v190;
                var v191 = _cobOtherParttimeIncome; v191.Clean = value; _cobOtherParttimeIncome = v191;
                var v192 = _cobOtherRetirementIncome; v192.Clean = value; _cobOtherRetirementIncome = v192;
                var v193 = _cobOtherSeasonalIncome; v193.Clean = value; _cobOtherSeasonalIncome = v193;
                var v194 = _cobOtherSocialSecurityIncome; v194.Clean = value; _cobOtherSocialSecurityIncome = v194;
                var v195 = _cobOtherTipIncome; v195.Clean = value; _cobOtherTipIncome = v195;
                var v196 = _cobOtherTrustIncome; v196.Clean = value; _cobOtherTrustIncome = v196;
                var v197 = _cobOtherUnemploymentIncome; v197.Clean = value; _cobOtherUnemploymentIncome = v197;
                var v198 = _cobOvertimeAverageOvertime; v198.Clean = value; _cobOvertimeAverageOvertime = v198;
                var v199 = _cobOvertimeMostRecentAmount; v199.Clean = value; _cobOvertimeMostRecentAmount = v199;
                var v200 = _cobOvertimeMostRecentMonths; v200.Clean = value; _cobOvertimeMostRecentMonths = v200;
                var v201 = _cobOvertimeMostRecentYear; v201.Clean = value; _cobOvertimeMostRecentYear = v201;
                var v202 = _cobOvertimePreviousAmount1; v202.Clean = value; _cobOvertimePreviousAmount1 = v202;
                var v203 = _cobOvertimePreviousAmount2; v203.Clean = value; _cobOvertimePreviousAmount2 = v203;
                var v204 = _cobOvertimePreviousMonths1; v204.Clean = value; _cobOvertimePreviousMonths1 = v204;
                var v205 = _cobOvertimePreviousMonths2; v205.Clean = value; _cobOvertimePreviousMonths2 = v205;
                var v206 = _cobOvertimePreviousYear1; v206.Clean = value; _cobOvertimePreviousYear1 = v206;
                var v207 = _cobOvertimePreviousYear2; v207.Clean = value; _cobOvertimePreviousYear2 = v207;
                var v208 = _cobProjectedIncomeProjectedBonuses; v208.Clean = value; _cobProjectedIncomeProjectedBonuses = v208;
                var v209 = _cobProjectedIncomeProjectedCostLivingAdjustment; v209.Clean = value; _cobProjectedIncomeProjectedCostLivingAdjustment = v209;
                var v210 = _cobProjectedIncomeProjectedNewJobIncome; v210.Clean = value; _cobProjectedIncomeProjectedNewJobIncome = v210;
                var v211 = _cobProjectedIncomeProjectedPerformanceRaises; v211.Clean = value; _cobProjectedIncomeProjectedPerformanceRaises = v211;
                var v212 = _cobProjectedIncomeTotalProjectedIncome; v212.Clean = value; _cobProjectedIncomeTotalProjectedIncome = v212;
                var v213 = _dUCaseIDorLPAUSKey; v213.Clean = value; _dUCaseIDorLPAUSKey = v213;
                var v214 = _firstSubmissionDate; v214.Clean = value; _firstSubmissionDate = v214;
                var v215 = _firstSubmissionTime; v215.Clean = value; _firstSubmissionTime = v215;
                var v216 = _freddieDocClass; v216.Clean = value; _freddieDocClass = v216;
                var v217 = _housingRatio; v217.Clean = value; _housingRatio = v217;
                var v218 = _id; v218.Clean = value; _id = v218;
                var v219 = _isEmpty; v219.Clean = value; _isEmpty = v219;
                var v220 = _submissionDate; v220.Clean = value; _submissionDate = v220;
                var v221 = _submissionNumber; v221.Clean = value; _submissionNumber = v221;
                var v222 = _submissionTime; v222.Clean = value; _submissionTime = v222;
                var v223 = _submittedBy; v223.Clean = value; _submittedBy = v223;
                var v224 = _totalExpenseRatio; v224.Clean = value; _totalExpenseRatio = v224;
                var v225 = _totalHousingPayment; v225.Clean = value; _totalHousingPayment = v225;
                var v226 = _totalMonthlyAssets; v226.Clean = value; _totalMonthlyAssets = v226;
                var v227 = _totalMonthlyDebt; v227.Clean = value; _totalMonthlyDebt = v227;
                var v228 = _totalMonthlyIncome; v228.Clean = value; _totalMonthlyIncome = v228;
                var v229 = _underwritingRiskAssessOther; v229.Clean = value; _underwritingRiskAssessOther = v229;
                var v230 = _underwritingRiskAssessType; v230.Clean = value; _underwritingRiskAssessType = v230;
                _settingClean = 0;
            }
        }
    }
}