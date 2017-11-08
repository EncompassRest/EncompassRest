using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Gfe2010FwbcFwsc : IDirty
    {
        private DirtyValue<string> _fwbc;
        public string Fwbc { get { return _fwbc; } set { _fwbc = value; } }
        private DirtyValue<string> _fwsc;
        public string Fwsc { get { return _fwsc; } set { _fwsc = value; } }
        private DirtyValue<int?> _gfe2010FwbcFwscIndex;
        public int? Gfe2010FwbcFwscIndex { get { return _gfe2010FwbcFwscIndex; } set { _gfe2010FwbcFwscIndex = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _lineLetter;
        public string LineLetter { get { return _lineLetter; } set { _lineLetter = value; } }
        private DirtyValue<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get { return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); } set { _extensionData = new DirtyDictionary<string, object>(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _fwbc.Dirty
                    || _fwsc.Dirty
                    || _gfe2010FwbcFwscIndex.Dirty
                    || _id.Dirty
                    || _lineLetter.Dirty
                    || _lineNumber.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _fwbc.Dirty = value;
                _fwsc.Dirty = value;
                _gfe2010FwbcFwscIndex.Dirty = value;
                _id.Dirty = value;
                _lineLetter.Dirty = value;
                _lineNumber.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}