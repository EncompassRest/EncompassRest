using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class DownPayment : IClean
    {
        private Value<decimal?> _amount;
        public decimal? Amount { get { return _amount; } set { _amount = value; } }
        private Value<string> _downPaymentType;
        public string DownPaymentType { get { return _downPaymentType; } set { _downPaymentType = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _sourceDescription;
        public string SourceDescription { get { return _sourceDescription; } set { _sourceDescription = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _amount.Clean
                    && _downPaymentType.Clean
                    && _id.Clean
                    && _sourceDescription.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _amount; v0.Clean = value; _amount = v0;
                var v1 = _downPaymentType; v1.Clean = value; _downPaymentType = v1;
                var v2 = _id; v2.Clean = value; _id = v2;
                var v3 = _sourceDescription; v3.Clean = value; _sourceDescription = v3;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}