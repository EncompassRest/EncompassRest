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
                var v0 = _balanceChecked; v0.Clean = value; _balanceChecked = v0;
                var v1 = _cdLineId; v1.Clean = value; _cdLineId = v1;
                var v2 = _feeDescription; v2.Clean = value; _feeDescription = v2;
                var v3 = _feeDescription2015; v3.Clean = value; _feeDescription2015 = v3;
                var v4 = _lineId; v4.Clean = value; _lineId = v4;
                var v5 = _lineNumber; v5.Clean = value; _lineNumber = v5;
                var v6 = _paidBy; v6.Clean = value; _paidBy = v6;
                var v7 = _paidTo; v7.Clean = value; _paidTo = v7;
                var v8 = _payee; v8.Clean = value; _payee = v8;
                var v9 = _pocPaidBy; v9.Clean = value; _pocPaidBy = v9;
                var v10 = _ptcPaidBy; v10.Clean = value; _ptcPaidBy = v10;
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