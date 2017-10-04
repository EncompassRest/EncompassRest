using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class AdditionalStateDisclosure : IDirty
    {
        private DirtyValue<string> _disclosureName;
        public string DisclosureName { get { return _disclosureName; } set { _disclosureName = value; } }
        private DirtyValue<string> _disclosureValue;
        public string DisclosureValue { get { return _disclosureValue; } set { _disclosureValue = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _stateCode;
        public string StateCode { get { return _stateCode; } set { _stateCode = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _disclosureName.Dirty
                    || _disclosureValue.Dirty
                    || _id.Dirty
                    || _stateCode.Dirty;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _disclosureName.Dirty = value;
                _disclosureValue.Dirty = value;
                _id.Dirty = value;
                _stateCode.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}