using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class UCDDetail : IDirty
    {
        private DirtyValue<string> _feeAccountType;
        public string FeeAccountType { get { return _feeAccountType; } set { _feeAccountType = value; } }
        private DirtyValue<decimal?> _feeAmount;
        public decimal? FeeAmount { get { return _feeAmount; } set { _feeAmount = value; } }
        private DirtyValue<DateTime?> _feeDateFrom;
        public DateTime? FeeDateFrom { get { return _feeDateFrom; } set { _feeDateFrom = value; } }
        private DirtyValue<DateTime?> _feeDateTo;
        public DateTime? FeeDateTo { get { return _feeDateTo; } set { _feeDateTo = value; } }
        private DirtyValue<string> _feeDesc;
        public string FeeDesc { get { return _feeDesc; } set { _feeDesc = value; } }
        private DirtyValue<int?> _feeIndex;
        public int? FeeIndex { get { return _feeIndex; } set { _feeIndex = value; } }
        private DirtyValue<string> _feePaidBy;
        public string FeePaidBy { get { return _feePaidBy; } set { _feePaidBy = value; } }
        private DirtyValue<string> _feePaidTo;
        public string FeePaidTo { get { return _feePaidTo; } set { _feePaidTo = value; } }
        private DirtyValue<bool?> _feePOC;
        public bool? FeePOC { get { return _feePOC; } set { _feePOC = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
        private DirtyValue<string> _section;
        public string Section { get { return _section; } set { _section = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
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
                    || _section.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}