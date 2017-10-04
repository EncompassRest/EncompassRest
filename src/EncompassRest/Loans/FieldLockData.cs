using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class FieldLockData : IDirty
    {
        private DirtyValue<bool?> _lockRemoved;
        public bool? LockRemoved { get { return _lockRemoved; } set { _lockRemoved = value; } }
        private DirtyValue<string> _modelPath;
        public string ModelPath { get { return _modelPath; } set { _modelPath = value; } }
        private DirtyValue<string> _value;
        public string Value { get { return _value; } set { _value = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _lockRemoved.Dirty
                    || _modelPath.Dirty
                    || _value.Dirty;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _lockRemoved.Dirty = value;
                _modelPath.Dirty = value;
                _value.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}