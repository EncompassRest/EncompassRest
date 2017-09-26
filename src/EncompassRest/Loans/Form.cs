using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Form : IDirty
    {
        private Value<int?> _formId;
        public int? FormId { get { return _formId; } set { _formId = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _formId.Dirty
                    || _id.Dirty
                    || _name.Dirty
                    || _systemId.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _formId.Dirty = value;
                _id.Dirty = value;
                _name.Dirty = value;
                _systemId.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}