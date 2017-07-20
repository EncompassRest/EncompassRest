using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ExtraPayment : IClean
    {
        private Value<decimal?> _amount;
        public decimal? Amount { get { return _amount; } set { _amount = value; } }
        private Value<DateTime?> _date;
        public DateTime? Date { get { return _date; } set { _date = value; } }
        private Value<int?> _extraPaymentIndex;
        public int? ExtraPaymentIndex { get { return _extraPaymentIndex; } set { _extraPaymentIndex = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _amount.Clean
                    && _date.Clean
                    && _extraPaymentIndex.Clean
                    && _id.Clean
                    && _lineNumber.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var amount = _amount; amount.Clean = value; _amount = amount;
                var date = _date; date.Clean = value; _date = date;
                var extraPaymentIndex = _extraPaymentIndex; extraPaymentIndex.Clean = value; _extraPaymentIndex = extraPaymentIndex;
                var id = _id; id.Clean = value; _id = id;
                var lineNumber = _lineNumber; lineNumber.Clean = value; _lineNumber = lineNumber;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ExtraPayment()
        {
            Clean = true;
        }
    }
}