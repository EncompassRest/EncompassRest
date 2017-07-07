using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010FwbcFwsc : IClean
    {
        private Value<string> _fwbc;
        public string Fwbc { get { return _fwbc; } set { _fwbc = value; } }
        private Value<string> _fwsc;
        public string Fwsc { get { return _fwsc; } set { _fwsc = value; } }
        private Value<int?> _gfe2010FwbcFwscIndex;
        public int? Gfe2010FwbcFwscIndex { get { return _gfe2010FwbcFwscIndex; } set { _gfe2010FwbcFwscIndex = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _lineLetter;
        public string LineLetter { get { return _lineLetter; } set { _lineLetter = value; } }
        private Value<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
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
                var fwbc = _fwbc; fwbc.Clean = value; _fwbc = fwbc;
                var fwsc = _fwsc; fwsc.Clean = value; _fwsc = fwsc;
                var gfe2010FwbcFwscIndex = _gfe2010FwbcFwscIndex; gfe2010FwbcFwscIndex.Clean = value; _gfe2010FwbcFwscIndex = gfe2010FwbcFwscIndex;
                var id = _id; id.Clean = value; _id = id;
                var lineLetter = _lineLetter; lineLetter.Clean = value; _lineLetter = lineLetter;
                var lineNumber = _lineNumber; lineNumber.Clean = value; _lineNumber = lineNumber;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Gfe2010FwbcFwsc()
        {
            Clean = true;
        }
    }
}