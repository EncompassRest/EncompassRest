using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Prequalification
    {
        public Value<decimal?> AfterTaxOwnMoSavings { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAfterTaxOwnMoSavings() => !AfterTaxOwnMoSavings.Clean;
        public Value<decimal?> AfterTaxRentMoSavings { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAfterTaxRentMoSavings() => !AfterTaxRentMoSavings.Clean;
        public Value<decimal?> AnnualHomeMaintenance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualHomeMaintenance() => !AnnualHomeMaintenance.Clean;
        public Value<decimal?> AvgMoPmtSavings { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAvgMoPmtSavings() => !AvgMoPmtSavings.Clean;
        public Value<decimal?> BeforeTaxOwnMoPmt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBeforeTaxOwnMoPmt() => !BeforeTaxOwnMoPmt.Clean;
        public Value<decimal?> BeforeTaxRentMoPmt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBeforeTaxRentMoPmt() => !BeforeTaxRentMoPmt.Clean;
        public Value<int?> CashOutBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCashOutBalance() => !CashOutBalance.Clean;
        public Value<decimal?> CombinedGain { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCombinedGain() => !CombinedGain.Clean;
        public Value<decimal?> CostIncreasePerYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCostIncreasePerYear() => !CostIncreasePerYear.Clean;
        public Value<decimal?> DownPaymentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownPaymentAmount() => !DownPaymentAmount.Clean;
        public Value<string> FavorableOption { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFavorableOption() => !FavorableOption.Clean;
        public Value<decimal?> HomeSellingPriceAfterYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeSellingPriceAfterYears() => !HomeSellingPriceAfterYears.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> InvestmentGain { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestmentGain() => !InvestmentGain.Clean;
        public Value<decimal?> MaxLoanLimit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxLoanLimit() => !MaxLoanLimit.Clean;
        public Value<decimal?> MaxPropValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxPropValue() => !MaxPropValue.Clean;
        public Value<decimal?> MinusDownPmtAndClosingCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinusDownPmtAndClosingCosts() => !MinusDownPmtAndClosingCosts.Clean;
        public Value<decimal?> MinusLoanBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinusLoanBalance() => !MinusLoanBalance.Clean;
        public Value<decimal?> MonthlyBenefit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyBenefit() => !MonthlyBenefit.Clean;
        public Value<decimal?> MonthlyHomeAppreciation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyHomeAppreciation() => !MonthlyHomeAppreciation.Clean;
        public Value<decimal?> MonthlyHomeEquity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyHomeEquity() => !MonthlyHomeEquity.Clean;
        public Value<decimal?> MonthlyIncomeTax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyIncomeTax() => !MonthlyIncomeTax.Clean;
        public Value<decimal?> MonthlyInvestmentInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyInvestmentInterest() => !MonthlyInvestmentInterest.Clean;
        public Value<int?> MonthlySavings { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlySavings() => !MonthlySavings.Clean;
        public Value<string> NumberOfMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfMonths() => !NumberOfMonths.Clean;
        public Value<decimal?> PercentAnnualHomeMaint { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentAnnualHomeMaint() => !PercentAnnualHomeMaint.Clean;
        public Value<decimal?> PercentOfHomeAppreciation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentOfHomeAppreciation() => !PercentOfHomeAppreciation.Clean;
        public Value<decimal?> PercentOfIncomeTax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentOfIncomeTax() => !PercentOfIncomeTax.Clean;
        public Value<decimal?> PercentOfInvestmentInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentOfInvestmentInterest() => !PercentOfInvestmentInterest.Clean;
        public Value<List<PrequalificationScenario>> PrequalificationScenarios { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrequalificationScenarios() => !PrequalificationScenarios.Clean;
        public Value<string> QualificationStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeQualificationStatus() => !QualificationStatus.Clean;
        public Value<decimal?> RentalCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRentalCost() => !RentalCost.Clean;
        public Value<decimal?> RentersInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRentersInsurance() => !RentersInsurance.Clean;
        public Value<decimal?> TotalBenefit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBenefit() => !TotalBenefit.Clean;
        public Value<decimal?> TotalCashFlow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalCashFlow() => !TotalCashFlow.Clean;
        public Value<decimal?> TotalGain { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalGain() => !TotalGain.Clean;
        public Value<decimal?> TotalHomeAppreciation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalHomeAppreciation() => !TotalHomeAppreciation.Clean;
        public Value<decimal?> TotalHomeEquity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalHomeEquity() => !TotalHomeEquity.Clean;
        public Value<decimal?> TotalHousingExpense { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalHousingExpense() => !TotalHousingExpense.Clean;
        public Value<decimal?> TotalIncomeTax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalIncomeTax() => !TotalIncomeTax.Clean;
        public Value<decimal?> TotalInvestmentInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalInvestmentInterest() => !TotalInvestmentInterest.Clean;
        public Value<int?> TotalLiabilityPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalLiabilityPayment() => !TotalLiabilityPayment.Clean;
        public Value<int?> TotalLiabilityUnpaid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalLiabilityUnpaid() => !TotalLiabilityUnpaid.Clean;
        public Value<int?> TotalLoanSavings { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalLoanSavings() => !TotalLoanSavings.Clean;
        public Value<decimal?> TotalOtherExpenses { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOtherExpenses() => !TotalOtherExpenses.Clean;
        public Value<decimal?> TotalOwnPmtOverYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOwnPmtOverYears() => !TotalOwnPmtOverYears.Clean;
        public Value<decimal?> TotalOwnTaxSavings { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOwnTaxSavings() => !TotalOwnTaxSavings.Clean;
        public Value<int?> TotalPaidOffBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPaidOffBalance() => !TotalPaidOffBalance.Clean;
        public Value<int?> TotalPaidOffMonthly { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPaidOffMonthly() => !TotalPaidOffMonthly.Clean;
        public Value<decimal?> TotalPmtSavings { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPmtSavings() => !TotalPmtSavings.Clean;
        public Value<decimal?> TotalRentPmtOverYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalRentPmtOverYears() => !TotalRentPmtOverYears.Clean;
        public Value<string> WithinLimits1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWithinLimits1() => !WithinLimits1.Clean;
        public Value<string> WithinLimits2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWithinLimits2() => !WithinLimits2.Clean;
        public Value<string> WithinLimits3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWithinLimits3() => !WithinLimits3.Clean;
        public Value<string> WithinLimits4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWithinLimits4() => !WithinLimits4.Clean;
        public Value<string> WithinLimits5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWithinLimits5() => !WithinLimits5.Clean;
        public Value<string> WithinLimits6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWithinLimits6() => !WithinLimits6.Clean;
        public Value<string> WithinLimits7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWithinLimits7() => !WithinLimits7.Clean;
        public Value<string> WithinLimits8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWithinLimits8() => !WithinLimits8.Clean;
        public Value<string> WithinLimits9 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWithinLimits9() => !WithinLimits9.Clean;
        public Value<int?> YearsForComparison { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearsForComparison() => !YearsForComparison.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AfterTaxOwnMoSavings.Clean
                    && AfterTaxRentMoSavings.Clean
                    && AnnualHomeMaintenance.Clean
                    && AvgMoPmtSavings.Clean
                    && BeforeTaxOwnMoPmt.Clean
                    && BeforeTaxRentMoPmt.Clean
                    && CashOutBalance.Clean
                    && CombinedGain.Clean
                    && CostIncreasePerYear.Clean
                    && DownPaymentAmount.Clean
                    && FavorableOption.Clean
                    && HomeSellingPriceAfterYears.Clean
                    && Id.Clean
                    && InvestmentGain.Clean
                    && MaxLoanLimit.Clean
                    && MaxPropValue.Clean
                    && MinusDownPmtAndClosingCosts.Clean
                    && MinusLoanBalance.Clean
                    && MonthlyBenefit.Clean
                    && MonthlyHomeAppreciation.Clean
                    && MonthlyHomeEquity.Clean
                    && MonthlyIncomeTax.Clean
                    && MonthlyInvestmentInterest.Clean
                    && MonthlySavings.Clean
                    && NumberOfMonths.Clean
                    && PercentAnnualHomeMaint.Clean
                    && PercentOfHomeAppreciation.Clean
                    && PercentOfIncomeTax.Clean
                    && PercentOfInvestmentInterest.Clean
                    && PrequalificationScenarios.Clean
                    && QualificationStatus.Clean
                    && RentalCost.Clean
                    && RentersInsurance.Clean
                    && TotalBenefit.Clean
                    && TotalCashFlow.Clean
                    && TotalGain.Clean
                    && TotalHomeAppreciation.Clean
                    && TotalHomeEquity.Clean
                    && TotalHousingExpense.Clean
                    && TotalIncomeTax.Clean
                    && TotalInvestmentInterest.Clean
                    && TotalLiabilityPayment.Clean
                    && TotalLiabilityUnpaid.Clean
                    && TotalLoanSavings.Clean
                    && TotalOtherExpenses.Clean
                    && TotalOwnPmtOverYears.Clean
                    && TotalOwnTaxSavings.Clean
                    && TotalPaidOffBalance.Clean
                    && TotalPaidOffMonthly.Clean
                    && TotalPmtSavings.Clean
                    && TotalRentPmtOverYears.Clean
                    && WithinLimits1.Clean
                    && WithinLimits2.Clean
                    && WithinLimits3.Clean
                    && WithinLimits4.Clean
                    && WithinLimits5.Clean
                    && WithinLimits6.Clean
                    && WithinLimits7.Clean
                    && WithinLimits8.Clean
                    && WithinLimits9.Clean
                    && YearsForComparison.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AfterTaxOwnMoSavings; v0.Clean = value; AfterTaxOwnMoSavings = v0;
                var v1 = AfterTaxRentMoSavings; v1.Clean = value; AfterTaxRentMoSavings = v1;
                var v2 = AnnualHomeMaintenance; v2.Clean = value; AnnualHomeMaintenance = v2;
                var v3 = AvgMoPmtSavings; v3.Clean = value; AvgMoPmtSavings = v3;
                var v4 = BeforeTaxOwnMoPmt; v4.Clean = value; BeforeTaxOwnMoPmt = v4;
                var v5 = BeforeTaxRentMoPmt; v5.Clean = value; BeforeTaxRentMoPmt = v5;
                var v6 = CashOutBalance; v6.Clean = value; CashOutBalance = v6;
                var v7 = CombinedGain; v7.Clean = value; CombinedGain = v7;
                var v8 = CostIncreasePerYear; v8.Clean = value; CostIncreasePerYear = v8;
                var v9 = DownPaymentAmount; v9.Clean = value; DownPaymentAmount = v9;
                var v10 = FavorableOption; v10.Clean = value; FavorableOption = v10;
                var v11 = HomeSellingPriceAfterYears; v11.Clean = value; HomeSellingPriceAfterYears = v11;
                var v12 = Id; v12.Clean = value; Id = v12;
                var v13 = InvestmentGain; v13.Clean = value; InvestmentGain = v13;
                var v14 = MaxLoanLimit; v14.Clean = value; MaxLoanLimit = v14;
                var v15 = MaxPropValue; v15.Clean = value; MaxPropValue = v15;
                var v16 = MinusDownPmtAndClosingCosts; v16.Clean = value; MinusDownPmtAndClosingCosts = v16;
                var v17 = MinusLoanBalance; v17.Clean = value; MinusLoanBalance = v17;
                var v18 = MonthlyBenefit; v18.Clean = value; MonthlyBenefit = v18;
                var v19 = MonthlyHomeAppreciation; v19.Clean = value; MonthlyHomeAppreciation = v19;
                var v20 = MonthlyHomeEquity; v20.Clean = value; MonthlyHomeEquity = v20;
                var v21 = MonthlyIncomeTax; v21.Clean = value; MonthlyIncomeTax = v21;
                var v22 = MonthlyInvestmentInterest; v22.Clean = value; MonthlyInvestmentInterest = v22;
                var v23 = MonthlySavings; v23.Clean = value; MonthlySavings = v23;
                var v24 = NumberOfMonths; v24.Clean = value; NumberOfMonths = v24;
                var v25 = PercentAnnualHomeMaint; v25.Clean = value; PercentAnnualHomeMaint = v25;
                var v26 = PercentOfHomeAppreciation; v26.Clean = value; PercentOfHomeAppreciation = v26;
                var v27 = PercentOfIncomeTax; v27.Clean = value; PercentOfIncomeTax = v27;
                var v28 = PercentOfInvestmentInterest; v28.Clean = value; PercentOfInvestmentInterest = v28;
                var v29 = PrequalificationScenarios; v29.Clean = value; PrequalificationScenarios = v29;
                var v30 = QualificationStatus; v30.Clean = value; QualificationStatus = v30;
                var v31 = RentalCost; v31.Clean = value; RentalCost = v31;
                var v32 = RentersInsurance; v32.Clean = value; RentersInsurance = v32;
                var v33 = TotalBenefit; v33.Clean = value; TotalBenefit = v33;
                var v34 = TotalCashFlow; v34.Clean = value; TotalCashFlow = v34;
                var v35 = TotalGain; v35.Clean = value; TotalGain = v35;
                var v36 = TotalHomeAppreciation; v36.Clean = value; TotalHomeAppreciation = v36;
                var v37 = TotalHomeEquity; v37.Clean = value; TotalHomeEquity = v37;
                var v38 = TotalHousingExpense; v38.Clean = value; TotalHousingExpense = v38;
                var v39 = TotalIncomeTax; v39.Clean = value; TotalIncomeTax = v39;
                var v40 = TotalInvestmentInterest; v40.Clean = value; TotalInvestmentInterest = v40;
                var v41 = TotalLiabilityPayment; v41.Clean = value; TotalLiabilityPayment = v41;
                var v42 = TotalLiabilityUnpaid; v42.Clean = value; TotalLiabilityUnpaid = v42;
                var v43 = TotalLoanSavings; v43.Clean = value; TotalLoanSavings = v43;
                var v44 = TotalOtherExpenses; v44.Clean = value; TotalOtherExpenses = v44;
                var v45 = TotalOwnPmtOverYears; v45.Clean = value; TotalOwnPmtOverYears = v45;
                var v46 = TotalOwnTaxSavings; v46.Clean = value; TotalOwnTaxSavings = v46;
                var v47 = TotalPaidOffBalance; v47.Clean = value; TotalPaidOffBalance = v47;
                var v48 = TotalPaidOffMonthly; v48.Clean = value; TotalPaidOffMonthly = v48;
                var v49 = TotalPmtSavings; v49.Clean = value; TotalPmtSavings = v49;
                var v50 = TotalRentPmtOverYears; v50.Clean = value; TotalRentPmtOverYears = v50;
                var v51 = WithinLimits1; v51.Clean = value; WithinLimits1 = v51;
                var v52 = WithinLimits2; v52.Clean = value; WithinLimits2 = v52;
                var v53 = WithinLimits3; v53.Clean = value; WithinLimits3 = v53;
                var v54 = WithinLimits4; v54.Clean = value; WithinLimits4 = v54;
                var v55 = WithinLimits5; v55.Clean = value; WithinLimits5 = v55;
                var v56 = WithinLimits6; v56.Clean = value; WithinLimits6 = v56;
                var v57 = WithinLimits7; v57.Clean = value; WithinLimits7 = v57;
                var v58 = WithinLimits8; v58.Clean = value; WithinLimits8 = v58;
                var v59 = WithinLimits9; v59.Clean = value; WithinLimits9 = v59;
                var v60 = YearsForComparison; v60.Clean = value; YearsForComparison = v60;
                _settingClean = 0;
            }
        }
    }
}