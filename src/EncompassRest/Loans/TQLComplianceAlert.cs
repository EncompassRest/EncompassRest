using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class TQLComplianceAlert
    {
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _lastComplianceOrderAlertCategories;
        public string LastComplianceOrderAlertCategories { get { return _lastComplianceOrderAlertCategories; } set { _lastComplianceOrderAlertCategories = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastComplianceOrderAlertCategories() => !_lastComplianceOrderAlertCategories.Clean;
        private Value<string> _lastComplianceOrderAlertMessage;
        public string LastComplianceOrderAlertMessage { get { return _lastComplianceOrderAlertMessage; } set { _lastComplianceOrderAlertMessage = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastComplianceOrderAlertMessage() => !_lastComplianceOrderAlertMessage.Clean;
        private Value<string> _lastComplianceOrderDescriptionOfAlerts;
        public string LastComplianceOrderDescriptionOfAlerts { get { return _lastComplianceOrderDescriptionOfAlerts; } set { _lastComplianceOrderDescriptionOfAlerts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastComplianceOrderDescriptionOfAlerts() => !_lastComplianceOrderDescriptionOfAlerts.Clean;
        private Value<int?> _tQLComplianceAlertIndex;
        public int? TQLComplianceAlertIndex { get { return _tQLComplianceAlertIndex; } set { _tQLComplianceAlertIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLComplianceAlertIndex() => !_tQLComplianceAlertIndex.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _id.Clean
                    && _lastComplianceOrderAlertCategories.Clean
                    && _lastComplianceOrderAlertMessage.Clean
                    && _lastComplianceOrderDescriptionOfAlerts.Clean
                    && _tQLComplianceAlertIndex.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _id; v0.Clean = value; _id = v0;
                var v1 = _lastComplianceOrderAlertCategories; v1.Clean = value; _lastComplianceOrderAlertCategories = v1;
                var v2 = _lastComplianceOrderAlertMessage; v2.Clean = value; _lastComplianceOrderAlertMessage = v2;
                var v3 = _lastComplianceOrderDescriptionOfAlerts; v3.Clean = value; _lastComplianceOrderDescriptionOfAlerts = v3;
                var v4 = _tQLComplianceAlertIndex; v4.Clean = value; _tQLComplianceAlertIndex = v4;
                _settingClean = 0;
            }
        }
    }
}