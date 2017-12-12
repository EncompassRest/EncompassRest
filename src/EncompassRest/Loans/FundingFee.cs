#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class FundingFee : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _balanceChecked;
        public bool? BalanceChecked { get => _balanceChecked; set => _balanceChecked = value; }
        private DirtyValue<string> _cdLineId;
        public string CdLineId { get => _cdLineId; set => _cdLineId = value; }
        private DirtyValue<string> _feeDescription;
        public string FeeDescription { get => _feeDescription; set => _feeDescription = value; }
        private DirtyValue<string> _feeDescription2015;
        public string FeeDescription2015 { get => _feeDescription2015; set => _feeDescription2015 = value; }
        private DirtyValue<string> _lineId;
        public string LineId { get => _lineId; set => _lineId = value; }
        private DirtyValue<int?> _lineNumber;
        public int? LineNumber { get => _lineNumber; set => _lineNumber = value; }
        private DirtyValue<string> _paidBy;
        public string PaidBy { get => _paidBy; set => _paidBy = value; }
        private DirtyValue<string> _paidTo;
        public string PaidTo { get => _paidTo; set => _paidTo = value; }
        private DirtyValue<string> _payee;
        public string Payee { get => _payee; set => _payee = value; }
        private DirtyValue<string> _pocPaidBy;
        public string PocPaidBy { get => _pocPaidBy; set => _pocPaidBy = value; }
        private DirtyValue<string> _ptcPaidBy;
        public string PtcPaidBy { get => _ptcPaidBy; set => _ptcPaidBy = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _balanceChecked.Dirty
                    || _cdLineId.Dirty
                    || _feeDescription.Dirty
                    || _feeDescription2015.Dirty
                    || _lineId.Dirty
                    || _lineNumber.Dirty
                    || _paidBy.Dirty
                    || _paidTo.Dirty
                    || _payee.Dirty
                    || _pocPaidBy.Dirty
                    || _ptcPaidBy.Dirty;
            }
            set
            {
                _balanceChecked.Dirty = value;
                _cdLineId.Dirty = value;
                _feeDescription.Dirty = value;
                _feeDescription2015.Dirty = value;
                _lineId.Dirty = value;
                _lineNumber.Dirty = value;
                _paidBy.Dirty = value;
                _paidTo.Dirty = value;
                _payee.Dirty = value;
                _pocPaidBy.Dirty = value;
                _ptcPaidBy.Dirty = value;
            }
        }
    }
}