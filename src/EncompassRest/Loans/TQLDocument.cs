using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class TQLDocument
    {
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<DateTime?> _tQLDocumentDeliveredDate;
        public DateTime? TQLDocumentDeliveredDate { get { return _tQLDocumentDeliveredDate; } set { _tQLDocumentDeliveredDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLDocumentDeliveredDate() => !_tQLDocumentDeliveredDate.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _id.Clean
                    && _tQLDocumentDeliveredDate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _id; v0.Clean = value; _id = v0;
                var v1 = _tQLDocumentDeliveredDate; v1.Clean = value; _tQLDocumentDeliveredDate = v1;
                _settingClean = 0;
            }
        }
    }
}