using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// HelocHistoricalIndexYearSetting
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class HelocHistoricalIndexYearSetting : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _id;
    private DirtyValue<decimal?>? _indexRate;
    private DirtyValue<int?>? _year;

    /// <summary>
    /// HelocHistoricalIndexYearSettingContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// HELOC Index Table Index [HHI0002]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? IndexRate { get => _indexRate; set => SetField(ref _indexRate, value); }

    /// <summary>
    /// HELOC Index Table Year [HHI0001]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? Year { get => _year; set => SetField(ref _year, value); }
}