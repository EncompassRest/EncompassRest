namespace EncompassRest.Loans.v1;

/// <summary>
/// Hud1EsDate
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Hud1EsDate : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Escrow Aggr Mthd Disb [HUDNN10]
    /// </summary>
    public decimal? AggrMthDisb { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Annual Fee [HUDNN60]
    /// </summary>
    public decimal? AnnualFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Date Balance [HUDNN11]
    /// </summary>
    public decimal? Balance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Payment Date [HUDNN01]
    /// </summary>
    public string? Date { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Flood Ins Disb [HUDNN05]
    /// </summary>
    public decimal? FloodInsDisb { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Haz Ins Disb [HUDNN03]
    /// </summary>
    public decimal? HazInsDisb { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsDate Hud1EsDateIndex
    /// </summary>
    public int? Hud1EsDateIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsDate Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Mtg Ins Disb [HUDNN04]
    /// </summary>
    public decimal? MtgInsDisb { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow City Taxes [HUDNN06]
    /// </summary>
    public decimal? SchoolTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Tax Disb [HUDNN02]
    /// </summary>
    public decimal? TaxDisb { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow User Defined 1 [HUDNN07]
    /// </summary>
    public decimal? UserDefined1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow User Defined 2 [HUDNN08]
    /// </summary>
    public decimal? UserDefined2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow User Defined 3 [HUDNN09]
    /// </summary>
    public decimal? UserDefined3 { get => GetValue<decimal?>(); set => SetValue(value); }
}