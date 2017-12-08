#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class RespaHudDetail : ExtensibleObject
    {
        private DirtyValue<StringEnumValue<CreditDebt>> _creditDebt;
        public StringEnumValue<CreditDebt> CreditDebt { get => _creditDebt; set => _creditDebt = value; }
        private DirtyValue<string> _fWBC;
        public string FWBC { get => _fWBC; set => _fWBC = value; }
        private DirtyValue<DateTime?> _hUD1LineItemFromDate;
        public DateTime? HUD1LineItemFromDate { get => _hUD1LineItemFromDate; set => _hUD1LineItemFromDate = value; }
        private DirtyValue<DateTime?> _hUD1LineItemToDate;
        public DateTime? HUD1LineItemToDate { get => _hUD1LineItemToDate; set => _hUD1LineItemToDate = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _lineItemAmount;
        public decimal? LineItemAmount { get => _lineItemAmount; set => _lineItemAmount = value; }
        private DirtyValue<string> _lineItemDescription;
        public string LineItemDescription { get => _lineItemDescription; set => _lineItemDescription = value; }
        private DirtyValue<int?> _lineNumber;
        public int? LineNumber { get => _lineNumber; set => _lineNumber = value; }
        private DirtyValue<decimal?> _realValue;
        public decimal? RealValue { get => _realValue; set => _realValue = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _creditDebt.Dirty
                    || _fWBC.Dirty
                    || _hUD1LineItemFromDate.Dirty
                    || _hUD1LineItemToDate.Dirty
                    || _id.Dirty
                    || _lineItemAmount.Dirty
                    || _lineItemDescription.Dirty
                    || _lineNumber.Dirty
                    || _realValue.Dirty;
            }
            set
            {
                _creditDebt.Dirty = value;
                _fWBC.Dirty = value;
                _hUD1LineItemFromDate.Dirty = value;
                _hUD1LineItemToDate.Dirty = value;
                _id.Dirty = value;
                _lineItemAmount.Dirty = value;
                _lineItemDescription.Dirty = value;
                _lineNumber.Dirty = value;
                _realValue.Dirty = value;
            }
        }
    }
}