using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class TQLFraudAlert
    {
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _lastFraudOrderAlertCategories;
        public string LastFraudOrderAlertCategories { get { return _lastFraudOrderAlertCategories; } set { _lastFraudOrderAlertCategories = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastFraudOrderAlertCategories() => !_lastFraudOrderAlertCategories.Clean;
        private Value<string> _lastFraudOrderAlertID;
        public string LastFraudOrderAlertID { get { return _lastFraudOrderAlertID; } set { _lastFraudOrderAlertID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastFraudOrderAlertID() => !_lastFraudOrderAlertID.Clean;
        private Value<string> _lastFraudOrderAlertLevel;
        public string LastFraudOrderAlertLevel { get { return _lastFraudOrderAlertLevel; } set { _lastFraudOrderAlertLevel = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastFraudOrderAlertLevel() => !_lastFraudOrderAlertLevel.Clean;
        private Value<string> _lastFraudOrderDescriptionOfAlerts;
        public string LastFraudOrderDescriptionOfAlerts { get { return _lastFraudOrderDescriptionOfAlerts; } set { _lastFraudOrderDescriptionOfAlerts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastFraudOrderDescriptionOfAlerts() => !_lastFraudOrderDescriptionOfAlerts.Clean;
        private Value<int?> _tQLFraudAlertIndex;
        public int? TQLFraudAlertIndex { get { return _tQLFraudAlertIndex; } set { _tQLFraudAlertIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLFraudAlertIndex() => !_tQLFraudAlertIndex.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _id.Clean
                    && _lastFraudOrderAlertCategories.Clean
                    && _lastFraudOrderAlertID.Clean
                    && _lastFraudOrderAlertLevel.Clean
                    && _lastFraudOrderDescriptionOfAlerts.Clean
                    && _tQLFraudAlertIndex.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _id; v0.Clean = value; _id = v0;
                var v1 = _lastFraudOrderAlertCategories; v1.Clean = value; _lastFraudOrderAlertCategories = v1;
                var v2 = _lastFraudOrderAlertID; v2.Clean = value; _lastFraudOrderAlertID = v2;
                var v3 = _lastFraudOrderAlertLevel; v3.Clean = value; _lastFraudOrderAlertLevel = v3;
                var v4 = _lastFraudOrderDescriptionOfAlerts; v4.Clean = value; _lastFraudOrderDescriptionOfAlerts = v4;
                var v5 = _tQLFraudAlertIndex; v5.Clean = value; _tQLFraudAlertIndex = v5;
                _settingClean = 0;
            }
        }
    }
}