using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Hud1EsDueDate
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Hud1EsDueDate : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Escrow Annual Fee Date [HUDNN49]
    /// </summary>
    public DateTime? AnnualFee { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Flood Ins Disb Date [HUDNN44]
    /// </summary>
    public DateTime? FloodInsDisb { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Haz Ins Disb Date [HUDNN42]
    /// </summary>
    public DateTime? HazInsDisb { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsDueDate Hud1EsDueDateIndex
    /// </summary>
    public int? Hud1EsDueDateIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsDueDate Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Mtg Ins Disb Date [HUDNN43]
    /// </summary>
    public DateTime? MtgInsDisb { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow City Taxes Date [HUDNN45]
    /// </summary>
    public DateTime? SchoolTaxes { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Tax Disb Date [HUDNN41]
    /// </summary>
    public DateTime? TaxDisb { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow User Defined 1 Date [HUDNN46]
    /// </summary>
    public DateTime? UserDefined1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow User Defined 2 Date [HUDNN47]
    /// </summary>
    public DateTime? UserDefined2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow User Defined 3 Date [HUDNN48]
    /// </summary>
    public DateTime? UserDefined3 { get => GetValue<DateTime?>(); set => SetValue(value); }
}