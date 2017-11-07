using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class RegulationZPayment : IDirty
    {
        private DirtyValue<decimal?> _balance;
        public decimal? Balance { get { return _balance; } set { _balance = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _interestRatePercent;
        public decimal? InterestRatePercent { get { return _interestRatePercent; } set { _interestRatePercent = value; } }
        private DirtyValue<decimal?> _monthlyPayment;
        public decimal? MonthlyPayment { get { return _monthlyPayment; } set { _monthlyPayment = value; } }
        private DirtyValue<int?> _numberOfPayments;
        public int? NumberOfPayments { get { return _numberOfPayments; } set { _numberOfPayments = value; } }
        private DirtyValue<DateTime?> _paymentDate;
        public DateTime? PaymentDate { get { return _paymentDate; } set { _paymentDate = value; } }
        private DirtyValue<int?> _regulationZPaymentIndex;
        public int? RegulationZPaymentIndex { get { return _regulationZPaymentIndex; } set { _regulationZPaymentIndex = value; } }
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
                var dirty = _balance.Dirty
                    || _id.Dirty
                    || _interestRatePercent.Dirty
                    || _monthlyPayment.Dirty
                    || _numberOfPayments.Dirty
                    || _paymentDate.Dirty
                    || _regulationZPaymentIndex.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _balance.Dirty = value;
                _id.Dirty = value;
                _interestRatePercent.Dirty = value;
                _monthlyPayment.Dirty = value;
                _numberOfPayments.Dirty = value;
                _paymentDate.Dirty = value;
                _regulationZPaymentIndex.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}