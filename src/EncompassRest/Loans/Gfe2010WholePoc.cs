using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010WholePoc : IDirty
    {
        private Value<int?> _gfe2010WholePocIndex;
        public int? Gfe2010WholePocIndex { get { return _gfe2010WholePocIndex; } set { _gfe2010WholePocIndex = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
        private Value<decimal?> _wholePoc;
        public decimal? WholePoc { get { return _wholePoc; } set { _wholePoc = value; } }
        private Value<string> _wholePocPaidByType;
        public string WholePocPaidByType { get { return _wholePocPaidByType; } set { _wholePocPaidByType = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _gfe2010WholePocIndex.Dirty
                    || _id.Dirty
                    || _lineNumber.Dirty
                    || _wholePoc.Dirty
                    || _wholePocPaidByType.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _gfe2010WholePocIndex.Dirty = value;
                _id.Dirty = value;
                _lineNumber.Dirty = value;
                _wholePoc.Dirty = value;
                _wholePocPaidByType.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}