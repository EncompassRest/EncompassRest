using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Prequalification
    {
        public JsonNullable<decimal?> AfterTaxOwnMoSavings { get; set; }
        public JsonNullable<decimal?> AfterTaxRentMoSavings { get; set; }
        public JsonNullable<decimal?> AnnualHomeMaintenance { get; set; }
        public JsonNullable<decimal?> AvgMoPmtSavings { get; set; }
        public JsonNullable<decimal?> BeforeTaxOwnMoPmt { get; set; }
        public JsonNullable<decimal?> BeforeTaxRentMoPmt { get; set; }
        public JsonNullable<int?> CashOutBalance { get; set; }
        public JsonNullable<decimal?> CombinedGain { get; set; }
        public JsonNullable<decimal?> CostIncreasePerYear { get; set; }
        public JsonNullable<decimal?> DownPaymentAmount { get; set; }
        public string FavorableOption { get; set; }
        public JsonNullable<decimal?> HomeSellingPriceAfterYears { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> InvestmentGain { get; set; }
        public JsonNullable<decimal?> MaxLoanLimit { get; set; }
        public JsonNullable<decimal?> MaxPropValue { get; set; }
        public JsonNullable<decimal?> MinusDownPmtAndClosingCosts { get; set; }
        public JsonNullable<decimal?> MinusLoanBalance { get; set; }
        public JsonNullable<decimal?> MonthlyBenefit { get; set; }
        public JsonNullable<decimal?> MonthlyHomeAppreciation { get; set; }
        public JsonNullable<decimal?> MonthlyHomeEquity { get; set; }
        public JsonNullable<decimal?> MonthlyIncomeTax { get; set; }
        public JsonNullable<decimal?> MonthlyInvestmentInterest { get; set; }
        public JsonNullable<int?> MonthlySavings { get; set; }
        public string NumberOfMonths { get; set; }
        public JsonNullable<decimal?> PercentAnnualHomeMaint { get; set; }
        public JsonNullable<decimal?> PercentOfHomeAppreciation { get; set; }
        public JsonNullable<decimal?> PercentOfIncomeTax { get; set; }
        public JsonNullable<decimal?> PercentOfInvestmentInterest { get; set; }
        public JsonNullable<List<PrequalificationScenario>> PrequalificationScenarios { get; set; }
        public string QualificationStatus { get; set; }
        public JsonNullable<decimal?> RentalCost { get; set; }
        public JsonNullable<decimal?> RentersInsurance { get; set; }
        public JsonNullable<decimal?> TotalBenefit { get; set; }
        public JsonNullable<decimal?> TotalCashFlow { get; set; }
        public JsonNullable<decimal?> TotalGain { get; set; }
        public JsonNullable<decimal?> TotalHomeAppreciation { get; set; }
        public JsonNullable<decimal?> TotalHomeEquity { get; set; }
        public JsonNullable<decimal?> TotalHousingExpense { get; set; }
        public JsonNullable<decimal?> TotalIncomeTax { get; set; }
        public JsonNullable<decimal?> TotalInvestmentInterest { get; set; }
        public JsonNullable<int?> TotalLiabilityPayment { get; set; }
        public JsonNullable<int?> TotalLiabilityUnpaid { get; set; }
        public JsonNullable<int?> TotalLoanSavings { get; set; }
        public JsonNullable<decimal?> TotalOtherExpenses { get; set; }
        public JsonNullable<decimal?> TotalOwnPmtOverYears { get; set; }
        public JsonNullable<decimal?> TotalOwnTaxSavings { get; set; }
        public JsonNullable<int?> TotalPaidOffBalance { get; set; }
        public JsonNullable<int?> TotalPaidOffMonthly { get; set; }
        public JsonNullable<decimal?> TotalPmtSavings { get; set; }
        public JsonNullable<decimal?> TotalRentPmtOverYears { get; set; }
        public string WithinLimits1 { get; set; }
        public string WithinLimits2 { get; set; }
        public string WithinLimits3 { get; set; }
        public string WithinLimits4 { get; set; }
        public string WithinLimits5 { get; set; }
        public string WithinLimits6 { get; set; }
        public string WithinLimits7 { get; set; }
        public string WithinLimits8 { get; set; }
        public string WithinLimits9 { get; set; }
        public JsonNullable<int?> YearsForComparison { get; set; }
    }
}