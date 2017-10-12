using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class HelocRepaymentDrawPeriod : IDirty
    {
        private DirtyValue<decimal?> _apr;
        public decimal? Apr { get { return _apr; } set { _apr = value; } }
        private DirtyValue<bool?> _drawIndicator;
        public bool? DrawIndicator { get { return _drawIndicator; } set { _drawIndicator = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _indexRatePercent;
        public decimal? IndexRatePercent { get { return _indexRatePercent; } set { _indexRatePercent = value; } }
        private DirtyValue<decimal?> _marginRatePercent;
        public decimal? MarginRatePercent { get { return _marginRatePercent; } set { _marginRatePercent = value; } }
        private DirtyValue<decimal?> _minimumMonthlyPaymentAmount;
        public decimal? MinimumMonthlyPaymentAmount { get { return _minimumMonthlyPaymentAmount; } set { _minimumMonthlyPaymentAmount = value; } }
        private DirtyValue<int?> _year;
        public int? Year { get { return _year; } set { _year = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _apr.Dirty
                    || _drawIndicator.Dirty
                    || _id.Dirty
                    || _indexRatePercent.Dirty
                    || _marginRatePercent.Dirty
                    || _minimumMonthlyPaymentAmount.Dirty
                    || _year.Dirty;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _apr.Dirty = value;
                _drawIndicator.Dirty = value;
                _id.Dirty = value;
                _indexRatePercent.Dirty = value;
                _marginRatePercent.Dirty = value;
                _minimumMonthlyPaymentAmount.Dirty = value;
                _year.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}