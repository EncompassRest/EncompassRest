using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// GfePayment
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(GfePaymentIndex))]
public sealed partial class GfePayment : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// GfePayment FixedRate
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? FixedRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GfePayment GfePaymentIndex
    /// </summary>
    public int? GfePaymentIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Pymt S5 Index Rate [RE88395.X313]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? IndexRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Pymt S6 Is Loan Balance Reduced [RE88395.X311]
    /// </summary>
    public StringEnumValue<YesOrNo> IsBalanceReduced { get => GetValue<StringEnumValue<YesOrNo>>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Pymt S6 Loan Type Explanation [RE88395.X306]
    /// </summary>
    public string? LoanTypeExplanation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Pymt S5 Margin Rate [RE88395.X314]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MarginRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GfePayment MaximumDifference
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MaximumDifference { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GfePayment MaximumRate
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MaximumRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GfePayment MinimumDifference
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MinimumDifference { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GfePayment MinimumMonthlyPayment
    /// </summary>
    public decimal? MinimumMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GfePayment MonthlyPaymentYear1
    /// </summary>
    public decimal? MonthlyPaymentYear1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GfePayment MonthlyPaymentYear6
    /// </summary>
    public decimal? MonthlyPaymentYear6 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GfePayment MonthlyPaymentYear6Change
    /// </summary>
    public decimal? MonthlyPaymentYear6Change { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GfePayment MonthlyPaymentYear6MaxChange
    /// </summary>
    public decimal? MonthlyPaymentYear6MaxChange { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GfePayment NotOfferedIndicator
    /// </summary>
    public bool? NotOfferedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// GfePayment OwedAfter5Years
    /// </summary>
    public decimal? OwedAfter5Years { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Pymt S5 Rate Month 2 Thru Yr 5 [RE88395.X304]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RateInMonth2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GfePayment ReducedLoanBalance
    /// </summary>
    public decimal? ReducedLoanBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Pymt S6 Loan Balance Reduced Status [RE88395.X312]
    /// </summary>
    public StringEnumValue<ReducedStatus> ReducedStatus { get => GetValue<StringEnumValue<ReducedStatus>>(); set => SetValue(value); }
}