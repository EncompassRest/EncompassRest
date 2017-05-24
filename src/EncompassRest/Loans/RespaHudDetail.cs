using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class RespaHudDetail
    {
        public Value<string> CreditDebt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditDebt() => !CreditDebt.Clean;
        public Value<string> FWBC { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFWBC() => !FWBC.Clean;
        public Value<DateTime?> HUD1LineItemFromDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHUD1LineItemFromDate() => !HUD1LineItemFromDate.Clean;
        public Value<DateTime?> HUD1LineItemToDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHUD1LineItemToDate() => !HUD1LineItemToDate.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> LineItemAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineItemAmount() => !LineItemAmount.Clean;
        public Value<string> LineItemDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineItemDescription() => !LineItemDescription.Clean;
        public Value<int?> LineNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineNumber() => !LineNumber.Clean;
        public Value<decimal?> RealValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealValue() => !RealValue.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = CreditDebt.Clean
                    && FWBC.Clean
                    && HUD1LineItemFromDate.Clean
                    && HUD1LineItemToDate.Clean
                    && Id.Clean
                    && LineItemAmount.Clean
                    && LineItemDescription.Clean
                    && LineNumber.Clean
                    && RealValue.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = CreditDebt; v0.Clean = value; CreditDebt = v0;
                var v1 = FWBC; v1.Clean = value; FWBC = v1;
                var v2 = HUD1LineItemFromDate; v2.Clean = value; HUD1LineItemFromDate = v2;
                var v3 = HUD1LineItemToDate; v3.Clean = value; HUD1LineItemToDate = v3;
                var v4 = Id; v4.Clean = value; Id = v4;
                var v5 = LineItemAmount; v5.Clean = value; LineItemAmount = v5;
                var v6 = LineItemDescription; v6.Clean = value; LineItemDescription = v6;
                var v7 = LineNumber; v7.Clean = value; LineNumber = v7;
                var v8 = RealValue; v8.Clean = value; RealValue = v8;
                _settingClean = 0;
            }
        }
    }
}