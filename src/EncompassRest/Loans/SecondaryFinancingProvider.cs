#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class SecondaryFinancingProvider : ExtensibleObject
    {
        private DirtyValue<decimal?> _financingAmount;
        public decimal? FinancingAmount { get => _financingAmount; set => _financingAmount = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _secondaryFinancingProviderType;
        public string SecondaryFinancingProviderType { get => _secondaryFinancingProviderType; set => _secondaryFinancingProviderType = value; }
        private DirtyValue<bool?> _sellerFundedDapIndicator;
        public bool? SellerFundedDapIndicator { get => _sellerFundedDapIndicator; set => _sellerFundedDapIndicator = value; }
        private DirtyValue<string> _source;
        public string Source { get => _source; set => _source = value; }
        private DirtyValue<bool?> _sourceFromFamilyIndicator;
        public bool? SourceFromFamilyIndicator { get => _sourceFromFamilyIndicator; set => _sourceFromFamilyIndicator = value; }
        private DirtyValue<bool?> _sourceFromGovernmentIndicator;
        public bool? SourceFromGovernmentIndicator { get => _sourceFromGovernmentIndicator; set => _sourceFromGovernmentIndicator = value; }
        private DirtyValue<bool?> _sourceFromNPIndicator;
        public bool? SourceFromNPIndicator { get => _sourceFromNPIndicator; set => _sourceFromNPIndicator = value; }
        private DirtyValue<bool?> _sourceFromOtherIndicator;
        public bool? SourceFromOtherIndicator { get => _sourceFromOtherIndicator; set => _sourceFromOtherIndicator = value; }
        private DirtyValue<string> _sourceOtherDetail;
        public string SourceOtherDetail { get => _sourceOtherDetail; set => _sourceOtherDetail = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _financingAmount.Dirty
                    || _id.Dirty
                    || _secondaryFinancingProviderType.Dirty
                    || _sellerFundedDapIndicator.Dirty
                    || _source.Dirty
                    || _sourceFromFamilyIndicator.Dirty
                    || _sourceFromGovernmentIndicator.Dirty
                    || _sourceFromNPIndicator.Dirty
                    || _sourceFromOtherIndicator.Dirty
                    || _sourceOtherDetail.Dirty;
            }
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