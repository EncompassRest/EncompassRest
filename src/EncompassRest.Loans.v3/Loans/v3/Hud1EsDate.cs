namespace EncompassRest.Loans.v3;

/// <summary>
/// Hud1EsDate
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Hud1EsDate : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Escrow Aggr Mthd Disb [HUD0010]
    /// </summary>
    public decimal? AggrMthDisb { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Annual Fee [HUD0060]
    /// </summary>
    public decimal? AnnualFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Date Balance [HUD0011]
    /// </summary>
    public decimal? Balance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Payment Date [HUD0001]
    /// </summary>
    public string? Date { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Flood Ins Disb [HUD0005]
    /// </summary>
    public decimal? FloodInsDisb { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Haz Ins Disb [HUD0003]
    /// </summary>
    public decimal? HazInsDisb { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsDate Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Mtg Ins Disb [HUD0004]
    /// </summary>
    public decimal? MtgInsDisb { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow City Taxes [HUD0006]
    /// </summary>
    public decimal? SchoolTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Tax Disb [HUD0002]
    /// </summary>
    public decimal? TaxDisb { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow User Defined 1 [HUD0007]
    /// </summary>
    public decimal? UserDefined1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow User Defined 2 [HUD0008]
    /// </summary>
    public decimal? UserDefined2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow User Defined 3 [HUD0009]
    /// </summary>
    public decimal? UserDefined3 { get => GetValue<decimal?>(); set => SetValue(value); }
}