using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class TQLComplianceAlert
    {
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> LastComplianceOrderAlertCategories { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastComplianceOrderAlertCategories() => !LastComplianceOrderAlertCategories.Clean;
        public Value<string> LastComplianceOrderAlertMessage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastComplianceOrderAlertMessage() => !LastComplianceOrderAlertMessage.Clean;
        public Value<string> LastComplianceOrderDescriptionOfAlerts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastComplianceOrderDescriptionOfAlerts() => !LastComplianceOrderDescriptionOfAlerts.Clean;
        public Value<int?> TQLComplianceAlertIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLComplianceAlertIndex() => !TQLComplianceAlertIndex.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Id.Clean
                    && LastComplianceOrderAlertCategories.Clean
                    && LastComplianceOrderAlertMessage.Clean
                    && LastComplianceOrderDescriptionOfAlerts.Clean
                    && TQLComplianceAlertIndex.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Id; v0.Clean = value; Id = v0;
                var v1 = LastComplianceOrderAlertCategories; v1.Clean = value; LastComplianceOrderAlertCategories = v1;
                var v2 = LastComplianceOrderAlertMessage; v2.Clean = value; LastComplianceOrderAlertMessage = v2;
                var v3 = LastComplianceOrderDescriptionOfAlerts; v3.Clean = value; LastComplianceOrderDescriptionOfAlerts = v3;
                var v4 = TQLComplianceAlertIndex; v4.Clean = value; TQLComplianceAlertIndex = v4;
                _settingClean = 0;
            }
        }
    }
}