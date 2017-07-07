using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class InterimServicingTransaction : IClean
    {
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<string> _createdById;
        public string CreatedById { get { return _createdById; } set { _createdById = value; } }
        private Value<string> _createdByName;
        public string CreatedByName { get { return _createdByName; } set { _createdByName = value; } }
        private Value<DateTime?> _createdDateTimeUtc;
        public DateTime? CreatedDateTimeUtc { get { return _createdDateTimeUtc; } set { _createdDateTimeUtc = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _modifiedById;
        public string ModifiedById { get { return _modifiedById; } set { _modifiedById = value; } }
        private Value<string> _modifiedByName;
        public string ModifiedByName { get { return _modifiedByName; } set { _modifiedByName = value; } }
        private Value<DateTime?> _modifiedDateTimeUtc;
        public DateTime? ModifiedDateTimeUtc { get { return _modifiedDateTimeUtc; } set { _modifiedDateTimeUtc = value; } }
        private Value<string> _servicingPaymentMethod;
        public string ServicingPaymentMethod { get { return _servicingPaymentMethod; } set { _servicingPaymentMethod = value; } }
        private Value<string> _servicingTransactionType;
        public string ServicingTransactionType { get { return _servicingTransactionType; } set { _servicingTransactionType = value; } }
        private Value<decimal?> _transactionAmount;
        public decimal? TransactionAmount { get { return _transactionAmount; } set { _transactionAmount = value; } }
        private Value<DateTime?> _transactionDate;
        public DateTime? TransactionDate { get { return _transactionDate; } set { _transactionDate = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _comments.Clean
                    && _createdById.Clean
                    && _createdByName.Clean
                    && _createdDateTimeUtc.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _modifiedById.Clean
                    && _modifiedByName.Clean
                    && _modifiedDateTimeUtc.Clean
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
                var comments = _comments; comments.Clean = value; _comments = comments;
                var createdById = _createdById; createdById.Clean = value; _createdById = createdById;
                var createdByName = _createdByName; createdByName.Clean = value; _createdByName = createdByName;
                var createdDateTimeUtc = _createdDateTimeUtc; createdDateTimeUtc.Clean = value; _createdDateTimeUtc = createdDateTimeUtc;
                var guid = _guid; guid.Clean = value; _guid = guid;
                var id = _id; id.Clean = value; _id = id;
                var modifiedById = _modifiedById; modifiedById.Clean = value; _modifiedById = modifiedById;
                var modifiedByName = _modifiedByName; modifiedByName.Clean = value; _modifiedByName = modifiedByName;
                var modifiedDateTimeUtc = _modifiedDateTimeUtc; modifiedDateTimeUtc.Clean = value; _modifiedDateTimeUtc = modifiedDateTimeUtc;
                var servicingPaymentMethod = _servicingPaymentMethod; servicingPaymentMethod.Clean = value; _servicingPaymentMethod = servicingPaymentMethod;
                var servicingTransactionType = _servicingTransactionType; servicingTransactionType.Clean = value; _servicingTransactionType = servicingTransactionType;
                var transactionAmount = _transactionAmount; transactionAmount.Clean = value; _transactionAmount = transactionAmount;
                var transactionDate = _transactionDate; transactionDate.Clean = value; _transactionDate = transactionDate;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public InterimServicingTransaction()
        {
            Clean = true;
        }
    }
}