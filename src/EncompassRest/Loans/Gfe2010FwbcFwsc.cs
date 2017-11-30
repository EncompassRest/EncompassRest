using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010FwbcFwsc : ExtensibleObject
    {
        private DirtyValue<string> _fwbc;
        public string Fwbc { get => _fwbc; set => _fwbc = value; }
        private DirtyValue<string> _fwsc;
        public string Fwsc { get => _fwsc; set => _fwsc = value; }
        private DirtyValue<int?> _gfe2010FwbcFwscIndex;
        public int? Gfe2010FwbcFwscIndex { get => _gfe2010FwbcFwscIndex; set => _gfe2010FwbcFwscIndex = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _lineLetter;
        public string LineLetter { get => _lineLetter; set => _lineLetter = value; }
        private DirtyValue<int?> _lineNumber;
        public int? LineNumber { get => _lineNumber; set => _lineNumber = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _fwbc.Dirty
                    || _fwsc.Dirty
                    || _gfe2010FwbcFwscIndex.Dirty
                    || _id.Dirty
                    || _lineLetter.Dirty
                    || _lineNumber.Dirty;
            }
            set
            {
                _fwbc.Dirty = value;
                _fwsc.Dirty = value;
                _gfe2010FwbcFwscIndex.Dirty = value;
                _id.Dirty = value;
                _lineLetter.Dirty = value;
                _lineNumber.Dirty = value;
            }
        }
    }
}