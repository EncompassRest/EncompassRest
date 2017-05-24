using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010FwbcFwsc
    {
        private Value<string> _fwbc;
        public string Fwbc { get { return _fwbc; } set { _fwbc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFwbc() => !_fwbc.Clean;
        private Value<string> _fwsc;
        public string Fwsc { get { return _fwsc; } set { _fwsc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFwsc() => !_fwsc.Clean;
        private Value<int?> _gfe2010FwbcFwscIndex;
        public int? Gfe2010FwbcFwscIndex { get { return _gfe2010FwbcFwscIndex; } set { _gfe2010FwbcFwscIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfe2010FwbcFwscIndex() => !_gfe2010FwbcFwscIndex.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _lineLetter;
        public string LineLetter { get { return _lineLetter; } set { _lineLetter = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineLetter() => !_lineLetter.Clean;
        private Value<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineNumber() => !_lineNumber.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _fwbc.Clean
                    && _fwsc.Clean
                    && _gfe2010FwbcFwscIndex.Clean
                    && _id.Clean
                    && _lineLetter.Clean
                    && _lineNumber.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _fwbc; v0.Clean = value; _fwbc = v0;
                var v1 = _fwsc; v1.Clean = value; _fwsc = v1;
                var v2 = _gfe2010FwbcFwscIndex; v2.Clean = value; _gfe2010FwbcFwscIndex = v2;
                var v3 = _id; v3.Clean = value; _id = v3;
                var v4 = _lineLetter; v4.Clean = value; _lineLetter = v4;
                var v5 = _lineNumber; v5.Clean = value; _lineNumber = v5;
                _settingClean = 0;
            }
        }
    }
}