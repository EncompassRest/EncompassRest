using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class AffiliatedBusinessArrangement
    {
        public Value<int?> AffiliatedBusinessArrangementIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAffiliatedBusinessArrangementIndex() => !AffiliatedBusinessArrangementIndex.Clean;
        public Value<string> AffiliateName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAffiliateName() => !AffiliateName.Clean;
        public Value<string> ChargeRangeChargesDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargeRangeChargesDescription1() => !ChargeRangeChargesDescription1.Clean;
        public Value<string> ChargeRangeChargesDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargeRangeChargesDescription2() => !ChargeRangeChargesDescription2.Clean;
        public Value<string> ChargeRangeChargesDescription3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargeRangeChargesDescription3() => !ChargeRangeChargesDescription3.Clean;
        public Value<string> ChargeRangeChargesDescription4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargeRangeChargesDescription4() => !ChargeRangeChargesDescription4.Clean;
        public Value<string> ChargeRangeChargesDescription5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargeRangeChargesDescription5() => !ChargeRangeChargesDescription5.Clean;
        public Value<string> ChargeRangeChargesDescription6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargeRangeChargesDescription6() => !ChargeRangeChargesDescription6.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> LenderAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAddress() => !LenderAddress.Clean;
        public Value<string> LenderAddressCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAddressCity() => !LenderAddressCity.Clean;
        public Value<string> LenderAddressState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAddressState() => !LenderAddressState.Clean;
        public Value<string> LenderAddressZipcode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAddressZipcode() => !LenderAddressZipcode.Clean;
        public Value<string> LenderName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderName() => !LenderName.Clean;
        public Value<string> NatureOfRelationship { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNatureOfRelationship() => !NatureOfRelationship.Clean;
        public Value<decimal?> PercentOwnershipInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentOwnershipInterest() => !PercentOwnershipInterest.Clean;
        public Value<bool?> PurchaseSaleRefinanceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseSaleRefinanceIndicator() => !PurchaseSaleRefinanceIndicator.Clean;
        public Value<bool?> RequiredUseIndicator1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredUseIndicator1() => !RequiredUseIndicator1.Clean;
        public Value<bool?> RequiredUseIndicator2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredUseIndicator2() => !RequiredUseIndicator2.Clean;
        public Value<bool?> RequiredUseIndicator3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredUseIndicator3() => !RequiredUseIndicator3.Clean;
        public Value<bool?> RequiredUseIndicator4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredUseIndicator4() => !RequiredUseIndicator4.Clean;
        public Value<bool?> RequiredUseIndicator5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredUseIndicator5() => !RequiredUseIndicator5.Clean;
        public Value<bool?> RequiredUseIndicator6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredUseIndicator6() => !RequiredUseIndicator6.Clean;
        public Value<string> ServiceDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceDescription1() => !ServiceDescription1.Clean;
        public Value<string> ServiceDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceDescription2() => !ServiceDescription2.Clean;
        public Value<string> ServiceDescription3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceDescription3() => !ServiceDescription3.Clean;
        public Value<string> ServiceDescription4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceDescription4() => !ServiceDescription4.Clean;
        public Value<string> ServiceDescription5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceDescription5() => !ServiceDescription5.Clean;
        public Value<string> ServiceDescription6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceDescription6() => !ServiceDescription6.Clean;
        public Value<bool?> SettlementIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementIndicator() => !SettlementIndicator.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AffiliatedBusinessArrangementIndex.Clean
                    && AffiliateName.Clean
                    && ChargeRangeChargesDescription1.Clean
                    && ChargeRangeChargesDescription2.Clean
                    && ChargeRangeChargesDescription3.Clean
                    && ChargeRangeChargesDescription4.Clean
                    && ChargeRangeChargesDescription5.Clean
                    && ChargeRangeChargesDescription6.Clean
                    && Id.Clean
                    && LenderAddress.Clean
                    && LenderAddressCity.Clean
                    && LenderAddressState.Clean
                    && LenderAddressZipcode.Clean
                    && LenderName.Clean
                    && NatureOfRelationship.Clean
                    && PercentOwnershipInterest.Clean
                    && PurchaseSaleRefinanceIndicator.Clean
                    && RequiredUseIndicator1.Clean
                    && RequiredUseIndicator2.Clean
                    && RequiredUseIndicator3.Clean
                    && RequiredUseIndicator4.Clean
                    && RequiredUseIndicator5.Clean
                    && RequiredUseIndicator6.Clean
                    && ServiceDescription1.Clean
                    && ServiceDescription2.Clean
                    && ServiceDescription3.Clean
                    && ServiceDescription4.Clean
                    && ServiceDescription5.Clean
                    && ServiceDescription6.Clean
                    && SettlementIndicator.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AffiliatedBusinessArrangementIndex; v0.Clean = value; AffiliatedBusinessArrangementIndex = v0;
                var v1 = AffiliateName; v1.Clean = value; AffiliateName = v1;
                var v2 = ChargeRangeChargesDescription1; v2.Clean = value; ChargeRangeChargesDescription1 = v2;
                var v3 = ChargeRangeChargesDescription2; v3.Clean = value; ChargeRangeChargesDescription2 = v3;
                var v4 = ChargeRangeChargesDescription3; v4.Clean = value; ChargeRangeChargesDescription3 = v4;
                var v5 = ChargeRangeChargesDescription4; v5.Clean = value; ChargeRangeChargesDescription4 = v5;
                var v6 = ChargeRangeChargesDescription5; v6.Clean = value; ChargeRangeChargesDescription5 = v6;
                var v7 = ChargeRangeChargesDescription6; v7.Clean = value; ChargeRangeChargesDescription6 = v7;
                var v8 = Id; v8.Clean = value; Id = v8;
                var v9 = LenderAddress; v9.Clean = value; LenderAddress = v9;
                var v10 = LenderAddressCity; v10.Clean = value; LenderAddressCity = v10;
                var v11 = LenderAddressState; v11.Clean = value; LenderAddressState = v11;
                var v12 = LenderAddressZipcode; v12.Clean = value; LenderAddressZipcode = v12;
                var v13 = LenderName; v13.Clean = value; LenderName = v13;
                var v14 = NatureOfRelationship; v14.Clean = value; NatureOfRelationship = v14;
                var v15 = PercentOwnershipInterest; v15.Clean = value; PercentOwnershipInterest = v15;
                var v16 = PurchaseSaleRefinanceIndicator; v16.Clean = value; PurchaseSaleRefinanceIndicator = v16;
                var v17 = RequiredUseIndicator1; v17.Clean = value; RequiredUseIndicator1 = v17;
                var v18 = RequiredUseIndicator2; v18.Clean = value; RequiredUseIndicator2 = v18;
                var v19 = RequiredUseIndicator3; v19.Clean = value; RequiredUseIndicator3 = v19;
                var v20 = RequiredUseIndicator4; v20.Clean = value; RequiredUseIndicator4 = v20;
                var v21 = RequiredUseIndicator5; v21.Clean = value; RequiredUseIndicator5 = v21;
                var v22 = RequiredUseIndicator6; v22.Clean = value; RequiredUseIndicator6 = v22;
                var v23 = ServiceDescription1; v23.Clean = value; ServiceDescription1 = v23;
                var v24 = ServiceDescription2; v24.Clean = value; ServiceDescription2 = v24;
                var v25 = ServiceDescription3; v25.Clean = value; ServiceDescription3 = v25;
                var v26 = ServiceDescription4; v26.Clean = value; ServiceDescription4 = v26;
                var v27 = ServiceDescription5; v27.Clean = value; ServiceDescription5 = v27;
                var v28 = ServiceDescription6; v28.Clean = value; ServiceDescription6 = v28;
                var v29 = SettlementIndicator; v29.Clean = value; SettlementIndicator = v29;
                _settingClean = 0;
            }
        }
    }
}