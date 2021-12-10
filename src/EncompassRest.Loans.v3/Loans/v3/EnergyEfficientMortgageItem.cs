namespace EncompassRest.Loans.v3;

/// <summary>
/// EnergyEfficientMortgageItem
/// </summary>
public sealed partial class EnergyEfficientMortgageItem : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _actualAmount;
    private DirtyValue<decimal?>? _allowedAmount;
    private DirtyValue<string?>? _item;
    private DirtyValue<int?>? _lineNumber;

    /// <summary>
    /// EnergyEfficientMortgageItemContract ActualAmount
    /// </summary>
    public decimal? ActualAmount { get => _actualAmount; set => SetField(ref _actualAmount, value); }

    /// <summary>
    /// EnergyEfficientMortgageItemContract AllowedAmount
    /// </summary>
    public decimal? AllowedAmount { get => _allowedAmount; set => SetField(ref _allowedAmount, value); }

    /// <summary>
    /// EnergyEfficientMortgageItemContract Item
    /// </summary>
    public string? Item { get => _item; set => SetField(ref _item, value); }

    /// <summary>
    /// EnergyEfficientMortgageItemContract LineNumber
    /// </summary>
    public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }
}