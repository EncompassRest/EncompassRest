using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class HelocRepaymentDrawPeriod : IClean
    {
        private Value<decimal?> _apr;
        public decimal? Apr { get { return _apr; } set { _apr = value; } }
        private Value<bool?> _drawIndicator;
        public bool? DrawIndicator { get { return _drawIndicator; } set { _drawIndicator = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _indexRatePercent;
        public decimal? IndexRatePercent { get { return _indexRatePercent; } set { _indexRatePercent = value; } }
        private Value<decimal?> _marginRatePercent;
        public decimal? MarginRatePercent { get { return _marginRatePercent; } set { _marginRatePercent = value; } }
        private Value<decimal?> _minimumMonthlyPaymentAmount;
        public decimal? MinimumMonthlyPaymentAmount { get { return _minimumMonthlyPaymentAmount; } set { _minimumMonthlyPaymentAmount = value; } }
        private Value<int?> _year;
        public int? Year { get { return _year; } set { _year = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _apr.Clean
                    && _drawIndicator.Clean
                    && _id.Clean
                    && _indexRatePercent.Clean
                    && _marginRatePercent.Clean
                    && _minimumMonthlyPaymentAmount.Clean
                    && _year.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var apr = _apr; apr.Clean = value; _apr = apr;
                var drawIndicator = _drawIndicator; drawIndicator.Clean = value; _drawIndicator = drawIndicator;
                var id = _id; id.Clean = value; _id = id;
                var indexRatePercent = _indexRatePercent; indexRatePercent.Clean = value; _indexRatePercent = indexRatePercent;
                var marginRatePercent = _marginRatePercent; marginRatePercent.Clean = value; _marginRatePercent = marginRatePercent;
                var minimumMonthlyPaymentAmount = _minimumMonthlyPaymentAmount; minimumMonthlyPaymentAmount.Clean = value; _minimumMonthlyPaymentAmount = minimumMonthlyPaymentAmount;
                var year = _year; year.Clean = value; _year = year;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public HelocRepaymentDrawPeriod()
        {
            Clean = true;
        }
    }
}