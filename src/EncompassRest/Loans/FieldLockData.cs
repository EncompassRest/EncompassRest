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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _lockRemoved.Dirty
                    || _modelPath.Dirty
                    || _value.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _lockRemoved.Dirty = value;
                _modelPath.Dirty = value;
                _value.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}