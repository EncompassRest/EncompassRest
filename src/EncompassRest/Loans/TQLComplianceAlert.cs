using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class TQLComplianceAlert : IDirty
    {
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _lastComplianceOrderAlertCategories;
        public string LastComplianceOrderAlertCategories { get { return _lastComplianceOrderAlertCategories; } set { _lastComplianceOrderAlertCategories = value; } }
        private DirtyValue<string> _lastComplianceOrderAlertMessage;
        public string LastComplianceOrderAlertMessage { get { return _lastComplianceOrderAlertMessage; } set { _lastComplianceOrderAlertMessage = value; } }
        private DirtyValue<string> _lastComplianceOrderDescriptionOfAlerts;
        public string LastComplianceOrderDescriptionOfAlerts { get { return _lastComplianceOrderDescriptionOfAlerts; } set { _lastComplianceOrderDescriptionOfAlerts = value; } }
        private DirtyValue<int?> _tQLComplianceAlertIndex;
        public int? TQLComplianceAlertIndex { get { return _tQLComplianceAlertIndex; } set { _tQLComplianceAlertIndex = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _id.Dirty
                    || _lastComplianceOrderAlertCategories.Dirty
                    || _lastComplianceOrderAlertMessage.Dirty
                    || _lastComplianceOrderDescriptionOfAlerts.Dirty
                    || _tQLComplianceAlertIndex.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _id.Dirty = value;
                _lastComplianceOrderAlertCategories.Dirty = value;
                _lastComplianceOrderAlertMessage.Dirty = value;
                _lastComplianceOrderDescriptionOfAlerts.Dirty = value;
                _tQLComplianceAlertIndex.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}