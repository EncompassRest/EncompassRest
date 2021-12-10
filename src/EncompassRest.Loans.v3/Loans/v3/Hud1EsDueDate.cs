using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Hud1EsDueDate
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Hud1EsDueDate : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _annualFee;
    private DirtyValue<DateTime?>? _floodInsDisb;
    private DirtyValue<DateTime?>? _hazInsDisb;
    private DirtyValue<string?>? _id;
    private DirtyValue<DateTime?>? _mtgInsDisb;
    private DirtyValue<DateTime?>? _schoolTaxes;
    private DirtyValue<DateTime?>? _taxDisb;
    private DirtyValue<DateTime?>? _userDefined1;
    private DirtyValue<DateTime?>? _userDefined2;
    private DirtyValue<DateTime?>? _userDefined3;

    /// <summary>
    /// Escrow Annual Fee Date [HUD0049]
    /// </summary>
    public DateTime? AnnualFee { get => _annualFee; set => SetField(ref _annualFee, value); }

    /// <summary>
    /// Escrow Flood Ins Disb Date [HUD0044]
    /// </summary>
    public DateTime? FloodInsDisb { get => _floodInsDisb; set => SetField(ref _floodInsDisb, value); }

    /// <summary>
    /// Escrow Haz Ins Disb Date [HUD0042]
    /// </summary>
    public DateTime? HazInsDisb { get => _hazInsDisb; set => SetField(ref _hazInsDisb, value); }

    /// <summary>
    /// Hud1EsDueDateContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Escrow Mtg Ins Disb Date [HUD0043]
    /// </summary>
    public DateTime? MtgInsDisb { get => _mtgInsDisb; set => SetField(ref _mtgInsDisb, value); }

    /// <summary>
    /// Escrow City Taxes Date [HUD0045]
    /// </summary>
    public DateTime? SchoolTaxes { get => _schoolTaxes; set => SetField(ref _schoolTaxes, value); }

    /// <summary>
    /// Escrow Tax Disb Date [HUD0041]
    /// </summary>
    public DateTime? TaxDisb { get => _taxDisb; set => SetField(ref _taxDisb, value); }

    /// <summary>
    /// Escrow User Defined 1 Date [HUD0046]
    /// </summary>
    public DateTime? UserDefined1 { get => _userDefined1; set => SetField(ref _userDefined1, value); }

    /// <summary>
    /// Escrow User Defined 2 Date [HUD0047]
    /// </summary>
    public DateTime? UserDefined2 { get => _userDefined2; set => SetField(ref _userDefined2, value); }

    /// <summary>
    /// Escrow User Defined 3 Date [HUD0048]
    /// </summary>
    public DateTime? UserDefined3 { get => _userDefined3; set => SetField(ref _userDefined3, value); }
}