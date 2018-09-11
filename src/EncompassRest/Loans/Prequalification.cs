using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Prequalification
    /// </summary>
    public sealed partial class Prequalification : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _afterTaxOwnMoSavings;
        /// <summary>
        /// Rent/Own Own Average After Tax Mo Pymt [PREQUAL.X327]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Own Average After Tax Mo Pymt")]
        public decimal? AfterTaxOwnMoSavings { get => _afterTaxOwnMoSavings; set => SetField(ref _afterTaxOwnMoSavings, value); }
        private DirtyValue<decimal?> _afterTaxRentMoSavings;
        /// <summary>
        /// Rent/Own Rent Average After Tax Mo Pymt [PREQUAL.X326]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Rent Average After Tax Mo Pymt")]
        public decimal? AfterTaxRentMoSavings { get => _afterTaxRentMoSavings; set => SetField(ref _afterTaxRentMoSavings, value); }
        private DirtyValue<decimal?> _annualHomeMaintenance;
        /// <summary>
        /// Rent/Own Annual Home Maintenance [PREQUAL.X322]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Rent/Own Annual Home Maintenance")]
        public decimal? AnnualHomeMaintenance { get => _annualHomeMaintenance; set => SetField(ref _annualHomeMaintenance, value); }
        private DirtyValue<decimal?> _avgMoPmtSavings;
        /// <summary>
        /// Rent/Own Average Mo Pymt Savings [PREQUAL.X317]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Average Mo Pymt Savings")]
        public decimal? AvgMoPmtSavings { get => _avgMoPmtSavings; set => SetField(ref _avgMoPmtSavings, value); }
        private DirtyValue<decimal?> _beforeTaxOwnMoPmt;
        /// <summary>
        /// Rent/Own Own Before Tax Mo Pymt [PREQUAL.X321]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Own Before Tax Mo Pymt")]
        public decimal? BeforeTaxOwnMoPmt { get => _beforeTaxOwnMoPmt; set => SetField(ref _beforeTaxOwnMoPmt, value); }
        private DirtyValue<decimal?> _beforeTaxRentMoPmt;
        /// <summary>
        /// Rent/Own Rent Before Tax Mo Pymt [PREQUAL.X320]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Rent Before Tax Mo Pymt")]
        public decimal? BeforeTaxRentMoPmt { get => _beforeTaxRentMoPmt; set => SetField(ref _beforeTaxRentMoPmt, value); }
        private DirtyValue<int?> _cashOutBalance;
        /// <summary>
        /// Debt Con Cash Out Bal [PREQUAL.X250]
        /// </summary>
        [LoanFieldProperty(Description = "Debt Con Cash Out Bal")]
        public int? CashOutBalance { get => _cashOutBalance; set => SetField(ref _cashOutBalance, value); }
        private DirtyValue<decimal?> _combinedGain;
        /// <summary>
        /// Rent/Own Combined Gain of Buying vs. Renting [PREQUAL.X333]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Combined Gain of Buying vs. Renting")]
        public decimal? CombinedGain { get => _combinedGain; set => SetField(ref _combinedGain, value); }
        private DirtyValue<decimal?> _costIncreasePerYear;
        /// <summary>
        /// Rent/Own Cost Increase per Year [PREQUAL.X216]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Rent/Own Cost Increase per Year")]
        public decimal? CostIncreasePerYear { get => _costIncreasePerYear; set => SetField(ref _costIncreasePerYear, value); }
        private DirtyValue<decimal?> _downPaymentAmount;
        /// <summary>
        /// Rent/Own Limits Down Pymt [PREQUAL.X203]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Limits Down Pymt")]
        public decimal? DownPaymentAmount { get => _downPaymentAmount; set => SetField(ref _downPaymentAmount, value); }
        private DirtyValue<string> _favorableOption;
        /// <summary>
        /// Rent/Own Favorable Option [PREQUAL.X316]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rent/Own Favorable Option")]
        public string FavorableOption { get => _favorableOption; set => SetField(ref _favorableOption, value); }
        private DirtyValue<decimal?> _homeSellingPriceAfterYears;
        /// <summary>
        /// Rent/Own Home Sellings Price After Years [PREQUAL.X328]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Home Sellings Price After Years")]
        public decimal? HomeSellingPriceAfterYears { get => _homeSellingPriceAfterYears; set => SetField(ref _homeSellingPriceAfterYears, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Prequalification Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _investmentGain;
        /// <summary>
        /// Rent/Own Investment Gain of Buying vs. Renting [PREQUAL.X331]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Investment Gain of Buying vs. Renting")]
        public decimal? InvestmentGain { get => _investmentGain; set => SetField(ref _investmentGain, value); }
        private DirtyValue<decimal?> _maxLoanLimit;
        /// <summary>
        /// Rent/Own Limits Max Loan [PREQUAL.X205]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Rent/Own Limits Max Loan")]
        public decimal? MaxLoanLimit { get => _maxLoanLimit; set => SetField(ref _maxLoanLimit, value); }
        private DirtyValue<decimal?> _maxPropValue;
        /// <summary>
        /// Rent/Own Limits Max Property Value [PREQUAL.X204]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Limits Max Property Value")]
        public decimal? MaxPropValue { get => _maxPropValue; set => SetField(ref _maxPropValue, value); }
        private DirtyValue<decimal?> _minusDownPmtAndClosingCosts;
        /// <summary>
        /// Rent/Own Minus Down Pymt/Initial Closing Costs [PREQUAL.X330]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Minus Down Pymt/Initial Closing Costs")]
        public decimal? MinusDownPmtAndClosingCosts { get => _minusDownPmtAndClosingCosts; set => SetField(ref _minusDownPmtAndClosingCosts, value); }
        private DirtyValue<decimal?> _minusLoanBalance;
        /// <summary>
        /// Rent/Own Minus Loan Balance [PREQUAL.X329]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Minus Loan Balance")]
        public decimal? MinusLoanBalance { get => _minusLoanBalance; set => SetField(ref _minusLoanBalance, value); }
        private DirtyValue<decimal?> _monthlyBenefit;
        /// <summary>
        /// Rent/Own Total Benefits Purch vs. Rent Monthly [PREQUAL.X231]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Total Benefits Purch vs. Rent Monthly")]
        public decimal? MonthlyBenefit { get => _monthlyBenefit; set => SetField(ref _monthlyBenefit, value); }
        private DirtyValue<decimal?> _monthlyHomeAppreciation;
        /// <summary>
        /// Rent/Own Home Appreciation Monthly [PREQUAL.X221]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Home Appreciation Monthly")]
        public decimal? MonthlyHomeAppreciation { get => _monthlyHomeAppreciation; set => SetField(ref _monthlyHomeAppreciation, value); }
        private DirtyValue<decimal?> _monthlyHomeEquity;
        /// <summary>
        /// Rent/Own Home Equity Monthly [PREQUAL.X219]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Home Equity Monthly")]
        public decimal? MonthlyHomeEquity { get => _monthlyHomeEquity; set => SetField(ref _monthlyHomeEquity, value); }
        private DirtyValue<decimal?> _monthlyIncomeTax;
        /// <summary>
        /// Rent/Own Income Tax Bracket Monthly [PREQUAL.X229]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Income Tax Bracket Monthly")]
        public decimal? MonthlyIncomeTax { get => _monthlyIncomeTax; set => SetField(ref _monthlyIncomeTax, value); }
        private DirtyValue<decimal?> _monthlyInvestmentInterest;
        /// <summary>
        /// Rent/Own Interest on Savings Monthly [PREQUAL.X224]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Interest on Savings Monthly")]
        public decimal? MonthlyInvestmentInterest { get => _monthlyInvestmentInterest; set => SetField(ref _monthlyInvestmentInterest, value); }
        private DirtyValue<int?> _monthlySavings;
        /// <summary>
        /// Loan Comp Monthly Pymt Svgs/Mo [PREQUAL.X245]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Comp Monthly Pymt Svgs/Mo")]
        public int? MonthlySavings { get => _monthlySavings; set => SetField(ref _monthlySavings, value); }
        private DirtyValue<string> _numberOfMonths;
        /// <summary>
        /// Rent/Own Compare Over # Mos [PREQUAL.X105]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rent/Own Compare Over # Mos")]
        public string NumberOfMonths { get => _numberOfMonths; set => SetField(ref _numberOfMonths, value); }
        private DirtyValue<decimal?> _percentAnnualHomeMaint;
        /// <summary>
        /// Rent/Own Annual Home Maintenance % [PREQUAL.X334]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rent/Own Annual Home Maintenance %")]
        public decimal? PercentAnnualHomeMaint { get => _percentAnnualHomeMaint; set => SetField(ref _percentAnnualHomeMaint, value); }
        private DirtyValue<decimal?> _percentOfHomeAppreciation;
        /// <summary>
        /// Rent/Own Home Appreciation %/Yr [PREQUAL.X107]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rent/Own Home Appreciation %/Yr")]
        public decimal? PercentOfHomeAppreciation { get => _percentOfHomeAppreciation; set => SetField(ref _percentOfHomeAppreciation, value); }
        private DirtyValue<decimal?> _percentOfIncomeTax;
        /// <summary>
        /// Rent/Own Income Tax Bracket % [PREQUAL.X228]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rent/Own Income Tax Bracket %")]
        public decimal? PercentOfIncomeTax { get => _percentOfIncomeTax; set => SetField(ref _percentOfIncomeTax, value); }
        private DirtyValue<decimal?> _percentOfInvestmentInterest;
        /// <summary>
        /// Rent/Own Interest on Savings %/Yr [PREQUAL.X223]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rent/Own Interest on Savings %/Yr")]
        public decimal? PercentOfInvestmentInterest { get => _percentOfInvestmentInterest; set => SetField(ref _percentOfInvestmentInterest, value); }
        private DirtyList<PrequalificationScenario> _prequalificationScenarios;
        /// <summary>
        /// Prequalification PrequalificationScenarios
        /// </summary>
        public IList<PrequalificationScenario> PrequalificationScenarios { get => GetField(ref _prequalificationScenarios); set => SetField(ref _prequalificationScenarios, value); }
        private DirtyValue<string> _qualificationStatus;
        /// <summary>
        /// Prequal Qualification Status [PREQUAL.X274]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Qualification Status")]
        public string QualificationStatus { get => _qualificationStatus; set => SetField(ref _qualificationStatus, value); }
        private DirtyValue<decimal?> _rentalCost;
        /// <summary>
        /// Rent/Own Mo Cost to Rent [PREQUAL.X99]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Mo Cost to Rent")]
        public decimal? RentalCost { get => _rentalCost; set => SetField(ref _rentalCost, value); }
        private DirtyValue<decimal?> _rentersInsurance;
        /// <summary>
        /// Rent/Own Mo Renters Insurance [PREQUAL.X319]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Rent/Own Mo Renters Insurance")]
        public decimal? RentersInsurance { get => _rentersInsurance; set => SetField(ref _rentersInsurance, value); }
        private DirtyValue<decimal?> _totalBenefit;
        /// <summary>
        /// Rent/Own Total Benefits Purch vs. Rent Total [PREQUAL.X232]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Total Benefits Purch vs. Rent Total")]
        public decimal? TotalBenefit { get => _totalBenefit; set => SetField(ref _totalBenefit, value); }
        private DirtyValue<decimal?> _totalCashFlow;
        /// <summary>
        /// Rent/Own Total Rent [PREQUAL.X217]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Total Rent")]
        public decimal? TotalCashFlow { get => _totalCashFlow; set => SetField(ref _totalCashFlow, value); }
        private DirtyValue<decimal?> _totalGain;
        /// <summary>
        /// Rent/Own Total Gain Over Years [PREQUAL.X318]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Total Gain Over Years")]
        public decimal? TotalGain { get => _totalGain; set => SetField(ref _totalGain, value); }
        private DirtyValue<decimal?> _totalHomeAppreciation;
        /// <summary>
        /// Rent/Own Home Appreciation Total [PREQUAL.X222]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Home Appreciation Total")]
        public decimal? TotalHomeAppreciation { get => _totalHomeAppreciation; set => SetField(ref _totalHomeAppreciation, value); }
        private DirtyValue<decimal?> _totalHomeEquity;
        /// <summary>
        /// Rent/Own Home Equity Total [PREQUAL.X220]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Home Equity Total")]
        public decimal? TotalHomeEquity { get => _totalHomeEquity; set => SetField(ref _totalHomeEquity, value); }
        private DirtyValue<decimal?> _totalHousingExpense;
        /// <summary>
        /// Rent/Own No Housing/Other Expenses Monthly [PREQUAL.X227]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own No Housing/Other Expenses Monthly")]
        public decimal? TotalHousingExpense { get => _totalHousingExpense; set => SetField(ref _totalHousingExpense, value); }
        private DirtyValue<decimal?> _totalIncomeTax;
        /// <summary>
        /// Rent/Own Income Tax Bracket Total [PREQUAL.X230]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Income Tax Bracket Total")]
        public decimal? TotalIncomeTax { get => _totalIncomeTax; set => SetField(ref _totalIncomeTax, value); }
        private DirtyValue<decimal?> _totalInvestmentInterest;
        /// <summary>
        /// Rent/Own Interest on Savings Total [PREQUAL.X225]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Interest on Savings Total")]
        public decimal? TotalInvestmentInterest { get => _totalInvestmentInterest; set => SetField(ref _totalInvestmentInterest, value); }
        private DirtyValue<int?> _totalLiabilityPayment;
        /// <summary>
        /// Debt Con Total Pymt [PREQUAL.X252]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Debt Con Total Pymt")]
        public int? TotalLiabilityPayment { get => _totalLiabilityPayment; set => SetField(ref _totalLiabilityPayment, value); }
        private DirtyValue<int?> _totalLiabilityUnpaid;
        /// <summary>
        /// Debt Con Total Paid Off Total Pymt [PREQUAL.X253]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Debt Con Total Paid Off Total Pymt")]
        public int? TotalLiabilityUnpaid { get => _totalLiabilityUnpaid; set => SetField(ref _totalLiabilityUnpaid, value); }
        private DirtyValue<int?> _totalLoanSavings;
        /// <summary>
        /// Debt Con Total Pymt Svgs/Mo [PREQUAL.X247]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Debt Con Total Pymt Svgs/Mo")]
        public int? TotalLoanSavings { get => _totalLoanSavings; set => SetField(ref _totalLoanSavings, value); }
        private DirtyValue<decimal?> _totalOtherExpenses;
        /// <summary>
        /// Prequal Total Other Expenses [PREQUAL.X294]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Prequal Total Other Expenses")]
        public decimal? TotalOtherExpenses { get => _totalOtherExpenses; set => SetField(ref _totalOtherExpenses, value); }
        private DirtyValue<decimal?> _totalOwnPmtOverYears;
        /// <summary>
        /// Rent/Own Own Total Pymt Over Years [PREQUAL.X324]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Own Total Pymt Over Years")]
        public decimal? TotalOwnPmtOverYears { get => _totalOwnPmtOverYears; set => SetField(ref _totalOwnPmtOverYears, value); }
        private DirtyValue<decimal?> _totalOwnTaxSavings;
        /// <summary>
        /// Rent/Own Own Total Tax Savings Over Years [PREQUAL.X325]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Own Total Tax Savings Over Years")]
        public decimal? TotalOwnTaxSavings { get => _totalOwnTaxSavings; set => SetField(ref _totalOwnTaxSavings, value); }
        private DirtyValue<int?> _totalPaidOffBalance;
        /// <summary>
        /// Debt Con Total Paid Off Bal [PREQUAL.X248]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Debt Con Total Paid Off Bal")]
        public int? TotalPaidOffBalance { get => _totalPaidOffBalance; set => SetField(ref _totalPaidOffBalance, value); }
        private DirtyValue<int?> _totalPaidOffMonthly;
        /// <summary>
        /// Debt Con Total Paid Off Mo Pymt [PREQUAL.X249]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Debt Con Total Paid Off Mo Pymt")]
        public int? TotalPaidOffMonthly { get => _totalPaidOffMonthly; set => SetField(ref _totalPaidOffMonthly, value); }
        private DirtyValue<decimal?> _totalPmtSavings;
        /// <summary>
        /// Rent/Own Total Pymt Savings [PREQUAL.X332]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Total Pymt Savings")]
        public decimal? TotalPmtSavings { get => _totalPmtSavings; set => SetField(ref _totalPmtSavings, value); }
        private DirtyValue<decimal?> _totalRentPmtOverYears;
        /// <summary>
        /// Rent/Own Rent Total Pymt Over Years [PREQUAL.X323]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Rent Total Pymt Over Years")]
        public decimal? TotalRentPmtOverYears { get => _totalRentPmtOverYears; set => SetField(ref _totalRentPmtOverYears, value); }
        private DirtyValue<string> _withinLimits1;
        /// <summary>
        /// Prequal Within Limits 1 [PREQUAL.X307]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 1")]
        public string WithinLimits1 { get => _withinLimits1; set => SetField(ref _withinLimits1, value); }
        private DirtyValue<string> _withinLimits2;
        /// <summary>
        /// Prequal Within Limits 2 [PREQUAL.X308]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 2")]
        public string WithinLimits2 { get => _withinLimits2; set => SetField(ref _withinLimits2, value); }
        private DirtyValue<string> _withinLimits3;
        /// <summary>
        /// Prequal Within Limits 3 [PREQUAL.X309]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 3")]
        public string WithinLimits3 { get => _withinLimits3; set => SetField(ref _withinLimits3, value); }
        private DirtyValue<string> _withinLimits4;
        /// <summary>
        /// Prequal Within Limits 4 [PREQUAL.X310]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 4")]
        public string WithinLimits4 { get => _withinLimits4; set => SetField(ref _withinLimits4, value); }
        private DirtyValue<string> _withinLimits5;
        /// <summary>
        /// Prequal Within Limits 5 [PREQUAL.X311]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 5")]
        public string WithinLimits5 { get => _withinLimits5; set => SetField(ref _withinLimits5, value); }
        private DirtyValue<string> _withinLimits6;
        /// <summary>
        /// Prequal Within Limits 6 [PREQUAL.X312]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 6")]
        public string WithinLimits6 { get => _withinLimits6; set => SetField(ref _withinLimits6, value); }
        private DirtyValue<string> _withinLimits7;
        /// <summary>
        /// Prequal Within Limits 7 [PREQUAL.X313]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 7")]
        public string WithinLimits7 { get => _withinLimits7; set => SetField(ref _withinLimits7, value); }
        private DirtyValue<string> _withinLimits8;
        /// <summary>
        /// Prequal Within Limits 8 [PREQUAL.X314]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 8")]
        public string WithinLimits8 { get => _withinLimits8; set => SetField(ref _withinLimits8, value); }
        private DirtyValue<string> _withinLimits9;
        /// <summary>
        /// Prequal Within Limits 9 [PREQUAL.X315]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 9")]
        public string WithinLimits9 { get => _withinLimits9; set => SetField(ref _withinLimits9, value); }
        private DirtyValue<int?> _yearsForComparison;
        /// <summary>
        /// Rent/Own How Many Years for this Comparison? [PREQUAL.X335]
        /// </summary>
        [LoanFieldProperty(Description = "Rent/Own How Many Years for this Comparison?")]
        public int? YearsForComparison { get => _yearsForComparison; set => SetField(ref _yearsForComparison, value); }
    }
}