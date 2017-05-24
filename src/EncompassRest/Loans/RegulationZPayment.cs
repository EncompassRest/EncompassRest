using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class RegulationZPayment
    {
        public Value<decimal?> Balance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBalance() => !Balance.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> InterestRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRatePercent() => !InterestRatePercent.Clean;
        public Value<decimal?> MonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPayment() => !MonthlyPayment.Clean;
        public Value<int?> NumberOfPayments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfPayments() => !NumberOfPayments.Clean;
        public Value<DateTime?> PaymentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentDate() => !PaymentDate.Clean;
        public Value<int?> RegulationZPaymentIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegulationZPaymentIndex() => !RegulationZPaymentIndex.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Balance.Clean
                    && Id.Clean
                    && InterestRatePercent.Clean
                    && MonthlyPayment.Clean
                    && NumberOfPayments.Clean
                    && PaymentDate.Clean
                    && RegulationZPaymentIndex.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Balance; v0.Clean = value; Balance = v0;
                var v1 = Id; v1.Clean = value; Id = v1;
                var v2 = InterestRatePercent; v2.Clean = value; InterestRatePercent = v2;
                var v3 = MonthlyPayment; v3.Clean = value; MonthlyPayment = v3;
                var v4 = NumberOfPayments; v4.Clean = value; NumberOfPayments = v4;
                var v5 = PaymentDate; v5.Clean = value; PaymentDate = v5;
                var v6 = RegulationZPaymentIndex; v6.Clean = value; RegulationZPaymentIndex = v6;
                _settingClean = 0;
            }
        }
    }
}