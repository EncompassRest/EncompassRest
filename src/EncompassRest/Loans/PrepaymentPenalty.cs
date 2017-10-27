using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class PrepaymentPenalty : IDirty
    {
        private DirtyValue<string> _fullPrepaymentPenaltyOptionType;
        public string FullPrepaymentPenaltyOptionType { get { return _fullPrepaymentPenaltyOptionType; } set { _fullPrepaymentPenaltyOptionType = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _prepaymentPenaltyPercent;
        public decimal? PrepaymentPenaltyPercent { get { return _prepaymentPenaltyPercent; } set { _prepaymentPenaltyPercent = value; } }
        private DirtyValue<int?> _termMonthsCount;
        public int? TermMonthsCount { get { return _termMonthsCount; } set { _termMonthsCount = value; } }
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
                var dirty = _fullPrepaymentPenaltyOptionType.Dirty
                    || _id.Dirty
                    || _prepaymentPenaltyPercent.Dirty
                    || _termMonthsCount.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _fullPrepaymentPenaltyOptionType.Dirty = value;
                _id.Dirty = value;
                _prepaymentPenaltyPercent.Dirty = value;
                _termMonthsCount.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}