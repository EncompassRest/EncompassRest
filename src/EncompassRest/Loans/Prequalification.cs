using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Prequalification
    /// </summary>
    public sealed partial class Prequalification : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _afterTaxOwnMoSavings;
        private DirtyValue<decimal?> _afterTaxRentMoSavings;
        private DirtyValue<decimal?> _annualHomeMaintenance;
        private DirtyValue<decimal?> _avgMoPmtSavings;
        private DirtyValue<decimal?> _beforeTaxOwnMoPmt;
        private DirtyValue<decimal?> _beforeTaxRentMoPmt;
        private DirtyValue<int?> _cashOutBalance;
        private DirtyValue<decimal?> _combinedGain;
        private DirtyValue<decimal?> _costIncreasePerYear;
        private DirtyValue<decimal?> _downPaymentAmount;
        private DirtyValue<string> _favorableOption;
        private DirtyValue<decimal?> _homeSellingPriceAfterYears;
        private DirtyValue<string> _id;
        private DirtyValue<decimal?> _investmentGain;
        private DirtyValue<decimal?> _maxLoanLimit;
        private DirtyValue<decimal?> _maxPropValue;
        private DirtyValue<decimal?> _minusDownPmtAndClosingCosts;
        private DirtyValue<decimal?> _minusLoanBalance;
        private DirtyValue<decimal?> _monthlyBenefit;
        private DirtyValue<decimal?> _monthlyHomeAppreciation;
        private DirtyValue<decimal?> _monthlyHomeEquity;
        private DirtyValue<decimal?> _monthlyIncomeTax;
        private DirtyValue<decimal?> _monthlyInvestmentInterest;
        private DirtyValue<int?> _monthlySavings;
        private DirtyValue<string> _numberOfMonths;
        private DirtyValue<decimal?> _percentAnnualHomeMaint;
        private DirtyValue<decimal?> _percentOfHomeAppreciation;
        private DirtyValue<decimal?> _percentOfIncomeTax;
        private DirtyValue<decimal?> _percentOfInvestmentInterest;
        private DirtyList<PrequalificationScenario> _prequalificationScenarios;
        private DirtyValue<string> _qualificationStatus;
        private DirtyValue<decimal?> _rentalCost;
        private DirtyValue<decimal?> _rentersInsurance;
        private DirtyValue<decimal?> _totalBenefit;
        private DirtyValue<decimal?> _totalCashFlow;
        private DirtyValue<decimal?> _totalGain;
        private DirtyValue<decimal?> _totalHomeAppreciation;
        private DirtyValue<decimal?> _totalHomeEquity;
        private DirtyValue<decimal?> _totalHousingExpense;
        private DirtyValue<decimal?> _totalIncomeTax;
        private DirtyValue<decimal?> _totalInvestmentInterest;
        private DirtyValue<int?> _totalLiabilityPayment;
        private DirtyValue<int?> _totalLiabilityUnpaid;
        private DirtyValue<int?> _totalLoanSavings;
        private DirtyValue<decimal?> _totalOtherExpenses;
        private DirtyValue<decimal?> _totalOwnPmtOverYears;
        private DirtyValue<decimal?> _totalOwnTaxSavings;
        private DirtyValue<int?> _totalPaidOffBalance;
        private DirtyValue<int?> _totalPaidOffMonthly;
        private DirtyValue<decimal?> _totalPmtSavings;
        private DirtyValue<decimal?> _totalRentPmtOverYears;
        private DirtyValue<string> _withinLimits1;
        private DirtyValue<string> _withinLimits2;
        private DirtyValue<string> _withinLimits3;
        private DirtyValue<string> _withinLimits4;
        private DirtyValue<string> _withinLimits5;
        private DirtyValue<string> _withinLimits6;
        private DirtyValue<string> _withinLimits7;
        private DirtyValue<string> _withinLimits8;
        private DirtyValue<string> _withinLimits9;
        private DirtyValue<int?> _yearsForComparison;

        /// <summary>
        /// Rent/Own Own Average After Tax Mo Pymt [PREQUAL.X327]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Own Average After Tax Mo Pymt")]
        public decimal? AfterTaxOwnMoSavings { get => _afterTaxOwnMoSavings; set => SetField(ref _afterTaxOwnMoSavings, value); }

        /// <summary>
        /// Rent/Own Rent Average After Tax Mo Pymt [PREQUAL.X326]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Rent Average After Tax Mo Pymt")]
        public decimal? AfterTaxRentMoSavings { get => _afterTaxRentMoSavings; set => SetField(ref _afterTaxRentMoSavings, value); }

        /// <summary>
        /// Rent/Own Annual Home Maintenance [PREQUAL.X322]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Rent/Own Annual Home Maintenance")]
        public decimal? AnnualHomeMaintenance { get => _annualHomeMaintenance; set => SetField(ref _annualHomeMaintenance, value); }

        /// <summary>
        /// Rent/Own Average Mo Pymt Savings [PREQUAL.X317]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Average Mo Pymt Savings")]
        public decimal? AvgMoPmtSavings { get => _avgMoPmtSavings; set => SetField(ref _avgMoPmtSavings, value); }

        /// <summary>
        /// Rent/Own Own Before Tax Mo Pymt [PREQUAL.X321]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Own Before Tax Mo Pymt")]
        public decimal? BeforeTaxOwnMoPmt { get => _beforeTaxOwnMoPmt; set => SetField(ref _beforeTaxOwnMoPmt, value); }

        /// <summary>
        /// Rent/Own Rent Before Tax Mo Pymt [PREQUAL.X320]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Rent Before Tax Mo Pymt")]
        public decimal? BeforeTaxRentMoPmt { get => _beforeTaxRentMoPmt; set => SetField(ref _beforeTaxRentMoPmt, value); }

        /// <summary>
        /// Debt Con Cash Out Bal [PREQUAL.X250]
        /// </summary>
        [LoanFieldProperty(Description = "Debt Con Cash Out Bal")]
        public int? CashOutBalance { get => _cashOutBalance; set => SetField(ref _cashOutBalance, value); }

        /// <summary>
        /// Rent/Own Combined Gain of Buying vs. Renting [PREQUAL.X333]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Combined Gain of Buying vs. Renting")]
        public decimal? CombinedGain { get => _combinedGain; set => SetField(ref _combinedGain, value); }

        /// <summary>
        /// Rent/Own Cost Increase per Year [PREQUAL.X216]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Rent/Own Cost Increase per Year")]
        public decimal? CostIncreasePerYear { get => _costIncreasePerYear; set => SetField(ref _costIncreasePerYear, value); }

        /// <summary>
        /// Rent/Own Limits Down Pymt [PREQUAL.X203]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Limits Down Pymt")]
        public decimal? DownPaymentAmount { get => _downPaymentAmount; set => SetField(ref _downPaymentAmount, value); }

        /// <summary>
        /// Rent/Own Favorable Option [PREQUAL.X316]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rent/Own Favorable Option")]
        public string FavorableOption { get => _favorableOption; set => SetField(ref _favorableOption, value); }

        /// <summary>
        /// Rent/Own Home Sellings Price After Years [PREQUAL.X328]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Home Sellings Price After Years")]
        public decimal? HomeSellingPriceAfterYears { get => _homeSellingPriceAfterYears; set => SetField(ref _homeSellingPriceAfterYears, value); }

        /// <summary>
        /// Prequalification Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Rent/Own Investment Gain of Buying vs. Renting [PREQUAL.X331]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Investment Gain of Buying vs. Renting")]
        public decimal? InvestmentGain { get => _investmentGain; set => SetField(ref _investmentGain, value); }

        /// <summary>
        /// Rent/Own Limits Max Loan [PREQUAL.X205]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Rent/Own Limits Max Loan")]
        public decimal? MaxLoanLimit { get => _maxLoanLimit; set => SetField(ref _maxLoanLimit, value); }

        /// <summary>
        /// Rent/Own Limits Max Property Value [PREQUAL.X204]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Limits Max Property Value")]
        public decimal? MaxPropValue { get => _maxPropValue; set => SetField(ref _maxPropValue, value); }

        /// <summary>
        /// Rent/Own Minus Down Pymt/Initial Closing Costs [PREQUAL.X330]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Minus Down Pymt/Initial Closing Costs")]
        public decimal? MinusDownPmtAndClosingCosts { get => _minusDownPmtAndClosingCosts; set => SetField(ref _minusDownPmtAndClosingCosts, value); }

        /// <summary>
        /// Rent/Own Minus Loan Balance [PREQUAL.X329]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Minus Loan Balance")]
        public decimal? MinusLoanBalance { get => _minusLoanBalance; set => SetField(ref _minusLoanBalance, value); }

        /// <summary>
        /// Rent/Own Total Benefits Purch vs. Rent Monthly [PREQUAL.X231]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Total Benefits Purch vs. Rent Monthly")]
        public decimal? MonthlyBenefit { get => _monthlyBenefit; set => SetField(ref _monthlyBenefit, value); }

        /// <summary>
        /// Rent/Own Home Appreciation Monthly [PREQUAL.X221]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Home Appreciation Monthly")]
        public decimal? MonthlyHomeAppreciation { get => _monthlyHomeAppreciation; set => SetField(ref _monthlyHomeAppreciation, value); }

        /// <summary>
        /// Rent/Own Home Equity Monthly [PREQUAL.X219]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Home Equity Monthly")]
        public decimal? MonthlyHomeEquity { get => _monthlyHomeEquity; set => SetField(ref _monthlyHomeEquity, value); }

        /// <summary>
        /// Rent/Own Income Tax Bracket Monthly [PREQUAL.X229]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Income Tax Bracket Monthly")]
        public decimal? MonthlyIncomeTax { get => _monthlyIncomeTax; set => SetField(ref _monthlyIncomeTax, value); }

        /// <summary>
        /// Rent/Own Interest on Savings Monthly [PREQUAL.X224]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Interest on Savings Monthly")]
        public decimal? MonthlyInvestmentInterest { get => _monthlyInvestmentInterest; set => SetField(ref _monthlyInvestmentInterest, value); }

        /// <summary>
        /// Loan Comp Monthly Pymt Svgs/Mo [PREQUAL.X245]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Comp Monthly Pymt Svgs/Mo")]
        public int? MonthlySavings { get => _monthlySavings; set => SetField(ref _monthlySavings, value); }

        /// <summary>
        /// Rent/Own Compare Over # Mos [PREQUAL.X105]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rent/Own Compare Over # Mos")]
        public string NumberOfMonths { get => _numberOfMonths; set => SetField(ref _numberOfMonths, value); }

        /// <summary>
        /// Rent/Own Annual Home Maintenance % [PREQUAL.X334]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rent/Own Annual Home Maintenance %")]
        public decimal? PercentAnnualHomeMaint { get => _percentAnnualHomeMaint; set => SetField(ref _percentAnnualHomeMaint, value); }

        /// <summary>
        /// Rent/Own Home Appreciation %/Yr [PREQUAL.X107]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rent/Own Home Appreciation %/Yr")]
        public decimal? PercentOfHomeAppreciation { get => _percentOfHomeAppreciation; set => SetField(ref _percentOfHomeAppreciation, value); }

        /// <summary>
        /// Rent/Own Income Tax Bracket % [PREQUAL.X228]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rent/Own Income Tax Bracket %")]
        public decimal? PercentOfIncomeTax { get => _percentOfIncomeTax; set => SetField(ref _percentOfIncomeTax, value); }

        /// <summary>
        /// Rent/Own Interest on Savings %/Yr [PREQUAL.X223]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rent/Own Interest on Savings %/Yr")]
        public decimal? PercentOfInvestmentInterest { get => _percentOfInvestmentInterest; set => SetField(ref _percentOfInvestmentInterest, value); }

        /// <summary>
        /// Prequalification PrequalificationScenarios
        /// </summary>
        public IList<PrequalificationScenario> PrequalificationScenarios { get => GetField(ref _prequalificationScenarios); set => SetField(ref _prequalificationScenarios, value); }

        /// <summary>
        /// Prequal Qualification Status [PREQUAL.X274]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Qualification Status")]
        public string QualificationStatus { get => _qualificationStatus; set => SetField(ref _qualificationStatus, value); }

        /// <summary>
        /// Rent/Own Mo Cost to Rent [PREQUAL.X99]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Mo Cost to Rent")]
        public decimal? RentalCost { get => _rentalCost; set => SetField(ref _rentalCost, value); }

        /// <summary>
        /// Rent/Own Mo Renters Insurance [PREQUAL.X319]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Rent/Own Mo Renters Insurance")]
        public decimal? RentersInsurance { get => _rentersInsurance; set => SetField(ref _rentersInsurance, value); }

        /// <summary>
        /// Rent/Own Total Benefits Purch vs. Rent Total [PREQUAL.X232]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Total Benefits Purch vs. Rent Total")]
        public decimal? TotalBenefit { get => _totalBenefit; set => SetField(ref _totalBenefit, value); }

        /// <summary>
        /// Rent/Own Total Rent [PREQUAL.X217]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Total Rent")]
        public decimal? TotalCashFlow { get => _totalCashFlow; set => SetField(ref _totalCashFlow, value); }

        /// <summary>
        /// Rent/Own Total Gain Over Years [PREQUAL.X318]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Total Gain Over Years")]
        public decimal? TotalGain { get => _totalGain; set => SetField(ref _totalGain, value); }

        /// <summary>
        /// Rent/Own Home Appreciation Total [PREQUAL.X222]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Home Appreciation Total")]
        public decimal? TotalHomeAppreciation { get => _totalHomeAppreciation; set => SetField(ref _totalHomeAppreciation, value); }

        /// <summary>
        /// Rent/Own Home Equity Total [PREQUAL.X220]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Home Equity Total")]
        public decimal? TotalHomeEquity { get => _totalHomeEquity; set => SetField(ref _totalHomeEquity, value); }

        /// <summary>
        /// Rent/Own No Housing/Other Expenses Monthly [PREQUAL.X227]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own No Housing/Other Expenses Monthly")]
        public decimal? TotalHousingExpense { get => _totalHousingExpense; set => SetField(ref _totalHousingExpense, value); }

        /// <summary>
        /// Rent/Own Income Tax Bracket Total [PREQUAL.X230]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Income Tax Bracket Total")]
        public decimal? TotalIncomeTax { get => _totalIncomeTax; set => SetField(ref _totalIncomeTax, value); }

        /// <summary>
        /// Rent/Own Interest on Savings Total [PREQUAL.X225]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Interest on Savings Total")]
        public decimal? TotalInvestmentInterest { get => _totalInvestmentInterest; set => SetField(ref _totalInvestmentInterest, value); }

        /// <summary>
        /// Debt Con Total Pymt [PREQUAL.X252]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Debt Con Total Pymt")]
        public int? TotalLiabilityPayment { get => _totalLiabilityPayment; set => SetField(ref _totalLiabilityPayment, value); }

        /// <summary>
        /// Debt Con Total Paid Off Total Pymt [PREQUAL.X253]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Debt Con Total Paid Off Total Pymt")]
        public int? TotalLiabilityUnpaid { get => _totalLiabilityUnpaid; set => SetField(ref _totalLiabilityUnpaid, value); }

        /// <summary>
        /// Debt Con Total Pymt Svgs/Mo [PREQUAL.X247]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Debt Con Total Pymt Svgs/Mo")]
        public int? TotalLoanSavings { get => _totalLoanSavings; set => SetField(ref _totalLoanSavings, value); }

        /// <summary>
        /// Prequal Total Other Expenses [PREQUAL.X294]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Prequal Total Other Expenses")]
        public decimal? TotalOtherExpenses { get => _totalOtherExpenses; set => SetField(ref _totalOtherExpenses, value); }

        /// <summary>
        /// Rent/Own Own Total Pymt Over Years [PREQUAL.X324]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Own Total Pymt Over Years")]
        public decimal? TotalOwnPmtOverYears { get => _totalOwnPmtOverYears; set => SetField(ref _totalOwnPmtOverYears, value); }

        /// <summary>
        /// Rent/Own Own Total Tax Savings Over Years [PREQUAL.X325]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Own Total Tax Savings Over Years")]
        public decimal? TotalOwnTaxSavings { get => _totalOwnTaxSavings; set => SetField(ref _totalOwnTaxSavings, value); }

        /// <summary>
        /// Debt Con Total Paid Off Bal [PREQUAL.X248]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Debt Con Total Paid Off Bal")]
        public int? TotalPaidOffBalance { get => _totalPaidOffBalance; set => SetField(ref _totalPaidOffBalance, value); }

        /// <summary>
        /// Debt Con Total Paid Off Mo Pymt [PREQUAL.X249]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Debt Con Total Paid Off Mo Pymt")]
        public int? TotalPaidOffMonthly { get => _totalPaidOffMonthly; set => SetField(ref _totalPaidOffMonthly, value); }

        /// <summary>
        /// Rent/Own Total Pymt Savings [PREQUAL.X332]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Total Pymt Savings")]
        public decimal? TotalPmtSavings { get => _totalPmtSavings; set => SetField(ref _totalPmtSavings, value); }

        /// <summary>
        /// Rent/Own Rent Total Pymt Over Years [PREQUAL.X323]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Rent Total Pymt Over Years")]
        public decimal? TotalRentPmtOverYears { get => _totalRentPmtOverYears; set => SetField(ref _totalRentPmtOverYears, value); }

        /// <summary>
        /// Prequal Within Limits 1 [PREQUAL.X307]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 1")]
        public string WithinLimits1 { get => _withinLimits1; set => SetField(ref _withinLimits1, value); }

        /// <summary>
        /// Prequal Within Limits 2 [PREQUAL.X308]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 2")]
        public string WithinLimits2 { get => _withinLimits2; set => SetField(ref _withinLimits2, value); }

        /// <summary>
        /// Prequal Within Limits 3 [PREQUAL.X309]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 3")]
        public string WithinLimits3 { get => _withinLimits3; set => SetField(ref _withinLimits3, value); }

        /// <summary>
        /// Prequal Within Limits 4 [PREQUAL.X310]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 4")]
        public string WithinLimits4 { get => _withinLimits4; set => SetField(ref _withinLimits4, value); }

        /// <summary>
        /// Prequal Within Limits 5 [PREQUAL.X311]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 5")]
        public string WithinLimits5 { get => _withinLimits5; set => SetField(ref _withinLimits5, value); }

        /// <summary>
        /// Prequal Within Limits 6 [PREQUAL.X312]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 6")]
        public string WithinLimits6 { get => _withinLimits6; set => SetField(ref _withinLimits6, value); }

        /// <summary>
        /// Prequal Within Limits 7 [PREQUAL.X313]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 7")]
        public string WithinLimits7 { get => _withinLimits7; set => SetField(ref _withinLimits7, value); }

        /// <summary>
        /// Prequal Within Limits 8 [PREQUAL.X314]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 8")]
        public string WithinLimits8 { get => _withinLimits8; set => SetField(ref _withinLimits8, value); }

        /// <summary>
        /// Prequal Within Limits 9 [PREQUAL.X315]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 9")]
        public string WithinLimits9 { get => _withinLimits9; set => SetField(ref _withinLimits9, value); }

        /// <summary>
        /// Rent/Own How Many Years for this Comparison? [PREQUAL.X335]
        /// </summary>
        [LoanFieldProperty(Description = "Rent/Own How Many Years for this Comparison?")]
        public int? YearsForComparison { get => _yearsForComparison; set => SetField(ref _yearsForComparison, value); }
    }
}