using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// FundingFee
    /// </summary>
    public sealed partial class FundingFee : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _balanceChecked;
        /// <summary>
        /// FundingFee BalanceChecked
        /// </summary>
        public bool? BalanceChecked { get => _balanceChecked; set => _balanceChecked = value; }
        private DirtyValue<string> _cdLineId;
        /// <summary>
        /// FundingFee CdLineId
        /// </summary>
        public string CdLineId { get => _cdLineId; set => _cdLineId = value; }
        private DirtyValue<string> _feeDescription;
        /// <summary>
        /// FundingFee FeeDescription
        /// </summary>
        public string FeeDescription { get => _feeDescription; set => _feeDescription = value; }
        private DirtyValue<string> _feeDescription2015;
        /// <summary>
        /// FundingFee FeeDescription2015
        /// </summary>
        public string FeeDescription2015 { get => _feeDescription2015; set => _feeDescription2015 = value; }
        private DirtyValue<string> _lineId;
        /// <summary>
        /// FundingFee LineId
        /// </summary>
        public string LineId { get => _lineId; set => _lineId = value; }
        private DirtyValue<int?> _lineNumber;
        /// <summary>
        /// FundingFee LineNumber
        /// </summary>
        public int? LineNumber { get => _lineNumber; set => _lineNumber = value; }
        private DirtyValue<string> _paidBy;
        /// <summary>
        /// FundingFee PaidBy
        /// </summary>
        public string PaidBy { get => _paidBy; set => _paidBy = value; }
        private DirtyValue<string> _paidTo;
        /// <summary>
        /// FundingFee PaidTo
        /// </summary>
        public string PaidTo { get => _paidTo; set => _paidTo = value; }
        private DirtyValue<string> _payee;
        /// <summary>
        /// FundingFee Payee
        /// </summary>
        public string Payee { get => _payee; set => _payee = value; }
        private DirtyValue<string> _pocPaidBy;
        /// <summary>
        /// FundingFee PocPaidBy
        /// </summary>
        public string PocPaidBy { get => _pocPaidBy; set => _pocPaidBy = value; }
        private DirtyValue<string> _ptcPaidBy;
        /// <summary>
        /// FundingFee PtcPaidBy
        /// </summary>
        public string PtcPaidBy { get => _ptcPaidBy; set => _ptcPaidBy = value; }
    }
}