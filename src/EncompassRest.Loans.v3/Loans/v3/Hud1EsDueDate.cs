using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Hud1EsDueDate
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Hud1EsDueDate : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Escrow Annual Fee Date [HUD0049]
    /// </summary>
    public DateTime? AnnualFee { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Flood Ins Disb Date [HUD0044]
    /// </summary>
    public DateTime? FloodInsDisb { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Haz Ins Disb Date [HUD0042]
    /// </summary>
    public DateTime? HazInsDisb { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsDueDate Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Mtg Ins Disb Date [HUD0043]
    /// </summary>
    public DateTime? MtgInsDisb { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow City Taxes Date [HUD0045]
    /// </summary>
    public DateTime? SchoolTaxes { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Tax Disb Date [HUD0041]
    /// </summary>
    public DateTime? TaxDisb { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow User Defined 1 Date [HUD0046]
    /// </summary>
    public DateTime? UserDefined1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow User Defined 2 Date [HUD0047]
    /// </summary>
    public DateTime? UserDefined2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow User Defined 3 Date [HUD0048]
    /// </summary>
    public DateTime? UserDefined3 { get => GetValue<DateTime?>(); set => SetValue(value); }
}