using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Gfe2010FwbcFwsc
    /// </summary>
    public sealed partial class Gfe2010FwbcFwsc : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _fwbc;
        /// <summary>
        /// Gfe2010FwbcFwsc Fwbc
        /// </summary>
        public string Fwbc { get => _fwbc; set => _fwbc = value; }
        private DirtyValue<string> _fwsc;
        /// <summary>
        /// Gfe2010FwbcFwsc Fwsc
        /// </summary>
        public string Fwsc { get => _fwsc; set => _fwsc = value; }
        private DirtyValue<int?> _gfe2010FwbcFwscIndex;
        /// <summary>
        /// Gfe2010FwbcFwsc Gfe2010FwbcFwscIndex
        /// </summary>
        public int? Gfe2010FwbcFwscIndex { get => _gfe2010FwbcFwscIndex; set => _gfe2010FwbcFwscIndex = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Gfe2010FwbcFwsc Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _lineLetter;
        /// <summary>
        /// Gfe2010FwbcFwsc LineLetter
        /// </summary>
        public string LineLetter { get => _lineLetter; set => _lineLetter = value; }
        private DirtyValue<int?> _lineNumber;
        /// <summary>
        /// Gfe2010FwbcFwsc LineNumber
        /// </summary>
        public int? LineNumber { get => _lineNumber; set => _lineNumber = value; }
        internal override bool DirtyInternal
        {
            get => _fwbc.Dirty
                || _fwsc.Dirty
                || _gfe2010FwbcFwscIndex.Dirty
                || _id.Dirty
                || _lineLetter.Dirty
                || _lineNumber.Dirty;
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