using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class TQLFraudAlert
    {
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> LastFraudOrderAlertCategories { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastFraudOrderAlertCategories() => !LastFraudOrderAlertCategories.Clean;
        public Value<string> LastFraudOrderAlertID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastFraudOrderAlertID() => !LastFraudOrderAlertID.Clean;
        public Value<string> LastFraudOrderAlertLevel { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastFraudOrderAlertLevel() => !LastFraudOrderAlertLevel.Clean;
        public Value<string> LastFraudOrderDescriptionOfAlerts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastFraudOrderDescriptionOfAlerts() => !LastFraudOrderDescriptionOfAlerts.Clean;
        public Value<int?> TQLFraudAlertIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLFraudAlertIndex() => !TQLFraudAlertIndex.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Id.Clean
                    && LastFraudOrderAlertCategories.Clean
                    && LastFraudOrderAlertID.Clean
                    && LastFraudOrderAlertLevel.Clean
                    && LastFraudOrderDescriptionOfAlerts.Clean
                    && TQLFraudAlertIndex.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Id; v0.Clean = value; Id = v0;
                var v1 = LastFraudOrderAlertCategories; v1.Clean = value; LastFraudOrderAlertCategories = v1;
                var v2 = LastFraudOrderAlertID; v2.Clean = value; LastFraudOrderAlertID = v2;
                var v3 = LastFraudOrderAlertLevel; v3.Clean = value; LastFraudOrderAlertLevel = v3;
                var v4 = LastFraudOrderDescriptionOfAlerts; v4.Clean = value; LastFraudOrderDescriptionOfAlerts = v4;
                var v5 = TQLFraudAlertIndex; v5.Clean = value; TQLFraudAlertIndex = v5;
                _settingClean = 0;
            }
        }
    }
}