using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// HelocRepaymentDrawPeriod
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(DrawIndicator), SerializeWholeListWhenDirty = true)]
public sealed partial class HelocRepaymentDrawPeriod : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// HelocRepaymentDrawPeriod Apr [HTDNN04], [HTRNN04]
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
    /// HelocRepaymentDrawPeriod IndexRatePercent [HTDNN02], [HTRNN02]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? IndexRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HelocRepaymentDrawPeriod MarginRatePercent [HTDNN03], [HTRNN03]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MarginRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HelocRepaymentDrawPeriod MinimumMonthlyPaymentAmount [HTDNN05], [HTRNN05]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MinimumMonthlyPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HelocRepaymentDrawPeriod Year [HTDNN01], [HTRNN01]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? Year { get => GetValue<int?>(); set => SetValue(value); }
}