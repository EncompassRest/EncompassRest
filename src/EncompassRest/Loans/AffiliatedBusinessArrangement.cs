#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class AffiliatedBusinessArrangement : ExtensibleObject
    {
        private DirtyValue<int?> _affiliatedBusinessArrangementIndex;
        public int? AffiliatedBusinessArrangementIndex { get => _affiliatedBusinessArrangementIndex; set => _affiliatedBusinessArrangementIndex = value; }
        private DirtyValue<string> _affiliateName;
        public string AffiliateName { get => _affiliateName; set => _affiliateName = value; }
        private DirtyValue<string> _chargeRangeChargesDescription1;
        public string ChargeRangeChargesDescription1 { get => _chargeRangeChargesDescription1; set => _chargeRangeChargesDescription1 = value; }
        private DirtyValue<string> _chargeRangeChargesDescription2;
        public string ChargeRangeChargesDescription2 { get => _chargeRangeChargesDescription2; set => _chargeRangeChargesDescription2 = value; }
        private DirtyValue<string> _chargeRangeChargesDescription3;
        public string ChargeRangeChargesDescription3 { get => _chargeRangeChargesDescription3; set => _chargeRangeChargesDescription3 = value; }
        private DirtyValue<string> _chargeRangeChargesDescription4;
        public string ChargeRangeChargesDescription4 { get => _chargeRangeChargesDescription4; set => _chargeRangeChargesDescription4 = value; }
        private DirtyValue<string> _chargeRangeChargesDescription5;
        public string ChargeRangeChargesDescription5 { get => _chargeRangeChargesDescription5; set => _chargeRangeChargesDescription5 = value; }
        private DirtyValue<string> _chargeRangeChargesDescription6;
        public string ChargeRangeChargesDescription6 { get => _chargeRangeChargesDescription6; set => _chargeRangeChargesDescription6 = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _lenderAddress;
        public string LenderAddress { get => _lenderAddress; set => _lenderAddress = value; }
        private DirtyValue<string> _lenderAddressCity;
        public string LenderAddressCity { get => _lenderAddressCity; set => _lenderAddressCity = value; }
        private DirtyValue<string> _lenderAddressState;
        public string LenderAddressState { get => _lenderAddressState; set => _lenderAddressState = value; }
        private DirtyValue<string> _lenderAddressZipcode;
        public string LenderAddressZipcode { get => _lenderAddressZipcode; set => _lenderAddressZipcode = value; }
        private DirtyValue<string> _lenderName;
        public string LenderName { get => _lenderName; set => _lenderName = value; }
        private DirtyValue<string> _natureOfRelationship;
        public string NatureOfRelationship { get => _natureOfRelationship; set => _natureOfRelationship = value; }
        private DirtyValue<decimal?> _percentOwnershipInterest;
        public decimal? PercentOwnershipInterest { get => _percentOwnershipInterest; set => _percentOwnershipInterest = value; }
        private DirtyValue<bool?> _purchaseSaleRefinanceIndicator;
        public bool? PurchaseSaleRefinanceIndicator { get => _purchaseSaleRefinanceIndicator; set => _purchaseSaleRefinanceIndicator = value; }
        private DirtyValue<bool?> _requiredUseIndicator1;
        public bool? RequiredUseIndicator1 { get => _requiredUseIndicator1; set => _requiredUseIndicator1 = value; }
        private DirtyValue<bool?> _requiredUseIndicator2;
        public bool? RequiredUseIndicator2 { get => _requiredUseIndicator2; set => _requiredUseIndicator2 = value; }
        private DirtyValue<bool?> _requiredUseIndicator3;
        public bool? RequiredUseIndicator3 { get => _requiredUseIndicator3; set => _requiredUseIndicator3 = value; }
        private DirtyValue<bool?> _requiredUseIndicator4;
        public bool? RequiredUseIndicator4 { get => _requiredUseIndicator4; set => _requiredUseIndicator4 = value; }
        private DirtyValue<bool?> _requiredUseIndicator5;
        public bool? RequiredUseIndicator5 { get => _requiredUseIndicator5; set => _requiredUseIndicator5 = value; }
        private DirtyValue<bool?> _requiredUseIndicator6;
        public bool? RequiredUseIndicator6 { get => _requiredUseIndicator6; set => _requiredUseIndicator6 = value; }
        private DirtyValue<string> _serviceDescription1;
        public string ServiceDescription1 { get => _serviceDescription1; set => _serviceDescription1 = value; }
        private DirtyValue<string> _serviceDescription2;
        public string ServiceDescription2 { get => _serviceDescription2; set => _serviceDescription2 = value; }
        private DirtyValue<string> _serviceDescription3;
        public string ServiceDescription3 { get => _serviceDescription3; set => _serviceDescription3 = value; }
        private DirtyValue<string> _serviceDescription4;
        public string ServiceDescription4 { get => _serviceDescription4; set => _serviceDescription4 = value; }
        private DirtyValue<string> _serviceDescription5;
        public string ServiceDescription5 { get => _serviceDescription5; set => _serviceDescription5 = value; }
        private DirtyValue<string> _serviceDescription6;
        public string ServiceDescription6 { get => _serviceDescription6; set => _serviceDescription6 = value; }
        private DirtyValue<bool?> _settlementIndicator;
        public bool? SettlementIndicator { get => _settlementIndicator; set => _settlementIndicator = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _affiliatedBusinessArrangementIndex.Dirty
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
                    || _settlementIndicator.Dirty;
            }
            set
            {
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
            }
        }
    }
}