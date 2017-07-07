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
        private Value<string> _feePaidBy;
        public string FeePaidBy { get { return _feePaidBy; } set { _feePaidBy = value; } }
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
                    && _feePaidBy.Clean
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
                var feeAccountType = _feeAccountType; feeAccountType.Clean = value; _feeAccountType = feeAccountType;
                var feeAmount = _feeAmount; feeAmount.Clean = value; _feeAmount = feeAmount;
                var feeDateFrom = _feeDateFrom; feeDateFrom.Clean = value; _feeDateFrom = feeDateFrom;
                var feeDateTo = _feeDateTo; feeDateTo.Clean = value; _feeDateTo = feeDateTo;
                var feeDesc = _feeDesc; feeDesc.Clean = value; _feeDesc = feeDesc;
                var feeIndex = _feeIndex; feeIndex.Clean = value; _feeIndex = feeIndex;
                var feePaidBy = _feePaidBy; feePaidBy.Clean = value; _feePaidBy = feePaidBy;
                var feePaidTo = _feePaidTo; feePaidTo.Clean = value; _feePaidTo = feePaidTo;
                var feePOC = _feePOC; feePOC.Clean = value; _feePOC = feePOC;
                var id = _id; id.Clean = value; _id = id;
                var lineNumber = _lineNumber; lineNumber.Clean = value; _lineNumber = lineNumber;
                var section = _section; section.Clean = value; _section = section;
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