using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Buydown : IDirty
    {
        private DirtyValue<int?> _buydownIndex;
        public int? BuydownIndex { get { return _buydownIndex; } set { _buydownIndex = value; } }
        private DirtyValue<decimal?> _buydownRatePercent;
        public decimal? BuydownRatePercent { get { return _buydownRatePercent; } set { _buydownRatePercent = value; } }
        private DirtyValue<int?> _changeFrequencyMonthsCount;
        public int? ChangeFrequencyMonthsCount { get { return _changeFrequencyMonthsCount; } set { _changeFrequencyMonthsCount = value; } }
        private DirtyValue<int?> _durationMonthsCount;
        public int? DurationMonthsCount { get { return _durationMonthsCount; } set { _durationMonthsCount = value; } }
        private DirtyValue<decimal?> _fundBalanceAmount;
        public decimal? FundBalanceAmount { get { return _fundBalanceAmount; } set { _fundBalanceAmount = value; } }
        private DirtyValue<decimal?> _fundTotalAmount;
        public decimal? FundTotalAmount { get { return _fundTotalAmount; } set { _fundTotalAmount = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _increaseRatePercent;
        public decimal? IncreaseRatePercent { get { return _increaseRatePercent; } set { _increaseRatePercent = value; } }
        private DirtyValue<int?> _remainingMonthsCount;
        public int? RemainingMonthsCount { get { return _remainingMonthsCount; } set { _remainingMonthsCount = value; } }
        private DirtyValue<decimal?> _subsidyAmount;
        public decimal? SubsidyAmount { get { return _subsidyAmount; } set { _subsidyAmount = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _buydownIndex.Dirty
                    || _buydownRatePercent.Dirty
                    || _changeFrequencyMonthsCount.Dirty
                    || _durationMonthsCount.Dirty
                    || _fundBalanceAmount.Dirty
                    || _fundTotalAmount.Dirty
                    || _id.Dirty
                    || _increaseRatePercent.Dirty
                    || _remainingMonthsCount.Dirty
                    || _subsidyAmount.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _buydownIndex.Dirty = value;
                _buydownRatePercent.Dirty = value;
                _changeFrequencyMonthsCount.Dirty = value;
                _durationMonthsCount.Dirty = value;
                _fundBalanceAmount.Dirty = value;
                _fundTotalAmount.Dirty = value;
                _id.Dirty = value;
                _increaseRatePercent.Dirty = value;
                _remainingMonthsCount.Dirty = value;
                _subsidyAmount.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}