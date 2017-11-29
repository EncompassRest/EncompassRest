using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Prequalification : ExtensibleObject
    {
        private DirtyValue<decimal?> _afterTaxOwnMoSavings;
        public decimal? AfterTaxOwnMoSavings { get => _afterTaxOwnMoSavings; set => _afterTaxOwnMoSavings = value; }
        private DirtyValue<decimal?> _afterTaxRentMoSavings;
        public decimal? AfterTaxRentMoSavings { get => _afterTaxRentMoSavings; set => _afterTaxRentMoSavings = value; }
        private DirtyValue<decimal?> _annualHomeMaintenance;
        public decimal? AnnualHomeMaintenance { get => _annualHomeMaintenance; set => _annualHomeMaintenance = value; }
        private DirtyValue<decimal?> _avgMoPmtSavings;
        public decimal? AvgMoPmtSavings { get => _avgMoPmtSavings; set => _avgMoPmtSavings = value; }
        private DirtyValue<decimal?> _beforeTaxOwnMoPmt;
        public decimal? BeforeTaxOwnMoPmt { get => _beforeTaxOwnMoPmt; set => _beforeTaxOwnMoPmt = value; }
        private DirtyValue<decimal?> _beforeTaxRentMoPmt;
        public decimal? BeforeTaxRentMoPmt { get => _beforeTaxRentMoPmt; set => _beforeTaxRentMoPmt = value; }
        private DirtyValue<int?> _cashOutBalance;
        public int? CashOutBalance { get => _cashOutBalance; set => _cashOutBalance = value; }
        private DirtyValue<decimal?> _combinedGain;
        public decimal? CombinedGain { get => _combinedGain; set => _combinedGain = value; }
        private DirtyValue<decimal?> _costIncreasePerYear;
        public decimal? CostIncreasePerYear { get => _costIncreasePerYear; set => _costIncreasePerYear = value; }
        private DirtyValue<decimal?> _downPaymentAmount;
        public decimal? DownPaymentAmount { get => _downPaymentAmount; set => _downPaymentAmount = value; }
        private DirtyValue<string> _favorableOption;
        public string FavorableOption { get => _favorableOption; set => _favorableOption = value; }
        private DirtyValue<decimal?> _homeSellingPriceAfterYears;
        public decimal? HomeSellingPriceAfterYears { get => _homeSellingPriceAfterYears; set => _homeSellingPriceAfterYears = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _investmentGain;
        public decimal? InvestmentGain { get => _investmentGain; set => _investmentGain = value; }
        private DirtyValue<decimal?> _maxLoanLimit;
        public decimal? MaxLoanLimit { get => _maxLoanLimit; set => _maxLoanLimit = value; }
        private DirtyValue<decimal?> _maxPropValue;
        public decimal? MaxPropValue { get => _maxPropValue; set => _maxPropValue = value; }
        private DirtyValue<decimal?> _minusDownPmtAndClosingCosts;
        public decimal? MinusDownPmtAndClosingCosts { get => _minusDownPmtAndClosingCosts; set => _minusDownPmtAndClosingCosts = value; }
        private DirtyValue<decimal?> _minusLoanBalance;
        public decimal? MinusLoanBalance { get => _minusLoanBalance; set => _minusLoanBalance = value; }
        private DirtyValue<decimal?> _monthlyBenefit;
        public decimal? MonthlyBenefit { get => _monthlyBenefit; set => _monthlyBenefit = value; }
        private DirtyValue<decimal?> _monthlyHomeAppreciation;
        public decimal? MonthlyHomeAppreciation { get => _monthlyHomeAppreciation; set => _monthlyHomeAppreciation = value; }
        private DirtyValue<decimal?> _monthlyHomeEquity;
        public decimal? MonthlyHomeEquity { get => _monthlyHomeEquity; set => _monthlyHomeEquity = value; }
        private DirtyValue<decimal?> _monthlyIncomeTax;
        public decimal? MonthlyIncomeTax { get => _monthlyIncomeTax; set => _monthlyIncomeTax = value; }
        private DirtyValue<decimal?> _monthlyInvestmentInterest;
        public decimal? MonthlyInvestmentInterest { get => _monthlyInvestmentInterest; set => _monthlyInvestmentInterest = value; }
        private DirtyValue<int?> _monthlySavings;
        public int? MonthlySavings { get => _monthlySavings; set => _monthlySavings = value; }
        private DirtyValue<string> _numberOfMonths;
        public string NumberOfMonths { get => _numberOfMonths; set => _numberOfMonths = value; }
        private DirtyValue<decimal?> _percentAnnualHomeMaint;
        public decimal? PercentAnnualHomeMaint { get => _percentAnnualHomeMaint; set => _percentAnnualHomeMaint = value; }
        private DirtyValue<decimal?> _percentOfHomeAppreciation;
        public decimal? PercentOfHomeAppreciation { get => _percentOfHomeAppreciation; set => _percentOfHomeAppreciation = value; }
        private DirtyValue<decimal?> _percentOfIncomeTax;
        public decimal? PercentOfIncomeTax { get => _percentOfIncomeTax; set => _percentOfIncomeTax = value; }
        private DirtyValue<decimal?> _percentOfInvestmentInterest;
        public decimal? PercentOfInvestmentInterest { get => _percentOfInvestmentInterest; set => _percentOfInvestmentInterest = value; }
        private DirtyList<PrequalificationScenario> _prequalificationScenarios;
        public IList<PrequalificationScenario> PrequalificationScenarios { get => _prequalificationScenarios ?? (_prequalificationScenarios = new DirtyList<PrequalificationScenario>()); set => _prequalificationScenarios = new DirtyList<PrequalificationScenario>(value); }
        private DirtyValue<string> _qualificationStatus;
        public string QualificationStatus { get => _qualificationStatus; set => _qualificationStatus = value; }
        private DirtyValue<decimal?> _rentalCost;
        public decimal? RentalCost { get => _rentalCost; set => _rentalCost = value; }
        private DirtyValue<decimal?> _rentersInsurance;
        public decimal? RentersInsurance { get => _rentersInsurance; set => _rentersInsurance = value; }
        private DirtyValue<decimal?> _totalBenefit;
        public decimal? TotalBenefit { get => _totalBenefit; set => _totalBenefit = value; }
        private DirtyValue<decimal?> _totalCashFlow;
        public decimal? TotalCashFlow { get => _totalCashFlow; set => _totalCashFlow = value; }
        private DirtyValue<decimal?> _totalGain;
        public decimal? TotalGain { get => _totalGain; set => _totalGain = value; }
        private DirtyValue<decimal?> _totalHomeAppreciation;
        public decimal? TotalHomeAppreciation { get => _totalHomeAppreciation; set => _totalHomeAppreciation = value; }
        private DirtyValue<decimal?> _totalHomeEquity;
        public decimal? TotalHomeEquity { get => _totalHomeEquity; set => _totalHomeEquity = value; }
        private DirtyValue<decimal?> _totalHousingExpense;
        public decimal? TotalHousingExpense { get => _totalHousingExpense; set => _totalHousingExpense = value; }
        private DirtyValue<decimal?> _totalIncomeTax;
        public decimal? TotalIncomeTax { get => _totalIncomeTax; set => _totalIncomeTax = value; }
        private DirtyValue<decimal?> _totalInvestmentInterest;
        public decimal? TotalInvestmentInterest { get => _totalInvestmentInterest; set => _totalInvestmentInterest = value; }
        private DirtyValue<int?> _totalLiabilityPayment;
        public int? TotalLiabilityPayment { get => _totalLiabilityPayment; set => _totalLiabilityPayment = value; }
        private DirtyValue<int?> _totalLiabilityUnpaid;
        public int? TotalLiabilityUnpaid { get => _totalLiabilityUnpaid; set => _totalLiabilityUnpaid = value; }
        private DirtyValue<int?> _totalLoanSavings;
        public int? TotalLoanSavings { get => _totalLoanSavings; set => _totalLoanSavings = value; }
        private DirtyValue<decimal?> _totalOtherExpenses;
        public decimal? TotalOtherExpenses { get => _totalOtherExpenses; set => _totalOtherExpenses = value; }
        private DirtyValue<decimal?> _totalOwnPmtOverYears;
        public decimal? TotalOwnPmtOverYears { get => _totalOwnPmtOverYears; set => _totalOwnPmtOverYears = value; }
        private DirtyValue<decimal?> _totalOwnTaxSavings;
        public decimal? TotalOwnTaxSavings { get => _totalOwnTaxSavings; set => _totalOwnTaxSavings = value; }
        private DirtyValue<int?> _totalPaidOffBalance;
        public int? TotalPaidOffBalance { get => _totalPaidOffBalance; set => _totalPaidOffBalance = value; }
        private DirtyValue<int?> _totalPaidOffMonthly;
        public int? TotalPaidOffMonthly { get => _totalPaidOffMonthly; set => _totalPaidOffMonthly = value; }
        private DirtyValue<decimal?> _totalPmtSavings;
        public decimal? TotalPmtSavings { get => _totalPmtSavings; set => _totalPmtSavings = value; }
        private DirtyValue<decimal?> _totalRentPmtOverYears;
        public decimal? TotalRentPmtOverYears { get => _totalRentPmtOverYears; set => _totalRentPmtOverYears = value; }
        private DirtyValue<string> _withinLimits1;
        public string WithinLimits1 { get => _withinLimits1; set => _withinLimits1 = value; }
        private DirtyValue<string> _withinLimits2;
        public string WithinLimits2 { get => _withinLimits2; set => _withinLimits2 = value; }
        private DirtyValue<string> _withinLimits3;
        public string WithinLimits3 { get => _withinLimits3; set => _withinLimits3 = value; }
        private DirtyValue<string> _withinLimits4;
        public string WithinLimits4 { get => _withinLimits4; set => _withinLimits4 = value; }
        private DirtyValue<string> _withinLimits5;
        public string WithinLimits5 { get => _withinLimits5; set => _withinLimits5 = value; }
        private DirtyValue<string> _withinLimits6;
        public string WithinLimits6 { get => _withinLimits6; set => _withinLimits6 = value; }
        private DirtyValue<string> _withinLimits7;
        public string WithinLimits7 { get => _withinLimits7; set => _withinLimits7 = value; }
        private DirtyValue<string> _withinLimits8;
        public string WithinLimits8 { get => _withinLimits8; set => _withinLimits8 = value; }
        private DirtyValue<string> _withinLimits9;
        public string WithinLimits9 { get => _withinLimits9; set => _withinLimits9 = value; }
        private DirtyValue<int?> _yearsForComparison;
        public int? YearsForComparison { get => _yearsForComparison; set => _yearsForComparison = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _afterTaxOwnMoSavings.Dirty
                    || _afterTaxRentMoSavings.Dirty
                    || _annualHomeMaintenance.Dirty
                    || _avgMoPmtSavings.Dirty
                    || _beforeTaxOwnMoPmt.Dirty
                    || _beforeTaxRentMoPmt.Dirty
                    || _cashOutBalance.Dirty
                    || _combinedGain.Dirty
                    || _costIncreasePerYear.Dirty
                    || _downPaymentAmount.Dirty
                    || _favorableOption.Dirty
                    || _homeSellingPriceAfterYears.Dirty
                    || _id.Dirty
                    || _investmentGain.Dirty
                    || _maxLoanLimit.Dirty
                    || _maxPropValue.Dirty
                    || _minusDownPmtAndClosingCosts.Dirty
                    || _minusLoanBalance.Dirty
                    || _monthlyBenefit.Dirty
                    || _monthlyHomeAppreciation.Dirty
                    || _monthlyHomeEquity.Dirty
                    || _monthlyIncomeTax.Dirty
                    || _monthlyInvestmentInterest.Dirty
                    || _monthlySavings.Dirty
                    || _numberOfMonths.Dirty
                    || _percentAnnualHomeMaint.Dirty
                    || _percentOfHomeAppreciation.Dirty
                    || _percentOfIncomeTax.Dirty
                    || _percentOfInvestmentInterest.Dirty
                    || _qualificationStatus.Dirty
                    || _rentalCost.Dirty
                    || _rentersInsurance.Dirty
                    || _totalBenefit.Dirty
                    || _totalCashFlow.Dirty
                    || _totalGain.Dirty
                    || _totalHomeAppreciation.Dirty
                    || _totalHomeEquity.Dirty
                    || _totalHousingExpense.Dirty
                    || _totalIncomeTax.Dirty
                    || _totalInvestmentInterest.Dirty
                    || _totalLiabilityPayment.Dirty
                    || _totalLiabilityUnpaid.Dirty
                    || _totalLoanSavings.Dirty
                    || _totalOtherExpenses.Dirty
                    || _totalOwnPmtOverYears.Dirty
                    || _totalOwnTaxSavings.Dirty
                    || _totalPaidOffBalance.Dirty
                    || _totalPaidOffMonthly.Dirty
                    || _totalPmtSavings.Dirty
                    || _totalRentPmtOverYears.Dirty
                    || _withinLimits1.Dirty
                    || _withinLimits2.Dirty
                    || _withinLimits3.Dirty
                    || _withinLimits4.Dirty
                    || _withinLimits5.Dirty
                    || _withinLimits6.Dirty
                    || _withinLimits7.Dirty
                    || _withinLimits8.Dirty
                    || _withinLimits9.Dirty
                    || _yearsForComparison.Dirty
                    || _prequalificationScenarios?.Dirty == true;
            }
            set
            {
                _afterTaxOwnMoSavings.Dirty = value;
                _afterTaxRentMoSavings.Dirty = value;
                _annualHomeMaintenance.Dirty = value;
                _avgMoPmtSavings.Dirty = value;
                _beforeTaxOwnMoPmt.Dirty = value;
                _beforeTaxRentMoPmt.Dirty = value;
                _cashOutBalance.Dirty = value;
                _combinedGain.Dirty = value;
                _costIncreasePerYear.Dirty = value;
                _downPaymentAmount.Dirty = value;
                _favorableOption.Dirty = value;
                _homeSellingPriceAfterYears.Dirty = value;
                _id.Dirty = value;
                _investmentGain.Dirty = value;
                _maxLoanLimit.Dirty = value;
                _maxPropValue.Dirty = value;
                _minusDownPmtAndClosingCosts.Dirty = value;
                _minusLoanBalance.Dirty = value;
                _monthlyBenefit.Dirty = value;
                _monthlyHomeAppreciation.Dirty = value;
                _monthlyHomeEquity.Dirty = value;
                _monthlyIncomeTax.Dirty = value;
                _monthlyInvestmentInterest.Dirty = value;
                _monthlySavings.Dirty = value;
                _numberOfMonths.Dirty = value;
                _percentAnnualHomeMaint.Dirty = value;
                _percentOfHomeAppreciation.Dirty = value;
                _percentOfIncomeTax.Dirty = value;
                _percentOfInvestmentInterest.Dirty = value;
                _qualificationStatus.Dirty = value;
                _rentalCost.Dirty = value;
                _rentersInsurance.Dirty = value;
                _totalBenefit.Dirty = value;
                _totalCashFlow.Dirty = value;
                _totalGain.Dirty = value;
                _totalHomeAppreciation.Dirty = value;
                _totalHomeEquity.Dirty = value;
                _totalHousingExpense.Dirty = value;
                _totalIncomeTax.Dirty = value;
                _totalInvestmentInterest.Dirty = value;
                _totalLiabilityPayment.Dirty = value;
                _totalLiabilityUnpaid.Dirty = value;
                _totalLoanSavings.Dirty = value;
                _totalOtherExpenses.Dirty = value;
                _totalOwnPmtOverYears.Dirty = value;
                _totalOwnTaxSavings.Dirty = value;
                _totalPaidOffBalance.Dirty = value;
                _totalPaidOffMonthly.Dirty = value;
                _totalPmtSavings.Dirty = value;
                _totalRentPmtOverYears.Dirty = value;
                _withinLimits1.Dirty = value;
                _withinLimits2.Dirty = value;
                _withinLimits3.Dirty = value;
                _withinLimits4.Dirty = value;
                _withinLimits5.Dirty = value;
                _withinLimits6.Dirty = value;
                _withinLimits7.Dirty = value;
                _withinLimits8.Dirty = value;
                _withinLimits9.Dirty = value;
                _yearsForComparison.Dirty = value;
                if (_prequalificationScenarios != null) _prequalificationScenarios.Dirty = value;
            }
        }
    }
}