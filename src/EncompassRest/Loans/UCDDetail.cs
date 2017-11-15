using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class UCDDetail : IDirty
    {
        private DirtyValue<StringEnumValue<UCDPayoffType>> _feeAccountType;
        public StringEnumValue<UCDPayoffType> FeeAccountType { get => _feeAccountType; set => _feeAccountType = value; }
        private DirtyValue<decimal?> _feeAmount;
        public decimal? FeeAmount { get => _feeAmount; set => _feeAmount = value; }
        private DirtyValue<DateTime?> _feeDateFrom;
        public DateTime? FeeDateFrom { get => _feeDateFrom; set => _feeDateFrom = value; }
        private DirtyValue<DateTime?> _feeDateTo;
        public DateTime? FeeDateTo { get => _feeDateTo; set => _feeDateTo = value; }
        private DirtyValue<string> _feeDesc;
        public string FeeDesc { get => _feeDesc; set => _feeDesc = value; }
        private DirtyValue<int?> _feeIndex;
        public int? FeeIndex { get => _feeIndex; set => _feeIndex = value; }
        private DirtyValue<StringEnumValue<FeePaidBy>> _feePaidBy;
        public StringEnumValue<FeePaidBy> FeePaidBy { get => _feePaidBy; set => _feePaidBy = value; }
        private DirtyValue<string> _feePaidTo;
        public string FeePaidTo { get => _feePaidTo; set => _feePaidTo = value; }
        private DirtyValue<bool?> _feePOC;
        public bool? FeePOC { get => _feePOC; set => _feePOC = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<int?> _lineNumber;
        public int? LineNumber { get => _lineNumber; set => _lineNumber = value; }
        private DirtyValue<string> _section;
        public string Section { get => _section; set => _section = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _feeAccountType.Dirty
                    || _feeAmount.Dirty
                    || _feeDateFrom.Dirty
                    || _feeDateTo.Dirty
                    || _feeDesc.Dirty
                    || _feeIndex.Dirty
                    || _feePaidBy.Dirty
                    || _feePaidTo.Dirty
                    || _feePOC.Dirty
                    || _id.Dirty
                    || _lineNumber.Dirty
                    || _section.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _feeAccountType.Dirty = value;
                _feeAmount.Dirty = value;
                _feeDateFrom.Dirty = value;
                _feeDateTo.Dirty = value;
                _feeDesc.Dirty = value;
                _feeIndex.Dirty = value;
                _feePaidBy.Dirty = value;
                _feePaidTo.Dirty = value;
                _feePOC.Dirty = value;
                _id.Dirty = value;
                _lineNumber.Dirty = value;
                _section.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}