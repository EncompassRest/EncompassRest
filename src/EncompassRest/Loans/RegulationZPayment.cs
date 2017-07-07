using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class RegulationZPayment : IClean
    {
        private Value<decimal?> _balance;
        public decimal? Balance { get { return _balance; } set { _balance = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _interestRatePercent;
        public decimal? InterestRatePercent { get { return _interestRatePercent; } set { _interestRatePercent = value; } }
        private Value<decimal?> _monthlyPayment;
        public decimal? MonthlyPayment { get { return _monthlyPayment; } set { _monthlyPayment = value; } }
        private Value<int?> _numberOfPayments;
        public int? NumberOfPayments { get { return _numberOfPayments; } set { _numberOfPayments = value; } }
        private Value<DateTime?> _paymentDate;
        public DateTime? PaymentDate { get { return _paymentDate; } set { _paymentDate = value; } }
        private Value<int?> _regulationZPaymentIndex;
        public int? RegulationZPaymentIndex { get { return _regulationZPaymentIndex; } set { _regulationZPaymentIndex = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _balance.Clean
                    && _id.Clean
                    && _interestRatePercent.Clean
                    && _monthlyPayment.Clean
                    && _numberOfPayments.Clean
                    && _paymentDate.Clean
                    && _regulationZPaymentIndex.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var balance = _balance; balance.Clean = value; _balance = balance;
                var id = _id; id.Clean = value; _id = id;
                var interestRatePercent = _interestRatePercent; interestRatePercent.Clean = value; _interestRatePercent = interestRatePercent;
                var monthlyPayment = _monthlyPayment; monthlyPayment.Clean = value; _monthlyPayment = monthlyPayment;
                var numberOfPayments = _numberOfPayments; numberOfPayments.Clean = value; _numberOfPayments = numberOfPayments;
                var paymentDate = _paymentDate; paymentDate.Clean = value; _paymentDate = paymentDate;
                var regulationZPaymentIndex = _regulationZPaymentIndex; regulationZPaymentIndex.Clean = value; _regulationZPaymentIndex = regulationZPaymentIndex;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public RegulationZPayment()
        {
            Clean = true;
        }
    }
}