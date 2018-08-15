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
        public DateTime? Date { get => _date; set => SetField(ref _date, value); }
        private DirtyValue<string> _description;
        /// <summary>
        /// Trust Acct Trans Descr [TANNDS]
        /// </summary>
        [LoanFieldProperty(Description = "Trust Acct Trans Descr")]
        public string Description { get => _description; set => SetField(ref _description, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// TrustAccountItem Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _notes;
        /// <summary>
        /// Trust Acct Trans Descr Notes [TANNNO]
        /// </summary>
        [LoanFieldProperty(Description = "Trust Acct Trans Descr Notes")]
        public string Notes { get => _notes; set => SetField(ref _notes, value); }
        private DirtyValue<decimal?> _paymentAmount;
        /// <summary>
        /// Trust Acct Trans Descr Pymt Amt [TANNPA]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trust Acct Trans Descr Pymt Amt")]
        public decimal? PaymentAmount { get => _paymentAmount; set => SetField(ref _paymentAmount, value); }
        private DirtyValue<string> _paymentCheckNo;
        /// <summary>
        /// Trust Acct Trans Descr Pymt Check [TANNPC]
        /// </summary>
        [LoanFieldProperty(Description = "Trust Acct Trans Descr Pymt Check")]
        public string PaymentCheckNo { get => _paymentCheckNo; set => SetField(ref _paymentCheckNo, value); }
        private DirtyValue<decimal?> _receiptAmount;
        /// <summary>
        /// Trust Acct Trans Descr Receipt Amt [TANNRA]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trust Acct Trans Descr Receipt Amt")]
        public decimal? ReceiptAmount { get => _receiptAmount; set => SetField(ref _receiptAmount, value); }
        private DirtyValue<string> _receiptCheckNo;
        /// <summary>
        /// Trust Acct Trans Descr Receipt Check [TANNRC]
        /// </summary>
        [LoanFieldProperty(Description = "Trust Acct Trans Descr Receipt Check")]
        public string ReceiptCheckNo { get => _receiptCheckNo; set => SetField(ref _receiptCheckNo, value); }
        private DirtyValue<int?> _trustAccountItemIndex;
        /// <summary>
        /// TrustAccountItem TrustAccountItemIndex
        /// </summary>
        public int? TrustAccountItemIndex { get => _trustAccountItemIndex; set => SetField(ref _trustAccountItemIndex, value); }
    }
}