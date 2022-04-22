using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Liability
/// </summary>
public sealed partial class Liability : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Liability AccountIdentifier [255], [1058]
    /// </summary>
    public string? AccountIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Country
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liabilities Alimony/Child Support Descr [271]
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability ForeignAddressIndicator
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability LiabilityType
    /// </summary>
    public StringEnumValue<AltLiabilityType> LiabilityType { get => GetValue<StringEnumValue<AltLiabilityType>>(); set => SetValue(value); }

    /// <summary>
    /// Liability LiabilityTypeIndex
    /// </summary>
    public int? LiabilityTypeIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability MonthlyPaymentAmount
    /// </summary>
    public decimal? MonthlyPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability RemainingTermMonths
    /// </summary>
    public int? RemainingTermMonths { get => GetValue<int?>(); set => SetValue(value); }
}