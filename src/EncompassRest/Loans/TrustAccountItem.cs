using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// TrustAccountItem
    /// </summary>
    public sealed partial class TrustAccountItem : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _date;
        /// <summary>
        /// Trust Acct Trans Descr Date [TANNDT]
        /// </summary>
        [LoanFieldProperty(Description = "Trust Acct Trans Descr Date")]
        public DateTime? Date { get => _date; set => _date = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// Trust Acct Trans Descr [TANNDS]
        /// </summary>
        [LoanFieldProperty(Description = "Trust Acct Trans Descr")]
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// TrustAccountItem Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _notes;
        /// <summary>
        /// Trust Acct Trans Descr Notes [TANNNO]
        /// </summary>
        [LoanFieldProperty(Description = "Trust Acct Trans Descr Notes")]
        public string Notes { get => _notes; set => _notes = value; }
        private DirtyValue<decimal?> _paymentAmount;
        /// <summary>
        /// Trust Acct Trans Descr Pymt Amt [TANNPA]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trust Acct Trans Descr Pymt Amt")]
        public decimal? PaymentAmount { get => _paymentAmount; set => _paymentAmount = value; }
        private DirtyValue<string> _paymentCheckNo;
        /// <summary>
        /// Trust Acct Trans Descr Pymt Check [TANNPC]
        /// </summary>
        [LoanFieldProperty(Description = "Trust Acct Trans Descr Pymt Check")]
        public string PaymentCheckNo { get => _paymentCheckNo; set => _paymentCheckNo = value; }
        private DirtyValue<decimal?> _receiptAmount;
        /// <summary>
        /// Trust Acct Trans Descr Receipt Amt [TANNRA]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trust Acct Trans Descr Receipt Amt")]
        public decimal? ReceiptAmount { get => _receiptAmount; set => _receiptAmount = value; }
        private DirtyValue<string> _receiptCheckNo;
        /// <summary>
        /// Trust Acct Trans Descr Receipt Check [TANNRC]
        /// </summary>
        [LoanFieldProperty(Description = "Trust Acct Trans Descr Receipt Check")]
        public string ReceiptCheckNo { get => _receiptCheckNo; set => _receiptCheckNo = value; }
        private DirtyValue<int?> _trustAccountItemIndex;
        /// <summary>
        /// TrustAccountItem TrustAccountItemIndex
        /// </summary>
        public int? TrustAccountItemIndex { get => _trustAccountItemIndex; set => _trustAccountItemIndex = value; }
        internal override bool DirtyInternal
        {
            get => _date.Dirty
                || _description.Dirty
                || _id.Dirty
                || _notes.Dirty
                || _paymentAmount.Dirty
                || _paymentCheckNo.Dirty
                || _receiptAmount.Dirty
                || _receiptCheckNo.Dirty
                || _trustAccountItemIndex.Dirty;
            set
            {
                _date.Dirty = value;
                _description.Dirty = value;
                _id.Dirty = value;
                _notes.Dirty = value;
                _paymentAmount.Dirty = value;
                _paymentCheckNo.Dirty = value;
                _receiptAmount.Dirty = value;
                _receiptCheckNo.Dirty = value;
                _trustAccountItemIndex.Dirty = value;
            }
        }
    }
}