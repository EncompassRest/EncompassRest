namespace EncompassRest.Loans.v1;

/// <summary>
/// Hud1EsSetup
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Hud1EsSetup : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Escrow Setup Annual Fee Prepaid [HUDNN58]
    /// </summary>
    public bool? AnnualFeePrepaid { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Annual Fees [HUDNN21]
    /// </summary>
    public int? AnnualFees { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Date [HUDNN12]
    /// </summary>
    public string? Date { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Flood Ins Disb [HUDNN16]
    /// </summary>
    public int? FloodInsDisb { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Flood Ins Prepaid [HUDNN53]
    /// </summary>
    public bool? FloodInsPrepaid { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Haz Ins Disb [HUDNN14]
    /// </summary>
    public int? HazInsDisb { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Haz Ins Prepaid [HUDNN51]
    /// </summary>
    public bool? HazInsPrepaid { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsSetup Hud1EsSetupIndex
    /// </summary>
    public int? Hud1EsSetupIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsSetup Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Mtg Ins Disb [HUDNN15]
    /// </summary>
    public int? MtgInsDisb { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Mtg Ins Prepaid [HUDNN52]
    /// </summary>
    public bool? MtgInsPrepaid { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup City Taxes [HUDNN17]
    /// </summary>
    public int? SchoolTaxes { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup City Taxes Prepaid [HUDNN54]
    /// </summary>
    public bool? SchoolTaxesPrepaid { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Tax Disb [HUDNN13]
    /// </summary>
    public int? TaxDisb { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup Tax Prepaid [HUDNN50]
    /// </summary>
    public bool? TaxPrepaid { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup User Defined 1 [HUDNN18]
    /// </summary>
    public int? UserDefined1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup User Defined 2 [HUDNN19]
    /// </summary>
    public int? UserDefined2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup User Defined 3 [HUDNN20]
    /// </summary>
    public int? UserDefined3 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup User Defined 1 Prepaid [HUDNN55]
    /// </summary>
    public bool? UserDefinedPrepaid1 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup User Defined 2 Prepaid [HUDNN56]
    /// </summary>
    public bool? UserDefinedPrepaid2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Setup User Defined 3 Prepaid [HUDNN57]
    /// </summary>
    public bool? UserDefinedPrepaid3 { get => GetValue<bool?>(); set => SetValue(value); }
}