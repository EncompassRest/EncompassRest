using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// NonVol
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class NonVol : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Adjustment Amount [UNFL0004]
    /// </summary>
    public decimal? AdjustmentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Adjustment Description [UNFL0002]
    /// </summary>
    public string? AdjustmentDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Adjustment Other Description [UNFL0003]
    /// </summary>
    public string? AdjustmentOtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UCD Adjustment Type [UNFL0001]
    /// </summary>
    public StringEnumValue<NonVolAdjustmentType> AdjustmentType { get => GetValue<StringEnumValue<NonVolAdjustmentType>>(); set => SetValue(value); }

    /// <summary>
    /// NonVol AltId
    /// </summary>
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NonVol Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Will be Paid Off and will be included [UNFL0005]
    /// </summary>
    public bool? IncludedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Paid By [UNFL0007]
    /// </summary>
    public StringEnumValue<PaidToOrBy> PaidBy { get => GetValue<StringEnumValue<PaidToOrBy>>(); set => SetValue(value); }

    /// <summary>
    /// Paid To [UNFL0009]
    /// </summary>
    public StringEnumValue<PaidToOrBy> PaidTo { get => GetValue<StringEnumValue<PaidToOrBy>>(); set => SetValue(value); }

    /// <summary>
    /// POC Indicator [UNFL0006]
    /// </summary>
    public bool? PocIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PrincipalCureAddendum Amount [UNFL0008]
    /// </summary>
    public string? PrincipalCureAddendum { get => GetValue<string?>(); set => SetValue(value); }
}