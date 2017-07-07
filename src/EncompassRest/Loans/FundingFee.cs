using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class FundingFee : IClean
    {
        private Value<bool?> _balanceChecked;
        public bool? BalanceChecked { get { return _balanceChecked; } set { _balanceChecked = value; } }
        private Value<string> _cdLineId;
        public string CdLineId { get { return _cdLineId; } set { _cdLineId = value; } }
        private Value<string> _feeDescription;
        public string FeeDescription { get { return _feeDescription; } set { _feeDescription = value; } }
        private Value<string> _feeDescription2015;
        public string FeeDescription2015 { get { return _feeDescription2015; } set { _feeDescription2015 = value; } }
        private Value<string> _lineId;
        public string LineId { get { return _lineId; } set { _lineId = value; } }
        private Value<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
        private Value<string> _paidBy;
        public string PaidBy { get { return _paidBy; } set { _paidBy = value; } }
        private Value<string> _paidTo;
        public string PaidTo { get { return _paidTo; } set { _paidTo = value; } }
        private Value<string> _payee;
        public string Payee { get { return _payee; } set { _payee = value; } }
        private Value<string> _pocPaidBy;
        public string PocPaidBy { get { return _pocPaidBy; } set { _pocPaidBy = value; } }
        private Value<string> _ptcPaidBy;
        public string PtcPaidBy { get { return _ptcPaidBy; } set { _ptcPaidBy = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _balanceChecked.Clean
                    && _cdLineId.Clean
                    && _feeDescription.Clean
                    && _feeDescription2015.Clean
                    && _lineId.Clean
                    && _lineNumber.Clean
                    && _paidBy.Clean
                    && _paidTo.Clean
                    && _payee.Clean
                    && _pocPaidBy.Clean
                    && _ptcPaidBy.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var balanceChecked = _balanceChecked; balanceChecked.Clean = value; _balanceChecked = balanceChecked;
                var cdLineId = _cdLineId; cdLineId.Clean = value; _cdLineId = cdLineId;
                var feeDescription = _feeDescription; feeDescription.Clean = value; _feeDescription = feeDescription;
                var feeDescription2015 = _feeDescription2015; feeDescription2015.Clean = value; _feeDescription2015 = feeDescription2015;
                var lineId = _lineId; lineId.Clean = value; _lineId = lineId;
                var lineNumber = _lineNumber; lineNumber.Clean = value; _lineNumber = lineNumber;
                var paidBy = _paidBy; paidBy.Clean = value; _paidBy = paidBy;
                var paidTo = _paidTo; paidTo.Clean = value; _paidTo = paidTo;
                var payee = _payee; payee.Clean = value; _payee = payee;
                var pocPaidBy = _pocPaidBy; pocPaidBy.Clean = value; _pocPaidBy = pocPaidBy;
                var ptcPaidBy = _ptcPaidBy; ptcPaidBy.Clean = value; _ptcPaidBy = ptcPaidBy;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public FundingFee()
        {
            Clean = true;
        }
    }
}