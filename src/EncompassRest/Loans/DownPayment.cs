using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class DownPayment : IDirty
    {
        private DirtyValue<decimal?> _amount;
        public decimal? Amount { get { return _amount; } set { _amount = value; } }
        private DirtyValue<string> _downPaymentType;
        public string DownPaymentType { get { return _downPaymentType; } set { _downPaymentType = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _sourceDescription;
        public string SourceDescription { get { return _sourceDescription; } set { _sourceDescription = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _amount.Dirty
                    || _downPaymentType.Dirty
                    || _id.Dirty
                    || _sourceDescription.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _amount.Dirty = value;
                _downPaymentType.Dirty = value;
                _id.Dirty = value;
                _sourceDescription.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}