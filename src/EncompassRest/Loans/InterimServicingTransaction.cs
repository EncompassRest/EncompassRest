using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class InterimServicingTransaction
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
        public Value<string> Guid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !Guid.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
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
                    && Guid.Clean
                    && Id.Clean
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
                var v4 = Guid; v4.Clean = value; Guid = v4;
                var v5 = Id; v5.Clean = value; Id = v5;
                var v6 = ModifiedById; v6.Clean = value; ModifiedById = v6;
                var v7 = ModifiedByName; v7.Clean = value; ModifiedByName = v7;
                var v8 = ModifiedDateTimeUtc; v8.Clean = value; ModifiedDateTimeUtc = v8;
                var v9 = ServicingPaymentMethod; v9.Clean = value; ServicingPaymentMethod = v9;
                var v10 = ServicingTransactionType; v10.Clean = value; ServicingTransactionType = v10;
                var v11 = TransactionAmount; v11.Clean = value; TransactionAmount = v11;
                var v12 = TransactionDate; v12.Clean = value; TransactionDate = v12;
                _settingClean = 0;
            }
        }
    }
}