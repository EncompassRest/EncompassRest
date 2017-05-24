using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PrincipalDisbursementTransaction
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
        public Value<DateTime?> DisbursementDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisbursementDate() => !DisbursementDate.Clean;
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
                    && DisbursementDate.Clean
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
                var v4 = DisbursementDate; v4.Clean = value; DisbursementDate = v4;
                var v5 = Guid; v5.Clean = value; Guid = v5;
                var v6 = Id; v6.Clean = value; Id = v6;
                var v7 = InstitutionName; v7.Clean = value; InstitutionName = v7;
                var v8 = ModifiedById; v8.Clean = value; ModifiedById = v8;
                var v9 = ModifiedByName; v9.Clean = value; ModifiedByName = v9;
                var v10 = ModifiedDateTimeUtc; v10.Clean = value; ModifiedDateTimeUtc = v10;
                var v11 = ServicingPaymentMethod; v11.Clean = value; ServicingPaymentMethod = v11;
                var v12 = ServicingTransactionType; v12.Clean = value; ServicingTransactionType = v12;
                var v13 = TransactionAmount; v13.Clean = value; TransactionAmount = v13;
                var v14 = TransactionDate; v14.Clean = value; TransactionDate = v14;
                _settingClean = 0;
            }
        }
    }
}