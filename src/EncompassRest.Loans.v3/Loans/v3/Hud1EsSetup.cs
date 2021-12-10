namespace EncompassRest.Loans.v3;

/// <summary>
/// Hud1EsSetup
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Hud1EsSetup : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<bool?>? _annualFeePrepaid;
    private DirtyValue<int?>? _annualFees;
    private DirtyValue<string?>? _date;
    private DirtyValue<int?>? _floodInsDisb;
    private DirtyValue<bool?>? _floodInsPrepaid;
    private DirtyValue<int?>? _hazInsDisb;
    private DirtyValue<bool?>? _hazInsPrepaid;
    private DirtyValue<string?>? _id;
    private DirtyValue<int?>? _mtgInsDisb;
    private DirtyValue<bool?>? _mtgInsPrepaid;
    private DirtyValue<int?>? _schoolTaxes;
    private DirtyValue<bool?>? _schoolTaxesPrepaid;
    private DirtyValue<int?>? _taxDisb;
    private DirtyValue<bool?>? _taxPrepaid;
    private DirtyValue<int?>? _userDefined1;
    private DirtyValue<int?>? _userDefined2;
    private DirtyValue<int?>? _userDefined3;
    private DirtyValue<bool?>? _userDefinedPrepaid1;
    private DirtyValue<bool?>? _userDefinedPrepaid2;
    private DirtyValue<bool?>? _userDefinedPrepaid3;

    /// <summary>
    /// Escrow Setup Annual Fee Prepaid [HUD0058]
    /// </summary>
    public bool? AnnualFeePrepaid { get => _annualFeePrepaid; set => SetField(ref _annualFeePrepaid, value); }

    /// <summary>
    /// Escrow Setup Annual Fees [HUD0021]
    /// </summary>
    public int? AnnualFees { get => _annualFees; set => SetField(ref _annualFees, value); }

    /// <summary>
    /// Escrow Setup Date [HUD0012]
    /// </summary>
    public string? Date { get => _date; set => SetField(ref _date, value); }

    /// <summary>
    /// Escrow Setup Flood Ins Disb [HUD0016]
    /// </summary>
    public int? FloodInsDisb { get => _floodInsDisb; set => SetField(ref _floodInsDisb, value); }

    /// <summary>
    /// Escrow Setup Flood Ins Prepaid [HUD0053]
    /// </summary>
    public bool? FloodInsPrepaid { get => _floodInsPrepaid; set => SetField(ref _floodInsPrepaid, value); }

    /// <summary>
    /// Escrow Setup Haz Ins Disb [HUD0014]
    /// </summary>
    public int? HazInsDisb { get => _hazInsDisb; set => SetField(ref _hazInsDisb, value); }

    /// <summary>
    /// Escrow Setup Haz Ins Prepaid [HUD0051]
    /// </summary>
    public bool? HazInsPrepaid { get => _hazInsPrepaid; set => SetField(ref _hazInsPrepaid, value); }

    /// <summary>
    /// Hud1EsSetupContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Escrow Setup Mtg Ins Disb [HUD0015]
    /// </summary>
    public int? MtgInsDisb { get => _mtgInsDisb; set => SetField(ref _mtgInsDisb, value); }

    /// <summary>
    /// Escrow Setup Mtg Ins Prepaid [HUD0052]
    /// </summary>
    public bool? MtgInsPrepaid { get => _mtgInsPrepaid; set => SetField(ref _mtgInsPrepaid, value); }

    /// <summary>
    /// Escrow Setup City Taxes [HUD0017]
    /// </summary>
    public int? SchoolTaxes { get => _schoolTaxes; set => SetField(ref _schoolTaxes, value); }

    /// <summary>
    /// Escrow Setup City Taxes Prepaid [HUD0054]
    /// </summary>
    public bool? SchoolTaxesPrepaid { get => _schoolTaxesPrepaid; set => SetField(ref _schoolTaxesPrepaid, value); }

    /// <summary>
    /// Escrow Setup Tax Disb [HUD0013]
    /// </summary>
    public int? TaxDisb { get => _taxDisb; set => SetField(ref _taxDisb, value); }

    /// <summary>
    /// Escrow Setup Tax Prepaid [HUD0050]
    /// </summary>
    public bool? TaxPrepaid { get => _taxPrepaid; set => SetField(ref _taxPrepaid, value); }

    /// <summary>
    /// Escrow Setup User Defined 1 [HUD0018]
    /// </summary>
    public int? UserDefined1 { get => _userDefined1; set => SetField(ref _userDefined1, value); }

    /// <summary>
    /// Escrow Setup User Defined 2 [HUD0019]
    /// </summary>
    public int? UserDefined2 { get => _userDefined2; set => SetField(ref _userDefined2, value); }

    /// <summary>
    /// Escrow Setup User Defined 3 [HUD0020]
    /// </summary>
    public int? UserDefined3 { get => _userDefined3; set => SetField(ref _userDefined3, value); }

    /// <summary>
    /// Escrow Setup User Defined 1 Prepaid [HUD0055]
    /// </summary>
    public bool? UserDefinedPrepaid1 { get => _userDefinedPrepaid1; set => SetField(ref _userDefinedPrepaid1, value); }

    /// <summary>
    /// Escrow Setup User Defined 2 Prepaid [HUD0056]
    /// </summary>
    public bool? UserDefinedPrepaid2 { get => _userDefinedPrepaid2; set => SetField(ref _userDefinedPrepaid2, value); }

    /// <summary>
    /// Escrow Setup User Defined 3 Prepaid [HUD0057]
    /// </summary>
    public bool? UserDefinedPrepaid3 { get => _userDefinedPrepaid3; set => SetField(ref _userDefinedPrepaid3, value); }
}