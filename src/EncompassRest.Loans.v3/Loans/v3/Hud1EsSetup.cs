namespace EncompassRest.Loans.v3;

/// <summary>
/// Hud1EsSetup
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Hud1EsSetup : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Escrow Setup Annual Fee Prepaid [HUD0058]
    /// </summary>
    public bool? AnnualFeePrepaid { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Annual Fees [HUD0021]
    /// </summary>
    public int? AnnualFees { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Date [HUD0012]
    /// </summary>
    public string? Date { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Flood Ins Disb [HUD0016]
    /// </summary>
    public int? FloodInsDisb { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Flood Ins Prepaid [HUD0053]
    /// </summary>
    public bool? FloodInsPrepaid { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Haz Ins Disb [HUD0014]
    /// </summary>
    public int? HazInsDisb { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Haz Ins Prepaid [HUD0051]
    /// </summary>
    public bool? HazInsPrepaid { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsSetup Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Mtg Ins Disb [HUD0015]
    /// </summary>
    public int? MtgInsDisb { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Mtg Ins Prepaid [HUD0052]
    /// </summary>
    public bool? MtgInsPrepaid { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup City Taxes [HUD0017]
    /// </summary>
    public int? SchoolTaxes { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup City Taxes Prepaid [HUD0054]
    /// </summary>
    public bool? SchoolTaxesPrepaid { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Tax Disb [HUD0013]
    /// </summary>
    public int? TaxDisb { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Tax Prepaid [HUD0050]
    /// </summary>
    public bool? TaxPrepaid { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup User Defined 1 [HUD0018]
    /// </summary>
    public int? UserDefined1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup User Defined 2 [HUD0019]
    /// </summary>
    public int? UserDefined2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup User Defined 3 [HUD0020]
    /// </summary>
    public int? UserDefined3 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup User Defined 1 Prepaid [HUD0055]
    /// </summary>
    public bool? UserDefinedPrepaid1 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup User Defined 2 Prepaid [HUD0056]
    /// </summary>
    public bool? UserDefinedPrepaid2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup User Defined 3 Prepaid [HUD0057]
    /// </summary>
    public bool? UserDefinedPrepaid3 { get => GetValue<bool?>(); set => SetValue(value); }
}