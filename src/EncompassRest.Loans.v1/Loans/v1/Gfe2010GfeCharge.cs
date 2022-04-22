namespace EncompassRest.Loans.v1;

/// <summary>
/// Gfe2010GfeCharge
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(ChargeBelow10Indicator) + "," + nameof(Gfe2010GfeChargeIndex))]
public sealed partial class Gfe2010GfeCharge : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Gfe2010GfeCharge ChargeBelow10Indicator
    /// </summary>
    public bool? ChargeBelow10Indicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010GfeCharge Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010GfeCharge Gfe2010GfeChargeIndex
    /// </summary>
    public int? Gfe2010GfeChargeIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010GfeCharge GfeCharge
    /// </summary>
    public decimal? GfeCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010GfeCharge HudCharge
    /// </summary>
    public decimal? HudCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010GfeCharge Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010GfeCharge Line
    /// </summary>
    public string? Line { get => GetValue<string?>(); set => SetValue(value); }
}