using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// SecondaryFinancingProvider
/// </summary>
public sealed partial class SecondaryFinancingProvider : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// SecondaryFinancingProvider FinancingAmount
    /// </summary>
    public decimal? FinancingAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SecondaryFinancingProvider SecondaryFinancingProviderType
    /// </summary>
    public StringEnumValue<SecondaryFinancingProviderType> SecondaryFinancingProviderType { get => GetValue<StringEnumValue<SecondaryFinancingProviderType>>(); set => SetValue(value); }

    /// <summary>
    /// HUD 92900 LT Seller Funded DAP [3008]
    /// </summary>
    public bool? SellerFundedDapIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// SecondaryFinancingProvider Source
    /// </summary>
    public string? Source { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SecondaryFinancingProvider SourceFromFamilyIndicator
    /// </summary>
    public bool? SourceFromFamilyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// SecondaryFinancingProvider SourceFromGovernmentIndicator
    /// </summary>
    public bool? SourceFromGovernmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// SecondaryFinancingProvider SourceFromNpIndicator
    /// </summary>
    public bool? SourceFromNpIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// SecondaryFinancingProvider SourceFromOtherIndicator
    /// </summary>
    public bool? SourceFromOtherIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// SecondaryFinancingProvider SourceOtherDetail
    /// </summary>
    public string? SourceOtherDetail { get => GetValue<string?>(); set => SetValue(value); }
}