#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class PaymentReversalTransaction : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _createdById;
        public string CreatedById { get => _createdById; set => _createdById = value; }
        private DirtyValue<string> _createdByName;
        public string CreatedByName { get => _createdByName; set => _createdByName = value; }
        private DirtyValue<DateTime?> _createdDateTimeUtc;
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => _createdDateTimeUtc = value; }
        private DirtyValue<string> _guid;
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _modifiedById;
        public string ModifiedById { get => _modifiedById; set => _modifiedById = value; }
        private DirtyValue<string> _modifiedByName;
        public string ModifiedByName { get => _modifiedByName; set => _modifiedByName = value; }
        private DirtyValue<DateTime?> _modifiedDateTimeUtc;
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => _modifiedDateTimeUtc = value; }
        private DirtyValue<string> _paymentId;
        public string PaymentId { get => _paymentId; set => _paymentId = value; }
        private DirtyValue<string> _reversalType;
        public string ReversalType { get => _reversalType; set => _reversalType = value; }
        private DirtyValue<string> _servicingPaymentMethod;
        public string ServicingPaymentMethod { get => _servicingPaymentMethod; set => _servicingPaymentMethod = value; }
        private DirtyValue<string> _servicingTransactionType;
        public string ServicingTransactionType { get => _servicingTransactionType; set => _servicingTransactionType = value; }
        private DirtyValue<decimal?> _transactionAmount;
        public decimal? TransactionAmount { get => _transactionAmount; set => _transactionAmount = value; }
        private DirtyValue<DateTime?> _transactionDate;
        public DateTime? TransactionDate { get => _transactionDate; set => _transactionDate = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _comments.Dirty
                    || _createdById.Dirty
                    || _createdByName.Dirty
                    || _createdDateTimeUtc.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _modifiedById.Dirty
                    || _modifiedByName.Dirty
                    || _modifiedDateTimeUtc.Dirty
                    || _paymentId.Dirty
                    || _reversalType.Dirty
                    || _servicingPaymentMethod.Dirty
                    || _servicingTransactionType.Dirty
                    || _transactionAmount.Dirty
                    || _transactionDate.Dirty;
            }
            set
            {
                _comments.Dirty = value;
                _createdById.Dirty = value;
                _createdByName.Dirty = value;
                _createdDateTimeUtc.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _modifiedById.Dirty = value;
                _modifiedByName.Dirty = value;
                _modifiedDateTimeUtc.Dirty = value;
                _paymentId.Dirty = value;
                _reversalType.Dirty = value;
                _servicingPaymentMethod.Dirty = value;
                _servicingTransactionType.Dirty = value;
                _transactionAmount.Dirty = value;
                _transactionDate.Dirty = value;
            }
        }
    }
}