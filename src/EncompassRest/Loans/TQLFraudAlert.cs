using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class TQLFraudAlert : IClean
    {
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _lastFraudOrderAlertCategories;
        public string LastFraudOrderAlertCategories { get { return _lastFraudOrderAlertCategories; } set { _lastFraudOrderAlertCategories = value; } }
        private Value<string> _lastFraudOrderAlertID;
        public string LastFraudOrderAlertID { get { return _lastFraudOrderAlertID; } set { _lastFraudOrderAlertID = value; } }
        private Value<string> _lastFraudOrderAlertLevel;
        public string LastFraudOrderAlertLevel { get { return _lastFraudOrderAlertLevel; } set { _lastFraudOrderAlertLevel = value; } }
        private Value<string> _lastFraudOrderDescriptionOfAlerts;
        public string LastFraudOrderDescriptionOfAlerts { get { return _lastFraudOrderDescriptionOfAlerts; } set { _lastFraudOrderDescriptionOfAlerts = value; } }
        private Value<int?> _tQLFraudAlertIndex;
        public int? TQLFraudAlertIndex { get { return _tQLFraudAlertIndex; } set { _tQLFraudAlertIndex = value; } }
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
                var id = _id; id.Clean = value; _id = id;
                var lastFraudOrderAlertCategories = _lastFraudOrderAlertCategories; lastFraudOrderAlertCategories.Clean = value; _lastFraudOrderAlertCategories = lastFraudOrderAlertCategories;
                var lastFraudOrderAlertID = _lastFraudOrderAlertID; lastFraudOrderAlertID.Clean = value; _lastFraudOrderAlertID = lastFraudOrderAlertID;
                var lastFraudOrderAlertLevel = _lastFraudOrderAlertLevel; lastFraudOrderAlertLevel.Clean = value; _lastFraudOrderAlertLevel = lastFraudOrderAlertLevel;
                var lastFraudOrderDescriptionOfAlerts = _lastFraudOrderDescriptionOfAlerts; lastFraudOrderDescriptionOfAlerts.Clean = value; _lastFraudOrderDescriptionOfAlerts = lastFraudOrderDescriptionOfAlerts;
                var tQLFraudAlertIndex = _tQLFraudAlertIndex; tQLFraudAlertIndex.Clean = value; _tQLFraudAlertIndex = tQLFraudAlertIndex;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public TQLFraudAlert()
        {
            Clean = true;
        }
    }
}