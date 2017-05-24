using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class SecondaryFinancingProvider
    {
        private Value<decimal?> _financingAmount;
        public decimal? FinancingAmount { get { return _financingAmount; } set { _financingAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancingAmount() => !_financingAmount.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _secondaryFinancingProviderType;
        public string SecondaryFinancingProviderType { get { return _secondaryFinancingProviderType; } set { _secondaryFinancingProviderType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecondaryFinancingProviderType() => !_secondaryFinancingProviderType.Clean;
        private Value<bool?> _sellerFundedDapIndicator;
        public bool? SellerFundedDapIndicator { get { return _sellerFundedDapIndicator; } set { _sellerFundedDapIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerFundedDapIndicator() => !_sellerFundedDapIndicator.Clean;
        private Value<string> _source;
        public string Source { get { return _source; } set { _source = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSource() => !_source.Clean;
        private Value<bool?> _sourceFromFamilyIndicator;
        public bool? SourceFromFamilyIndicator { get { return _sourceFromFamilyIndicator; } set { _sourceFromFamilyIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSourceFromFamilyIndicator() => !_sourceFromFamilyIndicator.Clean;
        private Value<bool?> _sourceFromGovernmentIndicator;
        public bool? SourceFromGovernmentIndicator { get { return _sourceFromGovernmentIndicator; } set { _sourceFromGovernmentIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSourceFromGovernmentIndicator() => !_sourceFromGovernmentIndicator.Clean;
        private Value<bool?> _sourceFromNPIndicator;
        public bool? SourceFromNPIndicator { get { return _sourceFromNPIndicator; } set { _sourceFromNPIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSourceFromNPIndicator() => !_sourceFromNPIndicator.Clean;
        private Value<bool?> _sourceFromOtherIndicator;
        public bool? SourceFromOtherIndicator { get { return _sourceFromOtherIndicator; } set { _sourceFromOtherIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSourceFromOtherIndicator() => !_sourceFromOtherIndicator.Clean;
        private Value<string> _sourceOtherDetail;
        public string SourceOtherDetail { get { return _sourceOtherDetail; } set { _sourceOtherDetail = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSourceOtherDetail() => !_sourceOtherDetail.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _financingAmount.Clean
                    && _id.Clean
                    && _secondaryFinancingProviderType.Clean
                    && _sellerFundedDapIndicator.Clean
                    && _source.Clean
                    && _sourceFromFamilyIndicator.Clean
                    && _sourceFromGovernmentIndicator.Clean
                    && _sourceFromNPIndicator.Clean
                    && _sourceFromOtherIndicator.Clean
                    && _sourceOtherDetail.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _financingAmount; v0.Clean = value; _financingAmount = v0;
                var v1 = _id; v1.Clean = value; _id = v1;
                var v2 = _secondaryFinancingProviderType; v2.Clean = value; _secondaryFinancingProviderType = v2;
                var v3 = _sellerFundedDapIndicator; v3.Clean = value; _sellerFundedDapIndicator = v3;
                var v4 = _source; v4.Clean = value; _source = v4;
                var v5 = _sourceFromFamilyIndicator; v5.Clean = value; _sourceFromFamilyIndicator = v5;
                var v6 = _sourceFromGovernmentIndicator; v6.Clean = value; _sourceFromGovernmentIndicator = v6;
                var v7 = _sourceFromNPIndicator; v7.Clean = value; _sourceFromNPIndicator = v7;
                var v8 = _sourceFromOtherIndicator; v8.Clean = value; _sourceFromOtherIndicator = v8;
                var v9 = _sourceOtherDetail; v9.Clean = value; _sourceOtherDetail = v9;
                _settingClean = 0;
            }
        }
    }
}