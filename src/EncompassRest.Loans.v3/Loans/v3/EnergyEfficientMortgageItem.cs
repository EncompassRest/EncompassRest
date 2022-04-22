namespace EncompassRest.Loans.v3;

/// <summary>
/// EnergyEfficientMortgageItem
/// </summary>
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
    /// EnergyEfficientMortgageItem Item
    /// </summary>
    public string? Item { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnergyEfficientMortgageItem LineNumber
    /// </summary>
    public int? LineNumber { get => GetValue<int?>(); set => SetValue(value); }
}