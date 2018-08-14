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
        private DirtyValue<decimal?> _amount;
        /// <summary>
        /// FundingFee Amount
        /// </summary>
        public decimal? Amount { get => _amount; set => _amount = value; }
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
        private DirtyValue<decimal?> _pacBroker2015;
        /// <summary>
        /// FundingFee PacBroker2015
        /// </summary>
        public decimal? PacBroker2015 { get => _pacBroker2015; set => _pacBroker2015 = value; }
        private DirtyValue<decimal?> _pacLender2015;
        /// <summary>
        /// FundingFee PacLender2015
        /// </summary>
        public decimal? PacLender2015 { get => _pacLender2015; set => _pacLender2015 = value; }
        private DirtyValue<decimal?> _pacOther2015;
        /// <summary>
        /// FundingFee PacOther2015
        /// </summary>
        public decimal? PacOther2015 { get => _pacOther2015; set => _pacOther2015 = value; }
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
        private DirtyValue<decimal?> _pocAmount;
        /// <summary>
        /// FundingFee PocAmount
        /// </summary>
        public decimal? PocAmount { get => _pocAmount; set => _pocAmount = value; }
        private DirtyValue<decimal?> _pocBorrower2015;
        /// <summary>
        /// FundingFee PocBorrower2015
        /// </summary>
        public decimal? PocBorrower2015 { get => _pocBorrower2015; set => _pocBorrower2015 = value; }
        private DirtyValue<decimal?> _pocBroker2015;
        /// <summary>
        /// FundingFee PocBroker2015
        /// </summary>
        public decimal? PocBroker2015 { get => _pocBroker2015; set => _pocBroker2015 = value; }
        private DirtyValue<decimal?> _pocLender2015;
        /// <summary>
        /// FundingFee PocLender2015
        /// </summary>
        public decimal? PocLender2015 { get => _pocLender2015; set => _pocLender2015 = value; }
        private DirtyValue<decimal?> _pocOther2015;
        /// <summary>
        /// FundingFee PocOther2015
        /// </summary>
        public decimal? PocOther2015 { get => _pocOther2015; set => _pocOther2015 = value; }
        private DirtyValue<string> _pocPaidBy;
        /// <summary>
        /// FundingFee PocPaidBy
        /// </summary>
        public string PocPaidBy { get => _pocPaidBy; set => _pocPaidBy = value; }
        private DirtyValue<decimal?> _pocSeller2015;
        /// <summary>
        /// FundingFee PocSeller2015
        /// </summary>
        public decimal? PocSeller2015 { get => _pocSeller2015; set => _pocSeller2015 = value; }
        private DirtyValue<decimal?> _ptcAmount;
        /// <summary>
        /// FundingFee PtcAmount
        /// </summary>
        public decimal? PtcAmount { get => _ptcAmount; set => _ptcAmount = value; }
        private DirtyValue<string> _ptcPaidBy;
        /// <summary>
        /// FundingFee PtcPaidBy
        /// </summary>
        public string PtcPaidBy { get => _ptcPaidBy; set => _ptcPaidBy = value; }
    }
}