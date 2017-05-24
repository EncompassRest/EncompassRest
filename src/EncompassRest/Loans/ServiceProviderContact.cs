using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ServiceProviderContact
    {
        public Value<string> Address { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddress() => !Address.Clean;
        public Value<string> City { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCity() => !City.Clean;
        public Value<string> ContactName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactName() => !ContactName.Clean;
        public Value<decimal?> Cost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCost() => !Cost.Clean;
        public Value<string> Email { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmail() => !Email.Clean;
        public Value<string> Fax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFax() => !Fax.Clean;
        public Value<decimal?> FeeAmt1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt1() => !FeeAmt1.Clean;
        public Value<decimal?> FeeAmt10 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt10() => !FeeAmt10.Clean;
        public Value<decimal?> FeeAmt2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt2() => !FeeAmt2.Clean;
        public Value<decimal?> FeeAmt3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt3() => !FeeAmt3.Clean;
        public Value<decimal?> FeeAmt4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt4() => !FeeAmt4.Clean;
        public Value<decimal?> FeeAmt5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt5() => !FeeAmt5.Clean;
        public Value<decimal?> FeeAmt6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt6() => !FeeAmt6.Clean;
        public Value<decimal?> FeeAmt7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt7() => !FeeAmt7.Clean;
        public Value<decimal?> FeeAmt8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt8() => !FeeAmt8.Clean;
        public Value<decimal?> FeeAmt9 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmt9() => !FeeAmt9.Clean;
        public Value<string> FeeDesc1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc1() => !FeeDesc1.Clean;
        public Value<string> FeeDesc10 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc10() => !FeeDesc10.Clean;
        public Value<string> FeeDesc2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc2() => !FeeDesc2.Clean;
        public Value<string> FeeDesc3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc3() => !FeeDesc3.Clean;
        public Value<string> FeeDesc4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc4() => !FeeDesc4.Clean;
        public Value<string> FeeDesc5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc5() => !FeeDesc5.Clean;
        public Value<string> FeeDesc6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc6() => !FeeDesc6.Clean;
        public Value<string> FeeDesc7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc7() => !FeeDesc7.Clean;
        public Value<string> FeeDesc8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc8() => !FeeDesc8.Clean;
        public Value<string> FeeDesc9 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc9() => !FeeDesc9.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> LineItemNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineItemNumber() => !LineItemNumber.Clean;
        public Value<string> Phone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhone() => !Phone.Clean;
        public Value<string> PostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePostalCode() => !PostalCode.Clean;
        public Value<int?> ProviderIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProviderIndex() => !ProviderIndex.Clean;
        public Value<string> ProviderName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProviderName() => !ProviderName.Clean;
        public Value<string> Relationship { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelationship() => !Relationship.Clean;
        public Value<string> ServiceProvided { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceProvided() => !ServiceProvided.Clean;
        public Value<string> ServiceProviderId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceProviderId() => !ServiceProviderId.Clean;
        public Value<string> ServiceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceType() => !ServiceType.Clean;
        public Value<bool?> ShopFor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeShopFor() => !ShopFor.Clean;
        public Value<string> State { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeState() => !State.Clean;
        public Value<string> WebUrl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWebUrl() => !WebUrl.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Address.Clean
                    && City.Clean
                    && ContactName.Clean
                    && Cost.Clean
                    && Email.Clean
                    && Fax.Clean
                    && FeeAmt1.Clean
                    && FeeAmt10.Clean
                    && FeeAmt2.Clean
                    && FeeAmt3.Clean
                    && FeeAmt4.Clean
                    && FeeAmt5.Clean
                    && FeeAmt6.Clean
                    && FeeAmt7.Clean
                    && FeeAmt8.Clean
                    && FeeAmt9.Clean
                    && FeeDesc1.Clean
                    && FeeDesc10.Clean
                    && FeeDesc2.Clean
                    && FeeDesc3.Clean
                    && FeeDesc4.Clean
                    && FeeDesc5.Clean
                    && FeeDesc6.Clean
                    && FeeDesc7.Clean
                    && FeeDesc8.Clean
                    && FeeDesc9.Clean
                    && Id.Clean
                    && LineItemNumber.Clean
                    && Phone.Clean
                    && PostalCode.Clean
                    && ProviderIndex.Clean
                    && ProviderName.Clean
                    && Relationship.Clean
                    && ServiceProvided.Clean
                    && ServiceProviderId.Clean
                    && ServiceType.Clean
                    && ShopFor.Clean
                    && State.Clean
                    && WebUrl.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Address; v0.Clean = value; Address = v0;
                var v1 = City; v1.Clean = value; City = v1;
                var v2 = ContactName; v2.Clean = value; ContactName = v2;
                var v3 = Cost; v3.Clean = value; Cost = v3;
                var v4 = Email; v4.Clean = value; Email = v4;
                var v5 = Fax; v5.Clean = value; Fax = v5;
                var v6 = FeeAmt1; v6.Clean = value; FeeAmt1 = v6;
                var v7 = FeeAmt10; v7.Clean = value; FeeAmt10 = v7;
                var v8 = FeeAmt2; v8.Clean = value; FeeAmt2 = v8;
                var v9 = FeeAmt3; v9.Clean = value; FeeAmt3 = v9;
                var v10 = FeeAmt4; v10.Clean = value; FeeAmt4 = v10;
                var v11 = FeeAmt5; v11.Clean = value; FeeAmt5 = v11;
                var v12 = FeeAmt6; v12.Clean = value; FeeAmt6 = v12;
                var v13 = FeeAmt7; v13.Clean = value; FeeAmt7 = v13;
                var v14 = FeeAmt8; v14.Clean = value; FeeAmt8 = v14;
                var v15 = FeeAmt9; v15.Clean = value; FeeAmt9 = v15;
                var v16 = FeeDesc1; v16.Clean = value; FeeDesc1 = v16;
                var v17 = FeeDesc10; v17.Clean = value; FeeDesc10 = v17;
                var v18 = FeeDesc2; v18.Clean = value; FeeDesc2 = v18;
                var v19 = FeeDesc3; v19.Clean = value; FeeDesc3 = v19;
                var v20 = FeeDesc4; v20.Clean = value; FeeDesc4 = v20;
                var v21 = FeeDesc5; v21.Clean = value; FeeDesc5 = v21;
                var v22 = FeeDesc6; v22.Clean = value; FeeDesc6 = v22;
                var v23 = FeeDesc7; v23.Clean = value; FeeDesc7 = v23;
                var v24 = FeeDesc8; v24.Clean = value; FeeDesc8 = v24;
                var v25 = FeeDesc9; v25.Clean = value; FeeDesc9 = v25;
                var v26 = Id; v26.Clean = value; Id = v26;
                var v27 = LineItemNumber; v27.Clean = value; LineItemNumber = v27;
                var v28 = Phone; v28.Clean = value; Phone = v28;
                var v29 = PostalCode; v29.Clean = value; PostalCode = v29;
                var v30 = ProviderIndex; v30.Clean = value; ProviderIndex = v30;
                var v31 = ProviderName; v31.Clean = value; ProviderName = v31;
                var v32 = Relationship; v32.Clean = value; Relationship = v32;
                var v33 = ServiceProvided; v33.Clean = value; ServiceProvided = v33;
                var v34 = ServiceProviderId; v34.Clean = value; ServiceProviderId = v34;
                var v35 = ServiceType; v35.Clean = value; ServiceType = v35;
                var v36 = ShopFor; v36.Clean = value; ShopFor = v36;
                var v37 = State; v37.Clean = value; State = v37;
                var v38 = WebUrl; v38.Clean = value; WebUrl = v38;
                _settingClean = 0;
            }
        }
    }
}