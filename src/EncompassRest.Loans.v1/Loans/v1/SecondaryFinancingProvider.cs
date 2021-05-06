using EncompassRest.Loans.v1.Enums;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// SecondaryFinancingProvider
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(SecondaryFinancingProviderType))]
    public sealed partial class SecondaryFinancingProvider : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?>? _financingAmount;
        private DirtyValue<string?>? _id;
        private DirtyValue<StringEnumValue<SecondaryFinancingProviderType>>? _secondaryFinancingProviderType;
        private DirtyValue<bool?>? _sellerFundedDapIndicator;
        private DirtyValue<string?>? _source;
        private DirtyValue<bool?>? _sourceFromFamilyIndicator;
        private DirtyValue<bool?>? _sourceFromGovernmentIndicator;
        private DirtyValue<bool?>? _sourceFromNPIndicator;
        private DirtyValue<bool?>? _sourceFromOtherIndicator;
        private DirtyValue<string?>? _sourceOtherDetail;

        /// <summary>
        /// SecondaryFinancingProvider FinancingAmount
        /// </summary>
        public decimal? FinancingAmount { get => _financingAmount; set => SetField(ref _financingAmount, value); }

        /// <summary>
        /// SecondaryFinancingProvider Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// SecondaryFinancingProvider SecondaryFinancingProviderType
        /// </summary>
        public StringEnumValue<SecondaryFinancingProviderType> SecondaryFinancingProviderType { get => _secondaryFinancingProviderType; set => SetField(ref _secondaryFinancingProviderType, value); }

        /// <summary>
        /// HUD 92900 LT Seller Funded DAP [3008]
        /// </summary>
        public bool? SellerFundedDapIndicator { get => _sellerFundedDapIndicator; set => SetField(ref _sellerFundedDapIndicator, value); }

        /// <summary>
        /// SecondaryFinancingProvider Source
        /// </summary>
        public string? Source { get => _source; set => SetField(ref _source, value); }

        /// <summary>
        /// SecondaryFinancingProvider SourceFromFamilyIndicator
        /// </summary>
        public bool? SourceFromFamilyIndicator { get => _sourceFromFamilyIndicator; set => SetField(ref _sourceFromFamilyIndicator, value); }

        /// <summary>
        /// SecondaryFinancingProvider SourceFromGovernmentIndicator
        /// </summary>
        public bool? SourceFromGovernmentIndicator { get => _sourceFromGovernmentIndicator; set => SetField(ref _sourceFromGovernmentIndicator, value); }

        /// <summary>
        /// SecondaryFinancingProvider SourceFromNPIndicator
        /// </summary>
        public bool? SourceFromNPIndicator { get => _sourceFromNPIndicator; set => SetField(ref _sourceFromNPIndicator, value); }

        /// <summary>
        /// SecondaryFinancingProvider SourceFromOtherIndicator
        /// </summary>
        public bool? SourceFromOtherIndicator { get => _sourceFromOtherIndicator; set => SetField(ref _sourceFromOtherIndicator, value); }

        /// <summary>
        /// SecondaryFinancingProvider SourceOtherDetail
        /// </summary>
        public string? SourceOtherDetail { get => _sourceOtherDetail; set => SetField(ref _sourceOtherDetail, value); }
    }
}