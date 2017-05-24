using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class RegulationZInterestRatePeriod
    {
        public Value<DateTime?> AdjustmentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentDate() => !AdjustmentDate.Clean;
        public Value<int?> AdjustmentMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentMonths() => !AdjustmentMonths.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> InterestPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestPayment() => !InterestPayment.Clean;
        public Value<decimal?> InterestPrincipalPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestPrincipalPayment() => !InterestPrincipalPayment.Clean;
        public Value<decimal?> InterestRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRatePercent() => !InterestRatePercent.Clean;
        public Value<decimal?> MonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPayment() => !MonthlyPayment.Clean;
        public Value<decimal?> PrincipalPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrincipalPayment() => !PrincipalPayment.Clean;
        public Value<string> RegulationZInterestRatePeriodType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegulationZInterestRatePeriodType() => !RegulationZInterestRatePeriodType.Clean;
        public Value<decimal?> TaxInsuranceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxInsuranceAmount() => !TaxInsuranceAmount.Clean;
        public Value<decimal?> TotalPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPayment() => !TotalPayment.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AdjustmentDate.Clean
                    && AdjustmentMonths.Clean
                    && Id.Clean
                    && InterestPayment.Clean
                    && InterestPrincipalPayment.Clean
                    && InterestRatePercent.Clean
                    && MonthlyPayment.Clean
                    && PrincipalPayment.Clean
                    && RegulationZInterestRatePeriodType.Clean
                    && TaxInsuranceAmount.Clean
                    && TotalPayment.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AdjustmentDate; v0.Clean = value; AdjustmentDate = v0;
                var v1 = AdjustmentMonths; v1.Clean = value; AdjustmentMonths = v1;
                var v2 = Id; v2.Clean = value; Id = v2;
                var v3 = InterestPayment; v3.Clean = value; InterestPayment = v3;
                var v4 = InterestPrincipalPayment; v4.Clean = value; InterestPrincipalPayment = v4;
                var v5 = InterestRatePercent; v5.Clean = value; InterestRatePercent = v5;
                var v6 = MonthlyPayment; v6.Clean = value; MonthlyPayment = v6;
                var v7 = PrincipalPayment; v7.Clean = value; PrincipalPayment = v7;
                var v8 = RegulationZInterestRatePeriodType; v8.Clean = value; RegulationZInterestRatePeriodType = v8;
                var v9 = TaxInsuranceAmount; v9.Clean = value; TaxInsuranceAmount = v9;
                var v10 = TotalPayment; v10.Clean = value; TotalPayment = v10;
                _settingClean = 0;
            }
        }
    }
}