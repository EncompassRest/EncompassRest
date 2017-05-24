using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class DownPayment
    {
        public Value<decimal?> Amount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmount() => !Amount.Clean;
        public Value<string> DownPaymentType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownPaymentType() => !DownPaymentType.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> SourceDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSourceDescription() => !SourceDescription.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Amount.Clean
                    && DownPaymentType.Clean
                    && Id.Clean
                    && SourceDescription.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Amount; v0.Clean = value; Amount = v0;
                var v1 = DownPaymentType; v1.Clean = value; DownPaymentType = v1;
                var v2 = Id; v2.Clean = value; Id = v2;
                var v3 = SourceDescription; v3.Clean = value; SourceDescription = v3;
                _settingClean = 0;
            }
        }
    }
}