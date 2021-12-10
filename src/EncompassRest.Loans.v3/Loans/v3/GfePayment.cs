using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// GfePayment
/// </summary>
public sealed partial class GfePayment : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _fixedRate;
    private DirtyValue<int?>? _gfePaymentIndex;
    private DirtyValue<decimal?>? _indexRate;
    private DirtyValue<StringEnumValue<YesOrNo>>? _isBalanceReduced;
    private DirtyValue<string?>? _loanTypeExplanation;
    private DirtyValue<decimal?>? _marginRate;
    private DirtyValue<decimal?>? _maximumDifference;
    private DirtyValue<decimal?>? _maximumRate;
    private DirtyValue<decimal?>? _minimumDifference;
    private DirtyValue<decimal?>? _minimumMonthlyPayment;
    private DirtyValue<decimal?>? _monthlyPaymentYear1;
    private DirtyValue<decimal?>? _monthlyPaymentYear6;
    private DirtyValue<decimal?>? _monthlyPaymentYear6Change;
    private DirtyValue<decimal?>? _monthlyPaymentYear6MaxChange;
    private DirtyValue<bool?>? _notOfferedIndicator;
    private DirtyValue<decimal?>? _owedAfter5Years;
    private DirtyValue<decimal?>? _rateInMonth2;
    private DirtyValue<decimal?>? _reducedLoanBalance;
    private DirtyValue<StringEnumValue<ReducedStatus>>? _reducedStatus;

    /// <summary>
    /// GfePaymentContract FixedRate
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? FixedRate { get => _fixedRate; set => SetField(ref _fixedRate, value); }

    /// <summary>
    /// GfePaymentContract GfePaymentIndex
    /// </summary>
    public int? GfePaymentIndex { get => _gfePaymentIndex; set => SetField(ref _gfePaymentIndex, value); }

    /// <summary>
    /// MLDS Pymt S5 Index Rate [RE88395.X313]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? IndexRate { get => _indexRate; set => SetField(ref _indexRate, value); }

    /// <summary>
    /// MLDS Pymt S6 Is Loan Balance Reduced [RE88395.X311]
    /// </summary>
    public StringEnumValue<YesOrNo> IsBalanceReduced { get => _isBalanceReduced; set => SetField(ref _isBalanceReduced, value); }

    /// <summary>
    /// MLDS Pymt S6 Loan Type Explanation [RE88395.X306]
    /// </summary>
    public string? LoanTypeExplanation { get => _loanTypeExplanation; set => SetField(ref _loanTypeExplanation, value); }

    /// <summary>
    /// MLDS Pymt S5 Margin Rate [RE88395.X314]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MarginRate { get => _marginRate; set => SetField(ref _marginRate, value); }

    /// <summary>
    /// GfePaymentContract MaximumDifference
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MaximumDifference { get => _maximumDifference; set => SetField(ref _maximumDifference, value); }

    /// <summary>
    /// GfePaymentContract MaximumRate
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MaximumRate { get => _maximumRate; set => SetField(ref _maximumRate, value); }

    /// <summary>
    /// GfePaymentContract MinimumDifference
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MinimumDifference { get => _minimumDifference; set => SetField(ref _minimumDifference, value); }

    /// <summary>
    /// GfePaymentContract MinimumMonthlyPayment
    /// </summary>
    public decimal? MinimumMonthlyPayment { get => _minimumMonthlyPayment; set => SetField(ref _minimumMonthlyPayment, value); }

    /// <summary>
    /// GfePaymentContract MonthlyPaymentYear1
    /// </summary>
    public decimal? MonthlyPaymentYear1 { get => _monthlyPaymentYear1; set => SetField(ref _monthlyPaymentYear1, value); }

    /// <summary>
    /// GfePaymentContract MonthlyPaymentYear6
    /// </summary>
    public decimal? MonthlyPaymentYear6 { get => _monthlyPaymentYear6; set => SetField(ref _monthlyPaymentYear6, value); }

    /// <summary>
    /// GfePaymentContract MonthlyPaymentYear6Change
    /// </summary>
    public decimal? MonthlyPaymentYear6Change { get => _monthlyPaymentYear6Change; set => SetField(ref _monthlyPaymentYear6Change, value); }

    /// <summary>
    /// GfePaymentContract MonthlyPaymentYear6MaxChange
    /// </summary>
    public decimal? MonthlyPaymentYear6MaxChange { get => _monthlyPaymentYear6MaxChange; set => SetField(ref _monthlyPaymentYear6MaxChange, value); }

    /// <summary>
    /// GfePaymentContract NotOfferedIndicator
    /// </summary>
    public bool? NotOfferedIndicator { get => _notOfferedIndicator; set => SetField(ref _notOfferedIndicator, value); }

    /// <summary>
    /// GfePaymentContract OwedAfter5Years
    /// </summary>
    public decimal? OwedAfter5Years { get => _owedAfter5Years; set => SetField(ref _owedAfter5Years, value); }

    /// <summary>
    /// MLDS Pymt S5 Rate Month 2 Thru Yr 5 [RE88395.X304]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RateInMonth2 { get => _rateInMonth2; set => SetField(ref _rateInMonth2, value); }

    /// <summary>
    /// GfePaymentContract ReducedLoanBalance
    /// </summary>
    public decimal? ReducedLoanBalance { get => _reducedLoanBalance; set => SetField(ref _reducedLoanBalance, value); }

    /// <summary>
    /// MLDS Pymt S6 Loan Balance Reduced Status [RE88395.X312]
    /// </summary>
    public StringEnumValue<ReducedStatus> ReducedStatus { get => _reducedStatus; set => SetField(ref _reducedStatus, value); }
}