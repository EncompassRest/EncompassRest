using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class SecondaryFinancingProvider : IDirty
    {
        private DirtyValue<decimal?> _financingAmount;
        public decimal? FinancingAmount { get { return _financingAmount; } set { _financingAmount = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _secondaryFinancingProviderType;
        public string SecondaryFinancingProviderType { get { return _secondaryFinancingProviderType; } set { _secondaryFinancingProviderType = value; } }
        private DirtyValue<bool?> _sellerFundedDapIndicator;
        public bool? SellerFundedDapIndicator { get { return _sellerFundedDapIndicator; } set { _sellerFundedDapIndicator = value; } }
        private DirtyValue<string> _source;
        public string Source { get { return _source; } set { _source = value; } }
        private DirtyValue<bool?> _sourceFromFamilyIndicator;
        public bool? SourceFromFamilyIndicator { get { return _sourceFromFamilyIndicator; } set { _sourceFromFamilyIndicator = value; } }
        private DirtyValue<bool?> _sourceFromGovernmentIndicator;
        public bool? SourceFromGovernmentIndicator { get { return _sourceFromGovernmentIndicator; } set { _sourceFromGovernmentIndicator = value; } }
        private DirtyValue<bool?> _sourceFromNPIndicator;
        public bool? SourceFromNPIndicator { get { return _sourceFromNPIndicator; } set { _sourceFromNPIndicator = value; } }
        private DirtyValue<bool?> _sourceFromOtherIndicator;
        public bool? SourceFromOtherIndicator { get { return _sourceFromOtherIndicator; } set { _sourceFromOtherIndicator = value; } }
        private DirtyValue<string> _sourceOtherDetail;
        public string SourceOtherDetail { get { return _sourceOtherDetail; } set { _sourceOtherDetail = value; } }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get { return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); } set { _extensionData = new DirtyDictionary<string, object>(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _financingAmount.Dirty
                    || _id.Dirty
                    || _secondaryFinancingProviderType.Dirty
                    || _sellerFundedDapIndicator.Dirty
                    || _source.Dirty
                    || _sourceFromFamilyIndicator.Dirty
                    || _sourceFromGovernmentIndicator.Dirty
                    || _sourceFromNPIndicator.Dirty
                    || _sourceFromOtherIndicator.Dirty
                    || _sourceOtherDetail.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}