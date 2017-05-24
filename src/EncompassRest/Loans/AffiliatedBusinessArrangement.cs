using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class AffiliatedBusinessArrangement
    {
        private Value<int?> _affiliatedBusinessArrangementIndex;
        public int? AffiliatedBusinessArrangementIndex { get { return _affiliatedBusinessArrangementIndex; } set { _affiliatedBusinessArrangementIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAffiliatedBusinessArrangementIndex() => !_affiliatedBusinessArrangementIndex.Clean;
        private Value<string> _affiliateName;
        public string AffiliateName { get { return _affiliateName; } set { _affiliateName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAffiliateName() => !_affiliateName.Clean;
        private Value<string> _chargeRangeChargesDescription1;
        public string ChargeRangeChargesDescription1 { get { return _chargeRangeChargesDescription1; } set { _chargeRangeChargesDescription1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargeRangeChargesDescription1() => !_chargeRangeChargesDescription1.Clean;
        private Value<string> _chargeRangeChargesDescription2;
        public string ChargeRangeChargesDescription2 { get { return _chargeRangeChargesDescription2; } set { _chargeRangeChargesDescription2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargeRangeChargesDescription2() => !_chargeRangeChargesDescription2.Clean;
        private Value<string> _chargeRangeChargesDescription3;
        public string ChargeRangeChargesDescription3 { get { return _chargeRangeChargesDescription3; } set { _chargeRangeChargesDescription3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargeRangeChargesDescription3() => !_chargeRangeChargesDescription3.Clean;
        private Value<string> _chargeRangeChargesDescription4;
        public string ChargeRangeChargesDescription4 { get { return _chargeRangeChargesDescription4; } set { _chargeRangeChargesDescription4 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargeRangeChargesDescription4() => !_chargeRangeChargesDescription4.Clean;
        private Value<string> _chargeRangeChargesDescription5;
        public string ChargeRangeChargesDescription5 { get { return _chargeRangeChargesDescription5; } set { _chargeRangeChargesDescription5 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargeRangeChargesDescription5() => !_chargeRangeChargesDescription5.Clean;
        private Value<string> _chargeRangeChargesDescription6;
        public string ChargeRangeChargesDescription6 { get { return _chargeRangeChargesDescription6; } set { _chargeRangeChargesDescription6 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargeRangeChargesDescription6() => !_chargeRangeChargesDescription6.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _lenderAddress;
        public string LenderAddress { get { return _lenderAddress; } set { _lenderAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAddress() => !_lenderAddress.Clean;
        private Value<string> _lenderAddressCity;
        public string LenderAddressCity { get { return _lenderAddressCity; } set { _lenderAddressCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAddressCity() => !_lenderAddressCity.Clean;
        private Value<string> _lenderAddressState;
        public string LenderAddressState { get { return _lenderAddressState; } set { _lenderAddressState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAddressState() => !_lenderAddressState.Clean;
        private Value<string> _lenderAddressZipcode;
        public string LenderAddressZipcode { get { return _lenderAddressZipcode; } set { _lenderAddressZipcode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAddressZipcode() => !_lenderAddressZipcode.Clean;
        private Value<string> _lenderName;
        public string LenderName { get { return _lenderName; } set { _lenderName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderName() => !_lenderName.Clean;
        private Value<string> _natureOfRelationship;
        public string NatureOfRelationship { get { return _natureOfRelationship; } set { _natureOfRelationship = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNatureOfRelationship() => !_natureOfRelationship.Clean;
        private Value<decimal?> _percentOwnershipInterest;
        public decimal? PercentOwnershipInterest { get { return _percentOwnershipInterest; } set { _percentOwnershipInterest = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentOwnershipInterest() => !_percentOwnershipInterest.Clean;
        private Value<bool?> _purchaseSaleRefinanceIndicator;
        public bool? PurchaseSaleRefinanceIndicator { get { return _purchaseSaleRefinanceIndicator; } set { _purchaseSaleRefinanceIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseSaleRefinanceIndicator() => !_purchaseSaleRefinanceIndicator.Clean;
        private Value<bool?> _requiredUseIndicator1;
        public bool? RequiredUseIndicator1 { get { return _requiredUseIndicator1; } set { _requiredUseIndicator1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredUseIndicator1() => !_requiredUseIndicator1.Clean;
        private Value<bool?> _requiredUseIndicator2;
        public bool? RequiredUseIndicator2 { get { return _requiredUseIndicator2; } set { _requiredUseIndicator2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredUseIndicator2() => !_requiredUseIndicator2.Clean;
        private Value<bool?> _requiredUseIndicator3;
        public bool? RequiredUseIndicator3 { get { return _requiredUseIndicator3; } set { _requiredUseIndicator3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredUseIndicator3() => !_requiredUseIndicator3.Clean;
        private Value<bool?> _requiredUseIndicator4;
        public bool? RequiredUseIndicator4 { get { return _requiredUseIndicator4; } set { _requiredUseIndicator4 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredUseIndicator4() => !_requiredUseIndicator4.Clean;
        private Value<bool?> _requiredUseIndicator5;
        public bool? RequiredUseIndicator5 { get { return _requiredUseIndicator5; } set { _requiredUseIndicator5 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredUseIndicator5() => !_requiredUseIndicator5.Clean;
        private Value<bool?> _requiredUseIndicator6;
        public bool? RequiredUseIndicator6 { get { return _requiredUseIndicator6; } set { _requiredUseIndicator6 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredUseIndicator6() => !_requiredUseIndicator6.Clean;
        private Value<string> _serviceDescription1;
        public string ServiceDescription1 { get { return _serviceDescription1; } set { _serviceDescription1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceDescription1() => !_serviceDescription1.Clean;
        private Value<string> _serviceDescription2;
        public string ServiceDescription2 { get { return _serviceDescription2; } set { _serviceDescription2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceDescription2() => !_serviceDescription2.Clean;
        private Value<string> _serviceDescription3;
        public string ServiceDescription3 { get { return _serviceDescription3; } set { _serviceDescription3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceDescription3() => !_serviceDescription3.Clean;
        private Value<string> _serviceDescription4;
        public string ServiceDescription4 { get { return _serviceDescription4; } set { _serviceDescription4 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceDescription4() => !_serviceDescription4.Clean;
        private Value<string> _serviceDescription5;
        public string ServiceDescription5 { get { return _serviceDescription5; } set { _serviceDescription5 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceDescription5() => !_serviceDescription5.Clean;
        private Value<string> _serviceDescription6;
        public string ServiceDescription6 { get { return _serviceDescription6; } set { _serviceDescription6 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceDescription6() => !_serviceDescription6.Clean;
        private Value<bool?> _settlementIndicator;
        public bool? SettlementIndicator { get { return _settlementIndicator; } set { _settlementIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementIndicator() => !_settlementIndicator.Clean;
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
                var v0 = _affiliatedBusinessArrangementIndex; v0.Clean = value; _affiliatedBusinessArrangementIndex = v0;
                var v1 = _affiliateName; v1.Clean = value; _affiliateName = v1;
                var v2 = _chargeRangeChargesDescription1; v2.Clean = value; _chargeRangeChargesDescription1 = v2;
                var v3 = _chargeRangeChargesDescription2; v3.Clean = value; _chargeRangeChargesDescription2 = v3;
                var v4 = _chargeRangeChargesDescription3; v4.Clean = value; _chargeRangeChargesDescription3 = v4;
                var v5 = _chargeRangeChargesDescription4; v5.Clean = value; _chargeRangeChargesDescription4 = v5;
                var v6 = _chargeRangeChargesDescription5; v6.Clean = value; _chargeRangeChargesDescription5 = v6;
                var v7 = _chargeRangeChargesDescription6; v7.Clean = value; _chargeRangeChargesDescription6 = v7;
                var v8 = _id; v8.Clean = value; _id = v8;
                var v9 = _lenderAddress; v9.Clean = value; _lenderAddress = v9;
                var v10 = _lenderAddressCity; v10.Clean = value; _lenderAddressCity = v10;
                var v11 = _lenderAddressState; v11.Clean = value; _lenderAddressState = v11;
                var v12 = _lenderAddressZipcode; v12.Clean = value; _lenderAddressZipcode = v12;
                var v13 = _lenderName; v13.Clean = value; _lenderName = v13;
                var v14 = _natureOfRelationship; v14.Clean = value; _natureOfRelationship = v14;
                var v15 = _percentOwnershipInterest; v15.Clean = value; _percentOwnershipInterest = v15;
                var v16 = _purchaseSaleRefinanceIndicator; v16.Clean = value; _purchaseSaleRefinanceIndicator = v16;
                var v17 = _requiredUseIndicator1; v17.Clean = value; _requiredUseIndicator1 = v17;
                var v18 = _requiredUseIndicator2; v18.Clean = value; _requiredUseIndicator2 = v18;
                var v19 = _requiredUseIndicator3; v19.Clean = value; _requiredUseIndicator3 = v19;
                var v20 = _requiredUseIndicator4; v20.Clean = value; _requiredUseIndicator4 = v20;
                var v21 = _requiredUseIndicator5; v21.Clean = value; _requiredUseIndicator5 = v21;
                var v22 = _requiredUseIndicator6; v22.Clean = value; _requiredUseIndicator6 = v22;
                var v23 = _serviceDescription1; v23.Clean = value; _serviceDescription1 = v23;
                var v24 = _serviceDescription2; v24.Clean = value; _serviceDescription2 = v24;
                var v25 = _serviceDescription3; v25.Clean = value; _serviceDescription3 = v25;
                var v26 = _serviceDescription4; v26.Clean = value; _serviceDescription4 = v26;
                var v27 = _serviceDescription5; v27.Clean = value; _serviceDescription5 = v27;
                var v28 = _serviceDescription6; v28.Clean = value; _serviceDescription6 = v28;
                var v29 = _settlementIndicator; v29.Clean = value; _settlementIndicator = v29;
                _settingClean = 0;
            }
        }
    }
}