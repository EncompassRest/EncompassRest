#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class ComplianceTestLog : ExtensibleObject
    {
        private DirtyValue<string> _details;
        public string Details { get => _details; set => _details = value; }
        private DirtyValue<string> _name;
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<string> _result;
        public string Result { get => _result; set => _result = value; }
        private DirtyValue<bool?> _showAlert;
        public bool? ShowAlert { get => _showAlert; set => _showAlert = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _details.Dirty
                    || _name.Dirty
                    || _result.Dirty
                    || _showAlert.Dirty;
            }
            set
            {
                _details.Dirty = value;
                _name.Dirty = value;
                _result.Dirty = value;
                _showAlert.Dirty = value;
            }
        }
    }
}