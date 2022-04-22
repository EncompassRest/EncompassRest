using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// NonVol
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class NonVol : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Adjustment Amount [UNFLNN04]
    /// </summary>
    public decimal? AdjustmentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Adjustment Description [UNFLNN02]
    /// </summary>
    public string? AdjustmentDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Adjustment Other Description [UNFLNN03]
    /// </summary>
    public string? AdjustmentOtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UCD Adjustment Type [UNFLNN01]
    /// </summary>
    public StringEnumValue<NonVolAdjustmentType> AdjustmentType { get => GetValue<StringEnumValue<NonVolAdjustmentType>>(); set => SetValue(value); }

    /// <summary>
    /// NonVol Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Will be Paid Off and will be included [UNFLNN05]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Paid off (*) will be included\"}")]
    public bool? IncludedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// NonVol NonVolId
    /// </summary>
    public string? NonVolId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NonVol NonVolIndex
    /// </summary>
    public int? NonVolIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Paid By [UNFLNN07]
    /// </summary>
    public StringEnumValue<PaidToOrBy> PaidBy { get => GetValue<StringEnumValue<PaidToOrBy>>(); set => SetValue(value); }

    /// <summary>
    /// Paid To [UNFLNN09]
    /// </summary>
    public StringEnumValue<PaidToOrBy> PaidTo { get => GetValue<StringEnumValue<PaidToOrBy>>(); set => SetValue(value); }

    /// <summary>
    /// POC Indicator [UNFLNN06]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Paid off (*) will be included\"}")]
    public bool? POCIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PrincipalCureAddendum Amount [UNFLNN08]
    /// </summary>
    public string? PrincipalCureAddendum { get => GetValue<string?>(); set => SetValue(value); }
}