#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class RegulationZInterestRatePeriod : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _adjustmentDate;
        public DateTime? AdjustmentDate { get => _adjustmentDate; set => _adjustmentDate = value; }
        private DirtyValue<int?> _adjustmentMonths;
        public int? AdjustmentMonths { get => _adjustmentMonths; set => _adjustmentMonths = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _interestPayment;
        public decimal? InterestPayment { get => _interestPayment; set => _interestPayment = value; }
        private DirtyValue<decimal?> _interestPrincipalPayment;
        public decimal? InterestPrincipalPayment { get => _interestPrincipalPayment; set => _interestPrincipalPayment = value; }
        private DirtyValue<decimal?> _interestRatePercent;
        public decimal? InterestRatePercent { get => _interestRatePercent; set => _interestRatePercent = value; }
        private DirtyValue<decimal?> _monthlyPayment;
        public decimal? MonthlyPayment { get => _monthlyPayment; set => _monthlyPayment = value; }
        private DirtyValue<decimal?> _principalPayment;
        public decimal? PrincipalPayment { get => _principalPayment; set => _principalPayment = value; }
        private DirtyValue<string> _regulationZInterestRatePeriodType;
        public string RegulationZInterestRatePeriodType { get => _regulationZInterestRatePeriodType; set => _regulationZInterestRatePeriodType = value; }
        private DirtyValue<decimal?> _taxInsuranceAmount;
        public decimal? TaxInsuranceAmount { get => _taxInsuranceAmount; set => _taxInsuranceAmount = value; }
        private DirtyValue<decimal?> _totalPayment;
        public decimal? TotalPayment { get => _totalPayment; set => _totalPayment = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _adjustmentDate.Dirty
                    || _adjustmentMonths.Dirty
                    || _id.Dirty
                    || _interestPayment.Dirty
                    || _interestPrincipalPayment.Dirty
                    || _interestRatePercent.Dirty
                    || _monthlyPayment.Dirty
                    || _principalPayment.Dirty
                    || _regulationZInterestRatePeriodType.Dirty
                    || _taxInsuranceAmount.Dirty
                    || _totalPayment.Dirty;
            }
            set
            {
                _adjustmentDate.Dirty = value;
                _adjustmentMonths.Dirty = value;
                _id.Dirty = value;
                _interestPayment.Dirty = value;
                _interestPrincipalPayment.Dirty = value;
                _interestRatePercent.Dirty = value;
                _monthlyPayment.Dirty = value;
                _principalPayment.Dirty = value;
                _regulationZInterestRatePeriodType.Dirty = value;
                _taxInsuranceAmount.Dirty = value;
                _totalPayment.Dirty = value;
            }
        }
    }
}