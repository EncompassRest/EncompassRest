using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// RespaHudDetail
    /// </summary>
    public sealed partial class RespaHudDetail : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<CreditDebt>> _creditDebt;
        /// <summary>
        /// RespaHudDetail CreditDebt
        /// </summary>
        public StringEnumValue<CreditDebt> CreditDebt { get => _creditDebt; set => _creditDebt = value; }
        private DirtyValue<string> _fWBC;
        /// <summary>
        /// RespaHudDetail FWBC
        /// </summary>
        public string FWBC { get => _fWBC; set => _fWBC = value; }
        private DirtyValue<DateTime?> _hUD1LineItemFromDate;
        /// <summary>
        /// RespaHudDetail HUD1LineItemFromDate
        /// </summary>
        public DateTime? HUD1LineItemFromDate { get => _hUD1LineItemFromDate; set => _hUD1LineItemFromDate = value; }
        private DirtyValue<DateTime?> _hUD1LineItemToDate;
        /// <summary>
        /// RespaHudDetail HUD1LineItemToDate
        /// </summary>
        public DateTime? HUD1LineItemToDate { get => _hUD1LineItemToDate; set => _hUD1LineItemToDate = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// RespaHudDetail Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _lineItemAmount;
        /// <summary>
        /// RespaHudDetail LineItemAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LineItemAmount { get => _lineItemAmount; set => _lineItemAmount = value; }
        private DirtyValue<string> _lineItemDescription;
        /// <summary>
        /// RespaHudDetail LineItemDescription
        /// </summary>
        public string LineItemDescription { get => _lineItemDescription; set => _lineItemDescription = value; }
        private DirtyValue<int?> _lineNumber;
        /// <summary>
        /// RespaHudDetail LineNumber
        /// </summary>
        public int? LineNumber { get => _lineNumber; set => _lineNumber = value; }
        private DirtyValue<decimal?> _realValue;
        /// <summary>
        /// RespaHudDetail RealValue
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? RealValue { get => _realValue; set => _realValue = value; }
        internal override bool DirtyInternal
        {
            get => _creditDebt.Dirty
                || _fWBC.Dirty
                || _hUD1LineItemFromDate.Dirty
                || _hUD1LineItemToDate.Dirty
                || _id.Dirty
                || _lineItemAmount.Dirty
                || _lineItemDescription.Dirty
                || _lineNumber.Dirty
                || _realValue.Dirty;
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