using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var fullPrepaymentPenaltyOptionType = _fullPrepaymentPenaltyOptionType; fullPrepaymentPenaltyOptionType.Clean = value; _fullPrepaymentPenaltyOptionType = fullPrepaymentPenaltyOptionType;
                var id = _id; id.Clean = value; _id = id;
                var prepaymentPenaltyPercent = _prepaymentPenaltyPercent; prepaymentPenaltyPercent.Clean = value; _prepaymentPenaltyPercent = prepaymentPenaltyPercent;
                var termMonthsCount = _termMonthsCount; termMonthsCount.Clean = value; _termMonthsCount = termMonthsCount;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public PrepaymentPenalty()
        {
            Clean = true;
        }
    }
}