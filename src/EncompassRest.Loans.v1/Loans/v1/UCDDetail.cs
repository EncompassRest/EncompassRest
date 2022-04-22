using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// UCDDetail
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(FeeIndex) + "," + nameof(LineNumber) + "," + nameof(Section))]
public sealed partial class UCDDetail : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// UCDDetail FeeAccountType
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Open30DayChargeAccount\":\"Open 30 Day Charge Account\"}")]
    public StringEnumValue<UCDPayoffType> FeeAccountType { get => GetValue<StringEnumValue<UCDPayoffType>>(); set => SetValue(value); }

    /// <summary>
    /// UCDDetail FeeAmount
    /// </summary>
    public decimal? FeeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// UCDDetail FeeDateFrom
    /// </summary>
    public DateTime? FeeDateFrom { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UCDDetail FeeDateTo
    /// </summary>
    public DateTime? FeeDateTo { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UCDDetail FeeDesc
    /// </summary>
    public string? FeeDesc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UCDDetail FeeIndex
    /// </summary>
    public int? FeeIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// UCDDetail FeePaidBy
    /// </summary>
    public StringEnumValue<PaidToOrBy> FeePaidBy { get => GetValue<StringEnumValue<PaidToOrBy>>(); set => SetValue(value); }

    /// <summary>
    /// UCDDetail FeePaidTo
    /// </summary>
    public string? FeePaidTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UCDDetail FeePOC
    /// </summary>
    public bool? FeePOC { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UCDDetail Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UCDDetail LineNumber
    /// </summary>
    public int? LineNumber { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// UCDDetail Section
    /// </summary>
    public StringEnumValue<Section> Section { get => GetValue<StringEnumValue<Section>>(); set => SetValue(value); }
}