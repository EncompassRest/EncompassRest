using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class TQLComplianceAlert : IClean
    {
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _lastComplianceOrderAlertCategories;
        public string LastComplianceOrderAlertCategories { get { return _lastComplianceOrderAlertCategories; } set { _lastComplianceOrderAlertCategories = value; } }
        private Value<string> _lastComplianceOrderAlertMessage;
        public string LastComplianceOrderAlertMessage { get { return _lastComplianceOrderAlertMessage; } set { _lastComplianceOrderAlertMessage = value; } }
        private Value<string> _lastComplianceOrderDescriptionOfAlerts;
        public string LastComplianceOrderDescriptionOfAlerts { get { return _lastComplianceOrderDescriptionOfAlerts; } set { _lastComplianceOrderDescriptionOfAlerts = value; } }
        private Value<int?> _tQLComplianceAlertIndex;
        public int? TQLComplianceAlertIndex { get { return _tQLComplianceAlertIndex; } set { _tQLComplianceAlertIndex = value; } }
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
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}