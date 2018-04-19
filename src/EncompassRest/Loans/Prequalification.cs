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
        public decimal? AfterTaxOwnMoSavings { get => _afterTaxOwnMoSavings; set => _afterTaxOwnMoSavings = value; }
        private DirtyValue<decimal?> _afterTaxRentMoSavings;
        /// <summary>
        /// Rent/Own Rent Average After Tax Mo Pymt [PREQUAL.X326]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Rent Average After Tax Mo Pymt")]
        public decimal? AfterTaxRentMoSavings { get => _afterTaxRentMoSavings; set => _afterTaxRentMoSavings = value; }
        private DirtyValue<decimal?> _annualHomeMaintenance;
        /// <summary>
        /// Rent/Own Annual Home Maintenance [PREQUAL.X322]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Rent/Own Annual Home Maintenance")]
        public decimal? AnnualHomeMaintenance { get => _annualHomeMaintenance; set => _annualHomeMaintenance = value; }
        private DirtyValue<decimal?> _avgMoPmtSavings;
        /// <summary>
        /// Rent/Own Average Mo Pymt Savings [PREQUAL.X317]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Average Mo Pymt Savings")]
        public decimal? AvgMoPmtSavings { get => _avgMoPmtSavings; set => _avgMoPmtSavings = value; }
        private DirtyValue<decimal?> _beforeTaxOwnMoPmt;
        /// <summary>
        /// Rent/Own Own Before Tax Mo Pymt [PREQUAL.X321]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Own Before Tax Mo Pymt")]
        public decimal? BeforeTaxOwnMoPmt { get => _beforeTaxOwnMoPmt; set => _beforeTaxOwnMoPmt = value; }
        private DirtyValue<decimal?> _beforeTaxRentMoPmt;
        /// <summary>
        /// Rent/Own Rent Before Tax Mo Pymt [PREQUAL.X320]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Rent Before Tax Mo Pymt")]
        public decimal? BeforeTaxRentMoPmt { get => _beforeTaxRentMoPmt; set => _beforeTaxRentMoPmt = value; }
        private DirtyValue<int?> _cashOutBalance;
        /// <summary>
        /// Debt Con Cash Out Bal [PREQUAL.X250]
        /// </summary>
        [LoanFieldProperty(Description = "Debt Con Cash Out Bal")]
        public int? CashOutBalance { get => _cashOutBalance; set => _cashOutBalance = value; }
        private DirtyValue<decimal?> _combinedGain;
        /// <summary>
        /// Rent/Own Combined Gain of Buying vs. Renting [PREQUAL.X333]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Combined Gain of Buying vs. Renting")]
        public decimal? CombinedGain { get => _combinedGain; set => _combinedGain = value; }
        private DirtyValue<decimal?> _costIncreasePerYear;
        /// <summary>
        /// Rent/Own Cost Increase per Year [PREQUAL.X216]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Rent/Own Cost Increase per Year")]
        public decimal? CostIncreasePerYear { get => _costIncreasePerYear; set => _costIncreasePerYear = value; }
        private DirtyValue<decimal?> _downPaymentAmount;
        /// <summary>
        /// Rent/Own Limits Down Pymt [PREQUAL.X203]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Limits Down Pymt")]
        public decimal? DownPaymentAmount { get => _downPaymentAmount; set => _downPaymentAmount = value; }
        private DirtyValue<string> _favorableOption;
        /// <summary>
        /// Rent/Own Favorable Option [PREQUAL.X316]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rent/Own Favorable Option")]
        public string FavorableOption { get => _favorableOption; set => _favorableOption = value; }
        private DirtyValue<decimal?> _homeSellingPriceAfterYears;
        /// <summary>
        /// Rent/Own Home Sellings Price After Years [PREQUAL.X328]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Home Sellings Price After Years")]
        public decimal? HomeSellingPriceAfterYears { get => _homeSellingPriceAfterYears; set => _homeSellingPriceAfterYears = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Prequalification Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _investmentGain;
        /// <summary>
        /// Rent/Own Investment Gain of Buying vs. Renting [PREQUAL.X331]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Investment Gain of Buying vs. Renting")]
        public decimal? InvestmentGain { get => _investmentGain; set => _investmentGain = value; }
        private DirtyValue<decimal?> _maxLoanLimit;
        /// <summary>
        /// Rent/Own Limits Max Loan [PREQUAL.X205]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Rent/Own Limits Max Loan")]
        public decimal? MaxLoanLimit { get => _maxLoanLimit; set => _maxLoanLimit = value; }
        private DirtyValue<decimal?> _maxPropValue;
        /// <summary>
        /// Rent/Own Limits Max Property Value [PREQUAL.X204]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Limits Max Property Value")]
        public decimal? MaxPropValue { get => _maxPropValue; set => _maxPropValue = value; }
        private DirtyValue<decimal?> _minusDownPmtAndClosingCosts;
        /// <summary>
        /// Rent/Own Minus Down Pymt/Initial Closing Costs [PREQUAL.X330]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Minus Down Pymt/Initial Closing Costs")]
        public decimal? MinusDownPmtAndClosingCosts { get => _minusDownPmtAndClosingCosts; set => _minusDownPmtAndClosingCosts = value; }
        private DirtyValue<decimal?> _minusLoanBalance;
        /// <summary>
        /// Rent/Own Minus Loan Balance [PREQUAL.X329]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Minus Loan Balance")]
        public decimal? MinusLoanBalance { get => _minusLoanBalance; set => _minusLoanBalance = value; }
        private DirtyValue<decimal?> _monthlyBenefit;
        /// <summary>
        /// Rent/Own Total Benefits Purch vs. Rent Monthly [PREQUAL.X231]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Total Benefits Purch vs. Rent Monthly")]
        public decimal? MonthlyBenefit { get => _monthlyBenefit; set => _monthlyBenefit = value; }
        private DirtyValue<decimal?> _monthlyHomeAppreciation;
        /// <summary>
        /// Rent/Own Home Appreciation Monthly [PREQUAL.X221]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Home Appreciation Monthly")]
        public decimal? MonthlyHomeAppreciation { get => _monthlyHomeAppreciation; set => _monthlyHomeAppreciation = value; }
        private DirtyValue<decimal?> _monthlyHomeEquity;
        /// <summary>
        /// Rent/Own Home Equity Monthly [PREQUAL.X219]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Home Equity Monthly")]
        public decimal? MonthlyHomeEquity { get => _monthlyHomeEquity; set => _monthlyHomeEquity = value; }
        private DirtyValue<decimal?> _monthlyIncomeTax;
        /// <summary>
        /// Rent/Own Income Tax Bracket Monthly [PREQUAL.X229]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Income Tax Bracket Monthly")]
        public decimal? MonthlyIncomeTax { get => _monthlyIncomeTax; set => _monthlyIncomeTax = value; }
        private DirtyValue<decimal?> _monthlyInvestmentInterest;
        /// <summary>
        /// Rent/Own Interest on Savings Monthly [PREQUAL.X224]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Interest on Savings Monthly")]
        public decimal? MonthlyInvestmentInterest { get => _monthlyInvestmentInterest; set => _monthlyInvestmentInterest = value; }
        private DirtyValue<int?> _monthlySavings;
        /// <summary>
        /// Loan Comp Monthly Pymt Svgs/Mo [PREQUAL.X245]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Comp Monthly Pymt Svgs/Mo")]
        public int? MonthlySavings { get => _monthlySavings; set => _monthlySavings = value; }
        private DirtyValue<string> _numberOfMonths;
        /// <summary>
        /// Rent/Own Compare Over # Mos [PREQUAL.X105]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rent/Own Compare Over # Mos")]
        public string NumberOfMonths { get => _numberOfMonths; set => _numberOfMonths = value; }
        private DirtyValue<decimal?> _percentAnnualHomeMaint;
        /// <summary>
        /// Rent/Own Annual Home Maintenance % [PREQUAL.X334]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rent/Own Annual Home Maintenance %")]
        public decimal? PercentAnnualHomeMaint { get => _percentAnnualHomeMaint; set => _percentAnnualHomeMaint = value; }
        private DirtyValue<decimal?> _percentOfHomeAppreciation;
        /// <summary>
        /// Rent/Own Home Appreciation %/Yr [PREQUAL.X107]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rent/Own Home Appreciation %/Yr")]
        public decimal? PercentOfHomeAppreciation { get => _percentOfHomeAppreciation; set => _percentOfHomeAppreciation = value; }
        private DirtyValue<decimal?> _percentOfIncomeTax;
        /// <summary>
        /// Rent/Own Income Tax Bracket % [PREQUAL.X228]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rent/Own Income Tax Bracket %")]
        public decimal? PercentOfIncomeTax { get => _percentOfIncomeTax; set => _percentOfIncomeTax = value; }
        private DirtyValue<decimal?> _percentOfInvestmentInterest;
        /// <summary>
        /// Rent/Own Interest on Savings %/Yr [PREQUAL.X223]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rent/Own Interest on Savings %/Yr")]
        public decimal? PercentOfInvestmentInterest { get => _percentOfInvestmentInterest; set => _percentOfInvestmentInterest = value; }
        private DirtyList<PrequalificationScenario> _prequalificationScenarios;
        /// <summary>
        /// Prequalification PrequalificationScenarios
        /// </summary>
        public IList<PrequalificationScenario> PrequalificationScenarios { get => _prequalificationScenarios ?? (_prequalificationScenarios = new DirtyList<PrequalificationScenario>()); set => _prequalificationScenarios = new DirtyList<PrequalificationScenario>(value); }
        private DirtyValue<string> _qualificationStatus;
        /// <summary>
        /// Prequal Qualification Status [PREQUAL.X274]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Qualification Status")]
        public string QualificationStatus { get => _qualificationStatus; set => _qualificationStatus = value; }
        private DirtyValue<decimal?> _rentalCost;
        /// <summary>
        /// Rent/Own Mo Cost to Rent [PREQUAL.X99]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Mo Cost to Rent")]
        public decimal? RentalCost { get => _rentalCost; set => _rentalCost = value; }
        private DirtyValue<decimal?> _rentersInsurance;
        /// <summary>
        /// Rent/Own Mo Renters Insurance [PREQUAL.X319]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Rent/Own Mo Renters Insurance")]
        public decimal? RentersInsurance { get => _rentersInsurance; set => _rentersInsurance = value; }
        private DirtyValue<decimal?> _totalBenefit;
        /// <summary>
        /// Rent/Own Total Benefits Purch vs. Rent Total [PREQUAL.X232]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Total Benefits Purch vs. Rent Total")]
        public decimal? TotalBenefit { get => _totalBenefit; set => _totalBenefit = value; }
        private DirtyValue<decimal?> _totalCashFlow;
        /// <summary>
        /// Rent/Own Total Rent [PREQUAL.X217]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Total Rent")]
        public decimal? TotalCashFlow { get => _totalCashFlow; set => _totalCashFlow = value; }
        private DirtyValue<decimal?> _totalGain;
        /// <summary>
        /// Rent/Own Total Gain Over Years [PREQUAL.X318]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Total Gain Over Years")]
        public decimal? TotalGain { get => _totalGain; set => _totalGain = value; }
        private DirtyValue<decimal?> _totalHomeAppreciation;
        /// <summary>
        /// Rent/Own Home Appreciation Total [PREQUAL.X222]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Home Appreciation Total")]
        public decimal? TotalHomeAppreciation { get => _totalHomeAppreciation; set => _totalHomeAppreciation = value; }
        private DirtyValue<decimal?> _totalHomeEquity;
        /// <summary>
        /// Rent/Own Home Equity Total [PREQUAL.X220]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Home Equity Total")]
        public decimal? TotalHomeEquity { get => _totalHomeEquity; set => _totalHomeEquity = value; }
        private DirtyValue<decimal?> _totalHousingExpense;
        /// <summary>
        /// Rent/Own No Housing/Other Expenses Monthly [PREQUAL.X227]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own No Housing/Other Expenses Monthly")]
        public decimal? TotalHousingExpense { get => _totalHousingExpense; set => _totalHousingExpense = value; }
        private DirtyValue<decimal?> _totalIncomeTax;
        /// <summary>
        /// Rent/Own Income Tax Bracket Total [PREQUAL.X230]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Income Tax Bracket Total")]
        public decimal? TotalIncomeTax { get => _totalIncomeTax; set => _totalIncomeTax = value; }
        private DirtyValue<decimal?> _totalInvestmentInterest;
        /// <summary>
        /// Rent/Own Interest on Savings Total [PREQUAL.X225]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Interest on Savings Total")]
        public decimal? TotalInvestmentInterest { get => _totalInvestmentInterest; set => _totalInvestmentInterest = value; }
        private DirtyValue<int?> _totalLiabilityPayment;
        /// <summary>
        /// Debt Con Total Pymt [PREQUAL.X252]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Debt Con Total Pymt")]
        public int? TotalLiabilityPayment { get => _totalLiabilityPayment; set => _totalLiabilityPayment = value; }
        private DirtyValue<int?> _totalLiabilityUnpaid;
        /// <summary>
        /// Debt Con Total Paid Off Total Pymt [PREQUAL.X253]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Debt Con Total Paid Off Total Pymt")]
        public int? TotalLiabilityUnpaid { get => _totalLiabilityUnpaid; set => _totalLiabilityUnpaid = value; }
        private DirtyValue<int?> _totalLoanSavings;
        /// <summary>
        /// Debt Con Total Pymt Svgs/Mo [PREQUAL.X247]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Debt Con Total Pymt Svgs/Mo")]
        public int? TotalLoanSavings { get => _totalLoanSavings; set => _totalLoanSavings = value; }
        private DirtyValue<decimal?> _totalOtherExpenses;
        /// <summary>
        /// Prequal Total Other Expenses [PREQUAL.X294]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Prequal Total Other Expenses")]
        public decimal? TotalOtherExpenses { get => _totalOtherExpenses; set => _totalOtherExpenses = value; }
        private DirtyValue<decimal?> _totalOwnPmtOverYears;
        /// <summary>
        /// Rent/Own Own Total Pymt Over Years [PREQUAL.X324]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Own Total Pymt Over Years")]
        public decimal? TotalOwnPmtOverYears { get => _totalOwnPmtOverYears; set => _totalOwnPmtOverYears = value; }
        private DirtyValue<decimal?> _totalOwnTaxSavings;
        /// <summary>
        /// Rent/Own Own Total Tax Savings Over Years [PREQUAL.X325]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Own Total Tax Savings Over Years")]
        public decimal? TotalOwnTaxSavings { get => _totalOwnTaxSavings; set => _totalOwnTaxSavings = value; }
        private DirtyValue<int?> _totalPaidOffBalance;
        /// <summary>
        /// Debt Con Total Paid Off Bal [PREQUAL.X248]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Debt Con Total Paid Off Bal")]
        public int? TotalPaidOffBalance { get => _totalPaidOffBalance; set => _totalPaidOffBalance = value; }
        private DirtyValue<int?> _totalPaidOffMonthly;
        /// <summary>
        /// Debt Con Total Paid Off Mo Pymt [PREQUAL.X249]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Debt Con Total Paid Off Mo Pymt")]
        public int? TotalPaidOffMonthly { get => _totalPaidOffMonthly; set => _totalPaidOffMonthly = value; }
        private DirtyValue<decimal?> _totalPmtSavings;
        /// <summary>
        /// Rent/Own Total Pymt Savings [PREQUAL.X332]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Total Pymt Savings")]
        public decimal? TotalPmtSavings { get => _totalPmtSavings; set => _totalPmtSavings = value; }
        private DirtyValue<decimal?> _totalRentPmtOverYears;
        /// <summary>
        /// Rent/Own Rent Total Pymt Over Years [PREQUAL.X323]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Rent/Own Rent Total Pymt Over Years")]
        public decimal? TotalRentPmtOverYears { get => _totalRentPmtOverYears; set => _totalRentPmtOverYears = value; }
        private DirtyValue<string> _withinLimits1;
        /// <summary>
        /// Prequal Within Limits 1 [PREQUAL.X307]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 1")]
        public string WithinLimits1 { get => _withinLimits1; set => _withinLimits1 = value; }
        private DirtyValue<string> _withinLimits2;
        /// <summary>
        /// Prequal Within Limits 2 [PREQUAL.X308]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 2")]
        public string WithinLimits2 { get => _withinLimits2; set => _withinLimits2 = value; }
        private DirtyValue<string> _withinLimits3;
        /// <summary>
        /// Prequal Within Limits 3 [PREQUAL.X309]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 3")]
        public string WithinLimits3 { get => _withinLimits3; set => _withinLimits3 = value; }
        private DirtyValue<string> _withinLimits4;
        /// <summary>
        /// Prequal Within Limits 4 [PREQUAL.X310]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 4")]
        public string WithinLimits4 { get => _withinLimits4; set => _withinLimits4 = value; }
        private DirtyValue<string> _withinLimits5;
        /// <summary>
        /// Prequal Within Limits 5 [PREQUAL.X311]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 5")]
        public string WithinLimits5 { get => _withinLimits5; set => _withinLimits5 = value; }
        private DirtyValue<string> _withinLimits6;
        /// <summary>
        /// Prequal Within Limits 6 [PREQUAL.X312]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 6")]
        public string WithinLimits6 { get => _withinLimits6; set => _withinLimits6 = value; }
        private DirtyValue<string> _withinLimits7;
        /// <summary>
        /// Prequal Within Limits 7 [PREQUAL.X313]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 7")]
        public string WithinLimits7 { get => _withinLimits7; set => _withinLimits7 = value; }
        private DirtyValue<string> _withinLimits8;
        /// <summary>
        /// Prequal Within Limits 8 [PREQUAL.X314]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 8")]
        public string WithinLimits8 { get => _withinLimits8; set => _withinLimits8 = value; }
        private DirtyValue<string> _withinLimits9;
        /// <summary>
        /// Prequal Within Limits 9 [PREQUAL.X315]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Within Limits 9")]
        public string WithinLimits9 { get => _withinLimits9; set => _withinLimits9 = value; }
        private DirtyValue<int?> _yearsForComparison;
        /// <summary>
        /// Rent/Own How Many Years for this Comparison? [PREQUAL.X335]
        /// </summary>
        [LoanFieldProperty(Description = "Rent/Own How Many Years for this Comparison?")]
        public int? YearsForComparison { get => _yearsForComparison; set => _yearsForComparison = value; }
        internal override bool DirtyInternal
        {
            get => _afterTaxOwnMoSavings.Dirty
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