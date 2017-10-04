using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LogSnapshotField : IDirty
    {
        private DirtyValue<string> _fieldID;
        public string FieldID { get { return _fieldID; } set { _fieldID = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _modalPath;
        public string ModalPath { get { return _modalPath; } set { _modalPath = value; } }
        private DirtyValue<string> _value;
        public string Value { get { return _value; } set { _value = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _fieldID.Dirty
                    || _id.Dirty
                    || _modalPath.Dirty
                    || _value.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _fieldID.Dirty = value;
                _id.Dirty = value;
                _modalPath.Dirty = value;
                _value.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}