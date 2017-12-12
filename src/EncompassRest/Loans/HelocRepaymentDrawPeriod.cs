#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class HelocRepaymentDrawPeriod : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _apr;
        public decimal? Apr { get => _apr; set => _apr = value; }
        private DirtyValue<bool?> _drawIndicator;
        public bool? DrawIndicator { get => _drawIndicator; set => _drawIndicator = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _indexRatePercent;
        public decimal? IndexRatePercent { get => _indexRatePercent; set => _indexRatePercent = value; }
        private DirtyValue<decimal?> _marginRatePercent;
        public decimal? MarginRatePercent { get => _marginRatePercent; set => _marginRatePercent = value; }
        private DirtyValue<decimal?> _minimumMonthlyPaymentAmount;
        public decimal? MinimumMonthlyPaymentAmount { get => _minimumMonthlyPaymentAmount; set => _minimumMonthlyPaymentAmount = value; }
        private DirtyValue<int?> _year;
        public int? Year { get => _year; set => _year = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _apr.Dirty
                    || _drawIndicator.Dirty
                    || _id.Dirty
                    || _indexRatePercent.Dirty
                    || _marginRatePercent.Dirty
                    || _minimumMonthlyPaymentAmount.Dirty
                    || _year.Dirty;
            }
            set
            {
                _apr.Dirty = value;
                _drawIndicator.Dirty = value;
                _id.Dirty = value;
                _indexRatePercent.Dirty = value;
                _marginRatePercent.Dirty = value;
                _minimumMonthlyPaymentAmount.Dirty = value;
                _year.Dirty = value;
            }
        }
    }
}