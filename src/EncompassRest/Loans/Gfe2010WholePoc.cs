#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010WholePoc : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _gfe2010WholePocIndex;
        public int? Gfe2010WholePocIndex { get => _gfe2010WholePocIndex; set => _gfe2010WholePocIndex = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<int?> _lineNumber;
        public int? LineNumber { get => _lineNumber; set => _lineNumber = value; }
        private DirtyValue<decimal?> _wholePoc;
        public decimal? WholePoc { get => _wholePoc; set => _wholePoc = value; }
        private DirtyValue<StringEnumValue<WholePocPaidByType>> _wholePocPaidByType;
        public StringEnumValue<WholePocPaidByType> WholePocPaidByType { get => _wholePocPaidByType; set => _wholePocPaidByType = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _gfe2010WholePocIndex.Dirty
                    || _id.Dirty
                    || _lineNumber.Dirty
                    || _wholePoc.Dirty
                    || _wholePocPaidByType.Dirty;
            }
            set
            {
                _gfe2010WholePocIndex.Dirty = value;
                _id.Dirty = value;
                _lineNumber.Dirty = value;
                _wholePoc.Dirty = value;
                _wholePocPaidByType.Dirty = value;
            }
        }
    }
}