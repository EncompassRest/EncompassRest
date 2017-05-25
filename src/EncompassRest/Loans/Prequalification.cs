using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Prequalification : IClean
    {
        private Value<decimal?> _afterTaxOwnMoSavings;
        public decimal? AfterTaxOwnMoSavings { get { return _afterTaxOwnMoSavings; } set { _afterTaxOwnMoSavings = value; } }
        private Value<decimal?> _afterTaxRentMoSavings;
        public decimal? AfterTaxRentMoSavings { get { return _afterTaxRentMoSavings; } set { _afterTaxRentMoSavings = value; } }
        private Value<decimal?> _annualHomeMaintenance;
        public decimal? AnnualHomeMaintenance { get { return _annualHomeMaintenance; } set { _annualHomeMaintenance = value; } }
        private Value<decimal?> _avgMoPmtSavings;
        public decimal? AvgMoPmtSavings { get { return _avgMoPmtSavings; } set { _avgMoPmtSavings = value; } }
        private Value<decimal?> _beforeTaxOwnMoPmt;
        public decimal? BeforeTaxOwnMoPmt { get { return _beforeTaxOwnMoPmt; } set { _beforeTaxOwnMoPmt = value; } }
        private Value<decimal?> _beforeTaxRentMoPmt;
        public decimal? BeforeTaxRentMoPmt { get { return _beforeTaxRentMoPmt; } set { _beforeTaxRentMoPmt = value; } }
        private Value<int?> _cashOutBalance;
        public int? CashOutBalance { get { return _cashOutBalance; } set { _cashOutBalance = value; } }
        private Value<decimal?> _combinedGain;
        public decimal? CombinedGain { get { return _combinedGain; } set { _combinedGain = value; } }
        private Value<decimal?> _costIncreasePerYear;
        public decimal? CostIncreasePerYear { get { return _costIncreasePerYear; } set { _costIncreasePerYear = value; } }
        private Value<decimal?> _downPaymentAmount;
        public decimal? DownPaymentAmount { get { return _downPaymentAmount; } set { _downPaymentAmount = value; } }
        private Value<string> _favorableOption;
        public string FavorableOption { get { return _favorableOption; } set { _favorableOption = value; } }
        private Value<decimal?> _homeSellingPriceAfterYears;
        public decimal? HomeSellingPriceAfterYears { get { return _homeSellingPriceAfterYears; } set { _homeSellingPriceAfterYears = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _investmentGain;
        public decimal? InvestmentGain { get { return _investmentGain; } set { _investmentGain = value; } }
        private Value<decimal?> _maxLoanLimit;
        public decimal? MaxLoanLimit { get { return _maxLoanLimit; } set { _maxLoanLimit = value; } }
        private Value<decimal?> _maxPropValue;
        public decimal? MaxPropValue { get { return _maxPropValue; } set { _maxPropValue = value; } }
        private Value<decimal?> _minusDownPmtAndClosingCosts;
        public decimal? MinusDownPmtAndClosingCosts { get { return _minusDownPmtAndClosingCosts; } set { _minusDownPmtAndClosingCosts = value; } }
        private Value<decimal?> _minusLoanBalance;
        public decimal? MinusLoanBalance { get { return _minusLoanBalance; } set { _minusLoanBalance = value; } }
        private Value<decimal?> _monthlyBenefit;
        public decimal? MonthlyBenefit { get { return _monthlyBenefit; } set { _monthlyBenefit = value; } }
        private Value<decimal?> _monthlyHomeAppreciation;
        public decimal? MonthlyHomeAppreciation { get { return _monthlyHomeAppreciation; } set { _monthlyHomeAppreciation = value; } }
        private Value<decimal?> _monthlyHomeEquity;
        public decimal? MonthlyHomeEquity { get { return _monthlyHomeEquity; } set { _monthlyHomeEquity = value; } }
        private Value<decimal?> _monthlyIncomeTax;
        public decimal? MonthlyIncomeTax { get { return _monthlyIncomeTax; } set { _monthlyIncomeTax = value; } }
        private Value<decimal?> _monthlyInvestmentInterest;
        public decimal? MonthlyInvestmentInterest { get { return _monthlyInvestmentInterest; } set { _monthlyInvestmentInterest = value; } }
        private Value<int?> _monthlySavings;
        public int? MonthlySavings { get { return _monthlySavings; } set { _monthlySavings = value; } }
        private Value<string> _numberOfMonths;
        public string NumberOfMonths { get { return _numberOfMonths; } set { _numberOfMonths = value; } }
        private Value<decimal?> _percentAnnualHomeMaint;
        public decimal? PercentAnnualHomeMaint { get { return _percentAnnualHomeMaint; } set { _percentAnnualHomeMaint = value; } }
        private Value<decimal?> _percentOfHomeAppreciation;
        public decimal? PercentOfHomeAppreciation { get { return _percentOfHomeAppreciation; } set { _percentOfHomeAppreciation = value; } }
        private Value<decimal?> _percentOfIncomeTax;
        public decimal? PercentOfIncomeTax { get { return _percentOfIncomeTax; } set { _percentOfIncomeTax = value; } }
        private Value<decimal?> _percentOfInvestmentInterest;
        public decimal? PercentOfInvestmentInterest { get { return _percentOfInvestmentInterest; } set { _percentOfInvestmentInterest = value; } }
        private Value<List<PrequalificationScenario>> _prequalificationScenarios;
        public List<PrequalificationScenario> PrequalificationScenarios { get { return _prequalificationScenarios; } set { _prequalificationScenarios = value; } }
        private Value<string> _qualificationStatus;
        public string QualificationStatus { get { return _qualificationStatus; } set { _qualificationStatus = value; } }
        private Value<decimal?> _rentalCost;
        public decimal? RentalCost { get { return _rentalCost; } set { _rentalCost = value; } }
        private Value<decimal?> _rentersInsurance;
        public decimal? RentersInsurance { get { return _rentersInsurance; } set { _rentersInsurance = value; } }
        private Value<decimal?> _totalBenefit;
        public decimal? TotalBenefit { get { return _totalBenefit; } set { _totalBenefit = value; } }
        private Value<decimal?> _totalCashFlow;
        public decimal? TotalCashFlow { get { return _totalCashFlow; } set { _totalCashFlow = value; } }
        private Value<decimal?> _totalGain;
        public decimal? TotalGain { get { return _totalGain; } set { _totalGain = value; } }
        private Value<decimal?> _totalHomeAppreciation;
        public decimal? TotalHomeAppreciation { get { return _totalHomeAppreciation; } set { _totalHomeAppreciation = value; } }
        private Value<decimal?> _totalHomeEquity;
        public decimal? TotalHomeEquity { get { return _totalHomeEquity; } set { _totalHomeEquity = value; } }
        private Value<decimal?> _totalHousingExpense;
        public decimal? TotalHousingExpense { get { return _totalHousingExpense; } set { _totalHousingExpense = value; } }
        private Value<decimal?> _totalIncomeTax;
        public decimal? TotalIncomeTax { get { return _totalIncomeTax; } set { _totalIncomeTax = value; } }
        private Value<decimal?> _totalInvestmentInterest;
        public decimal? TotalInvestmentInterest { get { return _totalInvestmentInterest; } set { _totalInvestmentInterest = value; } }
        private Value<int?> _totalLiabilityPayment;
        public int? TotalLiabilityPayment { get { return _totalLiabilityPayment; } set { _totalLiabilityPayment = value; } }
        private Value<int?> _totalLiabilityUnpaid;
        public int? TotalLiabilityUnpaid { get { return _totalLiabilityUnpaid; } set { _totalLiabilityUnpaid = value; } }
        private Value<int?> _totalLoanSavings;
        public int? TotalLoanSavings { get { return _totalLoanSavings; } set { _totalLoanSavings = value; } }
        private Value<decimal?> _totalOtherExpenses;
        public decimal? TotalOtherExpenses { get { return _totalOtherExpenses; } set { _totalOtherExpenses = value; } }
        private Value<decimal?> _totalOwnPmtOverYears;
        public decimal? TotalOwnPmtOverYears { get { return _totalOwnPmtOverYears; } set { _totalOwnPmtOverYears = value; } }
        private Value<decimal?> _totalOwnTaxSavings;
        public decimal? TotalOwnTaxSavings { get { return _totalOwnTaxSavings; } set { _totalOwnTaxSavings = value; } }
        private Value<int?> _totalPaidOffBalance;
        public int? TotalPaidOffBalance { get { return _totalPaidOffBalance; } set { _totalPaidOffBalance = value; } }
        private Value<int?> _totalPaidOffMonthly;
        public int? TotalPaidOffMonthly { get { return _totalPaidOffMonthly; } set { _totalPaidOffMonthly = value; } }
        private Value<decimal?> _totalPmtSavings;
        public decimal? TotalPmtSavings { get { return _totalPmtSavings; } set { _totalPmtSavings = value; } }
        private Value<decimal?> _totalRentPmtOverYears;
        public decimal? TotalRentPmtOverYears { get { return _totalRentPmtOverYears; } set { _totalRentPmtOverYears = value; } }
        private Value<string> _withinLimits1;
        public string WithinLimits1 { get { return _withinLimits1; } set { _withinLimits1 = value; } }
        private Value<string> _withinLimits2;
        public string WithinLimits2 { get { return _withinLimits2; } set { _withinLimits2 = value; } }
        private Value<string> _withinLimits3;
        public string WithinLimits3 { get { return _withinLimits3; } set { _withinLimits3 = value; } }
        private Value<string> _withinLimits4;
        public string WithinLimits4 { get { return _withinLimits4; } set { _withinLimits4 = value; } }
        private Value<string> _withinLimits5;
        public string WithinLimits5 { get { return _withinLimits5; } set { _withinLimits5 = value; } }
        private Value<string> _withinLimits6;
        public string WithinLimits6 { get { return _withinLimits6; } set { _withinLimits6 = value; } }
        private Value<string> _withinLimits7;
        public string WithinLimits7 { get { return _withinLimits7; } set { _withinLimits7 = value; } }
        private Value<string> _withinLimits8;
        public string WithinLimits8 { get { return _withinLimits8; } set { _withinLimits8 = value; } }
        private Value<string> _withinLimits9;
        public string WithinLimits9 { get { return _withinLimits9; } set { _withinLimits9 = value; } }
        private Value<int?> _yearsForComparison;
        public int? YearsForComparison { get { return _yearsForComparison; } set { _yearsForComparison = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _afterTaxOwnMoSavings.Clean
                    && _afterTaxRentMoSavings.Clean
                    && _annualHomeMaintenance.Clean
                    && _avgMoPmtSavings.Clean
                    && _beforeTaxOwnMoPmt.Clean
                    && _beforeTaxRentMoPmt.Clean
                    && _cashOutBalance.Clean
                    && _combinedGain.Clean
                    && _costIncreasePerYear.Clean
                    && _downPaymentAmount.Clean
                    && _favorableOption.Clean
                    && _homeSellingPriceAfterYears.Clean
                    && _id.Clean
                    && _investmentGain.Clean
                    && _maxLoanLimit.Clean
                    && _maxPropValue.Clean
                    && _minusDownPmtAndClosingCosts.Clean
                    && _minusLoanBalance.Clean
                    && _monthlyBenefit.Clean
                    && _monthlyHomeAppreciation.Clean
                    && _monthlyHomeEquity.Clean
                    && _monthlyIncomeTax.Clean
                    && _monthlyInvestmentInterest.Clean
                    && _monthlySavings.Clean
                    && _numberOfMonths.Clean
                    && _percentAnnualHomeMaint.Clean
                    && _percentOfHomeAppreciation.Clean
                    && _percentOfIncomeTax.Clean
                    && _percentOfInvestmentInterest.Clean
                    && _prequalificationScenarios.Clean
                    && _qualificationStatus.Clean
                    && _rentalCost.Clean
                    && _rentersInsurance.Clean
                    && _totalBenefit.Clean
                    && _totalCashFlow.Clean
                    && _totalGain.Clean
                    && _totalHomeAppreciation.Clean
                    && _totalHomeEquity.Clean
                    && _totalHousingExpense.Clean
                    && _totalIncomeTax.Clean
                    && _totalInvestmentInterest.Clean
                    && _totalLiabilityPayment.Clean
                    && _totalLiabilityUnpaid.Clean
                    && _totalLoanSavings.Clean
                    && _totalOtherExpenses.Clean
                    && _totalOwnPmtOverYears.Clean
                    && _totalOwnTaxSavings.Clean
                    && _totalPaidOffBalance.Clean
                    && _totalPaidOffMonthly.Clean
                    && _totalPmtSavings.Clean
                    && _totalRentPmtOverYears.Clean
                    && _withinLimits1.Clean
                    && _withinLimits2.Clean
                    && _withinLimits3.Clean
                    && _withinLimits4.Clean
                    && _withinLimits5.Clean
                    && _withinLimits6.Clean
                    && _withinLimits7.Clean
                    && _withinLimits8.Clean
                    && _withinLimits9.Clean
                    && _yearsForComparison.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _afterTaxOwnMoSavings; v0.Clean = value; _afterTaxOwnMoSavings = v0;
                var v1 = _afterTaxRentMoSavings; v1.Clean = value; _afterTaxRentMoSavings = v1;
                var v2 = _annualHomeMaintenance; v2.Clean = value; _annualHomeMaintenance = v2;
                var v3 = _avgMoPmtSavings; v3.Clean = value; _avgMoPmtSavings = v3;
                var v4 = _beforeTaxOwnMoPmt; v4.Clean = value; _beforeTaxOwnMoPmt = v4;
                var v5 = _beforeTaxRentMoPmt; v5.Clean = value; _beforeTaxRentMoPmt = v5;
                var v6 = _cashOutBalance; v6.Clean = value; _cashOutBalance = v6;
                var v7 = _combinedGain; v7.Clean = value; _combinedGain = v7;
                var v8 = _costIncreasePerYear; v8.Clean = value; _costIncreasePerYear = v8;
                var v9 = _downPaymentAmount; v9.Clean = value; _downPaymentAmount = v9;
                var v10 = _favorableOption; v10.Clean = value; _favorableOption = v10;
                var v11 = _homeSellingPriceAfterYears; v11.Clean = value; _homeSellingPriceAfterYears = v11;
                var v12 = _id; v12.Clean = value; _id = v12;
                var v13 = _investmentGain; v13.Clean = value; _investmentGain = v13;
                var v14 = _maxLoanLimit; v14.Clean = value; _maxLoanLimit = v14;
                var v15 = _maxPropValue; v15.Clean = value; _maxPropValue = v15;
                var v16 = _minusDownPmtAndClosingCosts; v16.Clean = value; _minusDownPmtAndClosingCosts = v16;
                var v17 = _minusLoanBalance; v17.Clean = value; _minusLoanBalance = v17;
                var v18 = _monthlyBenefit; v18.Clean = value; _monthlyBenefit = v18;
                var v19 = _monthlyHomeAppreciation; v19.Clean = value; _monthlyHomeAppreciation = v19;
                var v20 = _monthlyHomeEquity; v20.Clean = value; _monthlyHomeEquity = v20;
                var v21 = _monthlyIncomeTax; v21.Clean = value; _monthlyIncomeTax = v21;
                var v22 = _monthlyInvestmentInterest; v22.Clean = value; _monthlyInvestmentInterest = v22;
                var v23 = _monthlySavings; v23.Clean = value; _monthlySavings = v23;
                var v24 = _numberOfMonths; v24.Clean = value; _numberOfMonths = v24;
                var v25 = _percentAnnualHomeMaint; v25.Clean = value; _percentAnnualHomeMaint = v25;
                var v26 = _percentOfHomeAppreciation; v26.Clean = value; _percentOfHomeAppreciation = v26;
                var v27 = _percentOfIncomeTax; v27.Clean = value; _percentOfIncomeTax = v27;
                var v28 = _percentOfInvestmentInterest; v28.Clean = value; _percentOfInvestmentInterest = v28;
                var v29 = _prequalificationScenarios; v29.Clean = value; _prequalificationScenarios = v29;
                var v30 = _qualificationStatus; v30.Clean = value; _qualificationStatus = v30;
                var v31 = _rentalCost; v31.Clean = value; _rentalCost = v31;
                var v32 = _rentersInsurance; v32.Clean = value; _rentersInsurance = v32;
                var v33 = _totalBenefit; v33.Clean = value; _totalBenefit = v33;
                var v34 = _totalCashFlow; v34.Clean = value; _totalCashFlow = v34;
                var v35 = _totalGain; v35.Clean = value; _totalGain = v35;
                var v36 = _totalHomeAppreciation; v36.Clean = value; _totalHomeAppreciation = v36;
                var v37 = _totalHomeEquity; v37.Clean = value; _totalHomeEquity = v37;
                var v38 = _totalHousingExpense; v38.Clean = value; _totalHousingExpense = v38;
                var v39 = _totalIncomeTax; v39.Clean = value; _totalIncomeTax = v39;
                var v40 = _totalInvestmentInterest; v40.Clean = value; _totalInvestmentInterest = v40;
                var v41 = _totalLiabilityPayment; v41.Clean = value; _totalLiabilityPayment = v41;
                var v42 = _totalLiabilityUnpaid; v42.Clean = value; _totalLiabilityUnpaid = v42;
                var v43 = _totalLoanSavings; v43.Clean = value; _totalLoanSavings = v43;
                var v44 = _totalOtherExpenses; v44.Clean = value; _totalOtherExpenses = v44;
                var v45 = _totalOwnPmtOverYears; v45.Clean = value; _totalOwnPmtOverYears = v45;
                var v46 = _totalOwnTaxSavings; v46.Clean = value; _totalOwnTaxSavings = v46;
                var v47 = _totalPaidOffBalance; v47.Clean = value; _totalPaidOffBalance = v47;
                var v48 = _totalPaidOffMonthly; v48.Clean = value; _totalPaidOffMonthly = v48;
                var v49 = _totalPmtSavings; v49.Clean = value; _totalPmtSavings = v49;
                var v50 = _totalRentPmtOverYears; v50.Clean = value; _totalRentPmtOverYears = v50;
                var v51 = _withinLimits1; v51.Clean = value; _withinLimits1 = v51;
                var v52 = _withinLimits2; v52.Clean = value; _withinLimits2 = v52;
                var v53 = _withinLimits3; v53.Clean = value; _withinLimits3 = v53;
                var v54 = _withinLimits4; v54.Clean = value; _withinLimits4 = v54;
                var v55 = _withinLimits5; v55.Clean = value; _withinLimits5 = v55;
                var v56 = _withinLimits6; v56.Clean = value; _withinLimits6 = v56;
                var v57 = _withinLimits7; v57.Clean = value; _withinLimits7 = v57;
                var v58 = _withinLimits8; v58.Clean = value; _withinLimits8 = v58;
                var v59 = _withinLimits9; v59.Clean = value; _withinLimits9 = v59;
                var v60 = _yearsForComparison; v60.Clean = value; _yearsForComparison = v60;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}