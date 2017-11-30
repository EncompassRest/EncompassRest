using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class TQLComplianceAlert : ExtensibleObject
    {
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _lastComplianceOrderAlertCategories;
        public string LastComplianceOrderAlertCategories { get => _lastComplianceOrderAlertCategories; set => _lastComplianceOrderAlertCategories = value; }
        private DirtyValue<string> _lastComplianceOrderAlertMessage;
        public string LastComplianceOrderAlertMessage { get => _lastComplianceOrderAlertMessage; set => _lastComplianceOrderAlertMessage = value; }
        private DirtyValue<string> _lastComplianceOrderDescriptionOfAlerts;
        public string LastComplianceOrderDescriptionOfAlerts { get => _lastComplianceOrderDescriptionOfAlerts; set => _lastComplianceOrderDescriptionOfAlerts = value; }
        private DirtyValue<int?> _tQLComplianceAlertIndex;
        public int? TQLComplianceAlertIndex { get => _tQLComplianceAlertIndex; set => _tQLComplianceAlertIndex = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _id.Dirty
                    || _lastComplianceOrderAlertCategories.Dirty
                    || _lastComplianceOrderAlertMessage.Dirty
                    || _lastComplianceOrderDescriptionOfAlerts.Dirty
                    || _tQLComplianceAlertIndex.Dirty;
            }
            set
            {
                _id.Dirty = value;
                _lastComplianceOrderAlertCategories.Dirty = value;
                _lastComplianceOrderAlertMessage.Dirty = value;
                _lastComplianceOrderDescriptionOfAlerts.Dirty = value;
                _tQLComplianceAlertIndex.Dirty = value;
            }
        }
    }
}