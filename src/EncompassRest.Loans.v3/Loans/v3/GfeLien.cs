using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// GfeLien
/// </summary>
public sealed partial class GfeLien : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _amountOwing;
    private DirtyValue<int?>? _gfeLienIndex;
    private DirtyValue<StringEnumValue<GfeLienType>>? _gfeLienType;
    private DirtyValue<string?>? _holderName;
    private DirtyValue<string?>? _priority;

    /// <summary>
    /// GfeLienContract AmountOwing
    /// </summary>
    public decimal? AmountOwing { get => _amountOwing; set => SetField(ref _amountOwing, value); }

    /// <summary>
    /// GfeLienContract GfeLienIndex
    /// </summary>
    public int? GfeLienIndex { get => _gfeLienIndex; set => SetField(ref _gfeLienIndex, value); }

    /// <summary>
    /// GfeLienContract GfeLienType
    /// </summary>
    public StringEnumValue<GfeLienType> GfeLienType { get => _gfeLienType; set => SetField(ref _gfeLienType, value); }

    /// <summary>
    /// GfeLienContract HolderName
    /// </summary>
    public string? HolderName { get => _holderName; set => SetField(ref _holderName, value); }

    /// <summary>
    /// GfeLienContract Priority
    /// </summary>
    public string? Priority { get => _priority; set => SetField(ref _priority, value); }
}