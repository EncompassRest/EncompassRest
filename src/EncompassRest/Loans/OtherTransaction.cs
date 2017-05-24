using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class OtherTransaction
    {
        private Value<string> _accountNumber;
        public string AccountNumber { get { return _accountNumber; } set { _accountNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccountNumber() => !_accountNumber.Clean;
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !_comments.Clean;
        private Value<string> _createdById;
        public string CreatedById { get { return _createdById; } set { _createdById = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreatedById() => !_createdById.Clean;
        private Value<string> _createdByName;
        public string CreatedByName { get { return _createdByName; } set { _createdByName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreatedByName() => !_createdByName.Clean;
        private Value<DateTime?> _createdDateTimeUtc;
        public DateTime? CreatedDateTimeUtc { get { return _createdDateTimeUtc; } set { _createdDateTimeUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreatedDateTimeUtc() => !_createdDateTimeUtc.Clean;
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !_guid.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _institutionName;
        public string InstitutionName { get { return _institutionName; } set { _institutionName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInstitutionName() => !_institutionName.Clean;
        private Value<string> _institutionRouting;
        public string InstitutionRouting { get { return _institutionRouting; } set { _institutionRouting = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInstitutionRouting() => !_institutionRouting.Clean;
        private Value<string> _modifiedById;
        public string ModifiedById { get { return _modifiedById; } set { _modifiedById = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedById() => !_modifiedById.Clean;
        private Value<string> _modifiedByName;
        public string ModifiedByName { get { return _modifiedByName; } set { _modifiedByName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedByName() => !_modifiedByName.Clean;
        private Value<DateTime?> _modifiedDateTimeUtc;
        public DateTime? ModifiedDateTimeUtc { get { return _modifiedDateTimeUtc; } set { _modifiedDateTimeUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedDateTimeUtc() => !_modifiedDateTimeUtc.Clean;
        private Value<string> _reference;
        public string Reference { get { return _reference; } set { _reference = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReference() => !_reference.Clean;
        private Value<string> _servicingPaymentMethod;
        public string ServicingPaymentMethod { get { return _servicingPaymentMethod; } set { _servicingPaymentMethod = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingPaymentMethod() => !_servicingPaymentMethod.Clean;
        private Value<string> _servicingTransactionType;
        public string ServicingTransactionType { get { return _servicingTransactionType; } set { _servicingTransactionType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingTransactionType() => !_servicingTransactionType.Clean;
        private Value<decimal?> _transactionAmount;
        public decimal? TransactionAmount { get { return _transactionAmount; } set { _transactionAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransactionAmount() => !_transactionAmount.Clean;
        private Value<DateTime?> _transactionDate;
        public DateTime? TransactionDate { get { return _transactionDate; } set { _transactionDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransactionDate() => !_transactionDate.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _accountNumber.Clean
                    && _comments.Clean
                    && _createdById.Clean
                    && _createdByName.Clean
                    && _createdDateTimeUtc.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _institutionName.Clean
                    && _institutionRouting.Clean
                    && _modifiedById.Clean
                    && _modifiedByName.Clean
                    && _modifiedDateTimeUtc.Clean
                    && _reference.Clean
                    && _servicingPaymentMethod.Clean
                    && _servicingTransactionType.Clean
                    && _transactionAmount.Clean
                    && _transactionDate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _accountNumber; v0.Clean = value; _accountNumber = v0;
                var v1 = _comments; v1.Clean = value; _comments = v1;
                var v2 = _createdById; v2.Clean = value; _createdById = v2;
                var v3 = _createdByName; v3.Clean = value; _createdByName = v3;
                var v4 = _createdDateTimeUtc; v4.Clean = value; _createdDateTimeUtc = v4;
                var v5 = _guid; v5.Clean = value; _guid = v5;
                var v6 = _id; v6.Clean = value; _id = v6;
                var v7 = _institutionName; v7.Clean = value; _institutionName = v7;
                var v8 = _institutionRouting; v8.Clean = value; _institutionRouting = v8;
                var v9 = _modifiedById; v9.Clean = value; _modifiedById = v9;
                var v10 = _modifiedByName; v10.Clean = value; _modifiedByName = v10;
                var v11 = _modifiedDateTimeUtc; v11.Clean = value; _modifiedDateTimeUtc = v11;
                var v12 = _reference; v12.Clean = value; _reference = v12;
                var v13 = _servicingPaymentMethod; v13.Clean = value; _servicingPaymentMethod = v13;
                var v14 = _servicingTransactionType; v14.Clean = value; _servicingTransactionType = v14;
                var v15 = _transactionAmount; v15.Clean = value; _transactionAmount = v15;
                var v16 = _transactionDate; v16.Clean = value; _transactionDate = v16;
                _settingClean = 0;
            }
        }
    }
}