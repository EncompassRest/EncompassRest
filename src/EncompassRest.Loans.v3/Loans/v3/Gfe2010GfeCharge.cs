namespace EncompassRest.Loans.v3;

/// <summary>
/// Gfe2010GfeCharge
/// </summary>
public sealed partial class Gfe2010GfeCharge : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<bool?>? _chargeBelow10Indicator;
    private DirtyValue<string?>? _description;
    private DirtyValue<int?>? _gfe2010GfeChargeIndex;
    private DirtyValue<decimal?>? _gfeCharge;
    private DirtyValue<decimal?>? _hudCharge;
    private DirtyValue<string?>? _line;

    /// <summary>
    /// Gfe2010GfeChargeContract ChargeBelow10Indicator
    /// </summary>
    public bool? ChargeBelow10Indicator { get => _chargeBelow10Indicator; set => SetField(ref _chargeBelow10Indicator, value); }

    /// <summary>
    /// Gfe2010GfeChargeContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// Gfe2010GfeChargeContract Gfe2010GfeChargeIndex
    /// </summary>
    public int? Gfe2010GfeChargeIndex { get => _gfe2010GfeChargeIndex; set => SetField(ref _gfe2010GfeChargeIndex, value); }

    /// <summary>
    /// Gfe2010GfeChargeContract GfeCharge
    /// </summary>
    public decimal? GfeCharge { get => _gfeCharge; set => SetField(ref _gfeCharge, value); }

    /// <summary>
    /// Gfe2010GfeChargeContract HudCharge
    /// </summary>
    public decimal? HudCharge { get => _hudCharge; set => SetField(ref _hudCharge, value); }

    /// <summary>
    /// Gfe2010GfeChargeContract Line
    /// </summary>
    public string? Line { get => _line; set => SetField(ref _line, value); }
}