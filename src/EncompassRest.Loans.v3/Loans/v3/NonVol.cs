using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// NonVol
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class NonVol : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _adjustmentAmount;
    private DirtyValue<string?>? _adjustmentDescription;
    private DirtyValue<string?>? _adjustmentOtherDescription;
    private DirtyValue<StringEnumValue<NonVolAdjustmentType>>? _adjustmentType;
    private DirtyValue<string?>? _altId;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _includedIndicator;
    private DirtyValue<StringEnumValue<PaidToOrBy>>? _paidBy;
    private DirtyValue<StringEnumValue<PaidToOrBy>>? _paidTo;
    private DirtyValue<bool?>? _pocIndicator;
    private DirtyValue<string?>? _principalCureAddendum;

    /// <summary>
    /// Adjustment Amount [UNFL0004]
    /// </summary>
    public decimal? AdjustmentAmount { get => _adjustmentAmount; set => SetField(ref _adjustmentAmount, value); }

    /// <summary>
    /// Adjustment Description [UNFL0002]
    /// </summary>
    public string? AdjustmentDescription { get => _adjustmentDescription; set => SetField(ref _adjustmentDescription, value); }

    /// <summary>
    /// Adjustment Other Description [UNFL0003]
    /// </summary>
    public string? AdjustmentOtherDescription { get => _adjustmentOtherDescription; set => SetField(ref _adjustmentOtherDescription, value); }

    /// <summary>
    /// UCD Adjustment Type [UNFL0001]
    /// </summary>
    public StringEnumValue<NonVolAdjustmentType> AdjustmentType { get => _adjustmentType; set => SetField(ref _adjustmentType, value); }

    /// <summary>
    /// NonVolContract AltId
    /// </summary>
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// NonVolContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Liability Will be Paid Off and will be included [UNFL0005]
    /// </summary>
    public bool? IncludedIndicator { get => _includedIndicator; set => SetField(ref _includedIndicator, value); }

    /// <summary>
    /// Paid By [UNFL0007]
    /// </summary>
    public StringEnumValue<PaidToOrBy> PaidBy { get => _paidBy; set => SetField(ref _paidBy, value); }

    /// <summary>
    /// Paid To [UNFL0009]
    /// </summary>
    public StringEnumValue<PaidToOrBy> PaidTo { get => _paidTo; set => SetField(ref _paidTo, value); }

    /// <summary>
    /// POC Indicator [UNFL0006]
    /// </summary>
    public bool? PocIndicator { get => _pocIndicator; set => SetField(ref _pocIndicator, value); }

    /// <summary>
    /// PrincipalCureAddendum Amount [UNFL0008]
    /// </summary>
    public string? PrincipalCureAddendum { get => _principalCureAddendum; set => SetField(ref _principalCureAddendum, value); }
}