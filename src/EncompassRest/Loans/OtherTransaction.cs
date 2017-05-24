using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class OtherTransaction
    {
        public Value<string> AccountNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccountNumber() => !AccountNumber.Clean;
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
        public Value<string> InstitutionName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInstitutionName() => !InstitutionName.Clean;
        public Value<string> InstitutionRouting { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInstitutionRouting() => !InstitutionRouting.Clean;
        public Value<string> ModifiedById { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedById() => !ModifiedById.Clean;
        public Value<string> ModifiedByName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedByName() => !ModifiedByName.Clean;
        public Value<DateTime?> ModifiedDateTimeUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedDateTimeUtc() => !ModifiedDateTimeUtc.Clean;
        public Value<string> Reference { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReference() => !Reference.Clean;
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
                var clean = AccountNumber.Clean
                    && Comments.Clean
                    && CreatedById.Clean
                    && CreatedByName.Clean
                    && CreatedDateTimeUtc.Clean
                    && Guid.Clean
                    && Id.Clean
                    && InstitutionName.Clean
                    && InstitutionRouting.Clean
                    && ModifiedById.Clean
                    && ModifiedByName.Clean
                    && ModifiedDateTimeUtc.Clean
                    && Reference.Clean
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
                var v0 = AccountNumber; v0.Clean = value; AccountNumber = v0;
                var v1 = Comments; v1.Clean = value; Comments = v1;
                var v2 = CreatedById; v2.Clean = value; CreatedById = v2;
                var v3 = CreatedByName; v3.Clean = value; CreatedByName = v3;
                var v4 = CreatedDateTimeUtc; v4.Clean = value; CreatedDateTimeUtc = v4;
                var v5 = Guid; v5.Clean = value; Guid = v5;
                var v6 = Id; v6.Clean = value; Id = v6;
                var v7 = InstitutionName; v7.Clean = value; InstitutionName = v7;
                var v8 = InstitutionRouting; v8.Clean = value; InstitutionRouting = v8;
                var v9 = ModifiedById; v9.Clean = value; ModifiedById = v9;
                var v10 = ModifiedByName; v10.Clean = value; ModifiedByName = v10;
                var v11 = ModifiedDateTimeUtc; v11.Clean = value; ModifiedDateTimeUtc = v11;
                var v12 = Reference; v12.Clean = value; Reference = v12;
                var v13 = ServicingPaymentMethod; v13.Clean = value; ServicingPaymentMethod = v13;
                var v14 = ServicingTransactionType; v14.Clean = value; ServicingTransactionType = v14;
                var v15 = TransactionAmount; v15.Clean = value; TransactionAmount = v15;
                var v16 = TransactionDate; v16.Clean = value; TransactionDate = v16;
                _settingClean = 0;
            }
        }
    }
}