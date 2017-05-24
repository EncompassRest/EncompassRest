using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class EscrowDisbursementTransaction
    {
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<string> CreatedById { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreatedById() => !CreatedById.Clean;
        public Value<string> CreatedByName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreatedByName() => !CreatedByName.Clean;
        public Value<DateTime?> CreatedDateTimeUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreatedDateTimeUtc() => !CreatedDateTimeUtc.Clean;
        public Value<DateTime?> DisbursementDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisbursementDueDate() => !DisbursementDueDate.Clean;
        public Value<int?> DisbursementNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisbursementNumber() => !DisbursementNumber.Clean;
        public Value<string> DisbursementType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisbursementType() => !DisbursementType.Clean;
        public Value<string> Guid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !Guid.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> InstitutionName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInstitutionName() => !InstitutionName.Clean;
        public Value<string> ModifiedById { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedById() => !ModifiedById.Clean;
        public Value<string> ModifiedByName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedByName() => !ModifiedByName.Clean;
        public Value<DateTime?> ModifiedDateTimeUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedDateTimeUtc() => !ModifiedDateTimeUtc.Clean;
        public Value<string> ServicingPaymentMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingPaymentMethod() => !ServicingPaymentMethod.Clean;
        public Value<string> ServicingTransactionType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingTransactionType() => !ServicingTransactionType.Clean;
        public Value<decimal?> TransactionAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransactionAmount() => !TransactionAmount.Clean;
        public Value<DateTime?> TransactionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransactionDate() => !TransactionDate.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Comments.Clean
                    && CreatedById.Clean
                    && CreatedByName.Clean
                    && CreatedDateTimeUtc.Clean
                    && DisbursementDueDate.Clean
                    && DisbursementNumber.Clean
                    && DisbursementType.Clean
                    && Guid.Clean
                    && Id.Clean
                    && InstitutionName.Clean
                    && ModifiedById.Clean
                    && ModifiedByName.Clean
                    && ModifiedDateTimeUtc.Clean
                    && ServicingPaymentMethod.Clean
                    && ServicingTransactionType.Clean
                    && TransactionAmount.Clean
                    && TransactionDate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Comments; v0.Clean = value; Comments = v0;
                var v1 = CreatedById; v1.Clean = value; CreatedById = v1;
                var v2 = CreatedByName; v2.Clean = value; CreatedByName = v2;
                var v3 = CreatedDateTimeUtc; v3.Clean = value; CreatedDateTimeUtc = v3;
                var v4 = DisbursementDueDate; v4.Clean = value; DisbursementDueDate = v4;
                var v5 = DisbursementNumber; v5.Clean = value; DisbursementNumber = v5;
                var v6 = DisbursementType; v6.Clean = value; DisbursementType = v6;
                var v7 = Guid; v7.Clean = value; Guid = v7;
                var v8 = Id; v8.Clean = value; Id = v8;
                var v9 = InstitutionName; v9.Clean = value; InstitutionName = v9;
                var v10 = ModifiedById; v10.Clean = value; ModifiedById = v10;
                var v11 = ModifiedByName; v11.Clean = value; ModifiedByName = v11;
                var v12 = ModifiedDateTimeUtc; v12.Clean = value; ModifiedDateTimeUtc = v12;
                var v13 = ServicingPaymentMethod; v13.Clean = value; ServicingPaymentMethod = v13;
                var v14 = ServicingTransactionType; v14.Clean = value; ServicingTransactionType = v14;
                var v15 = TransactionAmount; v15.Clean = value; TransactionAmount = v15;
                var v16 = TransactionDate; v16.Clean = value; TransactionDate = v16;
                _settingClean = 0;
            }
        }
    }
}