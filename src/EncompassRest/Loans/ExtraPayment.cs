#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class ExtraPayment : ExtensibleObject
    {
        private DirtyValue<decimal?> _amount;
        public decimal? Amount { get => _amount; set => _amount = value; }
        private DirtyValue<DateTime?> _date;
        public DateTime? Date { get => _date; set => _date = value; }
        private DirtyValue<int?> _extraPaymentIndex;
        public int? ExtraPaymentIndex { get => _extraPaymentIndex; set => _extraPaymentIndex = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<int?> _lineNumber;
        public int? LineNumber { get => _lineNumber; set => _lineNumber = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _amount.Dirty
                    || _date.Dirty
                    || _extraPaymentIndex.Dirty
                    || _id.Dirty
                    || _lineNumber.Dirty;
            }
            set
            {
                _amount.Dirty = value;
                _date.Dirty = value;
                _extraPaymentIndex.Dirty = value;
                _id.Dirty = value;
                _lineNumber.Dirty = value;
            }
        }
    }
}