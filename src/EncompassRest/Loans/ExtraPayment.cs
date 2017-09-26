using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ExtraPayment : IDirty
    {
        private Value<decimal?> _amount;
        public decimal? Amount { get { return _amount; } set { _amount = value; } }
        private Value<DateTime?> _date;
        public DateTime? Date { get { return _date; } set { _date = value; } }
        private Value<int?> _extraPaymentIndex;
        public int? ExtraPaymentIndex { get { return _extraPaymentIndex; } set { _extraPaymentIndex = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _amount.Dirty
                    || _date.Dirty
                    || _extraPaymentIndex.Dirty
                    || _id.Dirty
                    || _lineNumber.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _amount.Dirty = value;
                _date.Dirty = value;
                _extraPaymentIndex.Dirty = value;
                _id.Dirty = value;
                _lineNumber.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}