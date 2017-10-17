using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class AffiliatedBusinessArrangement : IDirty
    {
        private DirtyValue<int?> _affiliatedBusinessArrangementIndex;
        public int? AffiliatedBusinessArrangementIndex { get { return _affiliatedBusinessArrangementIndex; } set { _affiliatedBusinessArrangementIndex = value; } }
        private DirtyValue<string> _affiliateName;
        public string AffiliateName { get { return _affiliateName; } set { _affiliateName = value; } }
        private DirtyValue<string> _chargeRangeChargesDescription1;
        public string ChargeRangeChargesDescription1 { get { return _chargeRangeChargesDescription1; } set { _chargeRangeChargesDescription1 = value; } }
        private DirtyValue<string> _chargeRangeChargesDescription2;
        public string ChargeRangeChargesDescription2 { get { return _chargeRangeChargesDescription2; } set { _chargeRangeChargesDescription2 = value; } }
        private DirtyValue<string> _chargeRangeChargesDescription3;
        public string ChargeRangeChargesDescription3 { get { return _chargeRangeChargesDescription3; } set { _chargeRangeChargesDescription3 = value; } }
        private DirtyValue<string> _chargeRangeChargesDescription4;
        public string ChargeRangeChargesDescription4 { get { return _chargeRangeChargesDescription4; } set { _chargeRangeChargesDescription4 = value; } }
        private DirtyValue<string> _chargeRangeChargesDescription5;
        public string ChargeRangeChargesDescription5 { get { return _chargeRangeChargesDescription5; } set { _chargeRangeChargesDescription5 = value; } }
        private DirtyValue<string> _chargeRangeChargesDescription6;
        public string ChargeRangeChargesDescription6 { get { return _chargeRangeChargesDescription6; } set { _chargeRangeChargesDescription6 = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _lenderAddress;
        public string LenderAddress { get { return _lenderAddress; } set { _lenderAddress = value; } }
        private DirtyValue<string> _lenderAddressCity;
        public string LenderAddressCity { get { return _lenderAddressCity; } set { _lenderAddressCity = value; } }
        private DirtyValue<string> _lenderAddressState;
        public string LenderAddressState { get { return _lenderAddressState; } set { _lenderAddressState = value; } }
        private DirtyValue<string> _lenderAddressZipcode;
        public string LenderAddressZipcode { get { return _lenderAddressZipcode; } set { _lenderAddressZipcode = value; } }
        private DirtyValue<string> _lenderName;
        public string LenderName { get { return _lenderName; } set { _lenderName = value; } }
        private DirtyValue<string> _natureOfRelationship;
        public string NatureOfRelationship { get { return _natureOfRelationship; } set { _natureOfRelationship = value; } }
        private DirtyValue<decimal?> _percentOwnershipInterest;
        public decimal? PercentOwnershipInterest { get { return _percentOwnershipInterest; } set { _percentOwnershipInterest = value; } }
        private DirtyValue<bool?> _purchaseSaleRefinanceIndicator;
        public bool? PurchaseSaleRefinanceIndicator { get { return _purchaseSaleRefinanceIndicator; } set { _purchaseSaleRefinanceIndicator = value; } }
        private DirtyValue<bool?> _requiredUseIndicator1;
        public bool? RequiredUseIndicator1 { get { return _requiredUseIndicator1; } set { _requiredUseIndicator1 = value; } }
        private DirtyValue<bool?> _requiredUseIndicator2;
        public bool? RequiredUseIndicator2 { get { return _requiredUseIndicator2; } set { _requiredUseIndicator2 = value; } }
        private DirtyValue<bool?> _requiredUseIndicator3;
        public bool? RequiredUseIndicator3 { get { return _requiredUseIndicator3; } set { _requiredUseIndicator3 = value; } }
        private DirtyValue<bool?> _requiredUseIndicator4;
        public bool? RequiredUseIndicator4 { get { return _requiredUseIndicator4; } set { _requiredUseIndicator4 = value; } }
        private DirtyValue<bool?> _requiredUseIndicator5;
        public bool? RequiredUseIndicator5 { get { return _requiredUseIndicator5; } set { _requiredUseIndicator5 = value; } }
        private DirtyValue<bool?> _requiredUseIndicator6;
        public bool? RequiredUseIndicator6 { get { return _requiredUseIndicator6; } set { _requiredUseIndicator6 = value; } }
        private DirtyValue<string> _serviceDescription1;
        public string ServiceDescription1 { get { return _serviceDescription1; } set { _serviceDescription1 = value; } }
        private DirtyValue<string> _serviceDescription2;
        public string ServiceDescription2 { get { return _serviceDescription2; } set { _serviceDescription2 = value; } }
        private DirtyValue<string> _serviceDescription3;
        public string ServiceDescription3 { get { return _serviceDescription3; } set { _serviceDescription3 = value; } }
        private DirtyValue<string> _serviceDescription4;
        public string ServiceDescription4 { get { return _serviceDescription4; } set { _serviceDescription4 = value; } }
        private DirtyValue<string> _serviceDescription5;
        public string ServiceDescription5 { get { return _serviceDescription5; } set { _serviceDescription5 = value; } }
        private DirtyValue<string> _serviceDescription6;
        public string ServiceDescription6 { get { return _serviceDescription6; } set { _serviceDescription6 = value; } }
        private DirtyValue<bool?> _settlementIndicator;
        public bool? SettlementIndicator { get { return _settlementIndicator; } set { _settlementIndicator = value; } }
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
                var dirty = _affiliatedBusinessArrangementIndex.Dirty
                    || _affiliateName.Dirty
                    || _chargeRangeChargesDescription1.Dirty
                    || _chargeRangeChargesDescription2.Dirty
                    || _chargeRangeChargesDescription3.Dirty
                    || _chargeRangeChargesDescription4.Dirty
                    || _chargeRangeChargesDescription5.Dirty
                    || _chargeRangeChargesDescription6.Dirty
                    || _id.Dirty
                    || _lenderAddress.Dirty
                    || _lenderAddressCity.Dirty
                    || _lenderAddressState.Dirty
                    || _lenderAddressZipcode.Dirty
                    || _lenderName.Dirty
                    || _natureOfRelationship.Dirty
                    || _percentOwnershipInterest.Dirty
                    || _purchaseSaleRefinanceIndicator.Dirty
                    || _requiredUseIndicator1.Dirty
                    || _requiredUseIndicator2.Dirty
                    || _requiredUseIndicator3.Dirty
                    || _requiredUseIndicator4.Dirty
                    || _requiredUseIndicator5.Dirty
                    || _requiredUseIndicator6.Dirty
                    || _serviceDescription1.Dirty
                    || _serviceDescription2.Dirty
                    || _serviceDescription3.Dirty
                    || _serviceDescription4.Dirty
                    || _serviceDescription5.Dirty
                    || _serviceDescription6.Dirty
                    || _settlementIndicator.Dirty
                  || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _affiliatedBusinessArrangementIndex.Dirty = value;
                _affiliateName.Dirty = value;
                _chargeRangeChargesDescription1.Dirty = value;
                _chargeRangeChargesDescription2.Dirty = value;
                _chargeRangeChargesDescription3.Dirty = value;
                _chargeRangeChargesDescription4.Dirty = value;
                _chargeRangeChargesDescription5.Dirty = value;
                _chargeRangeChargesDescription6.Dirty = value;
                _id.Dirty = value;
                _lenderAddress.Dirty = value;
                _lenderAddressCity.Dirty = value;
                _lenderAddressState.Dirty = value;
                _lenderAddressZipcode.Dirty = value;
                _lenderName.Dirty = value;
                _natureOfRelationship.Dirty = value;
                _percentOwnershipInterest.Dirty = value;
                _purchaseSaleRefinanceIndicator.Dirty = value;
                _requiredUseIndicator1.Dirty = value;
                _requiredUseIndicator2.Dirty = value;
                _requiredUseIndicator3.Dirty = value;
                _requiredUseIndicator4.Dirty = value;
                _requiredUseIndicator5.Dirty = value;
                _requiredUseIndicator6.Dirty = value;
                _serviceDescription1.Dirty = value;
                _serviceDescription2.Dirty = value;
                _serviceDescription3.Dirty = value;
                _serviceDescription4.Dirty = value;
                _serviceDescription5.Dirty = value;
                _serviceDescription6.Dirty = value;
                _settlementIndicator.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}