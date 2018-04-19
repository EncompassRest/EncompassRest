using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// OtherTransaction
    /// </summary>
    public sealed partial class OtherTransaction : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _accountNumber;
        /// <summary>
        /// OtherTransaction AccountNumber
        /// </summary>
        public string AccountNumber { get => _accountNumber; set => _accountNumber = value; }
        private DirtyValue<string> _comments;
        /// <summary>
        /// OtherTransaction Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _createdById;
        /// <summary>
        /// OtherTransaction CreatedById
        /// </summary>
        public string CreatedById { get => _createdById; set => _createdById = value; }
        private DirtyValue<string> _createdByName;
        /// <summary>
        /// OtherTransaction CreatedByName
        /// </summary>
        public string CreatedByName { get => _createdByName; set => _createdByName = value; }
        private DirtyValue<DateTime?> _createdDateTimeUtc;
        /// <summary>
        /// OtherTransaction CreatedDateTimeUtc
        /// </summary>
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => _createdDateTimeUtc = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// OtherTransaction Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// OtherTransaction Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _institutionName;
        /// <summary>
        /// OtherTransaction InstitutionName
        /// </summary>
        public string InstitutionName { get => _institutionName; set => _institutionName = value; }
        private DirtyValue<string> _institutionRouting;
        /// <summary>
        /// OtherTransaction InstitutionRouting
        /// </summary>
        public string InstitutionRouting { get => _institutionRouting; set => _institutionRouting = value; }
        private DirtyValue<string> _modifiedById;
        /// <summary>
        /// OtherTransaction ModifiedById
        /// </summary>
        public string ModifiedById { get => _modifiedById; set => _modifiedById = value; }
        private DirtyValue<string> _modifiedByName;
        /// <summary>
        /// OtherTransaction ModifiedByName
        /// </summary>
        public string ModifiedByName { get => _modifiedByName; set => _modifiedByName = value; }
        private DirtyValue<DateTime?> _modifiedDateTimeUtc;
        /// <summary>
        /// OtherTransaction ModifiedDateTimeUtc
        /// </summary>
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => _modifiedDateTimeUtc = value; }
        private DirtyValue<string> _reference;
        /// <summary>
        /// OtherTransaction Reference
        /// </summary>
        public string Reference { get => _reference; set => _reference = value; }
        private DirtyValue<string> _servicingPaymentMethod;
        /// <summary>
        /// OtherTransaction ServicingPaymentMethod
        /// </summary>
        public string ServicingPaymentMethod { get => _servicingPaymentMethod; set => _servicingPaymentMethod = value; }
        private DirtyValue<string> _servicingTransactionType;
        /// <summary>
        /// OtherTransaction ServicingTransactionType
        /// </summary>
        public string ServicingTransactionType { get => _servicingTransactionType; set => _servicingTransactionType = value; }
        private DirtyValue<decimal?> _transactionAmount;
        /// <summary>
        /// OtherTransaction TransactionAmount
        /// </summary>
        public decimal? TransactionAmount { get => _transactionAmount; set => _transactionAmount = value; }
        private DirtyValue<DateTime?> _transactionDate;
        /// <summary>
        /// OtherTransaction TransactionDate
        /// </summary>
        public DateTime? TransactionDate { get => _transactionDate; set => _transactionDate = value; }
        internal override bool DirtyInternal
        {
            get => _accountNumber.Dirty
                || _comments.Dirty
                || _createdById.Dirty
                || _createdByName.Dirty
                || _createdDateTimeUtc.Dirty
                || _guid.Dirty
                || _id.Dirty
                || _institutionName.Dirty
                || _institutionRouting.Dirty
                || _modifiedById.Dirty
                || _modifiedByName.Dirty
                || _modifiedDateTimeUtc.Dirty
                || _reference.Dirty
                || _servicingPaymentMethod.Dirty
                || _servicingTransactionType.Dirty
                || _transactionAmount.Dirty
                || _transactionDate.Dirty;
            set
            {
                _accountNumber.Dirty = value;
                _comments.Dirty = value;
                _createdById.Dirty = value;
                _createdByName.Dirty = value;
                _createdDateTimeUtc.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _institutionName.Dirty = value;
                _institutionRouting.Dirty = value;
                _modifiedById.Dirty = value;
                _modifiedByName.Dirty = value;
                _modifiedDateTimeUtc.Dirty = value;
                _reference.Dirty = value;
                _servicingPaymentMethod.Dirty = value;
                _servicingTransactionType.Dirty = value;
                _transactionAmount.Dirty = value;
                _transactionDate.Dirty = value;
            }
        }
    }
}