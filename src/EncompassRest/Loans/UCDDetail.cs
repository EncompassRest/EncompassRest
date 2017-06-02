using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class UCDDetail : IClean
    {
        private Value<string> _feeAccountType;
        public string FeeAccountType { get { return _feeAccountType; } set { _feeAccountType = value; } }
        private Value<decimal?> _feeAmount;
        public decimal? FeeAmount { get { return _feeAmount; } set { _feeAmount = value; } }
        private Value<DateTime?> _feeDateFrom;
        public DateTime? FeeDateFrom { get { return _feeDateFrom; } set { _feeDateFrom = value; } }
        private Value<DateTime?> _feeDateTo;
        public DateTime? FeeDateTo { get { return _feeDateTo; } set { _feeDateTo = value; } }
        private Value<string> _feeDesc;
        public string FeeDesc { get { return _feeDesc; } set { _feeDesc = value; } }
        private Value<int?> _feeIndex;
        public int? FeeIndex { get { return _feeIndex; } set { _feeIndex = value; } }
        private Value<string> _feePaidTo;
        public string FeePaidTo { get { return _feePaidTo; } set { _feePaidTo = value; } }
        private Value<bool?> _feePOC;
        public bool? FeePOC { get { return _feePOC; } set { _feePOC = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
        private Value<string> _section;
        public string Section { get { return _section; } set { _section = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _feeAccountType.Clean
                    && _feeAmount.Clean
                    && _feeDateFrom.Clean
                    && _feeDateTo.Clean
                    && _feeDesc.Clean
                    && _feeIndex.Clean
                    && _feePaidTo.Clean
                    && _feePOC.Clean
                    && _id.Clean
                    && _lineNumber.Clean
                    && _section.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _feeAccountType; v0.Clean = value; _feeAccountType = v0;
                var v1 = _feeAmount; v1.Clean = value; _feeAmount = v1;
                var v2 = _feeDateFrom; v2.Clean = value; _feeDateFrom = v2;
                var v3 = _feeDateTo; v3.Clean = value; _feeDateTo = v3;
                var v4 = _feeDesc; v4.Clean = value; _feeDesc = v4;
                var v5 = _feeIndex; v5.Clean = value; _feeIndex = v5;
                var v6 = _feePaidTo; v6.Clean = value; _feePaidTo = v6;
                var v7 = _feePOC; v7.Clean = value; _feePOC = v7;
                var v8 = _id; v8.Clean = value; _id = v8;
                var v9 = _lineNumber; v9.Clean = value; _lineNumber = v9;
                var v10 = _section; v10.Clean = value; _section = v10;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public UCDDetail()
        {
            Clean = true;
        }
    }
}