using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class EscrowDisbursementTransaction : IDirty
    {
        private DirtyValue<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private DirtyValue<string> _createdById;
        public string CreatedById { get { return _createdById; } set { _createdById = value; } }
        private DirtyValue<string> _createdByName;
        public string CreatedByName { get { return _createdByName; } set { _createdByName = value; } }
        private DirtyValue<DateTime?> _createdDateTimeUtc;
        public DateTime? CreatedDateTimeUtc { get { return _createdDateTimeUtc; } set { _createdDateTimeUtc = value; } }
        private DirtyValue<DateTime?> _disbursementDueDate;
        public DateTime? DisbursementDueDate { get { return _disbursementDueDate; } set { _disbursementDueDate = value; } }
        private DirtyValue<int?> _disbursementNumber;
        public int? DisbursementNumber { get { return _disbursementNumber; } set { _disbursementNumber = value; } }
        private DirtyValue<string> _disbursementType;
        public string DisbursementType { get { return _disbursementType; } set { _disbursementType = value; } }
        private DirtyValue<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _institutionName;
        public string InstitutionName { get { return _institutionName; } set { _institutionName = value; } }
        private DirtyValue<string> _modifiedById;
        public string ModifiedById { get { return _modifiedById; } set { _modifiedById = value; } }
        private DirtyValue<string> _modifiedByName;
        public string ModifiedByName { get { return _modifiedByName; } set { _modifiedByName = value; } }
        private DirtyValue<DateTime?> _modifiedDateTimeUtc;
        public DateTime? ModifiedDateTimeUtc { get { return _modifiedDateTimeUtc; } set { _modifiedDateTimeUtc = value; } }
        private DirtyValue<string> _servicingPaymentMethod;
        public string ServicingPaymentMethod { get { return _servicingPaymentMethod; } set { _servicingPaymentMethod = value; } }
        private DirtyValue<string> _servicingTransactionType;
        public string ServicingTransactionType { get { return _servicingTransactionType; } set { _servicingTransactionType = value; } }
        private DirtyValue<decimal?> _transactionAmount;
        public decimal? TransactionAmount { get { return _transactionAmount; } set { _transactionAmount = value; } }
        private DirtyValue<DateTime?> _transactionDate;
        public DateTime? TransactionDate { get { return _transactionDate; } set { _transactionDate = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _comments.Dirty
                    || _createdById.Dirty
                    || _createdByName.Dirty
                    || _createdDateTimeUtc.Dirty
                    || _disbursementDueDate.Dirty
                    || _disbursementNumber.Dirty
                    || _disbursementType.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _institutionName.Dirty
                    || _modifiedById.Dirty
                    || _modifiedByName.Dirty
                    || _modifiedDateTimeUtc.Dirty
                    || _servicingPaymentMethod.Dirty
                    || _servicingTransactionType.Dirty
                    || _transactionAmount.Dirty
                    || _transactionDate.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _comments.Dirty = value;
                _createdById.Dirty = value;
                _createdByName.Dirty = value;
                _createdDateTimeUtc.Dirty = value;
                _disbursementDueDate.Dirty = value;
                _disbursementNumber.Dirty = value;
                _disbursementType.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _institutionName.Dirty = value;
                _modifiedById.Dirty = value;
                _modifiedByName.Dirty = value;
                _modifiedDateTimeUtc.Dirty = value;
                _servicingPaymentMethod.Dirty = value;
                _servicingTransactionType.Dirty = value;
                _transactionAmount.Dirty = value;
                _transactionDate.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}