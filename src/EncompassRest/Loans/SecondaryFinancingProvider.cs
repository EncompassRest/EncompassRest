using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// SecondaryFinancingProvider
    /// </summary>
    public sealed partial class SecondaryFinancingProvider : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _financingAmount;
        /// <summary>
        /// SecondaryFinancingProvider FinancingAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FinancingAmount { get => _financingAmount; set => _financingAmount = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// SecondaryFinancingProvider Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<SecondaryFinancingProviderType>> _secondaryFinancingProviderType;
        /// <summary>
        /// SecondaryFinancingProvider SecondaryFinancingProviderType
        /// </summary>
        public StringEnumValue<SecondaryFinancingProviderType> SecondaryFinancingProviderType { get => _secondaryFinancingProviderType; set => _secondaryFinancingProviderType = value; }
        private DirtyValue<bool?> _sellerFundedDapIndicator;
        /// <summary>
        /// HUD 92900 LT Seller Funded DAP [3008]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 92900 LT Seller Funded DAP")]
        public bool? SellerFundedDapIndicator { get => _sellerFundedDapIndicator; set => _sellerFundedDapIndicator = value; }
        private DirtyValue<string> _source;
        /// <summary>
        /// SecondaryFinancingProvider Source
        /// </summary>
        public string Source { get => _source; set => _source = value; }
        private DirtyValue<bool?> _sourceFromFamilyIndicator;
        /// <summary>
        /// SecondaryFinancingProvider SourceFromFamilyIndicator
        /// </summary>
        public bool? SourceFromFamilyIndicator { get => _sourceFromFamilyIndicator; set => _sourceFromFamilyIndicator = value; }
        private DirtyValue<bool?> _sourceFromGovernmentIndicator;
        /// <summary>
        /// SecondaryFinancingProvider SourceFromGovernmentIndicator
        /// </summary>
        public bool? SourceFromGovernmentIndicator { get => _sourceFromGovernmentIndicator; set => _sourceFromGovernmentIndicator = value; }
        private DirtyValue<bool?> _sourceFromNPIndicator;
        /// <summary>
        /// SecondaryFinancingProvider SourceFromNPIndicator
        /// </summary>
        public bool? SourceFromNPIndicator { get => _sourceFromNPIndicator; set => _sourceFromNPIndicator = value; }
        private DirtyValue<bool?> _sourceFromOtherIndicator;
        /// <summary>
        /// SecondaryFinancingProvider SourceFromOtherIndicator
        /// </summary>
        public bool? SourceFromOtherIndicator { get => _sourceFromOtherIndicator; set => _sourceFromOtherIndicator = value; }
        private DirtyValue<string> _sourceOtherDetail;
        /// <summary>
        /// SecondaryFinancingProvider SourceOtherDetail
        /// </summary>
        public string SourceOtherDetail { get => _sourceOtherDetail; set => _sourceOtherDetail = value; }
        internal override bool DirtyInternal
        {
            get => _financingAmount.Dirty
                || _id.Dirty
                || _secondaryFinancingProviderType.Dirty
                || _sellerFundedDapIndicator.Dirty
                || _source.Dirty
                || _sourceFromFamilyIndicator.Dirty
                || _sourceFromGovernmentIndicator.Dirty
                || _sourceFromNPIndicator.Dirty
                || _sourceFromOtherIndicator.Dirty
                || _sourceOtherDetail.Dirty;
            set
            {
                _financingAmount.Dirty = value;
                _id.Dirty = value;
                _secondaryFinancingProviderType.Dirty = value;
                _sellerFundedDapIndicator.Dirty = value;
                _source.Dirty = value;
                _sourceFromFamilyIndicator.Dirty = value;
                _sourceFromGovernmentIndicator.Dirty = value;
                _sourceFromNPIndicator.Dirty = value;
                _sourceFromOtherIndicator.Dirty = value;
                _sourceOtherDetail.Dirty = value;
            }
        }
    }
}