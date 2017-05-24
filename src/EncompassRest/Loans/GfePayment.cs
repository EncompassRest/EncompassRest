using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class GfePayment
    {
        public Value<decimal?> FixedRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFixedRate() => !FixedRate.Clean;
        public Value<int?> GfePaymentIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfePaymentIndex() => !GfePaymentIndex.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> IndexRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIndexRate() => !IndexRate.Clean;
        public Value<string> IsBalanceReduced { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsBalanceReduced() => !IsBalanceReduced.Clean;
        public Value<string> LoanTypeExplanation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanTypeExplanation() => !LoanTypeExplanation.Clean;
        public Value<decimal?> MarginRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMarginRate() => !MarginRate.Clean;
        public Value<decimal?> MaximumDifference { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumDifference() => !MaximumDifference.Clean;
        public Value<decimal?> MaximumRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumRate() => !MaximumRate.Clean;
        public Value<decimal?> MinimumDifference { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumDifference() => !MinimumDifference.Clean;
        public Value<decimal?> MinimumMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumMonthlyPayment() => !MinimumMonthlyPayment.Clean;
        public Value<decimal?> MonthlyPaymentYear1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPaymentYear1() => !MonthlyPaymentYear1.Clean;
        public Value<decimal?> MonthlyPaymentYear6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPaymentYear6() => !MonthlyPaymentYear6.Clean;
        public Value<decimal?> MonthlyPaymentYear6Change { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPaymentYear6Change() => !MonthlyPaymentYear6Change.Clean;
        public Value<decimal?> MonthlyPaymentYear6MaxChange { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPaymentYear6MaxChange() => !MonthlyPaymentYear6MaxChange.Clean;
        public Value<bool?> NotOfferedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNotOfferedIndicator() => !NotOfferedIndicator.Clean;
        public Value<decimal?> OwedAfter5Years { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOwedAfter5Years() => !OwedAfter5Years.Clean;
        public Value<decimal?> RateInMonth2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateInMonth2() => !RateInMonth2.Clean;
        public Value<decimal?> ReducedLoanBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReducedLoanBalance() => !ReducedLoanBalance.Clean;
        public Value<string> ReducedStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReducedStatus() => !ReducedStatus.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = FixedRate.Clean
                    && GfePaymentIndex.Clean
                    && Id.Clean
                    && IndexRate.Clean
                    && IsBalanceReduced.Clean
                    && LoanTypeExplanation.Clean
                    && MarginRate.Clean
                    && MaximumDifference.Clean
                    && MaximumRate.Clean
                    && MinimumDifference.Clean
                    && MinimumMonthlyPayment.Clean
                    && MonthlyPaymentYear1.Clean
                    && MonthlyPaymentYear6.Clean
                    && MonthlyPaymentYear6Change.Clean
                    && MonthlyPaymentYear6MaxChange.Clean
                    && NotOfferedIndicator.Clean
                    && OwedAfter5Years.Clean
                    && RateInMonth2.Clean
                    && ReducedLoanBalance.Clean
                    && ReducedStatus.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = FixedRate; v0.Clean = value; FixedRate = v0;
                var v1 = GfePaymentIndex; v1.Clean = value; GfePaymentIndex = v1;
                var v2 = Id; v2.Clean = value; Id = v2;
                var v3 = IndexRate; v3.Clean = value; IndexRate = v3;
                var v4 = IsBalanceReduced; v4.Clean = value; IsBalanceReduced = v4;
                var v5 = LoanTypeExplanation; v5.Clean = value; LoanTypeExplanation = v5;
                var v6 = MarginRate; v6.Clean = value; MarginRate = v6;
                var v7 = MaximumDifference; v7.Clean = value; MaximumDifference = v7;
                var v8 = MaximumRate; v8.Clean = value; MaximumRate = v8;
                var v9 = MinimumDifference; v9.Clean = value; MinimumDifference = v9;
                var v10 = MinimumMonthlyPayment; v10.Clean = value; MinimumMonthlyPayment = v10;
                var v11 = MonthlyPaymentYear1; v11.Clean = value; MonthlyPaymentYear1 = v11;
                var v12 = MonthlyPaymentYear6; v12.Clean = value; MonthlyPaymentYear6 = v12;
                var v13 = MonthlyPaymentYear6Change; v13.Clean = value; MonthlyPaymentYear6Change = v13;
                var v14 = MonthlyPaymentYear6MaxChange; v14.Clean = value; MonthlyPaymentYear6MaxChange = v14;
                var v15 = NotOfferedIndicator; v15.Clean = value; NotOfferedIndicator = v15;
                var v16 = OwedAfter5Years; v16.Clean = value; OwedAfter5Years = v16;
                var v17 = RateInMonth2; v17.Clean = value; RateInMonth2 = v17;
                var v18 = ReducedLoanBalance; v18.Clean = value; ReducedLoanBalance = v18;
                var v19 = ReducedStatus; v19.Clean = value; ReducedStatus = v19;
                _settingClean = 0;
            }
        }
    }
}