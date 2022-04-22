using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Prequalification
/// </summary>
public sealed partial class Prequalification : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Rent/Own Own Average After Tax Mo Pymt [PREQUAL.X327]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? AfterTaxOwnMoSavings { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Rent Average After Tax Mo Pymt [PREQUAL.X326]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? AfterTaxRentMoSavings { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Annual Home Maintenance [PREQUAL.X322]
    /// </summary>
    public decimal? AnnualHomeMaintenance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Average Mo Pymt Savings [PREQUAL.X317]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? AvgMoPmtSavings { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Own Before Tax Mo Pymt [PREQUAL.X321]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BeforeTaxOwnMoPmt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Rent Before Tax Mo Pymt [PREQUAL.X320]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BeforeTaxRentMoPmt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Debt Con Cash Out Bal [PREQUAL.X250]
    /// </summary>
    public int? CashOutBalance { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Combined Gain of Buying vs. Renting [PREQUAL.X333]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CombinedGain { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Cost Increase per Year [PREQUAL.X216]
    /// </summary>
    public decimal? CostIncreasePerYear { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Limits Down Pymt [PREQUAL.X203]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DownPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Favorable Option [PREQUAL.X316]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? FavorableOption { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Home Sellings Price After Years [PREQUAL.X328]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? HomeSellingPriceAfterYears { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Prequalification Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Investment Gain of Buying vs. Renting [PREQUAL.X331]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? InvestmentGain { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Limits Max Loan [PREQUAL.X205]
    /// </summary>
    public decimal? MaxLoanLimit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Limits Max Property Value [PREQUAL.X204]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MaxPropValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Minus Down Pymt/Initial Closing Costs [PREQUAL.X330]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MinusDownPmtAndClosingCosts { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Minus Loan Balance [PREQUAL.X329]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MinusLoanBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Total Benefits Purch vs. Rent Monthly [PREQUAL.X231]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyBenefit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Home Appreciation Monthly [PREQUAL.X221]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyHomeAppreciation { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Home Equity Monthly [PREQUAL.X219]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyHomeEquity { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Income Tax Bracket Monthly [PREQUAL.X229]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyIncomeTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Interest on Savings Monthly [PREQUAL.X224]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyInvestmentInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Comp Monthly Pymt Svgs/Mo [PREQUAL.X245]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? MonthlySavings { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Compare Over # Mos [PREQUAL.X105]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? NumberOfMonths { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Annual Home Maintenance % [PREQUAL.X334]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PercentAnnualHomeMaint { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Home Appreciation %/Yr [PREQUAL.X107]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PercentOfHomeAppreciation { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Income Tax Bracket % [PREQUAL.X228]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PercentOfIncomeTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Interest on Savings %/Yr [PREQUAL.X223]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PercentOfInvestmentInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Prequalification PrequalificationScenarios
    /// </summary>
    [AllowNull]
    public IList<PrequalificationScenario> PrequalificationScenarios { get => GetList<PrequalificationScenario>(); set => SetList(value); }

    /// <summary>
    /// Prequal Qualification Status [PREQUAL.X274]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? QualificationStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Mo Cost to Rent [PREQUAL.X99]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? RentalCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Mo Renters Insurance [PREQUAL.X319]
    /// </summary>
    public decimal? RentersInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Total Benefits Purch vs. Rent Total [PREQUAL.X232]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalBenefit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Total Rent [PREQUAL.X217]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalCashFlow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Total Gain Over Years [PREQUAL.X318]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalGain { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Home Appreciation Total [PREQUAL.X222]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalHomeAppreciation { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Home Equity Total [PREQUAL.X220]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalHomeEquity { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own No Housing/Other Expenses Monthly [PREQUAL.X227]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalHousingExpense { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Income Tax Bracket Total [PREQUAL.X230]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalIncomeTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Interest on Savings Total [PREQUAL.X225]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalInvestmentInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Debt Con Total Pymt [PREQUAL.X252]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TotalLiabilityPayment { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Debt Con Total Paid Off Total Pymt [PREQUAL.X253]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TotalLiabilityUnpaid { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Debt Con Total Pymt Svgs/Mo [PREQUAL.X247]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TotalLoanSavings { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Prequal Total Other Expenses [PREQUAL.X294]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalOtherExpenses { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Own Total Pymt Over Years [PREQUAL.X324]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalOwnPmtOverYears { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Own Total Tax Savings Over Years [PREQUAL.X325]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalOwnTaxSavings { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Debt Con Total Paid Off Bal [PREQUAL.X248]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TotalPaidOffBalance { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Debt Con Total Paid Off Mo Pymt [PREQUAL.X249]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TotalPaidOffMonthly { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Total Pymt Savings [PREQUAL.X332]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPmtSavings { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own Rent Total Pymt Over Years [PREQUAL.X323]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalRentPmtOverYears { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Prequal Within Limits 1 [PREQUAL.X307]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WithinLimits1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Prequal Within Limits 2 [PREQUAL.X308]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WithinLimits2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Prequal Within Limits 3 [PREQUAL.X309]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WithinLimits3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Prequal Within Limits 4 [PREQUAL.X310]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WithinLimits4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Prequal Within Limits 5 [PREQUAL.X311]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WithinLimits5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Prequal Within Limits 6 [PREQUAL.X312]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WithinLimits6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Prequal Within Limits 7 [PREQUAL.X313]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WithinLimits7 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Prequal Within Limits 8 [PREQUAL.X314]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WithinLimits8 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Prequal Within Limits 9 [PREQUAL.X315]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WithinLimits9 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rent/Own How Many Years for this Comparison? [PREQUAL.X335]
    /// </summary>
    public int? YearsForComparison { get => GetValue<int?>(); set => SetValue(value); }
}