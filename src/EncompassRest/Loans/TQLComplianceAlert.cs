using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var id = _id; id.Clean = value; _id = id;
                var lastComplianceOrderAlertCategories = _lastComplianceOrderAlertCategories; lastComplianceOrderAlertCategories.Clean = value; _lastComplianceOrderAlertCategories = lastComplianceOrderAlertCategories;
                var lastComplianceOrderAlertMessage = _lastComplianceOrderAlertMessage; lastComplianceOrderAlertMessage.Clean = value; _lastComplianceOrderAlertMessage = lastComplianceOrderAlertMessage;
                var lastComplianceOrderDescriptionOfAlerts = _lastComplianceOrderDescriptionOfAlerts; lastComplianceOrderDescriptionOfAlerts.Clean = value; _lastComplianceOrderDescriptionOfAlerts = lastComplianceOrderDescriptionOfAlerts;
                var tQLComplianceAlertIndex = _tQLComplianceAlertIndex; tQLComplianceAlertIndex.Clean = value; _tQLComplianceAlertIndex = tQLComplianceAlertIndex;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public TQLComplianceAlert()
        {
            Clean = true;
        }
    }
}