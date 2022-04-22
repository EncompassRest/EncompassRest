using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// HelocRepaymentDrawPeriod
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class HelocRepaymentDrawPeriod : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// HelocRepaymentDrawPeriod Apr [HTD0004], [HTR0004]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? Apr { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HelocRepaymentDrawPeriod DrawIndicator
    /// </summary>
    public bool? DrawIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HelocRepaymentDrawPeriod Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HelocRepaymentDrawPeriod IndexRatePercent [HTD0002], [HTR0002]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? IndexRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HelocRepaymentDrawPeriod MarginRatePercent [HTD0003], [HTR0003]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MarginRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HelocRepaymentDrawPeriod MinimumMonthlyPaymentAmount [HTD0005], [HTR0005]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MinimumMonthlyPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HelocRepaymentDrawPeriod Year [HTD0001], [HTR0001]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? Year { get => GetValue<int?>(); set => SetValue(value); }
}