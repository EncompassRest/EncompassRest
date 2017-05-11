using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Prequalification
    {
        public string NumberOfMonths { get; set; }
        public decimal? PercentOfHomeAppreciation { get; set; }
        public List<PrequalificationScenario> PrequalificationScenarios { get; set; }
        public decimal? DownPaymentAmount { get; set; }
        public decimal? MaxPropValue { get; set; }
        public decimal? MaxLoanLimit { get; set; }
        public decimal? CostIncreasePerYear { get; set; }
        public decimal? TotalCashFlow { get; set; }
        public decimal? MonthlyHomeEquity { get; set; }
        public decimal? TotalHomeEquity { get; set; }
        public decimal? MonthlyHomeAppreciation { get; set; }
        public decimal? TotalHomeAppreciation { get; set; }
        public decimal? PercentOfInvestmentInterest { get; set; }
        public decimal? MonthlyInvestmentInterest { get; set; }
        public decimal? TotalInvestmentInterest { get; set; }
        public decimal? TotalHousingExpense { get; set; }
        public decimal? PercentOfIncomeTax { get; set; }
        public decimal? MonthlyIncomeTax { get; set; }
        public decimal? TotalIncomeTax { get; set; }
        public decimal? MonthlyBenefit { get; set; }
        public decimal? TotalBenefit { get; set; }
        public int? MonthlySavings { get; set; }
        public int? TotalLoanSavings { get; set; }
        public int? TotalPaidOffBalance { get; set; }
        public int? TotalPaidOffMonthly { get; set; }
        public int? CashOutBalance { get; set; }
        public int? TotalLiabilityPayment { get; set; }
        public int? TotalLiabilityUnpaid { get; set; }
        public string QualificationStatus { get; set; }
        public decimal? TotalOtherExpenses { get; set; }
        public string WithinLimits1 { get; set; }
        public string WithinLimits2 { get; set; }
        public string WithinLimits3 { get; set; }
        public string WithinLimits4 { get; set; }
        public string WithinLimits5 { get; set; }
        public string WithinLimits6 { get; set; }
        public string WithinLimits7 { get; set; }
        public string WithinLimits8 { get; set; }
        public string WithinLimits9 { get; set; }
        public string FavorableOption { get; set; }
        public decimal? AvgMoPmtSavings { get; set; }
        public decimal? TotalGain { get; set; }
        public decimal? RentersInsurance { get; set; }
        public decimal? BeforeTaxRentMoPmt { get; set; }
        public decimal? BeforeTaxOwnMoPmt { get; set; }
        public decimal? AnnualHomeMaintenance { get; set; }
        public decimal? TotalRentPmtOverYears { get; set; }
        public decimal? TotalOwnPmtOverYears { get; set; }
        public decimal? TotalOwnTaxSavings { get; set; }
        public decimal? AfterTaxRentMoSavings { get; set; }
        public decimal? AfterTaxOwnMoSavings { get; set; }
        public decimal? HomeSellingPriceAfterYears { get; set; }
        public decimal? MinusLoanBalance { get; set; }
        public decimal? MinusDownPmtAndClosingCosts { get; set; }
        public decimal? InvestmentGain { get; set; }
        public decimal? TotalPmtSavings { get; set; }
        public decimal? CombinedGain { get; set; }
        public decimal? PercentAnnualHomeMaint { get; set; }
        public int? YearsForComparison { get; set; }
        public decimal? RentalCost { get; set; }
        public string Id { get; set; }
    }
}