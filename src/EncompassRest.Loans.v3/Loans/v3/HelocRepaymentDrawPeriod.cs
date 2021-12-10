using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// HelocRepaymentDrawPeriod
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class HelocRepaymentDrawPeriod : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _apr;
    private DirtyValue<bool?>? _drawIndicator;
    private DirtyValue<string?>? _id;
    private DirtyValue<decimal?>? _indexRatePercent;
    private DirtyValue<decimal?>? _marginRatePercent;
    private DirtyValue<decimal?>? _minimumMonthlyPaymentAmount;
    private DirtyValue<int?>? _year;

    /// <summary>
    /// HelocRepaymentDrawPeriodContract Apr [HTD0004], [HTR0004]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? Apr { get => _apr; set => SetField(ref _apr, value); }

    /// <summary>
    /// HelocRepaymentDrawPeriodContract DrawIndicator
    /// </summary>
    public bool? DrawIndicator { get => _drawIndicator; set => SetField(ref _drawIndicator, value); }

    /// <summary>
    /// HelocRepaymentDrawPeriodContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// HelocRepaymentDrawPeriodContract IndexRatePercent [HTD0002], [HTR0002]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? IndexRatePercent { get => _indexRatePercent; set => SetField(ref _indexRatePercent, value); }

    /// <summary>
    /// HelocRepaymentDrawPeriodContract MarginRatePercent [HTD0003], [HTR0003]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MarginRatePercent { get => _marginRatePercent; set => SetField(ref _marginRatePercent, value); }

    /// <summary>
    /// HelocRepaymentDrawPeriodContract MinimumMonthlyPaymentAmount [HTD0005], [HTR0005]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MinimumMonthlyPaymentAmount { get => _minimumMonthlyPaymentAmount; set => SetField(ref _minimumMonthlyPaymentAmount, value); }

    /// <summary>
    /// HelocRepaymentDrawPeriodContract Year [HTD0001], [HTR0001]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? Year { get => _year; set => SetField(ref _year, value); }
}