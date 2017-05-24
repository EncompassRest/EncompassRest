using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class FundingFee
    {
        public Value<bool?> BalanceChecked { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBalanceChecked() => !BalanceChecked.Clean;
        public Value<string> CdLineId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCdLineId() => !CdLineId.Clean;
        public Value<string> FeeDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDescription() => !FeeDescription.Clean;
        public Value<string> FeeDescription2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDescription2015() => !FeeDescription2015.Clean;
        public Value<string> LineId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineId() => !LineId.Clean;
        public Value<int?> LineNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineNumber() => !LineNumber.Clean;
        public Value<string> PaidBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidBy() => !PaidBy.Clean;
        public Value<string> PaidTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidTo() => !PaidTo.Clean;
        public Value<string> Payee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayee() => !Payee.Clean;
        public Value<string> PocPaidBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePocPaidBy() => !PocPaidBy.Clean;
        public Value<string> PtcPaidBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePtcPaidBy() => !PtcPaidBy.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = BalanceChecked.Clean
                    && CdLineId.Clean
                    && FeeDescription.Clean
                    && FeeDescription2015.Clean
                    && LineId.Clean
                    && LineNumber.Clean
                    && PaidBy.Clean
                    && PaidTo.Clean
                    && Payee.Clean
                    && PocPaidBy.Clean
                    && PtcPaidBy.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = BalanceChecked; v0.Clean = value; BalanceChecked = v0;
                var v1 = CdLineId; v1.Clean = value; CdLineId = v1;
                var v2 = FeeDescription; v2.Clean = value; FeeDescription = v2;
                var v3 = FeeDescription2015; v3.Clean = value; FeeDescription2015 = v3;
                var v4 = LineId; v4.Clean = value; LineId = v4;
                var v5 = LineNumber; v5.Clean = value; LineNumber = v5;
                var v6 = PaidBy; v6.Clean = value; PaidBy = v6;
                var v7 = PaidTo; v7.Clean = value; PaidTo = v7;
                var v8 = Payee; v8.Clean = value; Payee = v8;
                var v9 = PocPaidBy; v9.Clean = value; PocPaidBy = v9;
                var v10 = PtcPaidBy; v10.Clean = value; PtcPaidBy = v10;
                _settingClean = 0;
            }
        }
    }
}