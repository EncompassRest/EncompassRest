using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ComplianceTestLog : IDirty
    {
        private DirtyValue<string> _details;
        public string Details { get { return _details; } set { _details = value; } }
        private DirtyValue<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        private DirtyValue<string> _result;
        public string Result { get { return _result; } set { _result = value; } }
        private DirtyValue<bool?> _showAlert;
        public bool? ShowAlert { get { return _showAlert; } set { _showAlert = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _details.Dirty
                    || _name.Dirty
                    || _result.Dirty
                    || _showAlert.Dirty;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _details.Dirty = value;
                _name.Dirty = value;
                _result.Dirty = value;
                _showAlert.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}