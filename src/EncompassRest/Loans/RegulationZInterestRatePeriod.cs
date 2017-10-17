using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class RegulationZInterestRatePeriod : IDirty
    {
        private DirtyValue<DateTime?> _adjustmentDate;
        public DateTime? AdjustmentDate { get { return _adjustmentDate; } set { _adjustmentDate = value; } }
        private DirtyValue<int?> _adjustmentMonths;
        public int? AdjustmentMonths { get { return _adjustmentMonths; } set { _adjustmentMonths = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _interestPayment;
        public decimal? InterestPayment { get { return _interestPayment; } set { _interestPayment = value; } }
        private DirtyValue<decimal?> _interestPrincipalPayment;
        public decimal? InterestPrincipalPayment { get { return _interestPrincipalPayment; } set { _interestPrincipalPayment = value; } }
        private DirtyValue<decimal?> _interestRatePercent;
        public decimal? InterestRatePercent { get { return _interestRatePercent; } set { _interestRatePercent = value; } }
        private DirtyValue<decimal?> _monthlyPayment;
        public decimal? MonthlyPayment { get { return _monthlyPayment; } set { _monthlyPayment = value; } }
        private DirtyValue<decimal?> _principalPayment;
        public decimal? PrincipalPayment { get { return _principalPayment; } set { _principalPayment = value; } }
        private DirtyValue<string> _regulationZInterestRatePeriodType;
        public string RegulationZInterestRatePeriodType { get { return _regulationZInterestRatePeriodType; } set { _regulationZInterestRatePeriodType = value; } }
        private DirtyValue<decimal?> _taxInsuranceAmount;
        public decimal? TaxInsuranceAmount { get { return _taxInsuranceAmount; } set { _taxInsuranceAmount = value; } }
        private DirtyValue<decimal?> _totalPayment;
        public decimal? TotalPayment { get { return _totalPayment; } set { _totalPayment = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _adjustmentDate.Dirty
                    || _adjustmentMonths.Dirty
                    || _id.Dirty
                    || _interestPayment.Dirty
                    || _interestPrincipalPayment.Dirty
                    || _interestRatePercent.Dirty
                    || _monthlyPayment.Dirty
                    || _principalPayment.Dirty
                    || _regulationZInterestRatePeriodType.Dirty
                    || _taxInsuranceAmount.Dirty
                    || _totalPayment.Dirty
                  || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}