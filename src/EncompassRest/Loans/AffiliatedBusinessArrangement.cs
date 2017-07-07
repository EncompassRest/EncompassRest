using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class AffiliatedBusinessArrangement : IClean
    {
        private Value<int?> _affiliatedBusinessArrangementIndex;
        public int? AffiliatedBusinessArrangementIndex { get { return _affiliatedBusinessArrangementIndex; } set { _affiliatedBusinessArrangementIndex = value; } }
        private Value<string> _affiliateName;
        public string AffiliateName { get { return _affiliateName; } set { _affiliateName = value; } }
        private Value<string> _chargeRangeChargesDescription1;
        public string ChargeRangeChargesDescription1 { get { return _chargeRangeChargesDescription1; } set { _chargeRangeChargesDescription1 = value; } }
        private Value<string> _chargeRangeChargesDescription2;
        public string ChargeRangeChargesDescription2 { get { return _chargeRangeChargesDescription2; } set { _chargeRangeChargesDescription2 = value; } }
        private Value<string> _chargeRangeChargesDescription3;
        public string ChargeRangeChargesDescription3 { get { return _chargeRangeChargesDescription3; } set { _chargeRangeChargesDescription3 = value; } }
        private Value<string> _chargeRangeChargesDescription4;
        public string ChargeRangeChargesDescription4 { get { return _chargeRangeChargesDescription4; } set { _chargeRangeChargesDescription4 = value; } }
        private Value<string> _chargeRangeChargesDescription5;
        public string ChargeRangeChargesDescription5 { get { return _chargeRangeChargesDescription5; } set { _chargeRangeChargesDescription5 = value; } }
        private Value<string> _chargeRangeChargesDescription6;
        public string ChargeRangeChargesDescription6 { get { return _chargeRangeChargesDescription6; } set { _chargeRangeChargesDescription6 = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _lenderAddress;
        public string LenderAddress { get { return _lenderAddress; } set { _lenderAddress = value; } }
        private Value<string> _lenderAddressCity;
        public string LenderAddressCity { get { return _lenderAddressCity; } set { _lenderAddressCity = value; } }
        private Value<string> _lenderAddressState;
        public string LenderAddressState { get { return _lenderAddressState; } set { _lenderAddressState = value; } }
        private Value<string> _lenderAddressZipcode;
        public string LenderAddressZipcode { get { return _lenderAddressZipcode; } set { _lenderAddressZipcode = value; } }
        private Value<string> _lenderName;
        public string LenderName { get { return _lenderName; } set { _lenderName = value; } }
        private Value<string> _natureOfRelationship;
        public string NatureOfRelationship { get { return _natureOfRelationship; } set { _natureOfRelationship = value; } }
        private Value<decimal?> _percentOwnershipInterest;
        public decimal? PercentOwnershipInterest { get { return _percentOwnershipInterest; } set { _percentOwnershipInterest = value; } }
        private Value<bool?> _purchaseSaleRefinanceIndicator;
        public bool? PurchaseSaleRefinanceIndicator { get { return _purchaseSaleRefinanceIndicator; } set { _purchaseSaleRefinanceIndicator = value; } }
        private Value<bool?> _requiredUseIndicator1;
        public bool? RequiredUseIndicator1 { get { return _requiredUseIndicator1; } set { _requiredUseIndicator1 = value; } }
        private Value<bool?> _requiredUseIndicator2;
        public bool? RequiredUseIndicator2 { get { return _requiredUseIndicator2; } set { _requiredUseIndicator2 = value; } }
        private Value<bool?> _requiredUseIndicator3;
        public bool? RequiredUseIndicator3 { get { return _requiredUseIndicator3; } set { _requiredUseIndicator3 = value; } }
        private Value<bool?> _requiredUseIndicator4;
        public bool? RequiredUseIndicator4 { get { return _requiredUseIndicator4; } set { _requiredUseIndicator4 = value; } }
        private Value<bool?> _requiredUseIndicator5;
        public bool? RequiredUseIndicator5 { get { return _requiredUseIndicator5; } set { _requiredUseIndicator5 = value; } }
        private Value<bool?> _requiredUseIndicator6;
        public bool? RequiredUseIndicator6 { get { return _requiredUseIndicator6; } set { _requiredUseIndicator6 = value; } }
        private Value<string> _serviceDescription1;
        public string ServiceDescription1 { get { return _serviceDescription1; } set { _serviceDescription1 = value; } }
        private Value<string> _serviceDescription2;
        public string ServiceDescription2 { get { return _serviceDescription2; } set { _serviceDescription2 = value; } }
        private Value<string> _serviceDescription3;
        public string ServiceDescription3 { get { return _serviceDescription3; } set { _serviceDescription3 = value; } }
        private Value<string> _serviceDescription4;
        public string ServiceDescription4 { get { return _serviceDescription4; } set { _serviceDescription4 = value; } }
        private Value<string> _serviceDescription5;
        public string ServiceDescription5 { get { return _serviceDescription5; } set { _serviceDescription5 = value; } }
        private Value<string> _serviceDescription6;
        public string ServiceDescription6 { get { return _serviceDescription6; } set { _serviceDescription6 = value; } }
        private Value<bool?> _settlementIndicator;
        public bool? SettlementIndicator { get { return _settlementIndicator; } set { _settlementIndicator = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _affiliatedBusinessArrangementIndex.Clean
                    && _affiliateName.Clean
                    && _chargeRangeChargesDescription1.Clean
                    && _chargeRangeChargesDescription2.Clean
                    && _chargeRangeChargesDescription3.Clean
                    && _chargeRangeChargesDescription4.Clean
                    && _chargeRangeChargesDescription5.Clean
                    && _chargeRangeChargesDescription6.Clean
                    && _id.Clean
                    && _lenderAddress.Clean
                    && _lenderAddressCity.Clean
                    && _lenderAddressState.Clean
                    && _lenderAddressZipcode.Clean
                    && _lenderName.Clean
                    && _natureOfRelationship.Clean
                    && _percentOwnershipInterest.Clean
                    && _purchaseSaleRefinanceIndicator.Clean
                    && _requiredUseIndicator1.Clean
                    && _requiredUseIndicator2.Clean
                    && _requiredUseIndicator3.Clean
                    && _requiredUseIndicator4.Clean
                    && _requiredUseIndicator5.Clean
                    && _requiredUseIndicator6.Clean
                    && _serviceDescription1.Clean
                    && _serviceDescription2.Clean
                    && _serviceDescription3.Clean
                    && _serviceDescription4.Clean
                    && _serviceDescription5.Clean
                    && _serviceDescription6.Clean
                    && _settlementIndicator.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var affiliatedBusinessArrangementIndex = _affiliatedBusinessArrangementIndex; affiliatedBusinessArrangementIndex.Clean = value; _affiliatedBusinessArrangementIndex = affiliatedBusinessArrangementIndex;
                var affiliateName = _affiliateName; affiliateName.Clean = value; _affiliateName = affiliateName;
                var chargeRangeChargesDescription1 = _chargeRangeChargesDescription1; chargeRangeChargesDescription1.Clean = value; _chargeRangeChargesDescription1 = chargeRangeChargesDescription1;
                var chargeRangeChargesDescription2 = _chargeRangeChargesDescription2; chargeRangeChargesDescription2.Clean = value; _chargeRangeChargesDescription2 = chargeRangeChargesDescription2;
                var chargeRangeChargesDescription3 = _chargeRangeChargesDescription3; chargeRangeChargesDescription3.Clean = value; _chargeRangeChargesDescription3 = chargeRangeChargesDescription3;
                var chargeRangeChargesDescription4 = _chargeRangeChargesDescription4; chargeRangeChargesDescription4.Clean = value; _chargeRangeChargesDescription4 = chargeRangeChargesDescription4;
                var chargeRangeChargesDescription5 = _chargeRangeChargesDescription5; chargeRangeChargesDescription5.Clean = value; _chargeRangeChargesDescription5 = chargeRangeChargesDescription5;
                var chargeRangeChargesDescription6 = _chargeRangeChargesDescription6; chargeRangeChargesDescription6.Clean = value; _chargeRangeChargesDescription6 = chargeRangeChargesDescription6;
                var id = _id; id.Clean = value; _id = id;
                var lenderAddress = _lenderAddress; lenderAddress.Clean = value; _lenderAddress = lenderAddress;
                var lenderAddressCity = _lenderAddressCity; lenderAddressCity.Clean = value; _lenderAddressCity = lenderAddressCity;
                var lenderAddressState = _lenderAddressState; lenderAddressState.Clean = value; _lenderAddressState = lenderAddressState;
                var lenderAddressZipcode = _lenderAddressZipcode; lenderAddressZipcode.Clean = value; _lenderAddressZipcode = lenderAddressZipcode;
                var lenderName = _lenderName; lenderName.Clean = value; _lenderName = lenderName;
                var natureOfRelationship = _natureOfRelationship; natureOfRelationship.Clean = value; _natureOfRelationship = natureOfRelationship;
                var percentOwnershipInterest = _percentOwnershipInterest; percentOwnershipInterest.Clean = value; _percentOwnershipInterest = percentOwnershipInterest;
                var purchaseSaleRefinanceIndicator = _purchaseSaleRefinanceIndicator; purchaseSaleRefinanceIndicator.Clean = value; _purchaseSaleRefinanceIndicator = purchaseSaleRefinanceIndicator;
                var requiredUseIndicator1 = _requiredUseIndicator1; requiredUseIndicator1.Clean = value; _requiredUseIndicator1 = requiredUseIndicator1;
                var requiredUseIndicator2 = _requiredUseIndicator2; requiredUseIndicator2.Clean = value; _requiredUseIndicator2 = requiredUseIndicator2;
                var requiredUseIndicator3 = _requiredUseIndicator3; requiredUseIndicator3.Clean = value; _requiredUseIndicator3 = requiredUseIndicator3;
                var requiredUseIndicator4 = _requiredUseIndicator4; requiredUseIndicator4.Clean = value; _requiredUseIndicator4 = requiredUseIndicator4;
                var requiredUseIndicator5 = _requiredUseIndicator5; requiredUseIndicator5.Clean = value; _requiredUseIndicator5 = requiredUseIndicator5;
                var requiredUseIndicator6 = _requiredUseIndicator6; requiredUseIndicator6.Clean = value; _requiredUseIndicator6 = requiredUseIndicator6;
                var serviceDescription1 = _serviceDescription1; serviceDescription1.Clean = value; _serviceDescription1 = serviceDescription1;
                var serviceDescription2 = _serviceDescription2; serviceDescription2.Clean = value; _serviceDescription2 = serviceDescription2;
                var serviceDescription3 = _serviceDescription3; serviceDescription3.Clean = value; _serviceDescription3 = serviceDescription3;
                var serviceDescription4 = _serviceDescription4; serviceDescription4.Clean = value; _serviceDescription4 = serviceDescription4;
                var serviceDescription5 = _serviceDescription5; serviceDescription5.Clean = value; _serviceDescription5 = serviceDescription5;
                var serviceDescription6 = _serviceDescription6; serviceDescription6.Clean = value; _serviceDescription6 = serviceDescription6;
                var settlementIndicator = _settlementIndicator; settlementIndicator.Clean = value; _settlementIndicator = settlementIndicator;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public AffiliatedBusinessArrangement()
        {
            Clean = true;
        }
    }
}