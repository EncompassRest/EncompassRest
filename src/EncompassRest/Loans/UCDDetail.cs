#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class UCDDetail : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<UCDPayoffType>> _feeAccountType;
        public StringEnumValue<UCDPayoffType> FeeAccountType { get => _feeAccountType; set => _feeAccountType = value; }
        private DirtyValue<decimal?> _feeAmount;
        public decimal? FeeAmount { get => _feeAmount; set => _feeAmount = value; }
        private DirtyValue<DateTime?> _feeDateFrom;
        public DateTime? FeeDateFrom { get => _feeDateFrom; set => _feeDateFrom = value; }
        private DirtyValue<DateTime?> _feeDateTo;
        public DateTime? FeeDateTo { get => _feeDateTo; set => _feeDateTo = value; }
        private DirtyValue<string> _feeDesc;
        public string FeeDesc { get => _feeDesc; set => _feeDesc = value; }
        private DirtyValue<int?> _feeIndex;
        public int? FeeIndex { get => _feeIndex; set => _feeIndex = value; }
        private DirtyValue<StringEnumValue<FeePaidBy>> _feePaidBy;
        public StringEnumValue<FeePaidBy> FeePaidBy { get => _feePaidBy; set => _feePaidBy = value; }
        private DirtyValue<string> _feePaidTo;
        public string FeePaidTo { get => _feePaidTo; set => _feePaidTo = value; }
        private DirtyValue<bool?> _feePOC;
        public bool? FeePOC { get => _feePOC; set => _feePOC = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<int?> _lineNumber;
        public int? LineNumber { get => _lineNumber; set => _lineNumber = value; }
        private DirtyValue<string> _section;
        public string Section { get => _section; set => _section = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _feeAccountType.Dirty
                    || _feeAmount.Dirty
                    || _feeDateFrom.Dirty
                    || _feeDateTo.Dirty
                    || _feeDesc.Dirty
                    || _feeIndex.Dirty
                    || _feePaidBy.Dirty
                    || _feePaidTo.Dirty
                    || _feePOC.Dirty
                    || _id.Dirty
                    || _lineNumber.Dirty
                    || _section.Dirty;
            }
            set
            {
                _feeAccountType.Dirty = value;
                _feeAmount.Dirty = value;
                _feeDateFrom.Dirty = value;
                _feeDateTo.Dirty = value;
                _feeDesc.Dirty = value;
                _feeIndex.Dirty = value;
                _feePaidBy.Dirty = value;
                _feePaidTo.Dirty = value;
                _feePOC.Dirty = value;
                _id.Dirty = value;
                _lineNumber.Dirty = value;
                _section.Dirty = value;
            }
        }
    }
}