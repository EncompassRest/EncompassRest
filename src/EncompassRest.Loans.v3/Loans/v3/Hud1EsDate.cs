namespace EncompassRest.Loans.v3;

/// <summary>
/// Hud1EsDate
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Hud1EsDate : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _aggrMthDisb;
    private DirtyValue<decimal?>? _annualFee;
    private DirtyValue<decimal?>? _balance;
    private DirtyValue<string?>? _date;
    private DirtyValue<decimal?>? _floodInsDisb;
    private DirtyValue<decimal?>? _hazInsDisb;
    private DirtyValue<string?>? _id;
    private DirtyValue<decimal?>? _mtgInsDisb;
    private DirtyValue<decimal?>? _schoolTaxes;
    private DirtyValue<decimal?>? _taxDisb;
    private DirtyValue<decimal?>? _userDefined1;
    private DirtyValue<decimal?>? _userDefined2;
    private DirtyValue<decimal?>? _userDefined3;

    /// <summary>
    /// Escrow Aggr Mthd Disb [HUD0010]
    /// </summary>
    public decimal? AggrMthDisb { get => _aggrMthDisb; set => SetField(ref _aggrMthDisb, value); }

    /// <summary>
    /// Escrow Annual Fee [HUD0060]
    /// </summary>
    public decimal? AnnualFee { get => _annualFee; set => SetField(ref _annualFee, value); }

    /// <summary>
    /// Escrow Date Balance [HUD0011]
    /// </summary>
    public decimal? Balance { get => _balance; set => SetField(ref _balance, value); }

    /// <summary>
    /// Escrow Payment Date [HUD0001]
    /// </summary>
    public string? Date { get => _date; set => SetField(ref _date, value); }

    /// <summary>
    /// Escrow Flood Ins Disb [HUD0005]
    /// </summary>
    public decimal? FloodInsDisb { get => _floodInsDisb; set => SetField(ref _floodInsDisb, value); }

    /// <summary>
    /// Escrow Haz Ins Disb [HUD0003]
    /// </summary>
    public decimal? HazInsDisb { get => _hazInsDisb; set => SetField(ref _hazInsDisb, value); }

    /// <summary>
    /// Hud1EsDateContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Escrow Mtg Ins Disb [HUD0004]
    /// </summary>
    public decimal? MtgInsDisb { get => _mtgInsDisb; set => SetField(ref _mtgInsDisb, value); }

    /// <summary>
    /// Escrow City Taxes [HUD0006]
    /// </summary>
    public decimal? SchoolTaxes { get => _schoolTaxes; set => SetField(ref _schoolTaxes, value); }

    /// <summary>
    /// Escrow Tax Disb [HUD0002]
    /// </summary>
    public decimal? TaxDisb { get => _taxDisb; set => SetField(ref _taxDisb, value); }

    /// <summary>
    /// Escrow User Defined 1 [HUD0007]
    /// </summary>
    public decimal? UserDefined1 { get => _userDefined1; set => SetField(ref _userDefined1, value); }

    /// <summary>
    /// Escrow User Defined 2 [HUD0008]
    /// </summary>
    public decimal? UserDefined2 { get => _userDefined2; set => SetField(ref _userDefined2, value); }

    /// <summary>
    /// Escrow User Defined 3 [HUD0009]
    /// </summary>
    public decimal? UserDefined3 { get => _userDefined3; set => SetField(ref _userDefined3, value); }
}