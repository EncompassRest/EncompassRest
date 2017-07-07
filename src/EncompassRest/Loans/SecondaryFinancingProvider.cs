using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class SecondaryFinancingProvider : IClean
    {
        private Value<decimal?> _financingAmount;
        public decimal? FinancingAmount { get { return _financingAmount; } set { _financingAmount = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _secondaryFinancingProviderType;
        public string SecondaryFinancingProviderType { get { return _secondaryFinancingProviderType; } set { _secondaryFinancingProviderType = value; } }
        private Value<bool?> _sellerFundedDapIndicator;
        public bool? SellerFundedDapIndicator { get { return _sellerFundedDapIndicator; } set { _sellerFundedDapIndicator = value; } }
        private Value<string> _source;
        public string Source { get { return _source; } set { _source = value; } }
        private Value<bool?> _sourceFromFamilyIndicator;
        public bool? SourceFromFamilyIndicator { get { return _sourceFromFamilyIndicator; } set { _sourceFromFamilyIndicator = value; } }
        private Value<bool?> _sourceFromGovernmentIndicator;
        public bool? SourceFromGovernmentIndicator { get { return _sourceFromGovernmentIndicator; } set { _sourceFromGovernmentIndicator = value; } }
        private Value<bool?> _sourceFromNPIndicator;
        public bool? SourceFromNPIndicator { get { return _sourceFromNPIndicator; } set { _sourceFromNPIndicator = value; } }
        private Value<bool?> _sourceFromOtherIndicator;
        public bool? SourceFromOtherIndicator { get { return _sourceFromOtherIndicator; } set { _sourceFromOtherIndicator = value; } }
        private Value<string> _sourceOtherDetail;
        public string SourceOtherDetail { get { return _sourceOtherDetail; } set { _sourceOtherDetail = value; } }
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
                var financingAmount = _financingAmount; financingAmount.Clean = value; _financingAmount = financingAmount;
                var id = _id; id.Clean = value; _id = id;
                var secondaryFinancingProviderType = _secondaryFinancingProviderType; secondaryFinancingProviderType.Clean = value; _secondaryFinancingProviderType = secondaryFinancingProviderType;
                var sellerFundedDapIndicator = _sellerFundedDapIndicator; sellerFundedDapIndicator.Clean = value; _sellerFundedDapIndicator = sellerFundedDapIndicator;
                var source = _source; source.Clean = value; _source = source;
                var sourceFromFamilyIndicator = _sourceFromFamilyIndicator; sourceFromFamilyIndicator.Clean = value; _sourceFromFamilyIndicator = sourceFromFamilyIndicator;
                var sourceFromGovernmentIndicator = _sourceFromGovernmentIndicator; sourceFromGovernmentIndicator.Clean = value; _sourceFromGovernmentIndicator = sourceFromGovernmentIndicator;
                var sourceFromNPIndicator = _sourceFromNPIndicator; sourceFromNPIndicator.Clean = value; _sourceFromNPIndicator = sourceFromNPIndicator;
                var sourceFromOtherIndicator = _sourceFromOtherIndicator; sourceFromOtherIndicator.Clean = value; _sourceFromOtherIndicator = sourceFromOtherIndicator;
                var sourceOtherDetail = _sourceOtherDetail; sourceOtherDetail.Clean = value; _sourceOtherDetail = sourceOtherDetail;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public SecondaryFinancingProvider()
        {
            Clean = true;
        }
    }
}