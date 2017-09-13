using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class RespaHudDetail : IDirty
    {
        private Value<string> _creditDebt;
        public string CreditDebt { get { return _creditDebt; } set { _creditDebt = value; } }
        private Value<string> _fWBC;
        public string FWBC { get { return _fWBC; } set { _fWBC = value; } }
        private Value<DateTime?> _hUD1LineItemFromDate;
        public DateTime? HUD1LineItemFromDate { get { return _hUD1LineItemFromDate; } set { _hUD1LineItemFromDate = value; } }
        private Value<DateTime?> _hUD1LineItemToDate;
        public DateTime? HUD1LineItemToDate { get { return _hUD1LineItemToDate; } set { _hUD1LineItemToDate = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _lineItemAmount;
        public decimal? LineItemAmount { get { return _lineItemAmount; } set { _lineItemAmount = value; } }
        private Value<string> _lineItemDescription;
        public string LineItemDescription { get { return _lineItemDescription; } set { _lineItemDescription = value; } }
        private Value<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
        private Value<decimal?> _realValue;
        public decimal? RealValue { get { return _realValue; } set { _realValue = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _creditDebt.Dirty
                    || _fWBC.Dirty
                    || _hUD1LineItemFromDate.Dirty
                    || _hUD1LineItemToDate.Dirty
                    || _id.Dirty
                    || _lineItemAmount.Dirty
                    || _lineItemDescription.Dirty
                    || _lineNumber.Dirty
                    || _realValue.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _creditDebt.Dirty = value;
                _fWBC.Dirty = value;
                _hUD1LineItemFromDate.Dirty = value;
                _hUD1LineItemToDate.Dirty = value;
                _id.Dirty = value;
                _lineItemAmount.Dirty = value;
                _lineItemDescription.Dirty = value;
                _lineNumber.Dirty = value;
                _realValue.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}