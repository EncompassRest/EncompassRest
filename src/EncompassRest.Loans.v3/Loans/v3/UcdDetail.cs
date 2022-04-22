using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// UcdDetail
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(FeeIndex) + "," + nameof(LineNumber) + "," + nameof(Section))]
public sealed partial class UcdDetail : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// UcdDetail FeeAccountType
    /// </summary>
    public StringEnumValue<FeeAccountType> FeeAccountType { get => GetValue<StringEnumValue<FeeAccountType>>(); set => SetValue(value); }

    /// <summary>
    /// UcdDetail FeeAmount
    /// </summary>
    public decimal? FeeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// UcdDetail FeeDateFrom
    /// </summary>
    public DateTime? FeeDateFrom { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UcdDetail FeeDateTo
    /// </summary>
    public DateTime? FeeDateTo { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UcdDetail FeeDesc
    /// </summary>
    public string? FeeDesc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UcdDetail FeeIndex
    /// </summary>
    public int? FeeIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// UcdDetail FeePaidBy
    /// </summary>
    public StringEnumValue<PaidToOrBy> FeePaidBy { get => GetValue<StringEnumValue<PaidToOrBy>>(); set => SetValue(value); }

    /// <summary>
    /// UcdDetail FeePaidTo
    /// </summary>
    public string? FeePaidTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UcdDetail FeePoc
    /// </summary>
    public bool? FeePoc { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UcdDetail LineNumber
    /// </summary>
    public int? LineNumber { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// UcdDetail Section
    /// </summary>
    public StringEnumValue<Section> Section { get => GetValue<StringEnumValue<Section>>(); set => SetValue(value); }
}