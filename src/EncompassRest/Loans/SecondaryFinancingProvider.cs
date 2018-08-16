using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// SecondaryFinancingProvider
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(SecondaryFinancingProviderType))]
    public sealed partial class SecondaryFinancingProvider : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _financingAmount;
        /// <summary>
        /// SecondaryFinancingProvider FinancingAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FinancingAmount { get => _financingAmount; set => SetField(ref _financingAmount, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// SecondaryFinancingProvider Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<StringEnumValue<SecondaryFinancingProviderType>> _secondaryFinancingProviderType;
        /// <summary>
        /// SecondaryFinancingProvider SecondaryFinancingProviderType
        /// </summary>
        public StringEnumValue<SecondaryFinancingProviderType> SecondaryFinancingProviderType { get => _secondaryFinancingProviderType; set => SetField(ref _secondaryFinancingProviderType, value); }
        private DirtyValue<bool?> _sellerFundedDapIndicator;
        /// <summary>
        /// HUD 92900 LT Seller Funded DAP [3008]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 92900 LT Seller Funded DAP")]
        public bool? SellerFundedDapIndicator { get => _sellerFundedDapIndicator; set => SetField(ref _sellerFundedDapIndicator, value); }
        private DirtyValue<string> _source;
        /// <summary>
        /// SecondaryFinancingProvider Source
        /// </summary>
        public string Source { get => _source; set => SetField(ref _source, value); }
        private DirtyValue<bool?> _sourceFromFamilyIndicator;
        /// <summary>
        /// SecondaryFinancingProvider SourceFromFamilyIndicator
        /// </summary>
        public bool? SourceFromFamilyIndicator { get => _sourceFromFamilyIndicator; set => SetField(ref _sourceFromFamilyIndicator, value); }
        private DirtyValue<bool?> _sourceFromGovernmentIndicator;
        /// <summary>
        /// SecondaryFinancingProvider SourceFromGovernmentIndicator
        /// </summary>
        public bool? SourceFromGovernmentIndicator { get => _sourceFromGovernmentIndicator; set => SetField(ref _sourceFromGovernmentIndicator, value); }
        private DirtyValue<bool?> _sourceFromNPIndicator;
        /// <summary>
        /// SecondaryFinancingProvider SourceFromNPIndicator
        /// </summary>
        public bool? SourceFromNPIndicator { get => _sourceFromNPIndicator; set => SetField(ref _sourceFromNPIndicator, value); }
        private DirtyValue<bool?> _sourceFromOtherIndicator;
        /// <summary>
        /// SecondaryFinancingProvider SourceFromOtherIndicator
        /// </summary>
        public bool? SourceFromOtherIndicator { get => _sourceFromOtherIndicator; set => SetField(ref _sourceFromOtherIndicator, value); }
        private DirtyValue<string> _sourceOtherDetail;
        /// <summary>
        /// SecondaryFinancingProvider SourceOtherDetail
        /// </summary>
        public string SourceOtherDetail { get => _sourceOtherDetail; set => SetField(ref _sourceOtherDetail, value); }
    }
}