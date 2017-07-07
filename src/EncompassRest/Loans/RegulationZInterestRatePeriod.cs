using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class RegulationZInterestRatePeriod : IClean
    {
        private Value<DateTime?> _adjustmentDate;
        public DateTime? AdjustmentDate { get { return _adjustmentDate; } set { _adjustmentDate = value; } }
        private Value<int?> _adjustmentMonths;
        public int? AdjustmentMonths { get { return _adjustmentMonths; } set { _adjustmentMonths = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _interestPayment;
        public decimal? InterestPayment { get { return _interestPayment; } set { _interestPayment = value; } }
        private Value<decimal?> _interestPrincipalPayment;
        public decimal? InterestPrincipalPayment { get { return _interestPrincipalPayment; } set { _interestPrincipalPayment = value; } }
        private Value<decimal?> _interestRatePercent;
        public decimal? InterestRatePercent { get { return _interestRatePercent; } set { _interestRatePercent = value; } }
        private Value<decimal?> _monthlyPayment;
        public decimal? MonthlyPayment { get { return _monthlyPayment; } set { _monthlyPayment = value; } }
        private Value<decimal?> _principalPayment;
        public decimal? PrincipalPayment { get { return _principalPayment; } set { _principalPayment = value; } }
        private Value<string> _regulationZInterestRatePeriodType;
        public string RegulationZInterestRatePeriodType { get { return _regulationZInterestRatePeriodType; } set { _regulationZInterestRatePeriodType = value; } }
        private Value<decimal?> _taxInsuranceAmount;
        public decimal? TaxInsuranceAmount { get { return _taxInsuranceAmount; } set { _taxInsuranceAmount = value; } }
        private Value<decimal?> _totalPayment;
        public decimal? TotalPayment { get { return _totalPayment; } set { _totalPayment = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _adjustmentDate.Clean
                    && _adjustmentMonths.Clean
                    && _id.Clean
                    && _interestPayment.Clean
                    && _interestPrincipalPayment.Clean
                    && _interestRatePercent.Clean
                    && _monthlyPayment.Clean
                    && _principalPayment.Clean
                    && _regulationZInterestRatePeriodType.Clean
                    && _taxInsuranceAmount.Clean
                    && _totalPayment.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var adjustmentDate = _adjustmentDate; adjustmentDate.Clean = value; _adjustmentDate = adjustmentDate;
                var adjustmentMonths = _adjustmentMonths; adjustmentMonths.Clean = value; _adjustmentMonths = adjustmentMonths;
                var id = _id; id.Clean = value; _id = id;
                var interestPayment = _interestPayment; interestPayment.Clean = value; _interestPayment = interestPayment;
                var interestPrincipalPayment = _interestPrincipalPayment; interestPrincipalPayment.Clean = value; _interestPrincipalPayment = interestPrincipalPayment;
                var interestRatePercent = _interestRatePercent; interestRatePercent.Clean = value; _interestRatePercent = interestRatePercent;
                var monthlyPayment = _monthlyPayment; monthlyPayment.Clean = value; _monthlyPayment = monthlyPayment;
                var principalPayment = _principalPayment; principalPayment.Clean = value; _principalPayment = principalPayment;
                var regulationZInterestRatePeriodType = _regulationZInterestRatePeriodType; regulationZInterestRatePeriodType.Clean = value; _regulationZInterestRatePeriodType = regulationZInterestRatePeriodType;
                var taxInsuranceAmount = _taxInsuranceAmount; taxInsuranceAmount.Clean = value; _taxInsuranceAmount = taxInsuranceAmount;
                var totalPayment = _totalPayment; totalPayment.Clean = value; _totalPayment = totalPayment;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public RegulationZInterestRatePeriod()
        {
            Clean = true;
        }
    }
}