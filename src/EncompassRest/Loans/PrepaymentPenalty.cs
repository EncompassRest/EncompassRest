using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PrepaymentPenalty : IClean
    {
        private Value<string> _fullPrepaymentPenaltyOptionType;
        public string FullPrepaymentPenaltyOptionType { get { return _fullPrepaymentPenaltyOptionType; } set { _fullPrepaymentPenaltyOptionType = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _prepaymentPenaltyPercent;
        public decimal? PrepaymentPenaltyPercent { get { return _prepaymentPenaltyPercent; } set { _prepaymentPenaltyPercent = value; } }
        private Value<int?> _termMonthsCount;
        public int? TermMonthsCount { get { return _termMonthsCount; } set { _termMonthsCount = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _fullPrepaymentPenaltyOptionType.Clean
                    && _id.Clean
                    && _prepaymentPenaltyPercent.Clean
                    && _termMonthsCount.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _fullPrepaymentPenaltyOptionType; v0.Clean = value; _fullPrepaymentPenaltyOptionType = v0;
                var v1 = _id; v1.Clean = value; _id = v1;
                var v2 = _prepaymentPenaltyPercent; v2.Clean = value; _prepaymentPenaltyPercent = v2;
                var v3 = _termMonthsCount; v3.Clean = value; _termMonthsCount = v3;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}