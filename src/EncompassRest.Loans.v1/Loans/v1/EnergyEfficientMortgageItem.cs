namespace EncompassRest.Loans.v1;

/// <summary>
/// EnergyEfficientMortgageItem
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class EnergyEfficientMortgageItem : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// EnergyEfficientMortgageItem ActualAmount
    /// </summary>
    public decimal? ActualAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EnergyEfficientMortgageItem AllowedAmount
    /// </summary>
    public decimal? AllowedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EnergyEfficientMortgageItem EnergyEfficientMortgageItemIndex
    /// </summary>
    public int? EnergyEfficientMortgageItemIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// EnergyEfficientMortgageItem Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnergyEfficientMortgageItem Item
    /// </summary>
    public string? Item { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnergyEfficientMortgageItem LineNumber
    /// </summary>
    public int? LineNumber { get => GetValue<int?>(); set => SetValue(value); }
}