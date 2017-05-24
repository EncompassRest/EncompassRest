using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class TQLDocument
    {
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<DateTime?> TQLDocumentDeliveredDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLDocumentDeliveredDate() => !TQLDocumentDeliveredDate.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Id.Clean
                    && TQLDocumentDeliveredDate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Id; v0.Clean = value; Id = v0;
                var v1 = TQLDocumentDeliveredDate; v1.Clean = value; TQLDocumentDeliveredDate = v1;
                _settingClean = 0;
            }
        }
    }
}