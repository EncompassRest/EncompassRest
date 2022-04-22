using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// GfeLien
/// </summary>
public sealed partial class GfeLien : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// GfeLien AmountOwing
    /// </summary>
    public decimal? AmountOwing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GfeLien GfeLienIndex
    /// </summary>
    public int? GfeLienIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// GfeLien GfeLienType
    /// </summary>
    public StringEnumValue<GfeLienType> GfeLienType { get => GetValue<StringEnumValue<GfeLienType>>(); set => SetValue(value); }

    /// <summary>
    /// GfeLien HolderName
    /// </summary>
    public string? HolderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GfeLien Priority
    /// </summary>
    public string? Priority { get => GetValue<string?>(); set => SetValue(value); }
}