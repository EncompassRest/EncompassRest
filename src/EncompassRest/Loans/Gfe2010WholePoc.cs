using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010WholePoc : IClean
    {
        private Value<int?> _gfe2010WholePocIndex;
        public int? Gfe2010WholePocIndex { get { return _gfe2010WholePocIndex; } set { _gfe2010WholePocIndex = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
        private Value<decimal?> _wholePoc;
        public decimal? WholePoc { get { return _wholePoc; } set { _wholePoc = value; } }
        private Value<string> _wholePocPaidByType;
        public string WholePocPaidByType { get { return _wholePocPaidByType; } set { _wholePocPaidByType = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _gfe2010WholePocIndex.Clean
                    && _id.Clean
                    && _lineNumber.Clean
                    && _wholePoc.Clean
                    && _wholePocPaidByType.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _gfe2010WholePocIndex; v0.Clean = value; _gfe2010WholePocIndex = v0;
                var v1 = _id; v1.Clean = value; _id = v1;
                var v2 = _lineNumber; v2.Clean = value; _lineNumber = v2;
                var v3 = _wholePoc; v3.Clean = value; _wholePoc = v3;
                var v4 = _wholePocPaidByType; v4.Clean = value; _wholePocPaidByType = v4;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}