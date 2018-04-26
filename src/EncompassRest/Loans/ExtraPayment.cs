using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ExtraPayment
    /// </summary>
    public sealed partial class ExtraPayment : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amount;
        /// <summary>
        /// ExtraPayment Amount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Amount { get => _amount; set => _amount = value; }
        private DirtyValue<DateTime?> _date;
        /// <summary>
        /// ExtraPayment Date
        /// </summary>
        public DateTime? Date { get => _date; set => _date = value; }
        private DirtyValue<int?> _extraPaymentIndex;
        /// <summary>
        /// ExtraPayment ExtraPaymentIndex
        /// </summary>
        public int? ExtraPaymentIndex { get => _extraPaymentIndex; set => _extraPaymentIndex = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// ExtraPayment Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<int?> _lineNumber;
        /// <summary>
        /// ExtraPayment LineNumber
        /// </summary>
        public int? LineNumber { get => _lineNumber; set => _lineNumber = value; }
        internal override bool DirtyInternal
        {
            get => _amount.Dirty
                || _date.Dirty
                || _extraPaymentIndex.Dirty
                || _id.Dirty
                || _lineNumber.Dirty;
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