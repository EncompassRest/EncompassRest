using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var afterTaxOwnMoSavings = _afterTaxOwnMoSavings; afterTaxOwnMoSavings.Clean = value; _afterTaxOwnMoSavings = afterTaxOwnMoSavings;
                var afterTaxRentMoSavings = _afterTaxRentMoSavings; afterTaxRentMoSavings.Clean = value; _afterTaxRentMoSavings = afterTaxRentMoSavings;
                var annualHomeMaintenance = _annualHomeMaintenance; annualHomeMaintenance.Clean = value; _annualHomeMaintenance = annualHomeMaintenance;
                var avgMoPmtSavings = _avgMoPmtSavings; avgMoPmtSavings.Clean = value; _avgMoPmtSavings = avgMoPmtSavings;
                var beforeTaxOwnMoPmt = _beforeTaxOwnMoPmt; beforeTaxOwnMoPmt.Clean = value; _beforeTaxOwnMoPmt = beforeTaxOwnMoPmt;
                var beforeTaxRentMoPmt = _beforeTaxRentMoPmt; beforeTaxRentMoPmt.Clean = value; _beforeTaxRentMoPmt = beforeTaxRentMoPmt;
                var cashOutBalance = _cashOutBalance; cashOutBalance.Clean = value; _cashOutBalance = cashOutBalance;
                var combinedGain = _combinedGain; combinedGain.Clean = value; _combinedGain = combinedGain;
                var costIncreasePerYear = _costIncreasePerYear; costIncreasePerYear.Clean = value; _costIncreasePerYear = costIncreasePerYear;
                var downPaymentAmount = _downPaymentAmount; downPaymentAmount.Clean = value; _downPaymentAmount = downPaymentAmount;
                var favorableOption = _favorableOption; favorableOption.Clean = value; _favorableOption = favorableOption;
                var homeSellingPriceAfterYears = _homeSellingPriceAfterYears; homeSellingPriceAfterYears.Clean = value; _homeSellingPriceAfterYears = homeSellingPriceAfterYears;
                var id = _id; id.Clean = value; _id = id;
                var investmentGain = _investmentGain; investmentGain.Clean = value; _investmentGain = investmentGain;
                var maxLoanLimit = _maxLoanLimit; maxLoanLimit.Clean = value; _maxLoanLimit = maxLoanLimit;
                var maxPropValue = _maxPropValue; maxPropValue.Clean = value; _maxPropValue = maxPropValue;
                var minusDownPmtAndClosingCosts = _minusDownPmtAndClosingCosts; minusDownPmtAndClosingCosts.Clean = value; _minusDownPmtAndClosingCosts = minusDownPmtAndClosingCosts;
                var minusLoanBalance = _minusLoanBalance; minusLoanBalance.Clean = value; _minusLoanBalance = minusLoanBalance;
                var monthlyBenefit = _monthlyBenefit; monthlyBenefit.Clean = value; _monthlyBenefit = monthlyBenefit;
                var monthlyHomeAppreciation = _monthlyHomeAppreciation; monthlyHomeAppreciation.Clean = value; _monthlyHomeAppreciation = monthlyHomeAppreciation;
                var monthlyHomeEquity = _monthlyHomeEquity; monthlyHomeEquity.Clean = value; _monthlyHomeEquity = monthlyHomeEquity;
                var monthlyIncomeTax = _monthlyIncomeTax; monthlyIncomeTax.Clean = value; _monthlyIncomeTax = monthlyIncomeTax;
                var monthlyInvestmentInterest = _monthlyInvestmentInterest; monthlyInvestmentInterest.Clean = value; _monthlyInvestmentInterest = monthlyInvestmentInterest;
                var monthlySavings = _monthlySavings; monthlySavings.Clean = value; _monthlySavings = monthlySavings;
                var numberOfMonths = _numberOfMonths; numberOfMonths.Clean = value; _numberOfMonths = numberOfMonths;
                var percentAnnualHomeMaint = _percentAnnualHomeMaint; percentAnnualHomeMaint.Clean = value; _percentAnnualHomeMaint = percentAnnualHomeMaint;
                var percentOfHomeAppreciation = _percentOfHomeAppreciation; percentOfHomeAppreciation.Clean = value; _percentOfHomeAppreciation = percentOfHomeAppreciation;
                var percentOfIncomeTax = _percentOfIncomeTax; percentOfIncomeTax.Clean = value; _percentOfIncomeTax = percentOfIncomeTax;
                var percentOfInvestmentInterest = _percentOfInvestmentInterest; percentOfInvestmentInterest.Clean = value; _percentOfInvestmentInterest = percentOfInvestmentInterest;
                var prequalificationScenarios = _prequalificationScenarios; prequalificationScenarios.Clean = value; _prequalificationScenarios = prequalificationScenarios;
                var qualificationStatus = _qualificationStatus; qualificationStatus.Clean = value; _qualificationStatus = qualificationStatus;
                var rentalCost = _rentalCost; rentalCost.Clean = value; _rentalCost = rentalCost;
                var rentersInsurance = _rentersInsurance; rentersInsurance.Clean = value; _rentersInsurance = rentersInsurance;
                var totalBenefit = _totalBenefit; totalBenefit.Clean = value; _totalBenefit = totalBenefit;
                var totalCashFlow = _totalCashFlow; totalCashFlow.Clean = value; _totalCashFlow = totalCashFlow;
                var totalGain = _totalGain; totalGain.Clean = value; _totalGain = totalGain;
                var totalHomeAppreciation = _totalHomeAppreciation; totalHomeAppreciation.Clean = value; _totalHomeAppreciation = totalHomeAppreciation;
                var totalHomeEquity = _totalHomeEquity; totalHomeEquity.Clean = value; _totalHomeEquity = totalHomeEquity;
                var totalHousingExpense = _totalHousingExpense; totalHousingExpense.Clean = value; _totalHousingExpense = totalHousingExpense;
                var totalIncomeTax = _totalIncomeTax; totalIncomeTax.Clean = value; _totalIncomeTax = totalIncomeTax;
                var totalInvestmentInterest = _totalInvestmentInterest; totalInvestmentInterest.Clean = value; _totalInvestmentInterest = totalInvestmentInterest;
                var totalLiabilityPayment = _totalLiabilityPayment; totalLiabilityPayment.Clean = value; _totalLiabilityPayment = totalLiabilityPayment;
                var totalLiabilityUnpaid = _totalLiabilityUnpaid; totalLiabilityUnpaid.Clean = value; _totalLiabilityUnpaid = totalLiabilityUnpaid;
                var totalLoanSavings = _totalLoanSavings; totalLoanSavings.Clean = value; _totalLoanSavings = totalLoanSavings;
                var totalOtherExpenses = _totalOtherExpenses; totalOtherExpenses.Clean = value; _totalOtherExpenses = totalOtherExpenses;
                var totalOwnPmtOverYears = _totalOwnPmtOverYears; totalOwnPmtOverYears.Clean = value; _totalOwnPmtOverYears = totalOwnPmtOverYears;
                var totalOwnTaxSavings = _totalOwnTaxSavings; totalOwnTaxSavings.Clean = value; _totalOwnTaxSavings = totalOwnTaxSavings;
                var totalPaidOffBalance = _totalPaidOffBalance; totalPaidOffBalance.Clean = value; _totalPaidOffBalance = totalPaidOffBalance;
                var totalPaidOffMonthly = _totalPaidOffMonthly; totalPaidOffMonthly.Clean = value; _totalPaidOffMonthly = totalPaidOffMonthly;
                var totalPmtSavings = _totalPmtSavings; totalPmtSavings.Clean = value; _totalPmtSavings = totalPmtSavings;
                var totalRentPmtOverYears = _totalRentPmtOverYears; totalRentPmtOverYears.Clean = value; _totalRentPmtOverYears = totalRentPmtOverYears;
                var withinLimits1 = _withinLimits1; withinLimits1.Clean = value; _withinLimits1 = withinLimits1;
                var withinLimits2 = _withinLimits2; withinLimits2.Clean = value; _withinLimits2 = withinLimits2;
                var withinLimits3 = _withinLimits3; withinLimits3.Clean = value; _withinLimits3 = withinLimits3;
                var withinLimits4 = _withinLimits4; withinLimits4.Clean = value; _withinLimits4 = withinLimits4;
                var withinLimits5 = _withinLimits5; withinLimits5.Clean = value; _withinLimits5 = withinLimits5;
                var withinLimits6 = _withinLimits6; withinLimits6.Clean = value; _withinLimits6 = withinLimits6;
                var withinLimits7 = _withinLimits7; withinLimits7.Clean = value; _withinLimits7 = withinLimits7;
                var withinLimits8 = _withinLimits8; withinLimits8.Clean = value; _withinLimits8 = withinLimits8;
                var withinLimits9 = _withinLimits9; withinLimits9.Clean = value; _withinLimits9 = withinLimits9;
                var yearsForComparison = _yearsForComparison; yearsForComparison.Clean = value; _yearsForComparison = yearsForComparison;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Prequalification()
        {
            Clean = true;
        }
    }
}