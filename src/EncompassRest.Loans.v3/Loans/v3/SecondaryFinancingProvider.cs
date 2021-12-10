using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// SecondaryFinancingProvider
/// </summary>
public sealed partial class SecondaryFinancingProvider : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _financingAmount;
    private DirtyValue<StringEnumValue<SecondaryFinancingProviderType>>? _secondaryFinancingProviderType;
    private DirtyValue<bool?>? _sellerFundedDapIndicator;
    private DirtyValue<string?>? _source;
    private DirtyValue<bool?>? _sourceFromFamilyIndicator;
    private DirtyValue<bool?>? _sourceFromGovernmentIndicator;
    private DirtyValue<bool?>? _sourceFromNpIndicator;
    private DirtyValue<bool?>? _sourceFromOtherIndicator;
    private DirtyValue<string?>? _sourceOtherDetail;

    /// <summary>
    /// SecondaryFinancingProviderContract FinancingAmount
    /// </summary>
    public decimal? FinancingAmount { get => _financingAmount; set => SetField(ref _financingAmount, value); }

    /// <summary>
    /// SecondaryFinancingProviderContract SecondaryFinancingProviderType
    /// </summary>
    public StringEnumValue<SecondaryFinancingProviderType> SecondaryFinancingProviderType { get => _secondaryFinancingProviderType; set => SetField(ref _secondaryFinancingProviderType, value); }

    /// <summary>
    /// HUD 92900 LT Seller Funded DAP [3008]
    /// </summary>
    public bool? SellerFundedDapIndicator { get => _sellerFundedDapIndicator; set => SetField(ref _sellerFundedDapIndicator, value); }

    /// <summary>
    /// SecondaryFinancingProviderContract Source
    /// </summary>
    public string? Source { get => _source; set => SetField(ref _source, value); }

    /// <summary>
    /// SecondaryFinancingProviderContract SourceFromFamilyIndicator
    /// </summary>
    public bool? SourceFromFamilyIndicator { get => _sourceFromFamilyIndicator; set => SetField(ref _sourceFromFamilyIndicator, value); }

    /// <summary>
    /// SecondaryFinancingProviderContract SourceFromGovernmentIndicator
    /// </summary>
    public bool? SourceFromGovernmentIndicator { get => _sourceFromGovernmentIndicator; set => SetField(ref _sourceFromGovernmentIndicator, value); }

    /// <summary>
    /// SecondaryFinancingProviderContract SourceFromNpIndicator
    /// </summary>
    public bool? SourceFromNpIndicator { get => _sourceFromNpIndicator; set => SetField(ref _sourceFromNpIndicator, value); }

    /// <summary>
    /// SecondaryFinancingProviderContract SourceFromOtherIndicator
    /// </summary>
    public bool? SourceFromOtherIndicator { get => _sourceFromOtherIndicator; set => SetField(ref _sourceFromOtherIndicator, value); }

    /// <summary>
    /// SecondaryFinancingProviderContract SourceOtherDetail
    /// </summary>
    public string? SourceOtherDetail { get => _sourceOtherDetail; set => SetField(ref _sourceOtherDetail, value); }
}