using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// HelocHistoricalIndexYearSetting
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class HelocHistoricalIndexYearSetting : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// HelocHistoricalIndexYearSetting HelocHistoricalIndexYearSettingIndex
    /// </summary>
    public int? HelocHistoricalIndexYearSettingIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HelocHistoricalIndexYearSetting Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Index Table Index [HHINN02]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? IndexRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Index Table Year [HHINN01]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? Year { get => GetValue<int?>(); set => SetValue(value); }
}